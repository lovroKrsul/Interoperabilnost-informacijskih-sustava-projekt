using ISS_RestService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml;
using Commons.Xml.Relaxng;

namespace ISS_RestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RngController : ControllerBase
    {
        private List<Game> Igre;

        public RngController(List<Game> PopisIgri)
        {
            this.Igre = PopisIgri;
        }

        [HttpGet]
        public List<Game> Get()
        {
            return Igre;
        }
        [HttpPost]
        public void Post(String documentPath)
        {
            Game Igra = new Game();
            RelaxngValidatingReader readerRng = null;
            if (Igra != null)
            {
                XmlReader xml = null;
                //validate xsd
                try
                {
                   xml = new XmlTextReader(documentPath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("no such file exists");
                }
                
                XmlReader schema=new XmlTextReader(".\\rngSchema.rng");
                bool correct = true;
                if (xml != null)
                {

                    readerRng = new RelaxngValidatingReader(xml, schema);
                }
                else { correct = false; };
                readerRng.InvalidNodeFound += (source, message) => {
                    Console.WriteLine("Error: " + message);
                    correct = false;
                    return true;
                };
                try
                {
                    if (readerRng != null)
                    { XDocument doc = XDocument.Load(readerRng); }
                   
                }
                catch (System.Xml.XmlException ex)
                {
                    Console.WriteLine(ex.Message);
                    correct = false;
                    HttpContext.Response.StatusCode = StatusCodes.Status418ImATeapot;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong");
                    correct= false;
                    HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                }


                
             

              
                if(correct)
                {
                    
                    XmlTextReader reader = new XmlTextReader(documentPath);
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            switch (reader.Name)
                            {
                                case "ID":
                                    Igra.ID = reader.ReadElementContentAsString();
                                    break;
                                case "Publisher":
                                    Igra.Publisher = reader.ReadElementContentAsString();
                                    break;
                                case "title":
                                    Igra.title = reader.ReadElementContentAsString();
                                    break;
                                case "ganre":
                                    Igra.ganre = reader.ReadElementContentAsString();
                                    break;
                                case "price":
                                    Igra.price = reader.ReadElementContentAsString();
                                    break;
                                case "description":
                                    Igra.desription = reader.ReadElementContentAsString();
                                    break;
                            }
                        }
                    }
                    Igre.Add(Igra);
                    HttpContext.Response.StatusCode = StatusCodes.Status201Created;
                }

                

            }
            //else
            else { HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest; }
        }
    }
}
