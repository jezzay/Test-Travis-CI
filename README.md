Test-Travis-CI
==============
A test project to build a C# project with mono on Travis CI. 

The sample code is from selecting New Project -> ASP.NET Web Application in Visual Studio

Build status
--------------
[![Build Status](https://travis-ci.org/jezzay/Test-Travis-CI.png?branch=master)](https://travis-ci.org/jezzay/Test-Travis-CI)

Goals
------------
- Any dependant binaries (eg nuget packages) are not checked into git, rather downloaded via nuget for each build
- Compile the C# code 
- Run xUnit tests 

