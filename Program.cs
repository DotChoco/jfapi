using jfapi.args;

namespace jfapi;

public class Program{
  public static void Main(string[] args){

    Console.Clear();

    //Check the instructions that
    //become from the arguments
    Args.Interpreter(args);

    //This method will be execute the actions
    //that become from the arguments
    Args.Execute();

    Args.PrintInvoice();

  }
}



