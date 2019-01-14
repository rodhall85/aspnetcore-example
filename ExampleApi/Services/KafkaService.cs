using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ExampleApi.Services {
  public class KafkaService : IKafkaService {
    
    private KafkaConfiguration _configuration;

    public KafkaService(IConfiguration configuration) {
      _configuration = configuration.GetSection("KafkaConfiguration").Get<KafkaConfiguration>();
    }

    public void WriteMessage() {
      File.WriteAllText("Logfile.txt", $"{DateTime.UtcNow.ToLongTimeString()} - Hello from the real deal! config: {_configuration.ConsumerConfig.BootstrapServers}");
    }
  }
}