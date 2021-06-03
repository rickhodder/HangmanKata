# Hangman

This kata can be found at

https://github.com/ardalis/kata-catalog/blob/main/katas/Hangman.md

Here are the steps I took before starting to work on this kata 

I created a new Github repository called HangmanKata 
https://github.com/rickhodder/HangmanKata
- No template
- Include Readme.md
- MIT License
- gitignore VisualStudio

I opened VS Code

I cloned the repository (ctrl+shift+p, then chose Clone Repository)

I opened the terminal in VS Code (ctrl+~)

And executed the following commands

```
dotnet new sln 

dotnet new xunit

dotnet sln add .\HangmanKata.csproj

rename unittest1.cs HangmanTests.cs
```

Finally, open HangmanTests.cs, and change the name of the 
class from "UnitTest1" to "HangmanTests"
