using jfapi.makers;

namespace jfapi.args;
public static class Args {
  private static object action = null;
  private static bool _printDoc = false;
  private static bool _printInvoice = false;
  private static byte _invoiceType = 0;
  private static InvoiceMaker _invM = new();
  private static SelfInvoiceMaker _sfInM = new();


  public static void Interpreter(string[] args){
    _printDoc = Documentation.NeedsPrintDoc(args);
    // action = null;
  }


  public static void Execute(){
    // if(true) { ExecuteInv(1); }
      // Console.WriteLine("Method Executed");
    ExecuteInv(1);
  }


  //Print help about the program
  private static void ExecuteDoc(byte action, string? path = null){
    if(path != null)
      Documentation.Print(path);

    Close();
  }


  private static void ExecuteInv(byte action, string? path = null){
    //Manual/Custom Invoice
    if(action == 0 && path != null){
      _invM.SetInvoice(_invM.FromFile(path));
    }

    //Random Invoice
    if(action == 1){
      _invM.SetInvoice(_invM.Random(collections.COMPLEMENTS.CP));
    }
  }


  private static void ExecuteSFI(byte action, string? path = null){
    //Manual/Custom SetInvoice
    if(action == 0 && path != null){
      _sfInM.SetInvoice(_sfInM.FromFile(path));
    }

    //Random SelfInvoice
    if(action == 1){
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
