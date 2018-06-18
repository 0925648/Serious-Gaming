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

  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      WindowState = FormWindowState.Maximized;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      var Form1 = new Form1();
      var Form2 = new Form2();
      this.Hide();
      Form2.Show();
    }

    private void button1_MouseEnter(object sender, EventArgs e)
    {
      button1.BackColor = Color.Blue;
    }

    private void button1_MouseLeave(object sender, EventArgs e)
    {
      button1.BackColor = Color.White;
    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void button2_MouseEnter(object sender, EventArgs e)
    {
      button2.BackColor = Color.Blue;
    }

    private void button2_MouseLeave(object sender, EventArgs e)
    {
      button2.BackColor = Color.White;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void button3_MouseEnter(object sender, EventArgs e)
    {
      button3.BackColor = Color.Blue;
    }

    private void button3_MouseLeave(object sender, EventArgs e)
    {
      button3.BackColor = Color.White;
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
  }
}
