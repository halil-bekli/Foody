using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete {
    public class AdressManager : IAdressService {
        private readonly IAdressDal _adressDal;
        public AdressManager(IAdressDal adressDal) {
            _adressDal = adressDal;
        }
        public void TDelete(int id) {
            _adressDal.Delete(id);
        }
        public List<Adress> TGetAll() {
            return _adressDal.GetAll();
        }
        public Adress TGetById(int id) {
            return _adressDal.GetById(id);
        }
        public void TInsert(Adress entity) {
            _adressDal.Insert(entity);
        }
        public void TUpdate(Adress entity) {
            _adressDal.Update(entity);
        }
    }
}
