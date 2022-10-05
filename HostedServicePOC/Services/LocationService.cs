namespace HostedServicePOC.Services
{
    public class LocationService : IHostedService
    {
        private Timer timer;
        public Task StartAsync(CancellationToken cancellationToken)
        {
            timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
            WriteLog("Proceso iniciado");
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            WriteLog("Proceso finalizado");
            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            WriteLog($"Proceso en ejecución: {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")}");
        }

        private void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
