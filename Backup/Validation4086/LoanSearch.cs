using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using CNO.BPA.DataHandler;
using System.Runtime.InteropServices;

namespace CNO.BPA.Validation4086
{
   [ComVisible(true)]
   [ClassInterface(ClassInterfaceType.AutoDual)]
   [GuidAttribute("D25941E1-ABF8-41eb-884C-AAD0AF2E74E8")]
   public class LoanSearch
   {
      public int Search(ref CommonParameters CP)
      {
         using (frmLoanSearch objLoanSearch = new frmLoanSearch(ref CP))
         {

         RESEARCH:
            objLoanSearch.ShowDialog();

            if (objLoanSearch.Cancel == false)
            {
               //call the search method
               DataHandler.DataAccess dataAccess = new DataAccess();
               DataSet datasetResults = dataAccess.selectMortgage(ref CP);
               //1st make sure we have a data set returned to us
               if (!object.ReferenceEquals(datasetResults, null))
               {
                  if (datasetResults.Tables[0].Rows.Count == 1)
                  {
                     //there was an exact match so pull back and assign the values
                     DataRow dataRow = datasetResults.Tables[0].Rows[0];
                     CP.AccountNumber = dataRow["LOAN_NUMBER"].ToString().Trim();
                     CP.Address1 = dataRow["PROPERTY_ADDRESS1"].ToString().Trim();
                     CP.Address2 = dataRow["PROPERTY_ADDRESS2"].ToString().Trim();
                     CP.LastName = dataRow["BORROWER_NAME"].ToString().Trim();
                     CP.PropertyName = dataRow["PROPERTY_NAME"].ToString().Trim();
                     CP.State = dataRow["PROPERTY_STATE"].ToString().Trim();
                     CP.City = dataRow["PROPERTY_CITY"].ToString().Trim();
                     CP.FullName = dataRow["TENANT"].ToString().Trim();
                     //indicate we were successful
                     return 0;
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
                           //indicate we were successful
                           return 0;
                        case System.Windows.Forms.DialogResult.Cancel:
                           return -1;  
                        case System.Windows.Forms.DialogResult.Retry:
                           goto RESEARCH;
                        default:
                           //indicate user cancelled
                           return -1;
                     }
                  }                  
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
      public int loanValidation(ref CommonParameters CP)
      {
         //a loan number value should be found in the account number field and the address in address 1
         if (CP.AccountNumber.Length > 0 && CP.Address1.Length > 0) 
         {
            DataHandler.DataAccess dataAccess = new DataAccess();
            DataSet datasetResults = dataAccess.selectMortgage(ref CP, CP.Address1);
            //1st make sure we have a data set returned to us
            if (!object.ReferenceEquals(datasetResults, null))
            {
               if (datasetResults.Tables[0].Rows.Count == 1)
               {
                  //there was an exact match so pull back and assign the values
                  DataRow dataRow = datasetResults.Tables[0].Rows[0];
                  CP.AccountNumber = dataRow["LOAN_NUMBER"].ToString().Trim();
                  CP.Address1 = dataRow["PROPERTY_ADDRESS1"].ToString().Trim();
                  CP.Address2 = dataRow["PROPERTY_ADDRESS2"].ToString().Trim();
                  CP.LastName = dataRow["BORROWER_NAME"].ToString().Trim();
                  CP.PropertyName = dataRow["PROPERTY_NAME"].ToString().Trim();
                  CP.State = dataRow["PROPERTY_STATE"].ToString().Trim();
                  CP.City = dataRow["PROPERTY_CITY"].ToString().Trim();
                  CP.FullName = dataRow["TENANT"].ToString().Trim();
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
   }
}
