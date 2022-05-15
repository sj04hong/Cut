
namespace WinFormsApp1
{
    partial class MainForm
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
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.textBox_Front = new System.Windows.Forms.TextBox();
            this.textBox_Back = new System.Windows.Forms.TextBox();
            this.label_Front = new System.Windows.Forms.Label();
            this.label_Back = new System.Windows.Forms.Label();
            this.button_Cut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(24, 21);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(601, 23);
            this.textBox_Input.TabIndex = 0;
            // 
            // textBox_Output
            // 
            this.textBox_Output.Location = new System.Drawing.Point(24, 114);
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.ReadOnly = true;
            this.textBox_Output.Size = new System.Drawing.Size(608, 23);
            this.textBox_Output.TabIndex = 1;
            this.textBox_Output.TabStop = false;
            // 
            // textBox_Front
            // 
            this.textBox_Front.Location = new System.Drawing.Point(80, 67);
            this.textBox_Front.Name = "textBox_Front";
            this.textBox_Front.Size = new System.Drawing.Size(143, 23);
            this.textBox_Front.TabIndex = 2;
            this.textBox_Front.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Front_KeyPress);
            // 
            // textBox_Back
            // 
            this.textBox_Back.Location = new System.Drawing.Point(301, 70);
            this.textBox_Back.Name = "textBox_Back";
            this.textBox_Back.Size = new System.Drawing.Size(143, 23);
            this.textBox_Back.TabIndex = 3;
            this.textBox_Back.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Back_KeyPress);
            // 
            // label_Front
            // 
            this.label_Front.AutoSize = true;
            this.label_Front.Location = new System.Drawing.Point(24, 70);
            this.label_Front.Name = "label_Front";
            this.label_Front.Size = new System.Drawing.Size(43, 15);
            this.label_Front.TabIndex = 4;
            this.label_Front.Text = "앞에서";
            // 
            // label_Back
            // 
            this.label_Back.AutoSize = true;
            this.label_Back.Location = new System.Drawing.Point(256, 73);
            this.label_Back.Name = "label_Back";
            this.label_Back.Size = new System.Drawing.Size(43, 15);
            this.label_Back.TabIndex = 5;
            this.label_Back.Text = "뒤에서";
            // 
            // button_Cut
            // 
            this.button_Cut.Location = new System.Drawing.Point(492, 73);
            this.button_Cut.Name = "button_Cut";
            this.button_Cut.Size = new System.Drawing.Size(75, 23);
            this.button_Cut.TabIndex = 6;
            this.button_Cut.Text = "자르기";
            this.button_Cut.UseVisualStyleBackColor = true;
            this.button_Cut.Click += new System.EventHandler(this.button_Cut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 165);
            this.Controls.Add(this.button_Cut);
            this.Controls.Add(this.label_Back);
            this.Controls.Add(this.label_Front);
            this.Controls.Add(this.textBox_Back);
            this.Controls.Add(this.textBox_Front);
            this.Controls.Add(this.textBox_Output);
            this.Controls.Add(this.textBox_Input);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "문자가위";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.TextBox textBox_Front;
        private System.Windows.Forms.TextBox textBox_Back;
        private System.Windows.Forms.Label label_Front;
        private System.Windows.Forms.Label label_Back;
        private System.Windows.Forms.Button button_Cut;
    }
}