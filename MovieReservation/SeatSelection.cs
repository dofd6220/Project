using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieReservation
{
    public partial class SeatSelection : Form
    {
        public SeatSelection()
        {
            InitializeComponent();
            A1btn.Click += A1btn_Click;
        }
        private void A1btn_Click(object sender, EventArgs e)
        {

        }
    }
}
