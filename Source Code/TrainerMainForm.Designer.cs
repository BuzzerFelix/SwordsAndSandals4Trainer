
namespace SwordsAndSandals4Trainer
{
    partial class TrainerMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sas4_worker = new System.ComponentModel.BackgroundWorker();
            this.inf_skillpoints = new System.Windows.Forms.CheckBox();
            this.ProcessID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 140);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Juice ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(91)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(121, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Swords and Sandals 4 Trainer";
            // 
            // sas4_worker
            // 
            this.sas4_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.sas4_worker_DoWork);
            // 
            // inf_skillpoints
            // 
            this.inf_skillpoints.AutoSize = true;
            this.inf_skillpoints.Checked = true;
            this.inf_skillpoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inf_skillpoints.Location = new System.Drawing.Point(12, 146);
            this.inf_skillpoints.Name = "inf_skillpoints";
            this.inf_skillpoints.Size = new System.Drawing.Size(138, 21);
            this.inf_skillpoints.TabIndex = 1;
            this.inf_skillpoints.Text = "Infinite Skillpoints";
            this.inf_skillpoints.UseVisualStyleBackColor = true;
            this.inf_skillpoints.Click += new System.EventHandler(this.inf_skillpoints_Click);
            // 
            // ProcessID
            // 
            this.ProcessID.AutoSize = true;
            this.ProcessID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcessID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProcessID.Location = new System.Drawing.Point(12, 384);
            this.ProcessID.Name = "ProcessID";
            this.ProcessID.Size = new System.Drawing.Size(69, 32);
            this.ProcessID.TabIndex = 2;
            this.ProcessID.Text = "Pid:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(361, 332);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(136, 84);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close Process And Trainer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrainerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(509, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProcessID);
            this.Controls.Add(this.inf_skillpoints);
            this.Controls.Add(this.panel1);
            this.Name = "TrainerMainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker sas4_worker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox inf_skillpoints;
        private System.Windows.Forms.Label ProcessID;
        private System.Windows.Forms.Button button1;
    }
}

