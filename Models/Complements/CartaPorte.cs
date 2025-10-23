namespace jfapi.models;

public sealed class CartaPorte{
  public CartaPorteObj Cartaporte { get; set; } = new();
}

public sealed class CartaPorteObj{
  public string name { get; set; } = string.Empty;

}
