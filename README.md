# _Palindrome Checker_

#### _An application that lets a user input a word, phrase, or sentence to find out if it is a palindrome. , Feb 2020_

#### By _**Patrick Kille & Benjamin Thom**_

## Description

A user enters a string and the application will return whether it is a palindrome.

## Project Specifications

| Behavior | Input | Output |
|---|:---:|:---:|
|User enters a string.|Race Car.|NA|
|String is normalized, white space and punctuation is removed|Race Car.|racecar|
|Application compares first letter to last letter|r == r?|true|
|Application iterates from front to back and back to front|a == a? c == c?|true true|
|If any pair is not equal return false|r == e? |"Not a Palindrome"|
|If all pairs true|racecar == racecar|"Is a Palindrome|

## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/PRKille/C-super-sharp-Palindrome-Check.git```
* Navigate to C-super-sharp-Palindrome-Check in your terminal and run "dotnet run"

_Download Manually:_

* Navigate to https://github.com/PRKille/C-super-sharp-Palindrome-Check.
* Click the green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Navigate to the folder called "C-super-sharp-Palindrome-Check" in your terminal.
* Run the command "dotnet run"

_Note For Editors:_ 
* Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal

* Install dotnet script, run the ```$ dotnet tool install -g dotnet-script``` command in your terminal
* Restart your terminal to complete installation, and run the ```$ dotnet run``` command to run application within your terminal - Note: To exit, simply press ```Ctrl + C```
## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? Please open a pull request.

## Technologies Used

* C#
* .Net Core

### License

[MIT]

Copyright (c) 2020 **_Patrick Kille & Benjamin Thom_**
