namespace OptimalRoute
{
    public class Leg
    {
        public State Start { get; set; }
        public State End { get; set; }
        public decimal Length { get; set; }

        public bool Contains(State state)
        {
            return Start == state || End == state;
        }
    }
}
