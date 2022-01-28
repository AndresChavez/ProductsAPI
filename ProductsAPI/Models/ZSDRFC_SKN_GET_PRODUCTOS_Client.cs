using System;
using System.ServiceModel;

namespace ProductsAPI.Models
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IZSDRFC_SKN_GET_PRODUCTOS_Channel : IZSDRFC_SKN_GET_PRODUCTOS, IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class ZSDRFC_SKN_GET_PRODUCTOS_Client : System.ServiceModel.ClientBase<IZSDRFC_SKN_GET_PRODUCTOS>, IZSDRFC_SKN_GET_PRODUCTOS
    {
        public ZSDRFC_SKN_GET_PRODUCTOS_Client()
        {
        }

        public ZSDRFC_SKN_GET_PRODUCTOS_Client(string endpointConfigurationName)
            :
                base(endpointConfigurationName)
        {
        }

        public ZSDRFC_SKN_GET_PRODUCTOS_Client(string endpointConfigurationName, string remoteAddress)
            :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public ZSDRFC_SKN_GET_PRODUCTOS_Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress)
            :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public ZSDRFC_SKN_GET_PRODUCTOS_Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress)
            :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ZSDRFC_SKN_GET_PRODUCTOSResponse1> IZSDRFC_SKN_GET_PRODUCTOS.ZSDRFC_SKN_GET_PRODUCTOSAsync(ZSDRFC_SKN_GET_PRODUCTOSRequest request)
        {
            return base.Channel.ZSDRFC_SKN_GET_PRODUCTOSAsync(request);
        }

        public System.Threading.Tasks.Task<ZSDRFC_SKN_GET_PRODUCTOSResponse1> ZSDRFC_SKN_GET_PRODUCTOSAsync(ZSDRFC_SKN_GET_PRODUCTOSRequest ZSDRFC_SKN_GET_PRODUCTOS)
        {
            ZSDRFC_SKN_GET_PRODUCTOSRequest inValue = new ZSDRFC_SKN_GET_PRODUCTOSRequest();
            inValue = ZSDRFC_SKN_GET_PRODUCTOS;
            return ((IZSDRFC_SKN_GET_PRODUCTOS)(this)).ZSDRFC_SKN_GET_PRODUCTOSAsync(inValue);
        }

        //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        //public System.Threading.Tasks.Task<ZSDRFC_SKN_GET_PRODUCTOSResponse> ZSDRFC_SKN_GET_PRODUCTOSAsync(ZSDRFC_SKN_GET_PRODUCTOS request)
        //{
        //    Console.WriteLine(request.ToString());
        //    return base.Channel.ZSDRFC_SKN_GET_PRODUCTOSAsync(request);
        //}

        //public System.Threading.Tasks.Task<ZSDRFC_SKN_GET_PRODUCTOSResponse> ZSDRFC_SKN_GET_PRODUCTOSAsync(IZSDRFC_SKN_GET_PRODUCTOS ZSDRFC_SKN_GET_PRODUCTOS)
        //{
        //    ZSDRFC_SKN_GET_PRODUCTOSRequest inValue = new ZSDRFC_SKN_GET_PRODUCTOSRequest();
        //    //inValue.ZSDRFC_SKN_GET_PRODUCTOS = ZSDRFC_SKN_GET_PRODUCTOS;
        //    return ((IZSDRFC_SKN_GET_PRODUCTOS)(this)).ZSDRFC_SKN_GET_PRODUCTOSAsync(inValue);
        //}

        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }

        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }

    }
}
