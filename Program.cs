using jfapi.makers;
using jfapi.doc;

namespace jfapi;

public class Program{
  public static void Main(string[] args){

    //Print help about the program
    if(Documentation.NeedsPrintDoc(args)){
      Documentation.Print();
    }
    // if(args[0].ToLower() == "-h" || args[0].ToLower() == "--help"){
    //   return;
    // }
    return;

    // SelfInvoice
    if(args[0].ToLower() == "--sfi"){
      SelfInvoiceMaker sfInM = new();

      //Manual/Custom SetInvoice
      if(args[1].ToLower() == "-m"){
        //Print help about the program
        if(args[args.Length - 1].ToLower() == "-h" || args[args.Length - 1].ToLower() == "--help"){
          Documentation.PrintDocument(DOCUMENT.SELFINVOICE);
          return;
        }
        else
          sfInM.SetInvoice(sfInM.FromFile(args[2]));

      }

      //Random SelfInvoice
      if(args[1].ToLower() == "r"){
        if(args[args.Length - 1].ToLower() == "-h" || args[args.Length - 1].ToLower() == "--help"){
          Documentation.PrintDocument(DOCUMENT.SELFINVOICE);
          return;
        }
        else
          sfInM.SetInvoice(sfInM.Random());
      }
      return;
    }

    // Invoice with or without complement
    // (Carta Porte, Payment Receipt,...)
    if(args[0].ToLower() == "-i"){
      InvoiceMaker invM = new();
      //Manual/Custom Invoice
      if(args[1].ToLower() == "m")
        invM.SetInvoice(invM.FromFile(args[2]));

      //Random Invoice
      if(args[1].ToLower() == "r")
        invM.SetInvoice(invM.Random(COMPLEMENTS.NONE));


      return;
    }

  }
}
