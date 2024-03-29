/* 
 * WebAPI
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: data
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using ARXivarNEXT.Client.Client;

namespace ARXivarNEXT.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOutlook365Api : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves the outlook message content based on the specified id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ARXivarNEXT.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The message id</param>
        /// <returns>Object</returns>
        Object Outlook365GetMessage (string id);

        /// <summary>
        /// Retrieves the outlook message content based on the specified id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ARXivarNEXT.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The message id</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> Outlook365GetMessageWithHttpInfo (string id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves the outlook message content based on the specified id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ARXivarNEXT.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The message id</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> Outlook365GetMessageAsync (string id);

        /// <summary>
        /// Retrieves the outlook message content based on the specified id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ARXivarNEXT.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The message id</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> Outlook365GetMessageAsyncWithHttpInfo (string id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class Outlook365Api : IOutlook365Api
    {
        private ARXivarNEXT.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Outlook365Api"/> class.
        /// </summary>
        /// <returns></returns>
        public Outlook365Api(String basePath)
        {
            this.Configuration = new ARXivarNEXT.Client.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ARXivarNEXT.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Outlook365Api"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public Outlook365Api(ARXivarNEXT.Client.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = ARXivarNEXT.Client.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = ARXivarNEXT.Client.Client.Configuration.DefaultExceptionFactory;
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
        public ARXivarNEXT.Client.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ARXivarNEXT.Client.Client.ExceptionFactory ExceptionFactory
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
        /// Retrieves the outlook message content based on the specified id 
        /// </summary>
        /// <exception cref="ARXivarNEXT.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The message id</param>
        /// <returns>Object</returns>
        public Object Outlook365GetMessage (string id)
        {
             ApiResponse<Object> localVarResponse = Outlook365GetMessageWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the outlook message content based on the specified id 
        /// </summary>
        /// <exception cref="ARXivarNEXT.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The message id</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > Outlook365GetMessageWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling Outlook365Api->Outlook365GetMessage");

            var localVarPath = "./api/outlook365/message/{id}";
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
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Outlook365GetMessage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Retrieves the outlook message content based on the specified id 
        /// </summary>
        /// <exception cref="ARXivarNEXT.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The message id</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> Outlook365GetMessageAsync (string id)
        {
             ApiResponse<Object> localVarResponse = await Outlook365GetMessageAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves the outlook message content based on the specified id 
        /// </summary>
        /// <exception cref="ARXivarNEXT.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The message id</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> Outlook365GetMessageAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling Outlook365Api->Outlook365GetMessage");

            var localVarPath = "./api/outlook365/message/{id}";
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
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Outlook365GetMessage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

    }
}
