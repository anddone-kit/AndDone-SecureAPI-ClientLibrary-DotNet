# Org.OpenAPITools.Api.SecureACHValidationApi

All URIs are relative to *https://api.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UtilityapiSecureVerifybankaccountsPost**](SecureACHValidationApi.md#utilityapisecureverifybankaccountspost) | **POST** /utilityapi/secure/verifybankaccounts | This API verifies bank account using secure ACH validation |

<a id="utilityapisecureverifybankaccountspost"></a>
# **UtilityapiSecureVerifybankaccountsPost**
> VerifyBankAccountResponse UtilityapiSecureVerifybankaccountsPost (string xApiKey, string xAppKey, float xVersion, string origin, SecureVerifyBankAccountRequestDTO secureVerifyBankAccountRequestDTO)

This API verifies bank account using secure ACH validation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UtilityapiSecureVerifybankaccountsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.anddone.com";
            var apiInstance = new SecureACHValidationApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var secureVerifyBankAccountRequestDTO = new SecureVerifyBankAccountRequestDTO(); // SecureVerifyBankAccountRequestDTO | SecureVerifyBankAccountRequestDTO

            try
            {
                // This API verifies bank account using secure ACH validation
                VerifyBankAccountResponse result = apiInstance.UtilityapiSecureVerifybankaccountsPost(xApiKey, xAppKey, xVersion, origin, secureVerifyBankAccountRequestDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureACHValidationApi.UtilityapiSecureVerifybankaccountsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UtilityapiSecureVerifybankaccountsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API verifies bank account using secure ACH validation
    ApiResponse<VerifyBankAccountResponse> response = apiInstance.UtilityapiSecureVerifybankaccountsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, secureVerifyBankAccountRequestDTO);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureACHValidationApi.UtilityapiSecureVerifybankaccountsPostWithHttpInfo: " + e.Message);
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
| **secureVerifyBankAccountRequestDTO** | [**SecureVerifyBankAccountRequestDTO**](SecureVerifyBankAccountRequestDTO.md) | SecureVerifyBankAccountRequestDTO |  |

### Return type

[**VerifyBankAccountResponse**](VerifyBankAccountResponse.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

