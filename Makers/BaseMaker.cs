using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using jfapi.models;

namespace jfapi.makers;
public enum COMPLEMENTS{
  NONE,
  CP,
  P
}
public class BaseMaker {
  protected readonly Dictionary<COMPLEMENTS, IComplement?> ComplemetMap = new(){
    {COMPLEMENTS.CP, new CartaPorte()}, //CartaPorte
    {COMPLEMENTS.P, new PaymentReceipt()}, //Payment
    {COMPLEMENTS.NONE, null}, //Payment
  };


  protected float RoundFloat(float value, byte scale) => (float)Math.Round((decimal)value, scale);

  public string MakeJson<T>(T data){
    string json = string.Empty;
    var options = new JsonSerializerOptions{
      WriteIndented = true,
      DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };


    json = JsonSerializer.Serialize(data, options);
    return json;
  }

  public string MakeXML<T>(T data){
    string xml = string.Empty;

    // Serializar a XML
    var xmlSerializer = new XmlSerializer(typeof(T));
    using (var stringWriter = new StringWriter()){
      xmlSerializer.Serialize(stringWriter, data);
      xml = stringWriter.ToString();
    }

    return xml;
  }

}

