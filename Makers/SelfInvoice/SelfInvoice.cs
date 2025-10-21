using jfapi.models;
namespace jfapi.makers;

public sealed class SelfInvoiceMaker: IMaker<SelfInvoice> {
  private SelfInvoice _sfInvoice = new();

  public SelfInvoice FromFile(string Path){

    return null;
  }

  public SelfInvoice Random(){
   return null;
  }

  public void SetInvoice(SelfInvoice sfInvoice) => _sfInvoice = sfInvoice;
  public SelfInvoice GetInvoice() => _sfInvoice;
}
