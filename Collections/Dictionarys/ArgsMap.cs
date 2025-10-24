namespace jfapi.collections;
public static class ArgsOptions{

  public static Dictionary<string, DOCUMENT> DocMap = new(){
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

  public static Dictionary<string, ARGACTIONS> ArgMap = new(){
    { "--invoice", ARGACTIONS.INVOICE},
    { "--pr", ARGACTIONS.PAYMENTRECEIPT},
    { "--cp", ARGACTIONS.CARTAPORTE},
    { "--manual", ARGACTIONS.MANUAL},
    { "--random", ARGACTIONS.RANDOM},
    { "--selfinvoice", ARGACTIONS.SELFINVOICE},
    { "-s", ARGACTIONS.SELFINVOICE},
    { "-r", ARGACTIONS.RANDOM},
    { "-m", ARGACTIONS.MANUAL},
    { "-i", ARGACTIONS.INVOICE},
  };
}
