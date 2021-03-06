/* 
 * NamSor API v2
 *
 * NamSor API v2 : enpoints to process personal names (gender, cultural origin or ethnicity) in all alphabets or languages. Use GET methods for small tests, but prefer POST methods for higher throughput (batch processing of up to 100 names at a time). Need something you can't find here? We have many more features coming soon. Let us know, we'll do our best to add it! 
 *
 * OpenAPI spec version: 2.0.11
 * Contact: contact@namsor.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Org.OpenAPITools.com.namsor.sdk2.api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGeneralApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Infer the likely type of a proper noun (personal name, brand name, place name etc.)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="properNoun"></param>
        /// <returns>ProperNounCategorizedOut</returns>
        ProperNounCategorizedOut NameType (string properNoun);

        /// <summary>
        /// Infer the likely type of a proper noun (personal name, brand name, place name etc.)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="properNoun"></param>
        /// <returns>ApiResponse of ProperNounCategorizedOut</returns>
        ApiResponse<ProperNounCategorizedOut> NameTypeWithHttpInfo (string properNoun);
        /// <summary>
        /// Infer the likely type of a proper noun (personal name, brand name, place name etc.)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="properNoun"></param>
        /// <param name="countryIso2"></param>
        /// <returns>ProperNounCategorizedOut</returns>
        ProperNounCategorizedOut NameType1 (string properNoun, string countryIso2);

        /// <summary>
        /// Infer the likely type of a proper noun (personal name, brand name, place name etc.)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="properNoun"></param>
        /// <param name="countryIso2"></param>
        /// <returns>ApiResponse of ProperNounCategorizedOut</returns>
        ApiResponse<ProperNounCategorizedOut> NameType1WithHttpInfo (string properNoun, string countryIso2);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Infer the likely type of a proper noun (personal name, brand name, place name etc.)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="properNoun"></param>
        /// <returns>Task of ProperNounCategorizedOut</returns>
        System.Threading.Tasks.Task<ProperNounCategorizedOut> NameTypeAsync (string properNoun);

        /// <summary>
        /// Infer the likely type of a proper noun (personal name, brand name, place name etc.)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="properNoun"></param>
        /// <returns>Task of ApiResponse (ProperNounCategorizedOut)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProperNounCategorizedOut>> NameTypeAsyncWithHttpInfo (string properNoun);
        /// <summary>
        /// Infer the likely type of a proper noun (personal name, brand name, place name etc.)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="properNoun"></param>
        /// <param name="countryIso2"></param>
        /// <returns>Task of ProperNounCategorizedOut</returns>
        System.Threading.Tasks.Task<ProperNounCategorizedOut> NameType1Async (string properNoun, string countryIso2);

        /// <summary>
        /// Infer the likely type of a proper noun (personal name, brand name, place name etc.)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="properNoun"></param>
        /// <param name="countryIso2"></param>
        /// <returns>Task of ApiResponse (ProperNounCategorizedOut)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProperNounCategorizedOut>> NameType1AsyncWithHttpInfo (string properNoun, string countryIso2);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GeneralApi : IGeneralApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GeneralApi(String basePath)
        {
            this.Configuration = new Org.OpenAPITools.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralApi"/> class
        /// </summary>
        /// <returns></returns>
        public GeneralApi()
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.Default;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GeneralApi(Org.OpenAPITools.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Org.OpenAPITools.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Infer the likely type of a proper noun (personal name, brand name, place name etc.) 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="properNoun"></param>
        /// <returns>ProperNounCategorizedOut</returns>
        public ProperNounCategorizedOut NameType (string properNoun)
        {
             ApiResponse<ProperNounCategorizedOut> localVarResponse = NameTypeWithHttpInfo(properNoun);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Infer the likely type of a proper noun (personal name, brand name, place name etc.) 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="properNoun"></param>
        /// <returns>ApiResponse of ProperNounCategorizedOut</returns>
        public ApiResponse< ProperNounCategorizedOut > NameTypeWithHttpInfo (string properNoun)
        {
            // verify the required parameter 'properNoun' is set
            if (properNoun == null)
                throw new ApiException(400, "Missing required parameter 'properNoun' when calling GeneralApi->NameType");

            var localVarPath = "/api2/json/nameType/{properNoun}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (properNoun != null) localVarPathParams.Add("properNoun", this.Configuration.ApiClient.ParameterToString(properNoun)); // path parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarHeaderParams["X-API-KEY"] = this.Configuration.GetApiKeyWithPrefix("X-API-KEY");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NameType", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProperNounCategorizedOut>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProperNounCategorizedOut) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProperNounCategorizedOut)));
        }

        /// <summary>
        /// Infer the likely type of a proper noun (personal name, brand name, place name etc.) 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="properNoun"></param>
        /// <returns>Task of ProperNounCategorizedOut</returns>
        public async System.Threading.Tasks.Task<ProperNounCategorizedOut> NameTypeAsync (string properNoun)
        {
             ApiResponse<ProperNounCategorizedOut> localVarResponse = await NameTypeAsyncWithHttpInfo(properNoun);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Infer the likely type of a proper noun (personal name, brand name, place name etc.) 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="properNoun"></param>
        /// <returns>Task of ApiResponse (ProperNounCategorizedOut)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProperNounCategorizedOut>> NameTypeAsyncWithHttpInfo (string properNoun)
        {
            // verify the required parameter 'properNoun' is set
            if (properNoun == null)
                throw new ApiException(400, "Missing required parameter 'properNoun' when calling GeneralApi->NameType");

            var localVarPath = "/api2/json/nameType/{properNoun}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (properNoun != null) localVarPathParams.Add("properNoun", this.Configuration.ApiClient.ParameterToString(properNoun)); // path parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarHeaderParams["X-API-KEY"] = this.Configuration.GetApiKeyWithPrefix("X-API-KEY");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NameType", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProperNounCategorizedOut>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProperNounCategorizedOut) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProperNounCategorizedOut)));
        }

        /// <summary>
        /// Infer the likely type of a proper noun (personal name, brand name, place name etc.) 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="properNoun"></param>
        /// <param name="countryIso2"></param>
        /// <returns>ProperNounCategorizedOut</returns>
        public ProperNounCategorizedOut NameType1 (string properNoun, string countryIso2)
        {
             ApiResponse<ProperNounCategorizedOut> localVarResponse = NameType1WithHttpInfo(properNoun, countryIso2);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Infer the likely type of a proper noun (personal name, brand name, place name etc.) 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="properNoun"></param>
        /// <param name="countryIso2"></param>
        /// <returns>ApiResponse of ProperNounCategorizedOut</returns>
        public ApiResponse< ProperNounCategorizedOut > NameType1WithHttpInfo (string properNoun, string countryIso2)
        {
            // verify the required parameter 'properNoun' is set
            if (properNoun == null)
                throw new ApiException(400, "Missing required parameter 'properNoun' when calling GeneralApi->NameType1");
            // verify the required parameter 'countryIso2' is set
            if (countryIso2 == null)
                throw new ApiException(400, "Missing required parameter 'countryIso2' when calling GeneralApi->NameType1");

            var localVarPath = "/api2/json/nameType/{properNoun}/{countryIso2}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (properNoun != null) localVarPathParams.Add("properNoun", this.Configuration.ApiClient.ParameterToString(properNoun)); // path parameter
            if (countryIso2 != null) localVarPathParams.Add("countryIso2", this.Configuration.ApiClient.ParameterToString(countryIso2)); // path parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarHeaderParams["X-API-KEY"] = this.Configuration.GetApiKeyWithPrefix("X-API-KEY");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NameType1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProperNounCategorizedOut>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProperNounCategorizedOut) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProperNounCategorizedOut)));
        }

        /// <summary>
        /// Infer the likely type of a proper noun (personal name, brand name, place name etc.) 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="properNoun"></param>
        /// <param name="countryIso2"></param>
        /// <returns>Task of ProperNounCategorizedOut</returns>
        public async System.Threading.Tasks.Task<ProperNounCategorizedOut> NameType1Async (string properNoun, string countryIso2)
        {
             ApiResponse<ProperNounCategorizedOut> localVarResponse = await NameType1AsyncWithHttpInfo(properNoun, countryIso2);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Infer the likely type of a proper noun (personal name, brand name, place name etc.) 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="properNoun"></param>
        /// <param name="countryIso2"></param>
        /// <returns>Task of ApiResponse (ProperNounCategorizedOut)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProperNounCategorizedOut>> NameType1AsyncWithHttpInfo (string properNoun, string countryIso2)
        {
            // verify the required parameter 'properNoun' is set
            if (properNoun == null)
                throw new ApiException(400, "Missing required parameter 'properNoun' when calling GeneralApi->NameType1");
            // verify the required parameter 'countryIso2' is set
            if (countryIso2 == null)
                throw new ApiException(400, "Missing required parameter 'countryIso2' when calling GeneralApi->NameType1");

            var localVarPath = "/api2/json/nameType/{properNoun}/{countryIso2}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (properNoun != null) localVarPathParams.Add("properNoun", this.Configuration.ApiClient.ParameterToString(properNoun)); // path parameter
            if (countryIso2 != null) localVarPathParams.Add("countryIso2", this.Configuration.ApiClient.ParameterToString(countryIso2)); // path parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarHeaderParams["X-API-KEY"] = this.Configuration.GetApiKeyWithPrefix("X-API-KEY");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NameType1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProperNounCategorizedOut>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProperNounCategorizedOut) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProperNounCategorizedOut)));
        }

    }
}
