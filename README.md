# NumberSequence

1. Details of applications, frameworks etc. required to run your solution : 
	-> This solution is developed using Visual Studio 2013 (.Net Framework 4.5), WCF Service, MVC5 and Unit tested with the use of MSUnit      Test.
  -> Nuget Package for Dependancy Injection - Unity.MVC5 to solve DI, Data Annotations for Validations,Moq for Mocking Objects in Unit        Test
	
2. Technical description :
Solution contains 5 projects:
1) Console application: NumberSequenceHost -> WCF service is self hosted in the console application.
2) Service Test Project: NumberSequenceTests -> All the unit test cases are written and tested.
3) Web Application (MVC): NumberSequenceWeb -> MVC application for User experience
4) Web Test Project: NumberSequenceWeb.Tests -> To run MVC web test cases using Moq and DI
5) WCF Service: NumberSequenceService -> for business logic

	
3. Steps to run the application:
1) Run NumberSequenceHost.exe as Administrator as WCF service is self hosted in console application
2) Once the service is started, run the web application - NumberSequenceWeb

4. Steps to Unit Test:
1) Use NumberSequenceTests to test service unit test cases
2) Use NumberSequenceWeb.Tests to test client unit test cases
