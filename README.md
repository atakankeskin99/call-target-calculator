# Call Target Calculator
![Java](https://img.shields.io/badge/Java-JDK%2017-orange)
![Type](https://img.shields.io/badge/type-Console-lightgrey)
![Status](https://img.shields.io/badge/status-learning%20project-lightgrey)


A simple Java console application that helps call center agents track daily call targets and calculate the required hourly pace to reach the goal.

## Why this exists
In busy shifts, it’s easy to lose track of pace. This small tool asks for your daily work details (login time, breaks, current calls) and tells you how many calls you should be making per hour to hit the target.

## Features
- Calculates **net working time** (login hours minus breaks)
- Shows the **required hourly call pace** to reach the daily target
- Handles basic input validation (no negative values, etc.)
- Lightweight: **pure Java console app**, no dependencies

## How it works (example)
You enter:
- How many hours you worked today
- Total break minutes
- Calls completed so far

Then it outputs:
- Remaining calls
- Remaining net time
- Required calls per hour

## Requirements
- Java 8+ (recommended: Java 17)

## Run
Compile and run from the project root:

```bash
javac src/CallTargetCalculator.java
java -cp src CallTargetCalculator

```




## Other Implementations
This project also exists in different forms:

- 🖥 **Java GUI version**  
  https://github.com/atakankeskin99/CallTargetCalculatorGUI

- 🌐 **Web-based version**  
  https://github.com/atakankeskin99/call-target-calculator-web

Each version shares the same core idea but explores different interfaces and technologies.
