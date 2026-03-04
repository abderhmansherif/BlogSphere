using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Application.Abstractions
{
    public interface ISlugGenerator
    {
        Task<string> GenerateAsync(string input);
    }
}
