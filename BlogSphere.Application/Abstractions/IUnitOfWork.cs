using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BlogSphere.Application.Abstractions
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync(CancellationToken token = default);

        IDbTransaction BeginTransaction();


       
    }
}
