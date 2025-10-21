
namespace jfapi.doc;

public enum DOCUMENT {
  NONE,
  GENERAL,
  CARTAPORTE,
  PAYMENTRECEIPT,
  INVOICE,
  SELFINVOICE
}

public static class Documentation{

  public static void Print(){
    DOCUMENT document = Detector();
    PrintDoc(document);
  }

  public static void PrintDoc(DOCUMENT doc){
    StreamReader sr = new("./doc/General");
    var document = sr.ReadToEnd().Split("\n");
    sr.Close();

    foreach(var line in document){Console.WriteLine(line);}
  }

  public static bool NeedsPrintDoc(string[] args){
    return false;
  }

  private static DOCUMENT Detector(){ return DOCUMENT.NONE;}

}
