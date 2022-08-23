﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3620
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
namespace CNO.BPA.DataHandler
{
   // 
   // This source code was auto-generated by wsdl, Version=2.0.50727.1432.
   // 



   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Web.Services.WebServiceBindingAttribute(Name = "ALCCC14Soap", Namespace = "HTTP://SHADOW.CONSECO.COM/PAL/ALCCC14")]
   public partial class ALCCC14 : System.Web.Services.Protocols.SoapHttpClientProtocol
   {

      private System.Threading.SendOrPostCallback CallALCCC14OperationCompleted;

      /// <remarks/>
      public ALCCC14(string URL)
      {
         //this.Url = "http://MFWEBT.CONSECO.COM:6111/PAL/ALCCC14.zws";
         this.Url = URL;
      }

      /// <remarks/>
      public event CallALCCC14CompletedEventHandler CallALCCC14Completed;

      /// <remarks/>
      [System.Web.Services.Protocols.SoapDocumentMethodAttribute("HTTP://SHADOW.CONSECO.COM/PAL/ALCCC14/ALCCC14", RequestElementName = "ALCCC14", RequestNamespace = "HTTP://SHADOW.CONSECO.COM/PAL/ALCCC14", ResponseElementName = "ALCCC14Response", ResponseNamespace = "HTTP://SHADOW.CONSECO.COM/PAL/ALCCC14", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
      [return: System.Xml.Serialization.XmlElementAttribute("ALCCC14Result")]
      public Alccc14_area CallALCCC14(Alccc14_input ALCCC14Input)
      {
         object[] results = this.Invoke("CallALCCC14", new object[] {
                    ALCCC14Input});
         return ((Alccc14_area)(results[0]));
      }

      /// <remarks/>
      public System.IAsyncResult BeginCallALCCC14(Alccc14_input ALCCC14Input, System.AsyncCallback callback, object asyncState)
      {
         return this.BeginInvoke("CallALCCC14", new object[] {
                    ALCCC14Input}, callback, asyncState);
      }

      /// <remarks/>
      public Alccc14_area EndCallALCCC14(System.IAsyncResult asyncResult)
      {
         object[] results = this.EndInvoke(asyncResult);
         return ((Alccc14_area)(results[0]));
      }

      /// <remarks/>
      public void CallALCCC14Async(Alccc14_input ALCCC14Input)
      {
         this.CallALCCC14Async(ALCCC14Input, null);
      }

      /// <remarks/>
      public void CallALCCC14Async(Alccc14_input ALCCC14Input, object userState)
      {
         if ((this.CallALCCC14OperationCompleted == null))
         {
            this.CallALCCC14OperationCompleted = new System.Threading.SendOrPostCallback(this.OnCallALCCC14OperationCompleted);
         }
         this.InvokeAsync("CallALCCC14", new object[] {
                    ALCCC14Input}, this.CallALCCC14OperationCompleted, userState);
      }

      private void OnCallALCCC14OperationCompleted(object arg)
      {
         if ((this.CallALCCC14Completed != null))
         {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.CallALCCC14Completed(this, new CallALCCC14CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
         }
      }

      /// <remarks/>
      public new void CancelAsync(object userState)
      {
         base.CancelAsync(userState);
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace = "HTTP://SHADOW.CONSECO.COM/PAL/ALCCC14")]
   public partial class Alccc14_input
   {

      private string alccc14_controlField;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_control
      {
         get
         {
            return this.alccc14_controlField;
         }
         set
         {
            this.alccc14_controlField = value;
         }
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace = "HTTP://SHADOW.CONSECO.COM/PAL/ALCCC14")]
   public partial class Alccc14_areaAlccc14_output
   {

      private string alccc14_activity_dateField;

      private string alccc14_cmp1Field;

      private string alccc14_cmp2Field;

      private string alccc14_dsoField;

      private string alccc14_bsoField;

      private string alccc14_combo_appField;

      private string alccc14_relate_prevappField;

      private string alccc14_master_controlField;

      private string alccc14_lead_sourceField;

      private string alccc14_assocField;

      private string alccc14_new_groupField;

      private string alccc14_replField;

      private string alccc14_sign_dtField;

      private string alccc14_appl_lastField;

      private string alccc14_appl_middleField;

      private string alccc14_appl_firstField;

      private string alccc14_appl_suffixField;

      private string alccc14_appl_ageField;

      private string alccc14_appl_age_cdField;

      private string alccc14_streetField;

      private string alccc14_cityField;

      private string alccc14_stField;

      private string alccc14_zipField;

      private string alccc14_phoneField;

      private string alccc14_trans_typeField;

      private string alccc14_helpField;

      private string alccc14_plan_cdField;

      private string alccc14_plan_txtField;

      private string alccc14_faxField;

      private string alccc14_coField;

      private string alccc14_policyField;

      private string alccc14_check_amtField;

      private string alccc14_annl_premField;

      private string alccc14_check_nbrField;

      private string alccc14_roll_overField;

      private string alccc14_tot_commisField;

      private string alccc14_wrt_agentField;

      private string alccc14_wrt_lastField;

      private string alccc14_wrt_orgField;

      private string alccc14_wrt_pctField;

      private string alccc14_spl_agentField;

      private string alccc14_spl_lastField;

      private string alccc14_spl_orgField;

      private string alccc14_spl_pctField;

      private string alccc14_lst_chgField;

      private string alccc14_useridField;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_activity_date
      {
         get
         {
            return this.alccc14_activity_dateField;
         }
         set
         {
            this.alccc14_activity_dateField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_cmp1
      {
         get
         {
            return this.alccc14_cmp1Field;
         }
         set
         {
            this.alccc14_cmp1Field = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_cmp2
      {
         get
         {
            return this.alccc14_cmp2Field;
         }
         set
         {
            this.alccc14_cmp2Field = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_dso
      {
         get
         {
            return this.alccc14_dsoField;
         }
         set
         {
            this.alccc14_dsoField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_bso
      {
         get
         {
            return this.alccc14_bsoField;
         }
         set
         {
            this.alccc14_bsoField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_combo_app
      {
         get
         {
            return this.alccc14_combo_appField;
         }
         set
         {
            this.alccc14_combo_appField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_relate_prevapp
      {
         get
         {
            return this.alccc14_relate_prevappField;
         }
         set
         {
            this.alccc14_relate_prevappField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_master_control
      {
         get
         {
            return this.alccc14_master_controlField;
         }
         set
         {
            this.alccc14_master_controlField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_lead_source
      {
         get
         {
            return this.alccc14_lead_sourceField;
         }
         set
         {
            this.alccc14_lead_sourceField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_assoc
      {
         get
         {
            return this.alccc14_assocField;
         }
         set
         {
            this.alccc14_assocField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_new_group
      {
         get
         {
            return this.alccc14_new_groupField;
         }
         set
         {
            this.alccc14_new_groupField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_repl
      {
         get
         {
            return this.alccc14_replField;
         }
         set
         {
            this.alccc14_replField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_sign_dt
      {
         get
         {
            return this.alccc14_sign_dtField;
         }
         set
         {
            this.alccc14_sign_dtField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_appl_last
      {
         get
         {
            return this.alccc14_appl_lastField;
         }
         set
         {
            this.alccc14_appl_lastField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_appl_middle
      {
         get
         {
            return this.alccc14_appl_middleField;
         }
         set
         {
            this.alccc14_appl_middleField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_appl_first
      {
         get
         {
            return this.alccc14_appl_firstField;
         }
         set
         {
            this.alccc14_appl_firstField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_appl_suffix
      {
         get
         {
            return this.alccc14_appl_suffixField;
         }
         set
         {
            this.alccc14_appl_suffixField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_appl_age
      {
         get
         {
            return this.alccc14_appl_ageField;
         }
         set
         {
            this.alccc14_appl_ageField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_appl_age_cd
      {
         get
         {
            return this.alccc14_appl_age_cdField;
         }
         set
         {
            this.alccc14_appl_age_cdField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_street
      {
         get
         {
            return this.alccc14_streetField;
         }
         set
         {
            this.alccc14_streetField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_city
      {
         get
         {
            return this.alccc14_cityField;
         }
         set
         {
            this.alccc14_cityField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_st
      {
         get
         {
            return this.alccc14_stField;
         }
         set
         {
            this.alccc14_stField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_zip
      {
         get
         {
            return this.alccc14_zipField;
         }
         set
         {
            this.alccc14_zipField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_phone
      {
         get
         {
            return this.alccc14_phoneField;
         }
         set
         {
            this.alccc14_phoneField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_trans_type
      {
         get
         {
            return this.alccc14_trans_typeField;
         }
         set
         {
            this.alccc14_trans_typeField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_help
      {
         get
         {
            return this.alccc14_helpField;
         }
         set
         {
            this.alccc14_helpField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_plan_cd
      {
         get
         {
            return this.alccc14_plan_cdField;
         }
         set
         {
            this.alccc14_plan_cdField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_plan_txt
      {
         get
         {
            return this.alccc14_plan_txtField;
         }
         set
         {
            this.alccc14_plan_txtField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_fax
      {
         get
         {
            return this.alccc14_faxField;
         }
         set
         {
            this.alccc14_faxField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_co
      {
         get
         {
            return this.alccc14_coField;
         }
         set
         {
            this.alccc14_coField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_policy
      {
         get
         {
            return this.alccc14_policyField;
         }
         set
         {
            this.alccc14_policyField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_check_amt
      {
         get
         {
            return this.alccc14_check_amtField;
         }
         set
         {
            this.alccc14_check_amtField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_annl_prem
      {
         get
         {
            return this.alccc14_annl_premField;
         }
         set
         {
            this.alccc14_annl_premField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_check_nbr
      {
         get
         {
            return this.alccc14_check_nbrField;
         }
         set
         {
            this.alccc14_check_nbrField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_roll_over
      {
         get
         {
            return this.alccc14_roll_overField;
         }
         set
         {
            this.alccc14_roll_overField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_tot_commis
      {
         get
         {
            return this.alccc14_tot_commisField;
         }
         set
         {
            this.alccc14_tot_commisField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_wrt_agent
      {
         get
         {
            return this.alccc14_wrt_agentField;
         }
         set
         {
            this.alccc14_wrt_agentField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_wrt_last
      {
         get
         {
            return this.alccc14_wrt_lastField;
         }
         set
         {
            this.alccc14_wrt_lastField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_wrt_org
      {
         get
         {
            return this.alccc14_wrt_orgField;
         }
         set
         {
            this.alccc14_wrt_orgField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_wrt_pct
      {
         get
         {
            return this.alccc14_wrt_pctField;
         }
         set
         {
            this.alccc14_wrt_pctField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_spl_agent
      {
         get
         {
            return this.alccc14_spl_agentField;
         }
         set
         {
            this.alccc14_spl_agentField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_spl_last
      {
         get
         {
            return this.alccc14_spl_lastField;
         }
         set
         {
            this.alccc14_spl_lastField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_spl_org
      {
         get
         {
            return this.alccc14_spl_orgField;
         }
         set
         {
            this.alccc14_spl_orgField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_spl_pct
      {
         get
         {
            return this.alccc14_spl_pctField;
         }
         set
         {
            this.alccc14_spl_pctField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_lst_chg
      {
         get
         {
            return this.alccc14_lst_chgField;
         }
         set
         {
            this.alccc14_lst_chgField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_userid
      {
         get
         {
            return this.alccc14_useridField;
         }
         set
         {
            this.alccc14_useridField = value;
         }
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace = "HTTP://SHADOW.CONSECO.COM/PAL/ALCCC14")]
   public partial class Alccc14_areaAlccc14_msgs
   {

      private string alccc14_msg_lvlField;

      private string alccc14_msg_textField;

      private string alccc14_sys_textField;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_msg_lvl
      {
         get
         {
            return this.alccc14_msg_lvlField;
         }
         set
         {
            this.alccc14_msg_lvlField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_msg_text
      {
         get
         {
            return this.alccc14_msg_textField;
         }
         set
         {
            this.alccc14_msg_textField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_sys_text
      {
         get
         {
            return this.alccc14_sys_textField;
         }
         set
         {
            this.alccc14_sys_textField = value;
         }
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace = "HTTP://SHADOW.CONSECO.COM/PAL/ALCCC14")]
   public partial class Alccc14_areaAlccc14_input
   {

      private string alccc14_controlField;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public string Alccc14_control
      {
         get
         {
            return this.alccc14_controlField;
         }
         set
         {
            this.alccc14_controlField = value;
         }
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace = "HTTP://SHADOW.CONSECO.COM/PAL/ALCCC14")]
   public partial class Alccc14_area
   {

      private Alccc14_areaAlccc14_input alccc14_inputField;

      private Alccc14_areaAlccc14_msgs alccc14_msgsField;

      private Alccc14_areaAlccc14_output alccc14_outputField;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public Alccc14_areaAlccc14_input Alccc14_input
      {
         get
         {
            return this.alccc14_inputField;
         }
         set
         {
            this.alccc14_inputField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public Alccc14_areaAlccc14_msgs Alccc14_msgs
      {
         get
         {
            return this.alccc14_msgsField;
         }
         set
         {
            this.alccc14_msgsField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
      public Alccc14_areaAlccc14_output Alccc14_output
      {
         get
         {
            return this.alccc14_outputField;
         }
         set
         {
            this.alccc14_outputField = value;
         }
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
   public delegate void CallALCCC14CompletedEventHandler(object sender, CallALCCC14CompletedEventArgs e);

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   public partial class CallALCCC14CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
   {

      private object[] results;

      internal CallALCCC14CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
         base(exception, cancelled, userState)
      {
         this.results = results;
      }

      /// <remarks/>
      public Alccc14_area Result
      {
         get
         {
            this.RaiseExceptionIfNecessary();
            return ((Alccc14_area)(this.results[0]));
         }
      }
   }
}
