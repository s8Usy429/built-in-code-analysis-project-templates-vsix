# built-in-code-analysis-project-templates-vsix
<p>
    A Visual Studio extension adding new project templates with built-in code analysis.<br/>
    The extension is for Visual Studio 2022 and above.<br/>
    This extension makes sure <a href="https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview#third-party-analyzers">recommended analyzers</a> are installed and enabled at all time.<br/>
    <ul>
        <li>.NET analyzers</li>
        <li>SonarAnalyzer</li>
        <li>Roslynator (for C# projects only)</li>
        <li>FluentAssertions.Analyzers (for test projects only)</li>
        <li>xunit.analyzers (for test projects only)</li>
    </ul>
</p>

## Overview

<table>
	<tr>
		<td colspan="2" align="center">
			<img src="doc/add_project_dialog.png"/>
			<div><i>Visual Studio New Project Dialog with the new templates</i></div>
			<br/>
		</td>
	</tr>
	<tr>
		<td valign="center" align="center">
			<img src="doc/overview1.png"/>
			<div><i>C# Console Application</i></div>
			<br/>
		</td>
		<td valign="center" align="center">
			<img src="doc/overview2.png"/>
			<div><i>C# xUnit Test Project</i></div>
			<br/>
		</td>
	</tr>
	<tr>
		<td valign="center" align="center">
			<img src="doc/overview3.png"/>
			<div><i>Linq query optimization detected</i></div>
		</td>
		<td valign="center" align="center">
			<img src="doc/overview4.png"/>
			<div><i>Weak encryption algorithm detected</i></div>
		</td>
	</tr>
</table>

<br/>

## List of project templates

| Language | Type          | Compatible Frameworks                            | Name                                                            | Included Analyzers                                                                     |
|:--------:|:-------------:|:------------------------------------------------:|:---------------------------------------------------------------:|:--------------------------------------------------------------------------------------:|
| C#       | Console App   | .NET Core 3.1, .NET 5, .NET 6                    | Console App with built-in code analysis                         | .Net analyzers, SonarAnalyzer, Roslynator                                              |
| C#       | Console App   | .NET Framework 4.6.2, 4.7, 4.7.1, 4.7.2, 4.8     | Console App with built-in code analysis (.NET Framework)        | .Net analyzers, SonarAnalyzer, Roslynator                                              |
|          |               |                                                  |                                                                 |                                                                                        |
| C#       | Class Library | .Net Standard 2.1, .NET Core 3.1, .NET 5, .NET 6 | Class Library with built-in code analysis                       | .Net analyzers, SonarAnalyzer, Roslynator                                              |
| C#       | Class Library | .NET Framework 4.6.2, 4.7, 4.7.1, 4.7.2, 4.8     | Class Library with built-in code analysis (.NET Framework)      | .Net analyzers, SonarAnalyzer, Roslynator                                              |
|          |               |                                                  |                                                                 |                                                                                        |
| C#       | Test/xUnit    | .NET Core 3.1, .NET 5, .NET 6                    | xUnit Test Project with built-in code analysis                  | .Net analyzers, SonarAnalyzer, Roslynator, xunit.analyzers, FluentAssertions.Analyzers |
| C#       | Test/xUnit    | .NET Framework 4.6.2, 4.7, 4.7.1, 4.7.2, 4.8     | xUnit Test Project with built-in code analysis (.NET Framework) | .Net analyzers, SonarAnalyzer, Roslynator, xunit.analyzers, FluentAssertions.Analyzers |
|          |               |                                                  |                                                                 |                                                                                        |
| VB       | Console App   | .NET Core 3.1, .NET 5, .NET 6                    | Console App with built-in code analysis                         | .Net analyzers, SonarAnalyzer                                                          |
| VB       | Console App   | .NET Framework 4.6.2, 4.7, 4.7.1, 4.7.2, 4.8     | Console App with built-in code analysis (.NET Framework)        | .Net analyzers, SonarAnalyzer                                                          |
|          |               |                                                  |                                                                 |                                                                                        |
| VB       | Class Library | .Net Standard 2.1, .NET Core 3.1, .NET 5, .NET 6 | Class Library with built-in code analysis                       | .Net analyzers, SonarAnalyzer                                                          |
| VB       | Class Library | .NET Framework 4.6.2, 4.7, 4.7.1, 4.7.2, 4.8     | Class Library with built-in code analysis (.NET Framework)      | .Net analyzers, SonarAnalyzer                                                          |

<br/>

## Pros of using analyzers

* Write compliant code
  * More secure (will detect weak hash algorithms, hard-coded sensitive stuff, etc.)
  * More optimized (will detect and autofix slow database queries, etc.)
  * Less error prone (will detect code smells, dead code, etc.)
* Happens during development phase (fixes code as soon as possible)
* Friendlier pull request (code already cleaned and optimized)
* CI will complain less (code already compliant)

<br/>

## Installation guide

1. Download <a href="https://github.com/s8Usy429/built-in-code-analysis-vs-project-templates-extension/releases/latest">the latest release</a>:<br/>
![Install Step1](doc/install_step1.png)

2. Launch the installer:<br/>
![Install Step2](doc/install_step2.png)

3. Select at least one target Visual Studio version where the extension should be installed:<br/>
![Install Step3](doc/install_step3.png)

4. Close Visual Studio instances if the installer complains about it.

5. That's it. You can check the extension has been installed successfuly from Visual Studio extension window:<br/>
![Install Step4](doc/install_step4.png)

<br/>

## Usage

1. Open Visual Studio "Create a new project" window.

2. All the new projects will show up at the top (it will until you use them).

3. At anytime, you can filter the list of projects on the "Analyzed" project type.<br/>
This, will show only projects added by this extension<br/>
![Usage3](doc/usage3.png)

4. Let us create an instance of "xUnit Test Project with built-in code analysis":

5. Wait for Visual Studio to restore nuget packages, or trigger it yourself.

6. Visual Studio 2022 conveniently shows the list of installed analyzers from the "Solution Explorer" window:<br/>
![Usage4](doc/overview2.png)<br/><br/>
Notice, the extension has installed the following analyzers:
   * FluentAssertions.Analyzers (assuming you are going to use FluentAssertions which is also installed by this extension)
   * .Net Analyzers
   * Roslynator
   * SonarAnalyzer
   * (xunit.analyzers is now already included when installing xunit. This is not included by this extension.)

7. If you are curious, you can see the list of all the rules for each analyzer:<br/>
![Usage5](doc/usage5.png)

8. Enjoy coding easier !

<br/>

## Developper guide

Actually, the extension just provides a way to deploy the project templates.<br/>
It is an empty extension (no code) and just references a local nuget package which does contain the project templates.<br/>
The reason it is done like this is because the templates have nothing to do with Visual Studio. They are "dotnet new XXX" style projects.<br/>
Actually you can achieve this if you go an install the local nuget package like this:<br/>
<code># Create the nuget package</code><br/>
<code>dotnet pack templates/_ignore.csproj -o templates</code><br/>
<code># Install the nuget package to work with dotnet CLI</code><br/>
<code>dotnet new --install templates/ProjectsWithAnalyers.Templates.1.0.0.nupkg</code><br/>
<code># Verify installed templates</code><br/>
<code>dotnet new -l # the output will contain the templates shiped inside the nuget package</code><br/>
<code># How to uninstall</code><br/>
<code>dotnet new --uninstall templates/ProjectsWithAnalyers.Templates.1.0.0.nupkg</code>

Using the extension basically does all that without impacting your dotnet CLI installation though (templates won't show up in <code>dotnet new -l</code>).<br/>
To make sure the extension is always deploying the latest version of the nuget package, the extension recreates the package using the following pre-build event:<br/>
<code>dotnet pack "\$(SolutionDir)templates\_ignore.csproj" -o "\$(SolutionDir)templates"</code><br/>
<code>RD /S /Q "\$(SolutionDir)templates\bin"</code><br/>
<code>RD /S /Q "\$(SolutionDir)templates\obj"</code><br/>

<br/>

### Build and run the extension:

1. Install the extensibility module from Visual Studio Installer:
![Develop Guide1](doc/develop_guide1.png)

2. Install the "Extensibility Essentials 2022" extension from Visual Studio managment window:
![Develop Guide2](doc/develop_guide2.png)

3. Open the solution within Visual Studio, build and run.<br/>
Visual Studio will start an experimental instance of Visual Studio with the extension installed.

4. Within the newly started experimental instance, navigate to the "Create new project" window. The project templates will show up.

<br/>

### Understand how the templates are packed
All the templates are located within the "templates" folder:<br/>
![Develop Guide3](doc/develop_guide3.png)<br/>
The "_ignore.csproj" is a fake project just to be able to use the <code>dotnet pack</code> command.<br/>
The <code>dotnet pack</code> command currently requires a project to create a nuget package. Microsoft is working on it, but it is not there yet.<br/>
The nuget simply contains the file like a zip archive would do. There is no C#/VB code whatsoever. Just raw files packed in.<br/>
The extension creates the package on build using the following pre-build event:<br/>
<code>dotnet pack "\$(SolutionDir)templates\_ignore.csproj" -o "\$(SolutionDir)templates"</code><br/>
<code>RD /S /Q "\$(SolutionDir)templates\bin"</code><br/>
<code>RD /S /Q "\$(SolutionDir)templates\obj"</code><br/>

<br/>

### What's inside template folders ?

<table>
	<tr>
		<td valign="center" align="center">
			<img src="doc/develop_guide4.png"/>
			<div><i>C# Console Application</i></div>
			<br/>
		</td>
		<td valign="center" align="center">
			<img src="doc/develop_guide5.png"/>
			<div><i>VB legacy Console Application</i></div>
			<br/>
		</td>
	</tr>
</table>

| Item                             | Name can be changed | Description                                                                                                                                                   |
|----------------------------------|:-------------------:|---------------------------------------------------------------------------------------------------------------------------------------------------------------|
| .template.config                 | No                  | A folder that contains the template configuration                                                                                                             |
| icon.png                         | No                  | (Optional) The icon the template will display within "Visual Studio New Project Dialog" window.<br/>If not set, Visual Studio provides a default icon anyway. |
| template.json                    | No                  | The configuration of the template.                                                                                                                            | 
| csappwithanalyzers.csproj        | Yes                 | A file that will be created when creating an instance of the template. Could be any file.                                                                     |
| Program.cs                       | Yes                 | A file that will be created when creating an instance of the template. Could be any file.                                                                     |
|                                  |                     |                                                                                                                                                               |
| My Project                       | Yes                 | A folder that will be created when creating an instance of the template. Could be any folder.                                                                 |
| -.-                              | No                  | An empty file ignored by the template engine when we need to create an empty folder. This file won't be created when creating an instance of the template.    |
| Module1.vb                       | Yes                 | A file that will be created when creating an instance of the template. Could be any file.                                                                     |
| vbappwithanalyzers_legacy.csproj | Yes                 | A file that will be created when creating an instance of the template. Could be any file.                                                                     |

<br/>

### Learn more about dotnet template engine
<a href="https://github.com/dotnet/templating/wiki">Home for the .NET Core Template Engine</a><br/>
<a href="https://github.com/sayedihashimi/template-sample">sayedihashimi sample repository</a>

<br/>

## Miscellaneous/Troubleshooting 
<p>This extension will only work on VS2022 and above !!! The installer won't let you install it on VS2019 anyway.</p>
<p>There is no plan to add a template for creating xUnit tests using VB. Turns out you can just use a C# xUnit test project to test VB stuff.</p>