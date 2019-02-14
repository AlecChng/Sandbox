using System.Collections.Generic;

namespace SandBox
{
    public class Graph
    {
        List<Node> Nodes { get; set; }


        #region Cracking the Coding Interview: 4.1
        /// <summary>
        /// Cracking the Coding Interview: 4.1
        /// Returns true if a route exists between the source and destination nodes.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static bool DoesRouteExist(Node source, Node destination)
        {
            var routeExists = false;

            if (source != null && destination != null)
            {
                if (source.Id == destination.Id)
                {
                    routeExists = true;
                }
                else
                {
                    Queue<Node> bfsQueue = new Queue<Node>();
                    source.Visited = true;
                    bfsQueue.Enqueue(source);

                    while (bfsQueue.Count > 0 && !routeExists)
                    {
                        var currNode = bfsQueue.Dequeue();
                        if (currNode != null)
                        {

                            currNode.Visited = true;
                            foreach (var neighbor in currNode.Neighbors)
                            {
                                if (neighbor.Id == destination.Id)
                                {
                                    routeExists = true;
                                }
                                else if (!currNode.Visited)
                                {
                                    bfsQueue.Enqueue(neighbor);
                                }
                            }
                        }
                    }
                }
            }


            return routeExists;
        }
        #endregion  
    }
}
