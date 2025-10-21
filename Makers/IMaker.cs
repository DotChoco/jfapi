namespace jfapi.models;

public interface IMaker<T>{

  public T FromFile(string Path);
  public T Random();

  public void SetInvoice(T invoice);
  public T GetInvoice();

}
