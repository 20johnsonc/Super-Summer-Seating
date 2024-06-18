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

        public static List<KeyValuePair<int, int>> SortRows(int numRows, List<int> numList, out List<KeyValuePair<int, int>> middleRow, out List<KeyValuePair<int, int>> rightRow, out int midRows, out int leftRows, out int rightRows)
        {
            List<KeyValuePair<int, int>> leftRow = new List<KeyValuePair<int, int>>();
            middleRow = new List<KeyValuePair<int, int>>();
            rightRow = new List<KeyValuePair<int, int>>();

            List<KeyValuePair<int, int>> sideList = new List<KeyValuePair<int, int>>();
            List<KeyValuePair<int, int>> middleList = new List<KeyValuePair<int, int>>();

            int middleTotal = numRows * _numMiddleChairs;
            int sideTotal = numRows * _numSideChairs;

            int midCurrent = 0;
            int leftCurrent = 0;
            int rightCurrent = 0;

            midRows = 0;
            leftRows = 0;
            rightRows = 0;

            foreach (int group in numList)
            {
                int x = group;
                int y = group;

                while (x > 0)
                {
                    x -= _numSideChairs;
                }
                x += _numSideChairs;

                while (y > 0)
                {
                    y -= _numMiddleChairs;
                }
                y += _numMiddleChairs;

                int side = _numSideChairs - x;
                int middle = _numMiddleChairs - y;

                sideList.Add(new KeyValuePair<int, int>(group, side));
                middleList.Add(new KeyValuePair<int, int>(group, middle));
            }

            sideList.OrderBy(x => x.Key);
            middleList.OrderBy(x => x.Key);

            while (sideList.Count > 0)
            {
                KeyValuePair<int, int> s = sideList.Last();
                KeyValuePair<int, int> m = middleList.Last();

                if (m.Value <= s.Value)
                {
                    if (midCurrent + m.Key <= middleTotal)
                    {
                        middleRow.Add(m);
                        midRows += (m.Key + _numMiddleChairs - 1) / _numMiddleChairs;
                        midCurrent += m.Key + m.Value;
                        middleList.Remove(middleList.First(item => item.Key.Equals(m.Key)));
                        sideList.Remove(sideList.First(item => item.Key.Equals(m.Key)));
                    }

                    else if (leftCurrent + s.Key <= sideTotal)
                    {
                        leftRow.Add(s);
                        leftRows += (s.Key + _numSideChairs - 1) / _numSideChairs;
                        leftCurrent += s.Key + s.Value;
                        middleList.Remove(middleList.First(item => item.Key.Equals(s.Key)));
                        sideList.Remove(sideList.First(item => item.Key.Equals(s.Key)));
                    }

                    else if (rightCurrent + s.Key <= sideTotal)
                    {
                        rightRow.Add(s);
                        rightRows += (s.Key + _numSideChairs - 1) / _numSideChairs;
                        rightCurrent += s.Key + s.Value;
                        middleList.Remove(middleList.First(item => item.Key.Equals(s.Key)));
                        sideList.Remove(sideList.First(item => item.Key.Equals(s.Key)));
                    }

                    else
                    {
                        middleRow.Add(s);
                        midRows += (m.Key + _numMiddleChairs - 1) / _numMiddleChairs;
                        midCurrent += s.Key + s.Value;
                        middleList.Remove(middleList.First(item => item.Key.Equals(s.Key)));
                        sideList.Remove(sideList.First(item => item.Key.Equals(s.Key)));
                    }

                }
                else
                {
                    if (leftCurrent + s.Key <= sideTotal)
                    {
                        leftRow.Add(s);
                        leftRows += (s.Key + _numSideChairs - 1) / _numSideChairs;
                        leftCurrent += s.Key + s.Value;
                        middleList.Remove(middleList.First(item => item.Key.Equals(s.Key)));
                        sideList.Remove(sideList.First(item => item.Key.Equals(s.Key)));
                    }

                    else if (rightCurrent + s.Key <= sideTotal)
                    {
                        rightRow.Add(s);
                        rightRows += (s.Key + _numSideChairs - 1) / _numSideChairs;
                        rightCurrent += s.Key + s.Value;
                        middleList.Remove(middleList.First(item => item.Key.Equals(s.Key)));
                        sideList.Remove(sideList.First(item => item.Key.Equals(s.Key)));
                    }

                    else
                    {
                        middleRow.Add(s);
                        midRows += (m.Key + _numMiddleChairs - 1) / _numMiddleChairs;
                        midCurrent += s.Key + s.Value;
                        middleList.Remove(middleList.First(item => item.Key.Equals(s.Key)));
                        sideList.Remove(sideList.First(item => item.Key.Equals(s.Key)));
                    }
                }
                if (midCurrent > middleTotal)
                {
                    SortRows(numRows + 1, numList, out middleRow, out rightRow, out midRows, out leftRows, out rightRows);
                }
            }

            //Needs to be all rows
            return leftRow;
        }
    }
}
