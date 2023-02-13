namespace AnteBeotWinClient
{
    class Requests
    {
        public static async Task<string> GetUri(string uri)
        {
            // Get Reqeust
            var req = new HttpClient();
            var content = await req.GetAsync(uri);
            //Console.WriteLine();
            return await content.Content.ReadAsStringAsync();
        }
    }
}