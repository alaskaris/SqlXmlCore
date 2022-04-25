namespace SqlXmlCore.Legacy
{
    public interface ISQLXMLBulkLoad4: ISQLXMLBulkLoad
    {
        /// <summary>
        /// Specifies if triggers defined on target tables should fire during the Bulk Load operation.
        /// When set to TRUE, triggers will fire as per normal during insert operations.
        /// NOTE: if ID Propagation is being done, then this option does not apply and triggers will be left on. 
        /// This occurs when KeepIdentity=False and there is a relationship defined where the parent is an identity field 
        /// and the value is given to the child as it is generated.
        /// 
        /// The default is FALSE.
        /// </summary>
        bool FireTriggers
        {
            get;
            set;
        }
    }
}
