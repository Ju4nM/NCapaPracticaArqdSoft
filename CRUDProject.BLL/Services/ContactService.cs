using CRUDProject.DAL.Repository;
using CRUDProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProject.BLL.Services {
    public class ContactService: IContactService {

        private readonly IGenericRepository<Contact> _contactRepository;

        public ContactService (IGenericRepository<Contact> contactRepo) {
            _contactRepository = contactRepo;
        }

        public async Task<bool> UpdateOne(Contact contact) => await _contactRepository.UpdateOne(contact);

        public async Task<bool> DeleteOne (int id) => await _contactRepository.DeleteOne(id);

        public async Task<Contact> FindOne(int id) => await _contactRepository.FindOne(id);

        public async Task<bool> Insert (Contact newContact) => await _contactRepository.Insert(newContact);

        public async Task<IQueryable<Contact>> FindAll() => await _contactRepository.FindAll();

        public async Task<Contact> FindOneByName(string name) {
            IQueryable<Contact> queryContacts = await FindAll();
            return queryContacts.Where(contact => contact.ContactName == name).FirstOrDefault();
        }
    }
}
