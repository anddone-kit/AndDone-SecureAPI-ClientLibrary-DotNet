# AndDoneSecureClientLibrary.Api.SecureOutboundPaymentsApi

All URIs are relative to *https://api.uat.anddone.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VendorapiSecureOutboundPaymentsTimelinesPost**](SecureOutboundPaymentsApi.md#vendorapisecureoutboundpaymentstimelinespost) | **POST** /vendorapi/secure/outboundPayments/timelines | This API gets outbound payment timelines |
| [**VendorapiSecureOutboundpaymentsCancelPost**](SecureOutboundPaymentsApi.md#vendorapisecureoutboundpaymentscancelpost) | **POST** /vendorapi/secure/outboundpayments/cancel | This API cancel outbound payment request |
| [**VendorapiSecureOutboundpaymentsDetailPost**](SecureOutboundPaymentsApi.md#vendorapisecureoutboundpaymentsdetailpost) | **POST** /vendorapi/secure/outboundpayments/detail | This API fetch outbound payment by paymentId |
| [**VendorapiSecureOutboundpaymentsImagePost**](SecureOutboundPaymentsApi.md#vendorapisecureoutboundpaymentsimagepost) | **POST** /vendorapi/secure/outboundpayments/image | This API gets outbound payment JPG image in Base64 string format |
| [**VendorapiSecureOutboundpaymentsPost**](SecureOutboundPaymentsApi.md#vendorapisecureoutboundpaymentspost) | **POST** /vendorapi/secure/outboundpayments | This API creates outbound payment request |
| [**VendorapiSecureOutboundpaymentsSearchPost**](SecureOutboundPaymentsApi.md#vendorapisecureoutboundpaymentssearchpost) | **POST** /vendorapi/secure/outboundpayments/search | This API gets all outbound payment |

<a id="vendorapisecureoutboundpaymentstimelinespost"></a>
# **VendorapiSecureOutboundPaymentsTimelinesPost**
> List&lt;OutboundPaymentTimelineResponseDTOInner&gt; VendorapiSecureOutboundPaymentsTimelinesPost (string xApiKey, string xAppKey, float xVersion, string origin, PaymentTimeLineRequestDto paymentTimeLineRequestDto)

This API gets outbound payment timelines

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AndDoneSecureClientLibrary.Api;
using AndDoneSecureClientLibrary.Client;
using AndDoneSecureClientLibrary.Model;

namespace Example
{
    public class VendorapiSecureOutboundPaymentsTimelinesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            var apiInstance = new SecureOutboundPaymentsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var paymentTimeLineRequestDto = new PaymentTimeLineRequestDto(); // PaymentTimeLineRequestDto | PaymentTimeLineRequestDto

            try
            {
                // This API gets outbound payment timelines
                List<OutboundPaymentTimelineResponseDTOInner> result = apiInstance.VendorapiSecureOutboundPaymentsTimelinesPost(xApiKey, xAppKey, xVersion, origin, paymentTimeLineRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureOutboundPaymentsApi.VendorapiSecureOutboundPaymentsTimelinesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VendorapiSecureOutboundPaymentsTimelinesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API gets outbound payment timelines
    ApiResponse<List<OutboundPaymentTimelineResponseDTOInner>> response = apiInstance.VendorapiSecureOutboundPaymentsTimelinesPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, paymentTimeLineRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureOutboundPaymentsApi.VendorapiSecureOutboundPaymentsTimelinesPostWithHttpInfo: " + e.Message);
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
| **paymentTimeLineRequestDto** | [**PaymentTimeLineRequestDto**](PaymentTimeLineRequestDto.md) | PaymentTimeLineRequestDto |  |

### Return type

[**List&lt;OutboundPaymentTimelineResponseDTOInner&gt;**](OutboundPaymentTimelineResponseDTOInner.md)

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

<a id="vendorapisecureoutboundpaymentscancelpost"></a>
# **VendorapiSecureOutboundpaymentsCancelPost**
> void VendorapiSecureOutboundpaymentsCancelPost (string xApiKey, string xAppKey, float xVersion, string origin, CancelPaymentRequestDTO cancelPaymentRequestDTO)

This API cancel outbound payment request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AndDoneSecureClientLibrary.Api;
using AndDoneSecureClientLibrary.Client;
using AndDoneSecureClientLibrary.Model;

namespace Example
{
    public class VendorapiSecureOutboundpaymentsCancelPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            var apiInstance = new SecureOutboundPaymentsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var cancelPaymentRequestDTO = new CancelPaymentRequestDTO(); // CancelPaymentRequestDTO | CancelPaymentRequestDTO

            try
            {
                // This API cancel outbound payment request
                apiInstance.VendorapiSecureOutboundpaymentsCancelPost(xApiKey, xAppKey, xVersion, origin, cancelPaymentRequestDTO);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureOutboundPaymentsApi.VendorapiSecureOutboundpaymentsCancelPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VendorapiSecureOutboundpaymentsCancelPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API cancel outbound payment request
    apiInstance.VendorapiSecureOutboundpaymentsCancelPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, cancelPaymentRequestDTO);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureOutboundPaymentsApi.VendorapiSecureOutboundpaymentsCancelPostWithHttpInfo: " + e.Message);
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
| **cancelPaymentRequestDTO** | [**CancelPaymentRequestDTO**](CancelPaymentRequestDTO.md) | CancelPaymentRequestDTO |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vendorapisecureoutboundpaymentsdetailpost"></a>
# **VendorapiSecureOutboundpaymentsDetailPost**
> PaymentDetailResponseDTO VendorapiSecureOutboundpaymentsDetailPost (string xApiKey, string xAppKey, float xVersion, string origin, PaymentRequestDetailDTO paymentRequestDetailDTO)

This API fetch outbound payment by paymentId

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AndDoneSecureClientLibrary.Api;
using AndDoneSecureClientLibrary.Client;
using AndDoneSecureClientLibrary.Model;

namespace Example
{
    public class VendorapiSecureOutboundpaymentsDetailPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            var apiInstance = new SecureOutboundPaymentsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var paymentRequestDetailDTO = new PaymentRequestDetailDTO(); // PaymentRequestDetailDTO | PaymentRequestDetailDTO

            try
            {
                // This API fetch outbound payment by paymentId
                PaymentDetailResponseDTO result = apiInstance.VendorapiSecureOutboundpaymentsDetailPost(xApiKey, xAppKey, xVersion, origin, paymentRequestDetailDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureOutboundPaymentsApi.VendorapiSecureOutboundpaymentsDetailPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VendorapiSecureOutboundpaymentsDetailPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API fetch outbound payment by paymentId
    ApiResponse<PaymentDetailResponseDTO> response = apiInstance.VendorapiSecureOutboundpaymentsDetailPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, paymentRequestDetailDTO);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureOutboundPaymentsApi.VendorapiSecureOutboundpaymentsDetailPostWithHttpInfo: " + e.Message);
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
| **paymentRequestDetailDTO** | [**PaymentRequestDetailDTO**](PaymentRequestDetailDTO.md) | PaymentRequestDetailDTO |  |

### Return type

[**PaymentDetailResponseDTO**](PaymentDetailResponseDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vendorapisecureoutboundpaymentsimagepost"></a>
# **VendorapiSecureOutboundpaymentsImagePost**
> OutboundPaymentImageResponseDTO VendorapiSecureOutboundpaymentsImagePost (string xApiKey, string xAppKey, float xVersion, string origin, PaymentTimeLineRequestDto paymentTimeLineRequestDto)

This API gets outbound payment JPG image in Base64 string format

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AndDoneSecureClientLibrary.Api;
using AndDoneSecureClientLibrary.Client;
using AndDoneSecureClientLibrary.Model;

namespace Example
{
    public class VendorapiSecureOutboundpaymentsImagePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            var apiInstance = new SecureOutboundPaymentsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var paymentTimeLineRequestDto = new PaymentTimeLineRequestDto(); // PaymentTimeLineRequestDto | OutboundPaymentImageRequestDto

            try
            {
                // This API gets outbound payment JPG image in Base64 string format
                OutboundPaymentImageResponseDTO result = apiInstance.VendorapiSecureOutboundpaymentsImagePost(xApiKey, xAppKey, xVersion, origin, paymentTimeLineRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureOutboundPaymentsApi.VendorapiSecureOutboundpaymentsImagePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VendorapiSecureOutboundpaymentsImagePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API gets outbound payment JPG image in Base64 string format
    ApiResponse<OutboundPaymentImageResponseDTO> response = apiInstance.VendorapiSecureOutboundpaymentsImagePostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, paymentTimeLineRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureOutboundPaymentsApi.VendorapiSecureOutboundpaymentsImagePostWithHttpInfo: " + e.Message);
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
| **paymentTimeLineRequestDto** | [**PaymentTimeLineRequestDto**](PaymentTimeLineRequestDto.md) | OutboundPaymentImageRequestDto |  |

### Return type

[**OutboundPaymentImageResponseDTO**](OutboundPaymentImageResponseDTO.md)

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

<a id="vendorapisecureoutboundpaymentspost"></a>
# **VendorapiSecureOutboundpaymentsPost**
> PaymentResponseDto VendorapiSecureOutboundpaymentsPost (string xApiKey, string xAppKey, float xVersion, string origin, PaymentRequestDto paymentRequestDto)

This API creates outbound payment request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AndDoneSecureClientLibrary.Api;
using AndDoneSecureClientLibrary.Client;
using AndDoneSecureClientLibrary.Model;

namespace Example
{
    public class VendorapiSecureOutboundpaymentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            var apiInstance = new SecureOutboundPaymentsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var paymentRequestDto = new PaymentRequestDto(); // PaymentRequestDto | PaymentRequestDto

            try
            {
                // This API creates outbound payment request
                PaymentResponseDto result = apiInstance.VendorapiSecureOutboundpaymentsPost(xApiKey, xAppKey, xVersion, origin, paymentRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureOutboundPaymentsApi.VendorapiSecureOutboundpaymentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VendorapiSecureOutboundpaymentsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API creates outbound payment request
    ApiResponse<PaymentResponseDto> response = apiInstance.VendorapiSecureOutboundpaymentsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, paymentRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureOutboundPaymentsApi.VendorapiSecureOutboundpaymentsPostWithHttpInfo: " + e.Message);
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
| **paymentRequestDto** | [**PaymentRequestDto**](PaymentRequestDto.md) | PaymentRequestDto |  |

### Return type

[**PaymentResponseDto**](PaymentResponseDto.md)

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

<a id="vendorapisecureoutboundpaymentssearchpost"></a>
# **VendorapiSecureOutboundpaymentsSearchPost**
> PagePaymentListResponseDTO VendorapiSecureOutboundpaymentsSearchPost (string xApiKey, string xAppKey, float xVersion, string origin, string vendorId = null, string paymentBasedId = null, string paymentId = null, string vendorName = null, string paymentMethodType = null, string paymentMethodStatus = null, float? amount = null, float? fromAmount = null, float? toAmount = null, string startDate = null, string endDate = null, string searchText = null, int? startRow = null, int? pageSize = null, string sortField = null, bool? asc = null)

This API gets all outbound payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AndDoneSecureClientLibrary.Api;
using AndDoneSecureClientLibrary.Client;
using AndDoneSecureClientLibrary.Model;

namespace Example
{
    public class VendorapiSecureOutboundpaymentsSearchPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.uat.anddone.com";
            var apiInstance = new SecureOutboundPaymentsApi(config);
            var xApiKey = "xApiKey_example";  // string | an authorization header
            var xAppKey = "xAppKey_example";  // string | an authorization header
            var xVersion = 8.14D;  // float | x-version
            var origin = "origin_example";  // string | origin
            var vendorId = "vendorId_example";  // string | sets vendorId (optional) 
            var paymentBasedId = "paymentBasedId_example";  // string | sets paymentBasedId (optional) 
            var paymentId = "paymentId_example";  // string | sets paymentId (optional) 
            var vendorName = "vendorName_example";  // string | sets vendorName (optional) 
            var paymentMethodType = "Check";  // string | sets paymentMethodType (optional) 
            var paymentMethodStatus = "paymentMethodStatus_example";  // string | sets paymentMethodStatus (optional) 
            var amount = 8.14D;  // float? | sets amount (optional) 
            var fromAmount = 8.14D;  // float? | sets fromAmount (optional) 
            var toAmount = 8.14D;  // float? | sets toAmount (optional) 
            var startDate = "startDate_example";  // string | sets startDate (optional) 
            var endDate = "endDate_example";  // string | sets endDate (optional) 
            var searchText = "searchText_example";  // string | sets searchText (optional) 
            var startRow = 56;  // int? | sets startRow (optional) 
            var pageSize = 56;  // int? | sets pageSize (optional) 
            var sortField = "sortField_example";  // string | sets sortField (optional) 
            var asc = true;  // bool? | Set Asc (optional) 

            try
            {
                // This API gets all outbound payment
                PagePaymentListResponseDTO result = apiInstance.VendorapiSecureOutboundpaymentsSearchPost(xApiKey, xAppKey, xVersion, origin, vendorId, paymentBasedId, paymentId, vendorName, paymentMethodType, paymentMethodStatus, amount, fromAmount, toAmount, startDate, endDate, searchText, startRow, pageSize, sortField, asc);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecureOutboundPaymentsApi.VendorapiSecureOutboundpaymentsSearchPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VendorapiSecureOutboundpaymentsSearchPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This API gets all outbound payment
    ApiResponse<PagePaymentListResponseDTO> response = apiInstance.VendorapiSecureOutboundpaymentsSearchPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, vendorId, paymentBasedId, paymentId, vendorName, paymentMethodType, paymentMethodStatus, amount, fromAmount, toAmount, startDate, endDate, searchText, startRow, pageSize, sortField, asc);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecureOutboundPaymentsApi.VendorapiSecureOutboundpaymentsSearchPostWithHttpInfo: " + e.Message);
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
| **vendorId** | **string** | sets vendorId | [optional]  |
| **paymentBasedId** | **string** | sets paymentBasedId | [optional]  |
| **paymentId** | **string** | sets paymentId | [optional]  |
| **vendorName** | **string** | sets vendorName | [optional]  |
| **paymentMethodType** | **string** | sets paymentMethodType | [optional]  |
| **paymentMethodStatus** | **string** | sets paymentMethodStatus | [optional]  |
| **amount** | **float?** | sets amount | [optional]  |
| **fromAmount** | **float?** | sets fromAmount | [optional]  |
| **toAmount** | **float?** | sets toAmount | [optional]  |
| **startDate** | **string** | sets startDate | [optional]  |
| **endDate** | **string** | sets endDate | [optional]  |
| **searchText** | **string** | sets searchText | [optional]  |
| **startRow** | **int?** | sets startRow | [optional]  |
| **pageSize** | **int?** | sets pageSize | [optional]  |
| **sortField** | **string** | sets sortField | [optional]  |
| **asc** | **bool?** | Set Asc | [optional]  |

### Return type

[**PagePaymentListResponseDTO**](PagePaymentListResponseDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

