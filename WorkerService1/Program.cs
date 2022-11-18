using ServiceReference1;
using WorkerService1;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<TestDataCollectionSoap>(new TestDataCollectionSoapClient(TestDataCollectionSoapClient.EndpointConfiguration.TestDataCollectionSoap12));
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
