# pricelist.Api.PriceListApi

All URIs are relative to *https://pricelist.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePriceList**](PriceListApi.md#createpricelist) | **POST** /pricelist.PriceList/CreatePriceList | Create new list |
| [**DeletePriceListItems**](PriceListApi.md#deletepricelistitems) | **POST** /pricelist.PriceList/DeletePriceListItems | Get prices for items |
| [**GetFullPriceItemsByPricelistId**](PriceListApi.md#getfullpriceitemsbypricelistid) | **POST** /pricelist.PriceList/GetFullPriceItemsByPricelistId | List detailed items |
| [**GetPriceList**](PriceListApi.md#getpricelist) | **POST** /pricelist.PriceList/GetPriceList | Get specific list |
| [**GetPriceListByCode**](PriceListApi.md#getpricelistbycode) | **POST** /pricelist.PriceList/GetPriceListByCode | Get list by code |
| [**GetPriceListItems**](PriceListApi.md#getpricelistitems) | **POST** /pricelist.PriceList/GetPriceListItems | Get items in list |
| [**GetPricesItems**](PriceListApi.md#getpricesitems) | **POST** /pricelist.PriceList/GetPricesItems | Get detailed items |
| [**ListFullPriceItemsByPricelistId**](PriceListApi.md#listfullpriceitemsbypricelistid) | **POST** /pricelist.PriceList/ListFullPriceItemsByPricelistId | List detailed price items for a specific price list |
| [**ListPriceLists**](PriceListApi.md#listpricelists) | **POST** /pricelist.PriceList/ListPriceLists | List all price lists |
| [**PriceListGetPriceItemsByPriceListItemIds**](PriceListApi.md#pricelistgetpriceitemsbypricelistitemids) | **POST** /pricelist.PriceList/GetPriceItemsByPriceListItemIds |  |
| [**SetPriceListItems**](PriceListApi.md#setpricelistitems) | **POST** /pricelist.PriceList/SetPriceListItems | Set items in list |
| [**UpdatePriceList**](PriceListApi.md#updatepricelist) | **POST** /pricelist.PriceList/UpdatePriceList | Update list |

<a id="createpricelist"></a>
# **CreatePriceList**
> PricelistCreatePriceListResponse CreatePriceList (PricelistCreatePriceListRequest body)

Create new list

Allows the creation of a new price list with specified details such as code, name, currency, and type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class CreatePriceListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://pricelist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PriceListApi(config);
            var body = new PricelistCreatePriceListRequest(); // PricelistCreatePriceListRequest | 

            try
            {
                // Create new list
                PricelistCreatePriceListResponse result = apiInstance.CreatePriceList(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.CreatePriceList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePriceListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create new list
    ApiResponse<PricelistCreatePriceListResponse> response = apiInstance.CreatePriceListWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.CreatePriceListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PricelistCreatePriceListRequest**](PricelistCreatePriceListRequest.md) |  |  |

### Return type

[**PricelistCreatePriceListResponse**](PricelistCreatePriceListResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletepricelistitems"></a>
# **DeletePriceListItems**
> Object DeletePriceListItems (PricelistDeletePriceListItemsRequest body)

Get prices for items

Deletes specified items from a price list based on their unique identifiers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class DeletePriceListItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://pricelist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PriceListApi(config);
            var body = new PricelistDeletePriceListItemsRequest(); // PricelistDeletePriceListItemsRequest | 

            try
            {
                // Get prices for items
                Object result = apiInstance.DeletePriceListItems(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.DeletePriceListItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePriceListItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get prices for items
    ApiResponse<Object> response = apiInstance.DeletePriceListItemsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.DeletePriceListItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PricelistDeletePriceListItemsRequest**](PricelistDeletePriceListItemsRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfullpriceitemsbypricelistid"></a>
# **GetFullPriceItemsByPricelistId**
> PricelistGetFullPriceItemsResponse GetFullPriceItemsByPricelistId (PricelistGetFullPriceItemsRequest body)

List detailed items

Fetches detailed information about items, including historical price data, for a specific price list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class GetFullPriceItemsByPricelistIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://pricelist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PriceListApi(config);
            var body = new PricelistGetFullPriceItemsRequest(); // PricelistGetFullPriceItemsRequest | 

            try
            {
                // List detailed items
                PricelistGetFullPriceItemsResponse result = apiInstance.GetFullPriceItemsByPricelistId(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.GetFullPriceItemsByPricelistId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFullPriceItemsByPricelistIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List detailed items
    ApiResponse<PricelistGetFullPriceItemsResponse> response = apiInstance.GetFullPriceItemsByPricelistIdWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.GetFullPriceItemsByPricelistIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PricelistGetFullPriceItemsRequest**](PricelistGetFullPriceItemsRequest.md) |  |  |

### Return type

[**PricelistGetFullPriceItemsResponse**](PricelistGetFullPriceItemsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpricelist"></a>
# **GetPriceList**
> PricelistGetPriceListResponse GetPriceList (PricelistGetPriceListRequest body)

Get specific list

Returns information about a particular price list identified by tenant ID and price list ID. The response includes details such as code, name, currency, and type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class GetPriceListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://pricelist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PriceListApi(config);
            var body = new PricelistGetPriceListRequest(); // PricelistGetPriceListRequest | 

            try
            {
                // Get specific list
                PricelistGetPriceListResponse result = apiInstance.GetPriceList(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.GetPriceList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPriceListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get specific list
    ApiResponse<PricelistGetPriceListResponse> response = apiInstance.GetPriceListWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.GetPriceListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PricelistGetPriceListRequest**](PricelistGetPriceListRequest.md) |  |  |

### Return type

[**PricelistGetPriceListResponse**](PricelistGetPriceListResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpricelistbycode"></a>
# **GetPriceListByCode**
> PricelistGetPriceListByCodeResponse GetPriceListByCode (PricelistGetPriceListByCodeRequest body)

Get list by code

Retrieves information about a specific price list using the unique code associated with it. The response includes details such as code, name, currency, and type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class GetPriceListByCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://pricelist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PriceListApi(config);
            var body = new PricelistGetPriceListByCodeRequest(); // PricelistGetPriceListByCodeRequest | 

            try
            {
                // Get list by code
                PricelistGetPriceListByCodeResponse result = apiInstance.GetPriceListByCode(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.GetPriceListByCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPriceListByCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list by code
    ApiResponse<PricelistGetPriceListByCodeResponse> response = apiInstance.GetPriceListByCodeWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.GetPriceListByCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PricelistGetPriceListByCodeRequest**](PricelistGetPriceListByCodeRequest.md) |  |  |

### Return type

[**PricelistGetPriceListByCodeResponse**](PricelistGetPriceListByCodeResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpricelistitems"></a>
# **GetPriceListItems**
> PricelistGetPriceListItemsResponse GetPriceListItems (PricelistGetPriceListItemsRequest body)

Get items in list

Fetches a paginated list of items associated with a particular price list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class GetPriceListItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://pricelist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PriceListApi(config);
            var body = new PricelistGetPriceListItemsRequest(); // PricelistGetPriceListItemsRequest | 

            try
            {
                // Get items in list
                PricelistGetPriceListItemsResponse result = apiInstance.GetPriceListItems(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.GetPriceListItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPriceListItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get items in list
    ApiResponse<PricelistGetPriceListItemsResponse> response = apiInstance.GetPriceListItemsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.GetPriceListItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PricelistGetPriceListItemsRequest**](PricelistGetPriceListItemsRequest.md) |  |  |

### Return type

[**PricelistGetPriceListItemsResponse**](PricelistGetPriceListItemsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpricesitems"></a>
# **GetPricesItems**
> PricelistGetPricesResponse GetPricesItems (PricelistGetPricesRequest body)

Get detailed items

Retrieves the current prices of specified items considering the provided context, such as currency and market.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class GetPricesItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://pricelist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PriceListApi(config);
            var body = new PricelistGetPricesRequest(); // PricelistGetPricesRequest | 

            try
            {
                // Get detailed items
                PricelistGetPricesResponse result = apiInstance.GetPricesItems(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.GetPricesItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPricesItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get detailed items
    ApiResponse<PricelistGetPricesResponse> response = apiInstance.GetPricesItemsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.GetPricesItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PricelistGetPricesRequest**](PricelistGetPricesRequest.md) |  |  |

### Return type

[**PricelistGetPricesResponse**](PricelistGetPricesResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listfullpriceitemsbypricelistid"></a>
# **ListFullPriceItemsByPricelistId**
> PricelistListFullPriceItemsResponse ListFullPriceItemsByPricelistId (PricelistListFullPriceItemsRequest body)

List detailed price items for a specific price list

Retrieves a paginated list of detailed price items, including historical data, for a specific price list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class ListFullPriceItemsByPricelistIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://pricelist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PriceListApi(config);
            var body = new PricelistListFullPriceItemsRequest(); // PricelistListFullPriceItemsRequest | 

            try
            {
                // List detailed price items for a specific price list
                PricelistListFullPriceItemsResponse result = apiInstance.ListFullPriceItemsByPricelistId(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.ListFullPriceItemsByPricelistId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFullPriceItemsByPricelistIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List detailed price items for a specific price list
    ApiResponse<PricelistListFullPriceItemsResponse> response = apiInstance.ListFullPriceItemsByPricelistIdWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.ListFullPriceItemsByPricelistIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PricelistListFullPriceItemsRequest**](PricelistListFullPriceItemsRequest.md) |  |  |

### Return type

[**PricelistListFullPriceItemsResponse**](PricelistListFullPriceItemsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listpricelists"></a>
# **ListPriceLists**
> PricelistListPriceListsResponse ListPriceLists (PricelistListPriceListsRequest body)

List all price lists

Retrieves a list of price lists based on optional filters such as name, code, and other attributes. The response includes details such as code, name, currency, and type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class ListPriceListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://pricelist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PriceListApi(config);
            var body = new PricelistListPriceListsRequest(); // PricelistListPriceListsRequest | 

            try
            {
                // List all price lists
                PricelistListPriceListsResponse result = apiInstance.ListPriceLists(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.ListPriceLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPriceListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all price lists
    ApiResponse<PricelistListPriceListsResponse> response = apiInstance.ListPriceListsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.ListPriceListsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PricelistListPriceListsRequest**](PricelistListPriceListsRequest.md) |  |  |

### Return type

[**PricelistListPriceListsResponse**](PricelistListPriceListsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pricelistgetpriceitemsbypricelistitemids"></a>
# **PriceListGetPriceItemsByPriceListItemIds**
> PricelistGetPriceItemsByPriceListItemIdsResponse PriceListGetPriceItemsByPriceListItemIds (PricelistGetPriceItemsByPriceListItemIdsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class PriceListGetPriceItemsByPriceListItemIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://pricelist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PriceListApi(config);
            var body = new PricelistGetPriceItemsByPriceListItemIdsRequest(); // PricelistGetPriceItemsByPriceListItemIdsRequest | 

            try
            {
                PricelistGetPriceItemsByPriceListItemIdsResponse result = apiInstance.PriceListGetPriceItemsByPriceListItemIds(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.PriceListGetPriceItemsByPriceListItemIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PriceListGetPriceItemsByPriceListItemIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PricelistGetPriceItemsByPriceListItemIdsResponse> response = apiInstance.PriceListGetPriceItemsByPriceListItemIdsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.PriceListGetPriceItemsByPriceListItemIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PricelistGetPriceItemsByPriceListItemIdsRequest**](PricelistGetPriceItemsByPriceListItemIdsRequest.md) |  |  |

### Return type

[**PricelistGetPriceItemsByPriceListItemIdsResponse**](PricelistGetPriceItemsByPriceListItemIdsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setpricelistitems"></a>
# **SetPriceListItems**
> PricelistSetPriceListItemsResponse SetPriceListItems (PricelistSetPriceListItemsRequest body)

Set items in list

Updates or creates items for a given price list, allowing bulk modifications.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class SetPriceListItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://pricelist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PriceListApi(config);
            var body = new PricelistSetPriceListItemsRequest(); // PricelistSetPriceListItemsRequest | 

            try
            {
                // Set items in list
                PricelistSetPriceListItemsResponse result = apiInstance.SetPriceListItems(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.SetPriceListItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetPriceListItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set items in list
    ApiResponse<PricelistSetPriceListItemsResponse> response = apiInstance.SetPriceListItemsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.SetPriceListItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PricelistSetPriceListItemsRequest**](PricelistSetPriceListItemsRequest.md) |  |  |

### Return type

[**PricelistSetPriceListItemsResponse**](PricelistSetPriceListItemsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatepricelist"></a>
# **UpdatePriceList**
> Object UpdatePriceList (PricelistUpdatePriceListRequest body)

Update list

Modifies the attributes of an existing price list based on the provided payload and field mask. The field mask is used to specify which attributes of the price list are to be updated. The field mask is a comma-separated list of fully qualified names of fields. Example: `code,name,currency,type`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class UpdatePriceListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://pricelist.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PriceListApi(config);
            var body = new PricelistUpdatePriceListRequest(); // PricelistUpdatePriceListRequest | 

            try
            {
                // Update list
                Object result = apiInstance.UpdatePriceList(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.UpdatePriceList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePriceListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update list
    ApiResponse<Object> response = apiInstance.UpdatePriceListWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.UpdatePriceListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PricelistUpdatePriceListRequest**](PricelistUpdatePriceListRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

