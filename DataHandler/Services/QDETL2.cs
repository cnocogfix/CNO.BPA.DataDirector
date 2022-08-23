﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5472
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

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.1432.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="QDETL2Soap", Namespace="HTTP://SHADOW.CONSECO.COM/QSEARCH/QDETL2")]
public partial class QDETL2 : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback CallQDETL2OperationCompleted;
    
    /// <remarks/>
    public QDETL2(string URL) {
        //this.Url = "http://MFWEBT.CONSECO.COM:6111/QSEARCH/QDETL2.zws";
        this.Url = URL;
    }
    
    /// <remarks/>
    public event CallQDETL2CompletedEventHandler CallQDETL2Completed;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("HTTP://SHADOW.CONSECO.COM/QSEARCH/QDETL2/QDETL2", RequestElementName="QDETL2", RequestNamespace="HTTP://SHADOW.CONSECO.COM/QSEARCH/QDETL2", ResponseElementName="QDETL2Response", ResponseNamespace="HTTP://SHADOW.CONSECO.COM/QSEARCH/QDETL2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("QDETL2Result")]
    public Qdetl2_area CallQDETL2(Qdetl2_input QDETL2Input) {
        object[] results = this.Invoke("CallQDETL2", new object[] {
                    QDETL2Input});
        return ((Qdetl2_area)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginCallQDETL2(Qdetl2_input QDETL2Input, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("CallQDETL2", new object[] {
                    QDETL2Input}, callback, asyncState);
    }
    
    /// <remarks/>
    public Qdetl2_area EndCallQDETL2(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Qdetl2_area)(results[0]));
    }
    
    /// <remarks/>
    public void CallQDETL2Async(Qdetl2_input QDETL2Input) {
        this.CallQDETL2Async(QDETL2Input, null);
    }
    
    /// <remarks/>
    public void CallQDETL2Async(Qdetl2_input QDETL2Input, object userState) {
        if ((this.CallQDETL2OperationCompleted == null)) {
            this.CallQDETL2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnCallQDETL2OperationCompleted);
        }
        this.InvokeAsync("CallQDETL2", new object[] {
                    QDETL2Input}, this.CallQDETL2OperationCompleted, userState);
    }
    
    private void OnCallQDETL2OperationCompleted(object arg) {
        if ((this.CallQDETL2Completed != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.CallQDETL2Completed(this, new CallQDETL2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="HTTP://SHADOW.CONSECO.COM/QSEARCH/QDETL2")]
public partial class Qdetl2_input {
    
    private string qdetl2_source_sysField;
    
    private string qdetl2_typeField;
    
    private string qdetl2_systemField;
    
    private string qdetl2_companyField;
    
    private string qdetl2_idField;
    
    private string qdetl2_useridField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_source_sys {
        get {
            return this.qdetl2_source_sysField;
        }
        set {
            this.qdetl2_source_sysField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_type {
        get {
            return this.qdetl2_typeField;
        }
        set {
            this.qdetl2_typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_system {
        get {
            return this.qdetl2_systemField;
        }
        set {
            this.qdetl2_systemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_company {
        get {
            return this.qdetl2_companyField;
        }
        set {
            this.qdetl2_companyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_id {
        get {
            return this.qdetl2_idField;
        }
        set {
            this.qdetl2_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_userid {
        get {
            return this.qdetl2_useridField;
        }
        set {
            this.qdetl2_useridField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="HTTP://SHADOW.CONSECO.COM/QSEARCH/QDETL2")]
public partial class Qdetl2_areaQdetl2_outputQdetl2_respond_table {
    
    private string qdetl2_cmp_nameField;
    
    private string qdetl2_filenetField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_cmp_name {
        get {
            return this.qdetl2_cmp_nameField;
        }
        set {
            this.qdetl2_cmp_nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_filenet {
        get {
            return this.qdetl2_filenetField;
        }
        set {
            this.qdetl2_filenetField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="HTTP://SHADOW.CONSECO.COM/QSEARCH/QDETL2")]
public partial class Qdetl2_areaQdetl2_outputQdetl2_prop_arrayQdetl2_pa {
    
    private string qdetl2_prop_cdField;
    
    private string[] qdetl2_propsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_prop_cd {
        get {
            return this.qdetl2_prop_cdField;
        }
        set {
            this.qdetl2_prop_cdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Qdetl2_props", IsNullable=true)]
    public string[] Qdetl2_props {
        get {
            return this.qdetl2_propsField;
        }
        set {
            this.qdetl2_propsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="HTTP://SHADOW.CONSECO.COM/QSEARCH/QDETL2")]
public partial class Qdetl2_areaQdetl2_outputQdetl2_pop_arrayQdetl2_pop_lines {
    
    private string qdetl2_pop_cdField;
    
    private string qdetl2_pop_msgField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_pop_cd {
        get {
            return this.qdetl2_pop_cdField;
        }
        set {
            this.qdetl2_pop_cdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_pop_msg {
        get {
            return this.qdetl2_pop_msgField;
        }
        set {
            this.qdetl2_pop_msgField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="HTTP://SHADOW.CONSECO.COM/QSEARCH/QDETL2")]
public partial class Qdetl2_areaQdetl2_outputQdetl2_arrayQdetl2_qname {
    
    private string qdetl2_resultField;
    
    private string qdetl2_name_prefixField;
    
    private string qdetl2_name_firstField;
    
    private string qdetl2_name_middleField;
    
    private string qdetl2_name_lastField;
    
    private string qdetl2_name_suffixField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_result {
        get {
            return this.qdetl2_resultField;
        }
        set {
            this.qdetl2_resultField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_name_prefix {
        get {
            return this.qdetl2_name_prefixField;
        }
        set {
            this.qdetl2_name_prefixField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_name_first {
        get {
            return this.qdetl2_name_firstField;
        }
        set {
            this.qdetl2_name_firstField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_name_middle {
        get {
            return this.qdetl2_name_middleField;
        }
        set {
            this.qdetl2_name_middleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_name_last {
        get {
            return this.qdetl2_name_lastField;
        }
        set {
            this.qdetl2_name_lastField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_name_suffix {
        get {
            return this.qdetl2_name_suffixField;
        }
        set {
            this.qdetl2_name_suffixField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="HTTP://SHADOW.CONSECO.COM/QSEARCH/QDETL2")]
public partial class Qdetl2_areaQdetl2_outputQdetl2_array {
    
    private string qdetl2_seqField;
    
    private string qdetl2_cust_idField;
    
    private string qdetl2_ssnField;
    
    private string qdetl2_corp_tax_idField;
    
    private string qdetl2_medicare_idField;
    
    private string qdetl2_nameField;
    
    private string qdetl2_addr_1Field;
    
    private string qdetl2_addr_2Field;
    
    private string qdetl2_addr_3Field;
    
    private string qdetl2_addr_4Field;
    
    private string qdetl2_cityField;
    
    private string qdetl2_stField;
    
    private string qdetl2_zipField;
    
    private string qdetl2_zip4Field;
    
    private string qdetl2_countryField;
    
    private string qdetl2_area_cdField;
    
    private string qdetl2_phoneField;
    
    private string qdetl2_phonexField;
    
    private string qdetl2_birthField;
    
    private string qdetl2_sexField;
    
    private string[] qdetl2_relField;
    
    private string qdetl2_mbr_statusField;
    
    private string qdetl2_mbr_status_reasonField;
    
    private string qdetl2_last_activityField;
    
    private Qdetl2_areaQdetl2_outputQdetl2_arrayQdetl2_qname qdetl2_qnameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_seq {
        get {
            return this.qdetl2_seqField;
        }
        set {
            this.qdetl2_seqField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_cust_id {
        get {
            return this.qdetl2_cust_idField;
        }
        set {
            this.qdetl2_cust_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_ssn {
        get {
            return this.qdetl2_ssnField;
        }
        set {
            this.qdetl2_ssnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_corp_tax_id {
        get {
            return this.qdetl2_corp_tax_idField;
        }
        set {
            this.qdetl2_corp_tax_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_medicare_id {
        get {
            return this.qdetl2_medicare_idField;
        }
        set {
            this.qdetl2_medicare_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_name {
        get {
            return this.qdetl2_nameField;
        }
        set {
            this.qdetl2_nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_addr_1 {
        get {
            return this.qdetl2_addr_1Field;
        }
        set {
            this.qdetl2_addr_1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_addr_2 {
        get {
            return this.qdetl2_addr_2Field;
        }
        set {
            this.qdetl2_addr_2Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_addr_3 {
        get {
            return this.qdetl2_addr_3Field;
        }
        set {
            this.qdetl2_addr_3Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_addr_4 {
        get {
            return this.qdetl2_addr_4Field;
        }
        set {
            this.qdetl2_addr_4Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_city {
        get {
            return this.qdetl2_cityField;
        }
        set {
            this.qdetl2_cityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_st {
        get {
            return this.qdetl2_stField;
        }
        set {
            this.qdetl2_stField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_zip {
        get {
            return this.qdetl2_zipField;
        }
        set {
            this.qdetl2_zipField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_zip4 {
        get {
            return this.qdetl2_zip4Field;
        }
        set {
            this.qdetl2_zip4Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_country {
        get {
            return this.qdetl2_countryField;
        }
        set {
            this.qdetl2_countryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_area_cd {
        get {
            return this.qdetl2_area_cdField;
        }
        set {
            this.qdetl2_area_cdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_phone {
        get {
            return this.qdetl2_phoneField;
        }
        set {
            this.qdetl2_phoneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_phonex {
        get {
            return this.qdetl2_phonexField;
        }
        set {
            this.qdetl2_phonexField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_birth {
        get {
            return this.qdetl2_birthField;
        }
        set {
            this.qdetl2_birthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_sex {
        get {
            return this.qdetl2_sexField;
        }
        set {
            this.qdetl2_sexField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Qdetl2_rel", IsNullable=true)]
    public string[] Qdetl2_rel {
        get {
            return this.qdetl2_relField;
        }
        set {
            this.qdetl2_relField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_mbr_status {
        get {
            return this.qdetl2_mbr_statusField;
        }
        set {
            this.qdetl2_mbr_statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_mbr_status_reason {
        get {
            return this.qdetl2_mbr_status_reasonField;
        }
        set {
            this.qdetl2_mbr_status_reasonField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_last_activity {
        get {
            return this.qdetl2_last_activityField;
        }
        set {
            this.qdetl2_last_activityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public Qdetl2_areaQdetl2_outputQdetl2_arrayQdetl2_qname Qdetl2_qname {
        get {
            return this.qdetl2_qnameField;
        }
        set {
            this.qdetl2_qnameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="HTTP://SHADOW.CONSECO.COM/QSEARCH/QDETL2")]
public partial class Qdetl2_areaQdetl2_output {
    
    private string qdetl2_sys_descField;
    
    private string qdetl2_cmp_descField;
    
    private string qdetl2_locationField;
    
    private string qdetl2_divisionField;
    
    private string qdetl2_agt_sysField;
    
    private string qdetl2_agt_cmpField;
    
    private string qdetl2_statusField;
    
    private string qdetl2_status_reasonField;
    
    private string qdetl2_lobField;
    
    private string qdetl2_productField;
    
    private string qdetl2_issue_countryField;
    
    private string qdetl2_issue_stateField;
    
    private string qdetl2_issue_dateField;
    
    private string qdetl2_termination_dateField;
    
    private string qdetl2_base_plan_codeField;
    
    private string qdetl2_group_numberField;
    
    private System.Nullable<short> qdetl2_mbr_cntField;
    
    private bool qdetl2_mbr_cntFieldSpecified;
    
    private Qdetl2_areaQdetl2_outputQdetl2_array[] qdetl2_arrayField;
    
    private System.Nullable<short> qdetl2_pop_approved_cntField;
    
    private bool qdetl2_pop_approved_cntFieldSpecified;
    
    private System.Nullable<short> qdetl2_pop_severe_cntField;
    
    private bool qdetl2_pop_severe_cntFieldSpecified;
    
    private System.Nullable<short> qdetl2_pop_cntField;
    
    private bool qdetl2_pop_cntFieldSpecified;
    
    private Qdetl2_areaQdetl2_outputQdetl2_pop_arrayQdetl2_pop_lines[] qdetl2_pop_arrayField;
    
    private Qdetl2_areaQdetl2_outputQdetl2_prop_arrayQdetl2_pa[] qdetl2_prop_arrayField;
    
    private Qdetl2_areaQdetl2_outputQdetl2_respond_table qdetl2_respond_tableField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_sys_desc {
        get {
            return this.qdetl2_sys_descField;
        }
        set {
            this.qdetl2_sys_descField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_cmp_desc {
        get {
            return this.qdetl2_cmp_descField;
        }
        set {
            this.qdetl2_cmp_descField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_location {
        get {
            return this.qdetl2_locationField;
        }
        set {
            this.qdetl2_locationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_division {
        get {
            return this.qdetl2_divisionField;
        }
        set {
            this.qdetl2_divisionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_agt_sys {
        get {
            return this.qdetl2_agt_sysField;
        }
        set {
            this.qdetl2_agt_sysField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_agt_cmp {
        get {
            return this.qdetl2_agt_cmpField;
        }
        set {
            this.qdetl2_agt_cmpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_status {
        get {
            return this.qdetl2_statusField;
        }
        set {
            this.qdetl2_statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_status_reason {
        get {
            return this.qdetl2_status_reasonField;
        }
        set {
            this.qdetl2_status_reasonField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_lob {
        get {
            return this.qdetl2_lobField;
        }
        set {
            this.qdetl2_lobField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_product {
        get {
            return this.qdetl2_productField;
        }
        set {
            this.qdetl2_productField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_issue_country {
        get {
            return this.qdetl2_issue_countryField;
        }
        set {
            this.qdetl2_issue_countryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_issue_state {
        get {
            return this.qdetl2_issue_stateField;
        }
        set {
            this.qdetl2_issue_stateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_issue_date {
        get {
            return this.qdetl2_issue_dateField;
        }
        set {
            this.qdetl2_issue_dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_termination_date {
        get {
            return this.qdetl2_termination_dateField;
        }
        set {
            this.qdetl2_termination_dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_base_plan_code {
        get {
            return this.qdetl2_base_plan_codeField;
        }
        set {
            this.qdetl2_base_plan_codeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_group_number {
        get {
            return this.qdetl2_group_numberField;
        }
        set {
            this.qdetl2_group_numberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public System.Nullable<short> Qdetl2_mbr_cnt {
        get {
            return this.qdetl2_mbr_cntField;
        }
        set {
            this.qdetl2_mbr_cntField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool Qdetl2_mbr_cntSpecified {
        get {
            return this.qdetl2_mbr_cntFieldSpecified;
        }
        set {
            this.qdetl2_mbr_cntFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Qdetl2_array", IsNullable=true)]
    public Qdetl2_areaQdetl2_outputQdetl2_array[] Qdetl2_array {
        get {
            return this.qdetl2_arrayField;
        }
        set {
            this.qdetl2_arrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public System.Nullable<short> Qdetl2_pop_approved_cnt {
        get {
            return this.qdetl2_pop_approved_cntField;
        }
        set {
            this.qdetl2_pop_approved_cntField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool Qdetl2_pop_approved_cntSpecified {
        get {
            return this.qdetl2_pop_approved_cntFieldSpecified;
        }
        set {
            this.qdetl2_pop_approved_cntFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public System.Nullable<short> Qdetl2_pop_severe_cnt {
        get {
            return this.qdetl2_pop_severe_cntField;
        }
        set {
            this.qdetl2_pop_severe_cntField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool Qdetl2_pop_severe_cntSpecified {
        get {
            return this.qdetl2_pop_severe_cntFieldSpecified;
        }
        set {
            this.qdetl2_pop_severe_cntFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public System.Nullable<short> Qdetl2_pop_cnt {
        get {
            return this.qdetl2_pop_cntField;
        }
        set {
            this.qdetl2_pop_cntField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool Qdetl2_pop_cntSpecified {
        get {
            return this.qdetl2_pop_cntFieldSpecified;
        }
        set {
            this.qdetl2_pop_cntFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Qdetl2_pop_lines")]
    public Qdetl2_areaQdetl2_outputQdetl2_pop_arrayQdetl2_pop_lines[] Qdetl2_pop_array {
        get {
            return this.qdetl2_pop_arrayField;
        }
        set {
            this.qdetl2_pop_arrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Qdetl2_pa")]
    public Qdetl2_areaQdetl2_outputQdetl2_prop_arrayQdetl2_pa[] Qdetl2_prop_array {
        get {
            return this.qdetl2_prop_arrayField;
        }
        set {
            this.qdetl2_prop_arrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public Qdetl2_areaQdetl2_outputQdetl2_respond_table Qdetl2_respond_table {
        get {
            return this.qdetl2_respond_tableField;
        }
        set {
            this.qdetl2_respond_tableField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="HTTP://SHADOW.CONSECO.COM/QSEARCH/QDETL2")]
public partial class Qdetl2_areaQdetl2_msgs {
    
    private string qdetl2_msg_lvlField;
    
    private string qdetl2_msg_textField;
    
    private string qdetl2_sys_textField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_msg_lvl {
        get {
            return this.qdetl2_msg_lvlField;
        }
        set {
            this.qdetl2_msg_lvlField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_msg_text {
        get {
            return this.qdetl2_msg_textField;
        }
        set {
            this.qdetl2_msg_textField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_sys_text {
        get {
            return this.qdetl2_sys_textField;
        }
        set {
            this.qdetl2_sys_textField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="HTTP://SHADOW.CONSECO.COM/QSEARCH/QDETL2")]
public partial class Qdetl2_areaQdetl2_input {
    
    private string qdetl2_source_sysField;
    
    private string qdetl2_typeField;
    
    private string qdetl2_systemField;
    
    private string qdetl2_companyField;
    
    private string qdetl2_idField;
    
    private string qdetl2_useridField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_source_sys {
        get {
            return this.qdetl2_source_sysField;
        }
        set {
            this.qdetl2_source_sysField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_type {
        get {
            return this.qdetl2_typeField;
        }
        set {
            this.qdetl2_typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_system {
        get {
            return this.qdetl2_systemField;
        }
        set {
            this.qdetl2_systemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_company {
        get {
            return this.qdetl2_companyField;
        }
        set {
            this.qdetl2_companyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_id {
        get {
            return this.qdetl2_idField;
        }
        set {
            this.qdetl2_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string Qdetl2_userid {
        get {
            return this.qdetl2_useridField;
        }
        set {
            this.qdetl2_useridField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="HTTP://SHADOW.CONSECO.COM/QSEARCH/QDETL2")]
public partial class Qdetl2_area {
    
    private Qdetl2_areaQdetl2_input qdetl2_inputField;
    
    private Qdetl2_areaQdetl2_msgs qdetl2_msgsField;
    
    private Qdetl2_areaQdetl2_output qdetl2_outputField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public Qdetl2_areaQdetl2_input Qdetl2_input {
        get {
            return this.qdetl2_inputField;
        }
        set {
            this.qdetl2_inputField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public Qdetl2_areaQdetl2_msgs Qdetl2_msgs {
        get {
            return this.qdetl2_msgsField;
        }
        set {
            this.qdetl2_msgsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public Qdetl2_areaQdetl2_output Qdetl2_output {
        get {
            return this.qdetl2_outputField;
        }
        set {
            this.qdetl2_outputField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
public delegate void CallQDETL2CompletedEventHandler(object sender, CallQDETL2CompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class CallQDETL2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal CallQDETL2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public Qdetl2_area Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((Qdetl2_area)(this.results[0]));
        }
    }
}