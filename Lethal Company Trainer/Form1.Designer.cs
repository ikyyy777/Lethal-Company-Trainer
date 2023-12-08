namespace Lethal_Company_Trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            checkBox_GodMode = new CheckBox();
            checkBox_SpeedHack = new CheckBox();
            checkBox_HighJump = new CheckBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label_currentMoney = new Label();
            button_SetMoney = new Button();
            checkBox_Stamina = new CheckBox();
            checkBox_FastClimb = new CheckBox();
            checkBox_LongGrab = new CheckBox();
            checkBox_NoWeight = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(149, 20);
            label1.Name = "label1";
            label1.Size = new Size(235, 25);
            label1.TabIndex = 0;
            label1.Text = "Lethal Company Trainer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(368, 434);
            label2.Name = "label2";
            label2.Size = new Size(165, 17);
            label2.TabIndex = 1;
            label2.Text = "Made by 1ntrovertskrrt";
            // 
            // checkBox_GodMode
            // 
            checkBox_GodMode.AutoSize = true;
            checkBox_GodMode.Font = new Font("Segoe UI", 11.25F);
            checkBox_GodMode.ForeColor = Color.White;
            checkBox_GodMode.Location = new Point(34, 76);
            checkBox_GodMode.Name = "checkBox_GodMode";
            checkBox_GodMode.Size = new Size(99, 24);
            checkBox_GodMode.TabIndex = 2;
            checkBox_GodMode.Text = "God Mode";
            checkBox_GodMode.UseVisualStyleBackColor = true;
            // 
            // checkBox_SpeedHack
            // 
            checkBox_SpeedHack.AutoSize = true;
            checkBox_SpeedHack.Font = new Font("Segoe UI", 11.25F);
            checkBox_SpeedHack.ForeColor = Color.White;
            checkBox_SpeedHack.Location = new Point(34, 101);
            checkBox_SpeedHack.Name = "checkBox_SpeedHack";
            checkBox_SpeedHack.Size = new Size(107, 24);
            checkBox_SpeedHack.TabIndex = 3;
            checkBox_SpeedHack.Text = "Speed Hack";
            checkBox_SpeedHack.UseVisualStyleBackColor = true;
            // 
            // checkBox_HighJump
            // 
            checkBox_HighJump.AutoSize = true;
            checkBox_HighJump.Font = new Font("Segoe UI", 11.25F);
            checkBox_HighJump.ForeColor = Color.White;
            checkBox_HighJump.Location = new Point(34, 126);
            checkBox_HighJump.Name = "checkBox_HighJump";
            checkBox_HighJump.Size = new Size(105, 24);
            checkBox_HighJump.TabIndex = 4;
            checkBox_HighJump.Text = "Super Jump";
            checkBox_HighJump.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 296);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(96, 23);
            textBox1.TabIndex = 7;
            textBox1.Text = "100000";
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 295);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 8;
            label3.Text = "Set Money";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(34, 271);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 9;
            label4.Text = "Current Money";
            // 
            // label_currentMoney
            // 
            label_currentMoney.AutoSize = true;
            label_currentMoney.Font = new Font("Segoe UI", 11.25F);
            label_currentMoney.ForeColor = Color.White;
            label_currentMoney.Location = new Point(149, 271);
            label_currentMoney.Name = "label_currentMoney";
            label_currentMoney.Size = new Size(17, 20);
            label_currentMoney.TabIndex = 10;
            label_currentMoney.Text = "0";
            // 
            // button_SetMoney
            // 
            button_SetMoney.Location = new Point(267, 296);
            button_SetMoney.Name = "button_SetMoney";
            button_SetMoney.Size = new Size(49, 22);
            button_SetMoney.TabIndex = 11;
            button_SetMoney.Text = "Set";
            button_SetMoney.UseVisualStyleBackColor = true;
            button_SetMoney.Click += button_SetMoney_Click;
            // 
            // checkBox_Stamina
            // 
            checkBox_Stamina.AutoSize = true;
            checkBox_Stamina.Font = new Font("Segoe UI", 11.25F);
            checkBox_Stamina.ForeColor = Color.White;
            checkBox_Stamina.Location = new Point(34, 151);
            checkBox_Stamina.Name = "checkBox_Stamina";
            checkBox_Stamina.Size = new Size(132, 24);
            checkBox_Stamina.TabIndex = 13;
            checkBox_Stamina.Text = "Infinite Stamina";
            checkBox_Stamina.UseVisualStyleBackColor = true;
            // 
            // checkBox_FastClimb
            // 
            checkBox_FastClimb.AutoSize = true;
            checkBox_FastClimb.Font = new Font("Segoe UI", 11.25F);
            checkBox_FastClimb.ForeColor = Color.White;
            checkBox_FastClimb.Location = new Point(34, 176);
            checkBox_FastClimb.Name = "checkBox_FastClimb";
            checkBox_FastClimb.Size = new Size(96, 24);
            checkBox_FastClimb.TabIndex = 14;
            checkBox_FastClimb.Text = "Fast Climb";
            checkBox_FastClimb.UseVisualStyleBackColor = true;
            // 
            // checkBox_LongGrab
            // 
            checkBox_LongGrab.AutoSize = true;
            checkBox_LongGrab.Font = new Font("Segoe UI", 11.25F);
            checkBox_LongGrab.ForeColor = Color.White;
            checkBox_LongGrab.Location = new Point(34, 201);
            checkBox_LongGrab.Name = "checkBox_LongGrab";
            checkBox_LongGrab.Size = new Size(158, 24);
            checkBox_LongGrab.TabIndex = 15;
            checkBox_LongGrab.Text = "Long Grab Distance";
            checkBox_LongGrab.UseVisualStyleBackColor = true;
            // 
            // checkBox_NoWeight
            // 
            checkBox_NoWeight.AutoSize = true;
            checkBox_NoWeight.Font = new Font("Segoe UI", 11.25F);
            checkBox_NoWeight.ForeColor = Color.White;
            checkBox_NoWeight.Location = new Point(34, 226);
            checkBox_NoWeight.Name = "checkBox_NoWeight";
            checkBox_NoWeight.Size = new Size(99, 24);
            checkBox_NoWeight.TabIndex = 16;
            checkBox_NoWeight.Text = "No Weight";
            checkBox_NoWeight.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(545, 462);
            Controls.Add(checkBox_NoWeight);
            Controls.Add(checkBox_LongGrab);
            Controls.Add(checkBox_FastClimb);
            Controls.Add(checkBox_Stamina);
            Controls.Add(button_SetMoney);
            Controls.Add(label_currentMoney);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(checkBox_HighJump);
            Controls.Add(checkBox_SpeedHack);
            Controls.Add(checkBox_GodMode);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lethal Company Trainer";
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox checkBox_GodMode;
        private CheckBox checkBox_SpeedHack;
        private CheckBox checkBox_HighJump;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label_currentMoney;
        private Button button_SetMoney;
        private CheckBox checkBox_Stamina;
        private CheckBox checkBox_FastClimb;
        private CheckBox checkBox_LongGrab;
        private CheckBox checkBox_NoWeight;
    }
}
