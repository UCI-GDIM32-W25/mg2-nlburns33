[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
For the MG2 plan, I planned four GameObjects - the player, the coins, the points UI text, and the ground. I ended up having to make another GameObject for the coins to spawn at. Like in my plan, the player script controls the movement of the player via the Update method and spawning of the coins via a timer and Instantiate. It uses a OnCollisionEnter method to detect when the player touches the ground and changes the isGrounded boolean accordingly. That script also uses OnTriggerEnter to detect collisions with and destroy the coins, but I deviated from my plan by making the updating of the points text in the Player script as well instead of calling a method in another script attached to the UI. The coin script uses Update to make the coins move like I had planned but I also had to make an if statement that destroys them when they travel too far left.  


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites