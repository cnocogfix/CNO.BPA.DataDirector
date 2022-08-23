using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.conseco.acord.ext;
using org.acord.standards.life._2;
using System.IO;
using System.Xml.Serialization;
using CNO.BPA.Framework;

namespace CNO.BPA.DataHandler
{
   public class ServiceCalls
   {
      private string CONFIG_PATH = Environment.GetFolderPath(Environment
                  .SpecialFolder.ApplicationData) + @"\CNO\bpa\";
      private string _tpxUser = "";
      private string _tpxPassword = "";
      
      public void updatePrivacyDetail(ref CommonParameters CP)
      {
         try
         {
            DataAccess dataAccess = new DataAccess();
            string definitionName = "CustomerGeneral";
            string urlPrivacyDetail = dataAccess.selectDDMainDefinitionValue("WEBSERVICE", definitionName);
            string userName = dataAccess.selectDDMainDefinitionValue("USERNAME", definitionName);
            string password = dataAccess.selectDDMainDefinitionValue("PASSWORD", definitionName);
            Cryptography crypto = new Cryptography();
            userName = crypto.Decrypt(userName);
            password = crypto.Decrypt(password);

            CustomerGeneral cg = new CustomerGeneral(urlPrivacyDetail);
            updatePersonPrivacyDetail updPPD = new updatePersonPrivacyDetail();

            org.acord.standards.life._2.TXLife_Type txl = new org.acord.standards.life._2.TXLife_Type();
            //create party
            org.acord.standards.life._2.Party privacyDetailParty = new org.acord.standards.life._2.Party();
            txl.TXLifeRequestCollection = new org.acord.standards.life._2.TXLifeRequestCollection();
            org.acord.standards.life._2.TXLifeRequest txlRequest = new org.acord.standards.life._2.TXLifeRequest();
            txlRequest.OLifE = new org.acord.standards.life._2.OLifE();

            privacyDetailParty.DataRep = org.acord.standards.life._2.DATAREP_TYPES.Full;
            privacyDetailParty.Person = new org.acord.standards.life._2.Person();

            //add address
            org.acord.standards.life._2.Address acAddress = new org.acord.standards.life._2.Address();
            if (CP.Address1.Trim().Length > 0)
            {
               acAddress.Line1 = CP.Address1.Trim();
            }
            if (CP.Address2.Trim().Length > 0)
            {
               acAddress.Line2 = CP.Address2.Trim();
            }
            if (CP.City.Trim().Length > 0)
            {
               acAddress.City = CP.City.Trim();
            }
            if (CP.State.Trim().Length > 0)
            {
               IntegrationCommonLib.AcordStateXref stateLookup = new IntegrationCommonLib.AcordStateXref();
               acAddress.AddressStateTC.tc = stateLookup.LookupAcordByAbrev[CP.State.Trim()].ToString();
            }
            if (CP.ZipCode.Trim().Length > 0)
            {
               acAddress.Zip = CP.ZipCode.Trim();
            }

            privacyDetailParty.AddressCollection.Add(acAddress);

            //add Person
            if (CP.FirstName.Trim().Length > 0)
            {
               privacyDetailParty.Person.FirstName = CP.FirstName.Trim();
            }
            if (CP.LastName.Trim().Length > 0)
            {
               privacyDetailParty.Person.LastName = CP.LastName.Trim();
            }
            if (CP.MiddleName.Trim().Length > 0)
            {
               privacyDetailParty.Person.MiddleName = CP.MiddleName.Trim();
            }

            //privacy info?
            org.acord.standards.life._2.OLifEExtension olifeExt = new org.acord.standards.life._2.OLifEExtension();
            olifeExt.VendorCode = IntegrationCommonLib.CONSECO.VENDORCODE;
            olifeExt.PartyExtension = new PartyExtension();
            olifeExt.PartyExtension.Privacy = new Privacy();
            //add two privacy statuses
            PrivacyStatus privStatusSHARE = new PrivacyStatus();
            privStatusSHARE.PrivacyOptionTC.tc = IntegrationCommonLib.OLI_PRIVOPT.OLI_PRIVOPT_SHARE.ToString();
            if (CP.PrivShareOptOut.Trim().Length > 0 && CP.PrivShareOptOut.Trim().Substring(0, 1).ToUpper() == "T")
            {
               privStatusSHARE.PrivacyStatusTC.tc = IntegrationCommonLib.OLI_PRIVSTAT.OLI_PRIVSTAT_OPTOUT.ToString();
            }
            else
            {
               privStatusSHARE.PrivacyStatusTC.tc = IntegrationCommonLib.OLI_PRIVSTAT.OLI_PRIVSTAT_OPTIN.ToString();

            }
            PrivacyStatus privStatusSHARE3rdPARTY = new PrivacyStatus();
            privStatusSHARE3rdPARTY.PrivacyOptionTC.tc = IntegrationCommonLib.OLI_PRIVOPT.OLI_PRIVOPT_SHARE3RDPTY.ToString();
            if (CP.PrivShare3rdPartyOptOut.Trim().Length > 0 && CP.PrivShare3rdPartyOptOut.Trim().Substring(0, 1).ToUpper() == "T")
            {
               privStatusSHARE3rdPARTY.PrivacyStatusTC.tc = IntegrationCommonLib.OLI_PRIVSTAT.OLI_PRIVSTAT_OPTOUT.ToString();
            }
            else
            {
               privStatusSHARE3rdPARTY.PrivacyStatusTC.tc = IntegrationCommonLib.OLI_PRIVSTAT.OLI_PRIVSTAT_OPTIN.ToString();

            }

            olifeExt.PartyExtension.Privacy.PrivacyStatusCollection.Add(privStatusSHARE);
            olifeExt.PartyExtension.Privacy.PrivacyStatusCollection.Add(privStatusSHARE3rdPARTY);
            //add change history
            ChangeHistory changeHistory = new ChangeHistory();
            changeHistory.Reason = "PRIVACYKEY";
            olifeExt.PartyExtension.Privacy.ChangeHistoryCollection.Add(changeHistory);



            privacyDetailParty.OLifEExtensionCollection.Add(olifeExt);

            //add party to Olife
            txlRequest.OLifE.PartyCollection.Add(privacyDetailParty);


            //TransType
            txlRequest.TransRefGUID = Guid.NewGuid().ToString();
            txlRequest.TransType = new org.acord.standards.life._2.TransType();
            txlRequest.TransType.tc = IntegrationCommonLib.OLI_TRANSTYPECODES.OLI_TRANS_INQPAR.ToString();

            //add request to life type
            txl.TXLifeRequestCollection.Add(txlRequest);

            //User info
            txl.UserAuthRequest = new UserAuthRequest();
            txl.UserAuthRequest.UserLoginName = userName;
            txl.UserAuthRequest.UserPswd.CryptType = "passwordBasedEncryption_CORE";
            PrivEncryption de = new PrivEncryption("!IdbP@55word_");
            string pwd = de.EncryptUsernamePassword(password);
            txl.UserAuthRequest.UserPswd.CryptPswd = pwd;

            updPPD.TXLife = txl;
            //hubheader
            cg.HubHeader = new HubHeaderType();
            DateTime dtNow = HubDateTime(DateTime.Now);
            cg.HubHeader.CreationTimestamp = dtNow;
            cg.HubHeader.SourceSystemId = "DataDirector";
            cg.HubHeader.Version = "1.0";
            cg.HubHeader.UserId = System.Environment.UserName.ToString();
            cg.HubHeader.BodyType = "xml/acord";
            cg.HubHeader.MessageId = new Guid().ToString();

            //writeObjectToXmlFile(@"d:\PrivRequest.xml", updPPD.TXLife, typeof(TXLife_Type));


            updatePersonPrivacyDetailResponse respPPD = cg.updatePersonPrivacyDetail(updPPD);

            if (respPPD.TXLife.TXLifeResponseCollection[0].TransResult.ResultCode.tc != "1" && respPPD.TXLife.TXLifeResponseCollection[0].TransResult.ResultCode.tc != "2")
            {
               string msg = respPPD.TXLife.TXLifeResponseCollection[0].TransResult.ResultCode.tc;
               if (respPPD.TXLife.TXLifeResponseCollection.Count > 0 &&
                     respPPD.TXLife.TXLifeResponseCollection[0].TransResult.ResultInfoCollection.Count > 0 &&
                     respPPD.TXLife.TXLifeResponseCollection[0].TransResult.ResultInfoCollection[0].ResultInfoDesc != null)
               {
                  msg += " " +respPPD.TXLife.TXLifeResponseCollection[0].TransResult.ResultInfoCollection[0].ResultInfoDesc;
               }
               throw new Exception(msg);
            }

         }
         catch (Exception ex)
         {
            throw new Exception("DataHandler.ServiceCalls.updatePrivacyDetail: " + ex.Message);
         }
      }
      public static void writeObjectToXmlFile(string fileId, object objectToConvert, System.Type objectType)
      {

         string xmlFileId = fileId;

         XmlSerializer s;

         using (TextWriter w = new StreamWriter(xmlFileId))
         {

            s = new XmlSerializer(objectType);

            s.Serialize(w, objectToConvert);

         }

      }      
      private DateTime HubDateTime(DateTime dt)
      {
         DateTime hubDate = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
         return hubDate;
      }      
      public string lookupALCCC14(ref CommonParameters CP)
      {
         string retValue;

         DataAccess dataAccess = new DataAccess();
         string urlALCCC14 = dataAccess.selectDDMainDefinitionValue("WEBSERVICE", "ALCCC14");
         ALCCC14 alccc14WS = new ALCCC14(urlALCCC14);
         Alccc14_input alcc14Input = new Alccc14_input();
         alcc14Input.Alccc14_control = CP.ControlNo;
         Alccc14_area alcc14Area = alccc14WS.CallALCCC14(alcc14Input);
         if (alcc14Area.Alccc14_msgs.Alccc14_msg_lvl.ToString() == "0")
         {
            retValue = "SUCCESS";
            if (null != alcc14Area.Alccc14_output.Alccc14_st)
            {
               CP.State = alcc14Area.Alccc14_output.Alccc14_st.ToString();
            }
            if (null != alcc14Area.Alccc14_output.Alccc14_repl)
            {
               CP.ReplacementIndicator = alcc14Area.Alccc14_output.Alccc14_repl.ToString();
            }
            if (null != alcc14Area.Alccc14_output.Alccc14_trans_type)
            {
               CP.TransType = alcc14Area.Alccc14_output.Alccc14_trans_type.ToString();
            }
            if (null != alcc14Area.Alccc14_output.Alccc14_plan_txt)
            {
               CP.ProductCategory = alcc14Area.Alccc14_output.Alccc14_plan_txt.ToString();
            }
            if (null != alcc14Area.Alccc14_output.Alccc14_wrt_agent)
            {
               CP.WritingAgent = alcc14Area.Alccc14_output.Alccc14_wrt_agent.ToString();
            }
         }
         else //webservice issue
         {
            retValue = alcc14Area.Alccc14_msgs.Alccc14_msg_text.ToString();
         }
         return retValue;


      }
      public void lookupBICEPS(ref CommonParameters CP)
      {
         DataAccess dataAccess = new DataAccess();
         string SortCode2 = String.Empty;
         string urlCLMMBR = dataAccess.selectDDMainDefinitionValue("WEBSERVICE", "CLMMBR");
         CLMMBR objCLMMBR = new CLMMBR(urlCLMMBR);
         Clmmbr_area objCLMMBR_Area = new Clmmbr_area();
         Clmmbr_input objCLMMBR_Input = new Clmmbr_input();

         objCLMMBR_Input.Clmmbr_id = CP.ID;
         objCLMMBR_Input.Clmmbr_system = CP.SystemNo;
         objCLMMBR_Input.Clmmbr_company = CP.CompanyNo;
         objCLMMBR_Input.Clmmbr_type = CP.NameType;

         string startTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
         objCLMMBR_Area = objCLMMBR.CallCLMMBR(objCLMMBR_Input);
         string endTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
         dataAccess.createPerfLogEntry(ref CP, startTime1, endTime1, "CLMMBR.CallCLMMBR", objCLMMBR_Area.Clmmbr_msgs.Clmmbr_msg_text);

         if (objCLMMBR_Area.Clmmbr_msgs.Clmmbr_msg_lvl == "0")
         {
            //objCLMMBR_Area.Clmmbr_output.Clmmbr_array[0].
            //pull back the sort code value
            CP.SortCode = objCLMMBR_Area.Clmmbr_output.Clmmbr_array[0]
               .Clmmbr_sort;
            SortCode2 = objCLMMBR_Area.Clmmbr_output.Clmmbr_array[0]
               .Clmmbr_sort2;
            CP.PlanCode = objCLMMBR_Area.Clmmbr_output.Clmmbr_array[0]
               .Clmmbr_plan;
            //we also want the bicps company
            CP.CompanyCodeBICPS = objCLMMBR_Area.Clmmbr_output.Clmmbr_bicps_cmp;
            //if the value returned was empty then default to 000
            if (CP.SortCode.Length == 0 || CP.SortCode.Trim() == "0")
            {
               if (SortCode2.Trim().Length > 0)
               {
                  CP.SortCode = SortCode2.Trim();
               }
               else
               {
                  CP.SortCode = "0";
               }
            }
            //before we lookup the lob we need to format the value returned
            //to ensure we have a 3 digit number
            CP.SortCode = CP.SortCode.Trim().PadLeft(3, '0');
         }
         else
         {
            //if there was an error performing the search, 
            //default the sort code to blank.
            CP.SortCode = "";
         }
      }
      public void lookupSharp(ref CommonParameters CP)
      {
         DataAccess dataAccess = new DataAccess();
         string urlSHRPGEN = dataAccess.selectDDMainDefinitionValue("WEBSERVICE", "SHRPGEN");
         SHRPGEN objSHRPGen = new SHRPGEN(urlSHRPGEN);
         Shrpgen_input objSHRPGen_Input = new Shrpgen_input();
         Shrpgen_area objSHRPGen_Area = new Shrpgen_area();

         objSHRPGen_Input.Shrpgen_type = CP.NameType;
         objSHRPGen_Input.Shrpgen_system = CP.SystemNo;
         objSHRPGen_Input.Shrpgen_company = CP.CompanyNo;
         objSHRPGen_Input.Shrpgen_id = CP.ID;
         try
         {
            string startTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            objSHRPGen_Area = objSHRPGen.CallSHRPGEN(objSHRPGen_Input);
            string endTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            dataAccess.createPerfLogEntry(ref CP, startTime1, endTime1, "SHRPGEN.CallSHRPGEN", objSHRPGen_Area.Shrpgen_msgs.Shrpgen_msg_text);


            if (objSHRPGen_Area.Shrpgen_msgs.Shrpgen_msg_lvl == "0")
            {
               //pull back the issue state and date values

               //AR145620 - START
               if (CP.IssueState.Length == 0 && objSHRPGen_Area.Shrpgen_output.Shrpgen_issue_st.Length > 0)
               {
                   //If CP value is null and SHARP field has a value then set CP with SHARP value
                   CP.IssueState = objSHRPGen_Area.Shrpgen_output.Shrpgen_issue_st;
               }
               else if (CP.IssueState.Length > 0 && objSHRPGen_Area.Shrpgen_output.Shrpgen_issue_st.Length == 0)
               {
                   //If SHARP field is null and CP has a value then set SHARP field with CP value
                   objSHRPGen_Area.Shrpgen_output.Shrpgen_issue_st = CP.IssueState;
               }
               else if (CP.IssueState.Length > 0 && objSHRPGen_Area.Shrpgen_output.Shrpgen_issue_st.Length > 0 &&
                   CP.IssueState.ToString() != objSHRPGen_Area.Shrpgen_output.Shrpgen_issue_st.ToString())
               {
                   //If both CP and SHARP fields have values then CP should be considered as the final one
                   objSHRPGen_Area.Shrpgen_output.Shrpgen_issue_st = CP.IssueState;
               }

               if (CP.IssueDate.Length == 0 && objSHRPGen_Area.Shrpgen_output.Shrpgen_issue_dt.Length > 0)
               {
                   //If CP value is null and SHARP field has a value then set CP with SHARP value
                   CP.IssueDate = objSHRPGen_Area.Shrpgen_output.Shrpgen_issue_dt;
               }
               else if (CP.IssueDate.Length > 0 && objSHRPGen_Area.Shrpgen_output.Shrpgen_issue_dt.Length == 0)
               {
                   //If SHARP field is null and CP has a value then set SHARP field with CP value
                   objSHRPGen_Area.Shrpgen_output.Shrpgen_issue_dt = CP.IssueDate;
               }
               else if (CP.IssueDate.Length > 0 && objSHRPGen_Area.Shrpgen_output.Shrpgen_issue_dt.Length > 0 &&
                   CP.IssueDate.ToString() != objSHRPGen_Area.Shrpgen_output.Shrpgen_issue_dt.ToString())
               {
                   //If both CP and SHARP fields have values then CP should be considered as the final one
                   objSHRPGen_Area.Shrpgen_output.Shrpgen_issue_dt = CP.IssueDate;
               }
               //AR145620 - END                

               //and the plan code
               if (objSHRPGen_Area.Shrpgen_output.Shrpgen_plan_array[0].Shrpgen_plan_cd.Length > 0)
               {
                  if (CP.PlanCode.Length == 0)
                  {
                     CP.PlanCode = objSHRPGen_Area.Shrpgen_output.Shrpgen_plan_array[0].Shrpgen_plan_cd;
                  }
               }
               if (CP.CompanyCodeBICPS.Length == 0 || IsNumeric(CP.CompanyCodeBICPS))
               {
                  CP.CompanyCodeBICPS = objSHRPGen_Area.Shrpgen_output.Shrpgen_company_cd;
               }
            }
         }
         catch (Exception ex)
         {
            //something bad happened
            throw new Exception("DataHandler.ServiceCalls.lookupSharp: " + ex.Message);
         }
      }
      public void lookupLifePro(ref CommonParameters CP)
      {
         DataAccess dataAccess = new DataAccess();
         string urlLPXGEN = dataAccess.selectDDMainDefinitionValue("WEBSERVICE", "LPXGEN");
         LPXGEN objLPXGen = new LPXGEN(urlLPXGEN);
         Lpgen_Input objLPXGen_Input = new Lpgen_Input();
         Lpgen_Area objLPXGen_Area = new Lpgen_Area();

         objLPXGen_Input.Lpgen_Type = CP.NameType;
         objLPXGen_Input.Lpgen_System = CP.SystemNo;
         objLPXGen_Input.Lpgen_Company = CP.CompanyNo;
         objLPXGen_Input.Lpgen_Id = CP.ID;
         try
         {
            string startTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            objLPXGen_Area = objLPXGen.DOLPXGEN(objLPXGen_Input);
            string endTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            dataAccess.createPerfLogEntry(ref CP, startTime1, endTime1, "LPXGEN.DOLPXGEN", objLPXGen_Area.Lpgen_Msgs.Lpgen_Msg_Text);
            
            if (objLPXGen_Area.Lpgen_Msgs.Lpgen_Msg_Lvl == "0")
            {
               //pull back the issue state value

               //AR145620 - START
               if (CP.IssueState.Length == 0 && objLPXGen_Area.Lpgen_Output.Lpgen_Iss_State.Length > 0)
               {
                   //If CP value is null and LifePro field has a value then set CP with LifePro value
                   CP.IssueState = objLPXGen_Area.Lpgen_Output.Lpgen_Iss_State;
               }
               else if (CP.IssueState.Length > 0 && objLPXGen_Area.Lpgen_Output.Lpgen_Iss_State.Length == 0)
               {
                   //If LifePro field is null and CP has a value then set LifePro field with CP value
                   objLPXGen_Area.Lpgen_Output.Lpgen_Iss_State = CP.IssueState;
               }
               else if (CP.IssueState.Length > 0 && objLPXGen_Area.Lpgen_Output.Lpgen_Iss_State.Length > 0 &&
                   CP.IssueState.ToString() != objLPXGen_Area.Lpgen_Output.Lpgen_Iss_State.ToString())
               {
                   //If both CP and LifePro fields have values then CP should be considered as the final one
                   objLPXGen_Area.Lpgen_Output.Lpgen_Iss_State = CP.IssueState;
               }

               if (CP.IssueDate.Length == 0 && objLPXGen_Area.Lpgen_Output.Lpgen_Iss_Dt.Length > 0)
               {
                   //If CP value is null and LifePro field has a value then set CP with LifePro value
                   CP.IssueDate = objLPXGen_Area.Lpgen_Output.Lpgen_Iss_Dt;
               }
               else if (CP.IssueDate.Length > 0 && objLPXGen_Area.Lpgen_Output.Lpgen_Iss_Dt.Length == 0)
               {
                   //If LifePro field is null and CP has a value then set LifePro field with CP value
                   objLPXGen_Area.Lpgen_Output.Lpgen_Iss_Dt = CP.IssueDate;
               }
               else if (CP.IssueDate.Length > 0 && objLPXGen_Area.Lpgen_Output.Lpgen_Iss_Dt.Length > 0 &&
                   CP.IssueDate.ToString() != objLPXGen_Area.Lpgen_Output.Lpgen_Iss_Dt.ToString())
               {
                   //If both CP and LifePro fields have values then CP should be considered as the final one
                   objLPXGen_Area.Lpgen_Output.Lpgen_Iss_Dt = CP.IssueDate;
               }

               //Pull Effective Date
               if (objLPXGen_Area.Lpgen_Output.Lpcov_Record[0].Lpcov_Eff_Dt.Length > 0)
               {
                   if (CP.EffectiveDate == null || CP.EffectiveDate.Length == 0 || CP.EffectiveDate == "")
                   {
                       CP.EffectiveDate = objLPXGen_Area.Lpgen_Output.Lpcov_Record[0].Lpcov_Eff_Dt;
                   }
               }
               //AR145620 - END

               //and the plan code
               if (objLPXGen_Area.Lpgen_Output.Lpcov_Record[0].Lpcov_Plan.Length > 0)
               {
                  if (CP.PlanCode.Length == 0)
                  {
                     CP.PlanCode = objLPXGen_Area.Lpgen_Output.Lpcov_Record[0].Lpcov_Plan;
                  }
               }
            }
            if (CP.CompanyCodeBICPS.Length == 0 || IsNumeric(CP.CompanyCodeBICPS))
            {
               CP.CompanyCodeBICPS = objLPXGen_Area.Lpgen_Output.Lpcov_Record[0].Lpcov_Cmp;
            }

         }
         catch (Exception ex)
         {
            if (ex.Message.ToUpper().Contains("PURGED"))
            {
               return;
            }
            //something bad happened
            throw new Exception("DataValidation.Validation.lookupLifePro: " + ex.Message);
         }
      }
      public void lookupCS01(ref CommonParameters CP)
      {
         DataAccess dataAccess = new DataAccess();
         string urlCS01GEN = dataAccess.selectDDMainDefinitionValue("WEBSERVICE", "CS01GEN");
         CS01GEN objCS01Gen = new CS01GEN(urlCS01GEN);
         Cs01gen_input objCS01Gen_Input = new Cs01gen_input();
         Cs01gen_area objCS01Gen_Area = new Cs01gen_area();

         objCS01Gen_Input.Cs01gen_type = CP.NameType;
         objCS01Gen_Input.Cs01gen_system = CP.SystemNo;
         objCS01Gen_Input.Cs01gen_company = CP.CompanyNo;
         objCS01Gen_Input.Cs01gen_id = CP.ID;
         try
         {
            string startTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            objCS01Gen_Area = objCS01Gen.CallCS01GEN(objCS01Gen_Input);
            string endTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            dataAccess.createPerfLogEntry(ref CP, startTime1, endTime1, "CS01GEN.CallCS01GEN", objCS01Gen_Area.Cs01gen_msgs.Cs01gen_msg_text);


            if (objCS01Gen_Area.Cs01gen_msgs.Cs01gen_msg_lvl == "0")
            {
               //pull back the issue state value
               
               //AR145620 - START
                if (CP.IssueState.Length == 0 && objCS01Gen_Area.Cs01gen_output.Cs01gen_gen_issue_st.Length > 0)
               {
                   //If CP value is null and CS01 field has a value then set CP with CS01 value
                   CP.IssueState = objCS01Gen_Area.Cs01gen_output.Cs01gen_gen_issue_st;
               }
                else if (CP.IssueState.Length > 0 && objCS01Gen_Area.Cs01gen_output.Cs01gen_gen_issue_st.Length == 0)
               {
                   //If CS01 field is null and CP has a value then set CS01 field with CP value
                   objCS01Gen_Area.Cs01gen_output.Cs01gen_gen_issue_st = CP.IssueState;
               }
                else if (CP.IssueState.Length > 0 && objCS01Gen_Area.Cs01gen_output.Cs01gen_gen_issue_st.Length > 0 &&
                   CP.IssueState.ToString() != objCS01Gen_Area.Cs01gen_output.Cs01gen_gen_issue_st.ToString())
               {
                   //If both CP and CS01 fields have values then CP should be considered as the final one
                   objCS01Gen_Area.Cs01gen_output.Cs01gen_gen_issue_st = CP.IssueState;
               }

                if (CP.IssueDate.Length == 0 && objCS01Gen_Area.Cs01gen_output.Cs01gen_val_system_iss_dt.Length > 0)
               {
                   //If CP value is null and CS01 field has a value then set CP with CS01 value
                   CP.IssueDate = objCS01Gen_Area.Cs01gen_output.Cs01gen_val_system_iss_dt;
               }
                else if (CP.IssueDate.Length > 0 && objCS01Gen_Area.Cs01gen_output.Cs01gen_val_system_iss_dt.Length == 0)
               {
                   //If LifePro field is null and CP has a value then set CS01 field with CP value
                   objCS01Gen_Area.Cs01gen_output.Cs01gen_val_system_iss_dt = CP.IssueDate;
               }
                else if (CP.IssueDate.Length > 0 && objCS01Gen_Area.Cs01gen_output.Cs01gen_val_system_iss_dt.Length > 0 &&
                   CP.IssueDate.ToString() != objCS01Gen_Area.Cs01gen_output.Cs01gen_val_system_iss_dt.ToString())
               {
                   //If both CP and CS01 fields have values then CP should be considered as the final one
                   objCS01Gen_Area.Cs01gen_output.Cs01gen_val_system_iss_dt = CP.IssueDate;
               }                

               //Pull Effective Date
               if (objCS01Gen_Area.Cs01gen_output.Cs01gen_covg_eff_date.Length > 0)
               {
                   if (CP.EffectiveDate == null || CP.EffectiveDate.Length == 0 || CP.EffectiveDate == "")
                   {
                       CP.EffectiveDate = objCS01Gen_Area.Cs01gen_output.Cs01gen_covg_eff_date;
                   }
               }
               //AR145620 - END

               //and the plan code
               if (objCS01Gen_Area.Cs01gen_output.Cs01gen_covg_array[0].Cs01gen_covg_plan.Length > 0)
               {
                  if (CP.PlanCode.Length == 0)
                  {
                     CP.PlanCode = objCS01Gen_Area.Cs01gen_output.Cs01gen_covg_array[0].Cs01gen_covg_plan;
                  }
               }
            }
         }
         catch (Exception ex)
         {
            //something bad happened
            throw new Exception("DataValidation.Validation.lookupCS01: " + ex.Message);
         }
      }
      public Qdetl2_area lookupPOPCodes(ref CommonParameters CP)
      {
         DataAccess dataAccess = new DataAccess();
         string urlQDETL2 = dataAccess.selectDDMainDefinitionValue("WEBSERVICE", "QDETL2");
         QDETL2 objQDETL2 = new QDETL2(urlQDETL2);
         Qdetl2_input objQDETL2_Input = new Qdetl2_input();
         Qdetl2_area objQDETL2_Area = new Qdetl2_area();

         objQDETL2_Input.Qdetl2_id = CP.ID;
         objQDETL2_Input.Qdetl2_system = CP.SystemNo;
         objQDETL2_Input.Qdetl2_company = CP.CompanyNo;
         objQDETL2_Input.Qdetl2_type = CP.NameType;

         string startTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
         objQDETL2_Area = objQDETL2.CallQDETL2(objQDETL2_Input);
         string endTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
         dataAccess.createPerfLogEntry(ref CP, startTime1, endTime1, "QDETL2.CallQDETL2", objQDETL2_Area.Qdetl2_msgs.Qdetl2_msg_text);
          
         return objQDETL2_Area;
      }
      public QSRCH2 getQSRCH2()
      {
         DataAccess dataAccess = new DataAccess();
         string urlQSRCH2 = dataAccess.selectDDMainDefinitionValue("WEBSERVICE", "QSRCH2");
         return new QSRCH2(urlQSRCH2);
      }
      public SelectPerson getSelectPerson()
      {
         DataAccess dataAccess = new DataAccess();
         string urlSelectPerson = dataAccess.selectDDMainDefinitionValue("WEBSERVICE", "SelectPerson");
         return new SelectPerson(urlSelectPerson);
      }
      public string generateBundleNo(ref CommonParameters CP)
      {
      failedLoginRestart:
         try
         {


            //next we need to store the values
            BPA.Framework.XML.Writer xmlWriter = new BPA.Framework.XML
               .Writer(CONFIG_PATH + "datadirector.xml");
            //we need a new handle to the main config
            BPA.Framework.XML.Parser xmlParser = new BPA.Framework.XML.Parser(
               CONFIG_PATH + "datadirector.xml");


            DataAccess dataAccess = new DataAccess();
            string urlCLMBCNCU = dataAccess.selectDDMainDefinitionValue("WEBSERVICE", "CLMBCNCU");
            CLMBCNCU clmbcncuWS = new CLMBCNCU(urlCLMBCNCU);


            Clmbcncu_input clmbcncuInput = new Clmbcncu_input();

            Clmbcncu_area clmbcncuArea = new Clmbcncu_area();
            //we also need an instance of the encryption class
            BPA.Framework.Cryptography crypto = new BPA.Framework.Cryptography();
            //first let's check for current login info
            _tpxUser = xmlParser.GetCustomAttribute("Configuration/TPX", "usr");
            _tpxPassword = xmlParser.GetCustomAttribute("Configuration/TPX", "pwd");
            if (_tpxPassword.Length != 0 & _tpxUser.Length != 0)
            {
               _tpxUser = crypto.Decrypt(_tpxUser);
               _tpxPassword = crypto.Decrypt(_tpxPassword);
            }
            else
            {
               //prompt user for credentials
               frmTPXCredentials tpxForm = new frmTPXCredentials();
               DialogResult dr = tpxForm.ShowDialog();
               switch (dr)
               {
                  case DialogResult.Cancel:
                     //should we leave or prompt?
                     return "";
                  case DialogResult.OK:
                     //first we need to pull back the values
                     _tpxUser = tpxForm.TPXUser;
                     _tpxPassword = tpxForm.TPXPassword;
                     xmlWriter.SetCustomAttribute("Configuration/TPX", "usr",
                        crypto.Encrypt(_tpxUser));
                     xmlWriter.SetCustomAttribute("Configuration/TPX", "pwd",
                        crypto.Encrypt(_tpxPassword));
                     break;
                  default:
                     //leave
                     return "";
               }
            }

            //provide login credentials
            zAuthPwd authUserInfo = new zAuthPwd();
            authUserInfo.UserId = _tpxUser;
            authUserInfo.Password = crypto.EncodeTo64(_tpxPassword.ToUpper());
            clmbcncuWS.zAuthPwdValue = authUserInfo;
            clmbcncuInput.Clmbcncu_company = CP.CompanyNo;
            clmbcncuInput.Clmbcncu_system = CP.SystemNo;
            clmbcncuInput.Clmbcncu_id = CP.ID;
            clmbcncuInput.Clmbcncu_type = CP.NameType;
            clmbcncuArea = clmbcncuWS.CallCLMBCNCU(clmbcncuInput);

            if (clmbcncuArea.Clmbcncu_msgs.Clmbcncu_msg_lvl.ToString() == "0")
            {
               //pull back the bundle no
               CP.BundleNo = clmbcncuArea.Clmbcncu_output.Clmbcncu_bundle_nbr.ToString();
               return CP.BundleNo;
            }
            else
            {
               return "";
            }
         }
         catch (System.Net.WebException webex)
         {
            if (webex.Message.Contains("Unauthorized"))
            {
               //next we need to blank out the bad values
               BPA.Framework.XML.Writer xmlWriter = new BPA.Framework.XML
                  .Writer(CONFIG_PATH + "datadirector.xml");
               xmlWriter.SetCustomAttribute("Configuration/TPX", "usr",
                  "");
               xmlWriter.SetCustomAttribute("Configuration/TPX", "pwd",
                  "");
               //next we need to go back to the user form and 
               //ask for the user's credentials again.
               goto failedLoginRestart;
            }
            throw new Exception("ServiceCalls.generateBundleNo: " + webex.Message);
         }
         catch (Exception ex)
         {
            throw new Exception("ServiceCalls.generateBundleNo: " + ex.Message);
         }
      }
      //private void lookupLifePro(ref CommonParameters CP)
      //{
      //    DataAccess dataAccess = new DataAccess();
      //    string urlLPGEN = dataAccess.selectDDMainDefinitionValue("WEBSERVICE", "LPGEN");
      //    LifePROPolicyGeneral objLPGen = new LifePROPolicyGeneral(urlLPGEN);
      //    getGeneralPolicyDetailType objLPGen_Input = new getGeneralPolicyDetailType();
      //    TXLife objTXLife = objLPGen_Input.TXLife;




      //    TXLifeRequest[] objTXLifeRequest = objTXLife.TXLifeRequest;
      //    objTXLifeRequest[0].id = CP.ID;
      //    objLPGen.getGeneralPolicyDetail(objLPGen_Input);

      //    Lpgen_Input objLPXGen_Input = new Lpgen_Input();
      //    Lpgen_Area objLPXGen_Area = new Lpgen_Area();

      //    try
      //    {
      //        objLPXGen_Area = objLPXGen.DOLPXGEN(objLPXGen_Input);

      //        if (objLPXGen_Area.Lpgen_Msgs.Lpgen_Msg_Lvl == "0")
      //        {
      //            //pull back the issue state value
      //            CP.IssueState = objLPXGen_Area.Lpgen_Output.Lpgen_Iss_State;
      //            CP.IssueDate = objLPXGen_Area.Lpgen_Output.Lpgen_Iss_Dt;
      //            //and the plan code
      //            if (objLPXGen_Area.Lpgen_Output.Lpcov_Record[0].Lpcov_Plan.Length > 0)
      //            {
      //                if (CP.PlanCode.Length == 0)
      //                {
      //                    CP.PlanCode = objLPXGen_Area.Lpgen_Output.Lpcov_Record[0].Lpcov_Plan;
      //                }
      //            }
      //        }
      //    }
      //    catch (Exception ex)
      //    {
      //        if (ex.Message.ToUpper().Contains("PURGED"))
      //        {
      //            return;
      //        }
      //        //something bad happened
      //        throw new Exception("DataValidation.Validation.lookupLifePro: " + ex.Message);
      //    }
      //}
      private bool IsNumeric(string p)
      {
         int outVal;
         bool result;
         result = int.TryParse(p, out outVal);
         return result;
      }

   }
}
