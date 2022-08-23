using System;
using System.Runtime.InteropServices;
using System.Data;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using CNO.BPA.DataHandler;
using CNO.BPA.DataValidation;
using CNO.BPA.Validation4086;
using CNO.BPA.MVI;
using CNO.BPA.PrivacyMailingValidation;
using CNO.BPA.GroupValidation;

namespace CNO.BPA.DataDirector
{
   public delegate void CompleteEventHandler(int Result, string Description);

   [Guid("F6750916-56FC-4885-A225-0081F44C18DD"),
   ClassInterface(ClassInterfaceType.None),
  ComSourceInterfaces(typeof(IDirectorEvents))]
   public class Director : IDirector
   {
      #region Public Events
      public event CompleteEventHandler Complete;
      #endregion

      #region Private Variables
      CommonParameters _cp;
      CommonParameters _prevcp;
      #endregion

      #region Public Methods

      public void LaunchDD(ref CommonParameters CP)
      {
         //log user tracking
         DataHandler.DataAccess dataAccess = new DataAccess();
         dataAccess.createDDUserTracking(ref CP, "LaunchDD", "");
         //pull the common parameters into a local variable
         _cp = CP;
         //try to read previous common parameters back in from file:
         getPrevCP();
                   
         System.Threading.Thread workerThread = new System.Threading.Thread(InitDD);
         workerThread.Start();         
      }

      #endregion

      #region Private Methods
      private void getPrevCP()
      {
         try
         {
            Stream stream = File.Open(_cp.CONFIG_PATH + @"PreviousCP.dat", FileMode.Open);
            BinaryFormatter bformatter = new BinaryFormatter();


            _prevcp = (CommonParameters)bformatter.Deserialize(stream);
            stream.Close();
            if (_cp.BatchNo == _prevcp.BatchNo && _cp.SiteID == _prevcp.SiteID &&
               _cp.WorkCategory == _prevcp.WorkCategory && _cp.EnvelopeNodeID == _prevcp.EnvelopeNodeID)
            {
               _cp.PreviousNodeID = _prevcp.CurrentNodeID;
               _cp.DDItemSeqPrevious = _prevcp.DDItemSeq;
            }
         }
         catch
         {
            _prevcp = new CommonParameters();
         }


      }
      private void InitDD()
      {
         int returnVal = 0;
         int dvReturn = 0;
         try
         {
            //first we need to determine if this item has had any indexes created for it.
            returnVal = checkDDItems();
            //based on the return value determine how to proceed
            switch (returnVal)
            {
               case 0:
                  //
                  break;
               case 1:
                  //if (Complete != null)
                  //{
                  //   Complete(1, "User Cancelled Existing Data Director Items Form.");
                  //}
                  return;
            }

         ReLaunchSearchProvider:
            //if the user decided to continue or if there were no previous indexes,
            //we need to determine the launch type
            getLaunchType();
            //based on launch type do we need to perform data validation
            switch (_cp.SearchProvider.ToUpper())
            {
               #region Case DV
               case "DV":
                  Validation dataValidaton = new Validation();
                  dvReturn = dataValidaton.Validate(ref _cp);
                  switch (dvReturn)
                  {
                     case 0: //validation completed successfully
                        //simply continue to the index sreen
                        break;
                     case -2:
                        //site id and policy number mismatch
                        goto ReLaunchSearchProvider;
                     default:
                        //simply continue to the index sreen
                        break;
                  }
                  break;
               #endregion

               //AR143750 - START
               #region Case ESC
               case "ESC":                  
                  ESCSearch escSearch = new ESCSearch();                  
                  dvReturn = escSearch.Search(ref _cp);
                  switch (dvReturn)
                  {
                      case 0: //validation completed successfully
                          //simply continue to the index sreen
                          break;
                      case -1:
                          //Holder Number is not entered by user
                          MessageBox.Show("Please enter a holder number to search for", "Holder Number Needed");
                          goto ReLaunchSearchProvider;                          
                      case -2:
                          //No data fetched from database
                          MessageBox.Show("No results found. Please enter a valid holder number to search for.", "Valid Holder Number Needed");
                          goto ReLaunchSearchProvider;
                      default:
                          //simply continue to the index sreen
                          break;
                  }
                  break;
               #endregion
               //AR143750 - END

               #region Case PRIVMAIL
               case "PRIVMAIL":
                  PrivacyValidation privMailVal = new PrivacyValidation();
                  dvReturn = privMailVal.Validate(ref _cp);
                  switch (dvReturn)
                  {
                     case 0: //validation completed successfully
                        break;
                     case -1: //user cancelled
                        //continue on to allow manual entry
                        break;
                     default:
                        //simply continue to the index sreen
                        break;
                  }
                  break;
               #endregion
               #region Case 4086CUSIP
               case "4086CUSIP":
                  CusipSearch cusipSearch = new CusipSearch();
                  dvReturn = cusipSearch.Search(ref _cp);
                  switch (dvReturn)
                  {
                     case 0: //validation completed successfully
                        //in case the user invoked the use of the bridge,
                        //we need to re-pull the launch type
                        getLaunchType();
                        break;
                     case -1: //user cancelled
                        break;
                     case -2: //no results found
                        System.Windows.Forms.MessageBox.Show("No Results found for the search criteria");
                        goto ReLaunchSearchProvider;
                     default:
                        //simply continue to the index sreen
                        break;
                  }
                  break;
               #endregion
               #region Case 4086LOAN
               case "4086LOAN":
                  LoanSearch loanSearch = new LoanSearch();
                  dvReturn = loanSearch.Search(ref _cp);
                  switch (dvReturn)
                  {
                     case 0: //validation completed successfully
                        //in case the user invoked the use of the bridge,
                        //we need to re-pull the launch type
                        getLaunchType();
                        break;
                     case -1: //user cancelled
                        break;
                     case -2: //no results found
                        System.Windows.Forms.MessageBox.Show("No Results found for the loan number entered");
                        goto ReLaunchSearchProvider;
                     default:
                        //simply continue to the index sreen
                        break;
                  }
                  break;
               #endregion

               #region Case GV
               case "GV":                  
                  GroupSearch groupSearch = new GroupSearch();
                  dvReturn = groupSearch.Search(ref _cp);
                  switch (dvReturn)
                  {
                      case 0: //validation completed successfully
                          //in case the user invoked the use of the bridge,
                          //we need to re-pull the launch type
                          getLaunchType();
                          break;
                      case -1: //user cancelled
                          break;
                      case -2: //no results found
                          System.Windows.Forms.MessageBox.Show("No Results found for the group entered");
                          goto ReLaunchSearchProvider;
                      default:
                          //simply continue to the index sreen
                          break;
                  }
                  break;
               #endregion
            }

            //once we are ready to move on, start the indexer

            Indexer indexer = new Indexer();
            //in case bridge used on search screen
            getLaunchType();
            switch (_cp.IndexType.ToUpper())
            {
               case "SP":
                  indexer.launchSPIndex(ref _cp);
                  break;
               default:
                  //FO, AWD, DST, FN, etc.
                  indexer.launchIndex(ref _cp, _prevcp);
                  break;
            }
            //Try to save CP
            saveCP();
            if (_cp.IsContinued == true)
            {
               //we need to clear out the search values
               _cp.PreviousNodeID = _cp.CurrentNodeID;
               _cp.DDItemSeqPrevious = _cp.DDItemSeq;
               getPrevCP();
               _cp.Clear();
               _cp.IsContinued = false;
  
               //now we can go to the search provider again
               goto ReLaunchSearchProvider;
            }
            if (_cp.IsCancelled == true)
            {
               _cp.Clear();
            }
         }
         catch (Exception ex)
         {
            System.Windows.Forms.MessageBox.Show(ex.Message);
         }
         finally
         {
            if (Complete != null)
            {


               DataAccess dataAccess = new DataAccess();
               IndexData datasetResults = dataAccess.selectDataDirectorItem(ref _cp);
               //based on the return we can act accordingly
               if (datasetResults.DD_ITEM.Rows.Count > 0)
               {
                  Complete(0, "There are " + datasetResults.DD_ITEM.Rows.Count.ToString() + " indexed items");
               }
               else
               {
                  Complete(1, "There are no indexed items");
               }

            }

         }
      }
      private CommonParameters copyCP(CommonParameters cp)
      {
         CommonParameters newCP = new CommonParameters();
         newCP = cp;
         return newCP;
      }
      private void saveCP()
      {
         //try to save cp
         Stream stream = File.Open(_cp.CONFIG_PATH + @"PreviousCP.dat", FileMode.Create);
         BinaryFormatter bformatter = new BinaryFormatter();
         bformatter.Serialize(stream, _cp);
         stream.Close();

      }

      private void getLaunchType()
      {
         //grab an instance of the data access class
         DataHandler.DataAccess dataAccess = new DataAccess();
         dataAccess.selectRouting(ref _cp);
      }
      private int checkDDItems()
      {
         //obtain a new instance of the pv class
         Validation dataValidation = new Validation();
         DataAccess dataAccess = new DataAccess();

         if (_cp.IsContinued != true)
         {
            //check the database to see if this item has been indexed before
            IndexData datasetResults = dataAccess.selectDataDirectorItem(ref _cp);
            //based on the return we can act accordingly
            if (datasetResults.DD_ITEM.Rows.Count > 0)
            {
               //create a new instance of the indexes form
               frmExistingDDItems existingDDItems = new frmExistingDDItems(datasetResults, ref _cp);
               //show the form with the current set of indexes and
               //setup a return from the dialog to determine the result
               System.Windows.Forms.DialogResult dr =
                  existingDDItems.ShowDialog();
               //based on the result of the dialog perform the next step
               switch (dr)
               {
                  case System.Windows.Forms.DialogResult.Yes:
                     //user wants to continue 
                     _cp.IsCancelled = false;
                     return 0;
                  case System.Windows.Forms.DialogResult.Cancel:
                     //user cancelled so leave the process
                     _cp.IsCancelled = true;
                     return 1;
                  default:
                     //user cancelled so leave the process
                     _cp.IsCancelled = true;
                     return 1;
               }
            }
         }
         return 0;
      }
      #endregion

   }
}
