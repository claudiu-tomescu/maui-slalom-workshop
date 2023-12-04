using MauiSlalomDemo.ViewModel;

namespace MauiSlalomDemo;

public partial class MainPage : ContentPage
{
	public MainPage(TopStoriesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

}


