namespace ProcessKiller
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstProcesses = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslProcessCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnUpdateProcessList = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lst_id = new System.Windows.Forms.ListBox();
            this.lst_memoriafisica = new System.Windows.Forms.ListBox();
            this.lst_memoriavirtual = new System.Windows.Forms.ListBox();
            this.lst_CPU = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProcesses
            // 
            this.lstProcesses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstProcesses.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProcesses.FormattingEnabled = true;
            this.lstProcesses.HorizontalScrollbar = true;
            this.lstProcesses.ItemHeight = 15;
            this.lstProcesses.Location = new System.Drawing.Point(30, 81);
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.ScrollAlwaysVisible = true;
            this.lstProcesses.Size = new System.Drawing.Size(136, 375);
            this.lstProcesses.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslProcessCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(908, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslProcessCount
            // 
            this.tslProcessCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tslProcessCount.Name = "tslProcessCount";
            this.tslProcessCount.Size = new System.Drawing.Size(118, 17);
            this.tslProcessCount.Text = "toolStripStatusLabel1";
            // 
            // btnUpdateProcessList
            // 
            this.btnUpdateProcessList.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProcessList.Location = new System.Drawing.Point(54, 473);
            this.btnUpdateProcessList.Name = "btnUpdateProcessList";
            this.btnUpdateProcessList.Size = new System.Drawing.Size(87, 27);
            this.btnUpdateProcessList.TabIndex = 2;
            this.btnUpdateProcessList.Text = "actualizar";
            this.btnUpdateProcessList.UseVisualStyleBackColor = true;
            this.btnUpdateProcessList.Click += new System.EventHandler(this.btnUpdateProcessList_Click_1);
            // 
            // btnKill
            // 
            this.btnKill.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKill.Location = new System.Drawing.Point(215, 473);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(87, 27);
            this.btnKill.TabIndex = 3;
            this.btnKill.Text = "detener";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(764, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(577, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "informacion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lst_id
            // 
            this.lst_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_id.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_id.FormattingEnabled = true;
            this.lst_id.HorizontalScrollbar = true;
            this.lst_id.ItemHeight = 15;
            this.lst_id.Location = new System.Drawing.Point(194, 81);
            this.lst_id.Name = "lst_id";
            this.lst_id.ScrollAlwaysVisible = true;
            this.lst_id.Size = new System.Drawing.Size(136, 375);
            this.lst_id.TabIndex = 7;
            // 
            // lst_memoriafisica
            // 
            this.lst_memoriafisica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_memoriafisica.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_memoriafisica.FormattingEnabled = true;
            this.lst_memoriafisica.HorizontalScrollbar = true;
            this.lst_memoriafisica.ItemHeight = 15;
            this.lst_memoriafisica.Location = new System.Drawing.Point(374, 81);
            this.lst_memoriafisica.Name = "lst_memoriafisica";
            this.lst_memoriafisica.ScrollAlwaysVisible = true;
            this.lst_memoriafisica.Size = new System.Drawing.Size(136, 375);
            this.lst_memoriafisica.TabIndex = 8;
            // 
            // lst_memoriavirtual
            // 
            this.lst_memoriavirtual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_memoriavirtual.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_memoriavirtual.FormattingEnabled = true;
            this.lst_memoriavirtual.HorizontalScrollbar = true;
            this.lst_memoriavirtual.ItemHeight = 15;
            this.lst_memoriavirtual.Location = new System.Drawing.Point(549, 81);
            this.lst_memoriavirtual.Name = "lst_memoriavirtual";
            this.lst_memoriavirtual.ScrollAlwaysVisible = true;
            this.lst_memoriavirtual.Size = new System.Drawing.Size(136, 375);
            this.lst_memoriavirtual.TabIndex = 9;
            // 
            // lst_CPU
            // 
            this.lst_CPU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_CPU.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_CPU.FormattingEnabled = true;
            this.lst_CPU.HorizontalScrollbar = true;
            this.lst_CPU.ItemHeight = 15;
            this.lst_CPU.Location = new System.Drawing.Point(734, 81);
            this.lst_CPU.Name = "lst_CPU";
            this.lst_CPU.ScrollAlwaysVisible = true;
            this.lst_CPU.Size = new System.Drawing.Size(136, 375);
            this.lst_CPU.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(66, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Procesos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(246, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(395, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Memoria fisica :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(569, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Memoria Virtual:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(787, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "CPU:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 528);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_CPU);
            this.Controls.Add(this.lst_memoriavirtual);
            this.Controls.Add(this.lst_memoriafisica);
            this.Controls.Add(this.lst_id);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnUpdateProcessList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lstProcesses);
            this.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Procesos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProcesses;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslProcessCount;
        private System.Windows.Forms.Button btnUpdateProcessList;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lst_id;
        private System.Windows.Forms.ListBox lst_memoriafisica;
        private System.Windows.Forms.ListBox lst_memoriavirtual;
        private System.Windows.Forms.ListBox lst_CPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}

