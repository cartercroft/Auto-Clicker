﻿namespace AutoClicker
{
    partial class AutoClicker
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
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.minClicksBetweenMovement = new System.Windows.Forms.TextBox();
            this.minWait = new System.Windows.Forms.TextBox();
            this.maxWait = new System.Windows.Forms.TextBox();
            this.asdfas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxClicksBetweenMovement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MouseXLabel = new System.Windows.Forms.Label();
            this.MouseYLabel = new System.Windows.Forms.Label();
            this.numMouseClicks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(136, 191);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 28);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(136, 226);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 28);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // minClicksBetweenMovement
            // 
            this.minClicksBetweenMovement.Location = new System.Drawing.Point(217, 79);
            this.minClicksBetweenMovement.Margin = new System.Windows.Forms.Padding(4);
            this.minClicksBetweenMovement.Name = "minClicksBetweenMovement";
            this.minClicksBetweenMovement.Size = new System.Drawing.Size(132, 22);
            this.minClicksBetweenMovement.TabIndex = 2;
            // 
            // minWait
            // 
            this.minWait.Location = new System.Drawing.Point(217, 15);
            this.minWait.Margin = new System.Windows.Forms.Padding(4);
            this.minWait.Name = "minWait";
            this.minWait.Size = new System.Drawing.Size(132, 22);
            this.minWait.TabIndex = 3;
            // 
            // maxWait
            // 
            this.maxWait.Location = new System.Drawing.Point(217, 43);
            this.maxWait.Margin = new System.Windows.Forms.Padding(4);
            this.maxWait.Name = "maxWait";
            this.maxWait.Size = new System.Drawing.Size(132, 22);
            this.maxWait.TabIndex = 4;
            // 
            // asdfas
            // 
            this.asdfas.AutoSize = true;
            this.asdfas.Location = new System.Drawing.Point(17, 15);
            this.asdfas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.asdfas.Name = "asdfas";
            this.asdfas.Size = new System.Drawing.Size(87, 16);
            this.asdfas.TabIndex = 5;
            this.asdfas.Text = "Min Wait (ms)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Max Wait (ms)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Min Clicks Before Movement";
            // 
            // maxClicksBetweenMovement
            // 
            this.maxClicksBetweenMovement.Location = new System.Drawing.Point(217, 106);
            this.maxClicksBetweenMovement.Margin = new System.Windows.Forms.Padding(4);
            this.maxClicksBetweenMovement.Name = "maxClicksBetweenMovement";
            this.maxClicksBetweenMovement.Size = new System.Drawing.Size(132, 22);
            this.maxClicksBetweenMovement.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Max Clicks Before Movement";
            // 
            // MouseXLabel
            // 
            this.MouseXLabel.AutoSize = true;
            this.MouseXLabel.Location = new System.Drawing.Point(17, 294);
            this.MouseXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MouseXLabel.Name = "MouseXLabel";
            this.MouseXLabel.Size = new System.Drawing.Size(116, 16);
            this.MouseXLabel.TabIndex = 10;
            this.MouseXLabel.Text = "Mouse X Position: ";
            // 
            // MouseYLabel
            // 
            this.MouseYLabel.AutoSize = true;
            this.MouseYLabel.Location = new System.Drawing.Point(187, 294);
            this.MouseYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MouseYLabel.Name = "MouseYLabel";
            this.MouseYLabel.Size = new System.Drawing.Size(117, 16);
            this.MouseYLabel.TabIndex = 11;
            this.MouseYLabel.Text = "Mouse Y Position: ";
            // 
            // numMouseClicks
            // 
            this.numMouseClicks.AutoSize = true;
            this.numMouseClicks.Location = new System.Drawing.Point(370, 294);
            this.numMouseClicks.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.numMouseClicks.Name = "numMouseClicks";
            this.numMouseClicks.Size = new System.Drawing.Size(131, 16);
            this.numMouseClicks.TabIndex = 12;
            this.numMouseClicks.Text = "0 Total Mouse Clicks";
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 321);
            this.Controls.Add(this.numMouseClicks);
            this.Controls.Add(this.MouseYLabel);
            this.Controls.Add(this.MouseXLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxClicksBetweenMovement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.asdfas);
            this.Controls.Add(this.maxWait);
            this.Controls.Add(this.minWait);
            this.Controls.Add(this.minClicksBetweenMovement);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AutoClicker";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox minClicksBetweenMovement;
        private System.Windows.Forms.TextBox minWait;
        private System.Windows.Forms.TextBox maxWait;
        private System.Windows.Forms.Label asdfas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxClicksBetweenMovement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MouseXLabel;
        private System.Windows.Forms.Label MouseYLabel;
        private System.Windows.Forms.Label numMouseClicks;
    }
}

