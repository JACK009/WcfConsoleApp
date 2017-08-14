using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Reflection;

namespace WcfService.Context
{
    public class AuthorContext
    {
        public JArray GetAuthors()
        {
            string resourceName = "WcfService.App_Data.authors_data.authors.json";
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream(resourceName);
            JsonTextReader reader = new JsonTextReader(new StreamReader(stream));

            return JArray.Load(reader);
        }
        
    }
}