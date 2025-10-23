using System.Text.Json.Serialization;

namespace jfapi.models;

public sealed class Invoice: GeneralFields{
  [JsonPropertyOrder(1)]
  public Emisor Emisor { get; set; } = new();
  [JsonPropertyOrder(2)]
  public Receptor Receptor { get; set; } = new();
  [JsonPropertyOrder(3)]
  public Concepts Conceptos { get; set; } = new();
  [JsonPropertyOrder(4)]
  public Complement? Complemento { get; set; } = null;
  [JsonPropertyOrder(3)]
  public Taxes? Impuestos { get; set; } = null;
}




