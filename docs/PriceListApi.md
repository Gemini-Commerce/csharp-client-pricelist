# pricelist.Api.PriceListApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PriceListCreatePriceList**](PriceListApi.md#pricelistcreatepricelist) | **POST** /pricelist.PriceList/CreatePriceList |  |
| [**PriceListDeletePriceListItems**](PriceListApi.md#pricelistdeletepricelistitems) | **POST** /pricelist.PriceList/DeletePriceListItems |  |
| [**PriceListGetFullPriceItemsByPricelistId**](PriceListApi.md#pricelistgetfullpriceitemsbypricelistid) | **POST** /pricelist.PriceList/GetFullPriceItemsByPricelistId |  |
| [**PriceListGetPriceItemsByPriceListItemIds**](PriceListApi.md#pricelistgetpriceitemsbypricelistitemids) | **POST** /pricelist.PriceList/GetPriceItemsByPriceListItemIds |  |
| [**PriceListGetPriceList**](PriceListApi.md#pricelistgetpricelist) | **POST** /pricelist.PriceList/GetPriceList |  |
| [**PriceListGetPriceListByCode**](PriceListApi.md#pricelistgetpricelistbycode) | **POST** /pricelist.PriceList/GetPriceListByCode |  |
| [**PriceListGetPriceListItems**](PriceListApi.md#pricelistgetpricelistitems) | **POST** /pricelist.PriceList/GetPriceListItems |  |
| [**PriceListGetPricesItems**](PriceListApi.md#pricelistgetpricesitems) | **POST** /pricelist.PriceList/GetPricesItems |  |
| [**PriceListListFullPriceItemsByPricelistId**](PriceListApi.md#pricelistlistfullpriceitemsbypricelistid) | **POST** /pricelist.PriceList/ListFullPriceItemsByPricelistId |  |
| [**PriceListListPriceLists**](PriceListApi.md#pricelistlistpricelists) | **POST** /pricelist.PriceList/ListPriceLists |  |
| [**PriceListSetPriceListItems**](PriceListApi.md#pricelistsetpricelistitems) | **POST** /pricelist.PriceList/SetPriceListItems |  |
| [**PriceListUpdatePriceList**](PriceListApi.md#pricelistupdatepricelist) | **POST** /pricelist.PriceList/UpdatePriceList |  |

<a id="pricelistcreatepricelist"></a>
# **PriceListCreatePriceList**
> PricelistCreatePriceListResponse PriceListCreatePriceList (PricelistCreatePriceListRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class PriceListCreatePriceListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PriceListApi(config);
            var body = new PricelistCreatePriceListRequest(); // PricelistCreatePriceListRequest | 

            try
            {
                PricelistCreatePriceListResponse result = apiInstance.PriceListCreatePriceList(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.PriceListCreatePriceList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PriceListCreatePriceListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PricelistCreatePriceListResponse> response = apiInstance.PriceListCreatePriceListWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.PriceListCreatePriceListWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pricelistdeletepricelistitems"></a>
# **PriceListDeletePriceListItems**
> Object PriceListDeletePriceListItems (PricelistDeletePriceListItemsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class PriceListDeletePriceListItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PriceListApi(config);
            var body = new PricelistDeletePriceListItemsRequest(); // PricelistDeletePriceListItemsRequest | 

            try
            {
                Object result = apiInstance.PriceListDeletePriceListItems(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.PriceListDeletePriceListItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PriceListDeletePriceListItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.PriceListDeletePriceListItemsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.PriceListDeletePriceListItemsWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pricelistgetfullpriceitemsbypricelistid"></a>
# **PriceListGetFullPriceItemsByPricelistId**
> PricelistGetFullPriceItemsResponse PriceListGetFullPriceItemsByPricelistId (PricelistGetFullPriceItemsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class PriceListGetFullPriceItemsByPricelistIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PriceListApi(config);
            var body = new PricelistGetFullPriceItemsRequest(); // PricelistGetFullPriceItemsRequest | 

            try
            {
                PricelistGetFullPriceItemsResponse result = apiInstance.PriceListGetFullPriceItemsByPricelistId(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.PriceListGetFullPriceItemsByPricelistId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PriceListGetFullPriceItemsByPricelistIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PricelistGetFullPriceItemsResponse> response = apiInstance.PriceListGetFullPriceItemsByPricelistIdWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.PriceListGetFullPriceItemsByPricelistIdWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
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
            config.BasePath = "http://localhost";
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pricelistgetpricelist"></a>
# **PriceListGetPriceList**
> PricelistGetPriceListResponse PriceListGetPriceList (PricelistGetPriceListRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class PriceListGetPriceListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PriceListApi(config);
            var body = new PricelistGetPriceListRequest(); // PricelistGetPriceListRequest | 

            try
            {
                PricelistGetPriceListResponse result = apiInstance.PriceListGetPriceList(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.PriceListGetPriceList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PriceListGetPriceListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PricelistGetPriceListResponse> response = apiInstance.PriceListGetPriceListWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.PriceListGetPriceListWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pricelistgetpricelistbycode"></a>
# **PriceListGetPriceListByCode**
> PricelistGetPriceListByCodeResponse PriceListGetPriceListByCode (PricelistGetPriceListByCodeRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class PriceListGetPriceListByCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PriceListApi(config);
            var body = new PricelistGetPriceListByCodeRequest(); // PricelistGetPriceListByCodeRequest | 

            try
            {
                PricelistGetPriceListByCodeResponse result = apiInstance.PriceListGetPriceListByCode(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.PriceListGetPriceListByCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PriceListGetPriceListByCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PricelistGetPriceListByCodeResponse> response = apiInstance.PriceListGetPriceListByCodeWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.PriceListGetPriceListByCodeWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pricelistgetpricelistitems"></a>
# **PriceListGetPriceListItems**
> PricelistGetPriceListItemsResponse PriceListGetPriceListItems (PricelistGetPriceListItemsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class PriceListGetPriceListItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PriceListApi(config);
            var body = new PricelistGetPriceListItemsRequest(); // PricelistGetPriceListItemsRequest | 

            try
            {
                PricelistGetPriceListItemsResponse result = apiInstance.PriceListGetPriceListItems(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.PriceListGetPriceListItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PriceListGetPriceListItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PricelistGetPriceListItemsResponse> response = apiInstance.PriceListGetPriceListItemsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.PriceListGetPriceListItemsWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pricelistgetpricesitems"></a>
# **PriceListGetPricesItems**
> PricelistGetPricesResponse PriceListGetPricesItems (PricelistGetPricesRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class PriceListGetPricesItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PriceListApi(config);
            var body = new PricelistGetPricesRequest(); // PricelistGetPricesRequest | 

            try
            {
                PricelistGetPricesResponse result = apiInstance.PriceListGetPricesItems(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.PriceListGetPricesItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PriceListGetPricesItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PricelistGetPricesResponse> response = apiInstance.PriceListGetPricesItemsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.PriceListGetPricesItemsWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pricelistlistfullpriceitemsbypricelistid"></a>
# **PriceListListFullPriceItemsByPricelistId**
> PricelistListFullPriceItemsResponse PriceListListFullPriceItemsByPricelistId (PricelistListFullPriceItemsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class PriceListListFullPriceItemsByPricelistIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PriceListApi(config);
            var body = new PricelistListFullPriceItemsRequest(); // PricelistListFullPriceItemsRequest | 

            try
            {
                PricelistListFullPriceItemsResponse result = apiInstance.PriceListListFullPriceItemsByPricelistId(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.PriceListListFullPriceItemsByPricelistId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PriceListListFullPriceItemsByPricelistIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PricelistListFullPriceItemsResponse> response = apiInstance.PriceListListFullPriceItemsByPricelistIdWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.PriceListListFullPriceItemsByPricelistIdWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pricelistlistpricelists"></a>
# **PriceListListPriceLists**
> PricelistListPriceListsResponse PriceListListPriceLists (PricelistListPriceListsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class PriceListListPriceListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PriceListApi(config);
            var body = new PricelistListPriceListsRequest(); // PricelistListPriceListsRequest | 

            try
            {
                PricelistListPriceListsResponse result = apiInstance.PriceListListPriceLists(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.PriceListListPriceLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PriceListListPriceListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PricelistListPriceListsResponse> response = apiInstance.PriceListListPriceListsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.PriceListListPriceListsWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pricelistsetpricelistitems"></a>
# **PriceListSetPriceListItems**
> PricelistSetPriceListItemsResponse PriceListSetPriceListItems (PricelistSetPriceListItemsRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class PriceListSetPriceListItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PriceListApi(config);
            var body = new PricelistSetPriceListItemsRequest(); // PricelistSetPriceListItemsRequest | 

            try
            {
                PricelistSetPriceListItemsResponse result = apiInstance.PriceListSetPriceListItems(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.PriceListSetPriceListItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PriceListSetPriceListItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PricelistSetPriceListItemsResponse> response = apiInstance.PriceListSetPriceListItemsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.PriceListSetPriceListItemsWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pricelistupdatepricelist"></a>
# **PriceListUpdatePriceList**
> Object PriceListUpdatePriceList (PricelistUpdatePriceListRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using pricelist.Api;
using pricelist.Client;
using pricelist.Model;

namespace Example
{
    public class PriceListUpdatePriceListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PriceListApi(config);
            var body = new PricelistUpdatePriceListRequest(); // PricelistUpdatePriceListRequest | 

            try
            {
                Object result = apiInstance.PriceListUpdatePriceList(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PriceListApi.PriceListUpdatePriceList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PriceListUpdatePriceListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.PriceListUpdatePriceListWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PriceListApi.PriceListUpdatePriceListWithHttpInfo: " + e.Message);
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

