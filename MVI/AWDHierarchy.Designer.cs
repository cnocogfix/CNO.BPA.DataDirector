﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 1591

namespace MVI {
    
    
    /// <summary>
    ///Represents a strongly typed in-memory cache of data.
    ///</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("AWDHierarchy")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class AWDHierarchy : global::System.Data.DataSet {
        
        private HierarchyDataTable tableHierarchy;
        
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public AWDHierarchy() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected AWDHierarchy(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["Hierarchy"] != null)) {
                    base.Tables.Add(new HierarchyDataTable(ds.Tables["Hierarchy"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public HierarchyDataTable Hierarchy {
            get {
                return this.tableHierarchy;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override global::System.Data.DataSet Clone() {
            AWDHierarchy cln = ((AWDHierarchy)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["Hierarchy"] != null)) {
                    base.Tables.Add(new HierarchyDataTable(ds.Tables["Hierarchy"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        internal void InitVars(bool initTable) {
            this.tableHierarchy = ((HierarchyDataTable)(base.Tables["Hierarchy"]));
            if ((initTable == true)) {
                if ((this.tableHierarchy != null)) {
                    this.tableHierarchy.InitVars();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitClass() {
            this.DataSetName = "AWDHierarchy";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/AWDHierarchy.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tableHierarchy = new HierarchyDataTable();
            base.Tables.Add(this.tableHierarchy);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private bool ShouldSerializeHierarchy() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            AWDHierarchy ds = new AWDHierarchy();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
        
        public delegate void HierarchyRowChangeEventHandler(object sender, HierarchyRowChangeEvent e);
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class HierarchyDataTable : global::System.Data.TypedTableBase<HierarchyRow> {
            
            private global::System.Data.DataColumn columnWORK_CATEGORY;
            
            private global::System.Data.DataColumn columnSTRUCTURE_SELECTION;
            
            private global::System.Data.DataColumn columnSITE_ID;
            
            private global::System.Data.DataColumn columnCASE_ID;
            
            private global::System.Data.DataColumn columnTRANSACTION_ID;
            
            private global::System.Data.DataColumn columnSOURCE_ID;
            
            private global::System.Data.DataColumn columnHIERARCHY_SEQ;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public HierarchyDataTable() {
                this.TableName = "Hierarchy";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal HierarchyDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected HierarchyDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn WORK_CATEGORYColumn {
                get {
                    return this.columnWORK_CATEGORY;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn STRUCTURE_SELECTIONColumn {
                get {
                    return this.columnSTRUCTURE_SELECTION;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn SITE_IDColumn {
                get {
                    return this.columnSITE_ID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn CASE_IDColumn {
                get {
                    return this.columnCASE_ID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn TRANSACTION_IDColumn {
                get {
                    return this.columnTRANSACTION_ID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn SOURCE_IDColumn {
                get {
                    return this.columnSOURCE_ID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataColumn HIERARCHY_SEQColumn {
                get {
                    return this.columnHIERARCHY_SEQ;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public HierarchyRow this[int index] {
                get {
                    return ((HierarchyRow)(this.Rows[index]));
                }
            }
            
            public event HierarchyRowChangeEventHandler HierarchyRowChanging;
            
            public event HierarchyRowChangeEventHandler HierarchyRowChanged;
            
            public event HierarchyRowChangeEventHandler HierarchyRowDeleting;
            
            public event HierarchyRowChangeEventHandler HierarchyRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void AddHierarchyRow(HierarchyRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public HierarchyRow AddHierarchyRow(string WORK_CATEGORY, string STRUCTURE_SELECTION, string SITE_ID, string CASE_ID, string TRANSACTION_ID, string SOURCE_ID, string HIERARCHY_SEQ) {
                HierarchyRow rowHierarchyRow = ((HierarchyRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        WORK_CATEGORY,
                        STRUCTURE_SELECTION,
                        SITE_ID,
                        CASE_ID,
                        TRANSACTION_ID,
                        SOURCE_ID,
                        HIERARCHY_SEQ};
                rowHierarchyRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowHierarchyRow);
                return rowHierarchyRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public HierarchyRow FindByHIERARCHY_SEQ(string HIERARCHY_SEQ) {
                return ((HierarchyRow)(this.Rows.Find(new object[] {
                            HIERARCHY_SEQ})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public override global::System.Data.DataTable Clone() {
                HierarchyDataTable cln = ((HierarchyDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Data.DataTable CreateInstance() {
                return new HierarchyDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal void InitVars() {
                this.columnWORK_CATEGORY = base.Columns["WORK_CATEGORY"];
                this.columnSTRUCTURE_SELECTION = base.Columns["STRUCTURE_SELECTION"];
                this.columnSITE_ID = base.Columns["SITE_ID"];
                this.columnCASE_ID = base.Columns["CASE_ID"];
                this.columnTRANSACTION_ID = base.Columns["TRANSACTION_ID"];
                this.columnSOURCE_ID = base.Columns["SOURCE_ID"];
                this.columnHIERARCHY_SEQ = base.Columns["HIERARCHY_SEQ"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private void InitClass() {
                this.columnWORK_CATEGORY = new global::System.Data.DataColumn("WORK_CATEGORY", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnWORK_CATEGORY);
                this.columnSTRUCTURE_SELECTION = new global::System.Data.DataColumn("STRUCTURE_SELECTION", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnSTRUCTURE_SELECTION);
                this.columnSITE_ID = new global::System.Data.DataColumn("SITE_ID", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnSITE_ID);
                this.columnCASE_ID = new global::System.Data.DataColumn("CASE_ID", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCASE_ID);
                this.columnTRANSACTION_ID = new global::System.Data.DataColumn("TRANSACTION_ID", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnTRANSACTION_ID);
                this.columnSOURCE_ID = new global::System.Data.DataColumn("SOURCE_ID", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnSOURCE_ID);
                this.columnHIERARCHY_SEQ = new global::System.Data.DataColumn("HIERARCHY_SEQ", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnHIERARCHY_SEQ);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("Constraint1", new global::System.Data.DataColumn[] {
                                this.columnHIERARCHY_SEQ}, true));
                this.columnHIERARCHY_SEQ.AllowDBNull = false;
                this.columnHIERARCHY_SEQ.Unique = true;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public HierarchyRow NewHierarchyRow() {
                return ((HierarchyRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new HierarchyRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override global::System.Type GetRowType() {
                return typeof(HierarchyRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.HierarchyRowChanged != null)) {
                    this.HierarchyRowChanged(this, new HierarchyRowChangeEvent(((HierarchyRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.HierarchyRowChanging != null)) {
                    this.HierarchyRowChanging(this, new HierarchyRowChangeEvent(((HierarchyRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.HierarchyRowDeleted != null)) {
                    this.HierarchyRowDeleted(this, new HierarchyRowChangeEvent(((HierarchyRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.HierarchyRowDeleting != null)) {
                    this.HierarchyRowDeleting(this, new HierarchyRowChangeEvent(((HierarchyRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void RemoveHierarchyRow(HierarchyRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                AWDHierarchy ds = new AWDHierarchy();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "HierarchyDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public partial class HierarchyRow : global::System.Data.DataRow {
            
            private HierarchyDataTable tableHierarchy;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal HierarchyRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tableHierarchy = ((HierarchyDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string WORK_CATEGORY {
                get {
                    try {
                        return ((string)(this[this.tableHierarchy.WORK_CATEGORYColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'WORK_CATEGORY\' in table \'Hierarchy\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHierarchy.WORK_CATEGORYColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string STRUCTURE_SELECTION {
                get {
                    try {
                        return ((string)(this[this.tableHierarchy.STRUCTURE_SELECTIONColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'STRUCTURE_SELECTION\' in table \'Hierarchy\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHierarchy.STRUCTURE_SELECTIONColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string SITE_ID {
                get {
                    try {
                        return ((string)(this[this.tableHierarchy.SITE_IDColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'SITE_ID\' in table \'Hierarchy\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHierarchy.SITE_IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string CASE_ID {
                get {
                    try {
                        return ((string)(this[this.tableHierarchy.CASE_IDColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'CASE_ID\' in table \'Hierarchy\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHierarchy.CASE_IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string TRANSACTION_ID {
                get {
                    try {
                        return ((string)(this[this.tableHierarchy.TRANSACTION_IDColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'TRANSACTION_ID\' in table \'Hierarchy\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHierarchy.TRANSACTION_IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string SOURCE_ID {
                get {
                    try {
                        return ((string)(this[this.tableHierarchy.SOURCE_IDColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'SOURCE_ID\' in table \'Hierarchy\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHierarchy.SOURCE_IDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public string HIERARCHY_SEQ {
                get {
                    return ((string)(this[this.tableHierarchy.HIERARCHY_SEQColumn]));
                }
                set {
                    this[this.tableHierarchy.HIERARCHY_SEQColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsWORK_CATEGORYNull() {
                return this.IsNull(this.tableHierarchy.WORK_CATEGORYColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetWORK_CATEGORYNull() {
                this[this.tableHierarchy.WORK_CATEGORYColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsSTRUCTURE_SELECTIONNull() {
                return this.IsNull(this.tableHierarchy.STRUCTURE_SELECTIONColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetSTRUCTURE_SELECTIONNull() {
                this[this.tableHierarchy.STRUCTURE_SELECTIONColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsSITE_IDNull() {
                return this.IsNull(this.tableHierarchy.SITE_IDColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetSITE_IDNull() {
                this[this.tableHierarchy.SITE_IDColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsCASE_IDNull() {
                return this.IsNull(this.tableHierarchy.CASE_IDColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetCASE_IDNull() {
                this[this.tableHierarchy.CASE_IDColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsTRANSACTION_IDNull() {
                return this.IsNull(this.tableHierarchy.TRANSACTION_IDColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetTRANSACTION_IDNull() {
                this[this.tableHierarchy.TRANSACTION_IDColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public bool IsSOURCE_IDNull() {
                return this.IsNull(this.tableHierarchy.SOURCE_IDColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public void SetSOURCE_IDNull() {
                this[this.tableHierarchy.SOURCE_IDColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
        public class HierarchyRowChangeEvent : global::System.EventArgs {
            
            private HierarchyRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public HierarchyRowChangeEvent(HierarchyRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public HierarchyRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}

#pragma warning restore 1591