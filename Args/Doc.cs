using jfapi.collections;

namespace jfapi.args;
public static class Documentation{
  private static DOCUMENT document = DOCUMENT.NONE;

  public static void Print(string docPath){
    StreamReader sr = new(docPath);
    var file = sr.ReadToEnd().Split("\n");
    sr.Close();

    foreach(var line in file){Console.WriteLine(line);}
  }

  public static bool NeedsPrintDoc(string[] args){
    document = Detector();
    return true;
  }

  private static DOCUMENT Detector(){ return DOCUMENT.NONE; }

}
