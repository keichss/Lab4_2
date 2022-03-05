
namespace Lab4_2
{
    partial class Form1
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
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.numUDA = new System.Windows.Forms.NumericUpDown();
            this.numUDB = new System.Windows.Forms.NumericUpDown();
            this.numUDC = new System.Windows.Forms.NumericUpDown();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarC = new System.Windows.Forms.TrackBar();
            this.lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).BeginInit();
            this.SuspendLayout();
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(85, 164);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(185, 20);
            this.tbA.TabIndex = 0;
            this.tbA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbA_KeyDown);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(311, 164);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(185, 20);
            this.tbB.TabIndex = 1;
            this.tbB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbB_KeyDown);
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(539, 164);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(185, 20);
            this.tbC.TabIndex = 2;
            this.tbC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbC_KeyDown);
            // 
            // numUDA
            // 
            this.numUDA.Location = new System.Drawing.Point(85, 215);
            this.numUDA.Name = "numUDA";
            this.numUDA.Size = new System.Drawing.Size(185, 20);
            this.numUDA.TabIndex = 3;
            this.numUDA.ValueChanged += new System.EventHandler(this.numUDA_ValueChanged);
            // 
            // numUDB
            // 
            this.numUDB.Location = new System.Drawing.Point(311, 215);
            this.numUDB.Name = "numUDB";
            this.numUDB.Size = new System.Drawing.Size(185, 20);
            this.numUDB.TabIndex = 4;
            this.numUDB.ValueChanged += new System.EventHandler(this.numUDB_ValueChanged);
            // 
            // numUDC
            // 
            this.numUDC.Location = new System.Drawing.Point(539, 215);
            this.numUDC.Name = "numUDC";
            this.numUDC.Size = new System.Drawing.Size(185, 20);
            this.numUDC.TabIndex = 5;
            this.numUDC.ValueChanged += new System.EventHandler(this.numUDC_ValueChanged);
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(85, 267);
            this.trackBarA.Maximum = 100;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(185, 45);
            this.trackBarA.TabIndex = 6;
            this.trackBarA.Scroll += new System.EventHandler(this.trackBarA_Scroll);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(311, 267);
            this.trackBarB.Maximum = 100;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(185, 45);
            this.trackBarB.TabIndex = 7;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // trackBarC
            // 
            this.trackBarC.Location = new System.Drawing.Point(539, 267);
            this.trackBarC.Maximum = 100;
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.Size = new System.Drawing.Size(185, 45);
            this.trackBarC.TabIndex = 8;
            this.trackBarC.Scroll += new System.EventHandler(this.trackBarC_Scroll);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb.Location = new System.Drawing.Point(124, 27);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(570, 108);
            this.lb.TabIndex = 9;
            this.lb.Text = "A <= B <= C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.trackBarC);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarA);
            this.Controls.Add(this.numUDC);
            this.Controls.Add(this.numUDB);
            this.Controls.Add(this.numUDA);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.NumericUpDown numUDA;
        private System.Windows.Forms.NumericUpDown numUDB;
        private System.Windows.Forms.NumericUpDown numUDC;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarC;
        private System.Windows.Forms.Label lb;
    }
}

