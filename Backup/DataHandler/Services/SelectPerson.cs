﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3082
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
   // This source code was auto-generated by wsdl, Version=2.0.50727.42.
   // 


   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Web.Services.WebServiceBindingAttribute(Name = "SelectPersonSOAP", Namespace = "http://bpa.conseco.ws/SelectPerson/")]
   public partial class SelectPerson : System.Web.Services.Protocols.SoapHttpClientProtocol
   {

      private System.Threading.SendOrPostCallback LookupOperationCompleted;

      private System.Threading.SendOrPostCallback CallSelectPersonOperationCompleted;

      //This method was added to the auto generated code to correct an issue in .net where it tries to keep the connection
      //to the web server alive.  When dealing with a clustered environment, this caused issues and this code corrects it.
      protected override System.Net.WebRequest GetWebRequest(Uri uri)
      {

         System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)base.GetWebRequest(uri);

         webRequest.KeepAlive = false;

         return webRequest;

      }


      /// <remarks/>
      public SelectPerson(string URL)
      {
         //this.Url = "http://c65018.conseco.ad:9081/SelectPerson/services/SelectPersonPort";
         this.Url = URL;
      }

      /// <remarks/>
      public event LookupCompletedEventHandler LookupCompleted;

      /// <remarks/>
      public event CallSelectPersonCompletedEventHandler CallSelectPersonCompleted;

      /// <remarks/>
      [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://bpa.conseco.ws/SelectPerson/LookUp", RequestNamespace = "http://bpa.conseco.ws/SelectPerson/", ResponseNamespace = "http://bpa.conseco.ws/SelectPerson/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
      [return: System.Xml.Serialization.XmlElementAttribute("out", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public LookUpResults Lookup([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string @in)
      {
         object[] results = this.Invoke("Lookup", new object[] {
                    @in});
         return ((LookUpResults)(results[0]));
      }

      /// <remarks/>
      public System.IAsyncResult BeginLookup(string @in, System.AsyncCallback callback, object asyncState)
      {
         return this.BeginInvoke("Lookup", new object[] {
                    @in}, callback, asyncState);
      }

      /// <remarks/>
      public LookUpResults EndLookup(System.IAsyncResult asyncResult)
      {
         object[] results = this.EndInvoke(asyncResult);
         return ((LookUpResults)(results[0]));
      }

      /// <remarks/>
      public void LookupAsync(string @in)
      {
         this.LookupAsync(@in, null);
      }

      /// <remarks/>
      public void LookupAsync(string @in, object userState)
      {
         if ((this.LookupOperationCompleted == null))
         {
            this.LookupOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLookupOperationCompleted);
         }
         this.InvokeAsync("Lookup", new object[] {
                    @in}, this.LookupOperationCompleted, userState);
      }

      private void OnLookupOperationCompleted(object arg)
      {
         if ((this.LookupCompleted != null))
         {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.LookupCompleted(this, new LookupCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
         }
      }

      /// <remarks/>
      [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://bpa.conseco.ws/SelectPerson/SelectPerson", RequestElementName = "SelectPerson", RequestNamespace = "http://bpa.conseco.ws/SelectPerson/", ResponseElementName = "SelectPersonResponse", ResponseNamespace = "http://bpa.conseco.ws/SelectPerson/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
      [return: System.Xml.Serialization.XmlElementAttribute("out", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public WorkitemResults CallSelectPerson([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] Selections @in)
      {
         object[] results = this.Invoke("CallSelectPerson", new object[] {
                    @in});
         return ((WorkitemResults)(results[0]));
      }

      /// <remarks/>
      public System.IAsyncResult BeginCallSelectPerson(Selections @in, System.AsyncCallback callback, object asyncState)
      {
         return this.BeginInvoke("CallSelectPerson", new object[] {
                    @in}, callback, asyncState);
      }

      /// <remarks/>
      public WorkitemResults EndCallSelectPerson(System.IAsyncResult asyncResult)
      {
         object[] results = this.EndInvoke(asyncResult);
         return ((WorkitemResults)(results[0]));
      }

      /// <remarks/>
      public void CallSelectPersonAsync(Selections @in)
      {
         this.CallSelectPersonAsync(@in, null);
      }

      /// <remarks/>
      public void CallSelectPersonAsync(Selections @in, object userState)
      {
         if ((this.CallSelectPersonOperationCompleted == null))
         {
            this.CallSelectPersonOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCallSelectPersonOperationCompleted);
         }
         this.InvokeAsync("CallSelectPerson", new object[] {
                    @in}, this.CallSelectPersonOperationCompleted, userState);
      }

      private void OnCallSelectPersonOperationCompleted(object arg)
      {
         if ((this.CallSelectPersonCompleted != null))
         {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.CallSelectPersonCompleted(this, new CallSelectPersonCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
         }
      }

      /// <remarks/>
      public new void CancelAsync(object userState)
      {
         base.CancelAsync(userState);
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://bpa.conseco.ws/SelectPerson/")]
   public partial class LookUpResults
   {

      private Person[] personArrayField;

      private int statusCodeField;

      private string statusDescField;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("PersonArray", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public Person[] PersonArray
      {
         get
         {
            return this.personArrayField;
         }
         set
         {
            this.personArrayField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public int StatusCode
      {
         get
         {
            return this.statusCodeField;
         }
         set
         {
            this.statusCodeField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string StatusDesc
      {
         get
         {
            return this.statusDescField;
         }
         set
         {
            this.statusDescField = value;
         }
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://bpa.conseco.ws/SelectPerson/")]
   public partial class Person
   {

      private string firstNameField;

      private string lastNameField;

      private System.DateTime dOBField;

      private string sexField;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string FirstName
      {
         get
         {
            return this.firstNameField;
         }
         set
         {
            this.firstNameField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string LastName
      {
         get
         {
            return this.lastNameField;
         }
         set
         {
            this.lastNameField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
      public System.DateTime DOB
      {
         get
         {
            return this.dOBField;
         }
         set
         {
            this.dOBField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Sex
      {
         get
         {
            return this.sexField;
         }
         set
         {
            this.sexField = value;
         }
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://bpa.conseco.ws/SelectPerson/")]
   public partial class FILENET
   {

      private string indexNameField;

      private string indexValueField;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string IndexName
      {
         get
         {
            return this.indexNameField;
         }
         set
         {
            this.indexNameField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string IndexValue
      {
         get
         {
            return this.indexValueField;
         }
         set
         {
            this.indexValueField = value;
         }
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://bpa.conseco.ws/SelectPerson/")]
   public partial class AWDLOB
   {

      private string nameField;

      private string valueField;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Name
      {
         get
         {
            return this.nameField;
         }
         set
         {
            this.nameField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://bpa.conseco.ws/SelectPerson/")]
   public partial class WorkItemRoute
   {

      private string businessAreaField;

      private string workTypeField;

      private string statusField;

      private string docClassField;

      private string docTypeField;

      private string lOBField;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string BusinessArea
      {
         get
         {
            return this.businessAreaField;
         }
         set
         {
            this.businessAreaField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string WorkType
      {
         get
         {
            return this.workTypeField;
         }
         set
         {
            this.workTypeField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string Status
      {
         get
         {
            return this.statusField;
         }
         set
         {
            this.statusField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string DocClass
      {
         get
         {
            return this.docClassField;
         }
         set
         {
            this.docClassField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string DocType
      {
         get
         {
            return this.docTypeField;
         }
         set
         {
            this.docTypeField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string LOB
      {
         get
         {
            return this.lOBField;
         }
         set
         {
            this.lOBField = value;
         }
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://bpa.conseco.ws/SelectPerson/")]
   public partial class WorkItem
   {

      private WorkItemRoute[] workItemRouteField;

      private AWDLOB[] aWDLOBField;

      private FILENET[] fileNetField;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("WorkItemRoute", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public WorkItemRoute[] WorkItemRoute
      {
         get
         {
            return this.workItemRouteField;
         }
         set
         {
            this.workItemRouteField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("AWDLOB", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public AWDLOB[] AWDLOB
      {
         get
         {
            return this.aWDLOBField;
         }
         set
         {
            this.aWDLOBField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("FileNet", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public FILENET[] FileNet
      {
         get
         {
            return this.fileNetField;
         }
         set
         {
            this.fileNetField = value;
         }
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://bpa.conseco.ws/SelectPerson/")]
   public partial class WorkitemResults
   {

      private WorkItem[] workItemField;

      private int statusCodeField;

      private string statusDescField;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("WorkItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public WorkItem[] WorkItem
      {
         get
         {
            return this.workItemField;
         }
         set
         {
            this.workItemField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public int StatusCode
      {
         get
         {
            return this.statusCodeField;
         }
         set
         {
            this.statusCodeField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string StatusDesc
      {
         get
         {
            return this.statusDescField;
         }
         set
         {
            this.statusDescField = value;
         }
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://bpa.conseco.ws/SelectPerson/")]
   public partial class Selections
   {

      private Person[] personArrayField;

      private string lTCExpenseField;

      private string policyNumberField;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("PersonArray", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public Person[] PersonArray
      {
         get
         {
            return this.personArrayField;
         }
         set
         {
            this.personArrayField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string LTCExpense
      {
         get
         {
            return this.lTCExpenseField;
         }
         set
         {
            this.lTCExpenseField = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public string PolicyNumber
      {
         get
         {
            return this.policyNumberField;
         }
         set
         {
            this.policyNumberField = value;
         }
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
   public delegate void LookupCompletedEventHandler(object sender, LookupCompletedEventArgs e);

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   public partial class LookupCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
   {

      private object[] results;

      internal LookupCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
         base(exception, cancelled, userState)
      {
         this.results = results;
      }

      /// <remarks/>
      public LookUpResults Result
      {
         get
         {
            this.RaiseExceptionIfNecessary();
            return ((LookUpResults)(this.results[0]));
         }
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
   public delegate void CallSelectPersonCompletedEventHandler(object sender, CallSelectPersonCompletedEventArgs e);

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   public partial class CallSelectPersonCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
   {

      private object[] results;

      internal CallSelectPersonCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
         base(exception, cancelled, userState)
      {
         this.results = results;
      }

      /// <remarks/>
      public WorkitemResults Result
      {
         get
         {
            this.RaiseExceptionIfNecessary();
            return ((WorkitemResults)(this.results[0]));
         }
      }
   }
}