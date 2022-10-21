using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

string CountryLangNames = "{\n\"België\" : {\n\"NL\" : \"België\",\n\"FR\" : \"Belgique\",\n\"DE\" : \"Belgien\",\n\"EN\" : \"Belgium\",\n\"LU\" : \"Belgien\",\n\"BE\" : \"België\"\n},\n\"Nederland\" : {\n\"NL\" : \"Nederland\",\n\"FR\" : \"Pays-Bas\",\n\"DE\" : \"Niederlande\",\n\"EN\" : \"Netherlands\",\n\"LU\" : \"Nederland\",\n\"BE\" : \"Nederland\"\n},\n\"Luxemburg\" : {\n\"NL\" : \"Luxemburg\",\n\"FR\" : \"Luxembourg\",\n\"DE\" : \"Luxemburg\",\n\"EN\" : \"Luxembourg\",\n\"LU\" : \"Luxemburg\",\n\"BE\" : \"Luxemburg\"\n},\n\"Duitsland\" : {\n\"NL\" : \"Duitsland\",\n\"FR\" : \"Allemagne\",\n\"DE\" : \"Deutschland\",\n\"EN\" : \"Germany\",\n\"LU\" : \"Duitsland\",\n\"BE\" : \"Duitsland\"\n},\n\"Frankrijk\" : {\n\"NL\" : \"Frankrijk\",\n\"FR\" : \"France\",\n\"DE\" : \"Frankreich\",\n\"EN\" : \"France\",\n\"LU\" : \"Frankräich\",\n\"BE\" : \"Frankrijk\"\n}\n}";

var data = (JObject)JsonConvert.DeserializeObject(CountryLangNames);

var country = data.Properties().FirstOrDefault(p => p.Name == "België");

Console.WriteLine(country.Name);
Console.WriteLine(country);
Console.WriteLine(country.Value["EN"]);

var countries = data.Properties().Select(p => p.Name).ToList();

foreach (var item in countries)
{
	Console.WriteLine(item);
}

Console.WriteLine(country.Value["OO"]);
