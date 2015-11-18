using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarksList504
{
    public partial class frmMarksInList : Form
    {
        List<int> markList = new List<int>();

        public int AverageFunction(List<int> listOfMarks)
        {
            int listSum = listOfMarks.Sum();
            int numberInList = listOfMarks.Count;
            int theAverage = listSum / numberInList;

            return theAverage;
        }
        public frmMarksInList()
        {
            InitializeComponent();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            int mark = Convert.ToInt32(this.nudInput.Value);

            markList.Add(mark);

            this.lstMarks.Items.Clear();
            foreach(int element in markList)
            {
                this.lstMarks.Items.Add(element);
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            int average = AverageFunction(markList);
            string averageAsString = Convert.ToString(average);
            MessageBox.Show(averageAsString);

            
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            this.lstMarks.Items.Clear();
            markList.Clear();
        }
    }
}
