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
    public partial class CacheApi 
    {
    /// <summary>
    /// This call allows to add a file to the buffer 
    /// </summary>
    /// <exception cref="Pragmos.ARXivarNEXT.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="_file">The file</param>
    /// <returns>Task of List&lt;string&gt;</returns>
    public async System.Threading.Tasks.Task<List<string>> CacheInsertAsync(System.IO.Stream _file, string fileName)
    {
      ApiResponse<List<string>> localVarResponse = await CacheInsertAsyncWithHttpInfo(_file, fileName);
      return localVarResponse.Data;

    }

    /// <summary>
    /// This call allows to add a file to the buffer 
    /// </summary>
    /// <exception cref="Pragmos.ARXivarNEXT.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="_file">The file</param>
    /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
    public async System.Threading.Tasks.Task<ApiResponse<List<string>>> CacheInsertAsyncWithHttpInfo(System.IO.Stream _file, string fileName)
    {
      // verify the required parameter '_file' is set
      if (_file == null)
        throw new ApiException(400, "Missing required parameter '_file' when calling CacheApi->CacheInsert");

      var localVarPath = "./api/Cache/insert";
      var localVarPathParams = new Dictionary<String, String>();
      var localVarQueryParams = new List<KeyValuePair<String, String>>();
      var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
      var localVarFormParams = new Dictionary<String, String>();
      var localVarFileParams = new Dictionary<String, FileParameter>();
      Object localVarPostBody = null;

      // to determine the Content-Type header
      String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
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

      if (_file != null)
      {
        var f = this.Configuration.ApiClient.ParameterToFile("file", _file);
        f.FileName = fileName;
        localVarFileParams.Add("file", f);
      }

      // authentication (Authorization) required
      if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
      {
        localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
      }

      // make the HTTP request
      IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
          Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
          localVarPathParams, localVarHttpContentType);

      int localVarStatusCode = (int)localVarResponse.StatusCode;

      if (ExceptionFactory != null)
      {
        Exception exception = ExceptionFactory("CacheInsert", localVarResponse);
        if (exception != null) throw exception;
      }

      return new ApiResponse<List<string>>(localVarStatusCode,
          localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
          (List<string>)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
    }

  }
}
