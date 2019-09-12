# Toyrobot

Toyrobot application that simulates the movement of a toy robot on a square tabletop, of dimensions 5 units x 5 units.

There are no obstructions on the table surface.

The robot is free to roam around the surface of the table, but must be prevented from falling to destruction. Any movement that would result in the robot falling from the table must be prevented, however further valid movement commands must still be allowed.

The movement of the robot is determined by an input string of commands. The first line of the string has the form PLACE X,Y,F and determines where the robot starts on the tabletop. X,Y are the coordinates of the starting position. F is the direction that the robot is facing.

Subsequent lines of the input string may contain one of the commands: MOVE, LEFT, RIGHT, or REPORT. There is no restriction on how many of these commands the input string may contain.

PLACE will put the toy robot on the table in position X,Y and facing NORTH, SOUTH, EAST or WEST.
The origin (0,0) can be considered to be the SOUTH WEST most corner.
MOVE will move the toy robot one unit forward in the direction it is currently facing.
LEFT and RIGHT will rotate the robot 90 degrees in the specified direction without changing the position of the robot.
REPORT will announce the X,Y and orientation of the robot.
The robot must not fall off the table during movement. This also includes the initial placement of the toy robot. Any move that would cause the robot to fall must be ignored.
Example Input and Output:
a)
PLACE 0,0,NORTH
MOVE
REPORT
Output: 0,1,NORTH
b)
PLACE 0,0,NORTH
LEFT
REPORT
Output: 0,0,WEST
c)
PLACE 1,2,EAST
MOVE
MOVE
LEFT
MOVE
REPORT
MOVE
MOVE
RIGHT
MOVE
REPORT
Output: 
3,3,NORTH
4,4,EAST
The application must run and you should provide sufficient evidence that your solution is complete by, as a minimum, indicating that it works correctly against the supplied test data.
The submission can be done in any language.
