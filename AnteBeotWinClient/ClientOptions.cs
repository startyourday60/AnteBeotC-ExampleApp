using System;
using AnteBeotWinClient;
using Newtonsoft.Json;
using System.Configuration;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Net.WebRequestMethods;

public class ClientOptions
{
	String m_uri;
	const string defUri = "https://antebeot.ru:8083";
    // String uri = "https://antebeot.ru:8083"
    public ClientOptions() // get from config file
	{
		var sAttr = ConfigurationManager.AppSettings.Get("WebAPIUrl");
		if (sAttr != null) 
			this.m_uri = sAttr;
		else
			this.m_uri = defUri;

    }
    public static void WriteCookiesToDisk(string file, CookieContainer cookieJar)
    {
        using (Stream stream = System.IO.File.Create(file))
        {
            try
            {
                Console.Out.Write("Writing cookies to disk... ");
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, cookieJar);
                Console.Out.WriteLine("Done.");
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Problem writing cookies to disk: " + e.GetType());
            }
        }
    }

    public static CookieContainer ReadCookiesFromDisk(string file)
    {

        //try
        //{
            using (Stream stream = System.IO.File.Open(file, FileMode.Open))
            {
                Console.Out.Write("Reading cookies from disk... ");
                BinaryFormatter formatter = new BinaryFormatter();
                Console.Out.WriteLine("Done.");
                return (CookieContainer)formatter.Deserialize(stream);
            }
        //}
        //catch (Exception e)
        //{
        //    Console.Out.WriteLine("Problem reading cookies from disk: " + e.GetType());
        //    return new CookieContainer();
       // }
    }
    public String updateSession(CookieContainer sessionCookie)
    {
        String uri = this.GetUri();
        String rUri = String.Format("{0}/user/?w=updateSession", uri);
        var request = (HttpWebRequest)WebRequest.Create(rUri);
        request.CookieContainer = sessionCookie;
        try
        {
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream);
                string text = reader.ReadToEnd();
                return text;
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
        }
        return "";
    }
    public string GetUri() { return m_uri;  }
	public async Task<List<String>> getAllowCoinList()
	{
        String req = await Requests.GetUri(this.m_uri + "/api/?w=getallowcoins");
        var allowed_lists = JsonConvert.DeserializeObject<List<String>>(req);
		if (allowed_lists == null)
		{
			throw new Exception("Broken connection");
		}
		return allowed_lists;
    }
}
