using Microsoft.AspNetCore.Components.Forms;
using System.Diagnostics.CodeAnalysis;

namespace BlogSphere.WebUI.Components.Shared
{
    public class AppInputBase : InputBase<string>
    {
        protected override bool TryParseValueFromString(string? value, [MaybeNullWhen(false)] out string result, [NotNullWhen(false)] out string? validationErrorMessage)
        {



            if (string.IsNullOrEmpty(value))
            {
                result = string.Empty;
                validationErrorMessage = "Input string is null or empty";
                return false;
            }

            result = value;
            validationErrorMessage = null;
            return true;
        }
    }
}
