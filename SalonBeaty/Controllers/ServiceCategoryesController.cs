using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using SalonBeaty.Models;

namespace SalonBeaty.Controllers
{ 

   public class ServiceCategoryesController
    { 
        /// <summary>
        /// Вывод информации из таблицы бд ServiceCategoryes
        /// </summary>
        /// <returns></returns>
        public static List<ServiceCategoryes> GetServiceCategoryes()

        {

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}ServiceCategoryes").Result;
            var content = response.Content.ReadAsStringAsync();
            var answer = JsonConvert.DeserializeObject<List<ServiceCategoryes>>(content.Result);
            return answer;

        }

    }
}
}
