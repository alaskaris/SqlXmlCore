namespace SqlXmlCore.Legacy
{
    public class SQLXMLBulkLoadClass : ISQLXMLBulkLoad4, SQLXMLBulkLoad, ISQLXMLBulkLoad
    {
        public bool FireTriggers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object ConnectionCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool KeepNulls { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool KeepIdentity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool CheckConstraints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ForceTableLock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool XMLFragment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Transaction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IgnoreDuplicateKeys { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool BulkLoad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool SchemaGen { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool SGDropTables { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool SGUseID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ErrorLogFile { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TempFilePath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Execute(string bstrSchemaFile, object vDataFile)
        {
            throw new NotImplementedException();
        }
    }
}
