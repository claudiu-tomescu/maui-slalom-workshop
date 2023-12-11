using System;
using MauiSlalomDemo.Model;

namespace MauiSlalomDemo.Services
{
    public class TopStoriesService
    {
        List<TopStory> topStories = new();
        HttpClient httpClient = new HttpClient();
        const string API_KEY = "rl01NT4xOodyre2Dcs1rRheqpyV3wokb";

        public async Task<List<TopStory>> GetTopStories()
        {
           
            Uri uri = new Uri(string.Format("https://api.nytimes.com/svc/topstories/v2/arts.json?api-key={0}", API_KEY));
            try
            {
                var response = await httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var apiStories = JsonConvert.DeserializeObject<TopStoryApiResponse>(content);

                    foreach (TopStoryItem apiStory in apiStories.results)
                    {
                        var story = new TopStory();
                        story.Abstract = apiStory.@abstract;
                        story.Byline = apiStory.byline;
                        story.Section = apiStory.section;
                        story.Subsection = apiStory.subsection;
                        story.Title = apiStory.title;
                        story.Url = apiStory.url;
                        var image = apiStory.multimedia.FirstOrDefault<Multimedium>(m => m.format == "Large Thumbnail");
                        if (image != null)
                        {
                            story.Image = image.url;
                        }

                        topStories.Add(story);
                    }
                }
            }
            catch (Exception e)
            {
                //
            }

            return topStories;
        }
    }

    #region API Helper classes
    public class Multimedium
    {
        public string url { get; set; }
        public string format { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string type { get; set; }
        public string subtype { get; set; }
        public string caption { get; set; }
        public string copyright { get; set; }
    }

    public class TopStoryItem
    {
        public string section { get; set; }
        public string subsection { get; set; }
        public string title { get; set; }
        public string @abstract { get; set; }
        public string url { get; set; }
        public string uri { get; set; }
        public string byline { get; set; }
        public string item_type { get; set; }
        public DateTime updated_date { get; set; }
        public DateTime created_date { get; set; }
        public DateTime published_date { get; set; }
        public string material_type_facet { get; set; }
        public string kicker { get; set; }
        public List<string> des_facet { get; set; }
        public List<string> org_facet { get; set; }
        public List<string> per_facet { get; set; }
        public List<string> geo_facet { get; set; }
        public List<Multimedium> multimedia { get; set; }
        public string short_url { get; set; }
    }

    public class TopStoryApiResponse
    {
        public string status { get; set; }
        public string copyright { get; set; }
        public string section { get; set; }
        public DateTime last_updated { get; set; }
        public int num_results { get; set; }
        public List<TopStoryItem> results { get; set; }
    }

    #endregion
}

