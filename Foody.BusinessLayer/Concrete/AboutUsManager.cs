using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete {
    public class AboutUsManager : IAboutUsService {
        private readonly IAboutUsDal _aboutUsDal;
        public AboutUsManager(IAboutUsDal aboutUsDal) {
            _aboutUsDal = aboutUsDal;
        }
        public void TDelete(int id) {
            _aboutUsDal.Delete(id);
        }

        public List<AboutUs> TGetAll() {
            return _aboutUsDal.GetAll();
        }

        public AboutUs TGetById(int id) {
            return _aboutUsDal.GetById(id);
        }

        public void TInsert(AboutUs entity) {
            _aboutUsDal.Insert(entity);
        }

        public void TUpdate(AboutUs entity) {
            _aboutUsDal.Update(entity);
        }
    }
}
