using jfapi.models;

namespace jfapi.makers.validator;
public sealed class Inspector{
  public string log = string.Empty;

  public string Analyze<T>(T item){
    Type type = item.GetType();
    if (type == typeof(Invoice))
      return "success";
    if (type == typeof(CartaPorte))
      return "success";
    if (type == typeof(SelfInvoice))
      return "success";
    return log != "success" || log != string.Empty ? log : "fail";
  }


}
