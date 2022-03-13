using DataAcess.Abstract;
using DataAcess.Concrete.Repository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.EntityFramework
{
    class EfWriterDal:GenericRepository<Writer>,IWriterDal
    {
    }
}
