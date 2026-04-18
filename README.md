# 🎯 Bingo Numbers – C# Console Game

A simple console-based number guessing game developed as a learning project in C#.

---

## 🧠 Overview

The program generates **10 unique random numbers (1–99)**.  
The user is then asked to enter **10 unique numbers within the same range**.

After input is completed, the program compares both sets and calculates how many numbers match.  
Each match gives **1 point**, and the user receives a message based on their final score.

---

## ⚙️ How it works

- The game generates a set of unique random numbers using `HashSet<int>`
- The user inputs their guesses with full validation:
  - Must be a number
  - Must be in range 1–99
  - Must be unique
- After input, both sets are compared
- Matching numbers are highlighted in color in the console
- Final score message is displayed based on performance

---

## 🛠 Programming techniques used

- `HashSet<int>` for automatic uniqueness handling
- `while` loops for controlled input and generation
- Input validation using `if / else` conditions
- `foreach` loops for comparison and output
- `switch expression` for clean message handling (C# 9.0 feature)
- Console color output via reusable helper method (`PrintWithColor`)
- Refactored structure with separated responsibilities per method

---

## 🚀 Refactoring improvements

This version includes several improvements over the initial implementation:

- Replaced `List<int>` with `HashSet<int>` for better performance and simplicity
- Removed manual duplicate checks (handled by `HashSet`)
- Improved naming conventions (clear and descriptive method names)
- Reduced code duplication by introducing reusable helper methods
- Simplified point calculation logic using LINQ-style approach
- Cleaned up input validation flow for better readability
- Made `Random` and configuration values (`numCount`) readonly
- Improved console output formatting and user experience
- Updated project to use **C# 9.0 language features**

---

## 🎯 Purpose of the project

This project was created as a practice exercise to improve understanding of:

- Loops (`while`, `foreach`)
- Conditional logic (`if / else`)
- Input validation
- Collections (`HashSet`)
- Code refactoring and readability
- Basic game logic design in C#

---

## ✨ Result

A simple but structured console game that demonstrates clean coding practices, improved logic flow, and modern C# features. 

