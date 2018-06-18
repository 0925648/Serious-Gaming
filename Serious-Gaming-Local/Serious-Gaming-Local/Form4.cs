using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serious_Gaming_Local
{
  public partial class Form4 : Form
  {
    public Form4()
    {
      InitializeComponent();
      WindowState = FormWindowState.Maximized;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      var Form4 = new Form4();
      var Form3 = new Form3();
      this.Hide();
      Form3.Show();
    }
  }
}
