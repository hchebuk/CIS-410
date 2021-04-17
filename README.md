# CIS-410
Repository containing assignments for CIS 410 - Game programming  
Members - Kenny Nguyen, Harrison Chebuk, Stephen
Contributions:
Harrison - The Player Character Parts 1 and 2, Setting up 3D Beginner, dot product for goal
Stephen - • The Camera, Ending the Game, Audio
Kenny - Enemies Parts 1 and 2, The Environment, Linear Interpolation

Linear Interpolation use (by Kenny): I have made two floating spheres on opposite sides of the environment. One sphere acts as a moving object which slowly moves to the other sphere which is the goal sphere. I added linear interpolation to the moving sphere so that wherever the goal sphere was, it would be able to move there in a certain amount of seconds. The moving sphere moves and meets the goal position in 44 seconds. The 44 seconds represents the fastest time it took for us to beat the game. So the gameplay element is to try and reach the end goal before the sphere does and if you don’t make it in time, don’t worry, you can still complete the game without starting over.

Dot product use (by Harrison): I used dot product to figure out if the player is facing towards the goal because it can be hard for a new player to tell where they got to go. I made it so that if the player is facing towards the goal Stephen’s particle effect will appear to tell the player they are going the right way.

Particle FX (by Stephen): Enhanced the appearance of the main character by creating orb particles in the appropriate color scheme. Was further enhanced by Harrison’s dot product to create a direction-sensitive indicator, mapped to the orientation of the end goal.
