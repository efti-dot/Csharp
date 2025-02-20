namespace Calculator
{
    partial class BMICalculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMICalculator));
            this.p1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.heightinfo = new System.Windows.Forms.Label();
            this.weightinfo = new System.Windows.Forms.Label();
            this.heiVal = new System.Windows.Forms.TextBox();
            this.weiVal = new System.Windows.Forms.TextBox();
            this.heiComBox = new System.Windows.Forms.ComboBox();
            this.weiComBox = new System.Windows.Forms.ComboBox();
            this.moodimages = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(13, 13);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(229, 199);
            this.p1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Condition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 31);
            this.label2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(396, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(396, 329);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(94, 45);
            this.clearbtn.TabIndex = 4;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // heightinfo
            // 
            this.heightinfo.AutoSize = true;
            this.heightinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightinfo.Location = new System.Drawing.Point(268, 13);
            this.heightinfo.Name = "heightinfo";
            this.heightinfo.Size = new System.Drawing.Size(62, 20);
            this.heightinfo.TabIndex = 5;
            this.heightinfo.Text = "Height";
            // 
            // weightinfo
            // 
            this.weightinfo.AutoSize = true;
            this.weightinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightinfo.Location = new System.Drawing.Point(268, 105);
            this.weightinfo.Name = "weightinfo";
            this.weightinfo.Size = new System.Drawing.Size(65, 20);
            this.weightinfo.TabIndex = 6;
            this.weightinfo.Text = "Weight";
            // 
            // heiVal
            // 
            this.heiVal.Location = new System.Drawing.Point(272, 52);
            this.heiVal.Name = "heiVal";
            this.heiVal.Size = new System.Drawing.Size(100, 20);
            this.heiVal.TabIndex = 7;
            this.heiVal.TextChanged += new System.EventHandler(this.checkInput);
            // 
            // weiVal
            // 
            this.weiVal.Location = new System.Drawing.Point(272, 148);
            this.weiVal.Name = "weiVal";
            this.weiVal.Size = new System.Drawing.Size(100, 20);
            this.weiVal.TabIndex = 8;
            // 
            // heiComBox
            // 
            this.heiComBox.FormattingEnabled = true;
            this.heiComBox.Items.AddRange(new object[] {
            "Ft",
            "m",
            "cm"});
            this.heiComBox.Location = new System.Drawing.Point(379, 52);
            this.heiComBox.Name = "heiComBox";
            this.heiComBox.Size = new System.Drawing.Size(51, 21);
            this.heiComBox.TabIndex = 9;
            // 
            // weiComBox
            // 
            this.weiComBox.FormattingEnabled = true;
            this.weiComBox.Items.AddRange(new object[] {
            "kg",
            "lb",
            "g"});
            this.weiComBox.Location = new System.Drawing.Point(379, 148);
            this.weiComBox.Name = "weiComBox";
            this.weiComBox.Size = new System.Drawing.Size(51, 21);
            this.weiComBox.TabIndex = 10;
            // 
            // moodimages
            // 
            this.moodimages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("moodimages.ImageStream")));
            this.moodimages.TransparentColor = System.Drawing.Color.Transparent;
            this.moodimages.Images.SetKeyName(0, "VirtualBox_elementary_16_11_2023_13_47_10.png");
            this.moodimages.Images.SetKeyName(1, "hafsa1.png");
            this.moodimages.Images.SetKeyName(2, "VirtualBox_ubuntu_17_11_2023_19_19_43.png");
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.weiComBox);
            this.Controls.Add(this.heiComBox);
            this.Controls.Add(this.weiVal);
            this.Controls.Add(this.heiVal);
            this.Controls.Add(this.weightinfo);
            this.Controls.Add(this.heightinfo);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p1);
            this.Name = "BMICalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Label heightinfo;
        private System.Windows.Forms.Label weightinfo;
        private System.Windows.Forms.TextBox heiVal;
        private System.Windows.Forms.TextBox weiVal;
        private System.Windows.Forms.ComboBox heiComBox;
        private System.Windows.Forms.ComboBox weiComBox;
        private System.Windows.Forms.ImageList moodimages;
    }
}

