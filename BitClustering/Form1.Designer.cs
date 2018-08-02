namespace BitClustering
{
    partial class Form1
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
            this.btn_Algorithm1 = new System.Windows.Forms.Button();
            this.label_N_LENGTH = new System.Windows.Forms.Label();
            this.label_W_LENGTH = new System.Windows.Forms.Label();
            this.label_FileName = new System.Windows.Forms.Label();
            this.txt_N_LENGTH = new System.Windows.Forms.TextBox();
            this.txt_W_LENGTH = new System.Windows.Forms.TextBox();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.btn_Algorithm2 = new System.Windows.Forms.Button();
            this.label_K_CENTERS = new System.Windows.Forms.Label();
            this.txt_K_CENTERS = new System.Windows.Forms.TextBox();
            this.best_so_far_dist_txt = new System.Windows.Forms.TextBox();
            this.best_so_far_loc_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Algorithm1
            // 
            this.btn_Algorithm1.Location = new System.Drawing.Point(98, 38);
            this.btn_Algorithm1.Name = "btn_Algorithm1";
            this.btn_Algorithm1.Size = new System.Drawing.Size(75, 23);
            this.btn_Algorithm1.TabIndex = 0;
            this.btn_Algorithm1.Text = "Algorithm 1";
            this.btn_Algorithm1.UseVisualStyleBackColor = true;
            this.btn_Algorithm1.Click += new System.EventHandler(this.btn_algorithm1_Click);
            // 
            // label_N_LENGTH
            // 
            this.label_N_LENGTH.AutoSize = true;
            this.label_N_LENGTH.Location = new System.Drawing.Point(102, 100);
            this.label_N_LENGTH.Name = "label_N_LENGTH";
            this.label_N_LENGTH.Size = new System.Drawing.Size(65, 13);
            this.label_N_LENGTH.TabIndex = 1;
            this.label_N_LENGTH.Text = "N_LENGTH";
            // 
            // label_W_LENGTH
            // 
            this.label_W_LENGTH.AutoSize = true;
            this.label_W_LENGTH.Location = new System.Drawing.Point(102, 136);
            this.label_W_LENGTH.Name = "label_W_LENGTH";
            this.label_W_LENGTH.Size = new System.Drawing.Size(68, 13);
            this.label_W_LENGTH.TabIndex = 2;
            this.label_W_LENGTH.Text = "W_LENGTH";
            // 
            // label_FileName
            // 
            this.label_FileName.AutoSize = true;
            this.label_FileName.Location = new System.Drawing.Point(102, 206);
            this.label_FileName.Name = "label_FileName";
            this.label_FileName.Size = new System.Drawing.Size(54, 13);
            this.label_FileName.TabIndex = 3;
            this.label_FileName.Text = "File Name";
            // 
            // txt_N_LENGTH
            // 
            this.txt_N_LENGTH.Location = new System.Drawing.Point(197, 97);
            this.txt_N_LENGTH.Name = "txt_N_LENGTH";
            this.txt_N_LENGTH.Size = new System.Drawing.Size(100, 20);
            this.txt_N_LENGTH.TabIndex = 4;
            this.txt_N_LENGTH.Text = "600";
            // 
            // txt_W_LENGTH
            // 
            this.txt_W_LENGTH.Location = new System.Drawing.Point(197, 132);
            this.txt_W_LENGTH.Name = "txt_W_LENGTH";
            this.txt_W_LENGTH.Size = new System.Drawing.Size(100, 20);
            this.txt_W_LENGTH.TabIndex = 4;
            this.txt_W_LENGTH.Text = "150";
            // 
            // txt_FileName
            // 
            this.txt_FileName.Location = new System.Drawing.Point(197, 199);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(100, 20);
            this.txt_FileName.TabIndex = 4;
            this.txt_FileName.Text = "ECG_15000.txt";
            // 
            // btn_Algorithm2
            // 
            this.btn_Algorithm2.Location = new System.Drawing.Point(222, 38);
            this.btn_Algorithm2.Name = "btn_Algorithm2";
            this.btn_Algorithm2.Size = new System.Drawing.Size(75, 23);
            this.btn_Algorithm2.TabIndex = 5;
            this.btn_Algorithm2.Text = "Algorithm 2";
            this.btn_Algorithm2.UseVisualStyleBackColor = true;
            this.btn_Algorithm2.Click += new System.EventHandler(this.btn_algorithm2_Click);
            // 
            // label_K_CENTERS
            // 
            this.label_K_CENTERS.AutoSize = true;
            this.label_K_CENTERS.Location = new System.Drawing.Point(102, 172);
            this.label_K_CENTERS.Name = "label_K_CENTERS";
            this.label_K_CENTERS.Size = new System.Drawing.Size(71, 13);
            this.label_K_CENTERS.TabIndex = 1;
            this.label_K_CENTERS.Text = "K_CENTERS";
            // 
            // txt_K_CENTERS
            // 
            this.txt_K_CENTERS.Location = new System.Drawing.Point(197, 167);
            this.txt_K_CENTERS.Name = "txt_K_CENTERS";
            this.txt_K_CENTERS.Size = new System.Drawing.Size(100, 20);
            this.txt_K_CENTERS.TabIndex = 4;
            this.txt_K_CENTERS.Text = "28";
            // 
            // best_so_far_dist_txt
            // 
            this.best_so_far_dist_txt.Location = new System.Drawing.Point(197, 238);
            this.best_so_far_dist_txt.Name = "best_so_far_dist_txt";
            this.best_so_far_dist_txt.Size = new System.Drawing.Size(100, 20);
            this.best_so_far_dist_txt.TabIndex = 6;
            // 
            // best_so_far_loc_txt
            // 
            this.best_so_far_loc_txt.Location = new System.Drawing.Point(197, 274);
            this.best_so_far_loc_txt.Name = "best_so_far_loc_txt";
            this.best_so_far_loc_txt.Size = new System.Drawing.Size(100, 20);
            this.best_so_far_loc_txt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "best_so_far_dist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "best_so_far_loc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status: ";
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(271, 315);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(100, 20);
            this.txt_time.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Execution time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 347);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.best_so_far_loc_txt);
            this.Controls.Add(this.best_so_far_dist_txt);
            this.Controls.Add(this.btn_Algorithm2);
            this.Controls.Add(this.txt_FileName);
            this.Controls.Add(this.txt_W_LENGTH);
            this.Controls.Add(this.txt_K_CENTERS);
            this.Controls.Add(this.txt_N_LENGTH);
            this.Controls.Add(this.label_FileName);
            this.Controls.Add(this.label_K_CENTERS);
            this.Controls.Add(this.label_W_LENGTH);
            this.Controls.Add(this.label_N_LENGTH);
            this.Controls.Add(this.btn_Algorithm1);
            this.Name = "Form1";
            this.Text = "BitClustering - Ver 1.5 - Nov 9th 2016";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Algorithm1;
        private System.Windows.Forms.Label label_N_LENGTH;
        private System.Windows.Forms.Label label_W_LENGTH;
        private System.Windows.Forms.Label label_FileName;
        private System.Windows.Forms.TextBox txt_N_LENGTH;
        private System.Windows.Forms.TextBox txt_W_LENGTH;
        private System.Windows.Forms.TextBox txt_FileName;
        private System.Windows.Forms.Button btn_Algorithm2;
        private System.Windows.Forms.Label label_K_CENTERS;
        private System.Windows.Forms.TextBox txt_K_CENTERS;
        private System.Windows.Forms.TextBox best_so_far_dist_txt;
        private System.Windows.Forms.TextBox best_so_far_loc_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Label label4;
    }
}

