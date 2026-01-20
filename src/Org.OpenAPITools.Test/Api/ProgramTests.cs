using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;
using System.IO;
using System.Security.Cryptography;

namespace Org.OpenAPITools.Test.Api
{
    public class ProgramTests(ITestOutputHelper output) : IDisposable
    {

        private readonly ITestOutputHelper output = output;

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        [Fact]
        public void Test()
        {
            using StreamReader r = new("C:\\Work\\AndDone_SDKs\\anddone-csharp-sdk-openapi-codegen\\config.json");
            dynamic jsonConfig = JObject.Parse(r.ReadToEnd());

            string xApiKey = jsonConfig.xApiKey;
            string xAppKey = jsonConfig.xAppKey;
            float xVersion = jsonConfig.xVersion;
            string origin = jsonConfig.origin;

            string URL = "https://api.uat.anddone.com";

            Configuration config = new()
            {
                BasePath = URL
            };

            var request = @"{
                ""saveForFuture"": true,
                ""amount"": 10000,
                ""title"": ""test title 001abc"",
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
            var apiInstance = new SecurePaymentIntentApi(config);

            try
            {
                var response = apiInstance.SecurePaymentintentsPostWithHttpInfo(xApiKey, xAppKey, xVersion, origin, postBody);
                output.WriteLine("Response: " + response.RawContent);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SecurePaymentIntentApi: " + e.Message);
            }
        }
    }
}