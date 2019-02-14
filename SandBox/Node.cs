using System.Collections.Generic;

namespace SandBox
{
    public class Node
    {
        public int Id { get; set; }
        public List<Node> Neighbors { get; set; }
        public bool Visited { get; set; }
    }
}
