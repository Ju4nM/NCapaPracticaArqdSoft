using CRUDProject.DAL.DataContext;
using CRUDProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProject.DAL.Repository {
    public class ContactRepository : IGenericRepository<Contact> {
    
        private readonly MvcpracticaArqdSoftContext _dbContext;
        public ContactRepository(MvcpracticaArqdSoftContext context) { 
            _dbContext = context;
        }

        public async Task<bool> DeleteOne(int id) {
            Contact currentContact = _dbContext.Contacts.First(c => c.ContactId == id);
            _dbContext.Contacts.Remove(currentContact);
            int deletedRows = await _dbContext.SaveChangesAsync();
            return deletedRows > 0;
        }

        public async Task<IQueryable<Contact>> FindAll() => _dbContext.Contacts;

        public async Task<Contact> FindOne(int id) => await _dbContext.Contacts.FindAsync(id);

        public async Task<bool> Insert(Contact model) {
            _dbContext.Contacts.Add(model);
            int insertedRows = await _dbContext.SaveChangesAsync();
            return insertedRows == 1;
        }

        public async Task<bool> UpdateOne(Contact model) {
            _dbContext.Contacts.Update(model);
            int deletedRows = await _dbContext.SaveChangesAsync();
            return deletedRows > 0;
        }
    }
}
