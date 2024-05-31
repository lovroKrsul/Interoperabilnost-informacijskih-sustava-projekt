using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

using System.Xml.Schema;
using System.Xml.Linq;
using System.Xml;
using ISS_RestService.Models;

namespace ISS_RestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class XsdController : ControllerBase
    {
        private List<Game> Igre;

        public XsdController(List<Game> PopisIgri)
        {
            this.Igre =PopisIgri;
        }

        [HttpGet]
        public List<Game> Get()
        {
            return Igre;
        }


        [HttpPost]
        public void Post(string documentPath)
        {
            Game Igra=new Game();
           

            //tu ide if valid
            if (Igra != null)
            {
                XDocument doc = null;
                bool correct = true;
                XmlSchemaSet schema = new XmlSchemaSet();
                //validate xsd
                try
                {
                    schema.Add("", ".\\xsdSchema.xsd");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("no such file exists");
                    HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                    correct = false;
                }
               
                
                try
                {

                     doc = XDocument.Load(documentPath);
                }
               catch(System.Xml.XmlException ex)
                {
                    Console.WriteLine(ex.Message);
                    HttpContext.Response.StatusCode = StatusCodes.Status415UnsupportedMediaType;
                    
                    correct = false;


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong");
                    HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                    correct = false;
                    
                }
               
               
                string errorMsg = "";
                if(doc!=null && correct==true)
                {
                    doc.Validate(schema, (s, e) => {
                        errorMsg = e.Message; correct = false; Console.WriteLine(errorMsg);
                    });
                    
                
                
               
                XmlTextReader reader = new XmlTextReader(documentPath);
                while(reader.Read())
                {
                    if(reader.NodeType==XmlNodeType.Element)
                    {
                        switch(reader.Name)
                        {
                            case "ID":
                                Igra.ID =reader.ReadElementContentAsString();
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
            else {HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest; }
        }

      
    }
}

