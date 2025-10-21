using System.Text.Json.Serialization;

namespace jfapi.models;

public class GeneralFields{
  [JsonPropertyOrder(-12)]
  public string? Version { get; set; }
  [JsonPropertyOrder(-11)]
  public string? Serie { get; set; }
  [JsonPropertyOrder(-10)]
  public string? Folio { get; set; }
  [JsonPropertyOrder(-9)]
  public string? Fecha { get; set; }
  [JsonPropertyOrder(-8)]
  public string? FormaPago { get; set; }
  [JsonPropertyOrder(-7)]
  public float? SubTotal { get; set; }
  [JsonPropertyOrder(-6)]
  public string? Moneda { get; set; }
  [JsonPropertyOrder(-5)]
  public float? Total { get; set; }
  [JsonPropertyOrder(-4)]
  public string? TipoDeComprobante { get; set; }
  [JsonPropertyOrder(-3)]
  public string? MetodoPago { get; set; }
  [JsonPropertyOrder(-2)]
  public string? LugarExpedicion { get; set; }
  [JsonPropertyOrder(-1)]
  public string? Exportacion { get; set; }
}
