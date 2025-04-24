namespace Tennis.Score
{
    partial class NewGameForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label6 = new Label();
            button1 = new Button();
            errorProvider2 = new ErrorProvider(components);
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(269, 43);
            label1.Name = "label1";
            label1.Size = new Size(270, 67);
            label1.TabIndex = 0;
            label1.Text = "New Game";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(98, 167);
            label2.Name = "label2";
            label2.Size = new Size(182, 46);
            label2.TabIndex = 1;
            label2.Text = "First Player";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(511, 167);
            label3.Name = "label3";
            label3.Size = new Size(230, 46);
            label3.TabIndex = 2;
            label3.Text = "Second Player";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(136, 307);
            label4.Name = "label4";
            label4.Size = new Size(82, 35);
            label4.TabIndex = 3;
            label4.Text = "Points";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(574, 307);
            label5.Name = "label5";
            label5.Size = new Size(82, 35);
            label5.TabIndex = 4;
            label5.Text = "Points";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.IndianRed;
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(109, 236);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 41);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.IndianRed;
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(543, 236);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 41);
            textBox2.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.IndianRed;
            numericUpDown1.Location = new Point(136, 376);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(94, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            numericUpDown2.BackColor = Color.IndianRed;
            numericUpDown2.Location = new Point(563, 376);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(102, 27);
            numericUpDown2.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 35F);
            label6.Location = new Point(350, 264);
            label6.Name = "label6";
            label6.Size = new Size(124, 78);
            label6.TabIndex = 9;
            label6.Text = "V/S";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(335, 434);
            button1.Name = "button1";
            button1.Size = new Size(124, 60);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // NewGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 538);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewGameForm";
            Text = "NewGameForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label6;
        private Button button1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider1;
    }
}