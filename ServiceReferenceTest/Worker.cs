using Sfc.TestDataCollection;
using System.Data.SqlTypes;
using System.Reflection.PortableExecutable;
using System.ServiceModel;
using System;
using System.ServiceModel.Channels;
using System.Text;
using wlg.WlgManagementService;

namespace ServiceReferenceTest
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly TestDataCollectionSoap _testDataCollection;
        private readonly WlgManagementClient _wlgManagement;

        public Worker(ILogger<Worker> logger, TestDataCollectionSoap testDataCollection,
            WlgManagementClient wlgManagement)
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
                using (var _ = new OperationContextScope(_wlgManagement.InnerChannel))
                {
                    var httpRequestProperty = new HttpRequestMessageProperty
                    {
                        Headers =
                        {
                            [System.Net.HttpRequestHeader.Authorization]
                                = "Basic " +
                                  Convert.ToBase64String(Encoding.ASCII.GetBytes("MESYS" + ":" + "sap123456"))
                        }
                    };
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] =
                        httpRequestProperty;

                    var appearanceCheckNcRecordResponse1 =
                        await _wlgManagement.appearanceCheckNCRecordAsync(new appearanceCheckNCRecord());
                    _logger.LogInformation("Worker running at: {time}, {serialize}", DateTimeOffset.Now,
                        appearanceCheckNcRecordResponse1.appearanceCheckNCRecordResponse.@return);
                }

                var testDataCollectionSoap = s as TestDataCollectionSoap;
                // var helloWorldResponse = await testDataCollectionSoap.HelloWorldAsync(new HelloWorldRequest());
                var helloWorldResponse = await _testDataCollection.HelloWorldAsync(new HelloWorldRequest());
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