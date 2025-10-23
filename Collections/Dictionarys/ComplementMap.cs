using jfapi.models;
namespace jfapi.collections;

public static class ComplementMap{
public static readonly Dictionary<COMPLEMENTS, IComplement?> Map = new(){
  {COMPLEMENTS.CP, new CartaPorte()}, //CartaPorte
  {COMPLEMENTS.P, new PaymentReceipt()}, //Payment
  {COMPLEMENTS.NONE, null}, //Payment
};

}
