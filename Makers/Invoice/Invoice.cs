using jfapi.models;
using jfapi.makers.validator;
using jfapi.collections;

namespace jfapi.makers;

public sealed class InvoiceMaker: BaseMaker, IMaker<Invoice> {
  private Invoice _invoice = new();
  public Invoice Invoice { get => _invoice; set => value = _invoice; }

  public InvoiceMaker(){
    _invoice.Complemento = new();
    _invoice.Complemento.any = new();

    // Taxes impuestos = new(){
    //   Traslados = new(){
    //     Traslado = new()
    //   }
    // };
    // _invoice.Conceptos.Concepto = new();
    // _invoice.Total = 134.342423f;
    // _invoice.Total = RoundFloat(_invoice.Total, 2);
    // _invoice.Conceptos.Concepto.Add(new());
    // _invoice.Conceptos.Concepto[0].Impuestos = new(){
    //   Traslados = new(){
    //     Traslado = new()
    //   }
    // };
    //
    // _invoice.Impuestos = impuestos;
  }

  public Invoice Random(COMPLEMENTS complement = COMPLEMENTS.NONE){
    if(complement != COMPLEMENTS.NONE){
      var complementFound = GetComplement(complement);

      if(complementFound.GetType() == typeof(CartaPorte))
        _invoice.Complemento!.any!.Add(new CartaPorteMaker().Random());

      else if(complementFound.GetType() == typeof(PaymentReceipt))
        _invoice.Complemento!.any!.Add(new PaymentReceiptMaker().Random());
    }
    else
      _invoice.Complemento = null;


    // inspector.Analyze(_invoice);
    return _invoice;
  }

  public object GetComplement(COMPLEMENTS type) => ComplementMap.Map!.GetValueOrDefault(type, null)!;


  public Invoice FromFile(string Path){
    return null;
  }

  public void SetInvoice(Invoice invoice) => _invoice = invoice;
  public Invoice GetInvoice() => _invoice;

}




