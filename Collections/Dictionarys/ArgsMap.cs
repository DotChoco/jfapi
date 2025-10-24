namespace jfapi.collections;
public static class ArgsOptions{

  public static Dictionary<string, DOCUMENT> Map = new(){
    { "--invoice", DOCUMENT.INVOICE},
    { "--pr", DOCUMENT.PAYMENTRECEIPT},
    { "--cp", DOCUMENT.CARTAPORTE},
    { "--manual", DOCUMENT.MANUAL},
    { "--random", DOCUMENT.RANDOM},
    { "--selfinvoice", DOCUMENT.SELFINVOICE},
    { "-s", DOCUMENT.SELFINVOICE},
    { "-r", DOCUMENT.RANDOM},
    { "-m", DOCUMENT.MANUAL},
    { "-i", DOCUMENT.INVOICE},
  };
}
