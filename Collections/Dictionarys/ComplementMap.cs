using jfapi.models;
namespace jfapi.collections;

public static class ComplementMap{
public static readonly Dictionary<COMPLEMENTS, object?> Map = new(){
  {COMPLEMENTS.CP, new CartaPorte()}, //CartaPorte
  {COMPLEMENTS.P, new PaymentReceipt()}, //Payment
  {COMPLEMENTS.NONE, null}, //Payment
};

}
