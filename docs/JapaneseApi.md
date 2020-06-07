# Org.OpenAPITools.com.namsor.sdk2.api.JapaneseApi

All URIs are relative to *https://v2.namsor.com/NamSorAPIv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GenderJapaneseNameFull**](JapaneseApi.md#genderjapanesenamefull) | **GET** /api2/json/genderJapaneseNameFull/{japaneseName} | Infer the likely gender of a Japanese full name ex. 王晓明
[**GenderJapaneseNameFullBatch**](JapaneseApi.md#genderjapanesenamefullbatch) | **POST** /api2/json/genderJapaneseNameFullBatch | Infer the likely gender of up to 100 full names
[**GenderJapaneseNamePinyin**](JapaneseApi.md#genderjapanesenamepinyin) | **GET** /api2/json/genderJapaneseName/{japaneseSurname}/{japaneseGivenName} | Infer the likely gender of a Japanese name in LATIN (Pinyin).
[**GenderJapaneseNamePinyinBatch**](JapaneseApi.md#genderjapanesenamepinyinbatch) | **POST** /api2/json/genderJapaneseNameBatch | Infer the likely gender of up to 100 Japanese names in LATIN (Pinyin).
[**JapaneseNameKanjiCandidates**](JapaneseApi.md#japanesenamekanjicandidates) | **GET** /api2/json/japaneseNameKanjiCandidates/{japaneseSurnameLatin}/{japaneseGivenNameLatin} | Identify japanese name candidates in KANJI, based on the romanized name ex. Yamamoto Sanae
[**JapaneseNameKanjiCandidatesBatch**](JapaneseApi.md#japanesenamekanjicandidatesbatch) | **POST** /api2/json/japaneseNameKanjiCandidatesBatch | Identify japanese name candidates in KANJI, based on the romanized name (firstName &#x3D; japaneseGivenName; lastName&#x3D;japaneseSurname), ex. Yamamoto Sanae
[**JapaneseNameLatinCandidates**](JapaneseApi.md#japanesenamelatincandidates) | **GET** /api2/json/japaneseNameLatinCandidates/{japaneseSurnameKanji}/{japaneseGivenNameKanji} | Romanize japanese name, based on the name in Kanji.
[**JapaneseNameLatinCandidatesBatch**](JapaneseApi.md#japanesenamelatincandidatesbatch) | **POST** /api2/json/japaneseNameLatinCandidatesBatch | Romanize japanese names, based on the name in KANJI
[**JapaneseNameMatch**](JapaneseApi.md#japanesenamematch) | **GET** /api2/json/japaneseNameMatch/{japaneseSurnameLatin}/{japaneseGivenNameLatin}/{japaneseName} | Return a score for matching Japanese name in KANJI ex. 山本 早苗 with a romanized name ex. Yamamoto Sanae
[**JapaneseNameMatchBatch**](JapaneseApi.md#japanesenamematchbatch) | **POST** /api2/json/japaneseNameMatchBatch | Return a score for matching a list of Japanese names in KANJI ex. 山本 早苗 with romanized names ex. Yamamoto Sanae
[**JapaneseNameMatchFeedbackLoop**](JapaneseApi.md#japanesenamematchfeedbackloop) | **GET** /api2/json/japaneseNameMatchFeedbackLoop/{japaneseSurnameLatin}/{japaneseGivenNameLatin}/{japaneseName} | [CREDITS 1 UNIT] Feedback loop to better perform matching Japanese name in KANJI ex. 山本 早苗 with a romanized name ex. Yamamoto Sanae
[**ParseJapaneseName**](JapaneseApi.md#parsejapanesename) | **GET** /api2/json/parseJapaneseName/{japaneseName} | Infer the likely first/last name structure of a name, ex. 山本 早苗 or Yamamoto Sanae
[**ParseJapaneseNameBatch**](JapaneseApi.md#parsejapanesenamebatch) | **POST** /api2/json/parseJapaneseNameBatch | Infer the likely first/last name structure of a name, ex. 山本 早苗 or Yamamoto Sanae 


<a name="genderjapanesenamefull"></a>
# **GenderJapaneseNameFull**
> PersonalNameGenderedOut GenderJapaneseNameFull (string japaneseName)

Infer the likely gender of a Japanese full name ex. 王晓明

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class GenderJapaneseNameFullExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new JapaneseApi();
            var japaneseName = japaneseName_example;  // string | 

            try
            {
                // Infer the likely gender of a Japanese full name ex. 王晓明
                PersonalNameGenderedOut result = apiInstance.GenderJapaneseNameFull(japaneseName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JapaneseApi.GenderJapaneseNameFull: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **japaneseName** | **string**|  | 

### Return type

[**PersonalNameGenderedOut**](PersonalNameGenderedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="genderjapanesenamefullbatch"></a>
# **GenderJapaneseNameFullBatch**
> BatchPersonalNameGenderedOut GenderJapaneseNameFullBatch (BatchPersonalNameIn batchPersonalNameIn = null)

Infer the likely gender of up to 100 full names

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class GenderJapaneseNameFullBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new JapaneseApi();
            var batchPersonalNameIn = new BatchPersonalNameIn(); // BatchPersonalNameIn | A list of personal names (optional) 

            try
            {
                // Infer the likely gender of up to 100 full names
                BatchPersonalNameGenderedOut result = apiInstance.GenderJapaneseNameFullBatch(batchPersonalNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JapaneseApi.GenderJapaneseNameFullBatch: " + e.Message );
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

<a name="genderjapanesenamepinyin"></a>
# **GenderJapaneseNamePinyin**
> FirstLastNameGenderedOut GenderJapaneseNamePinyin (string japaneseSurname, string japaneseGivenName)

Infer the likely gender of a Japanese name in LATIN (Pinyin).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class GenderJapaneseNamePinyinExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new JapaneseApi();
            var japaneseSurname = japaneseSurname_example;  // string | 
            var japaneseGivenName = japaneseGivenName_example;  // string | 

            try
            {
                // Infer the likely gender of a Japanese name in LATIN (Pinyin).
                FirstLastNameGenderedOut result = apiInstance.GenderJapaneseNamePinyin(japaneseSurname, japaneseGivenName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JapaneseApi.GenderJapaneseNamePinyin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **japaneseSurname** | **string**|  | 
 **japaneseGivenName** | **string**|  | 

### Return type

[**FirstLastNameGenderedOut**](FirstLastNameGenderedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="genderjapanesenamepinyinbatch"></a>
# **GenderJapaneseNamePinyinBatch**
> BatchFirstLastNameGenderedOut GenderJapaneseNamePinyinBatch (BatchFirstLastNameIn batchFirstLastNameIn = null)

Infer the likely gender of up to 100 Japanese names in LATIN (Pinyin).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class GenderJapaneseNamePinyinBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new JapaneseApi();
            var batchFirstLastNameIn = new BatchFirstLastNameIn(); // BatchFirstLastNameIn | A list of names, with country code. (optional) 

            try
            {
                // Infer the likely gender of up to 100 Japanese names in LATIN (Pinyin).
                BatchFirstLastNameGenderedOut result = apiInstance.GenderJapaneseNamePinyinBatch(batchFirstLastNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JapaneseApi.GenderJapaneseNamePinyinBatch: " + e.Message );
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

<a name="japanesenamekanjicandidates"></a>
# **JapaneseNameKanjiCandidates**
> RomanizedNameOut JapaneseNameKanjiCandidates (string japaneseSurnameLatin, string japaneseGivenNameLatin)

Identify japanese name candidates in KANJI, based on the romanized name ex. Yamamoto Sanae

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class JapaneseNameKanjiCandidatesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new JapaneseApi();
            var japaneseSurnameLatin = japaneseSurnameLatin_example;  // string | 
            var japaneseGivenNameLatin = japaneseGivenNameLatin_example;  // string | 

            try
            {
                // Identify japanese name candidates in KANJI, based on the romanized name ex. Yamamoto Sanae
                RomanizedNameOut result = apiInstance.JapaneseNameKanjiCandidates(japaneseSurnameLatin, japaneseGivenNameLatin);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JapaneseApi.JapaneseNameKanjiCandidates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **japaneseSurnameLatin** | **string**|  | 
 **japaneseGivenNameLatin** | **string**|  | 

### Return type

[**RomanizedNameOut**](RomanizedNameOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="japanesenamekanjicandidatesbatch"></a>
# **JapaneseNameKanjiCandidatesBatch**
> BatchNameMatchCandidatesOut JapaneseNameKanjiCandidatesBatch (BatchFirstLastNameIn batchFirstLastNameIn = null)

Identify japanese name candidates in KANJI, based on the romanized name (firstName = japaneseGivenName; lastName=japaneseSurname), ex. Yamamoto Sanae

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class JapaneseNameKanjiCandidatesBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new JapaneseApi();
            var batchFirstLastNameIn = new BatchFirstLastNameIn(); // BatchFirstLastNameIn | A list of personal japanese names in LATIN, firstName = japaneseGivenName; lastName=japaneseSurname (optional) 

            try
            {
                // Identify japanese name candidates in KANJI, based on the romanized name (firstName = japaneseGivenName; lastName=japaneseSurname), ex. Yamamoto Sanae
                BatchNameMatchCandidatesOut result = apiInstance.JapaneseNameKanjiCandidatesBatch(batchFirstLastNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JapaneseApi.JapaneseNameKanjiCandidatesBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchFirstLastNameIn** | [**BatchFirstLastNameIn**](BatchFirstLastNameIn.md)| A list of personal japanese names in LATIN, firstName &#x3D; japaneseGivenName; lastName&#x3D;japaneseSurname | [optional] 

### Return type

[**BatchNameMatchCandidatesOut**](BatchNameMatchCandidatesOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="japanesenamelatincandidates"></a>
# **JapaneseNameLatinCandidates**
> RomanizedNameOut JapaneseNameLatinCandidates (string japaneseSurnameKanji, string japaneseGivenNameKanji)

Romanize japanese name, based on the name in Kanji.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class JapaneseNameLatinCandidatesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new JapaneseApi();
            var japaneseSurnameKanji = japaneseSurnameKanji_example;  // string | 
            var japaneseGivenNameKanji = japaneseGivenNameKanji_example;  // string | 

            try
            {
                // Romanize japanese name, based on the name in Kanji.
                RomanizedNameOut result = apiInstance.JapaneseNameLatinCandidates(japaneseSurnameKanji, japaneseGivenNameKanji);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JapaneseApi.JapaneseNameLatinCandidates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **japaneseSurnameKanji** | **string**|  | 
 **japaneseGivenNameKanji** | **string**|  | 

### Return type

[**RomanizedNameOut**](RomanizedNameOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="japanesenamelatincandidatesbatch"></a>
# **JapaneseNameLatinCandidatesBatch**
> BatchNameMatchCandidatesOut JapaneseNameLatinCandidatesBatch (BatchFirstLastNameIn batchFirstLastNameIn = null)

Romanize japanese names, based on the name in KANJI

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class JapaneseNameLatinCandidatesBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new JapaneseApi();
            var batchFirstLastNameIn = new BatchFirstLastNameIn(); // BatchFirstLastNameIn | A list of personal japanese names in KANJI, firstName = japaneseGivenName; lastName=japaneseSurname (optional) 

            try
            {
                // Romanize japanese names, based on the name in KANJI
                BatchNameMatchCandidatesOut result = apiInstance.JapaneseNameLatinCandidatesBatch(batchFirstLastNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JapaneseApi.JapaneseNameLatinCandidatesBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchFirstLastNameIn** | [**BatchFirstLastNameIn**](BatchFirstLastNameIn.md)| A list of personal japanese names in KANJI, firstName &#x3D; japaneseGivenName; lastName&#x3D;japaneseSurname | [optional] 

### Return type

[**BatchNameMatchCandidatesOut**](BatchNameMatchCandidatesOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="japanesenamematch"></a>
# **JapaneseNameMatch**
> RomanizedNameOut JapaneseNameMatch (string japaneseSurnameLatin, string japaneseGivenNameLatin, string japaneseName)

Return a score for matching Japanese name in KANJI ex. 山本 早苗 with a romanized name ex. Yamamoto Sanae

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class JapaneseNameMatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new JapaneseApi();
            var japaneseSurnameLatin = japaneseSurnameLatin_example;  // string | 
            var japaneseGivenNameLatin = japaneseGivenNameLatin_example;  // string | 
            var japaneseName = japaneseName_example;  // string | 

            try
            {
                // Return a score for matching Japanese name in KANJI ex. 山本 早苗 with a romanized name ex. Yamamoto Sanae
                RomanizedNameOut result = apiInstance.JapaneseNameMatch(japaneseSurnameLatin, japaneseGivenNameLatin, japaneseName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JapaneseApi.JapaneseNameMatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **japaneseSurnameLatin** | **string**|  | 
 **japaneseGivenNameLatin** | **string**|  | 
 **japaneseName** | **string**|  | 

### Return type

[**RomanizedNameOut**](RomanizedNameOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="japanesenamematchbatch"></a>
# **JapaneseNameMatchBatch**
> BatchNameMatchCandidatesOut JapaneseNameMatchBatch (BatchFirstLastNameIn batchFirstLastNameIn = null)

Return a score for matching a list of Japanese names in KANJI ex. 山本 早苗 with romanized names ex. Yamamoto Sanae

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class JapaneseNameMatchBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new JapaneseApi();
            var batchFirstLastNameIn = new BatchFirstLastNameIn(); // BatchFirstLastNameIn | A list of personal Japanese names in LATIN, firstName = japaneseGivenName; lastName=japaneseSurname (optional) 

            try
            {
                // Return a score for matching a list of Japanese names in KANJI ex. 山本 早苗 with romanized names ex. Yamamoto Sanae
                BatchNameMatchCandidatesOut result = apiInstance.JapaneseNameMatchBatch(batchFirstLastNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JapaneseApi.JapaneseNameMatchBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchFirstLastNameIn** | [**BatchFirstLastNameIn**](BatchFirstLastNameIn.md)| A list of personal Japanese names in LATIN, firstName &#x3D; japaneseGivenName; lastName&#x3D;japaneseSurname | [optional] 

### Return type

[**BatchNameMatchCandidatesOut**](BatchNameMatchCandidatesOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="japanesenamematchfeedbackloop"></a>
# **JapaneseNameMatchFeedbackLoop**
> RomanizedNameOut JapaneseNameMatchFeedbackLoop (string japaneseSurnameLatin, string japaneseGivenNameLatin, string japaneseName)

[CREDITS 1 UNIT] Feedback loop to better perform matching Japanese name in KANJI ex. 山本 早苗 with a romanized name ex. Yamamoto Sanae

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class JapaneseNameMatchFeedbackLoopExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new JapaneseApi();
            var japaneseSurnameLatin = japaneseSurnameLatin_example;  // string | 
            var japaneseGivenNameLatin = japaneseGivenNameLatin_example;  // string | 
            var japaneseName = japaneseName_example;  // string | 

            try
            {
                // [CREDITS 1 UNIT] Feedback loop to better perform matching Japanese name in KANJI ex. 山本 早苗 with a romanized name ex. Yamamoto Sanae
                RomanizedNameOut result = apiInstance.JapaneseNameMatchFeedbackLoop(japaneseSurnameLatin, japaneseGivenNameLatin, japaneseName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JapaneseApi.JapaneseNameMatchFeedbackLoop: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **japaneseSurnameLatin** | **string**|  | 
 **japaneseGivenNameLatin** | **string**|  | 
 **japaneseName** | **string**|  | 

### Return type

[**RomanizedNameOut**](RomanizedNameOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="parsejapanesename"></a>
# **ParseJapaneseName**
> PersonalNameParsedOut ParseJapaneseName (string japaneseName)

Infer the likely first/last name structure of a name, ex. 山本 早苗 or Yamamoto Sanae

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class ParseJapaneseNameExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new JapaneseApi();
            var japaneseName = japaneseName_example;  // string | 

            try
            {
                // Infer the likely first/last name structure of a name, ex. 山本 早苗 or Yamamoto Sanae
                PersonalNameParsedOut result = apiInstance.ParseJapaneseName(japaneseName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JapaneseApi.ParseJapaneseName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **japaneseName** | **string**|  | 

### Return type

[**PersonalNameParsedOut**](PersonalNameParsedOut.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="parsejapanesenamebatch"></a>
# **ParseJapaneseNameBatch**
> BatchPersonalNameParsedOut ParseJapaneseNameBatch (BatchPersonalNameIn batchPersonalNameIn = null)

Infer the likely first/last name structure of a name, ex. 山本 早苗 or Yamamoto Sanae 

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class ParseJapaneseNameBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new JapaneseApi();
            var batchPersonalNameIn = new BatchPersonalNameIn(); // BatchPersonalNameIn | A list of personal names (optional) 

            try
            {
                // Infer the likely first/last name structure of a name, ex. 山本 早苗 or Yamamoto Sanae 
                BatchPersonalNameParsedOut result = apiInstance.ParseJapaneseNameBatch(batchPersonalNameIn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JapaneseApi.ParseJapaneseNameBatch: " + e.Message );
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

