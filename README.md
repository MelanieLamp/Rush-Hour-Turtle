# 🐢 Rush Hour Turtle

🏆 **1st Place Winner** – 2D Game Development Competition  

An award-winning, dynamic 2D side-scrolling obstacle game built with **VB.NET** in **Microsoft Visual Studio**. Players navigate a turtle through high-stakes obstacle courses—including chaotic highway traffic lanes and an alligator-infested river segment—to safely cross the checkered finish line.

<br>

<p align="center">
  ![Rush Hour Turtle loading screen](https://i.imgur.com/PABflBd.jpg)
</p>

## 🚀 Key Gameplay Features

* **Multi-Stage Mechanics:** Fast-paced real-time progression scaling from multi-lane highways to river crossings.
* **Persistent Leaderboards:** Integrates local SQLite3 relational services for reliable session score tracking.
* **Dynamic Scoring Engine:** Uses a multi-tiered formula factoring in raw stage clear times and remaining player lives via multi-tier multipliers.
* **Real-Time Sound System:** Built-in loop audio matrix managing active background soundtracks and event sound effects.

<br>

<p align="center">
  ![Turtle crossing dangerous roads and rivers](https://i.imgur.com/fEkrMPt.jpg)
</p>

## 🛠️ Tech Stack & Architecture

### Frontend & Client-Side
* **VB.NET Forms & UI Engine:** Native WinForms controls optimized for real-time 2D rendering and smooth visual alignment.
* **Sprite Management System:** Animated states directing object movement, car vectors, alligator paths, and world borders.

### Backend Core & Logic

| Component | Responsibility |
| :--- | :--- |
| **VB.NET Core** | Handles game physics loops, physical grid layout calculation, keyboard hook events, and lane speed updates. |
| **Score Calculation Engine** | Algorithmic processing module determining data mapping across score arrays. |
| **Collision Matrix** | Mathematical bounding-box override testing for continuous asset intersection detection (Turtle vs. Vehicles/Alligators). |

### Data & Development Layer
* **SQLite3 Data Layer:** Lightweight local relational storage tracking individual player high scores and historical values.
* **Microsoft Visual Studio:** Used as the primary compiler, designer toolkit, and build orchestrator.
* **Windows Media Player Services:** Core interface framework handling synchronous background theme playback.

## ⚙️ Getting Started

### Prerequisites
* **Windows OS** (7 / 10 / 11)
* **Microsoft Visual Studio** (with .NET Desktop Development workload enabled)
* **SQLite3 Runtime** components

### Setup and Compilation
1. **Clone the project files:**
   ```bash
   git clone https://github.com
   cd rush-hour-turtle
   ```
2. Open the solution file (`.sln`) inside **Microsoft Visual Studio**.
3. Rebuild the solution (`Ctrl + Shift + B`) to automatically restore any missing references or database hooks.
4. Hit **Start** (`F5`) to run the game simulation natively.

## 🐛 Known Issues & Debugging

The following stability behaviors are documented for developers interested in contributing optimization patches:

* **Boundary Sequence Break:** Player positioning vectors can exceed the river threshold before asset loads complete, forcing a hard safety reset back to the start of the water section.
* **Missing Animation State:** The turtle sprite fails to transition correctly to its swimming or water-based graphics state-machine upon river entry.
* **Spawn Trap Collision:** Reset matrix coordinates can occasionally respawn the turtle directly on top of active vehicle paths with 0 frames of avoidance time.
* **Underflow Score & Audio Loop:** Exceeding an extended runtime variable threshold will cause the score integer to underflow into negative numbers, causing a thread exception that stops the background music loop.

## 📜 License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
