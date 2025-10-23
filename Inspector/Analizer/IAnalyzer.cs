namespace jfapi.makers.validator;

public interface IAnalyzer<T>{

  public T FromFile(string Path);
  public T Random();

  public void SetInvoice(T invoice);
  public T GetInvoice();

}
