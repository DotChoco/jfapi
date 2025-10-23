using jfapi.models;
namespace jfapi.makers;

public sealed class CartaPorteMaker {


  public CartaPorte Random(){
    CartaPorte newCP = new();
    newCP.Cartaporte = new(){name = "Metroman" };
    return newCP;
  }
}

