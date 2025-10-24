namespace jfapi.behaviour;
public abstract class Instructions {
  protected static byte _maxLengthShortArg = 2;
  protected static (bool, byte) helpArg = (false,0);


  protected abstract List<string> GetInstructions(string[] args);
}
