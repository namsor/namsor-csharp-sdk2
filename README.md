# Org.OpenAPITools - the C# library for the NamSor API v2

NamSor API v2 : enpoints to process personal names (gender, cultural origin or ethnicity) in all alphabets or languages. Use GET methods for small tests, but prefer POST methods for higher throughput (batch processing of up to 100 names at a time). Need something you can't find here? We have many more features coming soon. Let us know, we'll do our best to add it! 

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 2.0.11
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [http://www.namsor.com/](http://www.namsor.com/)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Org.OpenAPITools.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.com.namsor.sdk2.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.namsor.sdk2.model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-KEY", "Bearer");

            var apiInstance = new AdminApi();
            var apiKey = apiKey_example;  // string | 
            var usageCredits = 789;  // long? | 
            var userMessage = userMessage_example;  // string | 

            try
            {
                // Add usage credits to an API Key.
                SystemMetricsOut result = apiInstance.AddCredits(apiKey, usageCredits, userMessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.AddCredits: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://v2.namsor.com/NamSorAPIv2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AdminApi* | [**AddCredits**](docs/AdminApi.md#addcredits) | **GET** /api2/json/addCredits/{apiKey}/{usageCredits}/{userMessage} | Add usage credits to an API Key.
*AdminApi* | [**Anonymize**](docs/AdminApi.md#anonymize) | **GET** /api2/json/anonymize/{source}/{anonymized} | Activate/deactivate anonymization for a source.
*AdminApi* | [**ApiStatus**](docs/AdminApi.md#apistatus) | **GET** /api2/json/apiStatus | Prints the current status of the classifiers.
*AdminApi* | [**ApiUsage**](docs/AdminApi.md#apiusage) | **GET** /api2/json/apiUsage | Print current API usage.
*AdminApi* | [**ApiUsageHistory**](docs/AdminApi.md#apiusagehistory) | **GET** /api2/json/apiUsageHistory | Print historical API usage.
*AdminApi* | [**ApiUsageHistoryAggregate**](docs/AdminApi.md#apiusagehistoryaggregate) | **GET** /api2/json/apiUsageHistoryAggregate | Print historical API usage (in an aggregated view, by service, by day/hour/min).
*AdminApi* | [**AvailablePlans**](docs/AdminApi.md#availableplans) | **GET** /api2/json/availablePlans/{token} | List all available plans in the user's preferred currency.
*AdminApi* | [**AvailablePlans1**](docs/AdminApi.md#availableplans1) | **GET** /api2/json/availablePlans | List all available plans in the default currency (usd).
*AdminApi* | [**AvailableServices**](docs/AdminApi.md#availableservices) | **GET** /api2/json/apiServices | List of API services and usage cost in Units (default is 1=ONE Unit).
*AdminApi* | [**BillingCurrencies**](docs/AdminApi.md#billingcurrencies) | **GET** /api2/json/billingCurrencies | List possible currency options for billing (USD, EUR, GBP, ...)
*AdminApi* | [**BillingHistory**](docs/AdminApi.md#billinghistory) | **GET** /api2/json/billingHistory/{token} | Read the history billing information (invoices paid via Stripe or manually).
*AdminApi* | [**BillingInfo**](docs/AdminApi.md#billinginfo) | **GET** /api2/json/billingInfo/{token} | Read the billing information (company name, address, phone, vat ID)
*AdminApi* | [**Charge**](docs/AdminApi.md#charge) | **POST** /api2/json/charge | Create a Stripe Customer, based on a payment card token (from secure StripeJS) and email.
*AdminApi* | [**CorporateKey**](docs/AdminApi.md#corporatekey) | **GET** /api2/json/corporateKey/{apiKey}/{corporate} | Setting an API Key to a corporate status.
*AdminApi* | [**DebugLevel**](docs/AdminApi.md#debuglevel) | **GET** /api2/json/debugLevel/{logger}/{level} | Update debug level for a classifier
*AdminApi* | [**Flush**](docs/AdminApi.md#flush) | **GET** /api2/json/flush | Flush counters.
*AdminApi* | [**InvalidateCache**](docs/AdminApi.md#invalidatecache) | **GET** /api2/json/invalidateCache | Invalidate system caches.
*AdminApi* | [**Learnable**](docs/AdminApi.md#learnable) | **GET** /api2/json/learnable/{source}/{learnable} | Activate/deactivate learning from a source.
*AdminApi* | [**NamsorCounter**](docs/AdminApi.md#namsorcounter) | **GET** /api2/json/namsorCounter | Get the overall API counter
*AdminApi* | [**PaymentInfo**](docs/AdminApi.md#paymentinfo) | **GET** /api2/json/paymentInfo/{token} | Get the Stripe payment information associated with the current google auth session token.
*AdminApi* | [**ProcureKey**](docs/AdminApi.md#procurekey) | **GET** /api2/json/procureKey/{token} | Procure an API Key (sent via Email), based on an auth token. Keep your API Key secret.
*AdminApi* | [**RedeployUI**](docs/AdminApi.md#redeployui) | **GET** /api2/json/redeployUI/{live} | Redeploy UI from current dev branch.
*AdminApi* | [**RedeployUI1**](docs/AdminApi.md#redeployui1) | **GET** /api2/json/redeployUI | Redeploy UI from current dev branch.
*AdminApi* | [**RemoveUserAccount**](docs/AdminApi.md#removeuseraccount) | **GET** /api2/json/removeUserAccount/{token} | Remove the user account.
*AdminApi* | [**RemoveUserAccountOnBehalf**](docs/AdminApi.md#removeuseraccountonbehalf) | **GET** /api2/json/removeUserAccountOnBehalf/{apiKey} | Remove (on behalf) a user account.
*AdminApi* | [**Shutdown**](docs/AdminApi.md#shutdown) | **GET** /api2/json/shutdown | Stop learning and shutdown system.
*AdminApi* | [**SoftwareVersion**](docs/AdminApi.md#softwareversion) | **GET** /api2/json/softwareVersion | Get the current software version
*AdminApi* | [**SourceStats**](docs/AdminApi.md#sourcestats) | **GET** /api2/json/sourceStats/{source} | Print basic source statistics.
*AdminApi* | [**Stats**](docs/AdminApi.md#stats) | **GET** /api2/json/stats | Print basic system statistics.
*AdminApi* | [**StripeConnect**](docs/AdminApi.md#stripeconnect) | **GET** /api2/json/stripeConnect | Connects a Stripe Account.
*AdminApi* | [**SubscribePlan**](docs/AdminApi.md#subscribeplan) | **GET** /api2/json/subscribePlan/{planName}/{token} | Subscribe to a give API plan, using the user's preferred or default currency.
*AdminApi* | [**SubscribePlanOnBehalf**](docs/AdminApi.md#subscribeplanonbehalf) | **GET** /api2/json/subscribePlanOnBehalf/{planName}/{apiKey} | Subscribe to a give API plan, using the user's preferred or default currency (admin only).
*AdminApi* | [**TaxonomyClasses**](docs/AdminApi.md#taxonomyclasses) | **GET** /api2/json/taxonomyClasses/{classifierName} | Print the taxonomy classes valid for the given classifier.
*AdminApi* | [**UpdateBillingInfo**](docs/AdminApi.md#updatebillinginfo) | **POST** /api2/json/updateBillingInfo/{token} | Sets or update the billing information (company name, address, phone, vat ID)
*AdminApi* | [**UpdateLimit**](docs/AdminApi.md#updatelimit) | **GET** /api2/json/updateLimit/{usageLimit}/{hardOrSoft}/{token} | Modifies the hard/soft limit on the API plan's overages (default is 0$ soft limit).
*AdminApi* | [**UpdatePaymentDefault**](docs/AdminApi.md#updatepaymentdefault) | **GET** /api2/json/updatePaymentDefault/{defautSourceId}/{token} | Update the default Stripe card associated with the current google auth session token.
*AdminApi* | [**UserInfo**](docs/AdminApi.md#userinfo) | **GET** /api2/json/userInfo/{token} | Get the user profile associated with the current google auth session token.
*AdminApi* | [**VerifyEmail**](docs/AdminApi.md#verifyemail) | **GET** /api2/json/verifyEmail/{emailToken} | Verifies an email, based on token sent to that email
*AdminApi* | [**VerifyRemoveEmail**](docs/AdminApi.md#verifyremoveemail) | **GET** /api2/json/verifyRemoveEmail/{emailToken} | Verifies an email, based on token sent to that email
*AdminApi* | [**Vet**](docs/AdminApi.md#vet) | **GET** /api2/json/vetting/{source}/{vetted} | Vetting of a source.
*ChineseApi* | [**ChineseNameCandidates**](docs/ChineseApi.md#chinesenamecandidates) | **GET** /api2/json/chineseNameCandidates/{chineseSurnameLatin}/{chineseGivenNameLatin} | Identify Chinese name candidates, based on the romanized name ex. Wang Xiaoming
*ChineseApi* | [**ChineseNameCandidatesBatch**](docs/ChineseApi.md#chinesenamecandidatesbatch) | **POST** /api2/json/chineseNameCandidatesBatch | Identify Chinese name candidates, based on the romanized name (firstName = chineseGivenName; lastName=chineseSurname), ex. Wang Xiaoming
*ChineseApi* | [**ChineseNameCandidatesGenderBatch**](docs/ChineseApi.md#chinesenamecandidatesgenderbatch) | **POST** /api2/json/chineseNameCandidatesGenderBatch | Identify Chinese name candidates, based on the romanized name (firstName = chineseGivenName; lastName=chineseSurname) ex. Wang Xiaoming.
*ChineseApi* | [**ChineseNameGenderCandidates**](docs/ChineseApi.md#chinesenamegendercandidates) | **GET** /api2/json/chineseNameGenderCandidates/{chineseSurnameLatin}/{chineseGivenNameLatin}/{knownGender} | Identify Chinese name candidates, based on the romanized name ex. Wang Xiaoming - having a known gender ('male' or 'female')
*ChineseApi* | [**ChineseNameMatch**](docs/ChineseApi.md#chinesenamematch) | **GET** /api2/json/chineseNameMatch/{chineseSurnameLatin}/{chineseGivenNameLatin}/{chineseName} | Return a score for matching Chinese name ex. 王晓明 with a romanized name ex. Wang Xiaoming
*ChineseApi* | [**ChineseNameMatchBatch**](docs/ChineseApi.md#chinesenamematchbatch) | **POST** /api2/json/chineseNameMatchBatch | Identify Chinese name candidates, based on the romanized name (firstName = chineseGivenName; lastName=chineseSurname), ex. Wang Xiaoming
*ChineseApi* | [**GenderChineseName**](docs/ChineseApi.md#genderchinesename) | **GET** /api2/json/genderChineseName/{chineseName} | Infer the likely gender of a Chinese full name ex. 王晓明
*ChineseApi* | [**GenderChineseNameBatch**](docs/ChineseApi.md#genderchinesenamebatch) | **POST** /api2/json/genderChineseNameBatch | Infer the likely gender of up to 100 full names ex. 王晓明
*ChineseApi* | [**GenderChineseNamePinyin**](docs/ChineseApi.md#genderchinesenamepinyin) | **GET** /api2/json/genderChineseNamePinyin/{chineseSurnameLatin}/{chineseGivenNameLatin} | Infer the likely gender of a Chinese name in LATIN (Pinyin).
*ChineseApi* | [**GenderChineseNamePinyinBatch**](docs/ChineseApi.md#genderchinesenamepinyinbatch) | **POST** /api2/json/genderChineseNamePinyinBatch | Infer the likely gender of up to 100 Chinese names in LATIN (Pinyin).
*ChineseApi* | [**ParseChineseName**](docs/ChineseApi.md#parsechinesename) | **GET** /api2/json/parseChineseName/{chineseName} | Infer the likely first/last name structure of a name, ex. 王晓明 -> 王(surname) 晓明(given name)
*ChineseApi* | [**ParseChineseNameBatch**](docs/ChineseApi.md#parsechinesenamebatch) | **POST** /api2/json/parseChineseNameBatch | Infer the likely first/last name structure of a name, ex. 王晓明 -> 王(surname) 晓明(given name).
*ChineseApi* | [**PinyinChineseName**](docs/ChineseApi.md#pinyinchinesename) | **GET** /api2/json/pinyinChineseName/{chineseName} | Romanize the Chinese name to Pinyin, ex. 王晓明 -> Wang (surname) Xiaoming (given name)
*ChineseApi* | [**PinyinChineseNameBatch**](docs/ChineseApi.md#pinyinchinesenamebatch) | **POST** /api2/json/pinyinChineseNameBatch | Romanize a list of Chinese name to Pinyin, ex. 王晓明 -> Wang (surname) Xiaoming (given name).
*GeneralApi* | [**NameType**](docs/GeneralApi.md#nametype) | **GET** /api2/json/nameType/{properNoun} | Infer the likely type of a proper noun (personal name, brand name, place name etc.)
*GeneralApi* | [**NameType1**](docs/GeneralApi.md#nametype1) | **GET** /api2/json/nameType/{properNoun}/{countryIso2} | Infer the likely type of a proper noun (personal name, brand name, place name etc.)
*JapaneseApi* | [**GenderJapaneseNameFull**](docs/JapaneseApi.md#genderjapanesenamefull) | **GET** /api2/json/genderJapaneseNameFull/{japaneseName} | Infer the likely gender of a Japanese full name ex. 王晓明
*JapaneseApi* | [**GenderJapaneseNameFullBatch**](docs/JapaneseApi.md#genderjapanesenamefullbatch) | **POST** /api2/json/genderJapaneseNameFullBatch | Infer the likely gender of up to 100 full names
*JapaneseApi* | [**GenderJapaneseNamePinyin**](docs/JapaneseApi.md#genderjapanesenamepinyin) | **GET** /api2/json/genderJapaneseName/{japaneseSurname}/{japaneseGivenName} | Infer the likely gender of a Japanese name in LATIN (Pinyin).
*JapaneseApi* | [**GenderJapaneseNamePinyinBatch**](docs/JapaneseApi.md#genderjapanesenamepinyinbatch) | **POST** /api2/json/genderJapaneseNameBatch | Infer the likely gender of up to 100 Japanese names in LATIN (Pinyin).
*JapaneseApi* | [**JapaneseNameKanjiCandidates**](docs/JapaneseApi.md#japanesenamekanjicandidates) | **GET** /api2/json/japaneseNameKanjiCandidates/{japaneseSurnameLatin}/{japaneseGivenNameLatin} | Identify japanese name candidates in KANJI, based on the romanized name ex. Yamamoto Sanae
*JapaneseApi* | [**JapaneseNameKanjiCandidatesBatch**](docs/JapaneseApi.md#japanesenamekanjicandidatesbatch) | **POST** /api2/json/japaneseNameKanjiCandidatesBatch | Identify japanese name candidates in KANJI, based on the romanized name (firstName = japaneseGivenName; lastName=japaneseSurname), ex. Yamamoto Sanae
*JapaneseApi* | [**JapaneseNameLatinCandidates**](docs/JapaneseApi.md#japanesenamelatincandidates) | **GET** /api2/json/japaneseNameLatinCandidates/{japaneseSurnameKanji}/{japaneseGivenNameKanji} | Romanize japanese name, based on the name in Kanji.
*JapaneseApi* | [**JapaneseNameLatinCandidatesBatch**](docs/JapaneseApi.md#japanesenamelatincandidatesbatch) | **POST** /api2/json/japaneseNameLatinCandidatesBatch | Romanize japanese names, based on the name in KANJI
*JapaneseApi* | [**JapaneseNameMatch**](docs/JapaneseApi.md#japanesenamematch) | **GET** /api2/json/japaneseNameMatch/{japaneseSurnameLatin}/{japaneseGivenNameLatin}/{japaneseName} | Return a score for matching Japanese name in KANJI ex. 山本 早苗 with a romanized name ex. Yamamoto Sanae
*JapaneseApi* | [**JapaneseNameMatchBatch**](docs/JapaneseApi.md#japanesenamematchbatch) | **POST** /api2/json/japaneseNameMatchBatch | Return a score for matching a list of Japanese names in KANJI ex. 山本 早苗 with romanized names ex. Yamamoto Sanae
*JapaneseApi* | [**JapaneseNameMatchFeedbackLoop**](docs/JapaneseApi.md#japanesenamematchfeedbackloop) | **GET** /api2/json/japaneseNameMatchFeedbackLoop/{japaneseSurnameLatin}/{japaneseGivenNameLatin}/{japaneseName} | [CREDITS 1 UNIT] Feedback loop to better perform matching Japanese name in KANJI ex. 山本 早苗 with a romanized name ex. Yamamoto Sanae
*JapaneseApi* | [**ParseJapaneseName**](docs/JapaneseApi.md#parsejapanesename) | **GET** /api2/json/parseJapaneseName/{japaneseName} | Infer the likely first/last name structure of a name, ex. 山本 早苗 or Yamamoto Sanae
*JapaneseApi* | [**ParseJapaneseNameBatch**](docs/JapaneseApi.md#parsejapanesenamebatch) | **POST** /api2/json/parseJapaneseNameBatch | Infer the likely first/last name structure of a name, ex. 山本 早苗 or Yamamoto Sanae 
*PersonalApi* | [**Country**](docs/PersonalApi.md#country) | **GET** /api2/json/country/{personalNameFull} | [USES 10 UNITS PER NAME] Infer the likely country of residence of a personal full name, or one surname. Assumes names as they are in the country of residence OR the country of origin.
*PersonalApi* | [**CountryBatch**](docs/PersonalApi.md#countrybatch) | **POST** /api2/json/countryBatch | [USES 10 UNITS PER NAME] Infer the likely country of residence of up to 100 personal full names, or surnames. Assumes names as they are in the country of residence OR the country of origin.
*PersonalApi* | [**Diaspora**](docs/PersonalApi.md#diaspora) | **GET** /api2/json/diaspora/{countryIso2}/{firstName}/{lastName} | [USES 20 UNITS PER NAME] Infer the likely ethnicity/diaspora of a personal name, given a country of residence ISO2 code (ex. US, CA, AU, NZ etc.)
*PersonalApi* | [**DiasporaBatch**](docs/PersonalApi.md#diasporabatch) | **POST** /api2/json/diasporaBatch | [USES 20 UNITS PER NAME] Infer the likely ethnicity/diaspora of up to 100 personal names, given a country of residence ISO2 code (ex. US, CA, AU, NZ etc.)
*PersonalApi* | [**Gender**](docs/PersonalApi.md#gender) | **GET** /api2/json/gender/{firstName}/{lastName} | Infer the likely gender of a name.
*PersonalApi* | [**GenderBatch**](docs/PersonalApi.md#genderbatch) | **POST** /api2/json/genderBatch | Infer the likely gender of up to 100 names, detecting automatically the cultural context.
*PersonalApi* | [**GenderFull**](docs/PersonalApi.md#genderfull) | **GET** /api2/json/genderFull/{fullName} | Infer the likely gender of a full name, ex. John H. Smith
*PersonalApi* | [**GenderFullBatch**](docs/PersonalApi.md#genderfullbatch) | **POST** /api2/json/genderFullBatch | Infer the likely gender of up to 100 full names, detecting automatically the cultural context.
*PersonalApi* | [**GenderFullGeo**](docs/PersonalApi.md#genderfullgeo) | **GET** /api2/json/genderFullGeo/{fullName}/{countryIso2} | Infer the likely gender of a full name, given a local context (ISO2 country code).
*PersonalApi* | [**GenderFullGeoBatch**](docs/PersonalApi.md#genderfullgeobatch) | **POST** /api2/json/genderFullGeoBatch | Infer the likely gender of up to 100 full names, with a given cultural context (country ISO2 code).
*PersonalApi* | [**GenderGeo**](docs/PersonalApi.md#gendergeo) | **GET** /api2/json/genderGeo/{firstName}/{lastName}/{countryIso2} | Infer the likely gender of a name, given a local context (ISO2 country code).
*PersonalApi* | [**GenderGeoBatch**](docs/PersonalApi.md#gendergeobatch) | **POST** /api2/json/genderGeoBatch | Infer the likely gender of up to 100 names, each given a local context (ISO2 country code).
*PersonalApi* | [**Origin**](docs/PersonalApi.md#origin) | **GET** /api2/json/origin/{firstName}/{lastName} | [USES 10 UNITS PER NAME] Infer the likely country of origin of a personal name. Assumes names as they are in the country of origin. For US, CA, AU, NZ and other melting-pots : use 'diaspora' instead.
*PersonalApi* | [**OriginBatch**](docs/PersonalApi.md#originbatch) | **POST** /api2/json/originBatch | [USES 10 UNITS PER NAME] Infer the likely country of origin of up to 100 names, detecting automatically the cultural context.
*PersonalApi* | [**ParseName**](docs/PersonalApi.md#parsename) | **GET** /api2/json/parseName/{nameFull} | Infer the likely first/last name structure of a name, ex. John Smith or SMITH, John or SMITH; John. 
*PersonalApi* | [**ParseNameBatch**](docs/PersonalApi.md#parsenamebatch) | **POST** /api2/json/parseNameBatch | Infer the likely first/last name structure of a name, ex. John Smith or SMITH, John or SMITH; John.
*PersonalApi* | [**ParseNameGeo**](docs/PersonalApi.md#parsenamegeo) | **GET** /api2/json/parseName/{nameFull}/{countryIso2} | Infer the likely first/last name structure of a name, ex. John Smith or SMITH, John or SMITH; John. For better accuracy, provide a geographic context.
*PersonalApi* | [**ParseNameGeoBatch**](docs/PersonalApi.md#parsenamegeobatch) | **POST** /api2/json/parseNameGeoBatch | Infer the likely first/last name structure of a name, ex. John Smith or SMITH, John or SMITH; John. Giving a local context improves precision. 
*PersonalApi* | [**ParsedGenderBatch**](docs/PersonalApi.md#parsedgenderbatch) | **POST** /api2/json/parsedGenderBatch | Infer the likely gender of up to 100 fully parsed names, detecting automatically the cultural context.
*PersonalApi* | [**ParsedGenderGeoBatch**](docs/PersonalApi.md#parsedgendergeobatch) | **POST** /api2/json/parsedGenderGeoBatch | Infer the likely gender of up to 100 fully parsed names, detecting automatically the cultural context.
*PersonalApi* | [**UsRaceEthnicity**](docs/PersonalApi.md#usraceethnicity) | **GET** /api2/json/usRaceEthnicity/{firstName}/{lastName} | [USES 10 UNITS PER NAME] Infer a US resident's likely race/ethnicity according to US Census taxonomy W_NL (white, non latino), HL (hispano latino),  A (asian, non latino), B_NL (black, non latino).
*PersonalApi* | [**UsRaceEthnicityBatch**](docs/PersonalApi.md#usraceethnicitybatch) | **POST** /api2/json/usRaceEthnicityBatch | [USES 10 UNITS PER NAME] Infer up-to 100 US resident's likely race/ethnicity according to US Census taxonomy.
*PersonalApi* | [**UsRaceEthnicityZIP5**](docs/PersonalApi.md#usraceethnicityzip5) | **GET** /api2/json/usRaceEthnicityZIP5/{firstName}/{lastName}/{zip5Code} | [USES 10 UNITS PER NAME] Infer a US resident's likely race/ethnicity according to US Census taxonomy, using (optional) ZIP5 code info. Output is W_NL (white, non latino), HL (hispano latino),  A (asian, non latino), B_NL (black, non latino).
*PersonalApi* | [**UsZipRaceEthnicityBatch**](docs/PersonalApi.md#uszipraceethnicitybatch) | **POST** /api2/json/usZipRaceEthnicityBatch | [USES 10 UNITS PER NAME] Infer up-to 100 US resident's likely race/ethnicity according to US Census taxonomy, with (optional) ZIP code.
*SocialApi* | [**PhoneCode**](docs/SocialApi.md#phonecode) | **GET** /api2/json/phoneCode/{firstName}/{lastName}/{phoneNumber} | [USES 11 UNITS PER NAME] Infer the likely country and phone prefix, given a personal name and formatted / unformatted phone number.
*SocialApi* | [**PhoneCodeBatch**](docs/SocialApi.md#phonecodebatch) | **POST** /api2/json/phoneCodeBatch | [USES 11 UNITS PER NAME] Infer the likely country and phone prefix, of up to 100 personal names, detecting automatically the local context given a name and formatted / unformatted phone number.
*SocialApi* | [**PhoneCodeGeo**](docs/SocialApi.md#phonecodegeo) | **GET** /api2/json/phoneCodeGeo/{firstName}/{lastName}/{phoneNumber}/{countryIso2} | [USES 11 UNITS PER NAME] Infer the likely phone prefix, given a personal name and formatted / unformatted phone number, with a local context (ISO2 country of residence).
*SocialApi* | [**PhoneCodeGeoBatch**](docs/SocialApi.md#phonecodegeobatch) | **POST** /api2/json/phoneCodeGeoBatch | [USES 11 UNITS PER NAME] Infer the likely country and phone prefix, of up to 100 personal names, with a local context (ISO2 country of residence).
*SocialApi* | [**PhoneCodeGeoFeedbackLoop**](docs/SocialApi.md#phonecodegeofeedbackloop) | **GET** /api2/json/phoneCodeGeoFeedbackLoop/{firstName}/{lastName}/{phoneNumber}/{phoneNumberE164}/{countryIso2} | [CREDITS 1 UNIT] Feedback loop to better infer the likely phone prefix, given a personal name and formatted / unformatted phone number, with a local context (ISO2 country of residence).


<a name="documentation-for-models"></a>
## Documentation for Models

 - [com.namsor.sdk2.model.APIBillingPeriodUsageOut](docs/APIBillingPeriodUsageOut.md)
 - [com.namsor.sdk2.model.APIClassifierOut](docs/APIClassifierOut.md)
 - [com.namsor.sdk2.model.APIClassifierTaxonomyOut](docs/APIClassifierTaxonomyOut.md)
 - [com.namsor.sdk2.model.APIClassifiersStatusOut](docs/APIClassifiersStatusOut.md)
 - [com.namsor.sdk2.model.APICounterV2Out](docs/APICounterV2Out.md)
 - [com.namsor.sdk2.model.APIKeyOut](docs/APIKeyOut.md)
 - [com.namsor.sdk2.model.APIPeriodUsageOut](docs/APIPeriodUsageOut.md)
 - [com.namsor.sdk2.model.APIPlanOut](docs/APIPlanOut.md)
 - [com.namsor.sdk2.model.APIPlanSubscriptionOut](docs/APIPlanSubscriptionOut.md)
 - [com.namsor.sdk2.model.APIPlansOut](docs/APIPlansOut.md)
 - [com.namsor.sdk2.model.APIServiceOut](docs/APIServiceOut.md)
 - [com.namsor.sdk2.model.APIServicesOut](docs/APIServicesOut.md)
 - [com.namsor.sdk2.model.APIUsageAggregatedOut](docs/APIUsageAggregatedOut.md)
 - [com.namsor.sdk2.model.BatchFirstLastNameDiasporaedOut](docs/BatchFirstLastNameDiasporaedOut.md)
 - [com.namsor.sdk2.model.BatchFirstLastNameGenderIn](docs/BatchFirstLastNameGenderIn.md)
 - [com.namsor.sdk2.model.BatchFirstLastNameGenderedOut](docs/BatchFirstLastNameGenderedOut.md)
 - [com.namsor.sdk2.model.BatchFirstLastNameGeoIn](docs/BatchFirstLastNameGeoIn.md)
 - [com.namsor.sdk2.model.BatchFirstLastNameGeoZippedIn](docs/BatchFirstLastNameGeoZippedIn.md)
 - [com.namsor.sdk2.model.BatchFirstLastNameIn](docs/BatchFirstLastNameIn.md)
 - [com.namsor.sdk2.model.BatchFirstLastNameOriginedOut](docs/BatchFirstLastNameOriginedOut.md)
 - [com.namsor.sdk2.model.BatchFirstLastNamePhoneCodedOut](docs/BatchFirstLastNamePhoneCodedOut.md)
 - [com.namsor.sdk2.model.BatchFirstLastNamePhoneNumberGeoIn](docs/BatchFirstLastNamePhoneNumberGeoIn.md)
 - [com.namsor.sdk2.model.BatchFirstLastNamePhoneNumberIn](docs/BatchFirstLastNamePhoneNumberIn.md)
 - [com.namsor.sdk2.model.BatchFirstLastNameUSRaceEthnicityOut](docs/BatchFirstLastNameUSRaceEthnicityOut.md)
 - [com.namsor.sdk2.model.BatchMatchPersonalFirstLastNameIn](docs/BatchMatchPersonalFirstLastNameIn.md)
 - [com.namsor.sdk2.model.BatchNameMatchCandidatesOut](docs/BatchNameMatchCandidatesOut.md)
 - [com.namsor.sdk2.model.BatchNameMatchedOut](docs/BatchNameMatchedOut.md)
 - [com.namsor.sdk2.model.BatchParsedFullNameGeoIn](docs/BatchParsedFullNameGeoIn.md)
 - [com.namsor.sdk2.model.BatchParsedFullNameIn](docs/BatchParsedFullNameIn.md)
 - [com.namsor.sdk2.model.BatchPersonalNameGenderedOut](docs/BatchPersonalNameGenderedOut.md)
 - [com.namsor.sdk2.model.BatchPersonalNameGeoIn](docs/BatchPersonalNameGeoIn.md)
 - [com.namsor.sdk2.model.BatchPersonalNameGeoOut](docs/BatchPersonalNameGeoOut.md)
 - [com.namsor.sdk2.model.BatchPersonalNameIn](docs/BatchPersonalNameIn.md)
 - [com.namsor.sdk2.model.BatchPersonalNameParsedOut](docs/BatchPersonalNameParsedOut.md)
 - [com.namsor.sdk2.model.BillingHistoryOut](docs/BillingHistoryOut.md)
 - [com.namsor.sdk2.model.BillingInfoInOut](docs/BillingInfoInOut.md)
 - [com.namsor.sdk2.model.CacheMetricsOut](docs/CacheMetricsOut.md)
 - [com.namsor.sdk2.model.ClassifierMetricsOut](docs/ClassifierMetricsOut.md)
 - [com.namsor.sdk2.model.CurrenciesOut](docs/CurrenciesOut.md)
 - [com.namsor.sdk2.model.DeployUIOut](docs/DeployUIOut.md)
 - [com.namsor.sdk2.model.ExpectedClassMetricsOut](docs/ExpectedClassMetricsOut.md)
 - [com.namsor.sdk2.model.FeedbackLoopOut](docs/FeedbackLoopOut.md)
 - [com.namsor.sdk2.model.FirstLastNameDiasporaedOut](docs/FirstLastNameDiasporaedOut.md)
 - [com.namsor.sdk2.model.FirstLastNameGenderIn](docs/FirstLastNameGenderIn.md)
 - [com.namsor.sdk2.model.FirstLastNameGenderedOut](docs/FirstLastNameGenderedOut.md)
 - [com.namsor.sdk2.model.FirstLastNameGeoIn](docs/FirstLastNameGeoIn.md)
 - [com.namsor.sdk2.model.FirstLastNameGeoZippedIn](docs/FirstLastNameGeoZippedIn.md)
 - [com.namsor.sdk2.model.FirstLastNameIn](docs/FirstLastNameIn.md)
 - [com.namsor.sdk2.model.FirstLastNameOriginedOut](docs/FirstLastNameOriginedOut.md)
 - [com.namsor.sdk2.model.FirstLastNameOut](docs/FirstLastNameOut.md)
 - [com.namsor.sdk2.model.FirstLastNamePhoneCodedOut](docs/FirstLastNamePhoneCodedOut.md)
 - [com.namsor.sdk2.model.FirstLastNamePhoneNumberGeoIn](docs/FirstLastNamePhoneNumberGeoIn.md)
 - [com.namsor.sdk2.model.FirstLastNamePhoneNumberIn](docs/FirstLastNamePhoneNumberIn.md)
 - [com.namsor.sdk2.model.FirstLastNameUSRaceEthnicityOut](docs/FirstLastNameUSRaceEthnicityOut.md)
 - [com.namsor.sdk2.model.InlineObject](docs/InlineObject.md)
 - [com.namsor.sdk2.model.InvoiceItemOut](docs/InvoiceItemOut.md)
 - [com.namsor.sdk2.model.InvoiceOut](docs/InvoiceOut.md)
 - [com.namsor.sdk2.model.MatchPersonalFirstLastNameIn](docs/MatchPersonalFirstLastNameIn.md)
 - [com.namsor.sdk2.model.NamSorCounterOut](docs/NamSorCounterOut.md)
 - [com.namsor.sdk2.model.NameMatchCandidateOut](docs/NameMatchCandidateOut.md)
 - [com.namsor.sdk2.model.NameMatchCandidatesOut](docs/NameMatchCandidatesOut.md)
 - [com.namsor.sdk2.model.NameMatchedOut](docs/NameMatchedOut.md)
 - [com.namsor.sdk2.model.ParsedFullNameGeoIn](docs/ParsedFullNameGeoIn.md)
 - [com.namsor.sdk2.model.ParsedFullNameIn](docs/ParsedFullNameIn.md)
 - [com.namsor.sdk2.model.PersonalNameGenderedOut](docs/PersonalNameGenderedOut.md)
 - [com.namsor.sdk2.model.PersonalNameGeoIn](docs/PersonalNameGeoIn.md)
 - [com.namsor.sdk2.model.PersonalNameGeoOut](docs/PersonalNameGeoOut.md)
 - [com.namsor.sdk2.model.PersonalNameIn](docs/PersonalNameIn.md)
 - [com.namsor.sdk2.model.PersonalNameParsedOut](docs/PersonalNameParsedOut.md)
 - [com.namsor.sdk2.model.ProperNounCategorizedOut](docs/ProperNounCategorizedOut.md)
 - [com.namsor.sdk2.model.RomanizedNameOut](docs/RomanizedNameOut.md)
 - [com.namsor.sdk2.model.SoftwareVersionOut](docs/SoftwareVersionOut.md)
 - [com.namsor.sdk2.model.SourceDetailedMetricsOut](docs/SourceDetailedMetricsOut.md)
 - [com.namsor.sdk2.model.SourceMetricsOut](docs/SourceMetricsOut.md)
 - [com.namsor.sdk2.model.StripeCardOut](docs/StripeCardOut.md)
 - [com.namsor.sdk2.model.StripeCustomerOut](docs/StripeCustomerOut.md)
 - [com.namsor.sdk2.model.SystemMetricsOut](docs/SystemMetricsOut.md)
 - [com.namsor.sdk2.model.UserInfoOut](docs/UserInfoOut.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="api_key"></a>
### api_key

- **Type**: API key
- **API key parameter name**: X-API-KEY
- **Location**: HTTP header

