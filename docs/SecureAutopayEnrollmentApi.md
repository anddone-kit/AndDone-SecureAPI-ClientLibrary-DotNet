# AndDoneSecureClientLibrary.Api.SecureAutopayEnrollmentApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SecureAutopayenrollmentPost**](SecureAutopayEnrollmentApi.md#secureautopayenrollmentpost) | **POST** /secure/autopayenrollment | This API is used for Autopay Enrollment. |

<a id="secureautopayenrollmentpost"></a>
# **SecureAutopayenrollmentPost**
> AutoPayEnrollmentResponse SecureAutopayenrollmentPost (string xApiKey, string xAppKey, float xVersion, string origin, AutoPayEnrollmentRequest autoPayEnrollmentRequest)

This API is used for Autopay Enrollment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AndDoneSecureClientLibrary.Api;
using AndDoneSecureClientLibrary.Client;
using AndDoneSecureClientLibrary.Model;

namespace Example
{
    public class SecureAutopayenrollmentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            var apiInstance = new SecureAutopayEnrollmentApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var autoPayEnrollmentRequest = new AutoPayEnrollmentRequest(); // AutoPayEnrollmentRequest | Autopay Enrollment Detail

            try
            {
                // This API is used for Autopay Enrollment.
                AutoPayEnrollmentResponse result = apiInstance.SecureAutopayenrollmentPost(xApiKey, xAppKey, xVersion, origin, autoPayEnrollmentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureAutopayEnrollmentApi.SecureAutopayenrollmentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureAutopayenrollmentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API is used for Autopay Enrollment.
    ApiResponse<AutoPayEnrollmentResponse> response = apiInstance.SecureAutopayenrollmentPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, autoPayEnrollmentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureAutopayEnrollmentApi.SecureAutopayenrollmentPostWithHttpInfo: " + e.Message);
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
| **autoPayEnrollmentRequest** | [**AutoPayEnrollmentRequest**](AutoPayEnrollmentRequest.md) | Autopay Enrollment Detail |  |

### Return type

[**AutoPayEnrollmentResponse**](AutoPayEnrollmentResponse.md)

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

