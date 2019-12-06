using le_site.Core.Generic;
using le_site.Data.Context;
using le_site.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace le_site.Repository.PersonneRepository
{
    public class PersonneRepository : GenericRepository<Personne>, IPersonneRepository
    {
        private readonly LeSiteDbContext _context;
        public PersonneRepository(LeSiteDbContext context)
        {
            _context = context;
        }
        public Personne Get(int id)
        {
            return _context.Personnes.Find(id);
        }

        public Task<Personne> GetAsync(int id)
        {
            return _context.Personnes.FindAsync(id);
        }

        public IEnumerable<Personne> GetAll()
        {
            return _context.Personnes.ToList();
        }
        public async Task<IEnumerable<Personne>> GetAllAsync()
        {
            return await _context.Personnes.ToListAsync();
        }
        public void Add(Personne personne)
        {
            _context.Add(personne);
            
        }
        public void AddAsync(Personne personne)
        {
            _context.AddAsync(personne);

        }
        public void Remove(Personne personne)
        {
            _context.Remove(personne);
        }
    }
}
