# Call Target Calculator

![Java](https://img.shields.io/badge/Java-Console-orange)
![C#](https://img.shields.io/badge/C%23-WinForms-blue)
![JavaScript](https://img.shields.io/badge/JavaScript-Vanilla-yellow)
![Status](https://img.shields.io/badge/status-learning%20project-lightgrey)

A multi-platform implementation of a simple call target calculator, built to explore how the same business logic can be adapted across different languages, interfaces, and application environments.

The project started as a **Java console application**, was later rebuilt as a **C# WinForms desktop application**, and finally implemented as a **browser-based application using HTML, CSS, and Vanilla JavaScript**.

## Implementations

| Version      | Technology              | Interface   | Main Focus                                      |
| ------------ | ----------------------- | ----------- | ----------------------------------------------- |
| Java Console | Java                    | CLI         | Core logic and input handling                   |
| C# WinForms  | C# / .NET               | Desktop GUI | Event-driven programming and GUI development    |
| Web          | HTML / CSS / JavaScript | Browser     | DOM manipulation, validation and web deployment |

### Project Structure

```text
call-target-calculator/
├── java-console/
│   └── src/
│       └── CallTargetCalculator.java
│
├── csharp-winforms/
│   ├── CallTargetCalculatorGUI.slnx
│   ├── CallTargetCalculatorGUI/
│   └── images/
│
├── web/
│   ├── index.html
│   └── images/
│
├── README.md
└── LICENSE
```

## Evolution

```text
Java Console
     ↓
C# WinForms
     ↓
Web Application
```

Each implementation solves the same underlying problem while exploring a different development environment.

Rather than treating them as separate projects, this repository keeps the implementations together to show the progression of the same idea across multiple technologies.

## The Problem

During a working day, it can be difficult to determine whether the current call pace is enough to reach a fixed daily target.

The calculator takes three values:

* Logged-in hours
* Total break minutes
* Calls completed so far

It then calculates:

* Net worked hours
* Remaining net working time
* Remaining calls
* Required calls per hour

## Core Calculation

The implementations currently use the same fixed values:

```text
Daily call target: 200
Daily net working time: 8.5 hours
```

The core calculation is:

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

The implementations also handle basic edge cases such as reaching or exceeding the target, having no remaining working time, and invalid input.

## Java Console

Location: [`java-console/`](java-console/)

The original implementation of the project.

This version focuses on basic program flow, console input, validation, and implementing the calculation logic in Java.

### Run

From the repository root:

```bash
javac java-console/src/CallTargetCalculator.java
java -cp java-console/src CallTargetCalculator
```

## C# WinForms

Location: [`csharp-winforms/`](csharp-winforms/)

The desktop GUI implementation built with C# and Windows Forms.

This version adapts the original calculation logic to an event-driven graphical application and adds form-based input validation and structured output.

### Main Technologies

* C#
* .NET
* Windows Forms

## Web Version

Location: [`web/`](web/)

The browser-based implementation built with:

* HTML5
* CSS3
* Vanilla JavaScript

It runs entirely on the client side and does not require a backend.

The web version additionally explores:

* DOM manipulation
* Event listeners
* Client-side validation
* Numeric parsing
* Browser-based UI
* Static deployment with GitHub Pages

## What This Project Demonstrates

The main purpose of this repository is not the complexity of the calculator itself, but the process of implementing the same idea in different environments.

Through the three versions, the project explores:

* Translating business logic between programming languages
* Console-based application flow
* Event-driven desktop development
* Browser-based application development
* Input validation in different environments
* UI development
* Incremental project evolution
* Maintaining consistent behavior across implementations

## Possible Improvements

Future iterations could include:

* Configurable daily targets
* Configurable shift lengths
* Separation of calculation logic from the UI layer
* Automated tests
* Persistent settings
* Improved responsive web UI
* Additional implementations using other frameworks or platforms

## Repository History

The implementations originally existed as separate repositories.

They were later consolidated into this repository while preserving their Git history, making it easier to view the project as a single progression rather than three unrelated applications.

## License

This project is licensed under the Apache License 2.0.
