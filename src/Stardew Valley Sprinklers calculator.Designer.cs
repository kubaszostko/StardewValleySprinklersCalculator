
namespace Sprinklers_Calculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InputOfSprinklersAmount = new System.Windows.Forms.TextBox();
            this.SprinklersAmount = new System.Windows.Forms.Label();
            this.SprinklerType = new System.Windows.Forms.Label();
            this.Sprinklers_List = new System.Windows.Forms.ComboBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PressureNozleCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // InputOfSprinklersAmount
            // 
            this.InputOfSprinklersAmount.BackColor = System.Drawing.SystemColors.Window;
            this.InputOfSprinklersAmount.Location = new System.Drawing.Point(191, 170);
            this.InputOfSprinklersAmount.MaxLength = 6;
            this.InputOfSprinklersAmount.Name = "InputOfSprinklersAmount";
            this.InputOfSprinklersAmount.PlaceholderText = "Insert your sprinklers amount";
            this.InputOfSprinklersAmount.ShortcutsEnabled = false;
            this.InputOfSprinklersAmount.Size = new System.Drawing.Size(232, 23);
            this.InputOfSprinklersAmount.TabIndex = 1;
            this.InputOfSprinklersAmount.TabStop = false;
            this.InputOfSprinklersAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputOfSprinklersNumber_KeyPress);
            // 
            // SprinklersAmount
            // 
            this.SprinklersAmount.AutoSize = true;
            this.SprinklersAmount.BackColor = System.Drawing.Color.Transparent;
            this.SprinklersAmount.Location = new System.Drawing.Point(65, 174);
            this.SprinklersAmount.Name = "SprinklersAmount";
            this.SprinklersAmount.Size = new System.Drawing.Size(106, 15);
            this.SprinklersAmount.TabIndex = 0;
            this.SprinklersAmount.Text = "Sprinklers amount:";
            // 
            // SprinklerType
            // 
            this.SprinklerType.AutoSize = true;
            this.SprinklerType.BackColor = System.Drawing.Color.Transparent;
            this.SprinklerType.Location = new System.Drawing.Point(65, 129);
            this.SprinklerType.Name = "SprinklerType";
            this.SprinklerType.Size = new System.Drawing.Size(82, 15);
            this.SprinklerType.TabIndex = 0;
            this.SprinklerType.Text = "Sprinkler type:";
            // 
            // Sprinklers_List
            // 
            this.Sprinklers_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sprinklers_List.Items.AddRange(new object[] {
            "Normal",
            "Quality",
            "Iridium"});
            this.Sprinklers_List.Location = new System.Drawing.Point(191, 125);
            this.Sprinklers_List.Name = "Sprinklers_List";
            this.Sprinklers_List.Size = new System.Drawing.Size(232, 23);
            this.Sprinklers_List.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Sprinklers_List, resources.GetString("Sprinklers_List.ToolTip"));
            this.Sprinklers_List.SelectedIndexChanged += new System.EventHandler(this.Sprinklers_List_SelectedIndexChanged);
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.Transparent;
            this.Calculate.Location = new System.Drawing.Point(354, 215);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(72, 24);
            this.Calculate.TabIndex = 5;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Sprinklers_Calculator.Properties.Resources.Banner;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 101);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PressureNozleCheckBox
            // 
            this.PressureNozleCheckBox.AutoSize = true;
            this.PressureNozleCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.PressureNozleCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PressureNozleCheckBox.Location = new System.Drawing.Point(65, 219);
            this.PressureNozleCheckBox.Name = "PressureNozleCheckBox";
            this.PressureNozleCheckBox.Size = new System.Drawing.Size(108, 19);
            this.PressureNozleCheckBox.TabIndex = 7;
            this.PressureNozleCheckBox.Text = "Pressure Nozzle";
            this.toolTip1.SetToolTip(this.PressureNozleCheckBox, resources.GetString("PressureNozleCheckBox.ToolTip"));
            this.PressureNozleCheckBox.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Sprinklers_Calculator.Properties.Resources.Pressure_Nozzle;
            this.pictureBox2.Location = new System.Drawing.Point(22, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, resources.GetString("pictureBox2.ToolTip"));
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::Sprinklers_Calculator.Properties.Resources.Iridium_Sprinkler;
            this.pictureBox3.Location = new System.Drawing.Point(19, 120);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 100000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "1,2,3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 35;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stardew Valley", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(335, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "version 1.0.2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 276);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PressureNozleCheckBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Sprinklers_List);
            this.Controls.Add(this.SprinklerType);
            this.Controls.Add(this.InputOfSprinklersAmount);
            this.Controls.Add(this.SprinklersAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(477, 377);
            this.MinimumSize = new System.Drawing.Size(477, 315);
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stardew Valley Sprinklers Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SprinklersAmount;
        private System.Windows.Forms.Label SprinklerType;
        private System.Windows.Forms.ComboBox Sprinklers_List;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox PressureNozleCheckBox;
        private System.Windows.Forms.TextBox InputOfSprinklersAmount;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

