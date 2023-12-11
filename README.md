# .NET MAUI Slalom Workshop

This repository contains the code and artifacts for the .NET MAUI workshop, as well as instructions for each of the workshop's lessons.



In this workshop we'll be using the New Yor Times' Top Stories API. For more info please refer to: [Top Stories | Dev Portal (nytimes.com)](https://developer.nytimes.com/docs/top-stories-product/1/overview)



## Lesson 1

In this introductory lesson we go over the basic of .NET MAUI application structure, installing the Visual Studio workload, creating and running a basic MAUI application in iOS and Android. We also get a glimpse of the final application that we're going to build together.

Below are all the things we are going to accomplish in this lesson:

* Install the .NET MAUI workload in Visual Studio (Mac or Windows) including iOS simulators & Android emulators.
* Overview of final application we are building (screenshot below)

* Creating the sigle page application project and overview of the app' structure.
* Run the application in Android emulator and iOS simulator

<img src="ScreenshotMauiApp.png" alt="Final MAUI App screenshot" style="zoom:100%;" />

## Lesson 2

In this lesson we'll go ahead and create the layout for displaying the list of articles in our application. For building the UI we'll use MAUI controls such as DataGrid, CollectionView, and Button and we'll learn about customizing the appearance with ItemTemplate and XAML data binding. For this lesson we'll hardcode (i.e. staticaly define) the list of articles we are showing in the application.



Here is the link to the recording: [MAUI Workshop-20231127_120346-Meeting Recording.mp4](https://twodegrees1-my.sharepoint.com/:v:/r/personal/claudiu_tomescu_slalom_com/Documents/Recordings/MAUI Workshop-20231127_120346-Meeting Recording.mp4?csf=1&web=1&e=JJh8d1&nav=eyJyZWZlcnJhbEluZm8iOnsicmVmZXJyYWxBcHAiOiJTdHJlYW1XZWJBcHAiLCJyZWZlcnJhbFZpZXciOiJTaGFyZURpYWxvZy1MaW5rIiwicmVmZXJyYWxBcHBQbGF0Zm9ybSI6IldlYiIsInJlZmVycmFsTW9kZSI6InZpZXcifX0%3D)



## Lesson 3

In this lesson we'll dynamically load the list of articles using the New Yort Times API and display it on the screen by binding it to the CollectionView control created in previous lesson using MVVM pattern. We'll also demonstrate the use of MAUI's dependency injection for automatically creating service and view-model instrances.



Here is the link to the recording: [MAUI Workshop-20231204_120141-Meeting Recording.mp4](https://twodegrees1-my.sharepoint.com/:v:/r/personal/claudiu_tomescu_slalom_com/Documents/Recordings/MAUI Workshop-20231204_120141-Meeting Recording.mp4?csf=1&web=1&e=9CKFDt&nav=eyJyZWZlcnJhbEluZm8iOnsicmVmZXJyYWxBcHAiOiJTdHJlYW1XZWJBcHAiLCJyZWZlcnJhbFZpZXciOiJTaGFyZURpYWxvZy1MaW5rIiwicmVmZXJyYWxBcHBQbGF0Zm9ybSI6IldlYiIsInJlZmVycmFsTW9kZSI6InZpZXcifX0%3D)



## Lesson 4

This lesson takes our application development one step further by:

* Load stories automatically when page loads (removing the button to load them on click)
* Implement pull to refresh for refreshing the list of articles (RefreshView)
* Implementing a multi tab interface (Shell & TabBar). Implement the sub-tabs (or top level tabs within a tab)
* Demonstrate swipe gestures (SwipeView)



Here is the link to the recording: [MAUI Workshop-20231211_120156-Meeting Recording.mp4](https://twodegrees1-my.sharepoint.com/:v:/r/personal/claudiu_tomescu_slalom_com/Documents/Recordings/MAUI Workshop-20231211_120156-Meeting Recording.mp4?csf=1&web=1&e=yUc7V2&nav=eyJyZWZlcnJhbEluZm8iOnsicmVmZXJyYWxBcHAiOiJTdHJlYW1XZWJBcHAiLCJyZWZlcnJhbFZpZXciOiJTaGFyZURpYWxvZy1MaW5rIiwicmVmZXJyYWxBcHBQbGF0Zm9ybSI6IldlYiIsInJlZmVycmFsTW9kZSI6InZpZXcifX0%3D)

Below are screenshots with pull to refresh feature in action inthe iOS app running in the iOS simulator, as well as the swipe gestures in the Android app running in the emulator.

![Pull to refresh in action](Pull_To_Refresh.png)

![Swipe gestures](Swipe_Gestures.png)