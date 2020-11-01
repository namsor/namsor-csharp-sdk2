# Org.OpenAPITools.com.namsor.sdk2.api.GeneralApi

All URIs are relative to *https://v2.namsor.com/NamSorAPIv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NameType**](GeneralApi.md#nametype) | **GET** /api2/json/nameType/{properNoun} | Infer the likely type of a proper noun (personal name, brand name, place name etc.)
[**NameType1**](GeneralApi.md#nametype1) | **GET** /api2/json/nameType/{properNoun}/{countryIso2} | Infer the likely type of a proper noun (personal name, brand name, place name etc.)


<a name="nametype"></a>
# **NameType**
> ProperNounCategorizedOut NameType (string properNoun)

Infer the likely type of a proper noun (personal name, brand name, place name etc.)

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class NameTypeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new GeneralApi();
            var properNoun = properNoun_example;  // string | 

            try
            {
                // Infer the likely type of a proper noun (personal name, brand name, place name etc.)
                ProperNounCategorizedOut result = apiInstance.NameType(properNoun);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeneralApi.NameType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **properNoun** | **string**|  | 

### Return type

[**ProperNounCategorizedOut**](ProperNounCategorizedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="nametype1"></a>
# **NameType1**
> ProperNounCategorizedOut NameType1 (string properNoun, string countryIso2)

Infer the likely type of a proper noun (personal name, brand name, place name etc.)

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class NameType1Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new GeneralApi();
            var properNoun = properNoun_example;  // string | 
            var countryIso2 = countryIso2_example;  // string | 

            try
            {
                // Infer the likely type of a proper noun (personal name, brand name, place name etc.)
                ProperNounCategorizedOut result = apiInstance.NameType1(properNoun, countryIso2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeneralApi.NameType1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **properNoun** | **string**|  | 
 **countryIso2** | **string**|  | 

### Return type

[**ProperNounCategorizedOut**](ProperNounCategorizedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

