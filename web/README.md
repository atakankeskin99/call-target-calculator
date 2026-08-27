# Call Target Calculator — Web Version

![HTML5](https://img.shields.io/badge/HTML5-Structure-orange)
![CSS3](https://img.shields.io/badge/CSS3-Styling-blue)
![JavaScript](https://img.shields.io/badge/JavaScript-Vanilla-yellow)
![Status](https://img.shields.io/badge/status-learning%20project-lightgrey)
![Deployment](https://img.shields.io/badge/deployed-GitHub%20Pages-blue)

A browser-based implementation of the Call Target Calculator built with pure HTML, CSS, and Vanilla JavaScript.

This version runs entirely in the browser and is deployed using GitHub Pages.

---

## 🌐 Live Demo

👉 https://atakankeskin99.github.io/call-target-calculator-web/

---

## 🧠 Multi-Platform Implementation

This project is part of a multi-version learning progression.

Same core logic, different environments:

- 🖥 Java Console Version  
  https://github.com/atakankeskin99/call-target-calculator  

- 🪟 C# WinForms GUI Version  
  https://github.com/atakankeskin99/CallTargetCalculatorGUI  

- 🌐 Web Version (this project)

The business logic remains consistent across all versions.  
Only the presentation layer changes.

---

## 🚀 Features

**Input:**

- Logged-in hours
- Break minutes
- Calls taken so far

**Calculates:**

- Net worked hours
- Remaining net hours
- Remaining calls
- Required calls per hour

- Smart number parsing (supports `4.5` and `4,5`)
- Input validation with clear error handling
- Target exceeded mode (bonus mode 🚀)
- Fully client-side (no backend required)

---

## 🧮 Core Logic

**Constants:**

- Daily target: `200 calls`
- Daily net working time: `8.5 hours`

**Calculation rules:**

Net worked hours = Login hours − (Break minutes / 60)  
Remaining net hours = Daily net hours − Net worked hours  
Remaining calls = Daily target − Calls taken  
Required pace = Remaining calls / Remaining net hours  

**Edge cases handled:**

- Target exceeded
- Remaining time = 0
- Invalid input

---

<h2>🖼️ Application Screenshot</h2>

<p align="center">
  <img src="images/screenshot.png" alt="Call Target Calculator Web Version Screenshot" width="900" />
  <br/>
  <em>Call Target Calculator — Web Version (HTML / JavaScript)</em>
</p>


---

## 🛠 Tech Stack

- HTML5
- CSS3
- Vanilla JavaScript
- GitHub Pages (deployment)

No frameworks.  
No external libraries.  
No build tools.

---

## 🎯 Purpose

This project demonstrates:

- Translating business logic across languages (Java → C# → JavaScript)
- DOM manipulation and event-driven programming
- Client-side validation
- Static site deployment
- Iterative learning mindset

This is intentionally a learning-focused project, not a production-grade system.

---

## 📚 What I Practiced

- Event listeners (`addEventListener`)
- Input validation patterns
- Numeric parsing edge cases
- UI structuring with CSS Grid
- Deploying static sites via GitHub Pages
- Maintaining consistent logic across platforms

---

## 🔮 Possible Improvements

- Make daily targets configurable
- Add localStorage persistence
- Add dark mode
- Extract calculation logic into a separate JS module
- Add automated testing (Jest)
- Convert to React / Next.js version

---

## ✅ Why This Project Matters

Although simple, this project represents:

- Multi-platform implementation
- Clean logic separation
- Deployment knowledge
- Progressive learning approach

It demonstrates growth from console applications to desktop GUI and finally to browser-based applications.
