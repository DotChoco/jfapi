using jfapi.makers;

namespace jfapi.behaviour;
public static class Application {
  private static byte _action = byte.MinValue;
  private static bool _printDoc = false;
  private static bool _printInvoice = false;
  private static byte _invoiceType = 0;
  private static InvoiceMaker _invM = new();
  private static SelfInvoiceMaker _sfInM = new();


  public static void Interpreter(string[] args){
    _printDoc = Documentation.NeedsPrintDoc(args);
    // _action = null;
  }


  public static void Execute(){
    // Print Documentation
    if(_printDoc){
      Documentation.Print();
      Close();
    }

    // if(true) { ExecuteInv(1); }
      // Console.WriteLine("Method Executed");
    // ExecuteInv(1);

  }


  private static void ExecuteInv(byte subAction, string? path = null){
    //Manual/Custom Invoice
    if(subAction == 0 && path != null){
      _invM.SetInvoice(_invM.FromFile(path));
    }

    //Random Invoice
    if(subAction == 1){
      _invM.SetInvoice(_invM.Random(collections.COMPLEMENTS.CP));
    }
  }


  private static void ExecuteSFI(byte subAction, string? path = null){
    //Manual/Custom SetInvoice
    if(subAction == 0 && path != null){
      _sfInM.SetInvoice(_sfInM.FromFile(path));
    }

    //Random SelfInvoice
    if(subAction == 1){
      _sfInM.SetInvoice(_sfInM.Random());
    }
  }




  public static void PrintInvoice() {
    string[] json = Array.Empty<string>();

    if(_invoiceType == 0){
      json = _invM.MakeJson(_invM.Invoice).Split('\n');
    }
    if(_invoiceType == 1){
      json = _invM.MakeJson(_invM.Invoice).Split('\n');
    }

    foreach(var line in json) { Console.WriteLine(line); }
  }


  private static void Close() => Environment.Exit(0);


}
