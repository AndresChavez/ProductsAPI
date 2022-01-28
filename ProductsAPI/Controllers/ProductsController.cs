using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Text;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Configuration;
using System.ServiceModel;
using ProductsAPI.Helpers;
using ProductsAPI.Services;
using ProductsAPI.Models;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using ProductsAPI.Entities;

namespace ProductsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        //private IProductService _productService;
        //private IMapper _mapper;
        private readonly AppSettings _appSettings;
        private readonly ILogger<ProductService> _logger;

        public ProductsController(IOptions<AppSettings> appSettings, ILogger<ProductService> logger)
        {
            //_productService = productService;
            _appSettings = appSettings.Value;
            _logger = logger;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            EndpointAddress endpointAddress = new EndpointAddress(
                        new Uri("https://servicioswebdex.alicorp.com.pe/nd1/sap/bc/srt/rfc/sap/zsdrfc_skn_get_productos/300/zsdrfc_skn_get_productos/zsdrfc_skn_get_productos"));
            WSHttpBinding myBinding = new WSHttpBinding();
            myBinding.MaxReceivedMessageSize = 65536 * 20;
            myBinding.Security.Mode = SecurityMode.Transport;
            myBinding.Security.Transport.ClientCredentialType =
                HttpClientCredentialType.Basic;
          

            ZSDRFC_SKN_GET_PRODUCTOSRequest request = new ZSDRFC_SKN_GET_PRODUCTOSRequest();
            request.ZSDRFC_SKN_GET_PRODUCTOS = new ZSDRFC_SKN_GET_PRODUCTOS();
            request.ZSDRFC_SKN_GET_PRODUCTOS.ET_PROD_GENERAL = new ET_PROD_GENERAL[] { };
            request.ZSDRFC_SKN_GET_PRODUCTOS.ET_RETURN = new ET_RETURN[] { };
            request.ZSDRFC_SKN_GET_PRODUCTOS.IT_FILTROS = new IT_FILTROS[] { };



            var appResponse = string.Empty;
            ZSDRFC_SKN_GET_PRODUCTOSResponse1 httpResponse;

            ZSDRFC_SKN_GET_PRODUCTOS_Client httpClient = new ZSDRFC_SKN_GET_PRODUCTOS_Client(myBinding, endpointAddress);
            httpClient.ClientCredentials.UserName.UserName = "nrodriguezv";
            httpClient.ClientCredentials.UserName.Password = "mikaela2013";
            
            Console.WriteLine(request.ToString());

            httpResponse = await httpClient.ZSDRFC_SKN_GET_PRODUCTOSAsync(request);


            List<Product> productsArray = new List<Product>();
            productsArray = ConvertXmlToJson(httpResponse);
            var productsJson = JsonConvert.SerializeObject(productsArray);
            return Ok(productsJson);

            //using (SoapClient client = new SoapClient(
            //        "https://servicioswebdex.alicorp.com.pe/nd1/sap/bc/srt/rfc/sap/zsdrfc_skn_get_productos/300/zsdrfc_skn_get_productos/zsdrfc_skn_get_productos",
            //        "urn:sap-com:document:sap:rfc:functions"))
            //{
            //    response = client.PostAsync<string>("ZSDRFC_SKN_GET_PRODUCTOS", new ZSDRFC_SKN_GET_PRODUCTOS[1]).Result;
            //}

            //ZSDRFC_SKN_GET_PRODUCTOSClient client = new ZSDRFC_SKN_GET_PRODUCTOSClient(myBinding, endpointAddress);
            //client.ClientCredentials.UserName.UserName = "nrodriguezv";
            //client.ClientCredentials.UserName.Password = "mikaela2013";
            //ZSDRFC_SKN_GET_PRODUCTOS1 bodyRequest = new ZSDRFC_SKN_GET_PRODUCTOS1 { ET_PROD_GENERAL = new ZSDT_MAEMAT00[1], ET_RETURN = new BAPIRETURN[1], IT_FILTROS = new RSSELECT[1] };
            //ZSDRFC_SKN_GET_PRODUCTOS body = bodyRequest as ZSDRFC_SKN_GET_PRODUCTOS;
            //ZSDRFC_SKN_GET_PRODUCTOSRequest request = new ZSDRFC_SKN_GET_PRODUCTOSRequest(body);
            //var bodyResponse = client.ZSDRFC_SKN_GET_PRODUCTOSAsync(body);
            //return Ok(bodyResponse);

        }

        private List<Product> ConvertXmlToJson(ZSDRFC_SKN_GET_PRODUCTOSResponse1 xml)
        {
            List<Product> arrayProduct = new List<Product>();
            ZSDRFC_SKN_GET_PRODUCTOSResponse productsXml = new ZSDRFC_SKN_GET_PRODUCTOSResponse();
            productsXml.ET_PROD_GENERAL = xml.ZSDRFC_SKN_GET_PRODUCTOSResponse.ET_PROD_GENERAL;

            foreach(ET_PROD_GENERAL element in productsXml.ET_PROD_GENERAL)
            {
                Product product = new Product();
                product.codMaterial = element.ZSD_CMATER;
                product.orgVentas = element.ZSD_CORVTA;
                product.canDistribucion = element.ZSD_CCADIS;
                product.sector = element.ZSD_CSECTO;
                product.desCorta = element.ZSD_DCORTA;
                product.desLarga = element.ZSD_DLARGA;
                product.pesoNeto = element.ZSD_PNETO;
                product.pesoBruto = element.ZSD_PBRUTO;
                product.codUM = element.ZSD_CUNMPE;
                product.codUMB = element.ZSD_CUNMBA;
                product.codUMV = element.ZSD_CUNMVT;
                product.facUMBToUMV = element.ZSD_NFUVTA;
                product.codTipoMaterial = element.ZSD_CTPMAT;
                product.codJerarquia = element.ZSD_CJERAR;
                product.codGrupoMaterial = element.ZSD_CGRMAT;
                product.codFamilia = element.ZSD_CFAMMT;
                product.codMarca = element.ZSD_CMARCA;
                product.codCategoria = element.ZSD_CCATEG;
                product.codMaterialReemplazante = element.ZSD_CMRZTE;
                product.codRegimen = element.ZSD_CREGIM;
                product.cantMinima = element.ZSD_QMINVT;
                arrayProduct.Add(product);
            }

            return arrayProduct;
        }

        [HttpGet("{sku}")]
        public async Task<IActionResult> GetById(string sku)
        {
            EndpointAddress endpointAddress = new EndpointAddress(
                                    new Uri("https://servicioswebdex.alicorp.com.pe/nd1/sap/bc/srt/rfc/sap/zsdrfc_skn_get_productos/300/zsdrfc_skn_get_productos/zsdrfc_skn_get_productos"));
            WSHttpBinding myBinding = new WSHttpBinding();
            myBinding.MaxReceivedMessageSize = 65536 * 20;
            myBinding.Security.Mode = SecurityMode.Transport;
            myBinding.Security.Transport.ClientCredentialType =
                HttpClientCredentialType.Basic;


            ZSDRFC_SKN_GET_PRODUCTOSRequest request = new ZSDRFC_SKN_GET_PRODUCTOSRequest();
            request.ZSDRFC_SKN_GET_PRODUCTOS = new ZSDRFC_SKN_GET_PRODUCTOS();
            request.ZSDRFC_SKN_GET_PRODUCTOS.ET_PROD_GENERAL = new ET_PROD_GENERAL[] { };
            request.ZSDRFC_SKN_GET_PRODUCTOS.ET_RETURN = new ET_RETURN[] { };
            request.ZSDRFC_SKN_GET_PRODUCTOS.IT_FILTROS = new IT_FILTROS[] { };



            var appResponse = string.Empty;
            ZSDRFC_SKN_GET_PRODUCTOSResponse1 httpResponse;

            ZSDRFC_SKN_GET_PRODUCTOS_Client httpClient = new ZSDRFC_SKN_GET_PRODUCTOS_Client(myBinding, endpointAddress);
            httpClient.ClientCredentials.UserName.UserName = "nrodriguezv";
            httpClient.ClientCredentials.UserName.Password = "mikaela2013";

            Console.WriteLine(request.ToString());

            httpResponse = await httpClient.ZSDRFC_SKN_GET_PRODUCTOSAsync(request);


            List<Product> productsArray = new List<Product>();
            Product product = new Product();
            productsArray = ConvertXmlToJson(httpResponse);
            product = productsArray.Find(x => x.codMaterial == sku );
;
            if (product != null)
            {
                var productJson = JsonConvert.SerializeObject(product);

                return Ok(productJson);
            }
            else
            {
                return NotFound();
            }

        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetByIdStibo(string id)
        //{
        //    var endpoint = "https://alicorp-qa-step.mdm.stibosystems.com/restapiv2/products/" + id + "?keyId=SKU&context=Context2&workspace=Main";
        //    var credentials = new NetworkCredential("RESTAPI", "Alicorp2021#");
        //    var handler = new HttpClientHandler { Credentials = credentials };
        //    var appResponse = string.Empty;

        //    using (var httpClient = new HttpClient(handler))
        //    {
        //        //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", "RESTAPI", "Alicorp2021#"))));
        //        //var authString = Convert.ToBase64String(Encoding.UTF8.GetBytes("RESTAPI:Alicorp2021#"));
        //        //var authValue = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authString);

        //        using (var httpResponse = await httpClient.GetAsync(endpoint))
        //        {
        //            appResponse = await httpResponse.Content.ReadAsStringAsync();
        //        }
        //    }

        //    var materialStibo = new MaterialStiboModel();
        //    return Ok(appResponse);

        //}
    }

   
}
