
# Rush Hour Turtle
 ## Welcome to Rush Hour Turtle! This program was created using Visual Basic and deployed with an 
 ## SQLite database backend to record player scores  on a leaderboard. 
 
 ![Rush Hourt Turtle loading screen](https://imgur.com/PABflBd)
 
# ==============================================================================
# Rush Hour Turtle
## visual basic.net video game project 

File Names:        FinalProject.exe, FinalProject.vb, FinalProject.sln
Last updated:      3/12/2020

Authors:            Melanie Lamp, Christopher Schmitt, Andy Park, 
                    and Mitch Fisher
Course:             CS161 Winter 2020

Description:        The objective is to reach the end of the finish line
                    while avoiding the cars and alligators. You're also encouraged
                    to finish in the fastest time possible for a maximum score. 
                    There's two stages: 1st the background scrolls and the user must
                    avoid obstacles coming towards them, but their ability to 
                    move backwards is inhibited. In the second Stage, the BG is
                    stationary and the user must cross 3 lanes with obstacles
                    as fast as possible.The score is determined by taking the 
                    maximum score (arbitrary) then subtracting from that the time 
                    the user took to cross stage 1 and stage 2, and then adding
                    to that the total amount of lives left multiplied by our life
                    value. 
                    
# =============================================================================

 ![Turtle crossing dangerous roads and rivers](https://imgur.com/fEkrMPt)
 
# =============================================================================

Known Bugs:       * 1. Turtle progress can exceed the river before the final 
                    part is loaded. Currently turtle is moved back to start of
                    water. 
                   * 2. Turtle does Not change animation When reaching the
                    the water. 
                   * 3. When Collision with obstacles is detected, will sometimes
                    respawn the turtle in front of a car with no time to avoid
                   * 4. If you don't finish in a reasonable time score could
                    potential be negative and music could stop playing. Although
                    game is not designed to require the time it would take to
                    get a negative score.
# ==============================================================================

