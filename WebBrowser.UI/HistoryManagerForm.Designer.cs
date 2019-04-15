namespace WebBrowser.UI
{
     partial class HistoryManagerForm
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.historyListBox = new System.Windows.Forms.ListBox();
               this.SuspendLayout();
               // 
               // historyListBox
               // 
               this.historyListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.historyListBox.FormattingEnabled = true;
               this.historyListBox.Location = new System.Drawing.Point(0, 0);
               this.historyListBox.Name = "historyListBox";
               this.historyListBox.Size = new System.Drawing.Size(120, 95);
               this.historyListBox.TabIndex = 0;
               // 
               // HistoryManagerForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.historyListBox);
               this.Name = "HistoryManagerForm";
               this.Text = "History Manager";
               this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.ListBox historyListBox;
     }
}