using jfapi.collections;
using jfapi.models;
namespace jfapi.makers;

public sealed class SelfInvoiceMaker: BaseMaker, IMaker<SelfInvoice> {
  private SelfInvoice _sfInvoice = new();
  public SelfInvoice SFInvoice;

  public SelfInvoice FromFile(string Path){

    return null;
  }

  public SelfInvoice Random(COMPLEMENTS complement = COMPLEMENTS.NONE){
   return null;
  }

  public void SetInvoice(SelfInvoice sfInvoice) => _sfInvoice = sfInvoice;
  public SelfInvoice GetInvoice() => _sfInvoice;
}
