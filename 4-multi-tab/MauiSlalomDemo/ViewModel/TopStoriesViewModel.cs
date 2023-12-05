using System;
using MauiSlalomDemo.Model;
using MauiSlalomDemo.Services;

namespace MauiSlalomDemo.ViewModel
{
	public class TopStoriesViewModel : BaseViewModel
	{
		private TopStoriesService service;
        public ObservableCollection<TopStory> TopStories { get; } = new();
        public Command GetTopStoriesCommand { get; }

        public TopStoriesViewModel(TopStoriesService service)
		{
			this.service = service;
			Title = "NYT Stories";
            GetTopStoriesCommand = new Command(async () => await GetTopStories());
        }

		public async Task GetTopStories()
		{
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;

                var topStories = await service.GetTopStories();
                if (TopStories.Count != 0)
                    TopStories.Clear();

                foreach (var topStory in topStories)
                    TopStories.Add(topStory);
            }
            catch (Exception e)
            {
                //
            }
            finally
            {
                IsBusy = false;
            }
        }
	}
}

