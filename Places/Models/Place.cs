using System.Collections.Generic;
namespace PlaceDiary.Models
{
    public class Place
    {
        private string _cityName;
        private string _description;
        private int _id;
        private static List<Place> _instances = new List<Place> { };

        public Place(string cityName)
        {
            _cityName = cityName;
            _instances.Add(this);
            _id = _instances.Count;
        }

        public string GetCityName()
        {
            return _cityName;
        }
        public void SetCityName(string newCityName)
        {
            _cityName = newCityName;
        }

        public string GetDescription()
        {
            return _description;
        }
        public void SetDescription(string newDescription)
        {
            _description = newDescription;
        }
        public static List<Place> GetAll()
        {
            return _instances;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
        public int GetId()
        {
            return _id;
        }
        public static Place Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}