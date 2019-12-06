using le_site.Core.Generic;
using le_site.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace le_site.Repository.PersonneRepository
{
    public interface IPersonneRepository :IGenericRepository<Personne>
    {
        Personne Get(int id);
        Task<Personne> GetAsync(int id);
        IEnumerable<Personne> GetAll();
        Task<IEnumerable<Personne>> GetAllAsync();
        IEnumerable<Personne> Find(Expression<Func<Personne, bool>> predicate);
        Task<IEnumerable<Personne>> FindAsync(Expression<Func<Personne, bool>> predicate);
        void Add(Personne personne);
        void AddAsync(Personne personne);
        void Remove(Personne personne);
        void RemoveRange(IEnumerable<Personne> entities);

    }
}
