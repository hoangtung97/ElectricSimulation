namespace ElectricSimutation
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_fullscreen = new System.Windows.Forms.Button();
            this.btn_restoredown = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pdfToolStripMain1 = new Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripMain();
            this.pdfToolStripZoomEx1 = new Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripZoomEx();
            this.pdfViewer1 = new Patagames.Pdf.Net.Controls.WinForms.PdfViewer();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pdfToolStripMain1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_fullscreen
            // 
            this.btn_fullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fullscreen.BackColor = System.Drawing.Color.Transparent;
            this.btn_fullscreen.FlatAppearance.BorderSize = 0;
            this.btn_fullscreen.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btn_fullscreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btn_fullscreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btn_fullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fullscreen.Image = global::ElectricSimutation.Properties.Resources.FULLSCREEN1;
            this.btn_fullscreen.Location = new System.Drawing.Point(725, 2);
            this.btn_fullscreen.Name = "btn_fullscreen";
            this.btn_fullscreen.Size = new System.Drawing.Size(33, 27);
            this.btn_fullscreen.TabIndex = 8;
            this.btn_fullscreen.UseVisualStyleBackColor = false;
            this.btn_fullscreen.Click += new System.EventHandler(this.btn_fullscreen_Click);
            // 
            // btn_restoredown
            // 
            this.btn_restoredown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restoredown.BackColor = System.Drawing.Color.Transparent;
            this.btn_restoredown.FlatAppearance.BorderSize = 0;
            this.btn_restoredown.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btn_restoredown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btn_restoredown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btn_restoredown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restoredown.Image = global::ElectricSimutation.Properties.Resources.RESTORE_DOWN11;
            this.btn_restoredown.Location = new System.Drawing.Point(725, 2);
            this.btn_restoredown.Name = "btn_restoredown";
            this.btn_restoredown.Size = new System.Drawing.Size(33, 27);
            this.btn_restoredown.TabIndex = 7;
            this.btn_restoredown.UseVisualStyleBackColor = false;
            this.btn_restoredown.Click += new System.EventHandler(this.btn_restoredown_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Image = global::ElectricSimutation.Properties.Resources.MINIMIZE11;
            this.btn_minimize.Location = new System.Drawing.Point(692, 2);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(33, 27);
            this.btn_minimize.TabIndex = 6;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = global::ElectricSimutation.Properties.Resources.EXIT11;
            this.btn_exit.Location = new System.Drawing.Point(764, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(33, 27);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fullscreen);
            this.panel1.Controls.Add(this.btn_restoredown);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_minimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 36);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pdfViewer1);
            this.panel2.Controls.Add(this.pdfToolStripZoomEx1);
            this.panel2.Controls.Add(this.pdfToolStripMain1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 521);
            this.panel2.TabIndex = 10;
            // 
            // pdfToolStripMain1
            // 
            this.pdfToolStripMain1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.pdfToolStripMain1.Location = new System.Drawing.Point(0, 0);
            this.pdfToolStripMain1.Name = "pdfToolStripMain1";
            this.pdfToolStripMain1.PdfViewer = this.pdfViewer1;
            this.pdfToolStripMain1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.pdfToolStripMain1.Size = new System.Drawing.Size(800, 58);
            this.pdfToolStripMain1.TabIndex = 0;
            this.pdfToolStripMain1.Text = "pdfToolStripMain1";
            // 
            // pdfToolStripZoomEx1
            // 
            this.pdfToolStripZoomEx1.Location = new System.Drawing.Point(0, 58);
            this.pdfToolStripZoomEx1.Name = "pdfToolStripZoomEx1";
            this.pdfToolStripZoomEx1.PdfViewer = this.pdfViewer1;
            this.pdfToolStripZoomEx1.Size = new System.Drawing.Size(800, 25);
            this.pdfToolStripZoomEx1.TabIndex = 1;
            this.pdfToolStripZoomEx1.Text = "pdfToolStripZoomEx1";
            this.pdfToolStripZoomEx1.ZoomLevel = new float[] {
        8.33F,
        12.5F,
        25F,
        33.33F,
        50F,
        66.67F,
        75F,
        100F,
        125F,
        150F,
        200F,
        300F,
        400F,
        600F,
        800F};
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pdfViewer1.CurrentIndex = -1;
            this.pdfViewer1.CurrentPageHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.Document = null;
            this.pdfViewer1.FormHighlightColor = System.Drawing.Color.Transparent;
            this.pdfViewer1.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY;
            this.pdfViewer1.LoadingIconText = "Loading...";
            this.pdfViewer1.Location = new System.Drawing.Point(0, 83);
            this.pdfViewer1.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.Default;
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.OptimizedLoadThreshold = 1000;
            this.pdfViewer1.Padding = new System.Windows.Forms.Padding(10);
            this.pdfViewer1.PageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pdfViewer1.PageAutoDispose = true;
            this.pdfViewer1.PageBackColor = System.Drawing.Color.White;
            this.pdfViewer1.PageBorderColor = System.Drawing.Color.Black;
            this.pdfViewer1.PageMargin = new System.Windows.Forms.Padding(10);
            this.pdfViewer1.PageSeparatorColor = System.Drawing.Color.Gray;
            this.pdfViewer1.RenderFlags = ((Patagames.Pdf.Enums.RenderFlags)((Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT | Patagames.Pdf.Enums.RenderFlags.FPDF_NO_CATCH)));
            this.pdfViewer1.ShowCurrentPageHighlight = true;
            this.pdfViewer1.ShowLoadingIcon = true;
            this.pdfViewer1.ShowPageSeparator = true;
            this.pdfViewer1.Size = new System.Drawing.Size(800, 438);
            this.pdfViewer1.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.FitToWidth;
            this.pdfViewer1.TabIndex = 2;
            this.pdfViewer1.TextSelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.pdfViewer1.TilesCount = 2;
            this.pdfViewer1.UseProgressiveRender = true;
            this.pdfViewer1.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical;
            this.pdfViewer1.Zoom = 1F;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 55);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pdfToolStripMain1.ResumeLayout(false);
            this.pdfToolStripMain1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_restoredown;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_fullscreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Patagames.Pdf.Net.Controls.WinForms.PdfViewer pdfViewer1;
        private Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripZoomEx pdfToolStripZoomEx1;
        private Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripMain pdfToolStripMain1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}