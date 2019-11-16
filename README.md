# Dapper-Tools
Repo for code that I usually end up writing over again and again when working on multiple different kinds of games so I decided to create a custom Unity package to make life easier. Feel free to make use of this yourself and I am happy to consider pull requests whilst also fixing reported issues.

# Installing with Unity Package Manager

To install this project as a [Git dependency](https://docs.unity3d.com/Manual/upm-git.html) using the Unity Package Manager,
add the following line to your project's `manifest.json`:

```
"com.dapperdino.dappertools": "https://github.com/DapperDino/Dapper-Tools.git"
```

You will need to have Git installed and available in your system's PATH.

If you are using [Assembly Definitions](https://docs.unity3d.com/Manual/ScriptCompilationAssemblyDefinitionFiles.html) in your project, you will need to add `DapperTools` and/or `DapperToolsEditor` as Assembly Definition References.

# External Dependencies

For the unit testing in this project I am using [Moq](https://www.nuget.org/packages/Moq/) to mock dependancies. Due to liscencing reasons I don't think I should have their nuget packages directly in this repo and I can't simply add it to the package.json because it isn't a package from the Unity Package Manager. Please follow [this video](https://www.youtube.com/watch?v=9AMPDjaSmjQ) to set it up'