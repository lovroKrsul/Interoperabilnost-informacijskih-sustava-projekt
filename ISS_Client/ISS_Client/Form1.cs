using ISS_Client.Soap_Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace ISS_Client
{
    public partial class Form1 : Form
    {
        String games_string = "";
        public Form1()
        {
            InitializeComponent();
        }
        
        //nemogu ga bolje razdovjit jel po svemu sta probam razdvojit postoji vec ili u linku ili u stringu nekom (probo sam po { , " ] etc)
        private async void getGames_Btn_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://steam2.p.rapidapi.com/search/Counter/page/1"),
                Headers =
    {
        { "X-RapidAPI-Key", "c8490c80acmshec0b2bde1bfa506p1137b0jsnc290317267b8" },
        { "X-RapidAPI-Host", "steam2.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                string[] games = body.Split('{');
                foreach (string game in games)
                {
                    string[] atributes = game.Split(',');

                    games_string += game;
                    games_string += "\n";
                }
                games_string.Trim();
                Games_Tb.Text = games_string;


            }

        }

        private void xsd_File_Btn_Click(object sender, EventArgs e)
        {
          
            
                string path = @".\xmlToValidate.xml";
                HttpWebRequest req = WebRequest.CreateHttp("http://localhost:5216/api/xsd");
                req.Method = "POST";
                var encoding = new UTF8Encoding();
                var data = Encoding.UTF8.GetBytes(path);
                req.Accept = "aplication/xml";
                req.ContentType = "aplication/xml";
                req.ContentLength = data.Length;
                Stream stream = req.GetRequestStream();

                stream.Write(data, 0, data.Length);

                stream.Close();


                //tu rokne nesto sa streamom
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                if (resp.StatusCode == HttpStatusCode.Created)
                {
                    Console.WriteLine("Radi");
                }
                else if (resp.StatusCode == HttpStatusCode.UnsupportedMediaType)
                {
                    Console.WriteLine("Xml not valid");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            
           
        }

        private void rng_File_Btn_Click(object sender, EventArgs e)
        {
            string path = @".\xmlToValidate.xml";
            HttpWebRequest req = WebRequest.CreateHttp("http://localhost:5216/api/rng");
            req.Method = "POST";
            var encoding = new UTF8Encoding();
            var data = Encoding.UTF8.GetBytes(path);
            req.Accept = "aplication/xml";
            req.ContentType = "aplication/xml";
            req.ContentLength = data.Length;
            Stream stream = req.GetRequestStream();

            stream.Write(data, 0, data.Length);

            stream.Close();


            //tu rokne nesto sa streamom
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            if (resp.StatusCode == HttpStatusCode.Created)
            {
                Console.WriteLine("Radi");
            }
            else if (resp.StatusCode == HttpStatusCode.UnsupportedMediaType)
            {
                Console.WriteLine("Xml not valid");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        private void Soap_Search_Btn_Click(object sender, EventArgs e)
        {
            string searchTerm = search_tb.Text;
            SoapGame[] games = null;
            try
            {
                Soap_Service.Service1Client client = new Soap_Service.Service1Client();

                 games = client.GetDocument(searchTerm);
            }
            catch (Exception ex)
            {
                Soap_Response_Tb.Text = ex.Message;
                Soap_Response_Tb.SelectAll();
                Soap_Response_Tb.SelectionColor = Color.Red;
            }
            
            if(games.Length == 0) {
                
                
                Soap_Response_Tb.Text = "No game by that name!";
                Soap_Response_Tb.SelectAll();
                Soap_Response_Tb.SelectionColor = Color.Red;

            }
            else
            {
                if(games!=null)
                {
                    foreach (SoapGame game in games)
                    {

                        Soap_Response_Tb.Text += ("ID: " + game.appID + "\n");
                        Soap_Response_Tb.Text += ("Title: " + game.title + "\n");
                        Soap_Response_Tb.Text += ("Url: " + game.url + "\n");
                        Soap_Response_Tb.Text += ("ImgUrl: " + game.imgUrl + "\n");
                        Soap_Response_Tb.Text += ("Review: " + game.reviewSummary + "\n");
                        Soap_Response_Tb.Text += ("Relese Date: " + game.releseDate + "\n");
                        Soap_Response_Tb.Text += ("Price: " + game.price + "\n");
                       
                    }
                    Soap_Response_Tb.SelectAll();
                    Soap_Response_Tb.SelectionColor = Color.Black;
                }
               
            }
           
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Soap_Service.Service1Client client = new Soap_Service.Service1Client();
                client.GenerateXML();
            }
           catch(Exception ex)
            {
                Soap_Response_Tb.Text = ex.Message;
                Soap_Response_Tb.SelectAll();
                Soap_Response_Tb.SelectionColor = Color.Red;
            }
        }
    }
}
