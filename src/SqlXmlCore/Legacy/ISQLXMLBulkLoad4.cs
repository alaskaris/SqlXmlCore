namespace SqlXmlCore.Legacy
{
    public interface ISQLXMLBulkLoad4: ISQLXMLBulkLoad
    {
        bool FireTriggers
        {
            get;
            set;
        }
    }
}
