namespace Kerstpuzzel.Route
{
    public class Leg
    {
         public Node Start { get; set; }
        public Node End { get; set; }
        public double Length { get; set; }

        public bool Contains(Node node)
        {
            return Start == node || End == node;
        }
    }
}
