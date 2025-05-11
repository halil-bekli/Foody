using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.EntityFramework {
    public class EfAboutUsDal : GenericRepository<AboutUs>, IAboutUsDal {
        public EfAboutUsDal(FoodyContext context) : base(context) {
        }
    }
}
