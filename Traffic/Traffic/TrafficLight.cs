namespace Traffic
{
    class TrafficLight
    {
        public static int count = 1;

        private string color = "Red";
        
        public void NextState()
        {
            switch (count)
            {
                case 1:
                    color = "Orange";
                    count++;
                    break;
                case 2:
                    color = "Green";
                    count++;
                    break;
                case 3:
                    color = "Red";
                    count = 1;
                    break;
            }
        }

        public string getCurrentColor()
        {
            return color;
        }
    }
}
