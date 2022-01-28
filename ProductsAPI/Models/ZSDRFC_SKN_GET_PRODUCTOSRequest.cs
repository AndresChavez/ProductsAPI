namespace ProductsAPI.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public class ZSDRFC_SKN_GET_PRODUCTOSRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:sap-com:document:sap:rfc:functions", Order = 0)]
        public ZSDRFC_SKN_GET_PRODUCTOS ZSDRFC_SKN_GET_PRODUCTOS;

        public ZSDRFC_SKN_GET_PRODUCTOSRequest()
        {
        
        }

        public ZSDRFC_SKN_GET_PRODUCTOSRequest(ZSDRFC_SKN_GET_PRODUCTOS ZSDRFC_SKN_GET_PRODUCTOS)
        {
            this.ZSDRFC_SKN_GET_PRODUCTOS = ZSDRFC_SKN_GET_PRODUCTOS;
        }
    }
}
