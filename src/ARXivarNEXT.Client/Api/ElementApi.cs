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
using ARXivarNEXT.Client.Model;

namespace ARXivarNEXT.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IElementApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This call returns all possible single element that can be used for the specific element type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ARXivarNEXT.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="elementType">Kind of elements that the call should return</param>
        /// <returns>List&lt;KeyValueElementDto&gt;</returns>
        List<KeyValueElementDto> ElementGetByElementType (int? elementType);

        /// <summary>
        /// This call returns all possible single element that can be used for the specific element type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ARXivarNEXT.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="elementType">Kind of elements that the call should return</param>
        /// <returns>ApiResponse of List&lt;KeyValueElementDto&gt;</returns>
        ApiResponse<List<KeyValueElementDto>> ElementGetByElementTypeWithHttpInfo (int? elementType);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This call returns all possible single element that can be used for the specific element type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ARXivarNEXT.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="elementType">Kind of elements that the call should return</param>
        /// <returns>Task of List&lt;KeyValueElementDto&gt;</returns>
        System.Threading.Tasks.Task<List<KeyValueElementDto>> ElementGetByElementTypeAsync (int? elementType);

        /// <summary>
        /// This call returns all possible single element that can be used for the specific element type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ARXivarNEXT.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="elementType">Kind of elements that the call should return</param>
        /// <returns>Task of ApiResponse (List&lt;KeyValueElementDto&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<KeyValueElementDto>>> ElementGetByElementTypeAsyncWithHttpInfo (int? elementType);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ElementApi : IElementApi
    {
        private ARXivarNEXT.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ElementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ElementApi(String basePath)
        {
            this.Configuration = new ARXivarNEXT.Client.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ARXivarNEXT.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ElementApi(ARXivarNEXT.Client.Client.Configuration configuration = null)
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
        /// This call returns all possible single element that can be used for the specific element type 
        /// </summary>
        /// <exception cref="ARXivarNEXT.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="elementType">Kind of elements that the call should return</param>
        /// <returns>List&lt;KeyValueElementDto&gt;</returns>
        public List<KeyValueElementDto> ElementGetByElementType (int? elementType)
        {
             ApiResponse<List<KeyValueElementDto>> localVarResponse = ElementGetByElementTypeWithHttpInfo(elementType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns all possible single element that can be used for the specific element type 
        /// </summary>
        /// <exception cref="ARXivarNEXT.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="elementType">Kind of elements that the call should return</param>
        /// <returns>ApiResponse of List&lt;KeyValueElementDto&gt;</returns>
        public ApiResponse< List<KeyValueElementDto> > ElementGetByElementTypeWithHttpInfo (int? elementType)
        {
            // verify the required parameter 'elementType' is set
            if (elementType == null)
                throw new ApiException(400, "Missing required parameter 'elementType' when calling ElementApi->ElementGetByElementType");

            var localVarPath = "./api/LayoutListElements/{elementType}";
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

            if (elementType != null) localVarPathParams.Add("elementType", this.Configuration.ApiClient.ParameterToString(elementType)); // path parameter

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
                Exception exception = ExceptionFactory("ElementGetByElementType", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<KeyValueElementDto>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (List<KeyValueElementDto>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<KeyValueElementDto>)));
        }

        /// <summary>
        /// This call returns all possible single element that can be used for the specific element type 
        /// </summary>
        /// <exception cref="ARXivarNEXT.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="elementType">Kind of elements that the call should return</param>
        /// <returns>Task of List&lt;KeyValueElementDto&gt;</returns>
        public async System.Threading.Tasks.Task<List<KeyValueElementDto>> ElementGetByElementTypeAsync (int? elementType)
        {
             ApiResponse<List<KeyValueElementDto>> localVarResponse = await ElementGetByElementTypeAsyncWithHttpInfo(elementType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns all possible single element that can be used for the specific element type 
        /// </summary>
        /// <exception cref="ARXivarNEXT.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="elementType">Kind of elements that the call should return</param>
        /// <returns>Task of ApiResponse (List&lt;KeyValueElementDto&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<KeyValueElementDto>>> ElementGetByElementTypeAsyncWithHttpInfo (int? elementType)
        {
            // verify the required parameter 'elementType' is set
            if (elementType == null)
                throw new ApiException(400, "Missing required parameter 'elementType' when calling ElementApi->ElementGetByElementType");

            var localVarPath = "./api/LayoutListElements/{elementType}";
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

            if (elementType != null) localVarPathParams.Add("elementType", this.Configuration.ApiClient.ParameterToString(elementType)); // path parameter

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
                Exception exception = ExceptionFactory("ElementGetByElementType", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<KeyValueElementDto>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (List<KeyValueElementDto>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<KeyValueElementDto>)));
        }

    }
}
