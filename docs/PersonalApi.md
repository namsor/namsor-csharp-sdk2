# Org.OpenAPITools.com.namsor.sdk2.api.PersonalApi

All URIs are relative to *https://v2.namsor.com/NamSorAPIv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Country**](PersonalApi.md#country) | **GET** /api2/json/country/{personalNameFull} | [USES 10 UNITS] Infer the likely country of residence of a personal full name, or one surname. Assumes names as they are in the country of residence OR the country of origin.
[**CountryBatch**](PersonalApi.md#countrybatch) | **POST** /api2/json/countryBatch | [USES 10 UNITS] Infer the likely country of residence of up to 100 personal full names, or surnames. Assumes names as they are in the country of residence OR the country of origin.
[**Diaspora**](PersonalApi.md#diaspora) | **GET** /api2/json/diaspora/{countryIso2}/{firstName}/{lastName} | [USES 20 UNITS] Infer the likely ethnicity/diaspora of a personal name, given a country of residence ISO2 code (ex. US, CA, AU, NZ etc.)
[**DiasporaBatch**](PersonalApi.md#diasporabatch) | **POST** /api2/json/diasporaBatch | [USES 20 UNITS] Infer the likely ethnicity/diaspora of up to 100 personal names, given a country of residence ISO2 code (ex. US, CA, AU, NZ etc.)
[**Gender**](PersonalApi.md#gender) | **GET** /api2/json/gender/{firstName}/{lastName} | Infer the likely gender of a name.
[**GenderBatch**](PersonalApi.md#genderbatch) | **POST** /api2/json/genderBatch | Infer the likely gender of up to 100 names, detecting automatically the cultural context.
[**GenderFull**](PersonalApi.md#genderfull) | **GET** /api2/json/genderFull/{fullName} | Infer the likely gender of a full name, ex. John H. Smith
[**GenderFullBatch**](PersonalApi.md#genderfullbatch) | **POST** /api2/json/genderFullBatch | Infer the likely gender of up to 100 full names, detecting automatically the cultural context.
[**GenderFullGeo**](PersonalApi.md#genderfullgeo) | **GET** /api2/json/genderFullGeo/{fullName}/{countryIso2} | Infer the likely gender of a full name, given a local context (ISO2 country code).
[**GenderFullGeoBatch**](PersonalApi.md#genderfullgeobatch) | **POST** /api2/json/genderFullGeoBatch | Infer the likely gender of up to 100 full names, with a given cultural context (country ISO2 code).
[**GenderGeo**](PersonalApi.md#gendergeo) | **GET** /api2/json/genderGeo/{firstName}/{lastName}/{countryIso2} | Infer the likely gender of a name, given a local context (ISO2 country code).
[**GenderGeoBatch**](PersonalApi.md#gendergeobatch) | **POST** /api2/json/genderGeoBatch | Infer the likely gender of up to 100 names, each given a local context (ISO2 country code).
[**Origin**](PersonalApi.md#origin) | **GET** /api2/json/origin/{firstName}/{lastName} | [USES 10 UNITS] Infer the likely country of origin of a personal name. Assumes names as they are in the country of origin. For US, CA, AU, NZ and other melting-pots : use &#39;diaspora&#39; instead.
[**OriginBatch**](PersonalApi.md#originbatch) | **POST** /api2/json/originBatch | [USES 10 UNITS] Infer the likely country of origin of up to 100 names, detecting automatically the cultural context.
[**ParseName**](PersonalApi.md#parsename) | **GET** /api2/json/parseName/{nameFull} | Infer the likely first/last name structure of a name, ex. John Smith or SMITH, John or SMITH; John. 
[**ParseNameBatch**](PersonalApi.md#parsenamebatch) | **POST** /api2/json/parseNameBatch | Infer the likely first/last name structure of a name, ex. John Smith or SMITH, John or SMITH; John.
[**ParseNameGeo**](PersonalApi.md#parsenamegeo) | **GET** /api2/json/parseName/{nameFull}/{countryIso2} | Infer the likely first/last name structure of a name, ex. John Smith or SMITH, John or SMITH; John. For better accuracy, provide a geographic context.
[**ParseNameGeoBatch**](PersonalApi.md#parsenamegeobatch) | **POST** /api2/json/parseNameGeoBatch | Infer the likely first/last name structure of a name, ex. John Smith or SMITH, John or SMITH; John. Giving a local context improves precision. 
[**ParsedGenderBatch**](PersonalApi.md#parsedgenderbatch) | **POST** /api2/json/parsedGenderBatch | Infer the likely gender of up to 100 fully parsed names, detecting automatically the cultural context.
[**ParsedGenderGeoBatch**](PersonalApi.md#parsedgendergeobatch) | **POST** /api2/json/parsedGenderGeoBatch | Infer the likely gender of up to 100 fully parsed names, detecting automatically the cultural context.
[**UsRaceEthnicity**](PersonalApi.md#usraceethnicity) | **GET** /api2/json/usRaceEthnicity/{firstName}/{lastName} | [USES 10 UNITS] Infer a US resident&#39;s likely race/ethnicity according to US Census taxonomy W_NL (white, non latino), HL (hispano latino),  A (asian, non latino), B_NL (black, non latino).
[**UsRaceEthnicityBatch**](PersonalApi.md#usraceethnicitybatch) | **POST** /api2/json/usRaceEthnicityBatch | [USES 10 UNITS] Infer up-to 100 US resident&#39;s likely race/ethnicity according to US Census taxonomy.
[**UsRaceEthnicityZIP5**](PersonalApi.md#usraceethnicityzip5) | **GET** /api2/json/usRaceEthnicityZIP5/{firstName}/{lastName}/{zip5Code} | [USES 10 UNITS] Infer a US resident&#39;s likely race/ethnicity according to US Census taxonomy, using (optional) ZIP5 code info. Output is W_NL (white, non latino), HL (hispano latino),  A (asian, non latino), B_NL (black, non latino).
[**UsZipRaceEthnicityBatch**](PersonalApi.md#uszipraceethnicitybatch) | **POST** /api2/json/usZipRaceEthnicityBatch | [USES 10 UNITS] Infer up-to 100 US resident&#39;s likely race/ethnicity according to US Census taxonomy, with (optional) ZIP code.


<a name="country"></a>
# **Country**
> PersonalNameGeoOut Country (string personalNameFull)

[USES 10 UNITS] Infer the likely country of residence of a personal full name, or one surname. Assumes names as they are in the country of residence OR the country of origin.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class CountryExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var personalNameFull = personalNameFull_example;  // string | 

            try
            {
                // [USES 10 UNITS] Infer the likely country of residence of a personal full name, or one surname. Assumes names as they are in the country of residence OR the country of origin.
                PersonalNameGeoOut result = apiInstance.Country(personalNameFull);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.Country: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personalNameFull** | **string**|  | 

### Return type

[**PersonalNameGeoOut**](PersonalNameGeoOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="countrybatch"></a>
# **CountryBatch**
> BatchPersonalNameGeoOut CountryBatch (BatchPersonalNameIn batchPersonalNameIn = null)

[USES 10 UNITS] Infer the likely country of residence of up to 100 personal full names, or surnames. Assumes names as they are in the country of residence OR the country of origin.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class CountryBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var batchPersonalNameIn = new BatchPersonalNameIn(); // BatchPersonalNameIn | A list of personal names (optional) 

            try
            {
                // [USES 10 UNITS] Infer the likely country of residence of up to 100 personal full names, or surnames. Assumes names as they are in the country of residence OR the country of origin.
                BatchPersonalNameGeoOut result = apiInstance.CountryBatch(batchPersonalNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.CountryBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchPersonalNameIn** | [**BatchPersonalNameIn**](BatchPersonalNameIn.md)| A list of personal names | [optional] 

### Return type

[**BatchPersonalNameGeoOut**](BatchPersonalNameGeoOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="diaspora"></a>
# **Diaspora**
> FirstLastNameDiasporaedOut Diaspora (string countryIso2, string firstName, string lastName)

[USES 20 UNITS] Infer the likely ethnicity/diaspora of a personal name, given a country of residence ISO2 code (ex. US, CA, AU, NZ etc.)

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class DiasporaExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var countryIso2 = countryIso2_example;  // string | 
            var firstName = firstName_example;  // string | 
            var lastName = lastName_example;  // string | 

            try
            {
                // [USES 20 UNITS] Infer the likely ethnicity/diaspora of a personal name, given a country of residence ISO2 code (ex. US, CA, AU, NZ etc.)
                FirstLastNameDiasporaedOut result = apiInstance.Diaspora(countryIso2, firstName, lastName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.Diaspora: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryIso2** | **string**|  | 
 **firstName** | **string**|  | 
 **lastName** | **string**|  | 

### Return type

[**FirstLastNameDiasporaedOut**](FirstLastNameDiasporaedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="diasporabatch"></a>
# **DiasporaBatch**
> BatchFirstLastNameDiasporaedOut DiasporaBatch (BatchFirstLastNameGeoIn batchFirstLastNameGeoIn = null)

[USES 20 UNITS] Infer the likely ethnicity/diaspora of up to 100 personal names, given a country of residence ISO2 code (ex. US, CA, AU, NZ etc.)

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class DiasporaBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var batchFirstLastNameGeoIn = new BatchFirstLastNameGeoIn(); // BatchFirstLastNameGeoIn | A list of personal names (optional) 

            try
            {
                // [USES 20 UNITS] Infer the likely ethnicity/diaspora of up to 100 personal names, given a country of residence ISO2 code (ex. US, CA, AU, NZ etc.)
                BatchFirstLastNameDiasporaedOut result = apiInstance.DiasporaBatch(batchFirstLastNameGeoIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.DiasporaBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchFirstLastNameGeoIn** | [**BatchFirstLastNameGeoIn**](BatchFirstLastNameGeoIn.md)| A list of personal names | [optional] 

### Return type

[**BatchFirstLastNameDiasporaedOut**](BatchFirstLastNameDiasporaedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gender"></a>
# **Gender**
> FirstLastNameGenderedOut Gender (string firstName, string lastName)

Infer the likely gender of a name.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class GenderExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var firstName = firstName_example;  // string | 
            var lastName = lastName_example;  // string | 

            try
            {
                // Infer the likely gender of a name.
                FirstLastNameGenderedOut result = apiInstance.Gender(firstName, lastName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.Gender: " + e.Message );
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

### Return type

[**FirstLastNameGenderedOut**](FirstLastNameGenderedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="genderbatch"></a>
# **GenderBatch**
> BatchFirstLastNameGenderedOut GenderBatch (BatchFirstLastNameIn batchFirstLastNameIn = null)

Infer the likely gender of up to 100 names, detecting automatically the cultural context.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class GenderBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var batchFirstLastNameIn = new BatchFirstLastNameIn(); // BatchFirstLastNameIn | A list of personal names (optional) 

            try
            {
                // Infer the likely gender of up to 100 names, detecting automatically the cultural context.
                BatchFirstLastNameGenderedOut result = apiInstance.GenderBatch(batchFirstLastNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.GenderBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchFirstLastNameIn** | [**BatchFirstLastNameIn**](BatchFirstLastNameIn.md)| A list of personal names | [optional] 

### Return type

[**BatchFirstLastNameGenderedOut**](BatchFirstLastNameGenderedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="genderfull"></a>
# **GenderFull**
> FirstLastNameGenderedOut GenderFull (string fullName)

Infer the likely gender of a full name, ex. John H. Smith

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class GenderFullExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var fullName = fullName_example;  // string | 

            try
            {
                // Infer the likely gender of a full name, ex. John H. Smith
                FirstLastNameGenderedOut result = apiInstance.GenderFull(fullName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.GenderFull: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fullName** | **string**|  | 

### Return type

[**FirstLastNameGenderedOut**](FirstLastNameGenderedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="genderfullbatch"></a>
# **GenderFullBatch**
> BatchPersonalNameGenderedOut GenderFullBatch (BatchPersonalNameIn batchPersonalNameIn = null)

Infer the likely gender of up to 100 full names, detecting automatically the cultural context.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class GenderFullBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var batchPersonalNameIn = new BatchPersonalNameIn(); // BatchPersonalNameIn | A list of personal names (optional) 

            try
            {
                // Infer the likely gender of up to 100 full names, detecting automatically the cultural context.
                BatchPersonalNameGenderedOut result = apiInstance.GenderFullBatch(batchPersonalNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.GenderFullBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchPersonalNameIn** | [**BatchPersonalNameIn**](BatchPersonalNameIn.md)| A list of personal names | [optional] 

### Return type

[**BatchPersonalNameGenderedOut**](BatchPersonalNameGenderedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="genderfullgeo"></a>
# **GenderFullGeo**
> FirstLastNameGenderedOut GenderFullGeo (string fullName, string countryIso2)

Infer the likely gender of a full name, given a local context (ISO2 country code).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class GenderFullGeoExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var fullName = fullName_example;  // string | 
            var countryIso2 = countryIso2_example;  // string | 

            try
            {
                // Infer the likely gender of a full name, given a local context (ISO2 country code).
                FirstLastNameGenderedOut result = apiInstance.GenderFullGeo(fullName, countryIso2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.GenderFullGeo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fullName** | **string**|  | 
 **countryIso2** | **string**|  | 

### Return type

[**FirstLastNameGenderedOut**](FirstLastNameGenderedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="genderfullgeobatch"></a>
# **GenderFullGeoBatch**
> BatchPersonalNameGenderedOut GenderFullGeoBatch (BatchPersonalNameGeoIn batchPersonalNameGeoIn = null)

Infer the likely gender of up to 100 full names, with a given cultural context (country ISO2 code).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class GenderFullGeoBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var batchPersonalNameGeoIn = new BatchPersonalNameGeoIn(); // BatchPersonalNameGeoIn | A list of personal names, with a country ISO2 code (optional) 

            try
            {
                // Infer the likely gender of up to 100 full names, with a given cultural context (country ISO2 code).
                BatchPersonalNameGenderedOut result = apiInstance.GenderFullGeoBatch(batchPersonalNameGeoIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.GenderFullGeoBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchPersonalNameGeoIn** | [**BatchPersonalNameGeoIn**](BatchPersonalNameGeoIn.md)| A list of personal names, with a country ISO2 code | [optional] 

### Return type

[**BatchPersonalNameGenderedOut**](BatchPersonalNameGenderedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gendergeo"></a>
# **GenderGeo**
> FirstLastNameGenderedOut GenderGeo (string firstName, string lastName, string countryIso2)

Infer the likely gender of a name, given a local context (ISO2 country code).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class GenderGeoExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var firstName = firstName_example;  // string | 
            var lastName = lastName_example;  // string | 
            var countryIso2 = countryIso2_example;  // string | 

            try
            {
                // Infer the likely gender of a name, given a local context (ISO2 country code).
                FirstLastNameGenderedOut result = apiInstance.GenderGeo(firstName, lastName, countryIso2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.GenderGeo: " + e.Message );
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
 **countryIso2** | **string**|  | 

### Return type

[**FirstLastNameGenderedOut**](FirstLastNameGenderedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gendergeobatch"></a>
# **GenderGeoBatch**
> BatchFirstLastNameGenderedOut GenderGeoBatch (BatchFirstLastNameGeoIn batchFirstLastNameGeoIn = null)

Infer the likely gender of up to 100 names, each given a local context (ISO2 country code).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class GenderGeoBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var batchFirstLastNameGeoIn = new BatchFirstLastNameGeoIn(); // BatchFirstLastNameGeoIn | A list of names, with country code. (optional) 

            try
            {
                // Infer the likely gender of up to 100 names, each given a local context (ISO2 country code).
                BatchFirstLastNameGenderedOut result = apiInstance.GenderGeoBatch(batchFirstLastNameGeoIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.GenderGeoBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchFirstLastNameGeoIn** | [**BatchFirstLastNameGeoIn**](BatchFirstLastNameGeoIn.md)| A list of names, with country code. | [optional] 

### Return type

[**BatchFirstLastNameGenderedOut**](BatchFirstLastNameGenderedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="origin"></a>
# **Origin**
> FirstLastNameOriginedOut Origin (string firstName, string lastName)

[USES 10 UNITS] Infer the likely country of origin of a personal name. Assumes names as they are in the country of origin. For US, CA, AU, NZ and other melting-pots : use 'diaspora' instead.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class OriginExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var firstName = firstName_example;  // string | 
            var lastName = lastName_example;  // string | 

            try
            {
                // [USES 10 UNITS] Infer the likely country of origin of a personal name. Assumes names as they are in the country of origin. For US, CA, AU, NZ and other melting-pots : use 'diaspora' instead.
                FirstLastNameOriginedOut result = apiInstance.Origin(firstName, lastName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.Origin: " + e.Message );
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

### Return type

[**FirstLastNameOriginedOut**](FirstLastNameOriginedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="originbatch"></a>
# **OriginBatch**
> BatchFirstLastNameOriginedOut OriginBatch (BatchFirstLastNameIn batchFirstLastNameIn = null)

[USES 10 UNITS] Infer the likely country of origin of up to 100 names, detecting automatically the cultural context.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class OriginBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var batchFirstLastNameIn = new BatchFirstLastNameIn(); // BatchFirstLastNameIn | A list of personal names (optional) 

            try
            {
                // [USES 10 UNITS] Infer the likely country of origin of up to 100 names, detecting automatically the cultural context.
                BatchFirstLastNameOriginedOut result = apiInstance.OriginBatch(batchFirstLastNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.OriginBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchFirstLastNameIn** | [**BatchFirstLastNameIn**](BatchFirstLastNameIn.md)| A list of personal names | [optional] 

### Return type

[**BatchFirstLastNameOriginedOut**](BatchFirstLastNameOriginedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="parsename"></a>
# **ParseName**
> PersonalNameParsedOut ParseName (string nameFull)

Infer the likely first/last name structure of a name, ex. John Smith or SMITH, John or SMITH; John. 

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class ParseNameExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var nameFull = nameFull_example;  // string | 

            try
            {
                // Infer the likely first/last name structure of a name, ex. John Smith or SMITH, John or SMITH; John. 
                PersonalNameParsedOut result = apiInstance.ParseName(nameFull);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.ParseName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nameFull** | **string**|  | 

### Return type

[**PersonalNameParsedOut**](PersonalNameParsedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="parsenamebatch"></a>
# **ParseNameBatch**
> BatchPersonalNameParsedOut ParseNameBatch (BatchPersonalNameIn batchPersonalNameIn = null)

Infer the likely first/last name structure of a name, ex. John Smith or SMITH, John or SMITH; John.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class ParseNameBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var batchPersonalNameIn = new BatchPersonalNameIn(); // BatchPersonalNameIn | A list of personal names (optional) 

            try
            {
                // Infer the likely first/last name structure of a name, ex. John Smith or SMITH, John or SMITH; John.
                BatchPersonalNameParsedOut result = apiInstance.ParseNameBatch(batchPersonalNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.ParseNameBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchPersonalNameIn** | [**BatchPersonalNameIn**](BatchPersonalNameIn.md)| A list of personal names | [optional] 

### Return type

[**BatchPersonalNameParsedOut**](BatchPersonalNameParsedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="parsenamegeo"></a>
# **ParseNameGeo**
> PersonalNameParsedOut ParseNameGeo (string nameFull, string countryIso2)

Infer the likely first/last name structure of a name, ex. John Smith or SMITH, John or SMITH; John. For better accuracy, provide a geographic context.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class ParseNameGeoExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var nameFull = nameFull_example;  // string | 
            var countryIso2 = countryIso2_example;  // string | 

            try
            {
                // Infer the likely first/last name structure of a name, ex. John Smith or SMITH, John or SMITH; John. For better accuracy, provide a geographic context.
                PersonalNameParsedOut result = apiInstance.ParseNameGeo(nameFull, countryIso2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.ParseNameGeo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nameFull** | **string**|  | 
 **countryIso2** | **string**|  | 

### Return type

[**PersonalNameParsedOut**](PersonalNameParsedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="parsenamegeobatch"></a>
# **ParseNameGeoBatch**
> BatchPersonalNameParsedOut ParseNameGeoBatch (BatchPersonalNameGeoIn batchPersonalNameGeoIn = null)

Infer the likely first/last name structure of a name, ex. John Smith or SMITH, John or SMITH; John. Giving a local context improves precision. 

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class ParseNameGeoBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var batchPersonalNameGeoIn = new BatchPersonalNameGeoIn(); // BatchPersonalNameGeoIn | A list of personal names (optional) 

            try
            {
                // Infer the likely first/last name structure of a name, ex. John Smith or SMITH, John or SMITH; John. Giving a local context improves precision. 
                BatchPersonalNameParsedOut result = apiInstance.ParseNameGeoBatch(batchPersonalNameGeoIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.ParseNameGeoBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchPersonalNameGeoIn** | [**BatchPersonalNameGeoIn**](BatchPersonalNameGeoIn.md)| A list of personal names | [optional] 

### Return type

[**BatchPersonalNameParsedOut**](BatchPersonalNameParsedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="parsedgenderbatch"></a>
# **ParsedGenderBatch**
> BatchFirstLastNameGenderedOut ParsedGenderBatch (BatchParsedFullNameIn batchParsedFullNameIn = null)

Infer the likely gender of up to 100 fully parsed names, detecting automatically the cultural context.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class ParsedGenderBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var batchParsedFullNameIn = new BatchParsedFullNameIn(); // BatchParsedFullNameIn | A list of personal names (optional) 

            try
            {
                // Infer the likely gender of up to 100 fully parsed names, detecting automatically the cultural context.
                BatchFirstLastNameGenderedOut result = apiInstance.ParsedGenderBatch(batchParsedFullNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.ParsedGenderBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchParsedFullNameIn** | [**BatchParsedFullNameIn**](BatchParsedFullNameIn.md)| A list of personal names | [optional] 

### Return type

[**BatchFirstLastNameGenderedOut**](BatchFirstLastNameGenderedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="parsedgendergeobatch"></a>
# **ParsedGenderGeoBatch**
> BatchFirstLastNameGenderedOut ParsedGenderGeoBatch (BatchParsedFullNameGeoIn batchParsedFullNameGeoIn = null)

Infer the likely gender of up to 100 fully parsed names, detecting automatically the cultural context.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class ParsedGenderGeoBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var batchParsedFullNameGeoIn = new BatchParsedFullNameGeoIn(); // BatchParsedFullNameGeoIn | A list of personal names (optional) 

            try
            {
                // Infer the likely gender of up to 100 fully parsed names, detecting automatically the cultural context.
                BatchFirstLastNameGenderedOut result = apiInstance.ParsedGenderGeoBatch(batchParsedFullNameGeoIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.ParsedGenderGeoBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchParsedFullNameGeoIn** | [**BatchParsedFullNameGeoIn**](BatchParsedFullNameGeoIn.md)| A list of personal names | [optional] 

### Return type

[**BatchFirstLastNameGenderedOut**](BatchFirstLastNameGenderedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usraceethnicity"></a>
# **UsRaceEthnicity**
> FirstLastNameUSRaceEthnicityOut UsRaceEthnicity (string firstName, string lastName)

[USES 10 UNITS] Infer a US resident's likely race/ethnicity according to US Census taxonomy W_NL (white, non latino), HL (hispano latino),  A (asian, non latino), B_NL (black, non latino).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class UsRaceEthnicityExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var firstName = firstName_example;  // string | 
            var lastName = lastName_example;  // string | 

            try
            {
                // [USES 10 UNITS] Infer a US resident's likely race/ethnicity according to US Census taxonomy W_NL (white, non latino), HL (hispano latino),  A (asian, non latino), B_NL (black, non latino).
                FirstLastNameUSRaceEthnicityOut result = apiInstance.UsRaceEthnicity(firstName, lastName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.UsRaceEthnicity: " + e.Message );
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

### Return type

[**FirstLastNameUSRaceEthnicityOut**](FirstLastNameUSRaceEthnicityOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usraceethnicitybatch"></a>
# **UsRaceEthnicityBatch**
> BatchFirstLastNameUSRaceEthnicityOut UsRaceEthnicityBatch (BatchFirstLastNameGeoIn batchFirstLastNameGeoIn = null)

[USES 10 UNITS] Infer up-to 100 US resident's likely race/ethnicity according to US Census taxonomy.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class UsRaceEthnicityBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var batchFirstLastNameGeoIn = new BatchFirstLastNameGeoIn(); // BatchFirstLastNameGeoIn | A list of personal names (optional) 

            try
            {
                // [USES 10 UNITS] Infer up-to 100 US resident's likely race/ethnicity according to US Census taxonomy.
                BatchFirstLastNameUSRaceEthnicityOut result = apiInstance.UsRaceEthnicityBatch(batchFirstLastNameGeoIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.UsRaceEthnicityBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchFirstLastNameGeoIn** | [**BatchFirstLastNameGeoIn**](BatchFirstLastNameGeoIn.md)| A list of personal names | [optional] 

### Return type

[**BatchFirstLastNameUSRaceEthnicityOut**](BatchFirstLastNameUSRaceEthnicityOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usraceethnicityzip5"></a>
# **UsRaceEthnicityZIP5**
> FirstLastNameUSRaceEthnicityOut UsRaceEthnicityZIP5 (string firstName, string lastName, string zip5Code)

[USES 10 UNITS] Infer a US resident's likely race/ethnicity according to US Census taxonomy, using (optional) ZIP5 code info. Output is W_NL (white, non latino), HL (hispano latino),  A (asian, non latino), B_NL (black, non latino).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class UsRaceEthnicityZIP5Example
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var firstName = firstName_example;  // string | 
            var lastName = lastName_example;  // string | 
            var zip5Code = zip5Code_example;  // string | 

            try
            {
                // [USES 10 UNITS] Infer a US resident's likely race/ethnicity according to US Census taxonomy, using (optional) ZIP5 code info. Output is W_NL (white, non latino), HL (hispano latino),  A (asian, non latino), B_NL (black, non latino).
                FirstLastNameUSRaceEthnicityOut result = apiInstance.UsRaceEthnicityZIP5(firstName, lastName, zip5Code);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.UsRaceEthnicityZIP5: " + e.Message );
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
 **zip5Code** | **string**|  | 

### Return type

[**FirstLastNameUSRaceEthnicityOut**](FirstLastNameUSRaceEthnicityOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uszipraceethnicitybatch"></a>
# **UsZipRaceEthnicityBatch**
> BatchFirstLastNameUSRaceEthnicityOut UsZipRaceEthnicityBatch (BatchFirstLastNameGeoZippedIn batchFirstLastNameGeoZippedIn = null)

[USES 10 UNITS] Infer up-to 100 US resident's likely race/ethnicity according to US Census taxonomy, with (optional) ZIP code.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class UsZipRaceEthnicityBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new PersonalApi();
            var batchFirstLastNameGeoZippedIn = new BatchFirstLastNameGeoZippedIn(); // BatchFirstLastNameGeoZippedIn | A list of personal names (optional) 

            try
            {
                // [USES 10 UNITS] Infer up-to 100 US resident's likely race/ethnicity according to US Census taxonomy, with (optional) ZIP code.
                BatchFirstLastNameUSRaceEthnicityOut result = apiInstance.UsZipRaceEthnicityBatch(batchFirstLastNameGeoZippedIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalApi.UsZipRaceEthnicityBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchFirstLastNameGeoZippedIn** | [**BatchFirstLastNameGeoZippedIn**](BatchFirstLastNameGeoZippedIn.md)| A list of personal names | [optional] 

### Return type

[**BatchFirstLastNameUSRaceEthnicityOut**](BatchFirstLastNameUSRaceEthnicityOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

