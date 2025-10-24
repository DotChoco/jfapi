using jfapi.makers;
using jfapi.collections;


namespace jfapi.behaviour;
public sealed class Application: Instructions{
  private ARGACTIONS _action = byte.MinValue;
  private bool _printDoc = false;
  private bool _printInvoice = false;
  private byte _invoiceType = 0;
  private InvoiceMaker _invM = new();
  private SelfInvoiceMaker _sfInM = new();


  public void Interpreter(string[] args){
    Documentation doc = new();
    _printDoc = doc.NeedsPrintDoc(args);
    // _action = null;
  }


  public void Execute(){
    // Print Documentation
    if(_printDoc){
      Documentation.Print();
      Close();
    }

    if(true) {
      ExecuteInv(1);
    }
    // Console.WriteLine("Method Executed");
    // ExecuteInv(1);

  }


  private void ExecuteInv(byte subAction, string? path = null){
    //Manual/Custom Invoice
    if(subAction == 0 && path != null){
      _invM.SetInvoice(_invM.FromFile(path));
    }

    //Random Invoice
    if(subAction == 1){
      _invM.SetInvoice(_invM.Random(COMPLEMENTS.CP));
    }
  }



  private void ExecuteSFI(byte subAction, string? path = null){
    //Manual/Custom SetInvoice
    if(subAction == 0 && path != null){
      _sfInM.SetInvoice(_sfInM.FromFile(path));
    }

    //Random SelfInvoice
    if(subAction == 1){
      _sfInM.SetInvoice(_sfInM.Random());
    }
  }




  public void PrintInvoice() {
    string[] json = Array.Empty<string>();

    if(_invoiceType == 0){
      json = _invM.MakeJson(_invM.Invoice).Split('\n');
    }
    if(_invoiceType == 1){
      json = _sfInM.MakeJson(_sfInM.SFInvoice).Split('\n');
    }

    foreach(var line in json) { Console.WriteLine(line); }
  }


  protected override List<string> GetInstructions(string[] args){
    List<string> instructions = new();
    byte counterInclude = 0;

    for(byte i = 0;i<args.Length ;i++){
      if((args[i] == null && args[i] == string.Empty) && (args[i].First() != '-'))
        continue;

      if(args[i].Contains("--") || args[i].Length == _maxLengthShortArg) {
        instructions.Add(args[i]);
        counterInclude++;
      }
    }

    return instructions;
  }





  private static void Close() => Environment.Exit(0);

}
