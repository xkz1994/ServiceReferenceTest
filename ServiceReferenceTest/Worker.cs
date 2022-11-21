using Sfc.TestDataCollection;
using wlg.WlgManagementService;

namespace ServiceReferenceTest
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly TestDataCollectionSoap _testDataCollection;
        private readonly WlgManagement _wlgManagement;

        public Worker(ILogger<Worker> logger, TestDataCollectionSoap testDataCollection, WlgManagement wlgManagement)
        {
            _logger = logger;
            _testDataCollection = testDataCollection;
            _wlgManagement = wlgManagement;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await using var s = new TestDataCollectionSoapClient(
                    TestDataCollectionSoapClient.EndpointConfiguration.TestDataCollectionSoap12,
                    "http://localhost:36871/WebService/TestDataCollection.asmx");
                var testDataCollectionSoap = s as TestDataCollectionSoap;
                var helloWorldResponse = await testDataCollectionSoap.HelloWorldAsync(new HelloWorldRequest());
                var getCraftInfoResponse = await _testDataCollection.GetCraftInfoAsync(new GetCraftInfoRequest());
                _logger.LogInformation("Worker running at: {time}, {serialize}", DateTimeOffset.Now,
                    helloWorldResponse.Body.HelloWorldResult);
                _logger.LogInformation("Worker running at: {time}, {serialize}", DateTimeOffset.Now,
                    getCraftInfoResponse.Body.GetCraftInfoResult.Result);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}