using jfapi.makers;

namespace jfapi.args;
public static class Args {
  private static object action = null;
  private static bool _printDoc = false;


  public static void Interpreter(string[] args){
    _printDoc = Documentation.NeedsPrintDoc(args);

    action = null;
  }


  public static void Execute(){
    if(true)
      Console.WriteLine("Method Executed");
  }


  //Print help about the program
  private static void ExecuteDoc(byte action, string? path = null){
    if(path != null)
      Documentation.Print(path);

    Close();
  }


  private static void ExecuteSFI(byte action, string? path = null){
    SelfInvoiceMaker sfInM = new();

    //Manual/Custom SetInvoice
    if(action == 0 && path != null){
      sfInM.SetInvoice(sfInM.FromFile(path));
    }

    //Random SelfInvoice
    if(action == 1){
      sfInM.SetInvoice(sfInM.Random());
    }
  }


  private static void ExecuteInv(byte action, string? path = null){
    InvoiceMaker invM = new();

    //Manual/Custom Invoice
    if(action == 0 && path != null){
      invM.SetInvoice(invM.FromFile(path));
    }

    //Random Invoice
    if(action == 1){
      Console.WriteLine("hola");
      invM.SetInvoice(invM.Random());
    }
  }


  private static void Close() => Environment.Exit(0);


}
