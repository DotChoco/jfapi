using System.Text.Json;
// using System.Text.Json.Serialization;


namespace jfapi.models;

public class Program{
  public static void Main(string[] args){
    Invoice invoice = new();
    invoice.Conceptos.Concepto = new();
    invoice.Conceptos.Concepto.Add(new());
    invoice.Conceptos.Concepto[0].Impuestos = new(){
      Traslados = new(){
        Traslado = new()
      }
    };
    invoice.Conceptos.Concepto[0].Impuestos.Traslados.Traslado.Add(new(){ Base = 1500.0000f });

    var options = new JsonSerializerOptions{
      WriteIndented = true
      // DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };
    var json = JsonSerializer.Serialize(invoice, options);

    Console.WriteLine(json);
  }
}
