using System.Collections.Generic;
using System.Text;

namespace Toyrobots
{
    public class ToyRobotResult
    {
        private List<Toyrobot> toyRobots = new List<Toyrobot>();
        Toyrobot activeRobot = new Toyrobot();

        public bool Add(string inputLine)
        {
            if (activeRobot == null)
            {
                activeRobot = new Toyrobot();
            }
            var result = InputParser.ProcessInput(inputLine.ToLower(), activeRobot);
            if (result != null)
                activeRobot = result;
            else
                toyRobots.Add(new Toyrobot { RoboDirection = activeRobot.RoboDirection, Xpos = activeRobot.Xpos, Ypos = activeRobot.Ypos });
            return true;
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            foreach (Toyrobot line in toyRobots)
            {
                if (output.Length > 0)
                    output.Append("\n");
                output.Append(line.ToString());
            }
            //Now add footer information
            output.Append("\n");
            return output.ToString();
        }
    }
}
