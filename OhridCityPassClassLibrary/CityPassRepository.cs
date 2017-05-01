using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhridCityPassClassLibrary
{
    public class CityPassRepository
    {
        public static OhridCityPassEntities _citypassEntities;

        public static OhridCityPassEntities OhridCityPassRepository
        {
            get
            {
                if (_citypassEntities == null)
                {
                    _citypassEntities = new OhridCityPassEntities();
                  //  _citypassEntities.Configuration.LazyLoadingEnabled = true;
                }
                return _citypassEntities;
            }
            set
            {
                _citypassEntities = value;
            }
        }
    }
}
