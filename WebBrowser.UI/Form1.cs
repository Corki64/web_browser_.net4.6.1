using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void Form1_Load(object sender, EventArgs e)
          {
               try
               {
                    MethodOne();
               }
               // To narrow down type of exception, place a BREAK button on the catch statement
               catch (Exception ex)
               {
                    MessageBox.Show(ex.StackTrace);
               }
          }

          private void MethodOne()
          {
               methodTwo();
          }

          private void methodTwo()
          {
               methodThree();
          }

          private void methodThree()
          {
               throw new NotImplementedException();
          }

          private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
          {
               MessageBox.Show(
                    "Welcome to the best browser ever built in this office. It is brought to you by Luis Cortez lac0084. I hope you enjoy your stay.");
          }

          private void toolStripButton1_Click(object sender, EventArgs e)
          {

          }
     }
}
