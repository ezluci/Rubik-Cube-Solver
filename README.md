# Rubik-Cube-Solver
This should be a Rubik Cube which solves itself, but I'm still working on it. I made it using Unity engine. If you are good with C# and Unity language, you can help me with this project.

I am currently working on: <ins>Solving the cube</ins>. The cube solves the __1. White cross__ step from https://ruwix.com/the-rubiks-cube/how-to-solve-the-rubiks-cube-beginners-method/.

Please let me know if you encounter any bugs in the game, because there are a lot of algorithms. You can go to https://github.com/ezluci/Rubik-Cube-Solver/issues and create a issue.

_**Do you want to try my game? I have <ins>two</ins> releases! Go to https://github.com/ezluci/Rubik-Cube-Solver/releases.**_

The main script is located to `Assets/MainScript.cs` and it is attached to `Main Camera` object! You can read the colors on the cube after every move. It's updating using the MoveChildsAndRearrangeColors(string Move) function.
