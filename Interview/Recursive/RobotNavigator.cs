using Interview.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Recursive
{
    public class RobotNavigator
    {

        private HashSet<Point> _FailPoints = new HashSet<Point>();
        public List<Point> FindPath(int[,] matrix)
        {
            var path = new List<Point>();
            if(Find(matrix, 0, matrix.GetLength(1)-1, path))
            {
                return path;
            }
            return null;
        }

        private bool Find(int[,] matrix, int x, int y, List<Point> path)
        {
            var point = new Point { X = x, Y = y };
            if (x>matrix.GetLength(0)-1 || y< 0)
            {
                return false;
            }
            if (_FailPoints.Contains(point)) return false;

            if (matrix[x, y] == 1) return false;
            var isGoal = (x == matrix.GetLength(0)-1 && y == 0);
            if( isGoal ||
                Find(matrix, x+1, y, path) ||
                Find(matrix, x, y-1, path)
              )
            {
                path.Add(point);
                return true;
            }
            _FailPoints.Add(point);
            return false;
        }
    }
}
