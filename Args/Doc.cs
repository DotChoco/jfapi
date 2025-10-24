using jfapi.collections;

namespace jfapi.behaviour;
public static class Documentation{
  private static byte _maxLengthShortArg = 2;
  private static DOCUMENT _document = DOCUMENT.NONE;
  private static string _docPath = @"C:\Users\techl\Dev\cs\jfapi\doc\";
  private static (bool, byte) helpArg = (false,0);



  public static void Print(){
    StreamReader sr = new(_docPath + _document.ToString());
    var file = sr.ReadToEnd().Split("\n");
    sr.Close();

    foreach(var line in file){Console.WriteLine(line);}
  }

  public static bool NeedsPrintDoc(string[] args){
    List<string> infoArgs = new();
    byte maxArgs = 2;
    byte currentArg = 0;
    List<string> instructions = new();

    if(args == null || args.Length == 0){
      _document = DOCUMENT.NOARGS;
      Print();
      return false;
    }

    instructions = GetInstructions(args);

    for(byte j = 0 ;j < helpArg.Item2; j++){
      //Sets the arg only if isn't menor than maximum
      if(currentArg < maxArgs){
        infoArgs.Add(instructions[j]);
        currentArg++;
      }
      //else break the loop
      else{ break; }
    }

    _document = ArgsOptions.Map.GetValueOrDefault(infoArgs.Last(), DOCUMENT.NONE);
    return _document != DOCUMENT.NONE ? true : false;
  }

  private static List<string> GetInstructions(string[] args){
    List<string> instructions = new();
    byte counterInclude = 0;

    for(byte i = 0;i<args.Length ;i++){
      if((args[i] == null && args[i] == string.Empty) && (args[i].First() != '-'))
        continue;

      if(args[i].Contains("--") || args[i].Length == _maxLengthShortArg) {
        instructions.Add(args[i]);

        if(args[i].Contains("--h") || args[i].Contains("-h")){
          helpArg = (true, counterInclude);
          break;
        }
        counterInclude++;
      }
    }

    return instructions;
  }

}
