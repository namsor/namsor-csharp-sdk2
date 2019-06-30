# Org.OpenAPITools.com.namsor.sdk2.api.SocialApi

All URIs are relative to *https://v2.namsor.com/NamSorAPIv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PhoneCode**](SocialApi.md#phonecode) | **GET** /api2/json/phoneCode/{firstName}/{lastName}/{phoneNumber} | [USES 11 UNITS] Infer the likely country and phone prefix, given a personal name and formatted / unformatted phone number.
[**PhoneCodeBatch**](SocialApi.md#phonecodebatch) | **POST** /api2/json/phoneCodeBatch | [USES 11 UNITS] Infer the likely country and phone prefix, of up to 100 personal names, detecting automatically the local context given a name and formatted / unformatted phone number.
[**PhoneCodeGeo**](SocialApi.md#phonecodegeo) | **GET** /api2/json/phoneCodeGeo/{firstName}/{lastName}/{phoneNumber}/{countryIso2} | [USES 11 UNITS] Infer the likely phone prefix, given a personal name and formatted / unformatted phone number, with a local context (ISO2 country of residence).
[**PhoneCodeGeoBatch**](SocialApi.md#phonecodegeobatch) | **POST** /api2/json/phoneCodeGeoBatch | [USES 11 UNITS] Infer the likely country and phone prefix, of up to 100 personal names, with a local context (ISO2 country of residence).
[**PhoneCodeGeoFeedbackLoop**](SocialApi.md#phonecodegeofeedbackloop) | **GET** /api2/json/phoneCodeGeoFeedbackLoop/{firstName}/{lastName}/{phoneNumber}/{phoneNumberE164}/{countryIso2} | [CREDITS 1 UNIT] Feedback loop to better infer the likely phone prefix, given a personal name and formatted / unformatted phone number, with a local context (ISO2 country of residence).


<a name="phonecode"></a>
# **PhoneCode**
> FirstLastNamePhoneCodedOut PhoneCode (string firstName, string lastName, string phoneNumber)

[USES 11 UNITS] Infer the likely country and phone prefix, given a personal name and formatted / unformatted phone number.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class PhoneCodeExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new SocialApi();
            var firstName = firstName_example;  // string | 
            var lastName = lastName_example;  // string | 
            var phoneNumber = phoneNumber_example;  // string | 

            try
            {
                // [USES 11 UNITS] Infer the likely country and phone prefix, given a personal name and formatted / unformatted phone number.
                FirstLastNamePhoneCodedOut result = apiInstance.PhoneCode(firstName, lastName, phoneNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.PhoneCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **firstName** | **string**|  | 
 **lastName** | **string**|  | 
 **phoneNumber** | **string**|  | 

### Return type

[**FirstLastNamePhoneCodedOut**](FirstLastNamePhoneCodedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="phonecodebatch"></a>
# **PhoneCodeBatch**
> BatchFirstLastNamePhoneCodedOut PhoneCodeBatch (BatchFirstLastNamePhoneNumberIn batchFirstLastNamePhoneNumberIn = null)

[USES 11 UNITS] Infer the likely country and phone prefix, of up to 100 personal names, detecting automatically the local context given a name and formatted / unformatted phone number.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class PhoneCodeBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new SocialApi();
            var batchFirstLastNamePhoneNumberIn = new BatchFirstLastNamePhoneNumberIn(); // BatchFirstLastNamePhoneNumberIn | A list of personal names (optional) 

            try
            {
                // [USES 11 UNITS] Infer the likely country and phone prefix, of up to 100 personal names, detecting automatically the local context given a name and formatted / unformatted phone number.
                BatchFirstLastNamePhoneCodedOut result = apiInstance.PhoneCodeBatch(batchFirstLastNamePhoneNumberIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.PhoneCodeBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchFirstLastNamePhoneNumberIn** | [**BatchFirstLastNamePhoneNumberIn**](BatchFirstLastNamePhoneNumberIn.md)| A list of personal names | [optional] 

### Return type

[**BatchFirstLastNamePhoneCodedOut**](BatchFirstLastNamePhoneCodedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="phonecodegeo"></a>
# **PhoneCodeGeo**
> FirstLastNamePhoneCodedOut PhoneCodeGeo (string firstName, string lastName, string phoneNumber, string countryIso2)

[USES 11 UNITS] Infer the likely phone prefix, given a personal name and formatted / unformatted phone number, with a local context (ISO2 country of residence).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class PhoneCodeGeoExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new SocialApi();
            var firstName = firstName_example;  // string | 
            var lastName = lastName_example;  // string | 
            var phoneNumber = phoneNumber_example;  // string | 
            var countryIso2 = countryIso2_example;  // string | 

            try
            {
                // [USES 11 UNITS] Infer the likely phone prefix, given a personal name and formatted / unformatted phone number, with a local context (ISO2 country of residence).
                FirstLastNamePhoneCodedOut result = apiInstance.PhoneCodeGeo(firstName, lastName, phoneNumber, countryIso2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.PhoneCodeGeo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **firstName** | **string**|  | 
 **lastName** | **string**|  | 
 **phoneNumber** | **string**|  | 
 **countryIso2** | **string**|  | 

### Return type

[**FirstLastNamePhoneCodedOut**](FirstLastNamePhoneCodedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="phonecodegeobatch"></a>
# **PhoneCodeGeoBatch**
> BatchFirstLastNamePhoneCodedOut PhoneCodeGeoBatch (BatchFirstLastNamePhoneNumberGeoIn batchFirstLastNamePhoneNumberGeoIn = null)

[USES 11 UNITS] Infer the likely country and phone prefix, of up to 100 personal names, with a local context (ISO2 country of residence).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class PhoneCodeGeoBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new SocialApi();
            var batchFirstLastNamePhoneNumberGeoIn = new BatchFirstLastNamePhoneNumberGeoIn(); // BatchFirstLastNamePhoneNumberGeoIn | A list of personal names (optional) 

            try
            {
                // [USES 11 UNITS] Infer the likely country and phone prefix, of up to 100 personal names, with a local context (ISO2 country of residence).
                BatchFirstLastNamePhoneCodedOut result = apiInstance.PhoneCodeGeoBatch(batchFirstLastNamePhoneNumberGeoIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.PhoneCodeGeoBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchFirstLastNamePhoneNumberGeoIn** | [**BatchFirstLastNamePhoneNumberGeoIn**](BatchFirstLastNamePhoneNumberGeoIn.md)| A list of personal names | [optional] 

### Return type

[**BatchFirstLastNamePhoneCodedOut**](BatchFirstLastNamePhoneCodedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="phonecodegeofeedbackloop"></a>
# **PhoneCodeGeoFeedbackLoop**
> FirstLastNamePhoneCodedOut PhoneCodeGeoFeedbackLoop (string firstName, string lastName, string phoneNumber, string phoneNumberE164, string countryIso2)

[CREDITS 1 UNIT] Feedback loop to better infer the likely phone prefix, given a personal name and formatted / unformatted phone number, with a local context (ISO2 country of residence).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class PhoneCodeGeoFeedbackLoopExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new SocialApi();
            var firstName = firstName_example;  // string | 
            var lastName = lastName_example;  // string | 
            var phoneNumber = phoneNumber_example;  // string | 
            var phoneNumberE164 = phoneNumberE164_example;  // string | 
            var countryIso2 = countryIso2_example;  // string | 

            try
            {
                // [CREDITS 1 UNIT] Feedback loop to better infer the likely phone prefix, given a personal name and formatted / unformatted phone number, with a local context (ISO2 country of residence).
                FirstLastNamePhoneCodedOut result = apiInstance.PhoneCodeGeoFeedbackLoop(firstName, lastName, phoneNumber, phoneNumberE164, countryIso2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.PhoneCodeGeoFeedbackLoop: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **firstName** | **string**|  | 
 **lastName** | **string**|  | 
 **phoneNumber** | **string**|  | 
 **phoneNumberE164** | **string**|  | 
 **countryIso2** | **string**|  | 

### Return type

[**FirstLastNamePhoneCodedOut**](FirstLastNamePhoneCodedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

