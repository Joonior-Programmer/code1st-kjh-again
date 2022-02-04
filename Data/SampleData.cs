using Code1st.Models;
using code1st_delete_me.Models;

namespace Code1st.Data;

public class SampleData {
  public static List<City> GetCities() {
      
      List<City> cities = new List<City>() {
         new City() {
             CityId=1,
             Population=5000,
             CityName="Los Angeles",
             ProvinceCode="CA",
         },
         new City() {
             CityId=2,
             Population=5000,
             CityName="Los Angeles",
             ProvinceCode="CA",
         },
         new City() {
             CityId=3,
             Population=5000,
             CityName="Los Angeles",
             ProvinceCode="CA",
         },
         new City() {
             CityId=4,
             Population=5000,
             CityName="Los Angeles",
             ProvinceCode="CA",
         },
         new City() {
             CityId=5,
             Population=5000,
             CityName="Los Angeles",
             ProvinceCode="CA",
         },
         new City() {
             CityId=6,
             Population=5000,
             CityName="Los Angeles",
             ProvinceCode="CA",
         },
         new City() {
             CityId=7,
             Population=5000,
             CityName="Los Angeles",
             ProvinceCode="CA",
         },
      };

      return cities;
  }

  public static List<Province> GetProvinces() {
      List<Province> provinces = new List<Province>() {
         new Province {
             ProvinceCode = "CA",
             ProvinceName = "California",
         },
      };

      return provinces;
  }

}