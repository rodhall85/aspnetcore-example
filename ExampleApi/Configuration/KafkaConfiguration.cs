public class KafkaConfiguration {
  public ConsumerConfig ConsumerConfig { get; set; }
}

public class ConsumerConfig {
  public string BootstrapServers { get; set; }
  public string Something { get; set; }
}