using System;
using System.Globalization;
using System.Text;
using System.Data;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Xml;
using System.Runtime.InteropServices;
using CNO.BPA.Framework;
using System.Drawing;

namespace CNO.BPA.DataHandler
{
    [ComVisible(false)]
    public class DataAccess : IDisposable
    {

        #region Procedure Names
        private string CLAIMS_ROUTING = "BPA_APPS.PKG_STNDCLAIM.CLAIMS_ROUTING";
        private string CREATE_BATCH_ITEM = "BPA_APPS.PKG_BATCH.CREATE_BATCH_ITEM";
        private string CREATE_BATCH_ITEM_REJECT = "BPA_APPS.PKG_BATCH.CREATE_BATCH_ITEM_REJECTS";
        private string CREATE_DD_ITEM = "BPA_APPS.PKG_DATADIRECTOR.CREATE_DD_ITEM";
        private string CREATE_DD_ITEM_INDEXES = "BPA_APPS.PKG_DATADIRECTOR.CREATE_DD_ITEM_INDEXES";
        private string CREATE_DD_USER_FORMSETTINGS = "BPA_APPS.PKG_DATADIRECTOR.CREATE_DD_USER_FORMSETTINGS";
        private string CREATE_DD_USER_TRACKING = "BPA_APPS.PKG_DATADIRECTOR.CREATE_DD_USER_TRACKING";
        private string CREATE_DOCUSTREAM_REQUEST = "BPA_APPS.CREATE_DOCUSTREAM_REQUEST";
        private string CREATE_FRONT_OFFICE_REQUEST = "BPA_APPS.CREATE_FRONT_OFFICE_REQUEST";
        private string CREATE_INVOICE_REQUEST = "BPA_APPS.CREATE_INVOICE_REQUEST";
        private string CREATE_INVOICE_DETAIL = "BPA_APPS.CREATE_INVOICE_DETAIL";
        private string CREATE_THIRD_PARTY_REQUEST = "BPA_APPS.CREATE_THIRD_PARTY_REQUEST";
        private string CREATE_AWD_REQUEST = "BPA_APPS.PKG_AWD_REQUEST.CREATE_REQUEST";
        private string CREATE_AWD_LOB = "BPA_APPS.PKG_AWD_REQUEST.CREATE_LOB";
        private string SELECT_BA_LIST = "BPA_APPS.PKG_DATADIRECTOR.SEL_BUSINESS_AREA_LIST";
        private string SELECT_WT_LIST = "BPA_APPS.PKG_DATADIRECTOR.SEL_WORK_TYPE_LIST";
        private string SELECT_SYSTEM_LIST = "BPA_APPS.PKG_DATADIRECTOR.SEL_SYSTEM_ID_LIST";
        private string SELECT_COMPANY_LIST = "BPA_APPS.PKG_DATADIRECTOR.SEL_COMPANY_CODE_LIST";
        private string SELECT_HIERARCHY_LIST = "BPA_APPS.PKG_DATADIRECTOR.SEL_AWD_HIERARCHY_LIST";
        private string SELECT_JOB_NAMES = "BPA_APPS.PKG_IA.SELECT_JOB_NAMES";
        private string SELECT_DD_MVI_FIELD_DEFINITION = "BPA_APPS.PKG_DATADIRECTOR.SEL_DD_MVI_FIELD_DEFINITION";
        private string SELECT_DD_MVI_AWD_LOB_DEFINITION = "BPA_APPS.PKG_DATADIRECTOR.SEL_DD_MVI_AWD_LOB_DEFINITION";
        private string SELECT_DD_MVI_FIELD_CHOICES = "BPA_APPS.PKG_DATADIRECTOR.SEL_DD_MVI_FIELD_CHOICES";
        private string SELECT_DD_MVI_FIELD_CONDITIONS = "BPA_APPS.PKG_DATADIRECTOR.SEL_DD_MVI_FIELD_CONDITIONS";
        private string SELECT_DD_USER_FORMSETTINGS = "BPA_APPS.PKG_DATADIRECTOR.SEL_DD_USER_FORMSETTINGS";
        private string SELECT_CASE_WT_LIST = "BPA_APPS.PKG_DATADIRECTOR.SEL_CASE_WORK_TYPE_LIST";
        private string SELECT_BA_WT_VALUES = "BPA_APPS.PKG_DATADIRECTOR.SEL_BA_WT_XREF_VALUES";
        private string SELECT_BA_CASEWT_VALUES = "BPA_APPS.PKG_DATADIRECTOR.SEL_CASE_BA_WT_XREF_VALUES";
        private string DELETE_DD_ITEM = "BPA_APPS.PKG_DATADIRECTOR.DEL_DD_ITEM";
        private string SELECT_AWD_LINK_DATA = "BPA_APPS.PKG_DATADIRECTOR.SEL_AWD_LINK_DATA";
        private string SELECT_BUNDLE_NO = "BPA_APPS.PKG_DATADIRECTOR.SEL_SORTCODE_BUNDLE";
        private string SELECT_ADMIN_SYSTEM_XREF = "BPA_APPS.PKG_DATADIRECTOR.SEL_ADMIN_SYSTEM_XREF";
        private string SELECT_SORTCODE_LOB = "BPA_APPS.PKG_DATADIRECTOR.SEL_SORTCODE_LOB";
        private string SELECT_SORTCODE_VALUES = "BPA_APPS.PKG_DATADIRECTOR.SEL_SORTCODE_XREF";
        private string SELECT_SORTCODE_WORKTYPE = "BPA_APPS.PKG_DATADIRECTOR.SEL_SORTCODE_WORKTYPE";
        private string SELECT_SORTCODE = "BPA_APPS.PKG_DATADIRECTOR.SEL_SORTCODE";
        private string SELECT_VATIN = "BPA_APPS.PKG_STNDCLAIM.SEL_VATIN";
        private string SELECT_SITE_ID = "BPA_APPS.PKG_DATADIRECTOR.SEL_SITE_FROM_ADMIN_XREF";
        private string CHECK_BUNDLING_WORKTYPE = "BPA_APPS.PKG_DATADIRECTOR.CHECK_BUNDLING_WORKTYPE";
        private string CHECK_TYPE_OF_BILL = "BPA_APPS.PKG_DATADIRECTOR.CHECK_TYPE_OF_BILL";
        private string SELECT_ROUTING = "BPA_APPS.PKG_DATADIRECTOR.SEL_ROUTING";
        private string SELECT_DD_ITEM = "BPA_APPS.PKG_DATADIRECTOR.SEL_DD_ITEM";
        private string SELECT_DD_ITEM_INDEXES = "BPA_APPS.PKG_DATADIRECTOR.SEL_DD_ITEM_INDEXES";
        private string SELECT_DD_MAIN_DEFINITION_VALUE = "BPA_APPS.PKG_DATADIRECTOR.SEL_DD_MAIN_DEFINITION_VALUE";
        private string SELECT_DD_MAIN_DEFINITION_VALUES = "BPA_APPS.PKG_DATADIRECTOR.SEL_DD_MAIN_DEFINITION_VALUES";
        private string SELECT_PRIVATE_PLACEMENT = "BPA_APPS.PKG_4086.SELECT_PRIVATE_PLACEMENT";
        private string SELECT_MORTGAGE = "BPA_APPS.PKG_4086.SELECT_MORTGAGE";
        private string SELECT_ROUTING_CHOICES = "BPA_APPS.PKG_DATADIRECTOR.SEL_ROUTING_CHOICES";

        //START: AR 145620
        private string SELECT_CONTESTABLE = "BPA_APPS.PKG_DATADIRECTOR.SEL_CONTESTABLE";
        private string SELECT_POP_CODE_LOOKUP_LIST = "BPA_APPS.PKG_DATADIRECTOR.SEL_POP_CODE_LOOKUP_LIST";
        private string GET_SEARCH_TYPE = "BPA_APPS.PKG_DATADIRECTOR.GET_SEARCH_TYPE";
        private string GET_REJECT_OPTIONS = "BPA_APPS.PKG_BATCH.GET_REJECT_OPTIONS";
        private string SELECT_GROUP_DETAILS = "BPA_APPS.PKG_CRS.SELECT_GROUP_DETAILS";
        private string UPDATE_REASON_CODE = "BPA_APPS.PKG_BATCH.UPDATE_REASON_CODE";
        //END: AR 145620

        //AR143750 - START
        private string GET_BA_FROM_HN = "BPA_APPS.PKG_DATADIRECTOR.GET_BA_FROM_HN";
        //AR143750 - END

        private string GET_FIS_ID = "BPA_APPS.PKG_DATADIRECTOR.GET_FIS_ID";
        private string SELECT_FRONT_OFFICE_BARCODE = "BPA_APPS.PKG_FRONT_OFFICE.SEL_FRONT_OFFICE_BARCODE";
        private string SELECT_FRONT_OFFICE_PROD_CAT_XREF = "BPA_APPS.PKG_FRONT_OFFICE.SEL_FO_PROD_CAT_XREF";
        private string SELECT_PRIVACY_MAILING = "BPA_APPS.PKG_DATADIRECTOR.SEL_DD_PRIVACY_MAILING";

        #endregion

        #region Variables
        private Cryptography crypto = new
           Cryptography();
        private OracleConnection _connection = null;
        private string _connectionString = null;
        private OracleTransaction _transaction = null;
        private string _applicationData = null;
        private CNO.BPA.Framework.XML.Parser _xmlParser = null;
        private string _activeRegion = String.Empty;
        private string _DSN = String.Empty;
        private string _DBUser = String.Empty;
        private string _DBPass = String.Empty;
        private CNO.BPA.Framework.LogLibrary.DBLogger _dbLogger;

        #endregion

        #region Constructors
        public DataAccess()
        {
            //locate the app data folder
            _applicationData = Environment.GetFolderPath
               (Environment.SpecialFolder.ApplicationData);
            //create a new instance of the parser class
            _xmlParser = new CNO.BPA.Framework.XML.Parser(_applicationData
               + @"\CNO\bpa\datadirector.xml");
            //now we need to pull the active region
            _activeRegion = _xmlParser.GetCustomAttribute(
               "Configuration/Database/Connections", "active");
            //next grab a copy of each of the db values
            _DSN = _xmlParser.GetCustomAttribute(
               "Configuration/Database/Connections/" + _activeRegion, "dsn");
            _DBUser = crypto.Decrypt(_xmlParser.GetCustomAttribute(
               "Configuration/Database/Connections/" + _activeRegion, "usr"));
            _DBPass = crypto.Decrypt(_xmlParser.GetCustomAttribute(
               "Configuration/Database/Connections/" + _activeRegion, "pwd"));

            //check to see that we have values for the db info
            if (_DSN.Length != 0 & _DBUser.Length != 0 &
                _DBPass.Length != 0)
            {
                //build the connection string
                _connectionString = "Data Source=" + _DSN + ";Persist Security Info=True;User ID="
                   + _DBUser + ";Password=" + _DBPass + ";Pooling=False;";
            }
            else
            {
                throw new ArgumentNullException("-266007825; Database information was "
                   + "not found in the configuration file.");
            }
            //we need to pull in the list of fully qualified procedures
            populateProcedureVariables();
            //instantiate the framework dblogger
            _dbLogger = new CNO.BPA.Framework.LogLibrary.DBLogger(_connectionString);

        }
        #endregion

        #region Private Methods
        internal void populateProcedureVariables()
        {
            //we need to pull in the list of fully qualified procedures
            XmlNodeList procList = _xmlParser.GetNodeList("Configuration/Database/Procedures");
            foreach (XmlNode nodeProcedure in procList)
            {
                switch (nodeProcedure.Name)
                {
                    case "CLAIMS_ROUTING":
                        CLAIMS_ROUTING = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "CHECK_BUNDLING_WORKTYPE":
                        CHECK_BUNDLING_WORKTYPE = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "CHECK_TYPE_OF_BILL":
                        CHECK_TYPE_OF_BILL = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "CREATE_AWD_LOB":
                        CREATE_AWD_LOB = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "CREATE_AWD_REQUEST":
                        CREATE_AWD_REQUEST = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "CREATE_BATCH_ITEM":
                        CREATE_BATCH_ITEM = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "CREATE_BATCH_ITEM_REJECT":
                        CREATE_BATCH_ITEM_REJECT = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "CREATE_DOCUSTREAM_REQUEST":
                        CREATE_DOCUSTREAM_REQUEST = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "CREATE_FRONT_OFFICE_REQUEST":
                        CREATE_FRONT_OFFICE_REQUEST = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "CREATE_INVOICE_REQUEST":
                        CREATE_INVOICE_REQUEST = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "CREATE_INVOICE_DETAIL":
                        CREATE_INVOICE_DETAIL = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "CREATE_THIRD_PARTY_REQUEST":
                        CREATE_THIRD_PARTY_REQUEST = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_BA_LIST":
                        SELECT_BA_LIST = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_COMPANY_LIST":
                        SELECT_COMPANY_LIST = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_HIERARCHY_LIST":
                        SELECT_HIERARCHY_LIST = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_JOB_NAMES":
                        SELECT_JOB_NAMES = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_DD_MVI_AWD_LOB_DEFINITION":
                        SELECT_DD_MVI_AWD_LOB_DEFINITION = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_DD_MVI_FIELD_DEFINITION":
                        SELECT_DD_MVI_FIELD_DEFINITION = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_DD_MVI_FIELD_CHOICES":
                        SELECT_DD_MVI_FIELD_CHOICES = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_DD_MVI_FIELD_CONDITIONS":
                        SELECT_DD_MVI_FIELD_CONDITIONS = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_SYSTEM_LIST":
                        SELECT_SYSTEM_LIST = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_WT_LIST":
                        SELECT_WT_LIST = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_CASE_WT_LIST":
                        SELECT_CASE_WT_LIST = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_BA_WT_VALUES":
                        SELECT_BA_WT_VALUES = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_BA_CASEWT_VALUES":
                        SELECT_BA_CASEWT_VALUES = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "CREATE_DD_ITEM":
                        CREATE_DD_ITEM = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "CREATE_DD_ITEM_INDEXES":
                        CREATE_DD_ITEM_INDEXES = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "CREATE_DD_USER_TRACKING":
                        CREATE_DD_USER_TRACKING = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "DELETE_DD_ITEM":
                        DELETE_DD_ITEM = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_AWD_LINK_DATA":
                        SELECT_AWD_LINK_DATA = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_BUNDLE_NO":
                        SELECT_BUNDLE_NO = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_ADMIN_SYSTEM_XREF":
                        SELECT_ADMIN_SYSTEM_XREF = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_CONTESTABLE":
                        SELECT_CONTESTABLE = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_SORTCODE_LOB":
                        SELECT_SORTCODE_LOB = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_SORTCODE_WORKTYPE":
                        SELECT_SORTCODE_WORKTYPE = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_SORTCODE":
                        SELECT_SORTCODE = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_VATIN":
                        SELECT_VATIN = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_SITE_ID":
                        SELECT_SITE_ID = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_ROUTING":
                        SELECT_ROUTING = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_DD_ITEM":
                        SELECT_DD_ITEM = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_DD_ITEM_INDEXES":
                        SELECT_DD_ITEM_INDEXES = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_SORTCODE_VALUES":
                        SELECT_SORTCODE_VALUES = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_DD_MAIN_DEFINITION_VALUE":
                        SELECT_DD_MAIN_DEFINITION_VALUE = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_DD_MAIN_DEFINITION_VALUES":
                        SELECT_DD_MAIN_DEFINITION_VALUES = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_GROUP_DETAILS":
                        SELECT_GROUP_DETAILS = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "GET_BA_FROM_HN":
                        GET_BA_FROM_HN = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_PRIVATE_PLACEMENT":
                        SELECT_PRIVATE_PLACEMENT = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_MORTGAGE":
                        SELECT_MORTGAGE = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_ROUTING_CHOICES":
                        SELECT_ROUTING_CHOICES = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "GET_FIS_ID":
                        GET_FIS_ID = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_FRONT_OFFICE_BARCODE":
                        SELECT_FRONT_OFFICE_BARCODE = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_FRONT_OFFICE_PROD_CAT_XREF":
                        SELECT_FRONT_OFFICE_PROD_CAT_XREF = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    case "SELECT_PRIVACY_MAILING":
                        SELECT_PRIVACY_MAILING = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;

                    //START: AR 145620
                    case "SELECT_POP_CODE_LOOKUP_LIST":
                        SELECT_POP_CODE_LOOKUP_LIST = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;

                    case "GET_SEARCH_TYPE":
                        GET_SEARCH_TYPE = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;

                    case "GET_REJECT_OPTIONS":
                        GET_REJECT_OPTIONS = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;

                    case "UPDATE_REASON_CODE":
                        UPDATE_REASON_CODE = _xmlParser.GetCustomAttribute(nodeProcedure, "value");
                        break;
                    //END: AR 145620

                }
            }
        }
        /// <summary>
        /// Connects and logs in to the database, and begins a transaction.
        /// </summary>
        public void Connect()
        {
            _connection = new OracleConnection();
            _connection.ConnectionString = _connectionString;
            try
            {
                _connection.Open();
                _transaction = _connection.BeginTransaction();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while connecting to the database.", ex);
            }
        }
        /// <summary>
        /// Commits the current transaction and disconnects from the database.
        /// </summary>
        public void Disconnect()
        {
            try
            {
                if (null != _connection)
                {
                    _transaction.Commit();
                    _connection.Close();
                    _connection = null;
                    _transaction = null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.Disconnect: " + ex.Message);
            }
        }
        /// <summary>
        /// Commits all of the data changes to the database.
        /// </summary>
        internal void Commit()
        {
            _transaction.Commit();
        }
        /// <summary>
        /// Cancels the transaction and voids any changes to the database.
        /// </summary>
        public void Cancel()
        {
            _transaction.Rollback();
            _connection.Close();
            _connection = null;
            _transaction = null;
        }
        /// <summary>
        /// Generates the command object and associates it with the current transaction object
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        internal OracleCommand GenerateCommand(string commandText, System.Data.CommandType commandType)
        {
            OracleCommand cmd = new OracleCommand(commandText, _connection);
            cmd.Transaction = _transaction;
            cmd.CommandType = commandType;
            return cmd;
        }
        #endregion

        #region Public Methods
        public Dictionary<string, int> getBatchIssueTypes()
        {
            try
            {
                Dictionary<string, int> BatchIssues = new Dictionary<string, int>();
                Connect();
                OracleCommand cmd = GenerateCommand("bpa_apps.pkg_ia.select_issue_types", CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);
                using (OracleDataReader dataReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        // Always call Read before accessing data.
                        while (dataReader.Read())
                        {
                            BatchIssues.Add(dataReader.GetString(0), 0);
                        }
                    }
                }
                Disconnect();
                return BatchIssues;
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.getBatchIssueTypes: " + ex.Message);
            }

        }
        public void insertBatchIssue(string batchNo, string item, int frequency)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand("bpa_apps.pkg_batch.CREATE_BATCH_ISSUES", CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_app_name",
                   "DD", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_machine_name",
                  System.Environment.MachineName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_user_id",
                  System.Environment.UserName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);

                DBUtilities.CreateAndAddParameter("p_in_batch_no",
                   batchNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_issue_type",
                   item, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_frequency",
                   frequency, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "SUCCESSFUL")
                {

                }
                else
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                       cmd.Parameters["p_out_error_message"].Value.ToString());
                }
                Disconnect();

            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.insertBatchIssue: " + ex.Message);
            }
        }
        public void createPerfLogEntry(ref CommonParameters CP, string callStart, string callEnd, string action,
                                     string actionResult)
        {
            if (CP.TrackPerformance)
            {

                try
                {
                    _dbLogger.createPerfLogEntry("DD", "NA", "NA",
                                             callStart, callEnd, action,
                                            actionResult);
                }
                catch
                {
                    //don't throw any errors for problems with perfomance log

                }
            }

        }
        public void createBatchItem(ref CommonParameters CP)
        {

            try
            {
                OracleCommand cmd = GenerateCommand(CREATE_BATCH_ITEM, CommandType.StoredProcedure);
                if (CP.BatchItemID == 0)
                {
                    DBUtilities.CreateAndAddParameter("p_in_action_indicator",
                      "I", OracleType.VarChar, ParameterDirection.Input, cmd);
                }
                else
                {
                    DBUtilities.CreateAndAddParameter("p_in_action_indicator",
                      "U", OracleType.VarChar, ParameterDirection.Input, cmd);
                    DBUtilities.CreateAndAddParameter("p_in_item_id",
                      CP.BatchItemID, OracleType.VarChar, ParameterDirection.Input, cmd);
                }
                DBUtilities.CreateAndAddParameter("p_in_app_name",
                  "DD", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_machine_name",
                  System.Environment.MachineName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_user_id",
                  System.Environment.UserName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_batch_no",
                  CP.BatchNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_f_doc_xref",
                  CP.CurrentNodeID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_dd_item_seq",
                  CP.DDItemSeq, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_template_name",
                 CP.TemplateName, OracleType.VarChar, ParameterDirection.Input, cmd);

                //AR 145620 - Commented below line of code as it is no more 
                //-needed as IA is upgraded to 7.1
                //DBUtilities.CreateAndAddParameter("p_in_f_docclassname",
                //  CP.FDocClassName, OracleType.VarChar, ParameterDirection.Input, cmd);

                DBUtilities.CreateAndAddParameter("p_in_document_type",
                  CP.DocType, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_lob",
                  CP.LineOfBusiness, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_img_count",
                  CP.ImgCount, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_certified_no",
                  CP.CertifiedNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_business_area",
                  CP.BusinessArea, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_work_type",
                  CP.WorkType, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_system_id",
                  CP.SystemID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_company_code",
                  CP.CompanyCode, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_fax_id",
                  CP.FaxID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_fax_sender",
                  CP.FaxFrom, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_fax_recipient",
                  CP.FaxTo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_fax_server",
                  CP.FaxServer, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_fax_account",
                  CP.FaxAccount, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_fisdocid",
                  CP.FisDocID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_work_category",
                  CP.WorkCategory, OracleType.VarChar, ParameterDirection.Input, cmd);
                //we need to send in counts for standard claims... values default to 0
                DBUtilities.CreateAndAddParameter("p_in_hcfa_count",
                  CP.CountHCFA, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_ub_count",
                  CP.CountUB92, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_pheomb_count",
                  CP.CountPHEOMB, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_eomb_count",
                  CP.CountEOMB, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_attachment_count",
                  CP.CountAttachment, OracleType.VarChar, ParameterDirection.Input, cmd);
                //we also need to send in the route code and type of bill for claims
                DBUtilities.CreateAndAddParameter("p_in_route_code",
                  CP.RouteCode, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_type_of_bill",
                  CP.TypeOfBill, OracleType.VarChar, ParameterDirection.Input, cmd);
                //setup the index operator info for tracking
                DBUtilities.CreateAndAddParameter("p_in_validation_machine",
                  System.Environment.MachineName.ToString().ToUpper(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_validation_operator",
                  System.Environment.UserName.ToString().ToUpper(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_validation_complete",
                  DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), OracleType.VarChar, ParameterDirection.Input, cmd);
                if (CP.ValidationStart.Length > 0)
                {
                    DBUtilities.CreateAndAddParameter("p_in_validation_start",
                       CP.ValidationStart, OracleType.VarChar, ParameterDirection.Input, cmd);
                }
                DBUtilities.CreateAndAddParameter("p_in_received_date",
                  CP.ReceivedDate, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_docustream_request_id",
                  CP.DocustreamRequestID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_kicker_request_id",
                  CP.AWDRequestID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_case_id",
                  CP.AWDCaseID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_transaction_id",
                  CP.AWDTranID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_source_id",
                  CP.AWDSourceID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_front_office_request_id",
                  CP.FORequestID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_third_party_request_id",
                  CP.TPRequestID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_fnp8_docclassname",
                  CP.FNP8_DOCCLASSNAME, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_fnp8_objectstore",
                  CP.FNP8_OBJECTSTORE, OracleType.VarChar, ParameterDirection.Input, cmd);
                //at this point we need to add any custom parameters to the command
                processDBParms(ref  CP, ref  cmd);
                DBUtilities.CreateAndAddParameter("p_out_item_id",
                   OracleType.Int32, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() != "SUCCESSFUL")
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }
                else
                {
                    CP.BatchItemID = int.Parse(cmd.Parameters[
                       "p_out_item_id"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.createBatchItem: " + ex.Message);

            }
        }
        public void createBatchItemReject(ref CommonParameters CP)
        {

            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(CREATE_BATCH_ITEM_REJECT, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_app_name",
                  "DD", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_machine_name",
                  System.Environment.MachineName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_user_id",
                  System.Environment.UserName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_batch_no",
                  CP.BatchNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_f_doc_xref",
                  CP.CurrentNodeID, OracleType.VarChar, ParameterDirection.Input, cmd);
                //START: AR 145620
                DBUtilities.CreateAndAddParameter("p_in_reason_code",
                  CP.ReasonCode, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_process_step",
                  CP.ProcessStep, OracleType.VarChar, ParameterDirection.Input, cmd);
                //END: AR 145620
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() != "SUCCESSFUL")
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }
                Disconnect();
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.createBatchItemReject: " + ex.Message);

            }
        }
        public void createDDItem(ref CommonParameters CP)
        {
            try
            {

                int intCurrentStatus = 100;
                OracleCommand cmd = GenerateCommand(CREATE_DD_ITEM, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_action_indicator",
                  "I", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_app_name",
                  "DD", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_machine_name",
                  System.Environment.MachineName.ToString(), OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_user_id",
                  System.Environment.UserName.ToString(), OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_batch_no",
                  CP.BatchNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_f_doc_xref",
                  CP.CurrentNodeID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_f_docclassname",
                  CP.FDocClassName, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_fnp8_docclassname",
                  CP.FNP8_DOCCLASSNAME, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_fnp8_objectstore",
                  CP.FNP8_OBJECTSTORE, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_fnp8_folder",
                  CP.FNP8_FOLDER, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_current_status",
                  intCurrentStatus, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_dd_item_seq",
                   OracleType.Int32, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() != "SUCCESSFUL")
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }
                else
                {
                    CP.DDItemSeq = int.Parse(cmd.Parameters[
                       "p_out_dd_item_seq"].Value.ToString());
                }
                createDDItemIndexes(ref CP);
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.createDDItem: " + ex.Message);
            }
        }
        public void createDDItemIndex(int DDItemSeq, string indexName, string indexNameP8, string indexValue)
        {
            try
            {

                OracleCommand cmd = GenerateCommand(CREATE_DD_ITEM_INDEXES, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_app_name",
                  "DD", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_machine_name",
                  System.Environment.MachineName.ToString(), OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_user_id",
                  System.Environment.UserName.ToString(), OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_dd_item_seq",
                  DDItemSeq, OracleType.Int32, ParameterDirection.Input, cmd);
                if (indexName.Length > 0)
                {
                    DBUtilities.CreateAndAddParameter("p_in_index_name",
                        indexName, OracleType.VarChar, ParameterDirection.Input, cmd);
                }
                if (indexNameP8.Length > 0)
                {
                    DBUtilities.CreateAndAddParameter("p_in_fnp8_index_name",
                        indexNameP8, OracleType.VarChar, ParameterDirection.Input, cmd);
                }
                DBUtilities.CreateAndAddParameter("p_in_index_value",
                    indexValue, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() != "SUCCESSFUL")
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }

            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.createDDItemIndex: " + ex.Message);
            }
        }
        public void createDDUserTracking(ref CommonParameters CP, string action, string fieldsUsed)
        {
            try
            {
                if (CP.TrackUser)
                {
                    Connect();
                    OracleCommand cmd = GenerateCommand(CREATE_DD_USER_TRACKING, CommandType.StoredProcedure);

                    DBUtilities.CreateAndAddParameter("p_in_app_machine",
                      Environment.MachineName, OracleType.VarChar, ParameterDirection.Input, cmd);
                    DBUtilities.CreateAndAddParameter("p_in_batch_no",
                      CP.BatchNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                    DBUtilities.CreateAndAddParameter("p_in_node_id",
                      CP.CurrentNodeID, OracleType.VarChar, ParameterDirection.Input, cmd);
                    DBUtilities.CreateAndAddParameter("p_in_user_id",
                      Environment.UserName, OracleType.VarChar, ParameterDirection.Input, cmd);
                    DBUtilities.CreateAndAddParameter("p_in_action",
                      action, OracleType.VarChar, ParameterDirection.Input, cmd);
                    DBUtilities.CreateAndAddParameter("p_in_fields_used",
                      fieldsUsed, OracleType.VarChar, ParameterDirection.Input, cmd);
                    DBUtilities.CreateAndAddParameter("p_out_result",
                       OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                    DBUtilities.CreateAndAddParameter("p_out_error_message",
                       OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                    cmd.ExecuteNonQuery();

                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    Disconnect();
                }
            }
            catch
            {
                //do not throw error for logging issue
            }
        }
        public void updateDDItem(ref CommonParameters CP)
        {
            try
            {
                OracleCommand cmd = GenerateCommand(CREATE_DD_ITEM, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_action_indicator",
                  "U", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_app_name",
                  "DD", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_machine_name",
                  System.Environment.MachineName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_user_id",
                  System.Environment.UserName.ToString(), OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_batch_no",
                  CP.BatchNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_f_doc_xref",
                  CP.CurrentNodeID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_dd_item_seq",
                  CP.DDItemSeq, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_docustream_request_id",
                  CP.DocustreamRequestID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_kicker_request_id",
                  CP.AWDRequestID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_case_id",
                  CP.AWDCaseID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_transaction_id",
                  CP.AWDTranID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_source_id",
                  CP.AWDSourceID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_front_office_request_id",
                  CP.FORequestID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_third_party_request_id",
                  CP.TPRequestID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_invoice_request_id",
                  CP.InvoiceRequestID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_current_status",
                  150, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_dd_item_seq",
                   OracleType.Int32, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() != "SUCCESSFUL")
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.updateDDItem: " + ex.Message);
            }
        }
        public void releaseDDItem(ref CommonParameters CP)
        {
            try
            {
                OracleCommand cmd = GenerateCommand(CREATE_DD_ITEM, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_action_indicator",
                  "U", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_app_name",
                  "DD", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_machine_name",
                  System.Environment.MachineName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_user_id",
                  System.Environment.UserName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_batch_no",
                  CP.BatchNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_f_doc_xref",
                  CP.CurrentNodeID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_dd_item_seq",
                  CP.DDItemSeq, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_current_status",
                  200, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_dd_item_seq",
                   OracleType.Int32, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() != "SUCCESSFUL")
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.releaseDDItem: " + ex.Message);
            }
        }
        public void getRouteCode(ref CommonParameters CP)
        {
            try
            {

                Connect();
                OracleCommand cmd = GenerateCommand(CLAIMS_ROUTING, CommandType.StoredProcedure);

                DBUtilities.CreateAndAddParameter("p_in_site",
                   CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);

                DBUtilities.CreateAndAddParameter("p_in_sort_code",
                   CP.SortCode, OracleType.VarChar, ParameterDirection.Input, cmd);

                DBUtilities.CreateAndAddParameter("p_in_form_name",
                   CP.FormName, OracleType.VarChar, ParameterDirection.Input, cmd);

                DBUtilities.CreateAndAddParameter("p_in_va_tin",
                   CP.ProviderTIN, OracleType.VarChar, ParameterDirection.Input, cmd);

                DBUtilities.CreateAndAddParameter("p_in_tob",
                   CP.TypeOfBill, OracleType.VarChar, ParameterDirection.Input, cmd);

                DBUtilities.CreateAndAddParameter("p_in_hcfa_count",
                   CP.CountHCFA, OracleType.VarChar, ParameterDirection.Input, cmd);

                DBUtilities.CreateAndAddParameter("p_in_ub92_count",
                   CP.CountUB92, OracleType.VarChar, ParameterDirection.Input, cmd);

                DBUtilities.CreateAndAddParameter("p_in_eomb_count",
                   CP.CountEOMB, OracleType.VarChar, ParameterDirection.Input, cmd);

                DBUtilities.CreateAndAddParameter("p_in_pheomb_count",
                   CP.CountPHEOMB, OracleType.VarChar, ParameterDirection.Input, cmd);

                DBUtilities.CreateAndAddParameter("p_in_policy_number",
                   CP.PolicyNo, OracleType.VarChar, ParameterDirection.Input, cmd);

                DBUtilities.CreateAndAddParameter("p_in_company_code",
                   CP.CompanyCode, OracleType.VarChar, ParameterDirection.Input, cmd);

                DBUtilities.CreateAndAddParameter("p_out_route", OracleType.VarChar,
                   ParameterDirection.Output, 3, cmd);

                DBUtilities.CreateAndAddParameter("p_out_doc_type", OracleType.VarChar,
                   ParameterDirection.Output, 10, cmd);

                DBUtilities.CreateAndAddParameter("p_out_doc_class", OracleType.VarChar,
                   ParameterDirection.Output, 20, cmd);

                DBUtilities.CreateAndAddParameter("p_out_docustream_code", OracleType.VarChar,
                   ParameterDirection.Output, 1, cmd);

                DBUtilities.CreateAndAddParameter("p_out_business_area", OracleType.VarChar,
                   ParameterDirection.Output, 25, cmd);

                DBUtilities.CreateAndAddParameter("p_out_work_type", OracleType.VarChar,
                   ParameterDirection.Output, 25, cmd);

                DBUtilities.CreateAndAddParameter("p_out_result", OracleType.VarChar,
                   ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message", OracleType.VarChar,
                   ParameterDirection.Output, 4000, cmd);

                //execute the procedure
                cmd.ExecuteNonQuery();

                //grab the values               
                if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "SUCCESSFUL")
                {
                    CP.DocType = Convert.ToString(cmd.Parameters["p_out_doc_type"].Value);
                    CP.FDocClassName = Convert.ToString(cmd.Parameters["p_out_doc_class"].Value);
                    string routeCode = Convert.ToString(cmd.Parameters["p_out_route"].Value);
                    routeCode = routeCode.PadLeft(3, char.Parse("0"));
                    if (CP.SiteID == "CIC")
                    {
                        routeCode = "C_C" + routeCode;
                    }
                    else
                    {
                        routeCode = "C_B" + routeCode;
                    }
                    CP.RouteCode = routeCode;
                    CP.DocustreamCode = Convert.ToString(cmd.Parameters["p_out_docustream_code"].Value);
                    CP.BusinessArea = Convert.ToString(cmd.Parameters["p_out_business_area"].Value);
                    CP.WorkType = Convert.ToString(cmd.Parameters["p_out_work_type"].Value);

                }
                else
                {
                    throw new Exception("-266007829; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                       cmd.Parameters["p_out_error_message"].Value.ToString());
                }
                Disconnect();
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.getRouteCode: " + ex.Message);
            }
        }
        public void createDSTRequest(ref CommonParameters CP)
        {
            try
            {
                OracleCommand cmd = GenerateCommand(
                   CREATE_DOCUSTREAM_REQUEST, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_action_indicator",
                  "I", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_app_name",
                  "DD", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_machine_name",
                  System.Environment.MachineName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_user_id",
                  System.Environment.UserName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_current_status",
                  100, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_batch_no",
                  CP.BatchNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_received_date",
                  CP.ReceivedDate, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_scan_complete",
                  CP.ScanDate, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_box_no",
                  CP.BoxNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_route_code",
                  CP.RouteCode, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_line_of_business",
                  CP.LineOfBusiness, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_f_doc_xref",
                  CP.CurrentNodeID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_external_item_id",
                  CP.FisDocID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_policy_no",
                  CP.PolicyNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_img_count",
                  CP.ImgCount, OracleType.VarChar, ParameterDirection.Input, cmd);

                //START: AR 140785
                DBUtilities.CreateAndAddParameter("p_in_fnp8_objectstore",
                  CP.FNP8_OBJECTSTORE, OracleType.VarChar, ParameterDirection.Input, cmd);
                //END: AR 140785

                DBUtilities.CreateAndAddParameter("p_out_docustream_request_id",
                   OracleType.Int32, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() != "SUCCESSFUL")
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }
                else
                {
                    CP.DocustreamRequestID = int.Parse(cmd.Parameters["p_out_docustream_request_id"]
                       .Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.createDSTRequest: " + ex.Message);
            }
        }
        public void createFORequest(ref CommonParameters CP)
        {
            try
            {
                int intCurrentStatus = 100;
                OracleCommand cmd = GenerateCommand(CREATE_FRONT_OFFICE_REQUEST, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_action_indicator",
                   "I", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_app_name",
                  "DD", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_machine_name",
                  System.Environment.MachineName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_user_id",
                  System.Environment.UserName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_current_status",
                  intCurrentStatus, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_batch_no",
                  CP.BatchNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_f_doc_xref",
                  CP.CurrentNodeID, OracleType.VarChar, ParameterDirection.Input, cmd);

                //START: AR 140785
                DBUtilities.CreateAndAddParameter("p_in_fnp8_objectstore",
                  CP.FNP8_OBJECTSTORE, OracleType.VarChar, ParameterDirection.Input, cmd);
                //END: AR 140785

                DBUtilities.CreateAndAddParameter("p_out_front_office_request_id",
                   OracleType.Int32, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);
                //at this point we need to add any custom parameters to the command
                processRequestParms(ref  CP, ref  cmd, "FO_PARAM_NAME");

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() != "SUCCESSFUL")
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }
                else
                {



                    if (cmd.Parameters["p_out_front_office_request_id"].Value is DBNull == false)
                    {
                        CP.FORequestID = (int)cmd.Parameters["p_out_front_office_request_id"].Value;
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.createFORequest: " + ex.Message);
            }
        }
        public void createInvoiceRequest(ref CommonParameters CP)
        {
            try
            {
                int intCurrentStatus = 100;
                OracleCommand cmd = GenerateCommand(CREATE_INVOICE_REQUEST, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_action_indicator",
                   "I", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_app_name",
                  "DD", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_machine_name",
                  System.Environment.MachineName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_user_id",
                  System.Environment.UserName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_current_status",
                  intCurrentStatus, OracleType.Number, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_batch_no",
                  CP.BatchNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_f_doc_xref",
                  CP.CurrentNodeID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_invoice_request_id",
                   OracleType.Int32, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);
                //at this point we need to add any custom parameters to the command
                processRequestParms(ref  CP, ref  cmd, "INVOICE_PARAM_NAME");

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() != "SUCCESSFUL")
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }
                else
                {

                    if (cmd.Parameters["p_out_invoice_request_id"].Value is DBNull == false)
                    {
                        CP.InvoiceRequestID = (int)cmd.Parameters["p_out_invoice_request_id"].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.createInvoiceRequest: " + ex.Message);
            }
        }
        public void createInvoiceDetail(ref CommonParameters CP)
        {
            try
            {
                OracleCommand cmd = GenerateCommand(CREATE_INVOICE_DETAIL, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_batch_no",
                  CP.BatchNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_f_doc_xref",
                  CP.CurrentNodeID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_invoice_request_id",
                  CP.InvoiceRequestID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_invoice_line_number",
                  1, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_invoice_line_type",
                  "ITEM", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_quantity",
                  1, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_uom",
                  "EACH", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_unit_price",
                  CP.InvoiceTotal, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_line_amount",
                  CP.InvoiceTotal, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() != "SUCCESSFUL")
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }
                else
                {
                    //is there anything to do here?
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.createInvoiceDetail: " + ex.Message);
            }
        }
        public void createTPRequest(ref CommonParameters CP)
        {
            try
            {
                int intCurrentStatus = 100;
                OracleCommand cmd = GenerateCommand(CREATE_THIRD_PARTY_REQUEST, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_action_indicator",
                   "I", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_app_name",
                  "DD", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_machine_name",
                  System.Environment.MachineName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_user_id",
                  System.Environment.UserName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_current_status",
                  intCurrentStatus, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_batch_no",
                  CP.BatchNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_f_doc_xref",
                  CP.CurrentNodeID, OracleType.VarChar, ParameterDirection.Input, cmd);

                //START: AR 140785
                DBUtilities.CreateAndAddParameter("p_in_fnp8_objectstore",
                  CP.FNP8_OBJECTSTORE, OracleType.VarChar, ParameterDirection.Input, cmd);
                //END: AR 140785

                DBUtilities.CreateAndAddParameter("p_out_third_party_request_id",
                   OracleType.Int32, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);
                //at this point we need to add any custom parameters to the command
                processRequestParms(ref  CP, ref  cmd, "TP_PARAM_NAME");

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() != "SUCCESSFUL")
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }
                else
                {



                    if (cmd.Parameters["p_out_third_party_request_id"].Value is DBNull == false)
                    {
                        CP.TPRequestID = (int)cmd.Parameters["p_out_third_party_request_id"].Value;
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.createTPRequest: " + ex.Message);
            }
        }
        public void createAWDRequest(ref CommonParameters CP, int caseID, int tranID,
                                            int sourceID, string workType)
        {
            try
            {
                OracleCommand cmd = GenerateCommand(CREATE_AWD_REQUEST, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_app_name",
                  "DD", OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_machine_name",
                  System.Environment.MachineName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_user_id",
                  System.Environment.UserName.ToString(),
                  OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_batch_no",
                  CP.BatchNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_priority",
                  CP.AWDPriority, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_kicker_request_id",
                  CP.AWDRequestID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_case_id",
                  caseID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_transaction_id",
                  tranID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_source_id",
                  sourceID, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_business_area",
                  CP.BusinessArea, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_work_type",
                  workType, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_awd_stat_code",
                  CP.AWDStatus, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_f_doc_xref",
                  CP.CurrentNodeID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_source_type",
                  CP.AWDSourceType, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_case_id",
                   OracleType.Int32, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_transaction_id",
                   OracleType.Int32, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_source_id",
                   OracleType.Int32, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_kicker_request_id",
                   OracleType.Int32, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() != "SUCCESSFUL")
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }
                else
                {


                    if (cmd.Parameters["p_out_kicker_request_id"].Value is DBNull == false)
                    {
                        CP.AWDRequestID = (int)cmd.Parameters["p_out_kicker_request_id"].Value;
                    }
                    if (cmd.Parameters["p_out_case_id"].Value is DBNull == false)
                    {
                        CP.AWDCaseID = (int)cmd.Parameters["p_out_case_id"].Value;
                    }
                    if (cmd.Parameters["p_out_transaction_id"].Value is DBNull == false)
                    {
                        CP.AWDTranID = (int)cmd.Parameters["p_out_transaction_id"].Value;
                    }
                    if (cmd.Parameters["p_out_source_id"].Value is DBNull == false)
                    {
                        CP.AWDSourceID = (int)cmd.Parameters["p_out_source_id"].Value;
                    }




                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.createAWDRequest: " + ex.Message);
            }
        }
        public void createAWDLOBs(ref CommonParameters CP, string name, string value, string type)
        {
            try
            {
                if (value.Length > 0)
                {
                    int objectID;
                    switch (type)
                    {
                        case "T":
                            objectID = CP.AWDTranID;
                            break;
                        case "S":
                            objectID = CP.AWDSourceID;
                            break;
                        case "C":
                            objectID = CP.AWDCaseID;
                            break;
                        default:
                            objectID = CP.AWDSourceID;
                            break;
                    }
                    if (objectID > 0)
                    {
                        OracleCommand cmd = GenerateCommand(CREATE_AWD_LOB, CommandType.StoredProcedure);
                        DBUtilities.CreateAndAddParameter("p_in_app_name",
                          "DD", OracleType.VarChar, ParameterDirection.Input, cmd);
                        DBUtilities.CreateAndAddParameter("p_in_machine_name",
                          System.Environment.MachineName.ToString(),
                          OracleType.VarChar, ParameterDirection.Input, cmd);
                        DBUtilities.CreateAndAddParameter("p_in_user_id",
                          System.Environment.UserName.ToString(),
                          OracleType.VarChar, ParameterDirection.Input, cmd);
                        //ensure the field is numeric
                        DBUtilities.CreateAndAddParameter("p_in_kicker_request_id",
                          CP.AWDRequestID, OracleType.Int32, ParameterDirection.Input, cmd);
                        DBUtilities.CreateAndAddParameter("p_in_lob_name",
                          name, OracleType.VarChar, ParameterDirection.Input, cmd);
                        DBUtilities.CreateAndAddParameter("p_in_lob_value",
                          value, OracleType.VarChar, ParameterDirection.Input, cmd);
                        DBUtilities.CreateAndAddParameter("p_in_record_type",
                          type, OracleType.VarChar, ParameterDirection.Input, cmd);
                        DBUtilities.CreateAndAddParameter("p_in_kicker_object_id",
                           objectID, OracleType.Int32, ParameterDirection.Input, cmd);
                        DBUtilities.CreateAndAddParameter("p_out_result",
                           OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                        DBUtilities.CreateAndAddParameter("p_out_error_message",
                           OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                        cmd.ExecuteNonQuery();

                        if (cmd.Parameters["p_out_result"].Value.ToString()
                           .ToUpper() != "SUCCESSFUL")
                        {
                            throw new Exception("-266088529; Procedure Error: " +
                               cmd.Parameters["p_out_result"].Value.ToString() +
                               "; Oracle Error: " + cmd.Parameters[
                               "p_out_error_message"].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.createAWDLOBs: " + ex.Message);
            }
        }
        public void getFISID(ref CommonParameters CP)
        {
            try
            {
                string tmpScanDate = "";
                if (CP.ScanDate.Length > 0)
                {
                    //first we need to format the scan date to mmddyy
                    DateTime scandate;
                    //convert the value to a date
                    scandate = DateTime.Parse(CP.ScanDate);
                    tmpScanDate = scandate.ToString("MMddyy");
                }
                //DataAccess _dbAccess = new DataAccess();            
                OracleCommand cmd = GenerateCommand(GET_FIS_ID, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_batch_source_code",
                  CP.ScannerID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_scanned_date",
                  tmpScanDate, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_fis_id",
                  OracleType.VarChar, ParameterDirection.Output, 15, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "SUCCESSFUL")
                {
                    //grab the values
                    CP.FisDocID = cmd.Parameters["p_out_fis_id"]
                       .Value.ToString();
                    //set in table if entry exists
                    foreach (DataRow dr in CP._MVIFieldData.DD_MVI_FIELD_DEFINITION.Rows)
                    {
                        //get the sp parameter name
                        string fieldName = dr["FIELD_NAME"].ToString();
                        //check the parameter name... if there is none, do not add 
                        if (fieldName == "FISDocID")
                        {
                            dr["LOCAL_VALUE"] = CP.FisDocID;
                        }
                    }
                }
                else
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                       cmd.Parameters["p_out_error_message"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.getFISID: " + ex.Message);
            }
        }
        public List<string> getBAList(ref CommonParameters CP)
        {
            try
            {
                List<string> BAList = new List<string>();
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_BA_LIST, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_work_category",
                  CP.WorkCategory, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                using (OracleDataReader dataReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        // Always call Read before accessing data.
                        while (dataReader.Read())
                        {
                            BAList.Add(dataReader.GetString(0));
                        }

                    }
                }
                Disconnect();
                return BAList;
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.getBAList: " + ex.Message);
            }

        }
        public List<string> getWTList(ref CommonParameters CP)
        {
            try
            {
                List<string> WTList = new List<string>();
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_WT_LIST, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_business_area",
                  CP.BusinessArea, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_work_category",
                  CP.WorkCategory, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);
                using (OracleDataReader dataReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        // Always call Read before accessing data.
                        while (dataReader.Read())
                        {
                            WTList.Add(dataReader.GetString(0));
                        }
                    }
                }
                Disconnect();
                return WTList;
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.getWTList: " + ex.Message);
            }

        }
        public List<string> getSystemList(ref CommonParameters CP)
        {
            try
            {
                List<string> SystemList = new List<string>();
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_SYSTEM_LIST, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_work_category",
                  CP.WorkCategory, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);
                using (OracleDataReader objReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        // Always call Read before accessing data.
                        while (objReader.Read())
                        {
                            SystemList.Add(objReader.GetString(0));
                        }
                    }
                    Disconnect();
                    return SystemList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.getSystemList: " + ex.Message);
            }

        }
        public List<string> getCompanyList(ref CommonParameters CP)
        {
            try
            {
                List<string> CompanyList = new List<string>();
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_COMPANY_LIST, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_system_id",
                  CP.SystemID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_work_category",
                  CP.WorkCategory, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);
                using (OracleDataReader objReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        if (objReader.HasRows)
                        {
                            // Always call Read before accessing data.
                            while (objReader.Read())
                            {
                                CompanyList.Add(objReader.GetString(0));
                            }
                        }
                    }

                    Disconnect();
                    return CompanyList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.getCompanyList: " + ex.Message);
            }

        }
        public void getXrefValues(ref CommonParameters CP)
        {

            try
            {
                //DataAccess _dbAccess = new DataAccess();            
                Connect();
                OracleCommand cmd = null;
                if (CP.WorkType.Length > 0)
                {
                    cmd = GenerateCommand(SELECT_BA_WT_VALUES, CommandType.StoredProcedure);

                    DBUtilities.CreateAndAddParameter("p_in_site_id",
                      CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                    DBUtilities.CreateAndAddParameter("p_in_business_area",
                      CP.BusinessArea, OracleType.VarChar, ParameterDirection.Input, cmd);
                    DBUtilities.CreateAndAddParameter("p_in_work_type",
                      CP.WorkType, OracleType.VarChar, ParameterDirection.Input, cmd);
                    DBUtilities.CreateAndAddParameter("p_in_work_category",
                      CP.WorkCategory, OracleType.VarChar, ParameterDirection.Input, cmd);
                    DBUtilities.CreateAndAddParameter("p_out_f_docclassname",
                      OracleType.VarChar, ParameterDirection.Output, 20, cmd);
                    DBUtilities.CreateAndAddParameter("p_out_document_type",
                      OracleType.VarChar, ParameterDirection.Output, 10, cmd);
                    DBUtilities.CreateAndAddParameter("p_out_lob",
                      OracleType.VarChar, ParameterDirection.Output, 3, cmd);
                    DBUtilities.CreateAndAddParameter("p_out_FNP8_DOCCLASSNAME",
                      OracleType.VarChar, ParameterDirection.Output, 50, cmd);
                    DBUtilities.CreateAndAddParameter("p_out_FNP8_OBJECTSTORE",
                      OracleType.VarChar, ParameterDirection.Output, 50, cmd);
                    DBUtilities.CreateAndAddParameter("p_out_FNP8_FOLDER",
                      OracleType.VarChar, ParameterDirection.Output, 250, cmd);

                    DBUtilities.CreateAndAddParameter("p_out_result",
                       OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                    DBUtilities.CreateAndAddParameter("p_out_error_message",
                       OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                }

                else//assume this is a case with source only
                {

                    cmd = GenerateCommand(SELECT_BA_CASEWT_VALUES, CommandType.StoredProcedure);

                    DBUtilities.CreateAndAddParameter("p_in_site_id",
                      CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                    DBUtilities.CreateAndAddParameter("p_in_business_area",
                      CP.BusinessArea, OracleType.VarChar, ParameterDirection.Input, cmd);
                    DBUtilities.CreateAndAddParameter("p_in_case_work_type",
                      CP.CaseWorkType, OracleType.VarChar, ParameterDirection.Input, cmd);
                    DBUtilities.CreateAndAddParameter("p_out_f_docclassname",
                      OracleType.VarChar, ParameterDirection.Output, 20, cmd);
                    DBUtilities.CreateAndAddParameter("p_out_document_type",
                      OracleType.VarChar, ParameterDirection.Output, 10, cmd);
                    DBUtilities.CreateAndAddParameter("p_out_lob",
                      OracleType.VarChar, ParameterDirection.Output, 3, cmd);
                    DBUtilities.CreateAndAddParameter("p_out_FNP8_DOCCLASSNAME",
                      OracleType.VarChar, ParameterDirection.Output, 50, cmd);
                    DBUtilities.CreateAndAddParameter("p_out_FNP8_OBJECTSTORE",
                      OracleType.VarChar, ParameterDirection.Output, 50, cmd);
                    DBUtilities.CreateAndAddParameter("p_out_FNP8_FOLDER",
                      OracleType.VarChar, ParameterDirection.Output, 250, cmd);
                    DBUtilities.CreateAndAddParameter("p_out_result",
                       OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                    DBUtilities.CreateAndAddParameter("p_out_error_message",
                       OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                }


                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "SUCCESSFUL")
                {
                    //grab the values if they aren't overridden previously
                    if (CP.FDocClassName.Length == 0 && cmd.Parameters["p_out_f_docclassname"].Value != null)
                    {
                        CP.FDocClassName = cmd.Parameters["p_out_f_docclassname"]
                           .Value.ToString();
                    }
                    if (CP.DocType.Length == 0)
                    {
                        CP.DocType = cmd.Parameters["p_out_document_type"]
                           .Value.ToString();
                    }
                    if (CP.LineOfBusiness.Length == 0)
                    {
                        CP.LineOfBusiness = cmd.Parameters["p_out_lob"]
                           .Value.ToString();
                    }
                    if (CP.FNP8_DOCCLASSNAME.Length == 0 && cmd.Parameters["p_out_FNP8_DOCCLASSNAME"].Value != null)
                    {
                        CP.FNP8_DOCCLASSNAME = cmd.Parameters["p_out_FNP8_DOCCLASSNAME"]
                           .Value.ToString();
                    }
                    if (CP.FNP8_FOLDER.Length == 0 && cmd.Parameters["p_out_FNP8_FOLDER"].Value != null)
                    {
                        CP.FNP8_FOLDER = cmd.Parameters["p_out_FNP8_FOLDER"]
                           .Value.ToString();
                    }
                    if (CP.FNP8_OBJECTSTORE.Length == 0 && cmd.Parameters["p_out_FNP8_OBJECTSTORE"].Value != null)
                    {
                        CP.FNP8_OBJECTSTORE = cmd.Parameters["p_out_FNP8_OBJECTSTORE"]
                           .Value.ToString();
                    }
                    Disconnect();
                    //loop through table and set local value if it does not already contain a value.
                    foreach (DataRow dr in CP._MVIFieldData.Tables["DD_MVI_FIELD_DEFINITION"].Rows)
                    {
                        string FieldName = dr["FIELD_NAME"].ToString();
                        switch (FieldName)
                        {

                            case "DocType":
                                if (dr["LOCAL_VALUE"].ToString().Length == 0)
                                {
                                    dr["LOCAL_VALUE"] = CP.DocType;
                                }
                                break;
                            case "LineOfBusiness":
                                if (dr["LOCAL_VALUE"].ToString().Length == 0)
                                {
                                    dr["LOCAL_VALUE"] = CP.LineOfBusiness;
                                }
                                break;


                        }

                    }
                }
                else
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.GetXrefValues: " + ex.Message);
            }
        }
        public AWDHierarchy getAWDHierarchy(ref CommonParameters CP)
        {
            try
            {
                AWDHierarchy retAWDHierarchy = new AWDHierarchy();
                //DataAccess dbAccess = new DataAccess();
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_HIERARCHY_LIST, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_work_category",
                  CP.WorkCategory, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);
                using (OracleDataReader objReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        DataRow workingRow;
                        // Always call Read before accessing data.
                        while (objReader.Read())
                        {

                            workingRow = retAWDHierarchy.Hierarchy.NewRow();
                            workingRow["WORK_CATEGORY"] = objReader.GetString(1);
                            workingRow["STRUCTURE_SELECTION"] = objReader.GetString(2);
                            workingRow["SITE_ID"] = objReader.GetString(0);
                            workingRow["CASE_ID"] = objReader.GetInt32(3);
                            workingRow["TRANSACTION_ID"] = objReader.GetInt32(4);
                            workingRow["SOURCE_ID"] = objReader.GetInt32(5);
                            workingRow["DEFAULT_SELECTION"] = objReader.GetString(6);

                            retAWDHierarchy.Hierarchy.Rows.Add(workingRow);
                        }
                    }
                    Disconnect();
                    return retAWDHierarchy;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.getAWDHierarchy: " + ex.Message);
            }
        }
        public void getMVIFieldData(ref CommonParameters CP)
        {
            try
            {
                //clear field tables
                CP._MVIFieldData = new MVIFieldData();
                Connect();
                //fill definition
                OracleCommand cmd = GenerateCommand(SELECT_DD_MVI_FIELD_DEFINITION, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_work_category",
                  CP.WorkCategory, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                OracleDataAdapter odaWID = new OracleDataAdapter(cmd);
                odaWID.Fill(CP._MVIFieldData.DD_MVI_FIELD_DEFINITION);
                //update CP to defaults if needed
                foreach (DataRow dr in CP._MVIFieldData.DD_MVI_FIELD_DEFINITION.Rows)
                {
                    string defaultValue = dr["DEFAULT_VALUE"].ToString();
                    if (defaultValue.Length != 0)
                    //update the localValue in the dataset
                    {
                        if (CP[dr["FIELD_NAME"].ToString()].ToString().Length == 0)
                        //only set the values if they haven't been set by previous logic already
                        {
                            if (defaultValue != null)
                            {
                                CP[dr["FIELD_NAME"].ToString()] = defaultValue;
                            }
                        }
                    }
                }

                //fill choices
                cmd = GenerateCommand(SELECT_DD_MVI_FIELD_CHOICES, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_work_category",
                  CP.WorkCategory, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                odaWID = new OracleDataAdapter(cmd);
                odaWID.Fill(CP._MVIFieldData.DD_MVI_FIELD_CHOICES);

                //fill conditions
                cmd = GenerateCommand(SELECT_DD_MVI_FIELD_CONDITIONS, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_work_category",
                  CP.WorkCategory, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                odaWID = new OracleDataAdapter(cmd);
                odaWID.Fill(CP._MVIFieldData.DD_MVI_FIELD_CONDITIONS);

                //fill awd lobs
                cmd = GenerateCommand(SELECT_DD_MVI_AWD_LOB_DEFINITION, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_work_category",
                  CP.WorkCategory, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                odaWID = new OracleDataAdapter(cmd);
                odaWID.Fill(CP._MVIFieldData.DD_MVI_AWD_LOB_DEFINITION);


                Disconnect();
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.getMVIFieldData: " + ex.Message);
            }
        }
        public List<string> getIAProcessNames()
        {
            try
            {
                List<string> IAProcessList = new List<string>();
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_JOB_NAMES, CommandType.StoredProcedure);

                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                using (OracleDataReader objReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        // Always call Read before accessing data.
                        while (objReader.Read())
                        {
                            IAProcessList.Add(objReader.GetString(0));
                        }
                    }
                    Disconnect();
                    return IAProcessList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.getIAProcessNames ERROR: " + ex.Message);
            }

        }
        public List<string> getCaseWT(ref CommonParameters CP)
        {
            try
            {
                List<string> CaseWTList = new List<string>();
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_CASE_WT_LIST, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_business_area",
                  CP.BusinessArea, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);
                using (OracleDataReader objReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        // Always call Read before accessing data.
                        while (objReader.Read())
                        {
                            CaseWTList.Add(objReader.GetString(0));
                        }
                    }
                    Disconnect();
                    return CaseWTList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.getCaseWT: " + ex.Message);
            }

        }
        public void getAWDLinkData(ref CommonParameters CP)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_AWD_LINK_DATA, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_dd_item_seq",
                  CP.DDItemSeqPrevious, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_case_id",
                   OracleType.Int32, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_tran_id",
                   OracleType.Int32, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_kicker_request_id",
                   OracleType.Int32, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);
                cmd.ExecuteNonQuery();
                if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() == "SUCCESSFUL")
                {
                    if (cmd.Parameters["p_out_case_id"].Value.ToString().Length > 0)
                    {
                        CP.AWDCaseIDPrevious = Int32.Parse(cmd.Parameters["p_out_case_id"].Value.ToString());
                    }
                    if (cmd.Parameters["p_out_tran_id"].Value.ToString().Length > 0)
                    {
                        CP.AWDTranIDPrevious = Int32.Parse(cmd.Parameters["p_out_tran_id"].Value.ToString());
                    }

                    if (cmd.Parameters["p_out_kicker_request_id"].Value.ToString().Length > 0)
                    {
                        CP.AWDRequestIDPrevious = Int32.Parse(cmd.Parameters["p_out_kicker_request_id"].Value.ToString());
                    }

                }
                else if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() != "NODATA")
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }
                Disconnect();

            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.getAWDLinkData: " + ex.Message);
            }
        }
        public string getBundleFlag(ref CommonParameters CP)
        {
            try
            {
                string retBundleFlag = "";
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_BUNDLE_NO, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_sort_code",
                  CP.SortCode, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_lob",
                  CP.LineOfBusiness, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_bundle",
                   OracleType.VarChar, ParameterDirection.Output, 1, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() == "SUCCESSFUL")
                {
                    retBundleFlag = cmd.Parameters["p_out_bundle"].Value.ToString();
                }
                else if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() != "NODATA")
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }
                Disconnect();
                return retBundleFlag;
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.getBundleFlag: " + ex.Message);

            }
        }
        public void lookupLOB(ref CommonParameters CP)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_SORTCODE_LOB, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_sort_code",
                  CP.SortCode, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_line_of_business",
                  OracleType.VarChar, ParameterDirection.Output, 3, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "SUCCESSFUL")
                {
                    //grab the values
                    string lineOfBusiness = cmd.Parameters["p_out_line_of_business"]
                       .Value.ToString();
                    Disconnect();
                    //if we find an lob, change the value otherwise leave what came from qsearch
                    if (lineOfBusiness.Trim().Length != 0)
                    {
                        CP.LineOfBusiness = lineOfBusiness;
                    }
                }
                else if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() != "NODATA")
                {
                    throw new Exception("-266007829; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                       cmd.Parameters["p_out_error_message"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.lookupLOB: " + ex.Message);
            }
        }
        public void lookupWorktypeBySortCode(ref CommonParameters CP)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_SORTCODE_WORKTYPE, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_sort_code",
                  CP.SortCode, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_work_type",
                  OracleType.VarChar, ParameterDirection.Output, 25, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "SUCCESSFUL")
                {
                    //grab the values
                    CP.WorkType = cmd.Parameters["p_out_work_type"].Value.ToString();
                    Disconnect();
                }
                else if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() != "NODATA")
                {
                    throw new Exception("-266007829; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                       cmd.Parameters["p_out_error_message"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.lookupWorktypeBySortCode: " + ex.Message);
            }
        }
        public int validationVATIN(ref CommonParameters CP)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_VATIN, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_provider_tax_id",
                  CP.SortCode, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_tax_id",
                  OracleType.VarChar, ParameterDirection.Output, 12, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "SUCCESSFUL")
                {
                    //grab the values
                    CP.ProviderTIN = cmd.Parameters["p_out_tax_id"]
                       .Value.ToString().Trim();
                    Disconnect();
                    return 0;
                }
                else if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "NODATA")
                {
                    return -1;
                }
                else
                {
                    return -2;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.lookupLOB: " + ex.Message);
            }
        }
        public DataSet selectGroupDetails(ref CommonParameters CP)
        {
            try
            {
                DataSet DataSetResults = new DataSet();
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_GROUP_DETAILS, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_group_number",
                  CP.GroupNo.Replace("*", "%"), OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_group_name",
                  CP.GroupName.Replace("*", "%"), OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_m_group_number",
                  CP.MasterGroupID.Replace("*", "%"), OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_m_group_name",
                  CP.MasterGroupName.Replace("*", "%"), OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                using (OracleDataReader dataReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        if (dataReader.HasRows)
                        {
                            DataTable dt = new DataTable("Results");
                            DataSetResults.Tables.Add(dt);
                            DataSetResults.Load(dataReader, LoadOption.PreserveChanges, DataSetResults.Tables[0]);
                            Disconnect();
                            return DataSetResults;
                        }
                        else
                        {
                            Disconnect();
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectGroupDetails: " + ex.Message);
            }
        }

        //AR143750 - START
        public string getBusinessAreaFromHolderNumber(ref CommonParameters CP)
        {
            try
            {
                string resultData = "";

                DataSet DataSetResults = new DataSet();
                Connect();
                OracleCommand cmd = GenerateCommand(GET_BA_FROM_HN, CommandType.StoredProcedure);
                
                DBUtilities.CreateAndAddParameter("p_in_holder_number",
                  CP.HolderNumber, OracleType.VarChar, ParameterDirection.Input, cmd);                                
                DBUtilities.CreateAndAddParameter("p_out_business_area",
                  OracleType.VarChar, ParameterDirection.Output, 20, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "SUCCESSFUL")
                {
                    //grab business area
                    CP.BusinessArea = cmd.Parameters["p_out_business_area"].Value.ToString();

                    resultData = "DATAFOUND";
                }
                else if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "NODATA")
                {
                    resultData = "NODATA";
                }
                else if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() != "NODATA")
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                       cmd.Parameters["p_out_error_message"].Value.ToString());
                }

                Disconnect();

                return resultData;
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.getBusinessAreaFromHolderNumber: " + ex.Message);
            }
        }
        //AR143750 - END

        public DataSet selectPrivatePlacement(ref CommonParameters CP, string AsOfDate)
        {
            try
            {
                DataSet DataSetResults = new DataSet();
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_PRIVATE_PLACEMENT, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_cusip",
                  CP.AccountNumber, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_asofdate",
                  AsOfDate, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                using (OracleDataReader dataReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        if (dataReader.HasRows)
                        {
                            DataTable dt = new DataTable("Results");
                            DataSetResults.Tables.Add(dt);
                            DataSetResults.Load(dataReader, LoadOption.PreserveChanges, DataSetResults.Tables[0]);
                            Disconnect();
                            return DataSetResults;
                        }
                        else
                        {
                            Disconnect();
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectPrivatePlacement: " + ex.Message);
            }
        }
        public DataSet selectPrivatePlacement(ref CommonParameters CP)
        {
            try
            {
                DataSet DataSetResults = new DataSet();
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_PRIVATE_PLACEMENT, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_cusip",
                  CP.AccountNumber, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                using (OracleDataReader dataReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        if (dataReader.HasRows)
                        {
                            DataTable dt = new DataTable("Results");
                            DataSetResults.Tables.Add(dt);
                            DataSetResults.Load(dataReader, LoadOption.PreserveChanges, DataSetResults.Tables[0]);
                            Disconnect();
                            return DataSetResults;
                        }
                        else
                        {
                            Disconnect();
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectPrivatePlacement: " + ex.Message);
            }
        }
        public DataSet selectMortgage(ref CommonParameters CP)
        {
            try
            {
                DataSet DataSetResults = new DataSet();
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_MORTGAGE, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_loan_number",
                  CP.AccountNumber, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                using (OracleDataReader dataReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        if (dataReader.HasRows)
                        {
                            DataTable dt = new DataTable("Results");
                            DataSetResults.Tables.Add(dt);
                            DataSetResults.Load(dataReader, LoadOption.PreserveChanges, DataSetResults.Tables[0]);
                            Disconnect();
                            return DataSetResults;
                        }
                        else
                        {
                            Disconnect();
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectMortgage: " + ex.Message);
            }
        }
        public DataSet selectMortgage(ref CommonParameters CP, string Address)
        {
            try
            {
                DataSet DataSetResults = new DataSet();
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_MORTGAGE, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_loan_number",
                  CP.AccountNumber, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_property_address",
                  Address, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                using (OracleDataReader dataReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        if (dataReader.HasRows)
                        {
                            DataTable dt = new DataTable("Results");
                            DataSetResults.Tables.Add(dt);
                            DataSetResults.Load(dataReader, LoadOption.PreserveChanges, DataSetResults.Tables[0]);
                            Disconnect();
                            return DataSetResults;
                        }
                        else
                        {
                            Disconnect();
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectMortgage: " + ex.Message);
            }
        }
        public IndexData selectDataDirectorItem(ref CommonParameters CP)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_DD_ITEM, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_batch_no",
                  CP.BatchNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_doc_xref",
                  CP.CurrentNodeID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);


                IndexData datasetResults = new IndexData();

                OracleDataAdapter odaWID = new OracleDataAdapter(cmd);
                odaWID.Fill(datasetResults.DD_ITEM);


                cmd = GenerateCommand(SELECT_DD_ITEM_INDEXES, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_batch_no",
                  CP.BatchNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_doc_xref",
                  CP.CurrentNodeID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);



                odaWID = new OracleDataAdapter(cmd);
                odaWID.Fill(datasetResults.DD_ITEM_INDEXES);




                Disconnect();

                return datasetResults;

                //using (OracleDataReader dataReader = cmd.ExecuteReader())
                //{
                //   if (cmd.Parameters["p_out_result"].Value.ToString()
                //      .ToUpper() != "SUCCESSFUL")
                //   {
                //      throw new Exception("-266088529; Procedure Error: " +
                //         cmd.Parameters["p_out_result"].Value.ToString() +
                //         "; Oracle Error: " + cmd.Parameters[
                //         "p_out_error_message"].Value.ToString());
                //   }
                //   else
                //   {
                //      if (dataReader.HasRows)
                //      {
                //         DataSet datasetResults = new DataSet();
                //         DataTable dt = new DataTable("Results");
                //         datasetResults.Tables.Add(dt);
                //         datasetResults.Load(dataReader, LoadOption.PreserveChanges, datasetResults.Tables[0]);
                //         Disconnect();
                //         return datasetResults;
                //      }
                //      else
                //      {
                //         Disconnect();
                //         return null;
                //      }
                //   }
                //}
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectDataDirectorItem: " + ex.Message);
            }
        }
        public void deleteDataDirectorItem(ref CommonParameters CP)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(DELETE_DD_ITEM, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_seq_id",
                  CP.DDItemSeq, OracleType.Int32, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();
                if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() != "SUCCESSFUL")
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }
                else
                {
                    Disconnect();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.deleteDataDirectorItem: " + ex.Message);
            }
        }
        public bool CheckTypeOfBill(ref CommonParameters CP)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(CHECK_TYPE_OF_BILL, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_type_of_bill",
                  CP.TypeOfBill, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                switch (cmd.Parameters["p_out_result"].Value.ToString().ToUpper())
                {
                    case "ERROR":
                        CP.IsValidTOB = false;
                        throw new Exception("-266007829; Procedure Error: " +
                            cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                            cmd.Parameters["p_out_error_message"].Value.ToString());
                    case "FOUND":
                        CP.IsValidTOB = true;
                        return true;
                    default:
                        CP.IsValidTOB = false;
                        return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.CheckTypeOfBill: " + ex.Message);
            }
        }
        public bool IsWorkTypeExcluded(ref CommonParameters CP)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(CHECK_BUNDLING_WORKTYPE, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_work_type",
                  CP.WorkType, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                switch (cmd.Parameters["p_out_result"].Value.ToString().ToUpper())
                {
                    case "ERROR":
                        CP.IsBundleNeeded = false;
                        throw new Exception("-266007829; Procedure Error: " +
                            cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                            cmd.Parameters["p_out_error_message"].Value.ToString());
                    case "NOT FOUND":
                        CP.IsBundleNeeded = true;
                        return true;
                    case "FOUND":
                        CP.IsBundleNeeded = false;
                        return false;
                    default:
                        CP.IsBundleNeeded = false;
                        return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.CheckBundleWorktype: " + ex.Message);
            }
        }
        public void selectRouting(ref CommonParameters CP)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_ROUTING, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_work_category",
                  CP.WorkCategory, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_search_provider",
                  OracleType.VarChar, ParameterDirection.Output, 10, cmd);
                DBUtilities.CreateAndAddParameter("p_out_index_type",
                  OracleType.VarChar, ParameterDirection.Output, 10, cmd);
                DBUtilities.CreateAndAddParameter("p_out_site_restriction",
                  OracleType.VarChar, ParameterDirection.Output, 1, cmd);
                DBUtilities.CreateAndAddParameter("p_out_bridge_enabled",
                  OracleType.VarChar, ParameterDirection.Output, 1, cmd);
                DBUtilities.CreateAndAddParameter("p_out_remember_ba_wt",
                  OracleType.VarChar, ParameterDirection.Output, 1, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "SUCCESSFUL")
                {
                    //grab the values
                    CP.SearchProvider = cmd.Parameters["p_out_search_provider"]
                       .Value.ToString();
                    CP.IndexType = cmd.Parameters["p_out_index_type"]
                       .Value.ToString();
                    CP.SiteRestriction = cmd.Parameters["p_out_site_restriction"]
                       .Value.ToString(); Disconnect();
                    CP.BridgeEnabled = cmd.Parameters["p_out_bridge_enabled"]
                       .Value.ToString(); Disconnect();
                    CP.RememberBAWT = cmd.Parameters["p_out_remember_ba_wt"]
                       .Value.ToString(); Disconnect();
                }
                else
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                       cmd.Parameters["p_out_error_message"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectRouting: " + ex.Message);
            }
        }
        public DataSet selectRoutingChoices()
        {

            DataSet DataSetResults = selectRoutingChoices(null);
            return DataSetResults;
        }
        public DataSet selectRoutingChoices(string SiteID)
        {
            try
            {
                DataSet DataSetResults = new DataSet();
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_ROUTING_CHOICES, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                using (OracleDataReader dataReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        if (dataReader.HasRows)
                        {
                            DataTable dt = new DataTable("Results");
                            DataSetResults.Tables.Add(dt);
                            DataSetResults.Load(dataReader, LoadOption.PreserveChanges, DataSetResults.Tables[0]);
                            Disconnect();
                            return DataSetResults;
                        }
                        else
                        {
                            Disconnect();
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectRoutingChoices: " + ex.Message);
            }
        }

        //START: AR 145620
        /// <summary>
        /// This function does a lookup on Pop Code and returns a DataSet with values.
        /// </summary>
        /// <param name="CP"></param>
        /// <returns></returns>
        public void selectPopCodeLookupList(ref CommonParameters CP)
        {
            try
            {
                DataSet DataSetResults = new DataSet();
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_POP_CODE_LOOKUP_LIST, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_pop_code",
                  CP.PopCode, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                using (OracleDataReader dataReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        if (dataReader.HasRows)
                        {
                            DataTable dt = new DataTable("Results");
                            DataSetResults.Tables.Add(dt);
                            DataSetResults.Load(dataReader, LoadOption.PreserveChanges, DataSetResults.Tables[0]);
                            Disconnect();

                            if (!object.ReferenceEquals(DataSetResults, null))
                            {
                                if (DataSetResults.Tables[0].Rows.Count > 0)
                                {
                                    foreach (DataRow row in DataSetResults.Tables[0].Rows)
                                    {
                                        if (row["NAME"].ToString() == "BUSINESS_AREA")
                                            CP.BusinessArea = row["VALUE"].ToString();
                                        else if (row["NAME"].ToString() == "WORK_TYPE")
                                            CP.WorkType = row["VALUE"].ToString();
                                        else if (row["NAME"].ToString() == "REJECT_CODE")
                                            CP.RejectCode = row["VALUE"].ToString();

                                        if ((CP.BusinessArea.Length > 0 && CP.WorkType.Length > 0) || (CP.RejectCode.Length > 0))
                                            CP.IsPopCodeFound = true;
                                    }
                                }
                            }
                        }
                        else
                        {
                            Disconnect();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectPopCodeLookupList: " + ex.Message);
            }
        }
        
        public string getSearchType(string SiteID, string WorkCategory)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(GET_SEARCH_TYPE, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_work_category",
                  WorkCategory, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_search_type",
                  OracleType.VarChar, ParameterDirection.Output, 10, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "SUCCESSFUL")
                {
                    Disconnect();
                    //grab the value
                    return cmd.Parameters["p_out_search_type"].Value.ToString();
                }
                else if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() != "NODATA")
                {
                    throw new Exception("-266007829; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                       cmd.Parameters["p_out_error_message"].Value.ToString());
                }
                else
                {
                    return String.Empty;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.getSearchType" + ex.Message);
            }        
        }

        public DataSet getRejectOptions(string OptionType)
        {
            try
            {
                DataSet DataSetResults = new DataSet();
                Connect();
                OracleCommand cmd = GenerateCommand(GET_REJECT_OPTIONS, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_option_type",
                  OptionType, OracleType.VarChar, ParameterDirection.Input, cmd);                
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                using (OracleDataReader dataReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        if (dataReader.HasRows)
                        {
                            DataTable dt = new DataTable("Results");
                            DataSetResults.Tables.Add(dt);
                            DataSetResults.Load(dataReader, LoadOption.PreserveChanges, DataSetResults.Tables[0]);
                            Disconnect();
                            return DataSetResults;
                        }
                        else
                        {
                            Disconnect();
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.getRejectOptions: " + ex.Message);
            }
        }

        public void updateReasonCode(string BatchNo, string FDocXref, string ReasonCode)
        {
            try
            {
                OracleCommand cmd = GenerateCommand(UPDATE_REASON_CODE, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_batch_no",
                  BatchNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_f_doc_xref",
                  FDocXref, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_reason_code",
                  ReasonCode, OracleType.VarChar, ParameterDirection.Input, cmd);                
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() != "SUCCESSFUL")
                {
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.updateReasonCode: " + ex.Message);
            }
        }

        public void selectContestableFromPlanCode(ref CommonParameters CP)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_CONTESTABLE, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_plan_code",
                  CP.PlanCode, OracleType.VarChar, ParameterDirection.Input, cmd);                
                DBUtilities.CreateAndAddParameter("p_out_contestable",
                  OracleType.VarChar, ParameterDirection.Output, 5, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "SUCCESSFUL")
                {
                    //grab the values
                    CP.Contestable = cmd.Parameters["p_out_contestable"].Value.ToString();
                    Disconnect();                    
                }
                else if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() != "NODATA")
                {
                    throw new Exception("-266007829; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                       cmd.Parameters["p_out_error_message"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectContestableFromPlanCode: " + ex.Message);
            }
        }
        //END: AR 145620

        public string selectFrontOfficeBarcode(ref CommonParameters CP)
        {
            try
            {
                string retValue = "";
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_FRONT_OFFICE_BARCODE, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("P_IN_BFO_BARCODE_DOCUMENT_TYPE",
                  CP.DocTypeOrig, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("P_OUTPUT",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                using (OracleDataReader dataReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        retValue = "Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString();
                    }
                    else
                    {
                        if (dataReader.HasRows)
                        {
                            dataReader.Read(); //use first row
                            CP.AcordType = dataReader["ACORD_TYPE"].ToString();
                            CP.DocType = dataReader["DOCUMENT_TYPE"].ToString();
                            CP.FDocClassName = dataReader["DOC_CLASS"].ToString();
                            CP.FNP8_DOCCLASSNAME = dataReader["DOC_CLASS"].ToString();
                            CP.BusinessArea = dataReader["BUSINESS_AREA"].ToString();
                            CP.WorkType = dataReader["WORK_TYPE"].ToString();
                            CP.AWDStatus = dataReader["STATUS"].ToString();
                            
                            Disconnect();
                            retValue = "SUCCESS";
                        }
                        else
                        {
                            Disconnect();
                            retValue = "NODATA";
                        }
                    }
                }
                return retValue;
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectFrontOfficeBarcode: " + ex.Message);
            }
        }
        public string selectFrontOfficeProdCatXref(ref CommonParameters CP)
        {
            try
            {
                string retValue = "";
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_FRONT_OFFICE_PROD_CAT_XREF, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("P_IN_PRODUCT_CATEGORY",
                  CP.ProductCategory, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("P_OUTPUT",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                using (OracleDataReader dataReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        retValue = "Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString();
                    }
                    else
                    {
                        if (dataReader.HasRows)
                        {
                            dataReader.Read(); //use first row
                            CP.FDocClassName = dataReader["DOC_CLASS"].ToString();
                            CP.FNP8_DOCCLASSNAME = dataReader["DOC_CLASS"].ToString();

                            Disconnect();
                            retValue = "SUCCESS";
                        }
                        else
                        {
                            Disconnect();
                            retValue = "NODATA";
                        }
                    }
                }
                return retValue;
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectFrontOfficeProdCatXref: " + ex.Message);
            }
        }
        public int selectPrivacyMailing(ref CommonParameters CP)
        {
            try
            {

                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_PRIVACY_MAILING, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("P_IN_MASTER_ID",
                  CP.PrivMasterID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("P_OUTPUT",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                using (OracleDataReader dataReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                           cmd.Parameters["p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        if (dataReader.HasRows)
                        {
                            dataReader.Read(); //use first row
                            CP.FirstName = dataReader["FIRST_NAME"].ToString().Trim();
                            CP.MiddleName = dataReader["MIDDLE_NAME"].ToString().Trim();
                            CP.LastName = dataReader["LAST_NAME"].ToString().Trim();
                            CP.City = dataReader["CITY"].ToString().Trim();
                            CP.State = dataReader["STATE"].ToString().Trim();
                            CP.ZipCode = dataReader["ZIP"].ToString().Trim();
                            CP.Address1 = dataReader["ADDRESS1"].ToString().Trim();
                            CP.Address2 = dataReader["ADDRESS2"].ToString().Trim();

                            Disconnect();
                            return 0;
                        }
                        else
                        {
                            Disconnect();
                            return -2;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectPrivacyMailing: " + ex.Message);
            }
        }
        public string selectSiteID(ref CommonParameters CP)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_SITE_ID, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_admin_system_id",
                  CP.SystemNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_admin_company_code",
                  CP.CompanyNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_work_category",
                  CP.WorkCategory, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_site_id",
                  OracleType.VarChar, ParameterDirection.Output, 3, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "SUCCESSFUL")
                {
                    Disconnect();
                    //grab the values
                    return cmd.Parameters["p_out_site_id"].Value.ToString();

                }
                else if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() != "NODATA")
                {
                    throw new Exception("-266007829; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                       cmd.Parameters["p_out_error_message"].Value.ToString());
                }
                else
                {
                    return String.Empty;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectSiteID " + ex.Message);
            }
        }
        public void selectSortCodeValues(ref CommonParameters CP)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_SORTCODE_VALUES, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_sort_code",
                  CP.SortCode, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_line_of_business",
                  OracleType.VarChar, ParameterDirection.Output, 10, cmd);
                DBUtilities.CreateAndAddParameter("p_out_work_type",
                  OracleType.VarChar, ParameterDirection.Output, 20, cmd);
                DBUtilities.CreateAndAddParameter("p_out_bundle",
                  OracleType.VarChar, ParameterDirection.Output, 1, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "SUCCESSFUL")
                {
                    //grab the values
                    CP.LineOfBusiness = cmd.Parameters["p_out_line_of_business"].Value.ToString().ToUpper();
                    //update: if we have a worktype passed in we do not want to
                    //overwrite it.
                    if (CP.WorkType.Trim().Length == 0)
                    {
                        CP.WorkType = cmd.Parameters["p_out_work_type"].Value.ToString().ToUpper();
                        string bundleNeeded = cmd.Parameters["p_out_bundle"].Value.ToString().ToUpper();
                        switch (bundleNeeded)
                        {
                            case "Y":
                                CP.IsBundleNeeded = true;
                                break;
                            case "N":
                                CP.IsBundleNeeded = false;
                                break;
                        }
                    }
                    Disconnect();
                }
                else if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() != "NODATA")
                {
                    throw new Exception("-266007829; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                       cmd.Parameters["p_out_error_message"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectSortCodeValues: " + ex.Message);
            }
        }
        public void selectSortCodeFromPlanCode(ref CommonParameters CP)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_SORTCODE, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_plan_code",
                  CP.PlanCode, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_biceps_company_code",
                  CP.CompanyCodeBICPS, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_sort_code",
                  OracleType.VarChar, ParameterDirection.Output, 6, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "SUCCESSFUL")
                {
                    //grab the values
                    string sortCode = cmd.Parameters["p_out_sort_code"]
                       .Value.ToString();
                    Disconnect();
                    //if we find a sortcode, change the value otherwise leave what came from qsearch
                    if (sortCode.Trim().Length != 0)
                    {
                        CP.SortCode = sortCode;
                    }
                }
                else if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() != "NODATA")
                {
                    throw new Exception("-266007829; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                       cmd.Parameters["p_out_error_message"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("PolicyValidation.translatePlanCode: " + ex.Message);
            }
        }
        public Point selectDDUserFormSettings(string formName)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_DD_USER_FORMSETTINGS, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_user_id",
                  System.Environment.UserName.ToString(), OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_form_name",
                  formName, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_form_x",
                  OracleType.VarChar, ParameterDirection.Output, 6, cmd);
                DBUtilities.CreateAndAddParameter("p_out_form_y",
                  OracleType.VarChar, ParameterDirection.Output, 6, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "SUCCESSFUL")
                {
                    //grab the values
                    string formX = cmd.Parameters["p_out_form_x"]
                       .Value.ToString();
                    string formY = cmd.Parameters["p_out_form_y"]
                       .Value.ToString();
                    Disconnect();
                    return new Point(Convert.ToInt32(formX), Convert.ToInt32(formY));


                }
                else if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "NODATA")
                {
                    Disconnect();
                    //add entry
                    createDDUserFormSettings("I", formName, "0", "0");
                    return new Point(0, 0);
                }

                else
                {
                    Disconnect();
                    throw new Exception("-266007829; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                       cmd.Parameters["p_out_error_message"].Value.ToString());
                }
            }
            catch { return new Point(0, 0); }

        }
        public void createDDUserFormSettings(string updatOrInsert, string formName, string formX, string formY)
        {
            try
            {

                Connect();
                OracleCommand cmd = GenerateCommand(CREATE_DD_USER_FORMSETTINGS, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_action_indicator",
                  updatOrInsert, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_user_id",
                  System.Environment.UserName.ToString(), OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_form_name",
                  formName, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_form_x",
                  formX, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_form_y",
                  formY, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString()
                   .ToUpper() != "SUCCESSFUL")
                {
                    Disconnect();
                    throw new Exception("-266088529; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() +
                       "; Oracle Error: " + cmd.Parameters[
                       "p_out_error_message"].Value.ToString());
                }
                else
                {
                    Disconnect();
                }

            }
            catch (Exception e) { string s = e.Message; }
        }
        public void selectAdminSystemXrefValues(ref CommonParameters CP)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_ADMIN_SYSTEM_XREF, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                   CP.SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_admin_system_id",
                  CP.SystemNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_admin_company_code",
                  CP.CompanyNo, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_lob",
                  CP.LineOfBusiness, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_category",
                  CP.WorkCategory, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_business_area",
                  OracleType.VarChar, ParameterDirection.Output, 25, cmd);
                DBUtilities.CreateAndAddParameter("p_out_company_code",
                  OracleType.VarChar, ParameterDirection.Output, 25, cmd);
                DBUtilities.CreateAndAddParameter("p_out_gl_company_code",
                  OracleType.VarChar, ParameterDirection.Output, 25, cmd);
                DBUtilities.CreateAndAddParameter("p_out_system_id",
                  OracleType.VarChar, ParameterDirection.Output, 25, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "SUCCESSFUL")
                {
                    //grab the values
                    CP.BusinessArea = cmd.Parameters["p_out_business_area"]
                       .Value.ToString();
                    CP.CompanyCode = cmd.Parameters["p_out_company_code"]
                       .Value.ToString();
                    CP.GLCompanyCode = cmd.Parameters["p_out_gl_company_code"]
                       .Value.ToString();
                    CP.SystemID = cmd.Parameters["p_out_system_id"]
                       .Value.ToString();
                    Disconnect();
                }
                else if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() != "NODATA")
                {
                    throw new Exception("-266007829; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                       cmd.Parameters["p_out_error_message"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectAdminSystemXrefValues: " + ex.Message);
            }
        }
        public string selectDDMainDefinitionValue(string DefinitionType, string Name)
        {
            string returnValue = selectDDMainDefinitionValue(DefinitionType, Name, null);
            return returnValue;
        }
        public string selectDDMainDefinitionValue(string DefinitionType, string Name, string SiteID)
        {
            try
            {
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_DD_MAIN_DEFINITION_VALUE, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_definition_type",
                  DefinitionType, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_name",
                  Name, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_value",
                  OracleType.VarChar, ParameterDirection.Output, 100, cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                cmd.ExecuteNonQuery();

                if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() == "SUCCESSFUL")
                {
                    Disconnect();
                    //grab the value
                    return cmd.Parameters["p_out_value"].Value.ToString();
                }
                else if (cmd.Parameters["p_out_result"].Value.ToString().ToUpper() != "NODATA")
                {
                    throw new Exception("-266007829; Procedure Error: " +
                       cmd.Parameters["p_out_result"].Value.ToString() + "; Oracle Error: " +
                       cmd.Parameters["p_out_error_message"].Value.ToString());
                }
                else
                {
                    return String.Empty;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectDDMainDefinitionValue" + ex.Message);
            }
        }
        public DataSet selectDDMainDefinitionValues(string DefinitionType)
        {
            DataSet DataSetResults = selectDDMainDefinitionValues(DefinitionType, null);
            return DataSetResults;
        }
        public DataSet selectDDMainDefinitionValues(string DefinitionType, string SiteID)
        {
            try
            {
                DataSet DataSetResults = new DataSet();
                Connect();
                OracleCommand cmd = GenerateCommand(SELECT_DD_MAIN_DEFINITION_VALUES, CommandType.StoredProcedure);
                DBUtilities.CreateAndAddParameter("p_in_definition_type",
                  DefinitionType, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_in_site_id",
                  SiteID, OracleType.VarChar, ParameterDirection.Input, cmd);
                DBUtilities.CreateAndAddParameter("p_out_ref_cursor",
                   DBNull.Value, OracleType.Cursor, ParameterDirection.Output,
                   cmd);
                DBUtilities.CreateAndAddParameter("p_out_result",
                   OracleType.VarChar, ParameterDirection.Output, 255, cmd);
                DBUtilities.CreateAndAddParameter("p_out_error_message",
                   OracleType.VarChar, ParameterDirection.Output, 4000, cmd);

                using (OracleDataReader dataReader = cmd.ExecuteReader())
                {
                    if (cmd.Parameters["p_out_result"].Value.ToString()
                       .ToUpper() != "SUCCESSFUL")
                    {
                        throw new Exception("-266088529; Procedure Error: " +
                           cmd.Parameters["p_out_result"].Value.ToString() +
                           "; Oracle Error: " + cmd.Parameters[
                           "p_out_error_message"].Value.ToString());
                    }
                    else
                    {
                        if (dataReader.HasRows)
                        {
                            DataTable dt = new DataTable("Results");
                            DataSetResults.Tables.Add(dt);
                            DataSetResults.Load(dataReader, LoadOption.PreserveChanges, DataSetResults.Tables[0]);
                            Disconnect();
                            return DataSetResults;
                        }
                        else
                        {
                            Disconnect();
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.selectDDMainDefinitionValues: " + ex.Message);
            }
        }
        public void processDBParms(ref CommonParameters CP, ref OracleCommand cmd)
        {
            try
            {

                foreach (DataRow dr in CP._MVIFieldData.DD_MVI_FIELD_DEFINITION.Rows)
                {
                    //get the sp parameter name
                    string parameterName = dr["SP_PARAM_NAME"].ToString();
                    //check the parameter name... if there is none, do not add 
                    if (parameterName.Length != 0)
                    {
                        string parameterValue = dr["LOCAL_VALUE"].ToString();
                        if (parameterValue.Length != 0)
                        //add parameter to command
                        {
                            DBUtilities.CreateAndAddParameter(parameterName,
                              parameterValue, OracleType.VarChar, ParameterDirection.Input, cmd);

                        }
                    }

                }


            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.processDBParms: " + ex.Message);
            }
        }
        public void processRequestParms(ref CommonParameters CP, ref OracleCommand cmd, string columnName)
        {
            try
            {

                foreach (DataRow dr in CP._MVIFieldData.DD_MVI_FIELD_DEFINITION.Rows)
                {
                    //get the sp parameter name
                    string parameterName = dr[columnName].ToString();
                    //check the parameter name... if there is none, do not add 
                    if (parameterName.Length != 0)
                    {
                        string parameterValue = dr["LOCAL_VALUE"].ToString();
                        if (parameterValue.Length != 0)
                        //add parameter to command
                        {
                            DBUtilities.CreateAndAddParameter(parameterName,
                              parameterValue, OracleType.VarChar, ParameterDirection.Input, cmd);

                        }
                    }

                }


            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.processDBParms: " + ex.Message);
            }
        }
        private void createDDItemIndexes(ref CommonParameters CP)
        {
            try
            {
                //certified number is a default index
                if (CP.CertifiedNo.Length > 0)
                {
                    createDDItemIndex(CP.DDItemSeq, "Certified_Number", "Certified_Number", CP.CertifiedNo);
                }
                foreach (DataRow dr in CP._MVIFieldData.DD_MVI_FIELD_DEFINITION.Rows)
                {
                    //get the sp parameter name
                    string indexName = dr["FN_PROP_NAME"].ToString();
                    string indexNameP8 = dr["FNP8_PROP_NAME"].ToString();

                    //check the parameter name... if there is none, do not add 
                    if (indexName.Length != 0 || indexNameP8.Length != 0)
                    {
                        string indexValue = String.Empty;

                        //temp solution, need to find a better way to handle it
                        if (indexNameP8 == "RecordFiledInFolderPath")
                        {
                            indexValue = CP.FNP8_RECORDFILEDIN;
                        }
                        else
                        {
                            indexValue = dr["LOCAL_VALUE"].ToString();
                        }
                        //format dates
                        if (indexValue.Length != 0 && dr["FN_DATE"].ToString() == "T")
                        {
                            DateTime dtTemp;
                            if (DateTime.TryParse(indexValue, out dtTemp))
                            {
                                indexValue = dtTemp.ToString("MM/dd/yyyy");
                            }
                            else
                            {
                                indexValue = "";
                            }
                        }

                        if (indexValue.Length != 0)
                        //add index name value pair to table
                        {
                            createDDItemIndex(CP.DDItemSeq, indexName, indexNameP8, indexValue);

                        }
                    }

                }


            }
            catch (Exception ex)
            {
                throw new Exception("DataHandler.DataAccess.CreateDDItemIndexes: " + ex.Message);
            }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            crypto = null;
            _connection = null;
            _connectionString = null;
            _transaction = null;
            _applicationData = null;
            _xmlParser = null;
            _activeRegion = String.Empty;
            _DSN = String.Empty;
            _DBUser = String.Empty;
            _DBPass = String.Empty;
        }

        #endregion

    }

}
