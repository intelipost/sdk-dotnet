# SDK .NET - Intelipost API V1

## Introdução
SDK para auxiliar no consumo de alguns endpoints existentes na [API V1](http://api.intelipost.com.br/v1), conforme [documentação](https://docs.intelipost.com.br/v1/introducao/guia-rapido).

## Instalação

Instalar utilizando o [NuGet](https://www.nuget.org/packages/api-intelipost/).
Para instalar o SDK, execute o seguinte comando no [Package Manager Console](http://docs.nuget.org/docs/start-here/using-the-package-manager-console)
```
PM> Install-Package InteliPost.API
```

## Dependências
- .NETFramework ≥ 4.0
- Newtonsoft.Json (≥ 7.0.1)


## Uso

Para utilizar o SDK é necessário:

1. Instanciar a classe "Intelipost.API.Configure" que fornecerá informações para os endpoints, com seus parâmetros:
* **Api-Key** - Chave de autenticação fornecida pela Intelipost
* **Platform** - Plataforma origem da requisição
* **Platform-version** - A versão atual da plataforma
* **Plugin** - Nome do conector utilizado
* **Plugin-version** - Versão do conector utilizado
* **Logging** - Flag que diz se deverão ser gravados logs
* **LogPath** - Se forem gravados logs, aqui deve ser informado o diretório

## Endpoints Disponíveis

* **AutoComplete** - GET ( */cep_location/address_complete/{cep}* )

```csharp
    new Configure().Initialize("Api-Key", false, "", platform: "my-ecommerce", platformVersion: "v1.0", plugin: "my-connector", pluginVersion: "v1.1.2");

    var modelResponse = new API.AutoComplete().RequestAutoComplete("04012080");      
```

* **ChangeDeliveryMethod** - POST ( */shipment_order/change_delivery_method* )

```csharp
    new Configure().Initialize("Api-Key", false, "", platform: "my-ecommerce", platformVersion: "v1.0", plugin: "my-connector", pluginVersion: "v1.1.2");

    var vol1 = new ChangeDeliveryMethodVolumes()
    {
        VolumeNumber = "676639",
        TrackingCode = "SW123456789BR",
    };

    var vol2 = new ChangeDeliveryMethodVolumes()
    {
        VolumeNumber = "676640",
        TrackingCode = "SW123456789BR",
    };

    var volumeArrayList = new List<ChangeDeliveryMethodVolumes>();
    volumeArrayList.Add(vol1);
    volumeArrayList.Add(vol2);

    var modelRequest = new Request<ChangeDeliveryMethod>()
    {
        Content = new ChangeDeliveryMethod()
        {
            DeliveryMethodId = 2,
            OrderNumber = "sdk0003",
            QuoteId = null,
            ClientId = 2354,
            EstimatedDeliveryDate = new DateTime(2016, 04, 20),
            Volumes = volumeArrayList
        }
    };
```

* **GetLabel** - GET ( */shipment_order/get_label/{order_number}/{shipment_order_volume_number}* )

```csharp
    new Configure().Initialize("Api-Key", false, "", platform: "my-ecommerce", platformVersion: "v1.0", plugin: "my-connector", pluginVersion: "v1.1.2");

    var modelResponse = new API.GetLabel().RequestGetLabel("sdk0001","1");
```

* **GetShipmentOrder** - GET ( */shipment_order/{order_number}* )

```csharp
    new Configure().Initialize("Api-Key", false, "", platform: "my-ecommerce", platformVersion: "v1.0", plugin: "my-connector", pluginVersion: "v1.1.2");

    var modelResponse = new API.GetShipmentOrder().RequestGetShipmentOrder("PEDIDO-013");
```

* **Info** - GET ( */info* )

```csharp
    new Configure().Initialize("Api-Key", false, "", platform: "my-ecommerce", platformVersion: "v1.0", plugin: "my-connector", pluginVersion: "v1.1.2");

    var modelResponse = new API.Info().RequestInfo();
```

* **Quote** - POST ( */quote* )

```csharp
    new Configure().Initialize("Api-Key", false, "", platform: "my-ecommerce", platformVersion: "v1.0", plugin: "my-connector", pluginVersion: "v1.1.2");

    var volumes = new List<Volume>();
    var volume1 = new Volume()
    {
        CostOfGoods = 15.99,
        Height = 10,
        Length = 25,
        VolumeType = VolumeType.Envelope,
        Weight = 10,
        Width = 10
    };

    var volume2 = new Volume()
    {
        CostOfGoods = 30.99,
        Height = 10,
        Length = 25,
        VolumeType = VolumeType.Box,
        Weight = 2,
        Width = 20
    };

    volumes.Add(volume1);
    volumes.Add(volume2);
    AddtionalInformation ad = new AddtionalInformation();

    var modelRequest = new Request<Quote>()
    {
        Content = new Quote()
        {
            OriginZipCode = "01001-000",
            DestinationZipCode = "20000-000",
            Volumes = volumes,
            AddtionalInformation = new AddtionalInformation() {
                FreeShipping = false,
                ExtraCostsAbsolute = 0,
                ExtraCostsPercentage = 0,
                LeadTimeBussinessDays = 0,
                DeliveryMethodIds = new int[] {1,2}               
            },     
            Identification = new Identification() {
                Url = "www.teste.com",
                PageName = "Page Test",
                ip = "192.168.0.1",
                Session = "123456789"
            }             
        }
    };
    
    var modelResponse = new API.Quote().RequestNewQuote(modelRequest);
```

* **QuoteByProduct** - POST ( */quote_by_product* )

```csharp
    new Configure().Initialize("Api-Key", false, "", platform: "my-ecommerce", platformVersion: "v1.0", plugin: "my-connector", pluginVersion: "v1.1.2");

    Products produto1 = new Products() {
        Weight = 1,
        CostOfGoods = 2,
        Width = 0.1,
        Height = 0.1,
        Length = 0.1,
        Quantity = 1,
        SkuId = "123",
        description = "produto 1",
        ProductCategory = "cat01",
        CanGroup = false
    };

    Products produto2 = new Products()
    {
        Weight = 1,
        CostOfGoods = 2,
        Width = 0.1,
        Height = 0.1,
        Length = 0.1,
        Quantity = 1,
        SkuId = "123",
        description = "produto 1",
        ProductCategory = "cat01",
        CanGroup = false
    };

    List<Products> produtos = new List<Products>();
    produtos.Add(produto1);
    produtos.Add(produto2);

    var modelRequest = new Request<Quote>()
    {
        Content = new Quote()
        {
            OriginZipCode = "01001-000",
            DestinationZipCode = "20000-000",
            Products = produtos,
            AddtionalInformation = new AddtionalInformation() {
                FreeShipping = false,
                ExtraCostsAbsolute = 0,
                ExtraCostsPercentage = 0,
                LeadTimeBussinessDays = 0,
                DeliveryMethodIds = new int[] { 1, 2 },
                ShippedDate = (DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString()).ToString()
            }        
        }
    };
    
    var modelResponse = new API.QuoteByProduct().RequestNewQuoteByProduct(modelRequest);
```

* **ReadyForShipmentWithDate** - POST ( */shipment_order/multi/ready_for_shipment/with_date* )

```csharp
    new Configure().Initialize("Api-Key", false, "", platform: "my-ecommerce", platformVersion: "v1.0", plugin: "my-connector", pluginVersion: "v1.1.2");

    ReadyForShipmentWithDate[] orderArray = new ReadyForShipmentWithDate[2];
    orderArray[0] = new ReadyForShipmentWithDate()
    {
        OrderNumber = "PEDIDO-004",
        EventDate = String.Format("{0:s}", DateTime.Now)
    };

    orderArray[1] = new ReadyForShipmentWithDate()
    {
        OrderNumber = "PEDIDO-003",
        EventDate = String.Format("{0:s}", DateTime.Now)
    };

    var modelRequest = new Request<ReadyForShipmentWithDate[]>()
    {
        Content = orderArray
    };
    
    var modelResponse = new API.ReadyForShipmentWithDate().RequestNewReadyForShipmentWithDate(modelRequest);
```

* **ShipmentOrder** - POST ( */shipment_order* )

```csharp
    new Configure().Initialize("Api-Key", false, "", platform: "my-ecommerce", platformVersion: "v1.0", plugin: "my-connector", pluginVersion: "v1.1.2");

    var endCustomer = new EndCustomer()
    {
        FirstName = "Unit",
        LastName = "Test",
        Email = "teste@teste.com",
        Phone = "00231424551",
        Cellphone = "11999999999",
        IsCompany = false,
        FederalTaxPayerId = "44611341801",
        StateTaxPayerId = "2314234",
        ShippingAddress = "Avenida Paulista",
        ShippingNumber = "2",
        ShippingAdditional = "apto 202",
        ShippingReference = "mercado test",
        ShippingQuarter = "Consolação",
        ShippingCity = "São Paulo",
        ShippingState = "São Paulo",
        ShippingZipCode = "01311330",
        ShippingCountry = "BR"
    };

    var volumeArray1 = new ShipmentOrderVolumeArray()
    {
        ShipmentOrderVolumeNumber = "1",
        Weight = 10.2,
        Width = 10.2,
        Height = 10.2,
        Length = 10.2,
        ProductsNature = "beverages",
        ProductsQuantity = 2,
        IsIcmsExempt = false,
        TrackingCode = "SW123456789BR",
        VolumeTypeCode = "box",
        ShipmentOrderVolumeInvoice = new ShipmentOrderVolumeInvoice()
        {
            InvoiceSeries = "1",
            InvoiveNumber = "1000",
            InvoiceKey = "41140502834982004563550010000084111000132317",
            InvoiceDate = new DateTime(2015, 08, 20),
            InvoiceTotalValue = "45.99",
            InvoiceProductsValue = "39.99",
            InvoiceCfop = "2890"
        },


    };

    var volumeArray2 = new ShipmentOrderVolumeArray()
    {
        ShipmentOrderVolumeNumber = "2",
        Weight = 10.2,
        Width = 10.2,
        Height = 10.2,
        Length = 10.2,
        ProductsNature = "beverages",
        ProductsQuantity = 2,
        IsIcmsExempt = false,
        TrackingCode = "SW123456789BR",
        VolumeTypeCode = "box",
        ShipmentOrderVolumeInvoice = new ShipmentOrderVolumeInvoice()
        {
            InvoiceSeries = "1",
            InvoiveNumber = "1000",
            InvoiceKey = "41140502834982004563550010000084111000132317",
            InvoiceDate = new DateTime(2015, 08, 20),
            InvoiceTotalValue = "45.99",
            InvoiceProductsValue = "39.99",
            InvoiceCfop = "2890"
        },
    };

    var volumeArrayList = new List<ShipmentOrderVolumeArray>();
    volumeArrayList.Add(volumeArray1);
    volumeArrayList.Add(volumeArray2);

    var additionalInformation = new Dictionary<string, string>();
    additionalInformation.Add("key", "val1");
    additionalInformation.Add("key2", "val2");

    var externalOrderNumbers = new Dictionary<string, string>();
    externalOrderNumbers.Add("marketplace", "PEDIDO-MKT-030");

    var modelRequest = new Request<ShipmentOrder>()
    {
        Content = new ShipmentOrder()
        {
            DeliveryMethodId = 1,
            OrderNumber = "PEDIDO-013",
            SalesOrderNumber = "s-sdk0002",
            SalesChannel = "SC Teste",
            QuoteId = null,
            OriginZipCode = "22710440",
            OriginWarehouseCode = "CD01",
            EndCustomer = endCustomer,
            ShipmentOrderVolumeArray = volumeArrayList,
            ShipmentOrderType = "NORMAL",
            CustomerShippingCosts = 1,
            Scheduled = false,
            Created = new DateTime(2018, 05, 02),
            AdditionalInformation = additionalInformation,
            ExternalOrderNumbers = externalOrderNumbers
        }
    };
    
    var modelResponse = new API.ShipmentOrder().RequestNewShipmentOrder(modelRequest);
```

* **ShippedWithDate** - POST ( */shipment_order/multi/shipped/with_date* )
```csharp
    new Configure().Initialize("Api-Key", false, "", platform: "my-ecommerce", platformVersion: "v1.0", plugin: "my-connector", pluginVersion: "v1.1.2");

    ShippedWithDate[] orderArray = new ShippedWithDate[2];
    orderArray[0] = new ShippedWithDate()
    {
        OrderNumber = "PEDIDO-004",
        EventDate = String.Format("{0:s}", DateTime.Now)
    };

    orderArray[1] = new ShippedWithDate()
    {
        OrderNumber = "PEDIDO-003",
        EventDate = String.Format("{0:s}", DateTime.Now)
    };

    var modelRequest = new Request<ShippedWithDate[]>()
    {
        Content = orderArray
    };
    
    var modelResponse = new API.ShippedWithDate().RequestNewShippedWithDate(modelRequest);
```

Last Release
--------------------
### Release 2.1.0:
- New Change Delivery Method;

> See [all release notes](https://github.com/intelipost/sdk-dotnet/releases)