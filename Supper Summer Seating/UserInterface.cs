using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Supper_Summer_Seating
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for Open menu item.
        /// Reads the file of numbers into a list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(uxOpenDialog.FileName))
                    {
                        List<int> numList = new List<int>();

                        while (!reader.EndOfStream)
                        {
                            numList.Add(Convert.ToInt32(reader.ReadLine()));
                        }

                        //Sort in decreasing order.
                        numList.Sort();
                        numList.Reverse();
                        int total = numList.Sum();

                        int numRows = FillRows.NumRowsNeeded(total);
                        List<KeyValuePair<int, int>> left = FillRows.SortRows(numRows, numList, out List<KeyValuePair<int, int>> middle, out List<KeyValuePair<int, int>> right);

                        foreach (KeyValuePair<int, int> key in left)
                        {
                            uxLeftBox.Text += key.Key.ToString() + "\r\n";
                        }
                        foreach (KeyValuePair<int, int> key in middle)
                        {
                            uxMiddleBox.Text += key.Key.ToString() + "\r\n";
                        }
                        foreach (KeyValuePair<int, int> key in right)
                        {
                            uxRightBox.Text += key.Key.ToString() + "\r\n";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
