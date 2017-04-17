# ASP.NET Core Starter Solution with EF6, ASP.NET Identity and an async implementation of the Repository pattern

This sample solution makes use of ASP.NET Core with ASP.NET Identity over Entity Framework Core running side-by-side
with Entity Framework 6. Look at this if you don't want Entity Framework Core for your data layer, but still want to
use ASP.NET Identity in ASP.NET Core and benefit from its out-of-the-box implementation (which is awesome!).

## Goals and inspiration
I was inspired by Mosh Hamedani's work on "Repository Pattern with C# and Entity Framework, Done Right". I think the theory that Mosh has put forward on the difference between a repository pattern and EF's DbContext is well structured and well explained. The sample code is also worth checking out.

I wanted to take it one step forward and put the pattern into an ASP.NET Core starter solution. The key point I want to demonstrate is using critical components of an ASP.NET Core MVC web application with an implementation of the repository that works side-by-side with the ASP.NET Identity 3 implementation. I wanted to make the repository asynchronous as well, because there's not many good examples out there.

The catch: ASP.NET Identity 3 uses ASP.NET Core and Entity Framework Core. That's all great, but many are not ready for EFCore and want the battle-tested Entity Framework 6. 

In summary, this sample answers these questions:

	• How do you inject an EF6 context with a connection string in the ASP.NET Core service collection?
	• How do you run ASP.NET Identity on EFCore and the rest of the application on EF6?
	• How do you properly implement the Repository pattern with EF6?
	• How do you make your Repository async?
	• How do you maintain one database for both your custom entities and ASP.NET Identity?
	• How and where do you implement a Services layer?
	• How do you make your Controller methods Async?
	• How do you use Services with Controllers?
	• How do you keep the connection string in one place?
