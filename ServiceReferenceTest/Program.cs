using ServiceReferenceTest;
using Sfc.TestDataCollection;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<TestDataCollectionSoap>(new TestDataCollectionSoapClient(TestDataCollectionSoapClient.EndpointConfiguration.TestDataCollectionSoap12));
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();