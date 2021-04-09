namespace ConsoleApp11
{
    interface IMovable
    {
        public const int minSpeed = 0;
        private static int maxSpeed = 60;

        static double GetTime(double distance, double speed) => distance / speed;
        static int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value > 0) maxSpeed = value;
            }
        }

    }
}
