using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser = System.Windows.Forms.WebBrowser;

namespace WebBrowser.UI
{
     public partial class GromBrowser : Form
     {
          public GromBrowser()
          {
               InitializeComponent();
          }

          private void Form1_Load(object sender, EventArgs e)
          {













               //try
               //{
               //     MethodOne();
               //}
               //// To narrow down type of exception, place a BREAK button on the catch statement
               //catch (Exception ex)
               //{
               //     MessageBox.Show(ex.StackTrace);
               //}
          }

          /**
           * Test methods follow for try catch tree.
           */
          //private void MethodOne()
          //{
          //     methodTwo();
          //}

          //private void methodTwo()
          //{
          //     methodThree();
          //}

          //private void methodThree()
          //{
          //     throw new NotImplementedException();
          //}

          /**
           * This function called to close the browser.
           */
          private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
          {
               MessageBox.Show(
                    "Welcome to the best browser ever built in this office. It is brought to you by Luis Cortez (lac0084). I hope you enjoy your stay.");
          }

          private void toolStripButton1_Click(object sender, EventArgs e)
          {

          }

          /**
           * Navigation function
           */
          private void NavigateToPage()
          {
               // Displays loading on status label.
               toolStripStatusLabel1.Text = "Page Loading";
               webBrowser1.Navigate(toolStripSpringTextBox1.Text);
          }

          /**
           * This function will allow us to hit enter from the address text box and go to web page entered.
           */
          private void toolStripSpringTextBox1_KeyPress(object sender, KeyPressEventArgs e)
          {
               if (e.KeyChar == (char)ConsoleKey.Enter)
               {
                    NavigateToPage();
               }
          }

          private void Go_Click(object sender, EventArgs e)
          {
               NavigateToPage();
          }

          private void windowTabs_KeyDown(object sender, KeyEventArgs e)
          {
               
          }

          private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
          {
               /**
                * This if statement will take care of a divide by zero error.
                */
               if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
               {
                    if (toolStripProgressBar1.ProgressBar != null)
                         toolStripProgressBar1.ProgressBar.Value = (int) (e.CurrentProgress * 100 / e.MaximumProgress);
               }
          }

          private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
          {
               // Displays complete on status label.
               toolStripStatusLabel1.Text = @"Complete";
          }

          private void printPageToolStripMenuItem_Click(object sender, EventArgs e)
          {
               webBrowser1.ShowPrintPreviewDialog();
          }

          public class BrowserTab : TabPage
          {
               System.Windows.Forms.WebBrowser wb = new System.Windows.Forms.WebBrowser();

               public BrowserTab()
               {
                    this.Controls.Add(wb);
               }
          }

          private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
          {
               windowTabs.Controls.Add(new BrowserTab());
          }
     }


}
