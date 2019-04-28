namespace WebBrowser.UI
{
     partial class BookmarkManagerForm
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
               this.bookmarkItemListBox = new System.Windows.Forms.ListBox();
               this.SuspendLayout();
               // 
               // bookmarkItemListBox
               // 
               this.bookmarkItemListBox.Dock = System.Windows.Forms.DockStyle.Fill;
               this.bookmarkItemListBox.FormattingEnabled = true;
               this.bookmarkItemListBox.Location = new System.Drawing.Point(0, 0);
               this.bookmarkItemListBox.Name = "bookmarkItemListBox";
               this.bookmarkItemListBox.Size = new System.Drawing.Size(800, 450);
               this.bookmarkItemListBox.TabIndex = 0;
               this.bookmarkItemListBox.SelectedIndexChanged += new System.EventHandler(this.BookmarkItemListBox_SelectedIndexChanged);
               // 
               // BookmarkManagerForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.bookmarkItemListBox);
               this.Name = "BookmarkManagerForm";
               this.Text = "Bookmarks";
               this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.ListBox bookmarkItemListBox;
     }
}