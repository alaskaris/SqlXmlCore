namespace SqlXmlCore.Legacy
{
    public interface ISQLXMLBulkLoad
    {
        string ConnectionString
        {
            get;
            set;
        }

        object ConnectionCommand
        {
            get;
            set;
        }

        bool KeepNulls
        {
            get;
            set;
        }

        bool KeepIdentity
        {
            get;
            set;
        }

        bool CheckConstraints
        {
            get;
            set;
        }

        bool ForceTableLock
        {
            get;
            set;
        }

        bool XMLFragment
        {
            get;
            set;
        }

        bool Transaction
        {
            get;
            set;
        }

        bool IgnoreDuplicateKeys
        {
            get;
            set;
        }

        bool BulkLoad
        {
            get;
            set;
        }

        bool SchemaGen
        {
            get;
            set;
        }

        bool SGDropTables
        {
            get;
            set;
        }

        bool SGUseID
        {
            get;
            set;
        }

        string ErrorLogFile
        {
            get;
            set;
        }

        string TempFilePath
        {
            get;
            set;
        }

        void Execute(string bstrSchemaFile, object vDataFile);
    }
}