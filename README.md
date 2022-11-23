# capstone
Capstone project repo


### Abstract
The intention of this project was to gain a better understanding of the processes and procedures behind game development. The Metroidvania genre was chosen as it allows for creative implementation of a variety of components often found within the industry. Development was primarily done using the Unity game engine. Fox Run is not currently available publicly, but the hope is to host it on Steam in the near future. The team gained experience in creating an extensive Player Controller, interactable objects, user interfaces, level design and enemy pathfinding. Areas of the game itself are designed to highlight some of the previously listed components – such as a scene that demonstrates the implementation of the A* pathfinding algorithm with a certain enemy type. However, the game itself is fully playable with an explorable map and refined look and feel that demonstrates the gleaned experience in game design. It would serve as a strong basis for the continued development of a fully-fledged game.
Keywords
Game Development, Pathfinding, Metroidvania, Game Design



### I Problem Statement and Motivation

	There are many video games on the market, both in and out of the Metroidvania genre. The intention of Fox Run is to offer an exciting and unique experience to players. The distinctive level design, exciting combat, and variety of unlockable skills will make the journey worth taking for all players. The aim of the project was to create a functional 2D game containing all essential components within the Unity engine that could be expanded upon if development continued past the capstone deadline. This project is of interest on a development front as it provides good exposure to game design and AI development. As a commercial product, the game is of interest as it fits into one of the main genres of indie games in the current market and aims to offer a satisfying experience to all players. The hope is to eventually host Fox Run on Steam to give it as wide an audience as possible.  
The repository can be accessed here: https://github.com/plazman97/capstone/commits/main 

### II Original and Final Design

	The original design plan was for Fox Run to follow in the footsteps of classic entries within the genre such as Hollow Knight. Ultimately, there wasn’t any expectation that a fully finished marketable product would be completed by the end of the semester. The intention was to create a strong foundation for continued development. We determined that several core components would be an ideal base for Fox Run: a functional player controller, at least one pathfinding enemy, UI, player upgrades and an explorable map. We have managed to deliver on all of these minimum specs for the project, though not necessarily in the exact manner originally imagined. For example, the original idea was that upgrade items would give the player abilities not originally built into the player controller. Instead, it was changed that the player controller had all functionalities built into itself from the get-go. Unlockable abilities were simply disabled until related upgrade scripts were ran by picking up the upgrade objects. Changes in planned implementation like this one were necessary to help speed along the development process and ensure that all goals were met by the capstone deadline. The explicit goal of the project’s design as a whole was to have a refined section of the game completed that would allow for easy continued development.
	
	All development for Fox Run was done using C# within the Unity game engine. Version control was handled through GitHub. The core features implemented during the development process were the player controller, enemy AI, menu system, player upgrade items and level control system. 
	
	The character controller is actually comprised of several main scripts. The CharacterController2D script contains many private variables related to how the player itself functions, for example what the player considers to be ground, crouch speed and jump velocity, and even the direction the player is currently facing. Also contained are functions for moving the player, which take input from the Player Movement script. The Move() function takes in arguments like player jumps, left and right movement and crouching and controls the player sprite accordingly. This function runs on a fixed update that checks for player movement input 50 times per second in order to move the way the player wants. This is different from the update function used elsewhere which runs once per frame – this is for more general use and would lead to player actions feeling choppy. There is a separate script controlling player combat that tracks attack radius and damage and applies it to objects on the enemy layer when appropriate. The Player Movement script is also vitally important to the upgrade system. Every player upgrade is actually built into the Movement script from the get-go. The actual items that grant those upgrade actually just enable them within the script. For example, the crouch upgrade script really just sets the canCrouch variable from false to true.
	
	The menu systems of the game were created by creating a series of buttons and formatting them appropriately. Then, a layer was created for each of the menu options such as the main menu, the pause menu, options, etcetera. Then, different scripts were made to give each button proper functionality. The volume slider’s script manipulates a game object called the audio mixer when the user adjusts it. The mixer raises or lowers the overall game volume accordingly when the user moves the slider within the main or pause menus. For the level control system – the basic components are the Player Manager and Camera Controller scripts. These scripts not only ensure that the camera stays focused on the player, but actively move the player and camera between scenes without deleting and re-instancing them each time the player goes to a new area. This smooths the process and makes sure that the player maintains all of their acquired upgrades between scenes. Also essential are the Entrance Scene and Exit Scene scripts, which keeps track of which gate the player has gone through in order to put them in an appropriate position in the correct scene. 
	
	Another interesting topic of discussion is the implementation of the enemies within Fox Run. Each enemy type is comprised of a unique AI script depending on enemy type and a general Enemy script which controls the health and damage of the individual foe. These attributes can be controlled on an individual object basis, allowing for different enemies of the same type to have varying health and damage. The opossum enemy within the game will walk to the edge of available map space before turning back around. However, the most exciting enemy of Fox Run is the eagle enemy type. This enemy contains an implementation of the A* pathfinding algorithm. By increasing the node count of the algorithm within our scenes the birds will chase the player efficiently without pushing through the player. These enemies are sure to present an exciting challenge to all players.
	
	Likely the biggest advantage to restarting the project with the knowledge we have now is how much experience we have gained with the Unity game engine. This alone would drastically speed up the process of re-developing Fox Run. Being able to skip time spent on implementation decisions that didn’t pan out, like the aforementioned upgrade system, would also make the overall process much smoother. 
	
### III Functional Constraints and Standards

For this project no functional constraints or standards needed to be addressed. If development continues, publishing to Steam will remain the end goal. At that point we would need to investigate Steam’s standards for games they host.

### IV Testing and Demonstration of Final Product

	Fox Run is not yet finished, and the intention of the project as it stands is to provide a strong basis for continued development. If the game is easy to develop going forwards using the capstone version as a basis – the work will be a true success. However, the ultimate intention of a game is for it to be fun to play. We were able to have several peers test the gameplay of Fox Run with positive results. Players did note that the game was short in its current iteration, but felt the experience was both visually refined and fun. This is honestly the best and most satisfying result possible. It is wonderful to know that the basis for the game is enjoyable as we move into contining development.

### V Analysis

	The test groups for Fox Run revealed that the game was on the right track. The core experience is enjoyable and participants were all eager to see a longer, finished experience. This was of course the desired result of the project. We can address the primary feedback by simply expanding on the experience we have created. Fox Run’s future is looking bright based on these results. The future of the project lies in creating a longer game. Much of the heavy lifting is actually already done. A finished product could likely be made by expanding to include more scenes, spreading out the upgrade items, and duplicating existing enemies throughout the open world. However, it would be ideal to continue the development of entirely new upgrades and enemies to further populate the world. The creation of exciting new enemies and upgrades awaits.
	
### VI Final Budget

	At present, Fox Run’s development has been entirely free. Our game utilizes free assets from the Unity Store and free a soundtrack found online. However, if development continues as planned, a $100 fee would need to be paid to register as a partner on Steamworks and actually publish the finished product.

### VII Conclusion

	Creating Fox Run has taught us many valuable lessons about game development. We’ve learned not just the ins-and-outs of game design, but how to collaborate effectively as a team and meet weekly deadlines as well. The ultimate result of our efforts is a strong foundation for a game that can be further developed into a more complete experience. 

### VIII References
•	https://arongranberg.com/astar/  
•	Dance of an Anecdote and a Fox (audio) 
