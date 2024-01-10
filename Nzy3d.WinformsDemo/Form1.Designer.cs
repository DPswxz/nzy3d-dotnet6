namespace Nzy3d.WinformsDemo
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
            myRenderer3D = new Winforms.Renderer3D();
            SuspendLayout();
            // 
            // myRenderer3D
            // 
            myRenderer3D.API = OpenTK.Windowing.Common.ContextAPI.OpenGL;
            myRenderer3D.APIVersion = new Version(3, 3, 0, 0);
            myRenderer3D.Flags = OpenTK.Windowing.Common.ContextFlags.Default;
            myRenderer3D.ForceUpdate = false;
            myRenderer3D.IsEventDriven = true;
            myRenderer3D.Location = new Point(58, 40);
            myRenderer3D.Margin = new Padding(5);
            myRenderer3D.Name = "myRenderer3D";
            myRenderer3D.Profile = OpenTK.Windowing.Common.ContextProfile.Core;
            myRenderer3D.Size = new Size(1623, 857);
            myRenderer3D.TabIndex = 0;
            myRenderer3D.Text = "renderer3d1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1750, 939);
            Controls.Add(myRenderer3D);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Winforms.Renderer3D myRenderer3D;
    }
}