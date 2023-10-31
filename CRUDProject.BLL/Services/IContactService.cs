using CRUDProject.DAL.Repository;
using CRUDProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProject.BLL.Services {
    public interface IContactService {

        public Task<Contact> FindOneByName(string name);

    }
}
