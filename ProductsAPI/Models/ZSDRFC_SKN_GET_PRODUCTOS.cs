using System.Runtime.Serialization;

namespace ProductsAPI.Models
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:sap-com:document:sap:rfc:functions")]
    //[DataContract(Namespace = "urn:sap-com:document:sap:rfc:functions")]
    public partial class ZSDRFC_SKN_GET_PRODUCTOS
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


        //[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:sap-com:document:sap:rfc:functions", Order = 0)]
        //public ET_PROD_GENERAL[] ET_PROD_GENERAL
        //{
        //    get
        //    {
        //        return this.mET_PROD_GENERAL;
        //    }
        //    set
        //    {
        //        this.mET_PROD_GENERAL = value;
        //    }
        //}

        //[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:sap-com:document:sap:rfc:functions", Order = 1)]
        //public ET_RETURN[] ET_RETURN
        //{
        //    get
        //    {
        //        return this.mET_RETURN;
        //    }
        //    set
        //    {
        //        this.mET_RETURN = value;
        //    }
        //}

        //[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:sap-com:document:sap:rfc:functions", Order = 2)]
        //public IT_FILTROS[] IT_FILTROS
        //{
        //    get
        //    {
        //        return this.mIT_FILTROS;
        //    }
        //    set
        //    {
        //        this.mIT_FILTROS = value;
        //    }
        //}


    }
}
