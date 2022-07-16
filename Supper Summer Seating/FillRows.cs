using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supper_Summer_Seating
{
    public static class FillRows
    {
        /// <summary>
        /// Number of chairs per row on the sides.
        /// </summary>
        private const int _numSideChairs = 6;

        /// <summary>
        /// Number of chairs per row in the middle.
        /// </summary>
        private const int _numMiddleChairs = 14;

        /// <summary>
        /// Gets the minimum number of rows needed.
        /// </summary>
        /// <param name="total">Total seats needed.</param>
        /// <returns>Number of needed rows.</returns>
        public static int NumRowsNeeded(int total)
        {
            int numRows = total / ((_numSideChairs * 2) + _numMiddleChairs);
            return numRows + 1;
        }

        public static List<int> SortRows(int numRows, List<int> numList)
        {
            List<int> leftRow = new List<int>();
            List<int> middleRow = new List<int>();
            List<int> rightRow = new List<int>();

            int middleTotal = numRows * _numMiddleChairs;
            int sideTotal = numRows * _numSideChairs;

            foreach (int group in numList)
            {
                int side = group % _numSideChairs;
                int middle = group % _numMiddleChairs;

                if (middle <= side)
                {
                    if (middleRow.Sum() < middleTotal + group)
                    {
                        middleRow.Add(group);
                    }
                }
                else
                {
                    if (leftRow.Sum() < sideTotal + group)
                    {
                        leftRow.Add(group);
                    }
                    else
                    {
                        rightRow.Add(group);
                    }
                }
                if (rightRow.Sum() > sideTotal)
                {

                }
            }
        }
    }
}
