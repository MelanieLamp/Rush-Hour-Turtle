# ===============================

# Rush Hour Turtle

Welcome to Rush Hour Turtle! This web application is a personal project 
created by a dedicated team of undergraduate students. It was developed using 
Microsoft Visual Studio, Visual Basic.NET and was deployed with an SQLite3 
database back-end to track player scores.
# ===============================

 [Rush Hourt Turtle loading screen](https://i.imgur.com/PABflBd.jpg)

# ===============================

## visual basic.net video game project 

Authors: Melanie Lamp, Christopher Schmitt, Andy Park and Mitch Fisher

The objective of the game is to reach the end of the finish line while avoiding obstacles such as cars and alligators. 
You're encouraged to finish in the fastest time possible for a greater numerical score. There's two stages of the game: 
First the background will force scroll to the right and the turtle must avoid obstacles coming towards it. The turtles' ability to move 
backwards is inhibited. 

In the second Stage, the background is kept stationary and the turtle must cross three lanes of traffic as 
fast as possible. The ending score is determined by taking the highest score and then subtracting that from the time
the turtle took to cross stage one and stage two. Then by adding to that the total amount of lives left multiplied by our life value,
the final score is calculated. The score is then recorded to database that refers to the same score per game. When the game is closed
the database refreshes and new highscores can be recorded.
                    
# =================================

[Turtle crossing dangerous roads and rivers](https://i.imgur.com/fEkrMPt.jpg)
 
# ==================================

### Known Issues:
Turtle progress can exceed the river before the final 
part is loaded. Currently turtle is moved back to start of the water. 

Turtle does Not change animation When reaching the the water. 

When Collision with obstacles is detected, will sometimes respawn 
the turtle in front of a car with no time to avoid

If you don't finish in a reasonable time score could
potential be negative and music could stop playing. Although
game is not designed to require the time it would take to
get a negative score.

# ===================================

