# Org.OpenAPITools.com.namsor.sdk2.api.ChineseApi

All URIs are relative to *https://v2.namsor.com/NamSorAPIv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChineseNameCandidates**](ChineseApi.md#chinesenamecandidates) | **GET** /api2/json/chineseNameCandidates/{chineseSurnameLatin}/{chineseGivenNameLatin} | Identify Chinese name candidates, based on the romanized name ex. Wang Xiaoming
[**ChineseNameCandidatesBatch**](ChineseApi.md#chinesenamecandidatesbatch) | **POST** /api2/json/chineseNameCandidatesBatch | Identify Chinese name candidates, based on the romanized name (firstName &#x3D; chineseGivenName; lastName&#x3D;chineseSurname), ex. Wang Xiaoming
[**ChineseNameCandidatesGenderBatch**](ChineseApi.md#chinesenamecandidatesgenderbatch) | **POST** /api2/json/chineseNameCandidatesGenderBatch | Identify Chinese name candidates, based on the romanized name (firstName &#x3D; chineseGivenName; lastName&#x3D;chineseSurname) ex. Wang Xiaoming.
[**ChineseNameGenderCandidates**](ChineseApi.md#chinesenamegendercandidates) | **GET** /api2/json/chineseNameGenderCandidates/{chineseSurnameLatin}/{chineseGivenNameLatin}/{knownGender} | Identify Chinese name candidates, based on the romanized name ex. Wang Xiaoming - having a known gender (&#39;male&#39; or &#39;female&#39;)
[**ChineseNameMatch**](ChineseApi.md#chinesenamematch) | **GET** /api2/json/chineseNameMatch/{chineseSurnameLatin}/{chineseGivenNameLatin}/{chineseName} | Return a score for matching Chinese name ex. 王晓明 with a romanized name ex. Wang Xiaoming
[**ChineseNameMatchBatch**](ChineseApi.md#chinesenamematchbatch) | **POST** /api2/json/chineseNameMatchBatch | Identify Chinese name candidates, based on the romanized name (firstName &#x3D; chineseGivenName; lastName&#x3D;chineseSurname), ex. Wang Xiaoming
[**GenderChineseName**](ChineseApi.md#genderchinesename) | **GET** /api2/json/genderChineseName/{chineseName} | Infer the likely gender of a Chinese full name ex. 王晓明
[**GenderChineseNameBatch**](ChineseApi.md#genderchinesenamebatch) | **POST** /api2/json/genderChineseNameBatch | Infer the likely gender of up to 100 full names ex. 王晓明
[**GenderChineseNamePinyin**](ChineseApi.md#genderchinesenamepinyin) | **GET** /api2/json/genderChineseNamePinyin/{chineseSurnameLatin}/{chineseGivenNameLatin} | Infer the likely gender of a Chinese name in LATIN (Pinyin).
[**GenderChineseNamePinyinBatch**](ChineseApi.md#genderchinesenamepinyinbatch) | **POST** /api2/json/genderChineseNamePinyinBatch | Infer the likely gender of up to 100 Chinese names in LATIN (Pinyin).
[**ParseChineseName**](ChineseApi.md#parsechinesename) | **GET** /api2/json/parseChineseName/{chineseName} | Infer the likely first/last name structure of a name, ex. 王晓明 -&gt; 王(surname) 晓明(given name)
[**ParseChineseNameBatch**](ChineseApi.md#parsechinesenamebatch) | **POST** /api2/json/parseChineseNameBatch | Infer the likely first/last name structure of a name, ex. 王晓明 -&gt; 王(surname) 晓明(given name).
[**PinyinChineseName**](ChineseApi.md#pinyinchinesename) | **GET** /api2/json/pinyinChineseName/{chineseName} | Romanize the Chinese name to Pinyin, ex. 王晓明 -&gt; Wang (surname) Xiaoming (given name)
[**PinyinChineseNameBatch**](ChineseApi.md#pinyinchinesenamebatch) | **POST** /api2/json/pinyinChineseNameBatch | Romanize a list of Chinese name to Pinyin, ex. 王晓明 -&gt; Wang (surname) Xiaoming (given name).


<a name="chinesenamecandidates"></a>
# **ChineseNameCandidates**
> RomanizedNameOut ChineseNameCandidates (string chineseSurnameLatin, string chineseGivenNameLatin)

Identify Chinese name candidates, based on the romanized name ex. Wang Xiaoming

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class ChineseNameCandidatesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new ChineseApi();
            var chineseSurnameLatin = chineseSurnameLatin_example;  // string | 
            var chineseGivenNameLatin = chineseGivenNameLatin_example;  // string | 

            try
            {
                // Identify Chinese name candidates, based on the romanized name ex. Wang Xiaoming
                RomanizedNameOut result = apiInstance.ChineseNameCandidates(chineseSurnameLatin, chineseGivenNameLatin);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChineseApi.ChineseNameCandidates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chineseSurnameLatin** | **string**|  | 
 **chineseGivenNameLatin** | **string**|  | 

### Return type

[**RomanizedNameOut**](RomanizedNameOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chinesenamecandidatesbatch"></a>
# **ChineseNameCandidatesBatch**
> BatchNameMatchCandidatesOut ChineseNameCandidatesBatch (BatchFirstLastNameIn batchFirstLastNameIn = null)

Identify Chinese name candidates, based on the romanized name (firstName = chineseGivenName; lastName=chineseSurname), ex. Wang Xiaoming

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class ChineseNameCandidatesBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new ChineseApi();
            var batchFirstLastNameIn = new BatchFirstLastNameIn(); // BatchFirstLastNameIn | A list of personal Chinese names in LATIN, firstName = chineseGivenName; lastName=chineseSurname (optional) 

            try
            {
                // Identify Chinese name candidates, based on the romanized name (firstName = chineseGivenName; lastName=chineseSurname), ex. Wang Xiaoming
                BatchNameMatchCandidatesOut result = apiInstance.ChineseNameCandidatesBatch(batchFirstLastNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChineseApi.ChineseNameCandidatesBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchFirstLastNameIn** | [**BatchFirstLastNameIn**](BatchFirstLastNameIn.md)| A list of personal Chinese names in LATIN, firstName &#x3D; chineseGivenName; lastName&#x3D;chineseSurname | [optional] 

### Return type

[**BatchNameMatchCandidatesOut**](BatchNameMatchCandidatesOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chinesenamecandidatesgenderbatch"></a>
# **ChineseNameCandidatesGenderBatch**
> BatchNameMatchCandidatesOut ChineseNameCandidatesGenderBatch (BatchFirstLastNameIn batchFirstLastNameIn = null)

Identify Chinese name candidates, based on the romanized name (firstName = chineseGivenName; lastName=chineseSurname) ex. Wang Xiaoming.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class ChineseNameCandidatesGenderBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new ChineseApi();
            var batchFirstLastNameIn = new BatchFirstLastNameIn(); // BatchFirstLastNameIn | A list of personal Chinese names in LATIN, firstName = chineseGivenName; lastName=chineseSurname (optional) 

            try
            {
                // Identify Chinese name candidates, based on the romanized name (firstName = chineseGivenName; lastName=chineseSurname) ex. Wang Xiaoming.
                BatchNameMatchCandidatesOut result = apiInstance.ChineseNameCandidatesGenderBatch(batchFirstLastNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChineseApi.ChineseNameCandidatesGenderBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchFirstLastNameIn** | [**BatchFirstLastNameIn**](BatchFirstLastNameIn.md)| A list of personal Chinese names in LATIN, firstName &#x3D; chineseGivenName; lastName&#x3D;chineseSurname | [optional] 

### Return type

[**BatchNameMatchCandidatesOut**](BatchNameMatchCandidatesOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chinesenamegendercandidates"></a>
# **ChineseNameGenderCandidates**
> RomanizedNameOut ChineseNameGenderCandidates (string chineseSurnameLatin, string chineseGivenNameLatin, string knownGender)

Identify Chinese name candidates, based on the romanized name ex. Wang Xiaoming - having a known gender ('male' or 'female')

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class ChineseNameGenderCandidatesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new ChineseApi();
            var chineseSurnameLatin = chineseSurnameLatin_example;  // string | 
            var chineseGivenNameLatin = chineseGivenNameLatin_example;  // string | 
            var knownGender = knownGender_example;  // string | 

            try
            {
                // Identify Chinese name candidates, based on the romanized name ex. Wang Xiaoming - having a known gender ('male' or 'female')
                RomanizedNameOut result = apiInstance.ChineseNameGenderCandidates(chineseSurnameLatin, chineseGivenNameLatin, knownGender);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChineseApi.ChineseNameGenderCandidates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chineseSurnameLatin** | **string**|  | 
 **chineseGivenNameLatin** | **string**|  | 
 **knownGender** | **string**|  | 

### Return type

[**RomanizedNameOut**](RomanizedNameOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chinesenamematch"></a>
# **ChineseNameMatch**
> RomanizedNameOut ChineseNameMatch (string chineseSurnameLatin, string chineseGivenNameLatin, string chineseName)

Return a score for matching Chinese name ex. 王晓明 with a romanized name ex. Wang Xiaoming

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class ChineseNameMatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new ChineseApi();
            var chineseSurnameLatin = chineseSurnameLatin_example;  // string | 
            var chineseGivenNameLatin = chineseGivenNameLatin_example;  // string | 
            var chineseName = chineseName_example;  // string | 

            try
            {
                // Return a score for matching Chinese name ex. 王晓明 with a romanized name ex. Wang Xiaoming
                RomanizedNameOut result = apiInstance.ChineseNameMatch(chineseSurnameLatin, chineseGivenNameLatin, chineseName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChineseApi.ChineseNameMatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chineseSurnameLatin** | **string**|  | 
 **chineseGivenNameLatin** | **string**|  | 
 **chineseName** | **string**|  | 

### Return type

[**RomanizedNameOut**](RomanizedNameOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chinesenamematchbatch"></a>
# **ChineseNameMatchBatch**
> BatchNameMatchCandidatesOut ChineseNameMatchBatch (BatchFirstLastNameIn batchFirstLastNameIn = null)

Identify Chinese name candidates, based on the romanized name (firstName = chineseGivenName; lastName=chineseSurname), ex. Wang Xiaoming

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class ChineseNameMatchBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new ChineseApi();
            var batchFirstLastNameIn = new BatchFirstLastNameIn(); // BatchFirstLastNameIn | A list of personal Chinese names in LATIN, firstName = chineseGivenName; lastName=chineseSurname (optional) 

            try
            {
                // Identify Chinese name candidates, based on the romanized name (firstName = chineseGivenName; lastName=chineseSurname), ex. Wang Xiaoming
                BatchNameMatchCandidatesOut result = apiInstance.ChineseNameMatchBatch(batchFirstLastNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChineseApi.ChineseNameMatchBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchFirstLastNameIn** | [**BatchFirstLastNameIn**](BatchFirstLastNameIn.md)| A list of personal Chinese names in LATIN, firstName &#x3D; chineseGivenName; lastName&#x3D;chineseSurname | [optional] 

### Return type

[**BatchNameMatchCandidatesOut**](BatchNameMatchCandidatesOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="genderchinesename"></a>
# **GenderChineseName**
> PersonalNameGenderedOut GenderChineseName (string chineseName)

Infer the likely gender of a Chinese full name ex. 王晓明

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class GenderChineseNameExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new ChineseApi();
            var chineseName = chineseName_example;  // string | 

            try
            {
                // Infer the likely gender of a Chinese full name ex. 王晓明
                PersonalNameGenderedOut result = apiInstance.GenderChineseName(chineseName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChineseApi.GenderChineseName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chineseName** | **string**|  | 

### Return type

[**PersonalNameGenderedOut**](PersonalNameGenderedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="genderchinesenamebatch"></a>
# **GenderChineseNameBatch**
> BatchPersonalNameGenderedOut GenderChineseNameBatch (BatchPersonalNameIn batchPersonalNameIn = null)

Infer the likely gender of up to 100 full names ex. 王晓明

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class GenderChineseNameBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new ChineseApi();
            var batchPersonalNameIn = new BatchPersonalNameIn(); // BatchPersonalNameIn | A list of personal names, with a country ISO2 code (optional) 

            try
            {
                // Infer the likely gender of up to 100 full names ex. 王晓明
                BatchPersonalNameGenderedOut result = apiInstance.GenderChineseNameBatch(batchPersonalNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChineseApi.GenderChineseNameBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchPersonalNameIn** | [**BatchPersonalNameIn**](BatchPersonalNameIn.md)| A list of personal names, with a country ISO2 code | [optional] 

### Return type

[**BatchPersonalNameGenderedOut**](BatchPersonalNameGenderedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="genderchinesenamepinyin"></a>
# **GenderChineseNamePinyin**
> FirstLastNameGenderedOut GenderChineseNamePinyin (string chineseSurnameLatin, string chineseGivenNameLatin)

Infer the likely gender of a Chinese name in LATIN (Pinyin).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class GenderChineseNamePinyinExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new ChineseApi();
            var chineseSurnameLatin = chineseSurnameLatin_example;  // string | 
            var chineseGivenNameLatin = chineseGivenNameLatin_example;  // string | 

            try
            {
                // Infer the likely gender of a Chinese name in LATIN (Pinyin).
                FirstLastNameGenderedOut result = apiInstance.GenderChineseNamePinyin(chineseSurnameLatin, chineseGivenNameLatin);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChineseApi.GenderChineseNamePinyin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chineseSurnameLatin** | **string**|  | 
 **chineseGivenNameLatin** | **string**|  | 

### Return type

[**FirstLastNameGenderedOut**](FirstLastNameGenderedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="genderchinesenamepinyinbatch"></a>
# **GenderChineseNamePinyinBatch**
> BatchFirstLastNameGenderedOut GenderChineseNamePinyinBatch (BatchFirstLastNameIn batchFirstLastNameIn = null)

Infer the likely gender of up to 100 Chinese names in LATIN (Pinyin).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class GenderChineseNamePinyinBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new ChineseApi();
            var batchFirstLastNameIn = new BatchFirstLastNameIn(); // BatchFirstLastNameIn | A list of names, with country code. (optional) 

            try
            {
                // Infer the likely gender of up to 100 Chinese names in LATIN (Pinyin).
                BatchFirstLastNameGenderedOut result = apiInstance.GenderChineseNamePinyinBatch(batchFirstLastNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChineseApi.GenderChineseNamePinyinBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchFirstLastNameIn** | [**BatchFirstLastNameIn**](BatchFirstLastNameIn.md)| A list of names, with country code. | [optional] 

### Return type

[**BatchFirstLastNameGenderedOut**](BatchFirstLastNameGenderedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="parsechinesename"></a>
# **ParseChineseName**
> PersonalNameParsedOut ParseChineseName (string chineseName)

Infer the likely first/last name structure of a name, ex. 王晓明 -> 王(surname) 晓明(given name)

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class ParseChineseNameExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new ChineseApi();
            var chineseName = chineseName_example;  // string | 

            try
            {
                // Infer the likely first/last name structure of a name, ex. 王晓明 -> 王(surname) 晓明(given name)
                PersonalNameParsedOut result = apiInstance.ParseChineseName(chineseName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChineseApi.ParseChineseName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chineseName** | **string**|  | 

### Return type

[**PersonalNameParsedOut**](PersonalNameParsedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="parsechinesenamebatch"></a>
# **ParseChineseNameBatch**
> BatchPersonalNameParsedOut ParseChineseNameBatch (BatchPersonalNameIn batchPersonalNameIn = null)

Infer the likely first/last name structure of a name, ex. 王晓明 -> 王(surname) 晓明(given name).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class ParseChineseNameBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new ChineseApi();
            var batchPersonalNameIn = new BatchPersonalNameIn(); // BatchPersonalNameIn | A list of personal names (optional) 

            try
            {
                // Infer the likely first/last name structure of a name, ex. 王晓明 -> 王(surname) 晓明(given name).
                BatchPersonalNameParsedOut result = apiInstance.ParseChineseNameBatch(batchPersonalNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChineseApi.ParseChineseNameBatch: " + e.Message );
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

<a name="pinyinchinesename"></a>
# **PinyinChineseName**
> PersonalNameParsedOut PinyinChineseName (string chineseName)

Romanize the Chinese name to Pinyin, ex. 王晓明 -> Wang (surname) Xiaoming (given name)

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class PinyinChineseNameExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new ChineseApi();
            var chineseName = chineseName_example;  // string | 

            try
            {
                // Romanize the Chinese name to Pinyin, ex. 王晓明 -> Wang (surname) Xiaoming (given name)
                PersonalNameParsedOut result = apiInstance.PinyinChineseName(chineseName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChineseApi.PinyinChineseName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chineseName** | **string**|  | 

### Return type

[**PersonalNameParsedOut**](PersonalNameParsedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pinyinchinesenamebatch"></a>
# **PinyinChineseNameBatch**
> BatchPersonalNameParsedOut PinyinChineseNameBatch (BatchPersonalNameIn batchPersonalNameIn = null)

Romanize a list of Chinese name to Pinyin, ex. 王晓明 -> Wang (surname) Xiaoming (given name).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class PinyinChineseNameBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new ChineseApi();
            var batchPersonalNameIn = new BatchPersonalNameIn(); // BatchPersonalNameIn | A list of Chinese names (optional) 

            try
            {
                // Romanize a list of Chinese name to Pinyin, ex. 王晓明 -> Wang (surname) Xiaoming (given name).
                BatchPersonalNameParsedOut result = apiInstance.PinyinChineseNameBatch(batchPersonalNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChineseApi.PinyinChineseNameBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchPersonalNameIn** | [**BatchPersonalNameIn**](BatchPersonalNameIn.md)| A list of Chinese names | [optional] 

### Return type

[**BatchPersonalNameParsedOut**](BatchPersonalNameParsedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

