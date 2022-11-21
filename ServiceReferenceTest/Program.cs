using ServiceReferenceTest;
using Sfc.TestDataCollection;
using wlg.WlgManagementService;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<TestDataCollectionSoap>(
            new TestDataCollectionSoapClient(
                TestDataCollectionSoapClient.EndpointConfiguration.TestDataCollectionSoap12));
        // services.AddSingleton<TestDataCollectionSoap>(
        //     new TestDataCollectionSoapClient(
        //         TestDataCollectionSoapClient.EndpointConfiguration.TestDataCollectionSoap12, "http://localhost:36871/WebService/TestDataCollection.asmx"));
        services.AddSingleton<WlgManagement>(
            new WlgManagementClient(WlgManagementClient.EndpointConfiguration.WlgManagementPort));
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();