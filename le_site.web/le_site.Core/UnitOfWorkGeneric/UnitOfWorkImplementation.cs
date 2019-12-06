using le_site.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace le_site.Core.UnitOfWorkGeneric
{
    public class UnitOfWorkImplementation : IUnitOfWork
    {
        private readonly LeSiteDbContext _context;
        public UnitOfWorkImplementation(LeSiteDbContext context)
        {
            _context = context;
        }

        public async Task CompletAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
