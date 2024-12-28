namespace Timer
{
    partial class FormTimer
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonStart = new Button();
            textSetTime = new TextBox();
            textRemainingTime = new TextBox();
            timerControl = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "時間設定";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 9);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 1;
            label2.Text = "秒";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "残り時間";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 67);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 3;
            label4.Text = "秒";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(12, 35);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(186, 23);
            buttonStart.TabIndex = 4;
            buttonStart.Text = "スタート！";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // textSetTime
            // 
            textSetTime.Location = new Point(73, 6);
            textSetTime.Name = "textSetTime";
            textSetTime.Size = new Size(100, 23);
            textSetTime.TabIndex = 5;
            textSetTime.Text = "10";
            textSetTime.TextAlign = HorizontalAlignment.Right;
            // 
            // textRemainingTime
            // 
            textRemainingTime.Location = new Point(73, 64);
            textRemainingTime.Name = "textRemainingTime";
            textRemainingTime.Size = new Size(100, 23);
            textRemainingTime.TabIndex = 6;
            textRemainingTime.Text = "10";
            textRemainingTime.TextAlign = HorizontalAlignment.Right;
            // 
            // timerControl
            // 
            timerControl.Interval = 1000;
            timerControl.Tick += timerControl_Tick;
            // 
            // FormTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 96);
            Controls.Add(textRemainingTime);
            Controls.Add(textSetTime);
            Controls.Add(buttonStart);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTimer";
            Text = "タイマー";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonStart;
        private TextBox textSetTime;
        private TextBox textRemainingTime;
        private System.Windows.Forms.Timer timerControl;
    }
}
