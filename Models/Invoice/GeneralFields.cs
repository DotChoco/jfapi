using System.Text.Json.Serialization;

namespace jfapi.models;

public class GeneralFields{
  [JsonPropertyOrder(-12)]
  public string Version { get; set; } = string.Empty;
  [JsonPropertyOrder(-11)]
  public string Serie { get; set; } = string.Empty;
  [JsonPropertyOrder(-10)]
  public string Folio { get; set; } = string.Empty;
  [JsonPropertyOrder(-9)]
  public string Fecha { get; set; } = string.Empty;
  [JsonPropertyOrder(-8)]
  public string FormaPago { get; set; } = string.Empty;
  [JsonPropertyOrder(-7)]
  public float SubTotal { get; set; } = 0.0f;
  [JsonPropertyOrder(-6)]
  public string Moneda { get; set; } = string.Empty;
  [JsonPropertyOrder(-5)]
  public float Total { get; set; } = 0.0f;
  [JsonPropertyOrder(-4)]
  public string TipoDeComprobante { get; set; } = string.Empty;
  [JsonPropertyOrder(-3)]
  public string MetodoPago { get; set; } = string.Empty;
  [JsonPropertyOrder(-2)]
  public string LugarExpedicion { get; set; } = string.Empty;
  [JsonPropertyOrder(-1)]
  public string Exportacion { get; set; } = string.Empty;
}
