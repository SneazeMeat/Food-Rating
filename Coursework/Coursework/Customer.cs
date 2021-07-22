using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Coursework
{
    class Customer
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public int FoodRating { get; set; }
        public int StaffRating { get; set; }
        public int CleanRating { get; set; }
        public int OrderRating { get; set; }
        public int AmbienceRating { get; set; }
        public int ValueRating { get; set; }
        public DateTime Feedbackdate { get; set; }
        /*
        public String FoodRatingString { get; set; }
        public String StaffRatingString { get; set; }
        public String CleanRatingString { get; set; }
        public String OrderRatingString { get; set; }
        public String AmbienceRatingString { get; set; }
        public String ValueRatingString { get; set; }
        */
        private string _filePath = "customerInfo.json";

        public void Add(Customer info)
        {
            Random r = new Random();
            info.ID = r.Next(1000, 9999);
            string data = JsonConvert.SerializeObject(info, Formatting.None);
            Console.WriteLine(data);
            Utility.WriteToFile(_filePath, data);
        }

        public List<Customer> List() 
        {
            string file = Utility.ReadFromFile(_filePath);
            if (file != null) 
            {
                List<Customer> list = JsonConvert.DeserializeObject<List<Customer>>(file);
                return list;
            }
            return null;
        }

        public void Edit(Customer info) 
        {
            List<Customer> list = List();
            Customer s = list.Where(x => x.ID == info.ID).FirstOrDefault();
            list.Remove(s);
            list.Add(info);
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            Utility.WriteToFile(_filePath, data, false);
        }

        public void Delete(int id)
        {
            List<Customer> list = List();
            Customer s = list.Where(x => x.ID == id).FirstOrDefault();
            list.Remove(s);
            int count = list.Count;
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            Utility.WriteToFile(_filePath, data, false, count);
        }
    }
}
