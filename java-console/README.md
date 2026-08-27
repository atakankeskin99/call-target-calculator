# Call Target Calculator — Java Console

![Java](https://img.shields.io/badge/Java-JDK%2017-orange)
![Type](https://img.shields.io/badge/interface-Console-lightgrey)

The original implementation of the Call Target Calculator.

This version is a lightweight Java console application that calculates the required hourly call pace to reach a fixed daily target.

It served as the starting point for the later C# WinForms and web implementations included in the main repository.

## Features

* Console-based user input
* Calculates net working time
* Calculates remaining working time
* Calculates remaining calls
* Calculates the required calls per hour
* Basic input validation
* No external dependencies

## Inputs

The application asks for:

* Logged-in hours
* Total break minutes
* Calls completed so far

## Core Values

```text
Daily call target: 200 calls
Daily net working time: 8.5 hours
```

## Calculation

```text
Net worked hours =
    Login hours - (Break minutes / 60)

Remaining net hours =
    Daily net hours - Net worked hours

Remaining calls =
    Daily target - Calls taken

Required pace =
    Remaining calls / Remaining net hours
```

## Requirements

* Java 8 or newer
* Java 17 recommended

## Run

From the root of the main repository:

```bash
javac java-console/src/CallTargetCalculator.java
java -cp java-console/src CallTargetCalculator
```

Or from inside the `java-console` directory:

```bash
javac src/CallTargetCalculator.java
java -cp src CallTargetCalculator
```

## Project Structure

```text
java-console/
├── README.md
└── src/
    └── CallTargetCalculator.java
```

## What I Practiced

This implementation focuses on:

* Java fundamentals
* Console input and output
* Variables and arithmetic operations
* Conditional logic
* Input validation
* Translating a real-world requirement into program logic

## Other Implementations

This project is also implemented as:

* **C# WinForms** — [`../csharp-winforms`](../csharp-winforms)
* **Web Application** — [`../web`](../web)

All implementations are maintained together in the main **Call Target Calculator** repository.
