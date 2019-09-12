using System;

namespace Toyrobots
{
    public static class InputParser
    {
        static string[] commands = { "MOVE", "LEFT", "RIGHT", "REPORT" };
        
        public static Toyrobot ProcessInput(string sentence, Toyrobot toyrobot) {

            // Checking the Input is command or line
            if (sentence.Contains("place"))
            {
                string[] words = sentence.Replace("place", string.Empty).Split(",");

                // get Xpos (first word)
                try
                {
                    toyrobot.Xpos = int.Parse(words[0].Trim());
                }
                catch (FormatException)
                {
                    return null;
                }
                catch (OverflowException)
                {
                    return null;
                }
                // get Ypos (first word)
                try
                {
                    toyrobot.Ypos = int.Parse(words[1].Trim());
                }
                catch (FormatException)
                {
                    return null;
                }
                catch (OverflowException)
                {
                    return null;
                }
                toyrobot.RoboDirection = words[2].Trim();
            }
            else if (Array.IndexOf(commands, sentence.ToUpper()) >= 0)
            {
                switch (sentence)
                {
                    case "move":
                        UpdateRoboPosition(toyrobot);
                        break;
                    case "left":
                    case "right":
                        GetRoboDirection(toyrobot, sentence);
                        break;
                    case "report":
                        return null;
                }
            }
            else {
                return null;
            }

            return toyrobot;
        }

       static void GetRoboDirection(Toyrobot activeRobo,string command) {
            string roboDirection = activeRobo.RoboDirection;
            switch (roboDirection.ToLower())
            {
                case "south":
                    roboDirection = command.ToLower() == "left" ? "EAST" : "WEST";
                    break;
                case "north":
                    roboDirection = command.ToLower() == "left" ? "WEST" : "EAST";
                    break;
                case "east":
                    roboDirection = command.ToLower() == "left" ? "NORTH" : "SOUTH";
                    break;
                case "west":
                    roboDirection = command.ToLower() == "left" ? "SOUTH" : "NORTH";
                    break;
            }
            activeRobo.RoboDirection = roboDirection;
        }
       static void UpdateRoboPosition(Toyrobot activeRobo) {
            switch (activeRobo.RoboDirection.ToLower())
            {
                case "south":
                    if (activeRobo.Ypos > 0)
                        activeRobo.Ypos -= 1;
                    break;
                case "north":
                    if (activeRobo.Ypos < 4)
                        activeRobo.Ypos += 1;
                    break;
                case "east":
                    if (activeRobo.Xpos < 4)
                        activeRobo.Xpos += 1;
                    break;
                case "west":
                    if (activeRobo.Xpos > 0)
                        activeRobo.Xpos -= 1;
                    break;
            }
        }
    }
}
