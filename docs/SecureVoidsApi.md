# Org.OpenAPITools.Api.SecureVoidsApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecureCancellationsPost**](SecureVoidsApi.md#securecancellationspost) | **POST** /secure/cancellations | This API cancel a transaction. |

<a id="securecancellationspost"></a>
# **SecureCancellationsPost**
> SecureCancelledTransactionResponse SecureCancellationsPost (string xApiKey, string xAppKey, float xVersion, string origin, SecureTransactionCancelRequest secureTransactionCancelRequest)

This API cancel a transaction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecureCancellationsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            var apiInstance = new SecureVoidsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var secureTransactionCancelRequest = new SecureTransactionCancelRequest(); // SecureTransactionCancelRequest | Cancel Detail

            try
            {
                // This API cancel a transaction.
                SecureCancelledTransactionResponse result = apiInstance.SecureCancellationsPost(xApiKey, xAppKey, xVersion, origin, secureTransactionCancelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureVoidsApi.SecureCancellationsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureCancellationsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API cancel a transaction.
    ApiResponse<SecureCancelledTransactionResponse> response = apiInstance.SecureCancellationsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, secureTransactionCancelRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureVoidsApi.SecureCancellationsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiKey** | **string** | an authorization header |  |
| **xAppKey** | **string** | an authorization header |  |
| **xVersion** | **float** | x-version |  |
| **origin** | **string** | origin |  |
| **secureTransactionCancelRequest** | [**SecureTransactionCancelRequest**](SecureTransactionCancelRequest.md) | Cancel Detail |  |

### Return type

[**SecureCancelledTransactionResponse**](SecureCancelledTransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

