using Interview.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.BinaryTree
{
    public class CreateListFromBinaryTree
    {
        public Result<List<List<int>>> Create(TreeNode root)
        {
            var visitedList = new Dictionary<int, List<int>>();
            var queue = new Queue<(int level, TreeNode node)>();
            queue.Enqueue((0, root));

            while (queue.TryDequeue(out (int level, TreeNode node) current))
            {
                if (current.node == null) continue;

                if (!visitedList.ContainsKey(current.level))
                {
                    visitedList.Add(current.level, new List<int>());
                }
                visitedList[current.level].Add(current.node.Value);

                queue.Enqueue((current.level+1, current.node.LeftChild));
                queue.Enqueue((current.level+1, current.node.RigthChild));
            }

            var result = visitedList.Values.ToList();
            return Result<List<List<int>>>.Ok(result);
        }
    }
}
