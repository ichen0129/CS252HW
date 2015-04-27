namespace Calcuate
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.numTextBox1 = new System.Windows.Forms.TextBox();
            this.numTextBox2 = new System.Windows.Forms.TextBox();
            this.numTextBox3 = new System.Windows.Forms.TextBox();
            this.numTextBox4 = new System.Windows.Forms.TextBox();
            this.numLabel1 = new System.Windows.Forms.Label();
            this.numLabel2 = new System.Windows.Forms.Label();
            this.numLabel4 = new System.Windows.Forms.Label();
            this.numLabel3 = new System.Windows.Forms.Label();
            this.calcuateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numTextBox1
            // 
            this.numTextBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTextBox1.Location = new System.Drawing.Point(93, 13);
            this.numTextBox1.Name = "numTextBox1";
            this.numTextBox1.Size = new System.Drawing.Size(126, 23);
            this.numTextBox1.TabIndex = 0;
            this.numTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numTextBox1_KeyPress);
            this.numTextBox1.Leave += new System.EventHandler(this.numTextBox1_Leave);
            // 
            // numTextBox2
            // 
            this.numTextBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTextBox2.Location = new System.Drawing.Point(93, 47);
            this.numTextBox2.Name = "numTextBox2";
            this.numTextBox2.Size = new System.Drawing.Size(126, 23);
            this.numTextBox2.TabIndex = 1;
            this.numTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numTextBox1_KeyPress);
            this.numTextBox2.Leave += new System.EventHandler(this.numTextBox1_Leave);
            // 
            // numTextBox3
            // 
            this.numTextBox3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTextBox3.Location = new System.Drawing.Point(93, 81);
            this.numTextBox3.Name = "numTextBox3";
            this.numTextBox3.Size = new System.Drawing.Size(126, 23);
            this.numTextBox3.TabIndex = 2;
            this.numTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numTextBox1_KeyPress);
            this.numTextBox3.Leave += new System.EventHandler(this.numTextBox1_Leave);
            // 
            // numTextBox4
            // 
            this.numTextBox4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTextBox4.Location = new System.Drawing.Point(93, 115);
            this.numTextBox4.Name = "numTextBox4";
            this.numTextBox4.Size = new System.Drawing.Size(126, 23);
            this.numTextBox4.TabIndex = 3;
            this.numTextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numTextBox1_KeyPress);
            this.numTextBox4.Leave += new System.EventHandler(this.numTextBox1_Leave);
            // 
            // numLabel1
            // 
            this.numLabel1.AutoSize = true;
            this.numLabel1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLabel1.Location = new System.Drawing.Point(28, 17);
            this.numLabel1.Name = "numLabel1";
            this.numLabel1.Size = new System.Drawing.Size(63, 15);
            this.numLabel1.TabIndex = 4;
            this.numLabel1.Text = "Number 1";
            // 
            // numLabel2
            // 
            this.numLabel2.AutoSize = true;
            this.numLabel2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLabel2.Location = new System.Drawing.Point(28, 51);
            this.numLabel2.Name = "numLabel2";
            this.numLabel2.Size = new System.Drawing.Size(63, 15);
            this.numLabel2.TabIndex = 5;
            this.numLabel2.Text = "Number 2";
            // 
            // numLabel4
            // 
            this.numLabel4.AutoSize = true;
            this.numLabel4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLabel4.Location = new System.Drawing.Point(28, 119);
            this.numLabel4.Name = "numLabel4";
            this.numLabel4.Size = new System.Drawing.Size(63, 15);
            this.numLabel4.TabIndex = 7;
            this.numLabel4.Text = "Number 4";
            // 
            // numLabel3
            // 
            this.numLabel3.AutoSize = true;
            this.numLabel3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLabel3.Location = new System.Drawing.Point(28, 85);
            this.numLabel3.Name = "numLabel3";
            this.numLabel3.Size = new System.Drawing.Size(63, 15);
            this.numLabel3.TabIndex = 6;
            this.numLabel3.Text = "Number 3";
            // 
            // calcuateButton
            // 
            this.calcuateButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcuateButton.Location = new System.Drawing.Point(46, 169);
            this.calcuateButton.Name = "calcuateButton";
            this.calcuateButton.Size = new System.Drawing.Size(162, 39);
            this.calcuateButton.TabIndex = 8;
            this.calcuateButton.Text = "Calcuate";
            this.calcuateButton.UseVisualStyleBackColor = true;
            this.calcuateButton.Click += new System.EventHandler(this.calcuateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 241);
            this.Controls.Add(this.calcuateButton);
            this.Controls.Add(this.numLabel4);
            this.Controls.Add(this.numLabel3);
            this.Controls.Add(this.numLabel2);
            this.Controls.Add(this.numLabel1);
            this.Controls.Add(this.numTextBox4);
            this.Controls.Add(this.numTextBox3);
            this.Controls.Add(this.numTextBox2);
            this.Controls.Add(this.numTextBox1);
            this.Name = "Form1";
            this.Text = "Calcuate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numTextBox1;
        private System.Windows.Forms.TextBox numTextBox2;
        private System.Windows.Forms.TextBox numTextBox3;
        private System.Windows.Forms.TextBox numTextBox4;
        private System.Windows.Forms.Label numLabel1;
        private System.Windows.Forms.Label numLabel2;
        private System.Windows.Forms.Label numLabel4;
        private System.Windows.Forms.Label numLabel3;
        private System.Windows.Forms.Button calcuateButton;
    }
}

