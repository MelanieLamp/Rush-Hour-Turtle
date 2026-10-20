# Rush Hour Turtle

<br>

  ![Rush Hour Turtle loading screen](https://i.imgur.com/PABflBd.jpg)

<br>

Rush Hour Turtle is an award-winning, dynamic 2D side-scrolling game built in Microsoft Visual Studio using VB.NET. The gameplay challenges players to navigate a turtle through complex real-time obstacle courses featuring traffic lanes and a river segment before reaching a checkered finish line. It incorporates an algorithmic score tracking module that calculates performance based on clear times and remaining player lives, dynamically syncing results to a local SQLite3 database layer.


## <-- Key Gameplay Features -->
<br>

Awarded first place in a 2D game development competition for its multi-stage design and responsive real-time mechanics. Integrates local SQLite3 database services to handle session-based score recording and leaderboard persistence. Features a multi-tiered final score algorithm that dynamically factors in stage clear times and remaining player lives before saving data.

<br>

  ![Turtle crossing dangerous roads and rivers](https://i.imgur.com/fEkrMPt.jpg)

<br>

## Frontend & Client-Side:

*   **VB.NET Forms & Graphics**: -- Core UI layout and real-time 2D side-scrolling rendering engine within Visual Studio.
  
*   **Sprite Animations**: -- Visual assets managing character movements, obstacle behaviors, and environment transitions.
<br>

## Backend Core & Frameworks:

*   **VB.NET**: -- Core programming language driving game physics, input handling, and lane logic.
  
*   **Microsoft Visual Studio**: -- Primary Integrated Development Environment (IDE) used for compilation and form design.
<br>

## Security & Data Layer:

*   **SQLite3**: -- Lightweight relational database service integrated to manage and temporarily persist player scoreboards.
  
*   **Score Calculation Engine**: -- Algorithmic scoring module that processes clear times against high scores and life multipliers.
<br>

## Dev Tools, Testing & Logging:

*   **Collision Detection Matrix**: -- Algorithmic testing layer validating real-time bounding box overlaps between the turtle, cars, and alligators.
  
*   **Media Player Services**: -- Internal sound engine handling background music tracks and real-time audio playback loop.
<br>

## Known Issues & Technical Bugs:

• Boundary Sequence Break: Player progress can exceed the river boundary before the final asset chunk is completely loaded; the turtle is temporarily forced back to the start of the water as a safety reset.

• Missing Animation State: The turtle sprite does not correctly trigger its swimming or water-based animation state machine upon reaching the river section.

• Spawn Trap Collision: Obstacle collision resets can occasionally respawn the turtle directly in front of active vehicle vectors, leaving zero frames for player avoidance.

• Underflow Score & Audio Loop: Exceeding an extended time threshold can cause the score integer to drop into negative values and trigger an exception that stops the background music engine.

<br>
