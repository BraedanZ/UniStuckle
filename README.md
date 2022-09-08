# UniStuckle

This game was created by Robert Braedan Zinn alone, no classmates or anyone else were involved in any part of development.  

After unzipping the submitted file, you may open it as a project with Unity.  

To play the game prototype, go to https://braedanz.itch.io/unistuckledemo using Google Chrome.  The game can be played in browser, but only chrome has been tested.  

The demo for this game is very simple, as will the final version of the game.  In this version, a functioning wheel now propels the player forward instead of force being applied from the side on a nondynamic object like in the prototype.  

Controls:
Use the mouse to press the "Play Demo" and "Play Again" buttons.  
Control Player lean with the left and right arrow keys.
Control forward and backward movement with the up and down arrow keys.
The further the player leans in the direction that they want to go, the faster they will move in that direction.  

Goal:
Get to the top of the hill to save the baby moose.
It is possible, the point of the game is to be difficult and frustrating though.  If you feel like you are just not quite getting to the top of a hill, then you lost too much momentum or just never built enough speed... If you still can't get it, maybe just try throwing the players body over the top of the ledge ;)

Note:
While testing the game in the Unity player, everything works as it should.  The only thing that does not in the browser version is that after beating the game, the play again button seems to have a small hitbox only near the P in Play instead of the whole phrase being the button.  I'm not sure what caused this during building but I don't have time to fix it.  I only note it so that you dont miss that the play again button is indeed a functioning button.  Just take a moment to find the spot that makes the text liten up in order to find the button.  

It is probably not plain to see, but the amout of time that I spent adjusting the physics in order to get the unicycle to feel alright was insane.  I found that a large wheel allows for more control over the player's lean as well as more friction for creating movement.  Apart from that, reworking how speed is calculated, adjusting gravity, friction, and bounciness on the player and wheel, adjusting force applied to the player, and entirely reworking how force is created (AddForce, wheel and hinge joints with motors, to finally a hinge joint with AddTorque) all meant a huge time sink.  The physics still aren't right, and honestly, it is all I care about in the game right now.  I want to eventually release this on Steam but there's a long way to go.  But once I nail the physics, then everything else will be easy in comparison.  Please accept that I know the level design isn't great.  It is simply to show off how the physics work in their current state.  In the future, the physics will allow for better level design as the player will roll down hills faster, losing more progress.  This is the core idea of the game afterall.  