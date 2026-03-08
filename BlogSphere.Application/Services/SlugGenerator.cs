using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace BlogSphere.Application.Services
{
    public class SlugGenerator: ISlugGeneratorService
    {

        public async Task<string> GenerateAsync(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            var normalized = input.ToLowerInvariant()
                                  .Replace("c#", "csharp")
                                  .Replace(".net", "dotnet")
                                  .Replace("&", "and")
                                  .Replace("+", "plus");

            normalized = RemoveDiacritics(normalized);


            normalized = Regex.Replace(normalized, @"[^a-z0-9\s-]", "");
            normalized = Regex.Replace(normalized, @"\s+", "-").Trim();
            normalized = Regex.Replace(normalized, "-+", "-");

            return normalized;
        }

        private string RemoveDiacritics(string text)
        {
            string normalizedString = text.Normalize(NormalizationForm.FormD);

            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var info = CharUnicodeInfo.GetUnicodeCategory(c);
                if(info != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
