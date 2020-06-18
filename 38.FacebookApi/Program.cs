using System;
using Newtonsoft.Json;

namespace _38.FacebookApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string fbtoken =  "KITDFCYGvkhvbhjvytFUYCytvouyVBUHHGCYTVhvhjv2873tvjhVJGC26FUVYLJbliyg67");
            string fbfields = "id, first_name, last_name, middle_name, name, name_format, picture, short_name, email";

            FacebookApi fb = new FacebookApi();

            string resultado = fb.ObtenerInfo(fbfields).Result;

            var res = JsonConvert.DeserializeObject(resultado);

            Console.WriteLine(resultado);
        }
    }
}
