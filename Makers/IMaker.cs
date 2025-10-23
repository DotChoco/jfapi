using jfapi.collections;
namespace jfapi.models;

public interface IMaker<T>{

  public T FromFile(string Path);
  public T Random(COMPLEMENTS complement);

  public void SetInvoice(T invoice);
  public T GetInvoice();

}
