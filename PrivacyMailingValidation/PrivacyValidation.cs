using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using CNO.BPA.DataHandler;
using System.Windows.Forms;

namespace CNO.BPA.PrivacyMailingValidation
{
   [ComVisible(true)]
   [ClassInterface(ClassInterfaceType.AutoDual)]
   [GuidAttribute("7174C897-24ED-42eb-8A52-6FADC1BDEC9B")]
   public class PrivacyValidation
   {
      public int Validate(ref CommonParameters CP)
      {
         using (frmPrivacySearch objPrivacySearch = new frmPrivacySearch(ref CP))
         {
            DialogResult searchDiagRes = objPrivacySearch.ShowDialog();

            if (searchDiagRes == DialogResult.OK)
            {
               //valid Master ID was found
               return 0;
            }
            else
            {
               //user cancelled
               return -1;
            }


         }

      }
      public int AutoValidate(ref CommonParameters CP)
      {
         try
         {
            //clear the validation message
            CP.ValidationMessage = String.Empty;

            int dvReturn;
            int matches = 0;
            CommonParameters lookupCP = new CommonParameters();
            lookupCP.PrivMasterID = CP.PrivMasterID;
            //search for Master ID
            DataHandler.DataAccess dataAccess = new DataAccess();
            lookupCP.PrivMasterID = CP.PrivMasterID.Trim();
            dvReturn = dataAccess.selectPrivacyMailing(ref lookupCP);

            switch (dvReturn)
            {
               case 0: //found
                  //compare to OCR data to validate
                  if (lookupCP.FirstName.Trim().Length > 0 && lookupCP.FirstName.Trim() == CP.FirstName.Trim())
                  {
                     matches++;
                  }
                  if (lookupCP.LastName.Trim().Length > 0 && lookupCP.LastName.Trim() == CP.LastName.Trim())
                  {
                     matches++;
                  }
                  if (lookupCP.MiddleName.Trim().Length > 0 && lookupCP.MiddleName.Trim() == CP.MiddleName.Trim())
                  {
                     matches++;
                  }
                  if (lookupCP.Address1.Trim().Length > 0 && lookupCP.Address1.Trim() == CP.Address1.Trim())
                  {
                     matches++;
                  }
                  if (lookupCP.Address2.Trim().Length > 0 && lookupCP.Address2.Trim() == CP.Address2.Trim())
                  {
                     matches++;
                  }


                  break;
               case -2:
                  //Master ID not found
                  CP.ValidationMessage = "Master ID not found.";
                  return -1;
               default:
                  //unexpected return
                  CP.ValidationMessage = "Unexpected return from selectPrivacyMailing.";
                  return -1;
            }


            if (matches >= 2)
            {
               //validates
               //set values to lookup values
               CP.FirstName = lookupCP.FirstName;
               CP.MiddleName = lookupCP.MiddleName;
               CP.LastName = lookupCP.LastName;
               CP.City = lookupCP.City;
               CP.State = lookupCP.State;
               CP.ZipCode = lookupCP.ZipCode;
               CP.Address1 = lookupCP.Address1;
               CP.Address2 = lookupCP.Address2;

               return 0;
            }
            else
            {
               CP.ValidationMessage = matches.ToString() + " data matches found.  2 data matches are required for validation.";
               return -1;
            }
         }
         catch (Exception ex)
         {
            CP.ValidationMessage = ex.Message;
            return -1;
         }
      }
   }
}
