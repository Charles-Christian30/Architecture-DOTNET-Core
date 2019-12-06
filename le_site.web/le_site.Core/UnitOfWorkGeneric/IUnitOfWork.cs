using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace le_site.Core.UnitOfWorkGeneric
{
    public interface IUnitOfWork
    {
        Task CompletAsync();
    }
}
