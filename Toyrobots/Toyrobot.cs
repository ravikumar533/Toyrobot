namespace Toyrobots
{
    public class Toyrobot
    {
        #region public members
        public string RoboDirection;
        public int Xpos;
        public int Ypos;
        #endregion

        public override string ToString()
        {
            return string.Format("Output : {0}, {1}, {2}", RoboDirection, Xpos, Ypos);
        }

    }
}
