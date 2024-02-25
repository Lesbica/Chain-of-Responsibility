namespace Chain_of_Responsibility
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStartAssembly = new Button();
            SuspendLayout();
            // 
            // btnStartAssembly
            // 
            btnStartAssembly.Location = new Point(12, 12);
            btnStartAssembly.Name = "btnStartAssembly";
            btnStartAssembly.Size = new Size(115, 37);
            btnStartAssembly.TabIndex = 0;
            btnStartAssembly.Text = "Start Assembly";
            btnStartAssembly.UseVisualStyleBackColor = true;
            btnStartAssembly.Click += btnStartAssembly_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStartAssembly);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStartAssembly;
    }
}
