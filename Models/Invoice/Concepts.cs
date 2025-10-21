namespace jfapi.models;
public sealed class Concepts{
  public List<Concept> Concepto { get; set; } = new();
}

public sealed class Concept{
  public Taxes? Impuestos { get; set; } = null;
  public string ObjetoImp { get; set; } = string.Empty;
  public string ClaveProdServ { get; set; } = string.Empty;
  public string NoIdentificacion { get; set; } = string.Empty;
  public float Cantidad { get; set; } = 0.0f;
  public string ClaveUnidad { get; set; } = string.Empty;
  public string Unidad { get; set; } = string.Empty;
  public string Descripcion { get; set; } = string.Empty;
  public float ValorUnitario { get; set; } = 0.0f;
  public float Importe { get; set; } = 0.0f;
}


public sealed class Taxes{
  public Traslates? Traslados { get; set; } = null;
}

public sealed class Traslates{
  public List<Traslate>? Traslado { get; set; } = null;
}

public sealed class Traslate{
  public float? Base { get; set; } = 0.0f;
  public string? Impuesto { get; set; } = string.Empty;
  public string? TipoFactor { get; set; } = string.Empty;
  public string? TasaOCuota { get; set; } = string.Empty;
  public float? Importe { get; set; } = 0.0f;
}

