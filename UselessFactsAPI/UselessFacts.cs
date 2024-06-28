namespace UselessFactsAPI
{
    public static class UselessFacts
    {
        /// <summary>
        /// A static method that fetches a single random fact from uselessfacts.jsph.pl
        /// </summary>
        /// <returns>string</returns>
        /// <example>
        /// string randomFact = UselessFacts.RandomFact();
        /// Console.WriteLine(randomFact);
        /// </example>
        public static string RandomFact()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/plain"));
                    // Send a GET request to the URL
                    HttpResponseMessage response = client.GetAsync("https://uselessfacts.jsph.pl/api/v2/facts/random?language=en").Result;
                    return response.Content.ReadAsStringAsync().Result;
                }
                catch (HttpRequestException ex)
                {
                    return ex.Message;
                }
            }
        }
        public static string RandomFact(bool german)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string lang = german ? "de" : "en";
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/plain"));
                    // Send a GET request to the URL
                    HttpResponseMessage response = client.GetAsync($"https://uselessfacts.jsph.pl/api/v2/facts/random?language={lang}").Result;
                    return response.Content.ReadAsStringAsync().Result;
                }
                catch (HttpRequestException ex)
                {
                    return ex.Message;
                }
            }
        }
        /// <summary>
        /// A static method that fetches a single random fact for TODAY from uselessfacts.jsph.pl
        /// </summary>
        /// <returns>string</returns>
        /// <example>
        /// string todaysFact = UselessFacts.TodayFact();
        /// Console.WriteLine(todaysFact);
        /// </example>
        public static string TodayFact()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/plain"));
                    // Send a GET request to the URL
                    HttpResponseMessage response = client.GetAsync("https://uselessfacts.jsph.pl/api/v2/facts/today?language=en").Result;
                    return response.Content.ReadAsStringAsync().Result;
                }
                catch (HttpRequestException ex)
                {
                    return ex.Message;
                }
            }
        }
        public static string TodayFact(bool german)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string lang = german ? "de" : "en";
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/plain"));
                    // Send a GET request to the URL
                    HttpResponseMessage response = client.GetAsync($"https://uselessfacts.jsph.pl/api/v2/facts/today?language={lang}").Result;
                    return response.Content.ReadAsStringAsync().Result;
                }
                catch (HttpRequestException ex)
                {
                    return ex.Message;
                }
            }
        }
    }
}
