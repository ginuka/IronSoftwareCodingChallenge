# IronSoftwareCodingChallenge
C# code Coding Challenge with Iron Software 


This is a C# Console Application developed using **.NET 8** for the Iron Software Coding Challenge.  
It includes a logic implementation and unit tests to verify functionality.

## 📁 Project Structure

│
├── IronSoftwareCodingChallenge.sln # Solution file
├── IronSoftwareCodingChallenge/ # Main console app
│ ├── Program.cs
│ └── KeyPadService.cs
│
└── IronSoftwareCodingChallenge.Test/ # xUnit test project
  ├── UnitTest.cs


The program decodes numeric keypad input (like old mobile phones), where:

- Keys `2` to `9` represent letter groups
- Repeated digits represent the position in the group
- `0` is assumed to represent a **space**


## 🛠 Technologies Used

- .NET 8
- C#
- xUnit for Unit Testing