using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;

namespace api_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = new WebClient().DownloadString("https://uinames.com/api/?ext&amount=20");
            List<Persons> data = new JavaScriptSerializer().Deserialize<List<Persons>>(json);


            foreach(Persons x in data)
            {
                Console.WriteLine($"{x.name}\n{x.surname}\n{x.gender}\n{x.region}\n{x.age}\n{x.title}\n{x.phone}\n{x.birthday.dmy}\n{x.email}\n{x.password}\n\n{x.credit_card.number}\n{x.photo} ");
                Console.ReadKey();
            }
        }
    }
}

    class Persons
    {

    public string name { get; set; }
    public string surname { get; set; }
    public string gender { get; set; }
    public string region { get; set; }
    public int age { get; set; }
    public string title { get; set; }
    public string phone { get; set; }
    
    
    public Birthday birthday { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public Credit_card credit_card { get; set; }
    public string photo { get; set; }
    

}
    class Birthday
    {
    public string dmy { get; set; }
    public string mdy { get; set; }
    public int raw { get; set; }

    }

    class Credit_card
    {
    public string expiration { get; set; }
    public string number { get; set; }
    public int pin { get; set; }
    public int security { get; set; }
    }
