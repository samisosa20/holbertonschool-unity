0x01. Unity - Unity Concepts
============================

Specializations - AR/VR ― Unity

Resources
---------

**Read or watch**:

*   [Unity Manual: GameObjects](https://docs.unity3d.com/Manual/class-GameObject.html "Unity Manual: GameObjects")
*   [GameObjects and Components](https://www.youtube.com/watch?v=9Nf2_ds5y8c "GameObjects and Components")
*   [Creating GameObjects and Types of GameObjects](https://www.youtube.com/watch?v=U7l1J0mASi0 "Creating GameObjects and Types of GameObjects")
*   [Unity Manual: Components](https://docs.unity3d.com/Manual/UsingComponents.html "Unity Manual: Components")
*   [Components](https://www.youtube.com/watch?v=0Lq0DUwjG24 "Components")
*   [Unity Manual: Prefabs](https://docs.unity3d.com/Manual/Prefabs.html "Unity Manual: Prefabs")
*   [Creating and Using Prefabs](https://www.youtube.com/watch?v=0Jc287z4Qpg "Creating and Using Prefabs")
*   [Unity Manual: Tags](https://docs.unity3d.com/Manual/Tags.html "Unity Manual: Tags")
*   [Unity Manual: Layers](https://docs.unity3d.com/Manual/Layers.html "Unity Manual: Layers")
*   [The Beginner’s Guide to Game Mechanics](https://www.gamedesigning.org/learn/basic-game-mechanics/ "The Beginner's Guide to Game Mechanics")
*   [The 13 Basic Principles of Gameplay Design](https://www.gamasutra.com/view/feature/132341/the_13_basic_principles_of_.php "The 13 Basic Principles of Gameplay Design") (_Read all 4 pages_)
*   [Gameplay and Game Mechanics Design: A Key to Quality in Videogames](http://www.oecd.org/education/ceri/39414829.pdf "Gameplay and Game Mechanics Design: A Key to Quality in Videogames")
*   [Unity Manual](https://docs.unity3d.com/Manual/index.html "Unity Manual")

Learning Objectives
-------------------

At the end of this project, you are expected to be able to [explain to anyone](https://fs.blog/2012/04/feynman-technique/ "explain to anyone"), **without the help of Google**:

### General

*   What is a GameObject
*   What is a Component
*   What is a Prefab
*   What is a Tag
*   What is a Layer
*   How to create and change the properties of a GameObject
*   How to create a Prefab
*   How to add Tags and Layers
*   Why is it important to name GameObjects and assets clearly and organize your project hierarchy
*   What are gameplay and game mechanics and how do they relate to developing any kind of interactive experience

Requirements
------------

### General

*   A `README.md` file, at the root of the folder of the project
*   Use Unity’s default `.gitignore` in your `holbertonschool-unity` directory
*   Push the entire project folder `0x01-unity_concepts` to your repo, including `.meta` files
*   Scenes and project assets such as Materials must be named and organized as described in the tasks
*   No scripts are allowed for this project

* * *

Quiz questions
--------------

#### Question #0

What is a GameObject?

- [ ]   a 3D model
    
- [X]   a container for Components
    
- [ ]   built-in game assets that come with Unity
    

#### Question #1

A GameObject must not be empty.

- [ ]   True
    
- [X]   False
    

#### Question #2

What Component is required for all GameObjects?

- [X]   Transform
    
- [ ]   Box Collider
    
- [ ]   Size
    

#### Question #3

How can you add your own code as a Component of a GameObject?

- [ ]   right-click on the GameObject in the Hierarchy window and choose “Add Script”
    
- [X]   add a new Script Component to the GameObject in the Inspector window
    
- [X]   drag a script from the Project window to the GameObject’s Inspector window
    

#### Question #4

What is a Prefab?

- [ ]   a built-in game asset that comes with Unity
    
- [X]   a template created from an existing GameObject and its components and properties
    
- [ ]   a Component of a GameObject
    

#### Question #5

What are the benefits of using Prefabs?

- [X]   Prefabs can be used to make copies easily of a GameObject and make changes to all of them efficiently
    
- [X]   Prefabs can be used in multiple scenes
    
- [ ]   Prefabs don’t need Components to edit their properties
    

#### Question #6

How could you use Tags in a Unity project?

- [X]   to sort GameObjects in the Project window
    
- [ ]   to organize Components in a GameObject
    
- [X]   to identify and organize GameObjects for scripting purposes
    

#### Question #7

A GameObject can have multiple Tags assigned to it.

- [ ]   True
    
- [X]   False
    

#### Question #8

What is the purpose of Layers?

- [X]   to render only part of a scene
    
- [X]   to restrict raycasting to only specific parts of a scene
    
- [ ]   to keep track of scene drafts
    

#### Question #9

What is gameplay?

- [ ]   The game controller / keyboard controls used in interacting with a game
    
- [X]   How a player interacts with a game
    
- [ ]   A rule designed for a player’s interaction with the game
    

#### Question #10

What are game mechanics?

- [ ]   The inner workings of a game’s engine
    
- [ ]   How a player interacts with a game
    
- [X]   A set of rules designed for the player’s interaction with the game
    


#### Students who are done with "0. Floor plans"

## 0\. Floor plans mandatory

Create a new 3D Unity project called `0x01-unity_concepts`. Save your new scene as `0-floor`. Create a new Cube GameObject named `Floor` with the following Transform properties:

*   Position: `X: 0`, `Y: 0`, `Z: 0`
*   Rotation: `X: 0`, `Y: 0`, `Z: 0`
*   Scale: `X: 16`, `Y: 0.5`, `Z: 16`

**Repo:**

*   GitHub repository: `holbertonschool-unity`
*   Directory: `0x01-unity_concepts`
*   File: `0x01-unity_concepts/Assets/0-floor.unity`


#### Students who are done with "1. On the ball"

## 1\. On the ball mandatory

Duplicate `0-floor` by selecting the scene in the Project window and either `Edit > Duplicate` from the Toolbar or `CTRL / CMD + D`. Rename the scene `1-ball` and open it. Create a new Sphere GameObject named `Ball` with the following Transform properties:

*   Position: `X: 0`, `Y: 8`, `Z: 0`
*   Rotation: `X: 0`, `Y: 0`, `Z: 0`
*   Scale: `X: 1.5`, `Y: 1.5`, `Z: 1.5`

**Repo:**

*   GitHub repository: `holbertonschool-unity`
*   Directory: `0x01-unity_concepts`
*   File: `0x01-unity_concepts/Assets/1-ball.unity`


#### Students who are done with "2. Colors!"

#### 2\. Colors! mandatory

Duplicate `1-ball`, rename it `2-colors`, and open it. Create a `Materials` folder in the Project window, then create a new material named `floor`. In the Inspector window, change the Albedo color to any color you like using the color picker. Assign the material to the Floor GameObject.

Create a second new material named `ball`. Change the material color and assign the new material to the Ball GameObject.

**Repo:**

*   GitHub repository: `holbertonschool-unity`
*   Directory: `0x01-unity_concepts`
*   File: `0x01-unity_concepts/Assets/2-colors.unity, 0x01-unity_concepts/Assets/Materials/floor.mat, 0x01-unity_concepts/Assets/Materials/ball.mat`


#### Students who are done with "3. Gravity is a harsh mistress"

## 3\. Gravity is a harsh mistress mandatory

Duplicate `2-colors`, rename it `3-gravity`, and open it. Add a Rigidbody Component to the Ball GameObject. Press Play to see what happens. Wouldn’t it be better if the ball bounced when it fell?

Create a new folder in the Project window named `Physic Materials` and create a new Physic Material called `bounce`. Feel free to edit the material’s settings to get an idea of what the different settings affect. Add the `bounce` material to the Ball’s Sphere Collider. Press `Play`. For this task, your final `bounce` material settings should be:

*   `Bounciness: 0.8`
*   `Bounce Combine: Maximum`

**Repo:**

*   GitHub repository: `holbertonschool-unity`
*   Directory: `0x01-unity_concepts`
*   File: `0x01-unity_concepts/Assets/3-gravity.unity, 0x01-unity_concepts/Assets/Physic Materials/bounce`


#### Students who are done with "4. Prefabricated"

## 4\. Prefabricated mandatory

Duplicate `3-gravity`, rename it `4-prefab`, and open it. Create a new folder named `Prefabs`. Create a prefab from the Ball inside the new folder, then, using the prefab, add four more instance of the Ball to the scene. Position and scale them any way you like.

**Repo:**

*   GitHub repository: `holbertonschool-unity`
*   Directory: `0x01-unity_concepts`
*   File: `0x01-unity_concepts/Assets/4-prefab.unity, 0x01-unity_concepts/Assets/Prefabs/Ball`


#### Students who are done with "5. Even more colors!"

## 5\. Even more colors! mandatory

Duplicate `4-prefab`, rename it `5-more_colors`, and open it. Change the colors of each ball so they are different hex colors as defined below. New materials should be named as listed below. You cannot use scripts in this task.

*   `ball-red` : `FF0000FF`
*   `ball-blue` : `0000FFFF`
*   `ball-green` : `00FF00FF`
*   `ball-white` : `FFFFFFFF`
*   `ball-black` : `000000FF`

Take a look at the Hierarchy window. Having a bunch of GameObjects with the same name is hard to navigate, right? It’s important to clearly name your GameObjects and assets, especially when working with others in the same project. Rename each Ball GameObject in your scene with their color name.

*   `Red Ball`
*   `Blue Ball`
*   `Green Ball`
*   `White Ball`
*   `Black Ball`

**Repo:**

*   GitHub repository: `holbertonschool-unity`
*   Directory: `0x01-unity_concepts`
*   File: `0x01-unity_concepts/Assets/5-more_colors.unity, 0x01-unity_concepts/Assets/Materials/ball-*`

## Students who are done with "6. Tag yourself"

#### 6\. Tag yourself mandatory

Duplicate `5-more_colors`, rename it `6-tags`, and open it. Add a tag to all Ball objects called `Obstacles`.

**Repo:**

*   GitHub repository: `holbertonschool-unity`
*   Directory: `0x01-unity_concepts`
*   File: `0x01-unity_concepts/Assets/6-tags.unity`

#### Students who are done with "7. Textures"

## 7\. Textures #advanced

Duplicate `6-tags`, rename it `100-textures`, and open it. Create a new instance of Ball named `Textured Ball` and add a texture to it. Your texture asset should be in a folder named `Textures` and your new material should be called `ball-texture`.

Free Texture Sources:

*   [textures.com](https://www.textures.com/ "textures.com")
*   [texturex.com](https://www.texturex.com/ "texturex.com")
*   [Unity Asset Store](https://assetstore.unity.com/?orderBy=1 "Unity Asset Store")

**Repo:**

*   GitHub repository: `holbertonschool-unity`
*   Directory: `0x01-unity_concepts`
*   File: `0x01-unity_concepts/Assets/100-textures.unity, 0x01-unity_concepts/Assets/Materials/ball-texture, 0x01-unity_concepts/Assets/Textures/<texture_name>`