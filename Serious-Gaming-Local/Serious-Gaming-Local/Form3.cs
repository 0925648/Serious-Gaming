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
  public partial class Form3 : Form
  {
    public Form3()
    {
      InitializeComponent();
      WindowState = FormWindowState.Maximized;
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      var Form2 = new Form2(); 
      this.Hide();
      Form2.Show();
    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {
      var Form4 = new Form4();
      this.Hide();
      Form4.Show();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
      var Form4 = new Form4();
      this.Hide();
      Form4.Show();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
      var Form4 = new Form4();
      this.Hide();
      Form4.Show();
    }

    private void label1_DoubleClick(object sender, EventArgs e)
    {

    }

    private void pictureBox1_DoubleClick(object sender, EventArgs e)
    {
      var Form4 = new Form4();
      this.Hide();
      Form4.Show();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      var Form4 = new Form4();
      this.Hide();
      Form4.Show();
    }
  }
}
