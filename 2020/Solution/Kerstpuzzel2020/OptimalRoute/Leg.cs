namespace OptimalRoute
{
    public class Leg
    {
        public State start { get; set; }
        public State end { get; set; }
        public decimal length { get; set; }

        public bool Contains(State state)
        {
            return start == state || end == state;
        }
    }
}
