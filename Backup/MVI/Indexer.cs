
//
//	Description:	This is the main class for the indexing library and contains
//                all of the public accessible methods
//	Created by:    Brian E Harvey 	 
//	
//	Created on 12/08/2006.  Copyright 2007 CNO Services, LLC.  
//	This software and its associated documentation are copyrighted
//	works protected by the United States Copyright Act and the 
//	Berne Convention.
//				
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Data;
using System.Text;
using System.Xml;
using System.Drawing;
//using BPA.Framework;
using CNO.BPA.DataHandler;

namespace CNO.BPA.MVI
{
   [ComVisible(true)]
   [ClassInterface(ClassInterfaceType.AutoDual)]
   [GuidAttribute("42923090-D159-4a66-915F-681A5E04B5CD")]
   public class Indexer
   {
      #region Variables
      private string _applicationData = null;

      DataAccess _dataAccess = new DataAccess();



      #endregion

      #region Constructors
      public Indexer()
      {
         //locate the app data folder
         _applicationData = Environment.GetFolderPath
            (Environment.SpecialFolder.ApplicationData);
      }
      #endregion

      #region Public Methods
      public void direct2Workflow(ref CommonParameters CP)
      {
         if (CP.IndexType == "AWD")
         //for direct2workflow we create a source and a transacton
         {
            _dataAccess.getXrefValues(ref CP);
            CP.AWDSourceID = 0;
            CP.AWDTranID = 0;
            CP.AWDCaseID = -1;

         }

         writeRecord(ref CP);
      }
      public void launchSPIndex(ref CommonParameters CP)
      {
         if (CP.PolicyNo != "")
         {
            using (frmSelectPerson formSP = new frmSelectPerson(ref CP))
            {
               //populate mvi tables
               _dataAccess.getMVIFieldData(ref CP);

               //let the form populate the grid
               formSP.populateGrid();
               //setup a return from the dialog
               System.Windows.Forms.DialogResult dRes = formSP.ShowDialog();
               //let's assume that whoever launched the index screen and then closed it out
               //was the index operator for this item
               if (null != System.Environment.UserName)
               {
                  CP.IndexOperator = System.Environment.UserName.ToString().ToUpper();
               }
               //now we can check the results of the dialog
               switch (dRes)
               {
                  case System.Windows.Forms.DialogResult.OK:

                     //make sure dates are formatted YYYY/MM/DD HH24:MM:SS
                     formatDateFields(ref CP);
                     //and then send the data to the db
                     foreach (WorkItem wi in formSP.WorkItemResultsUse.WorkItem)
                     {
                        //reset BatchItemID before each work Item
                        CP.BatchItemID = 0;
                        getIndexValuesSP(ref CP, wi);
                        //we need to pull back some info from the db
                        _dataAccess.getXrefValues(ref CP);
                        Dictionary<string, string> LOBs = new Dictionary<string, string>();
                        foreach (AWDLOB aWDLOB in wi.AWDLOB)
                        {
                           LOBs.Add(aWDLOB.Name, aWDLOB.Value);
                        }
                        //populate mvi table with CP values
                        foreach (DataRow dr in CP._MVIFieldData.DD_MVI_FIELD_DEFINITION.Rows)
                        {
                           string FieldName = dr["FIELD_NAME"].ToString();
                           string cpvalue = CP[FieldName].ToString();
                           if (cpvalue.Length > 0)
                           {
                              dr["LOCAL_VALUE"] = cpvalue;
                           }
                        }
                        writeRecordShowWait(ref CP, LOBs, "frmSelectPerson");


                     }

                     //now we can leave
                     break;
                  case System.Windows.Forms.DialogResult.Cancel:
                     //user cancelled
                     CP.IsCancelled = true;
                     break;
                  case System.Windows.Forms.DialogResult.Ignore:
                     //flag the user wants to perform additional policy validation
                     CP.IsContinued = true;
                     break;
                  case System.Windows.Forms.DialogResult.Abort:
                     //get new indextype if needed
                     DataAccess dataAccess = new DataAccess();
                     dataAccess.selectRouting(ref CP);

                     switch (CP.IndexType)
                     {

                        case "SP":
                           //the user wants to perform select person
                           launchSPIndex(ref CP);
                           break;
                        default:
                           //FO, AWD, DST, FN, etc.
                           launchIndex(ref CP, new CommonParameters());
                           break;

                     }
                     break;
                  default:
                     //user cancelled
                     CP.IsCancelled = true;
                     break;
               }
            }
         }
         else
         {
            //policy number is blank, we need to cancel
            //System.Windows.Forms.MessageBox.Show("Must enter a Policy Number.");
            CP.IsCancelled = true;

         }
      }
      public void launchIndex(ref CommonParameters CP, CommonParameters prevCP)
      {
         using (frmIndex formIndex = new frmIndex(ref CP, prevCP))
         {
            //setup a return from the dialog
            System.Windows.Forms.DialogResult dRes = formIndex.ShowDialog();
            //let's assume that whoever launched the index screen and then closed it out
            //was the index operator for this item
            if (null != System.Environment.UserName)
            {
               CP.IndexOperator = System.Environment.UserName.ToString().ToUpper();
            }
            //now we can check the results of the dialog
            switch (dRes)
            {
               case System.Windows.Forms.DialogResult.Retry:
                  //flag the user wants to perform additional policy validation
                  CP.IsContinued = true;
                  goto case System.Windows.Forms.DialogResult.OK;
               case System.Windows.Forms.DialogResult.OK:
                  //we need to pull back some info from the db for AWD
                  if (CP.IndexType == "AWD")
                  {
                     _dataAccess.getXrefValues(ref CP);
                  }
                  //make sure dates are formatted YYYY/MM/DD HH24:MM:SS
                  formatDateFields(ref CP);
                  //and then send the data to the db
                  writeRecordShowWait(ref CP,null,"frmIndex");
                  //now we can leave
                  break;
               case System.Windows.Forms.DialogResult.Cancel:
                  //user cancelled
                  CP.IsCancelled = true;
                  break;
               case System.Windows.Forms.DialogResult.Ignore:
                  //flag the user wants to perform additional policy validation
                  CP.IsContinued = true;
                  break;
               case System.Windows.Forms.DialogResult.Abort:

                  //get new indextype if needed
                  DataAccess dataAccess = new DataAccess();
                  dataAccess.selectRouting(ref CP);
                  switch (CP.IndexType)
                  {
                     case "SP":
                        //the user wants to perform select person
                        launchSPIndex(ref CP);
                        break;
                     default:
                        //FO, AWD, DST, FN, etc.
                        launchIndex(ref CP, new CommonParameters());
                        break;
                  }

                  break;
               default:
                  //user cancelled
                  CP.IsCancelled = true;
                  break;
            }
            GC.Collect();
         }
      }

      #endregion

      #region Private Methods

      private void getIndexValuesSP(ref CommonParameters CP, WorkItem wi)
      {
         int fnIndexCt = 0;
         //set BA/WT/STATUS
         CP.BusinessArea = wi.WorkItemRoute[0].BusinessArea;
         CP.WorkType = wi.WorkItemRoute[0].WorkType;
         CP.AWDStatus = wi.WorkItemRoute[0].Status;
         //clear table of any previous filenet indexes
         //set by a previous work item returned from the SelectPerson Call
         List<DataRow> deleterows = new List<DataRow>();
         foreach (DataRow drd in CP._MVIFieldData.DD_MVI_FIELD_DEFINITION.Rows)
         {
            if (drd["FIELD_NAME"].ToString().Length >= 8 && drd["FIELD_NAME"].ToString().Substring(0, 8) == "SPReturn")
            {
               deleterows.Add(drd);
            }
         }
         foreach (DataRow drd in deleterows)
         {
            drd.Delete();
         }
         //set FileNet Indexes
         foreach (FILENET fILENET in wi.FileNet)
         {
            Boolean foundInTable = false;
            foreach (DataRow dri in CP._MVIFieldData.DD_MVI_FIELD_DEFINITION.Rows)
            {

               if (dri["FN_PROP_NAME"].ToString() == fILENET.IndexName)
               {
                  foundInTable = true;
                  switch (fILENET.IndexName)
                  {
                     case "Batch_Number":
                        //do nothing, we never want to change the batch number from what IA provides
                        break;
                     case "Certified_Number":
                        if (CP.CertifiedNo == "")
                        {
                           //only change if entered certified number is null...it comes from the select person form
                           CP.CertifiedNo = fILENET.IndexValue;
                        }
                        break;
                     default:
                        //set cp value if filenetproperty exists
                        CP[dri["FIELD_NAME"].ToString()] = fILENET.IndexValue;
                        break;
                  }
                  break;
               }
            }
            if (false == foundInTable)
            {
               //add row to definition table with local value
               fnIndexCt++;
               DataRow dr = CP._MVIFieldData.DD_MVI_FIELD_DEFINITION.NewRow();
               dr["SITE_ID"] = CP.SiteID;
               dr["WORK_CATEGORY"] = CP.WorkCategory;
               dr["FIELD_NAME"] = "SPReturn" + fnIndexCt.ToString();
               dr["FN_PROP_NAME"] = fILENET.IndexName;
               dr["LOCAL_VALUE"] = fILENET.IndexValue;
               CP._MVIFieldData.DD_MVI_FIELD_DEFINITION.Rows.Add(dr);


            }

         }


      }

      public void formatDateFields(ref CommonParameters CP)
      {
         try
         {
            //define the variables
            DateTime scanDate;
            //convert the value to a date
            scanDate = DateTime.Parse(CP.ScanDate);
            CP.ScanDate = scanDate.ToString("yyyy/MM/dd HH:mm:ss");
         }
         catch
         {
            CP.ScanDate = "";
         }

         try
         {
            //define the variables
            DateTime birthDate;
            //convert the value to a date
            birthDate = DateTime.Parse(CP.BirthDate);
            CP.BirthDate = birthDate.ToString("yyyy/MM/dd HH:mm:ss");
         }
         catch
         {
            CP.BirthDate = "";
         }
         try
         {
            //define the variables
            DateTime receivedDate;
            //convert the value to a date
            receivedDate = DateTime.Parse(CP.ReceivedDate);
            CP.ReceivedDate = receivedDate.ToString("yyyy/MM/dd HH:mm:ss");
         }
         catch
         {
            CP.ReceivedDate = "";
         }
         try
         {
            //define the variables
            DateTime receivedDateCRD;
            //convert the value to a date
            receivedDateCRD = DateTime.Parse(CP.ReceivedDateCRD);
            CP.ReceivedDateCRD = receivedDateCRD.ToString("yyyy/MM/dd HH:mm:ss");
         }
         catch
         {
            CP.ReceivedDateCRD = "";
         }        
      }
       
      private void writeRecord(ref CommonParameters CP)
      {
         writeRecord(ref CP, null);
      }

      private void writeRecordShowWait(ref CommonParameters CP, Dictionary<string, string> LOBs, string parentFormName)
      {
         frmWait objWait = new frmWait(parentFormName);
         try
         {
            objWait.Show();
            objWait.Refresh();
            writeRecord(ref CP, LOBs);

         }
         catch (Exception ex)
         {
            throw ex;
         }
         finally
         {
            objWait.Close();
         }
      }

      private void writeRecord(ref CommonParameters CP, Dictionary<string, string> LOBs)
      {
         try
         {
            //start a transactional connection to the db
            _dataAccess.Connect();
            //make sure the dates are formatted correctly
            formatDateFields(ref CP);
            //generate the fis id
            _dataAccess.getFISID(ref CP);
            //create the batch data record
            _dataAccess.createDDItem(ref CP);
            //create the appropriate routing record
            switch (CP.IndexType.ToUpper())
            {
               case "AWD":
                  #region AWD

                  int origTranID;

                  if (CP.AWDCaseID == 0 & CP.AWDTranID == -1)
                  {
                     //we need to perform an initial call in order
                     //to get the case worktype in correctly  
                     //now make the call
                     _dataAccess.createAWDRequest(ref CP, 0, -1, 0, CP.CaseWorkType);
                  }
                  else if (CP.AWDCaseID == 0 & CP.AWDTranID != -1)
                  {
                     //we need to perform an initial call in order
                     //to get the case worktype in correctly  
                     //grab a local copy of the id
                     origTranID = CP.AWDTranID;
                     //now make the call
                     _dataAccess.createAWDRequest(ref CP, 0, -1, -1, CP.CaseWorkType);
                     //now put back the original value
                     CP.AWDTranID = origTranID;
                     //now make the call to create the transaction
                     _dataAccess.createAWDRequest(ref CP, CP.AWDCaseID, CP.AWDTranID, 0, CP.WorkType);

                  }
                  else
                  {

                     //make the call
                     _dataAccess.createAWDRequest(ref CP, CP.AWDCaseID, CP.AWDTranID, 0, CP.WorkType);
                  }
                  if (null != LOBs)
                  {
                     processAWDLOBs(ref CP, LOBs);
                  }
                  else
                  {
                     processAWDLOBs(ref CP);

                  }
                  //now we need to update the batch data record
                  _dataAccess.updateDDItem(ref CP);
                  //send the batch item data in
                  _dataAccess.createBatchItem(ref CP);
                  break;
                  #endregion
               case "SP":
                  #region SelectPerson
                  //now make the call
                  _dataAccess.createAWDRequest(ref CP, -1, 0, 0, CP.WorkType);
                  if (null != LOBs)
                  {
                     processAWDLOBs(ref CP, LOBs);
                  }
                  //now we need to update the dd item record
                  _dataAccess.updateDDItem(ref CP);
                  //send the batch item data in
                  _dataAccess.createBatchItem(ref CP);
                  break;
                  #endregion
               case "DST":
                  _dataAccess.createDSTRequest(ref CP);
                  //now we need to update the dd item record
                  _dataAccess.updateDDItem(ref CP);
                  //send the batch item data in
                  _dataAccess.createBatchItem(ref CP);
                  break;
               case "INV":
                  _dataAccess.createInvoiceRequest(ref CP);
                  _dataAccess.createInvoiceDetail(ref CP);
                  //now we need to update the dd item record
                  _dataAccess.updateDDItem(ref CP);
                  _dataAccess.createBatchItem(ref CP);
                  break;
               case "FO":
                  _dataAccess.createFORequest(ref CP);
                  //now we need to update the dd item record
                  _dataAccess.updateDDItem(ref CP);
                  _dataAccess.createBatchItem(ref CP);
                  break;
               case "TP":
                  _dataAccess.createTPRequest(ref CP);
                  //now we need to update the dd item record
                  _dataAccess.updateDDItem(ref CP);
                  _dataAccess.createBatchItem(ref CP);
                  break;
               case "PRIVKEY":
                  ServiceCalls sc = new ServiceCalls();
                  sc.updatePrivacyDetail(ref CP);
                  //now we need to update the dd item record
                  _dataAccess.updateDDItem(ref CP);
                  //send the batch item data in
                  _dataAccess.createBatchItem(ref CP);
                  break;
               case "FN":
                  _dataAccess.createBatchItem(ref CP);
                  break;
               default:
                  //just in case there is no launch type
                  throw new Exception("No Valid Launch Type Present");
            }
            //now we can flag the document as ready 
            _dataAccess.releaseDDItem(ref CP);
            //if we arrive here we may commit the transaction;
            _dataAccess.Disconnect();
            //just so we don't ever link something inadvertently reset defaults

            CP.AWDSourceID = 0;
            CP.AWDTranID = -1;
            CP.AWDCaseID = -1;
            CP.AWDRequestID = 0;
            CP.DocustreamRequestID = 0;
         }
         catch (Exception ex)
         {
            try
            {
               //something failed, so roll it all back
               _dataAccess.Cancel();
            }
            catch { }

            throw new Exception("MultiIndex.WriteRecord: " + ex.Message);
         }
      }
       
      private void processAWDLOBs(ref CommonParameters CP, Dictionary<string, string> LOBs)
      {
         try
         {
            foreach (string lobName in LOBs.Keys)
            {
               string lobValue = LOBs[lobName];

               if (lobValue.Length != 0)
               {
                  //now we can call the insert (do both T and S because type is not specified)
                  _dataAccess.createAWDLOBs(ref CP, lobName, lobValue, "T");
               }
            }
            //now process those in config
            processAWDLOBs(ref CP);
         }
         catch (Exception ex)
         {
            throw new Exception("MultiIndex.processAWDLOBs: " + ex.Message);
         }
      }
      private void processAWDLOBs(ref CommonParameters CP)
      {
         try
         {
            //loop through table for lob definitions
            foreach (DataRow dr in CP._MVIFieldData.DD_MVI_AWD_LOB_DEFINITION.Rows)
            {
               string lobName = "";
               string lobValue = "";
               string lobLevel = "";

               lobName = dr["LOB_NAME"].ToString();
               lobLevel = dr["LOB_LEVEL"].ToString();

               //try to get value from CP
               if (CP[dr["SOURCE"].ToString()] != null)
               {
                   lobValue = CP[dr["SOURCE"].ToString()].ToString();
               }
               else
               {
                   lobValue = String.Empty;
               }

               _dataAccess.createAWDLOBs(ref CP, lobName, lobValue, lobLevel);
            }
         }
         catch (Exception ex)
         {
            throw new Exception("MultiIndex.processAWDLOBs: " + ex.Message);
         }
      }
       
      #endregion

      #region Public Properties


      #endregion
   }
   public class ComboBoxItem
   {
      private string _display;
      private string _value;
      private string _DocClassName = String.Empty;
      private string _DocType = String.Empty;
      private string _LineOfBusiness = String.Empty;
      private string _FNP8_DOCCLASSNAME = String.Empty;
      private string _FNP8_OBJECTSTORE = String.Empty;
      private string _FNP8_FOLDER = String.Empty;


      public ComboBoxItem(string display, string value, string docType, string fDocClassName, string lineOfBusiness, string FNP8_DocClassName, string FNP8_ObjectStore, string FNP8_Folder)
      {
         this._display = display;
         this._value = value;
         this._DocClassName = fDocClassName;
         this._DocType = docType;
         this._LineOfBusiness = lineOfBusiness;
         this._FNP8_DOCCLASSNAME = FNP8_DocClassName;
         this._FNP8_OBJECTSTORE = FNP8_ObjectStore;
         this._FNP8_FOLDER = FNP8_Folder;
      }
      public string Display
      {
         set { _display = value; }
         get { return _display; }
      }
      public string Value
      {
         set { _value = value; }
         get { return _value; }
      }
      public string DocType
      {
         get { return _DocType; }
         set { _DocType = value; }
      }
      public string FDocClassName
      {
         get { return _DocClassName; }
         set { _DocClassName = value; }
      }
      public string LineOfBusiness
      {
         get { return _LineOfBusiness; }
         set { _LineOfBusiness = value; }
      }
      public string FNP8_DOCCLASSNAME
      {
         get { return _FNP8_DOCCLASSNAME; }
         set { _FNP8_DOCCLASSNAME = value; }
      }
      public string FNP8_OBJECTSTORE
      {
         get { return _FNP8_OBJECTSTORE; }
         set { _FNP8_OBJECTSTORE = value; }
      }
      public string FNP8_FOLDER
      {
         get { return _FNP8_FOLDER; }
         set { _FNP8_FOLDER = value; }
      }

   }
}
