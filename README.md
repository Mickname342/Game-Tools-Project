# Lurking Monsters

![Title_Screen](https://github.com/Mickname342/Lurking_Monsters/blob/main/Images/Title%20Screen.png)

Lurking Monsters is a top down shooter with elements of horror. The game is set in the dark an the player has bot a lashlight and a gun to defend themselves. The goal of the game is to collect 3 keys and escape from the house while being chased by monsters.

Both the ode and the art were made by Mickname342. [Link to the itch.io page](https://mickname.itch.io/lurking-monsters)

The Player will move with WASD and will shoot with left click. For more information chack the [PlayerMovemnt script](https://github.com/Mickname342/Lurking_Monsters/blob/main/Lurking_Monsters_Final/Assets/PlayerMovement.cs) and the [Shooting script](https://github.com/Mickname342/Lurking_Monsters/blob/main/Lurking_Monsters_Final/Assets/Shooting.cs)

There are 3 different enemies in the game:

Green enemy: Will follow the player and has 3 HP

![Green_Enemy](https://github.com/Mickname342/Lurking_Monsters/blob/main/Images/Green%20Enemy.PNG)

Blue enemy: Will Follow the player faster than the green one and has 4 HP

![Blue_enemy](https://github.com/Mickname342/Lurking_Monsters/blob/main/Images/Blue%20Enemy.PNG)

Golden enemy: Will follow the player at a slower speed than the green enemy, but it will be a constant threat because it has INFINITE HP

![Golden_Enemy](https://github.com/Mickname342/Lurking_Monsters/blob/main/Images/Golden%20MonsterPNG.PNG)

To know where the player is they all use A* pathfinding. For more information check the [Enemy script](https://github.com/Mickname342/Lurking_Monsters/blob/main/Lurking_Monsters_Final/Assets/Bear.cs)

To make the Environment dark with different light sources we used the Unity URP

The player will have to collect 3 keys around the house and then leave through the main door

![Key](https://github.com/Mickname342/Lurking_Monsters/blob/main/Images/Key.PNG)

![Main_Entrance](https://github.com/Mickname342/Lurking_Monsters/blob/main/Images/End%20Game.PNG)


