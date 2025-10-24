using jfapi.behaviour;

namespace jfapi;

public class Program{
  public static void Main(string[] args){

    // Console.Clear();

    //Check the instructions that
    //become from the arguments
    Application.Interpreter(args);

    //This method will be execute the actions
    //that become from the arguments
    Application.Execute();

    // Application.PrintInvoice();

  }
}



