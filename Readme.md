## Description of the issue

Code to reproduce issue when using Refit interfaces inside of assemblies loaded with `Assembly.LoadFile`

Running the `SimpleConsole` application works as expected. Running the `CompositionConsole` application, which uses `Assembly.LoadFile` to load the `RandomUser` assmbly, throws an exception.

## Excpected result
Running CompositionConole prints 

## Actual result
Exception when creating the Refit interface implementation.
```
Unhandled exception. System.InvalidOperationException: INameGeneratorClient doesn't look like a Refit interface. Make sure it has at least one method with a Refit HTTP method attribute and Refit is installed in the project.
   at Refit.RestService.GetGeneratedType(Type refitInterfaceType) in /_/Refit/RestService.cs:line 173
   at Refit.RestService.For(Type refitInterfaceType, HttpClient client, IRequestBuilder builder) in /_/Refit/RestService.cs:line 76
   at Refit.RestService.For[T](HttpClient client, IRequestBuilder`1 builder) in /_/Refit/RestService.cs:line 20
   at Refit.RestService.For[T](HttpClient client, RefitSettings settings) in /_/Refit/RestService.cs:line 34
   at Refit.RestService.For[T](String hostUrl, RefitSettings settings) in /_/Refit/RestService.cs:line 54
   at Refit.RestService.For[T](String hostUrl) in /_/Refit/RestService.cs:line 65
   at RandomUser.RandomUserComposer.Compose() in /Users/ecamp/proj/test/RefitIssue/RandomUser/RandomUserComposer.cs:line 10
   at Program.<Main>$(String[] args) in /Users/ecamp/proj/test/RefitIssue/CompositionConsole/Program.cs:line 7
```
