using System;
using System.IO;
using System.Net;
using System.Text;


namespace WebRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp("http://www.spiegel.de");

                WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                Stream dataStream = response.GetResponseStream();   // get bytes
                StreamReader reader = new StreamReader(dataStream); // get char
                string responseFromServer = reader.ReadToEnd();

                // Clean up the streams.
                reader.Close();
                dataStream.Close();
                response.Close();


                Console.WriteLine(responseFromServer);
                Console.WriteLine();
                Console.WriteLine(responseFromServer.Contains("tigermuecke"));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
