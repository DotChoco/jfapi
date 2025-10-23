using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using jfapi.makers.validator;

namespace jfapi.makers;
public class BaseMaker{

  protected Inspector inspector = new();

  protected float RoundFloat(float value, byte scale) => (float)Math.Round((decimal)value, scale);

  public string MakeJson<T>(T data){
    string json = string.Empty;
    var options = new JsonSerializerOptions{
      WriteIndented = true,
      DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    return JsonSerializer.Serialize(data, options);
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

