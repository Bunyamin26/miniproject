# Mini Project

Overview of the game
The game centers around the simple yet engaging task of pushing balls into designated holes located on the walls. Successfully placing all the balls into their respective holes triggers the door to open, allowing the player to progress to the next level.

You move the player with WASD, and push the balls by going into them.
Assets
Scripts
Doorcontroller & Doorcontroller2
Handles the opening of the doors after putting the ball into the holes. Could be written as one script, but i just choose to make it separate scripts… I know it isn't efficient. Furthermore have i in Doorcontroller2 made a 3D text active by using Unity's built-in method setActive, to display the user has won after completing the second “level”.

Playermovement
Handles the movement of the player with input from wasd keys & mouse movement. The movement script has been taken from the Github user “HadrienBoyer” and has been tweaked a little bit to my liking.
Link: https://github.com/HadrienBoyer/UNITY5-Simple-FPS-CharacterController/blob/master/PlayerController.cs

PushableObject
Makes the object which this script is attached to, to move the object when an object's collider with the tag “player” collides with the object that has this script attached to it with RigidBody. This script is for the balls that need to be pushed into the hole.

Triggerzone
This script handles the colliders inside the "hole" where the player must push the ball. When the ball is detected, it triggers the corresponding DoorController to execute a method that slides the door open, allowing the player to proceed to the next level.

Materials
I have used “Ciathyza, Gridbox Prototype Materials” to give nice grid by grid materials to the walls and the floor.

Link: https://assetstore.unity.com/packages/2d/textures-materials/gridbox-prototype-materials-129127
Textmesh Pro
I have used TextMesh Pro to display a text to the user that they have completed the game after opening the second door. The text says 

“Congrats you have finished this ass game. Now go ahead and play a real game”
Scenes
The game only consists of one scene.
Testing
The game was only tested on Windows.
