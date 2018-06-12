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
  public partial class Form2 : Form
  {

    public Form2()
    {
      InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged_1(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      var Form1 = new Form1();
      var Form2 = new Form2();
      this.Hide();
      Form1.Show();

    }
  }
}
