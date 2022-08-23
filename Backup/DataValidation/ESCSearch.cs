using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using CNO.BPA.DataHandler;

namespace CNO.BPA.DataValidation
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [GuidAttribute("B5836FF4-A767-4206-99ED-97A9973F9408")]
    public class ESCSearch
    {
        public int Search(ref CommonParameters CP)
        {
            using (frmESCSearch objESCSearch = new frmESCSearch(ref CP))
            {
                string resultData = "";

                objESCSearch.ShowDialog();

                if (objESCSearch.Cancel == false)
                {
                    //call the search method
                    DataHandler.DataAccess dataAccess = new DataAccess();

                    //Check if the entered holder number is empty
                    if (CP.HolderNumber == "")
                    {
                        resultData = "BLANK";
                    }
                    else
                    {
                        resultData = dataAccess.getBusinessAreaFromHolderNumber(ref CP);
                    }

                    //Based on the data fetched from database assign return value.
                    if (resultData == "DATAFOUND")
                        return 0;
                    else if (resultData == "BLANK")
                        return -1;
                    else if (resultData == "NODATA")
                        return -2;

                    //indicate we were successful
                    return 0;
                }
                else
                {
                    //user cancelled. Proceed to Index screen
                    return -4;                 
                }
            }
        }  
    }
}