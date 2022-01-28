using System.Runtime.Serialization;

namespace ProductsAPI.Models
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:sap-com:document:sap:rfc:functions")]
    public class ZSDRFC_SKN_GET_PRODUCTOSResponse
    {
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn:sap-com:document:sap:rfc:functions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        //[DataMember(Order = 0)]
        public ET_PROD_GENERAL[] ET_PROD_GENERAL { get; set; }


        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn:sap-com:document:sap:rfc:functions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        //[DataMember(Order = 1)]
        public ET_RETURN[] ET_RETURN { get; set; }


        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn:sap-com:document:sap:rfc:functions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        //[DataMember(Order = 2)]
        public IT_FILTROS[] IT_FILTROS { get; set; }

    }
}
