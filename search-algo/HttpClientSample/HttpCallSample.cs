
public class HttpCallSample
{
    public static async Task Executor()
    {
        using (HttpClient httpClient = new())
        {
            httpClient.BaseAddress = new Uri("http://localhost");
            HttpResponseMessage response = await httpClient.GetAsync("api/Sample/{id}");
            response.EnsureSuccessStatusCode();
            var message = response.Content.ReadAsStringAsync();
        }

    }
}