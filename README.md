# mvvmbestpractices
Collection of MVVM best practices. The way I build apps with MVVMLight and other bits and pieces.

## What's the purpose?
I often see questions on forums and groups on how to start with MVVM and which library to use. So I decided to build this project and share it with the world of aspiring developers.

## What's included?
- Common project containing all platform independent code including ViewModels, app logic, base classes, interfaces, extensions, services, etc.
- WPF app that uses code from Common and implement its interfaces. The app uses MVVMLight's SimpleIOC dependency inversion container to register classes, and resolve them when needed.

## Bits and pieces to start with
- [VMBase](https://github.com/takacsalbert/mvvmbestpractices/blob/main/src/MVVMBestPractices/MVVMBestPractices.Common/ViewModels/VMBase.cs "VMBase"): the base class for your ViewModel classes that can be navigated onto
- [NavigationService](https://github.com/takacsalbert/mvvmbestpractices/blob/main/src/MVVMBestPractices/MVVMBestPractices.WPF/Services/NavigationService.cs "NavigationService"): the implementation of INavigationService providing a central place to navigate between pages in a WPF app.
- [Pages](https://github.com/takacsalbert/mvvmbestpractices/blob/main/src/MVVMBestPractices/MVVMBestPractices.Common/Navigation/Pages.cs "Pages"): Abstract collection of pages in your application. It's just a list of strings that you can use to navigate around. It is important to be able to reference pages in a platform-independent way to be able to keep app logic centralized and separated from the presentation layers.
- [BaseView](https://github.com/takacsalbert/mvvmbestpractices/blob/main/src/MVVMBestPractices/MVVMBestPractices.WPF/Views/BaseView.cs "BaseView"): the base class for your Views. In case of a WPF application, they are going to be simple UserControls. This class is responsible for calling navigation related events on the ViewModels.

## Plans ahead
You know, a project is never finished. There is always something to add or polish the code here and there. Here is a todo list for this particular project:
- Add DialogService: service to help you with popping up complex modal dialogs and showing simple notifications
- Add more types of apps: Since we have the building blocks (in the Commond project), we can code the actual implementations for more platforms. I am going to add Xamarin Forms, UWP, Xamarin native apps in the future showing that the same technique works on different platforms. And it works without modifying the Common project or other apps.
- I am happy to add anything you would like to see. Please create a new issue for specific requests.

## References
I know I need to show that this works. So here are two of my projects that are built with the same approach that is presented here. Unfortunately I cannot disclose their code base, because I don't want to. :)
- [Elllo English Learning](https://takacsalbert.wordpress.com/elllo/ "Elllo English Learning"): Feature rich English learning app built using UWP and Xamarin Android native. Available on Windows 10 and Android.
- [ReDraw!](https://takacsalbert.wordpress.com/redraw/ "ReDraw!"): A combination of memory and drawing games built using UWP and Xamarin Android native. Available on Windows 10 and Android.
