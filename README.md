
# AndDone Client Library - .NET

This client library integrates with AndDone's secure APIs.

Please see our developer documentation & API Explorer, linked below, for detailed instructions on how to integrate this into your systems.

**Secure API .NET Client**

This .NET SDK is an auto-generated client for the AndDone Secure API, built using the [OpenAPI Generator](https://openapi-generator.tech).

* **API version**: 2.3
* **Package version**: 1.0.0
* **Generator version**: 7.9.0
* **Build package**: `org.openapitools.codegen.languages.CSharpClientCodegen`
* **Developer Documentation**: [DevDocs](https://docs.anddone.com/)
* **API Explorer**: [AndDone API Explorer](https://explorer.anddone.com/)

---

## Table of Contents

* [Requirements](#requirements)
* [Installation](#installation)
* [Configuration](#configuration)
* [Quickstart](#quickstart)
* [API Endpoints](#api-endpoints)
* [Models](#models)
* [Authorization](#authorization)
* [Support & Versioning](#support--versioning)

---

## Requirements

* **.NET 6.0+** (supports .NET Core and .NET Framework)
* Access to **AndDone Merchant Portal** for API keys.

Dependencies are managed through **NuGet**:

* [RestSharp](https://www.nuget.org/packages/RestSharp) 112.0.0+
* [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json) 13.0.2+
* [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) 1.8.0+
* [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) 5.0.0+

---

## Installation

Install dependencies via NuGet:

```powershell
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

Then include the DLLs or reference the project, and import the namespaces:

```csharp
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
```

---

## Configuration

1. **Retrieve Developer Credentials:**

   1. Log in to AndDone Merchant Portal:

      * **UAT**: [https://portal.uat.anddone.com](https://portal.uat.anddone.com)
      * **Production**: [https://portal.anddone.com](https://portal.anddone.com)
   2. Go to **Developer → API Keys** in the left menu.
   3. Copy:

      * `xApiKey` (API Key)
      * `xAppKey` (App Key)

2. **Determine Your Origin:**
   The `origin` is your public IP address.
   Find it by searching **"what's my IP"** in Google or visiting [https://www.whatsmyip.org](https://www.whatsmyip.org).

   * Contact AndDone support to ensure your origin IP is registered.
   * Email: [integrations@anddone.com](mailto:integrations@anddone.com)

3. **Optional: Create a Configuration File:**
   Rename `config.example.json` to `config.json` and fill it with your values:

   ```json
   {
     "xApiKey": "YOUR_API_KEY",
     "xAppKey": "YOUR_APP_KEY",
     "xVersion": "2.3",
     "origin": "YOUR_IP_ADDRESS"
   }
   ```

---

## Quickstart

Here’s a minimal working example to call the **Secure Create Payment Intent API**:

```csharp
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

var config = new Configuration
{
    BasePath = "https://api.uat.anddone.com"
};

var apiInstance = new SecurePaymentIntentApi(config);

// Required headers
string xApiKey = "YOUR_API_KEY";
string xAppKey = "YOUR_APP_KEY";
float xVersion = 2.3F;
string origin = "YOUR_ORIGIN";

var request = @"{
    ""saveForFuture"": true,
    ""amount"": 10000,
    ""title"": ""test title 001a"",
    ""shortDescription"": ""shortDescription"",
    ""paymentDescription"": ""paymentDescription"",
    ""invoiceNumber"": ""postman"",
    ""expiresIn"": ""300000"",
    ""intent"": {
        ""paymentTypes"": [
            ""CreditCard"", 
            ""ACH""
        ]
    },
    ""enablePremiumFinance"": true,
    ""splits"": null,
    ""additionalDetailsPreference"": ""NoAdditionalDetails""
}";
JObject data = JObject.Parse(request);
PaymentIntentRequest postBody = JsonConvert.DeserializeObject<PaymentIntentRequest>(data.ToString());

try
{
    var response = apiInstance.SecurePaymentintentsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, postBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.WriteLine("Exception when calling SecurePaymentIntentApi: " + e.Message);
}
```

---

## API Endpoints

All URIs are relative to:

* **UAT**: `https://api.uat.anddone.com`
* **Production**: `https://api.anddone.com`

<details>
  <summary>Click to view all endpoints</summary>

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*SecureEmbeddedPremiumFinanceApi* | [**SecureEpfMerchantsQuotesPolicyPut**](docs/SecureEmbeddedPremiumFinanceApi.md#secureepfmerchantsquotespolicyputwithhttpinfo) | **PUT** /secure/epf/merchants/quotes/policy | This API is will update the policy number
*SecureEmbeddedPremiumFinanceApi* | [**SecureEpfQuotesBookingPut**](docs/SecureEmbeddedPremiumFinanceApi.md#secureepfquotesbookingputwithhttpinfo) | **PUT** /secure/epf/quotes/booking | This API will update PFA to book a quote.
*SecureEmbeddedPremiumFinanceApi* | [**SecureEpfQuotesCaptureesignPut**](docs/SecureEmbeddedPremiumFinanceApi.md#secureepfquotescaptureesignputwithhttpinfo) | **PUT** /secure/epf/quotes/captureesign | This API will eSign the pfa with insured name.
*SecureEmbeddedPremiumFinanceApi* | [**SecureEpfQuotesGeneratePost**](docs/SecureEmbeddedPremiumFinanceApi.md#secureepfquotesgeneratepostwithhttpinfo) | **POST** /secure/epf/quotes/generate | This API is used to Generate Quotes
*SecureEmbeddedPremiumFinanceApi* | [**SecureEpfQuotesIntentPost**](docs/SecureEmbeddedPremiumFinanceApi.md#secureepfquotesintentpostwithhttpinfo) | **POST** /secure/epf/quotes/intent | This API will return quotes created againsts a payment intent.
*SecureEmbeddedPremiumFinanceApi* | [**SecureEpfQuotesPost**](docs/SecureEmbeddedPremiumFinanceApi.md#secureepfquotespostwithhttpinfo) | **POST** /secure/epf/quotes | This API will return quote by QuoteKey.
*SecureEmbeddedPremiumFinanceApi* | [**SecureEpfRetrievepfaPost**](docs/SecureEmbeddedPremiumFinanceApi.md#secureepfretrievepfapostwithhttpinfo) | **POST** /secure/epf/retrievepfa | This API will return PFA for given quoteKey.
*SecureEmbeddedPremiumFinanceEndorsementsApi* | [**SecureEpfEndorsementsPost**](docs/SecureEmbeddedPremiumFinanceEndorsementsApi.md#secureepfendorsementspostwithhttpinfo) | **POST** /secure/epf/endorsements | This API will do a check of eligibility of account
*SecureEmbeddedPremiumFinanceEndorsementsApi* | [**SecureEpfQuoteEndorsementBookingPut**](docs/SecureEmbeddedPremiumFinanceEndorsementsApi.md#secureepfquoteendorsementbookingputwithhttpinfo) | **PUT** /secure/epf/quote/endorsement/booking | This API will update PFA to book a endorsement quote.
*SecureEmbeddedPremiumFinanceEndorsementsApi* | [**SecureEpfQuoteEndorsementPost**](docs/SecureEmbeddedPremiumFinanceEndorsementsApi.md#secureepfquoteendorsementpostwithhttpinfo) | **POST** /secure/epf/quote/endorsement | This API will do return a quote for an existing policy or new policy for an existing account
*SecureOrumApi* | [**SecureBankaccountsDetailsPost**](docs/SecureOrumApi.md#securebankaccountsdetailspostwithhttpinfo) | **POST** /secure/bankaccounts/details | This API will request for verified bank account.
*SecureOrumApi* | [**SecureBankaccountsVerifyPost**](docs/SecureOrumApi.md#securebankaccountsverifypostwithhttpinfo) | **POST** /secure/bankaccounts/verify | This API will request for account verification.
*SecureOutboundPaymentsApi* | [**VendorapiSecureOutboundPaymentsTimelinesPost**](docs/SecureOutboundPaymentsApi.md#vendorapisecureoutboundpaymentstimelinespostwithhttpinfo) | **POST** /vendorapi/secure/outboundPayments/timelines | This API gets outbound payment timelines
*SecureOutboundPaymentsApi* | [**VendorapiSecureOutboundpaymentsCancelPost**](docs/SecureOutboundPaymentsApi.md#vendorapisecureoutboundpaymentscancelpostwithhttpinfo) | **POST** /vendorapi/secure/outboundpayments/cancel | This API cancel outbound payment request
*SecureOutboundPaymentsApi* | [**VendorapiSecureOutboundpaymentsDetailPost**](docs/SecureOutboundPaymentsApi.md#vendorapisecureoutboundpaymentsdetailpostwithhttpinfo) | **POST** /vendorapi/secure/outboundpayments/detail | This API fetch outbound payment by paymentId
*SecureOutboundPaymentsApi* | [**VendorapiSecureOutboundpaymentsPost**](docs/SecureOutboundPaymentsApi.md#vendorapisecureoutboundpaymentspostwithhttpinfo) | **POST** /vendorapi/secure/outboundpayments | This API creates outbound payment request
*SecureOutboundPaymentsApi* | [**VendorapiSecureOutboundpaymentsSearchPost**](docs/SecureOutboundPaymentsApi.md#vendorapisecureoutboundpaymentssearchpostwithhttpinfo) | **POST** /vendorapi/secure/outboundpayments/search | This API gets all outbound payment
*SecurePaymentBatchingApi* | [**SecureBatchesDetailsPost**](docs/SecurePaymentBatchingApi.md#securebatchesdetailspostwithhttpinfo) | **POST** /secure/batches/details | This API is used for getting Secure Payment Batch Details
*SecurePaymentBatchingApi* | [**SecureBatchesExecutePost**](docs/SecurePaymentBatchingApi.md#securebatchesexecutepostwithhttpinfo) | **POST** /secure/batches/execute | This API execute on-demand batch transaction.
*SecurePaymentBatchingApi* | [**SecureBatchesPost**](docs/SecurePaymentBatchingApi.md#securebatchespostwithhttpinfo) | **POST** /secure/batches | This API is used for getting Secure Payment Batches
*SecurePaymentBatchingApi* | [**SecureBatchesTimelinesPost**](docs/SecurePaymentBatchingApi.md#securebatchestimelinespostwithhttpinfo) | **POST** /secure/batches/timelines | This API will returns batch timeline.
*SecurePaymentBatchingApi* | [**SecureBatchesTransactionsCancelPost**](docs/SecurePaymentBatchingApi.md#securebatchestransactionscancelpostwithhttpinfo) | **POST** /secure/batches/transactions/cancel | This API cancels transactions from an active batch.
*SecurePaymentIntentApi* | [**SecurePaymentintentsExpirationsPost**](docs/SecurePaymentIntentApi.md#securepaymentintentsexpirationspostwithhttpinfo) | **POST** /secure/paymentintents/expirations | This API expires the payment Intent or link.
*SecurePaymentIntentApi* | [**SecurePaymentintentsPost**](docs/SecurePaymentIntentApi.md#securepaymentintentspostwithhttpinfo) | **POST** /secure/paymentintents | This API is use to create Secure payment Intent.
*SecurePaymentLinksApi* | [**SecurePaymentlinksDetailsPost**](docs/SecurePaymentLinksApi.md#securepaymentlinksdetailspostwithhttpinfo) | **POST** /secure/paymentlinks/details | This API is used for getting Payment Links by PaymentLink ID
*SecurePaymentLinksApi* | [**SecurePaymentlinksExpirationsPost**](docs/SecurePaymentLinksApi.md#securepaymentlinksexpirationspostwithhttpinfo) | **POST** /secure/paymentlinks/expirations | This API is used for to set expired payment link
*SecurePaymentLinksApi* | [**SecurePaymentlinksIdPut**](docs/SecurePaymentLinksApi.md#securepaymentlinksidputwithhttpinfo) | **PUT** /secure/paymentlinks/{id} | This API is used to update Payment Links
*SecurePaymentLinksApi* | [**SecurePaymentlinksPost**](docs/SecurePaymentLinksApi.md#securepaymentlinkspostwithhttpinfo) | **POST** /secure/paymentlinks | This API is used to create Payment Links
*SecurePaymentsApi* | [**SecurePaymentsExportPost**](docs/SecurePaymentsApi.md#securepaymentsexportpostwithhttpinfo) | **POST** /secure/payments/export | This API gets Secure payment by search criteria for the merchant.
*SecurePaymentsApi* | [**SecurePaymentsPost**](docs/SecurePaymentsApi.md#securepaymentspostwithhttpinfo) | **POST** /secure/payments | This API posts new Secure payment request for the merchant.
*SecurePaymentsApi* | [**SecurePaymentsSearchPost**](docs/SecurePaymentsApi.md#securepaymentssearchpostwithhttpinfo) | **POST** /secure/payments/search | This API gets Secure payment by search criteria for the merchant.
*SecurePaymentsApi* | [**SecurePaymentsdetailsPost**](docs/SecurePaymentsApi.md#securepaymentsdetailspostwithhttpinfo) | **POST** /secure/paymentsdetails | This API is used for getting details of Payments
*SecurePremiumFinanceLiteApi* | [**SecureEpfliteQuotesGeneratePost**](docs/SecurePremiumFinanceLiteApi.md#secureepflitequotesgeneratepostwithhttpinfo) | **POST** /secure/epflite/quotes/generate | This API is used to generate the quote from the provider.
*SecurePremiumFinanceLiteApi* | [**SecureEpfliteQuotesLinkPost**](docs/SecurePremiumFinanceLiteApi.md#secureepflitequoteslinkpostwithhttpinfo) | **POST** /secure/epflite/quotes/link | This API will return quotes created againsts a payment link.
*SecurePremiumFinanceLiteApi* | [**SecureEpfliteQuotesPaymentlinksPost**](docs/SecurePremiumFinanceLiteApi.md#secureepflitequotespaymentlinkspostwithhttpinfo) | **POST** /secure/epflite/quotes/paymentlinks | This API is used to create Payment Links
*SecureRefundsApi* | [**SecureRefundsEligibilityPost**](docs/SecureRefundsApi.md#securerefundseligibilitypostwithhttpinfo) | **POST** /secure/refunds/eligibility | This API return refund eligibility of a transaction.
*SecureRefundsApi* | [**SecureRefundsPost**](docs/SecureRefundsApi.md#securerefundspostwithhttpinfo) | **POST** /secure/refunds | This API will refund a transaction which has been settled by the processor.
*SecureReportsApi* | [**SecureReportsDownloadsPost**](docs/SecureReportsApi.md#securereportsdownloadspostwithhttpinfo) | **POST** /secure/reports/downloads | This API will add system report.
*SecureTokenLinksApi* | [**SecureTokenlinksDetailsPost**](docs/SecureTokenLinksApi.md#securetokenlinksdetailspostwithhttpinfo) | **POST** /secure/tokenlinks/details | This API is used for getting Token Links by TokenLink ID
*SecureTokenLinksApi* | [**SecureTokenlinksExpirationsPost**](docs/SecureTokenLinksApi.md#securetokenlinksexpirationspostwithhttpinfo) | **POST** /secure/tokenlinks/expirations | This API expires the token link.
*SecureTokenLinksApi* | [**SecureTokenlinksListPost**](docs/SecureTokenLinksApi.md#securetokenlinkslistpostwithhttpinfo) | **POST** /secure/tokenlinks/list | This API is used for getting all Token Links for Merchant
*SecureTokenLinksApi* | [**SecureTokenlinksPost**](docs/SecureTokenLinksApi.md#securetokenlinkspostwithhttpinfo) | **POST** /secure/tokenlinks | This API is use to create Secure Token Links
*SecureTokenLinksApi* | [**SecureTokenlinksPut**](docs/SecureTokenLinksApi.md#securetokenlinksputwithhttpinfo) | **PUT** /secure/tokenlinks | This API will update the expireIn and paymentType of Token Link.
*SecureTokenManagementApi* | [**SecureTokensActivationsDelete**](docs/SecureTokenManagementApi.md#securetokensactivationsdeletewithhttpinfo) | **DELETE** /secure/tokens/activations | This API is used for deactivating merchant token securely
*SecureTokenManagementApi* | [**SecureTokensDetailsPost**](docs/SecureTokenManagementApi.md#securetokensdetailspostwithhttpinfo) | **POST** /secure/tokens/details | This API is used for getting details of Merchant Token by Token link.
*SecureVendorManagementApi* | [**VendorapiSecureMerchantsVendorsDeletePost**](docs/SecureVendorManagementApi.md#vendorapisecuremerchantsvendorsdeletepostwithhttpinfo) | **POST** /vendorapi/secure/merchants/vendors/delete | This API deletes vendor into system
*SecureVendorManagementApi* | [**VendorapiSecureMerchantsVendorsDetailsPost**](docs/SecureVendorManagementApi.md#vendorapisecuremerchantsvendorsdetailspostwithhttpinfo) | **POST** /vendorapi/secure/merchants/vendors/details | This API gets details of particular vendor
*SecureVendorManagementApi* | [**VendorapiSecureMerchantsVendorsEditPost**](docs/SecureVendorManagementApi.md#vendorapisecuremerchantsvendorseditpostwithhttpinfo) | **POST** /vendorapi/secure/merchants/vendors/edit | This API Updates the existing vendor
*SecureVendorManagementApi* | [**VendorapiSecureMerchantsVendorsPost**](docs/SecureVendorManagementApi.md#vendorapisecuremerchantsvendorspostwithhttpinfo) | **POST** /vendorapi/secure/merchants/vendors | This API creates vendor into system
*SecureVendorManagementApi* | [**VendorapiSecureMerchantsVendorsSearchPost**](docs/SecureVendorManagementApi.md#vendorapisecuremerchantsvendorssearchpostwithhttpinfo) | **POST** /vendorapi/secure/merchants/vendors/search | This API returns list of all the Vendors of Merchant
*SecureVendorManagementApi* | [**VendorapiSecureMerchantsVendorsSuspendPost**](docs/SecureVendorManagementApi.md#vendorapisecuremerchantsvendorssuspendpostwithhttpinfo) | **POST** /vendorapi/secure/merchants/vendors/suspend | This API suspends vendor into system
*SecureVendorManagementApi* | [**VendorapiSecureMerchantsVendorsTimelinePost**](docs/SecureVendorManagementApi.md#vendorapisecuremerchantsvendorstimelinepostwithhttpinfo) | **POST** /vendorapi/secure/merchants/vendors/timeline | This API gets timeline of particular vendor
*SecureVendorManagementApi* | [**VendorapiSecureMerchantsVendorsUnsuspendPost**](docs/SecureVendorManagementApi.md#vendorapisecuremerchantsvendorsunsuspendpostwithhttpinfo) | **POST** /vendorapi/secure/merchants/vendors/unsuspend | This API unsuspends vendor into system
*SecureVoidsApi* | [**SecureCancellationsPost**](docs/SecureVoidsApi.md#securecancellationspostwithhttpinfo) | **POST** /secure/cancellations | This API cancel a transaction.

</details>

---

## Models

<details>
  <summary>Click to view all models</summary>


 - [Model.BankDetailDto](docs/BankDetailDto.md)
 - [Model.CancelPaymentRequestDTO](docs/CancelPaymentRequestDTO.md)
 - [Model.DataDto](docs/DataDto.md)
 - [Model.GetQuoteKeyRequest](docs/GetQuoteKeyRequest.md)
 - [Model.GetQuoteRequest](docs/GetQuoteRequest.md)
 - [Model.HeadingDto](docs/HeadingDto.md)
 - [Model.MerchantTransactionEntityResponse](docs/MerchantTransactionEntityResponse.md)
 - [Model.MerchantTransactionEntityResponseDataInner](docs/MerchantTransactionEntityResponseDataInner.md)
 - [Model.OutboundPaymentTimelineResponseDTOInner](docs/OutboundPaymentTimelineResponseDTOInner.md)
 - [Model.PFCheckEndorsementsRequest](docs/PFCheckEndorsementsRequest.md)
 - [Model.PFCheckEndorsementsResponse](docs/PFCheckEndorsementsResponse.md)
 - [Model.PFCheckEndorsementsResponseItem](docs/PFCheckEndorsementsResponseItem.md)
 - [Model.PFCheckEndorsementsResponseItemPoliciesInner](docs/PFCheckEndorsementsResponseItemPoliciesInner.md)
 - [Model.PFEndorsementRequest](docs/PFEndorsementRequest.md)
 - [Model.PFEndorsementRequestQuote](docs/PFEndorsementRequestQuote.md)
 - [Model.PFEndorsementRequestQuoteAgent](docs/PFEndorsementRequestQuoteAgent.md)
 - [Model.PFEndorsementRequestQuoteAgentAddress](docs/PFEndorsementRequestQuoteAgentAddress.md)
 - [Model.PFEndorsementRequestQuoteCommunication](docs/PFEndorsementRequestQuoteCommunication.md)
 - [Model.PFEndorsementRequestQuoteDetails](docs/PFEndorsementRequestQuoteDetails.md)
 - [Model.PFEndorsementRequestQuoteDetailsRecurringACH](docs/PFEndorsementRequestQuoteDetailsRecurringACH.md)
 - [Model.PFEndorsementRequestQuoteInsured](docs/PFEndorsementRequestQuoteInsured.md)
 - [Model.PFEndorsementRequestQuoteInsuredAddress](docs/PFEndorsementRequestQuoteInsuredAddress.md)
 - [Model.PFEndorsementRequestQuotePoliciesInner](docs/PFEndorsementRequestQuotePoliciesInner.md)
 - [Model.PFEndorsementRequestQuotePoliciesInnerCompany](docs/PFEndorsementRequestQuotePoliciesInnerCompany.md)
 - [Model.PFEndorsementRequestQuotePoliciesInnerGa](docs/PFEndorsementRequestQuotePoliciesInnerGa.md)
 - [Model.PFEndorsementRequestQuotePoliciesInnerPolicyFeeInner](docs/PFEndorsementRequestQuotePoliciesInnerPolicyFeeInner.md)
 - [Model.PFEndorsementRequestQuotePoliciesInnerTotalPayFundingInner](docs/PFEndorsementRequestQuotePoliciesInnerTotalPayFundingInner.md)
 - [Model.PFEndorsementResponse](docs/PFEndorsementResponse.md)
 - [Model.PFEndorsementResponseItem](docs/PFEndorsementResponseItem.md)
 - [Model.PFEndorsementResponseItemPaymentIntent](docs/PFEndorsementResponseItemPaymentIntent.md)
 - [Model.PFEndorsementResponseItemPaymentIntentIntent](docs/PFEndorsementResponseItemPaymentIntentIntent.md)
 - [Model.PFEndorsementResponseItemQuote](docs/PFEndorsementResponseItemQuote.md)
 - [Model.PFEndorsementResponseItemQuoteESignResult](docs/PFEndorsementResponseItemQuoteESignResult.md)
 - [Model.PFGenerateQuoteResponse](docs/PFGenerateQuoteResponse.md)
 - [Model.PFGenerateQuoteResponseItem](docs/PFGenerateQuoteResponseItem.md)
 - [Model.PFGenerateQuoteResponseItemESignResult](docs/PFGenerateQuoteResponseItemESignResult.md)
 - [Model.PFLiteGenerateQuoteResponse](docs/PFLiteGenerateQuoteResponse.md)
 - [Model.PFLiteGenerateQuoteResponseItem](docs/PFLiteGenerateQuoteResponseItem.md)
 - [Model.PFLiteGenerateQuoteResponseItemESignResult](docs/PFLiteGenerateQuoteResponseItemESignResult.md)
 - [Model.PFLiteGetQuoteRequest](docs/PFLiteGetQuoteRequest.md)
 - [Model.PFLitePaymentLinkRequest](docs/PFLitePaymentLinkRequest.md)
 - [Model.PFLitePaymentLinkRequestCallbackParameters](docs/PFLitePaymentLinkRequestCallbackParameters.md)
 - [Model.PFLitePaymentLinkRequestCustomersInner](docs/PFLitePaymentLinkRequestCustomersInner.md)
 - [Model.PFLitePaymentLinkRequestCustomersInnerAddress](docs/PFLitePaymentLinkRequestCustomersInnerAddress.md)
 - [Model.PFLitePaymentLinkRequestReferenceDataListInner](docs/PFLitePaymentLinkRequestReferenceDataListInner.md)
 - [Model.PFLitePaymentLinkRequestSettings](docs/PFLitePaymentLinkRequestSettings.md)
 - [Model.PFLiteQuoteByPaymentLinkResponse](docs/PFLiteQuoteByPaymentLinkResponse.md)
 - [Model.PFLiteQuoteByPaymentLinkResponsePoliciesInner](docs/PFLiteQuoteByPaymentLinkResponsePoliciesInner.md)
 - [Model.PFLiteQuoteByPaymentLinkResponsePoliciesInnerCarrier](docs/PFLiteQuoteByPaymentLinkResponsePoliciesInnerCarrier.md)
 - [Model.PFLiteSecureQuoteRequest](docs/PFLiteSecureQuoteRequest.md)
 - [Model.PFLiteSecureQuoteRequestInsured](docs/PFLiteSecureQuoteRequestInsured.md)
 - [Model.PFLiteSecureQuoteRequestInsuredAddress](docs/PFLiteSecureQuoteRequestInsuredAddress.md)
 - [Model.PFLiteSecureQuoteRequestMerchant](docs/PFLiteSecureQuoteRequestMerchant.md)
 - [Model.PFLiteSecureQuoteRequestPoliciesInner](docs/PFLiteSecureQuoteRequestPoliciesInner.md)
 - [Model.PFLiteSecureQuoteRequestPoliciesInnerCarrier](docs/PFLiteSecureQuoteRequestPoliciesInnerCarrier.md)
 - [Model.PFLiteSecureQuoteRequestProgram](docs/PFLiteSecureQuoteRequestProgram.md)
 - [Model.PFPolicyUpdateRequestDTO](docs/PFPolicyUpdateRequestDTO.md)
 - [Model.PFPolicyUpdateResponse](docs/PFPolicyUpdateResponse.md)
 - [Model.PFQuoteBookingRequest](docs/PFQuoteBookingRequest.md)
 - [Model.PFQuoteEsignRequest](docs/PFQuoteEsignRequest.md)
 - [Model.PFRetrievePFARequest](docs/PFRetrievePFARequest.md)
 - [Model.PFRetrievePFARequestDTO](docs/PFRetrievePFARequestDTO.md)
 - [Model.PFUpdatePFARequestDTO](docs/PFUpdatePFARequestDTO.md)
 - [Model.PFUpdatePFAResponse](docs/PFUpdatePFAResponse.md)
 - [Model.PagePaymentListResponseDTO](docs/PagePaymentListResponseDTO.md)
 - [Model.PagePaymentListResponseDTODataInner](docs/PagePaymentListResponseDTODataInner.md)
 - [Model.PageVendorResponseDTO](docs/PageVendorResponseDTO.md)
 - [Model.PageVendorResponseDTODataInner](docs/PageVendorResponseDTODataInner.md)
 - [Model.PaymentBatchCancellationRequest](docs/PaymentBatchCancellationRequest.md)
 - [Model.PaymentBatchDetailsResponse](docs/PaymentBatchDetailsResponse.md)
 - [Model.PaymentBatchDetailsResponseTransactionDetailsInner](docs/PaymentBatchDetailsResponseTransactionDetailsInner.md)
 - [Model.PaymentBatchEventLogResponse](docs/PaymentBatchEventLogResponse.md)
 - [Model.PaymentBatchResponse](docs/PaymentBatchResponse.md)
 - [Model.PaymentBatchResponseDataInner](docs/PaymentBatchResponseDataInner.md)
 - [Model.PaymentDetailResponseDTO](docs/PaymentDetailResponseDTO.md)
 - [Model.PaymentIntentExpiresResponse](docs/PaymentIntentExpiresResponse.md)
 - [Model.PaymentIntentRequest](docs/PaymentIntentRequest.md)
 - [Model.PaymentIntentRequestCustomersInner](docs/PaymentIntentRequestCustomersInner.md)
 - [Model.PaymentIntentRequestIntent](docs/PaymentIntentRequestIntent.md)
 - [Model.PaymentIntentRequestPfr](docs/PaymentIntentRequestPfr.md)
 - [Model.PaymentIntentRequestReferenceDataListInner](docs/PaymentIntentRequestReferenceDataListInner.md)
 - [Model.PaymentIntentRequestSplitsInner](docs/PaymentIntentRequestSplitsInner.md)
 - [Model.PaymentIntentResponse](docs/PaymentIntentResponse.md)
 - [Model.PaymentIntentResponseCustomersInner](docs/PaymentIntentResponseCustomersInner.md)
 - [Model.PaymentLinkExpiresResponse](docs/PaymentLinkExpiresResponse.md)
 - [Model.PaymentLinkRequest](docs/PaymentLinkRequest.md)
 - [Model.PaymentLinkRequestSettings](docs/PaymentLinkRequestSettings.md)
 - [Model.PaymentLinkRequestSettingsIntent](docs/PaymentLinkRequestSettingsIntent.md)
 - [Model.PaymentLinkResponse](docs/PaymentLinkResponse.md)
 - [Model.PaymentLinkResponseCallbackParameters](docs/PaymentLinkResponseCallbackParameters.md)
 - [Model.PaymentLinkResponseCustomersInner](docs/PaymentLinkResponseCustomersInner.md)
 - [Model.PaymentLinkResponseCustomersInnerAccountsInner](docs/PaymentLinkResponseCustomersInnerAccountsInner.md)
 - [Model.PaymentLinkResponseDisplaySettings](docs/PaymentLinkResponseDisplaySettings.md)
 - [Model.PaymentLinkResponseDisplaySettingsIntent](docs/PaymentLinkResponseDisplaySettingsIntent.md)
 - [Model.PaymentLinkResponseLineItemsInner](docs/PaymentLinkResponseLineItemsInner.md)
 - [Model.PaymentLinkResponsePaymentsInner](docs/PaymentLinkResponsePaymentsInner.md)
 - [Model.PaymentLinkResponseReferenceDataListInner](docs/PaymentLinkResponseReferenceDataListInner.md)
 - [Model.PaymentListResponseDTO](docs/PaymentListResponseDTO.md)
 - [Model.PaymentRequest](docs/PaymentRequest.md)
 - [Model.PaymentRequestDetailDTO](docs/PaymentRequestDetailDTO.md)
 - [Model.PaymentRequestDto](docs/PaymentRequestDto.md)
 - [Model.PaymentRequestDtoData](docs/PaymentRequestDtoData.md)
 - [Model.PaymentRequestDtoDataRemittanceData](docs/PaymentRequestDtoDataRemittanceData.md)
 - [Model.PaymentRequestTenderInfo](docs/PaymentRequestTenderInfo.md)
 - [Model.PaymentResponseDto](docs/PaymentResponseDto.md)
 - [Model.PaymentTimeLineRequestDto](docs/PaymentTimeLineRequestDto.md)
 - [Model.QuoteRequest](docs/QuoteRequest.md)
 - [Model.QuoteRequestAgent](docs/QuoteRequestAgent.md)
 - [Model.QuoteRequestAgentAddress](docs/QuoteRequestAgentAddress.md)
 - [Model.QuoteRequestDetails](docs/QuoteRequestDetails.md)
 - [Model.QuoteRequestInsured](docs/QuoteRequestInsured.md)
 - [Model.QuoteRequestInsuredAddress](docs/QuoteRequestInsuredAddress.md)
 - [Model.QuoteRequestPoliciesInner](docs/QuoteRequestPoliciesInner.md)
 - [Model.QuoteRequestPoliciesInnerCompany](docs/QuoteRequestPoliciesInnerCompany.md)
 - [Model.QuoteRequestPoliciesInnerGa](docs/QuoteRequestPoliciesInnerGa.md)
 - [Model.QuoteRequestPoliciesInnerGaAddress](docs/QuoteRequestPoliciesInnerGaAddress.md)
 - [Model.QuoteResponse](docs/QuoteResponse.md)
 - [Model.RefundEligibility](docs/RefundEligibility.md)
 - [Model.RemittanceDataDto](docs/RemittanceDataDto.md)
 - [Model.ReportDownloadRequest](docs/ReportDownloadRequest.md)
 - [Model.RowDto](docs/RowDto.md)
 - [Model.SecureBatchExecuteRequest](docs/SecureBatchExecuteRequest.md)
 - [Model.SecureCancelledTransactionResponse](docs/SecureCancelledTransactionResponse.md)
 - [Model.SecureMerchantTokenShortResponse](docs/SecureMerchantTokenShortResponse.md)
 - [Model.SecurePaymentBatchDetailsRequest](docs/SecurePaymentBatchDetailsRequest.md)
 - [Model.SecurePaymentDetailsRequest](docs/SecurePaymentDetailsRequest.md)
 - [Model.SecurePaymentLinkRequest](docs/SecurePaymentLinkRequest.md)
 - [Model.SecureTokenLinkByIdResponse](docs/SecureTokenLinkByIdResponse.md)
 - [Model.SecureTokenLinkByIdResponseAccountToken](docs/SecureTokenLinkByIdResponseAccountToken.md)
 - [Model.SecureTokenLinkByIdResponseTimeLineInner](docs/SecureTokenLinkByIdResponseTimeLineInner.md)
 - [Model.SecureTokenLinkExpiredResponse](docs/SecureTokenLinkExpiredResponse.md)
 - [Model.SecureTokenLinkRequest](docs/SecureTokenLinkRequest.md)
 - [Model.SecureTokenLinkResponse](docs/SecureTokenLinkResponse.md)
 - [Model.SecureTokenLinkResponseCustomersInner](docs/SecureTokenLinkResponseCustomersInner.md)
 - [Model.SecureTokenLinkResponseIntent](docs/SecureTokenLinkResponseIntent.md)
 - [Model.SecureTokenLinkUpdateRequest](docs/SecureTokenLinkUpdateRequest.md)
 - [Model.SecureTransactionCancelRequest](docs/SecureTransactionCancelRequest.md)
 - [Model.SecureTransactionDetailDTO](docs/SecureTransactionDetailDTO.md)
 - [Model.SecureTransactionDetailDTOTenderInfo](docs/SecureTransactionDetailDTOTenderInfo.md)
 - [Model.SecureTransactionRefundRequest](docs/SecureTransactionRefundRequest.md)
 - [Model.SecureUpdatePaymentLinkRequest](docs/SecureUpdatePaymentLinkRequest.md)
 - [Model.SecureUpdatePaymentLinkRequestSettings](docs/SecureUpdatePaymentLinkRequestSettings.md)
 - [Model.SecureUpdatePaymentLinkRequestSettingsIntent](docs/SecureUpdatePaymentLinkRequestSettingsIntent.md)
 - [Model.SecureVendorRequestDTO](docs/SecureVendorRequestDTO.md)
 - [Model.SecureVendorResponseDTO](docs/SecureVendorResponseDTO.md)
 - [Model.SecureVendorResponseDTORemittanceAddress](docs/SecureVendorResponseDTORemittanceAddress.md)
 - [Model.SecureVendorStatusRequestDTO](docs/SecureVendorStatusRequestDTO.md)
 - [Model.SecureVendorTimelineRequestDTO](docs/SecureVendorTimelineRequestDTO.md)
 - [Model.SecureVendorUpdateRequestDTO](docs/SecureVendorUpdateRequestDTO.md)
 - [Model.SecureVendorUpdateRequestDTORemittanceAddress](docs/SecureVendorUpdateRequestDTORemittanceAddress.md)
 - [Model.TokenLinkResponse](docs/TokenLinkResponse.md)
 - [Model.TokenLinkResponseDataInner](docs/TokenLinkResponseDataInner.md)
 - [Model.TokenLinkSecureRequest](docs/TokenLinkSecureRequest.md)
 - [Model.TokenLinkSecureRequestCustomersInner](docs/TokenLinkSecureRequestCustomersInner.md)
 - [Model.TokenLinkSecureRequestIntent](docs/TokenLinkSecureRequestIntent.md)
 - [Model.TokenRequest](docs/TokenRequest.md)
 - [Model.TransactionDetailResponse](docs/TransactionDetailResponse.md)
 - [Model.TransactionDetailResponseSplitsInner](docs/TransactionDetailResponseSplitsInner.md)
 - [Model.TransactionDetailResponseTenderInfo](docs/TransactionDetailResponseTenderInfo.md)
 - [Model.TransactionPaymentResponse](docs/TransactionPaymentResponse.md)
 - [Model.TransactionPaymentResponseAchTenderInfo](docs/TransactionPaymentResponseAchTenderInfo.md)
 - [Model.TransactionPaymentResponseBillingContact](docs/TransactionPaymentResponseBillingContact.md)
 - [Model.TransactionPaymentResponseBillingContactAddress](docs/TransactionPaymentResponseBillingContactAddress.md)
 - [Model.TransactionPaymentResponseBillingContactName](docs/TransactionPaymentResponseBillingContactName.md)
 - [Model.TransactionPaymentResponseCcTenderInfo](docs/TransactionPaymentResponseCcTenderInfo.md)
 - [Model.TransactionPaymentResponseRefundTransactions](docs/TransactionPaymentResponseRefundTransactions.md)
 - [Model.TransactionPaymentResponseRefundTransactionsDataInner](docs/TransactionPaymentResponseRefundTransactionsDataInner.md)
 - [Model.TransactionPaymentResponseTransactionEntitySplitResponsesInner](docs/TransactionPaymentResponseTransactionEntitySplitResponsesInner.md)
 - [Model.TransactionPaymentResponseTransactionResult](docs/TransactionPaymentResponseTransactionResult.md)
 - [Model.TransactionRefundEligibilityRequest](docs/TransactionRefundEligibilityRequest.md)
 - [Model.UpdateIntentRequest](docs/UpdateIntentRequest.md)
 - [Model.VendorRequestDTO](docs/VendorRequestDTO.md)
 - [Model.VendorRequestDTOPhysicalAddress](docs/VendorRequestDTOPhysicalAddress.md)
 - [Model.VendorRequestDTORemittanceAddress](docs/VendorRequestDTORemittanceAddress.md)
 - [Model.VendorResponseDTO](docs/VendorResponseDTO.md)
 - [Model.VendorResponseDTORemittanceAddress](docs/VendorResponseDTORemittanceAddress.md)
 - [Model.VendorResponseDTOTemplate](docs/VendorResponseDTOTemplate.md)
 - [Model.VendorResponseDTOVerificationResultsInner](docs/VendorResponseDTOVerificationResultsInner.md)
 - [Model.VendorTimelineResponseListInner](docs/VendorTimelineResponseListInner.md)
 - [Model.VerificationEntityRequest](docs/VerificationEntityRequest.md)
 - [Model.VerifyBankAccountRequest](docs/VerifyBankAccountRequest.md)
 - [Model.VerifyBankAccountRequestBankAccountEntity](docs/VerifyBankAccountRequestBankAccountEntity.md)
 - [Model.VerifyBankAccountResponse](docs/VerifyBankAccountResponse.md)
 - [Model.VerifyBankAccountResponseHttpResponse](docs/VerifyBankAccountResponseHttpResponse.md)


</details>

---

## Authorization

Authentication is handled via API keys in HTTP headers:

| Key           | Location | Description             |
| ------------- | -------- | ----------------------- |
| **x-api-key** | Header   | Your API key            |
| **x-app-key** | Header   | Your App key            |
| **x-version** | Header   | API version (e.g., 2.3) |
| **origin**    | Header   | Your public IP address  |

---

## Support & Versioning

* **API Environments:** Use UAT for testing; switch to Production only after validation.
* **Issues:** Report bugs or request features via the [GitHub Issues](https://github.com/anddone-kit/AndDone-SecureAPI-ClientLibrary-DotNet/issues) page.