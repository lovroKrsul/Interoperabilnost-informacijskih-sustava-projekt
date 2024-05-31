using soapServoce;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Soap
{
    /// <summary>
    /// Summary description for SoapService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SoapService : System.Web.Services.WebService
    {
        public List<SoapGame> Games = new List<SoapGame>()
        {
            new SoapGame()
            {
                appID="1182900",
                title="A Plague Tale: Requiem",
                url="https://store.steampowered.com/app/1182900/A_Plague_Tale_Requiem/?snr=1_7_7_151_150_1",
                imgUrl="https://cdn.akamai.steamstatic.com/steam/apps/1182900/capsule_sm_120.jpg?t=1678973757",
                releseDate="17 Oct, 2022",
                reviewSummary="Very Positive<br>91% of the 7,507 user reviews for this game are positive.",
                price="69,99€"
            },
             new SoapGame()
            {
                appID="752590",
                title="A Plague Tale: Innocence",
                url="https://store.steampowered.com/app/752590/A_Plague_Tale_Innocence/?snr=1_7_7_151_150_1",
                imgUrl="https://cdn.akamai.steamstatic.com/steam/apps/752590/capsule_sm_120.jpg?t=1674035726",
                releseDate="14 May, 2019",
                reviewSummary="Very Positive<br>93% of the 45,928 user reviews for this game are positive.",
                price="39,99€"
            },
              new SoapGame()
            {
                appID="1740720",
                title="Have a Nice Death",
                url="https://store.steampowered.com/app/1740720/Have_a_Nice_Death/?snr=1_7_7_151_150_1",
                imgUrl="https://cdn.akamai.steamstatic.com/steam/apps/1740720/capsule_sm_120_alt_assets_0.jpg?t=1683753196",
                releseDate="22 Mar, 2023",
                reviewSummary="Very Positive<br>85% of the 6,872 user reviews for this game are positive.",
                price="24,99€"
            },
               new SoapGame()
            {
                appID="253230",
                title="A Hat in Time",
                url="https://store.steampowered.com/app/253230/A_Hat_in_Time/?snr=1_7_7_151_150_1",
                imgUrl="https://cdn.akamai.steamstatic.com/steam/apps/253230/capsule_sm_120.jpg?t=1671724399",
                releseDate="5 Oct, 2017",
                reviewSummary="Overwhelmingly Positive<br>98% of the 37,396 user reviews for this game are positive.",
                price="28,99€"
            },
                new SoapGame()
            {
                appID="218620",
                title="PAYDAY 2",
                url="https://store.steampowered.com/app/239200/Amnesia_A_Machine_for_Pigs/?snr=1_7_7_151_150_20",
                imgUrl="https://cdn.akamai.steamstatic.com/steam/apps/239200/capsule_sm_120.jpg?t=1670246309",
                releseDate="10 Sep, 2013",
                reviewSummary="Mixed<br>68% of the 5,857 user reviews for this game are positive.",
                price="19,50€"
            },
                  new SoapGame()
            {
                appID="239200",
                title="Amnesia: A Machine for Pigs",
                url="https://store.steampowered.com/app/239200/Amnesia_A_Machine_for_Pigs/?snr=1_7_7_151_150_20",
                imgUrl="https://cdn.akamai.steamstatic.com/steam/apps/239200/capsule_sm_120.jpg?t=1670246309",
                releseDate="10 Sep, 2013",
                reviewSummary="Mixed<br>68% of the 5,857 user reviews for this game are positive.",
                price="19,50€"
            },
            new SoapGame()
            {
                appID="1333920",
                title="A Place, Forbidden",
                url="https://store.steampowered.com/app/1333920/A_Place_Forbidden/?snr=1_7_7_151_150_6",
                imgUrl="https://cdn.akamai.steamstatic.com/steam/apps/1333920/capsule_sm_120.jpg?t=1684535776",
                releseDate="25 Jun, 2020",
                reviewSummary="Very Positive<br>88% of the 313 user reviews for this game are positive.",
                price="Free"
            },
             new SoapGame()
            {
                appID="1085660",
                title="Destiny 2",
                url="https://store.steampowered.com/app/1085660/Destiny_2/?snr=1_7_7_151_150_1",
                imgUrl="https://cdn.akamai.steamstatic.com/steam/apps/1085660/capsule_sm_120.jpg?t=1684966156",
                releseDate="1 Oct, 2019",
                reviewSummary="Very Positive<br>82% of the 544,903 user reviews for this game are positive.",
                price="Free To Play"
            },
              new SoapGame()
            {
                appID="320240",
                title="We Happy Few",
                url="https://store.steampowered.com/app/320240/We_Happy_Few/?snr=1_7_7_151_150_1",
                imgUrl="https://cdn.akamai.steamstatic.com/steam/apps/320240/capsule_sm_120.jpg?t=1648680905",
                releseDate="10 Aug, 2018",
                reviewSummary="Mostly Positive<br>76% of the 9,744 user reviews for this game are positive.",
                price="59,99€"
            },
               new SoapGame()
            {
                appID="327030",
                title="Worms W.M.D",
                url="https://store.steampowered.com/app/327030/Worms_WMD/?snr=1_7_7_151_150_1",
                imgUrl="https://cdn.akamai.steamstatic.com/steam/apps/327030/capsule_sm_120.jpg?t=1668768511",
                releseDate="23 Aug, 2016",
                reviewSummary="Very Positive<br>85% of the 6,692 user reviews for this game are positive.",
                price="29,99€"
            }


        };

        [WebMethod]
        public string GenerateXML()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<SoapGame>));
            var writer = new StreamWriter(@"D:\Users\lovro krsul\Desktop\algebra\s6\iis\Projekt\soapXml.xml");
            xmlSerializer.Serialize(writer, Games);
            string path = "";
            return path;
        }
        [WebMethod]
        public List<SoapGame> GetDocument(string searchTerm)
        {


            List<SoapGame> results = new List<SoapGame>();
            XDocument doc = XDocument.Load(@"D:\Users\lovro krsul\Desktop\algebra\s6\iis\Projekt\soapXml.xml");


            IEnumerable<XElement> elements = doc.Descendants("SoapGame");

            Console.WriteLine(elements.Count());



            foreach (XElement element in elements)
            {

                if (element.Element("title").Value == searchTerm)
                {

                    results.Add(new SoapGame()
                    {
                        appID = element.Element("appID").Value,
                        title = element.Element("title").Value,
                        url = element.Element("url").Value,
                        imgUrl = element.Element("imgUrl").Value,
                        releseDate = element.Element("releseDate").Value,
                        reviewSummary = element.Element("reviewSummary").Value,
                        price = element.Element("price").Value

                    });
                }
            }





            return results;
        }
    }
}
