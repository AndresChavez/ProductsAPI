using ProductsAPI.Models;
using System.Runtime.Serialization;

namespace ProductsAPI.Models
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "urn:sap-com:document:sap:rfc:functions", ConfigurationName = "ZSDRFC_SKN_GET_PRODUCTOS")]
    public interface IZSDRFC_SKN_GET_PRODUCTOS
    {
        [System.ServiceModel.OperationContractAttribute(Action = "urn:sap-com:document:sap:rfc:functions:ZSDRFC_SKN_GET_PRODUCTOS:ZSDRFC_SKN_GET_PRODUCTOSRequest", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.Threading.Tasks.Task<ZSDRFC_SKN_GET_PRODUCTOSResponse1> ZSDRFC_SKN_GET_PRODUCTOSAsync(ZSDRFC_SKN_GET_PRODUCTOSRequest request);
    }
}
