using jfapi.behaviour;

namespace jfapi;

public class Program{
  public static void Main(string[] args){

    Application app = new();
    // Console.Clear();

    //Check the instructions that
    //become from the arguments
    app.Interpreter(args);

    //This method will be execute the actions
    //that become from the arguments
    app.Execute();

    app.PrintInvoice();

  }
}



