using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CNO.BPA.DataHandler;
using System.Runtime.InteropServices;

namespace CNO.BPA.Validation4086
{
   [ComVisible(true)]
   [ClassInterface(ClassInterfaceType.AutoDual)]
   [GuidAttribute("EBEBE33A-7D9B-4f50-A866-D085FC062FEB")]
   public class CusipSearch
   {
      /// <summary>
      /// This method requires the caller to pass in a common parameters 
      /// object.  The common parameters object should be populated with 
      /// a value in the AccountNumber field and the ReportDate Field.  If  
      /// both values are present it will attempt to auto validate and pull back 
      /// all data (CUSIP, BORROWER_NAME, ISSUER_ID, PARENT_NAME).
      /// </summary>
      /// <param name="CP" description="The Common Parameters object found in the DataHandler Library." />
      /// <returns> 0     success
      ///          -1     validation cancelled
      ///          -2     no data found</returns>
      public int Search(ref CommonParameters CP)
      {
         using (frmCusipSearch objCusipSearch = new frmCusipSearch(ref CP))
         {
            objCusipSearch.ShowDialog();

            if (objCusipSearch.Cancel == false)
            {
               //call the search method
               DataHandler.DataAccess dataAccess = new DataAccess();
               DataSet datasetResults = dataAccess.selectPrivatePlacement(ref CP, CP.CustomReqIndexProperty6);
               //1st make sure we have a data set returned to us
               if (!object.ReferenceEquals(datasetResults, null))
               {
                  if (datasetResults.Tables[0].Rows.Count == 1)
                  {
                     //there was an exact match so pull back and assign the values
                     DataRow dataRow = datasetResults.Tables[0].Rows[0];
                     CP.AccountNumber = dataRow["CUSIP"].ToString().Trim();
                     CP.VendorName = dataRow["PARENT_NAME"].ToString().Trim();
                     CP.FullName = dataRow["BORROWER_NAME"].ToString().Trim();
                     CP.Description2 = dataRow["ISSUER_ID"].ToString().Trim();

                  }
                  else
                  {
                     //pass the resulting dataset into a new form so the user can select it
                     CP._datasetResults = datasetResults;
                     frmLoanResults formLoanResults = new frmLoanResults(ref CP);
                     System.Windows.Forms.DialogResult dlgResult = formLoanResults.ShowDialog();
                     switch (dlgResult)
                     {
                        case System.Windows.Forms.DialogResult.OK:

                           break;
                        case System.Windows.Forms.DialogResult.Cancel:
                           return -1;                           
                        default:
                           break;
                     }
                  }
                  //indicate we were successful
                  return 0;
               }
               else
               {
                  //indicate no results found
                  return -2;
               }
            }
            else
            {
               //user cancelled
               return -1;
            }

         }

      }
      /// <summary>
      /// This method requires the caller to pass in a common parameters 
      /// object.  The common parameters object should be populated with 
      /// a value in the AccountNumber field.  If  
      /// both values are present it will attempt to auto validate and pull back 
      /// all data (CUSIP, BORROWER_NAME, ISSUER_ID, PARENT_NAME).
      /// </summary>
      /// <param name="CP">The Common Parameters object found in the DataHandler Library.</param>
      /// <returns> 0     success
      ///          -1     muliple rows returned
      ///          -2     no data found
      ///          -3     required search parameters were not found</returns>
      public int ValidateCUSIP(ref CommonParameters CP)
      {
         try
         {
            if (CP.AccountNumber.Length > 0) //a CUISP value should be found in the account number field
            {
               DataHandler.DataAccess dataAccess = new DataAccess();
               DataSet datasetResults = dataAccess.selectPrivatePlacement(ref CP);
               //1st make sure we have a data set returned to us
               if (!object.ReferenceEquals(datasetResults, null))
               {
                  if (datasetResults.Tables[0].Rows.Count == 1)
                  {
                     //there was an exact match so pull back and assign the values
                     DataRow dataRow = datasetResults.Tables[0].Rows[0];
                     CP.AccountNumber = dataRow["CUSIP"].ToString().Trim();
                     CP.VendorName = dataRow["PARENT_NAME"].ToString().Trim();
                     CP.FullName = dataRow["BORROWER_NAME"].ToString().Trim();
                     CP.Description2 = dataRow["ISSUER_ID"].ToString().Trim();
                     //indicate we were successful
                     return 0;
                  }
                  else
                  {
                     //indicate more than one row returned from the query
                     return -1;
                  }
               }
               else//if not, there is no need to move forward
               {
                  //indicate no data was found
                  return -2;
               }
            }
            else
            {
               //indicate the required search params were not supplied
               return -3;
            }
         }
         catch (Exception ex)
         {
            return -4;
         }
      }
   }
}
