# Call Target Calculator

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
