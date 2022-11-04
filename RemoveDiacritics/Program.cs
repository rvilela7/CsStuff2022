using System.Text;
using System.Globalization;

public class Program
{
	public static void Main()
	{
		Console.WriteLine(RemoveDiacritics("çáppp+ff-áäëü"));
	}

    // https://stackoverflow.com/questions/249087/how-do-i-remove-diacritics-accents-from-a-string-in-net  
	static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder(capacity: normalizedString.Length);

            for (int i = 0; i < normalizedString.Length; i++)
            {
                char c = normalizedString[i];
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder
                .ToString()
                .Normalize(NormalizationForm.FormC);
        }
}