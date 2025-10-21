using jfapi.models;

namespace jfapi.makers;

public sealed class InvoiceMaker: BaseMaker, IMaker<Invoice> {
  private Invoice _invoice;
  public Invoice Invoice { get => _invoice; }

  public InvoiceMaker(){
    Taxes impuestos = new(){
      Traslados = new(){
        Traslado = new()
      }
    };
    _invoice = new();
    _invoice.Conceptos.Concepto = new();
    _invoice.Total = 134.342423f;
    _invoice.Total = RoundFloat(_invoice.Total, 2);
    _invoice.Conceptos.Concepto.Add(new());
    _invoice.Conceptos.Concepto[0].Impuestos = impuestos;
    _invoice.Impuestos = impuestos;
    _invoice.Complemento = new CartaPorte();
  }

  public Invoice Random(){
    return Random(COMPLEMENTS.NONE);
  }

  public Invoice Random(COMPLEMENTS complement){

    var complementFound = GetComplement(complement);

    if(complement.GetType() == typeof(CartaPorte))
      _invoice.Complemento = new CartaPorteMaker().Random();
    else if(complement.GetType() == typeof(PaymentReceipt))
      _invoice.Complemento = new PaymentReceiptMaker().Random();
    else
      _invoice.Complemento = null;

    return _invoice;
  }

  public IComplement GetComplement(COMPLEMENTS type) => ComplemetMap!.GetValueOrDefault(type, null)!;


  public Invoice FromFile(string Path){
    return null;
  }

  public void SetInvoice(Invoice invoice) => _invoice = invoice;
  public Invoice GetInvoice() => _invoice;

}




