using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Application.Services
{
    public interface ISlugGeneratorService
    {
        Task<string> GenerateAsync(string input);
    }
}
