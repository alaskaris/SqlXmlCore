# SqlXmlCore : A port of SQLXML 4.0 COM library to dotnet core.

SQLXML 4.0 implements many features which range between bulk loading of XML files to querying using XML.
This project will primarily focus on implementing the bulk load feature, so it can be used as a drop-in replacement of the corresponding COM library. When used in .NET, the COM is called through an interop.

Check the [example call](Example-call) as well as the [interfaces](Classes-and-Interfaces) as defined in the SQXML Interop.
