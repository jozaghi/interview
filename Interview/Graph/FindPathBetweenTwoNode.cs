using Interview.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Graph
{
    public class FindPathBetweenTwoNode<T>
    {
        public FindPathBetweenTwoNode()
        {
        }

        public Result Find(GraphNode<T> firstNode, GraphNode<T> secondNode)
        {
            if (firstNode == null || secondNode == null) return Result.Fail("null arguments are not allowed");

            var queue = new Queue<GraphNode<T>>();
            var visited = new HashSet<T>();
            queue.Enqueue(firstNode);

            while (queue.TryDequeue(out GraphNode<T> currentNode))
            {
                if (visited.Contains(currentNode.Value)) continue;
                visited.Add(currentNode.Value);

                if (EqualityComparer<T>.Default.Equals(currentNode.Value , secondNode.Value)) return Result.Ok();
               
                foreach (var child in currentNode.Children)
                {
                    queue.Enqueue(child);
                }
            }
            return Result.Fail("no path found.");
        }
    }
}
