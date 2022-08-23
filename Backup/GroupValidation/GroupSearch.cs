using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using CNO.BPA.DataHandler;
using System.Runtime.InteropServices;

namespace CNO.BPA.GroupValidation
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [GuidAttribute("EAA516A1-D5A9-4fe7-894F-5269F382D3B3")]
    public class GroupSearch
    {
        public int Search(ref CommonParameters CP)
        {
            using (frmGroupSearch objGroupSearch = new frmGroupSearch(ref CP))
            {

            RESEARCH:
                objGroupSearch.ShowDialog();
                
                if (objGroupSearch.Cancel == false)
                {                    
                    //call the search method
                    DataHandler.DataAccess dataAccess = new DataAccess();
                    DataSet datasetResults = dataAccess.selectGroupDetails(ref CP);

                    //1st make sure we have a data set returned to us
                    if (!object.ReferenceEquals(datasetResults, null))
                    {
                        if (datasetResults.Tables[0].Rows.Count == 1)
                        {
                            //there was an exact match so pull back and assign the values
                            DataRow dataRow = datasetResults.Tables[0].Rows[0];

                            CP.City = dataRow["CITY"].ToString().Trim();
                            CP.CompanyCode = dataRow["COMPANY"].ToString().Trim();
                            CP.EmailID = dataRow["CONTACTEMAIL"].ToString().Trim();
                            CP.FirstName = dataRow["CONTACTNAME"].ToString().Trim();
                            CP.Phone = dataRow["CONTACTNUMBER"].ToString().Trim();
                            CP.GroupID = dataRow["GROUPID"].ToString().Trim();
                            CP.GroupName = dataRow["GROUPNAME"].ToString().Trim();
                            CP.GroupNo = dataRow["GROUPNUMBER"].ToString().Trim();
                            CP.SystemID = dataRow["GROUPSYSTEM"].ToString().Trim();
                            CP.AgentNo = dataRow["IMOAGENTNUMBER"].ToString().Trim();
                            CP.LineOfBusiness = dataRow["LINEOFBUSINESS"].ToString().Trim();
                            CP.Address1 = dataRow["MAILINGADDRESS1"].ToString().Trim();
                            CP.Address2 = dataRow["MAILINGADDRESS2"].ToString().Trim();
                            CP.MasterGroupID = dataRow["MASTERGROUPID"].ToString().Trim();
                            CP.MasterGroupName = dataRow["MGGROUPNAME"].ToString().Trim();
                            CP.MasterGroupNo = dataRow["MGGROUPNUMBER"].ToString().Trim();
                            CP.State = dataRow["STATE"].ToString().Trim();
                            CP.Status = dataRow["STATUS"].ToString().Trim();
                            CP.ZipCode = dataRow["ZIP"].ToString().Trim();
                            
                            //indicate we were successful
                            return 0;
                        }
                        else
                        {
                            //pass the resulting dataset into a new form so the user can select it
                            CP._datasetResults = datasetResults;
                            frmGroupSearchResults frmGroupSearchResults = new frmGroupSearchResults(ref CP);
                            System.Windows.Forms.DialogResult dlgResult = frmGroupSearchResults.ShowDialog();
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
    }
}
