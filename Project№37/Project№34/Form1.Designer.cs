
namespace Project_34
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonInit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAnaliz = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.labelGraf = new System.Windows.Forms.Label();
            this.labelFastpath = new System.Windows.Forms.Label();
            this.labelFlex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(331, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(390, 223);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(43, 65);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(128, 23);
            this.buttonInit.TabIndex = 1;
            this.buttonInit.Text = "Создание графа";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buttonAnaliz
            // 
            this.buttonAnaliz.Location = new System.Drawing.Point(43, 111);
            this.buttonAnaliz.Name = "buttonAnaliz";
            this.buttonAnaliz.Size = new System.Drawing.Size(128, 27);
            this.buttonAnaliz.TabIndex = 3;
            this.buttonAnaliz.Text = "Анализ графа\r\n\r\n";
            this.buttonAnaliz.UseVisualStyleBackColor = true;
            this.buttonAnaliz.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(331, 286);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(390, 181);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(744, 286);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(327, 181);
            this.dataGridView3.TabIndex = 5;
            // 
            // labelGraf
            // 
            this.labelGraf.AutoSize = true;
            this.labelGraf.Location = new System.Drawing.Point(338, 9);
            this.labelGraf.Name = "labelGraf";
            this.labelGraf.Size = new System.Drawing.Size(160, 13);
            this.labelGraf.TabIndex = 6;
            this.labelGraf.Text = "Начальный граф (расстояния)";
            // 
            // labelFastpath
            // 
            this.labelFastpath.AutoSize = true;
            this.labelFastpath.Location = new System.Drawing.Point(328, 260);
            this.labelFastpath.Name = "labelFastpath";
            this.labelFastpath.Size = new System.Drawing.Size(256, 13);
            this.labelFastpath.TabIndex = 7;
            this.labelFastpath.Text = "Кратчайшие расстояния до пунктов (расстояния)\r\n";
            // 
            // labelFlex
            // 
            this.labelFlex.AutoSize = true;
            this.labelFlex.Location = new System.Drawing.Point(698, 260);
            this.labelFlex.Name = "labelFlex";
            this.labelFlex.Size = new System.Drawing.Size(495, 13);
            this.labelFlex.TabIndex = 8;
            this.labelFlex.Text = "Таблица переходов между пунктами для достижения наикратчайшего пути (пункты - пос" +
    "трочно)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Не больше 9 пунктов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFlex);
            this.Controls.Add(this.labelFastpath);
            this.Controls.Add(this.labelGraf);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonAnaliz);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonInit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Алгоритм Флойда-Уоршелла";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAnaliz;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label labelGraf;
        private System.Windows.Forms.Label labelFastpath;
        private System.Windows.Forms.Label labelFlex;
        private System.Windows.Forms.Label label1;
    }
}

