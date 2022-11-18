using ServiceReference1;

namespace WorkerService1
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly TestDataCollectionSoap _client;

        public Worker(ILogger<Worker> logger, TestDataCollectionSoap client)
        {
            _logger = logger;
            _client = client;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var helloWorldResponse = await _client.HelloWorldAsync(new HelloWorldRequest());
                var getCraftInfoResponse = await _client.GetCraftInfoAsync(new GetCraftInfoRequest());
                _logger.LogInformation("Worker running at: {time}, {serialize}", DateTimeOffset.Now,
                    helloWorldResponse.Body.HelloWorldResult);
                _logger.LogInformation("Worker running at: {time}, {serialize}", DateTimeOffset.Now,
                    getCraftInfoResponse.Body.GetCraftInfoResult.Result);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}