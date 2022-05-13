## 3D Voxel Mesh Generation
### Description
This project was created by Jackson Haskamp and Nathan Tucker. This is a voxel mesh generation game that focuses on outrunning and killing waves of monsters. This project uses meshing and chunking to create a 3d mesh of our voxel data at run time. 

### METHODS
We use chunkdata to store data about our chunk so we can use it to generate the meshdata with our meshData script. Meshdata has in addition to the necessary lists of triangles, vertices, and uv to map texture. Meshdata also adds the triangles to generate the quad faces for the mesh, because each quad is made up of two triangles. In our addQuadTriangles function in meshdata the order of the vertices added is important because it determines which side of the quad is rendered because it rendered in a clockwise direction and if it was switched it would render the quad backwards from the players view. Meshdata uses sub meshing to generate water. we distinct between the two because the ground has collider vertices and water doesnt. In our BlockHelper script we add functionality for generating textures for each block. In our BiomeGenerator script we process each block and atach a perlin noise value for the y value to give a smooth but alternating terrain. In our chunkRenderer script we add functionality to render our mesh and add our main mesh with our water submesh. In our world script we call our terrain and biome generator scripts (objects) to actually generate the world using the chunk data. The EnemyManager script is responsible for the spawning of prefabed slime clones, which does so through preset spawn points in the world. Enemy and Player damage are handled by collision detections, with Enemies damaging the Player by colliding with their mesh, while Players damage the Enemies through the use of a hitbox object that is quickly activated and deactivated on Left Click to pair with the swinging animation of the sword. When Enemies reach 0 health, their max health is added to the score variable and is shown on the GameOver screen along with the total time spent in the gameplay scene. The player then can return to the main menu to repeat the gameplay cycle. 

### KNOWN ISSUES
For whatever reason, killing a random amount of slime entities too quickly results in a MisssingReferenceException error "The object of type 'GameObject' has been destroyed but you are still trying to access it.", and it highlights the Instantiate() calls on lines 40 and 49 of EnemyManager.cs. We are still unsure of what is causing the destroyed game object to be accessed.

### YOUTUBE DEMO LINK
- https://youtu.be/aeb8tiqUcac
- Forgot to mention in the video that attacking is done with Left Click

### ROLES
Jackson Haskamp
-Voxel Generation
-Mob Spawning
-Mob AI

Nathan Tucker
-Menu UI
-Overall Design
-Combat Animations
-Player and Camera Control

### IMPORTED ASSETS
-Skybox: https://assetstore.unity.com/packages/2d/textures-materials/galaxy-fire-skybox-10976
-Font: https://assetstore.unity.com/packages/2d/fonts/free-pixel-font-thaleah-140059#description
-Weapon Model: https://assetstore.unity.com/packages/3d/props/weapons/melee-weapons-pack-swords-axes-121237#publisher
-Voxel Pack: https://www.kenney.nl/assets/voxel-pack 

### REFERENCES
In general, the Unity Manual was used at almost every step of this project for just about everything
- https://docs.unity3d.com/Manual/index.html
Making minecraft in a day
- https://www.youtube.com/watch?v=Nj8gt_92c-M
- https://github.com/samhogan/Minecraft-Unity3D 
- https://hiteshkrsahu.medium.com/generating-voxel-planet-using-3d-simplex-noise-3ab011fd88ec
FPS Camera Tutorial:
- https://sharpcoderblog.com/blog/unity-3d-fps-controller
 Mesh Tutorial that I followed along to:
- had lots of trouble getting the mesh working, so I used this reference to go through creating our mesh generation for this game.
- was a big help in the voxel mesh generation and getting the hang of unity. We referenced this a lot for our project in our WorldScripts folder, and helped get our project basics completed. We also used his modified sprite sheet for our textures because they were the easiest to implement comparing to the unity asset store, and it looked good.
- https://www.youtube.com/watch?v=leBl6q21-0I&list=PLcRSafycjWFdYej0h_9sMD6rEUCpa7hDH 
-Also used this: https://www.youtube.com/watch?v=b_1ZlHrJZc4 
How to generate a voxel mesh:
- https://www.youtube.com/watch?v=ns78VoalB2A 
Mob/Monster AI:
- https://docs.unity3d.com/ScriptReference/Transform.LookAt.html used for mob 'aggro'
References Used in project:

Help with creating mob ai
- https://www.youtube.com/watch?v=lhgEczq74FM&list=PLmP1LNMzp97p0xu2cSMv9hju6J27Ukxwo&index=9 
Mob collision
- https://www.youtube.com/watch?v=_3EFPHgtkwY 
- https://docs.unity3d.com/ScriptReference/Collision-gameObject.html
- https://answers.unity.com/questions/1758694/how-does-the-player-take-damage-if-collided-eith-e.html
- https://docs.unity3d.com/ScriptReference/Object.Destroy.html 
Help with spawning in enemies:
- https://www.youtube.com/watch?v=NWNH9XRtuIc 
- https://forum.unity.com/threads/enemies-spawn-system-near-the-player.379685/ 
Ran into issue with EventSystems that this helped out
- https://answers.unity.com/questions/1236062/the-name-eventsystems-does-not-exist-in-the-curren.html 
