# Rubik-Cube-Solver
This should be a Rubik Cube which solves itself.
Made using Unity. Still under construction, doe. The main script is located to `Assets/Scripts.cs`. If you are good with C# and Unity language, you can help me with this project.
First, install Github Desktop and create a clone to this repository to your computer. Then open Unity and... code. Save everything, go to Github Desktop and "commit to master".

I made the moves first. Next, I need to make the user-interaction, meaning the user can move the cube.
For any issues, go to Issues tab and tell me.

One release! Go to https://github.com/ezluci/Rubik-Cube-Solver/releases. **The script is put in `Main Camera` object!** You can change `whichMove` to the next move you want to do. Check the declaration of the variable and the functions R(), D(), U_(), etc. (here you can change this variable). Also make sure to put MoveCube() in the FixedUpdate() function. Then, you can see the cube move.
You can read the colors after every move. It's updating using the MoveChildsAndRearrangeColors(string Move) function.
