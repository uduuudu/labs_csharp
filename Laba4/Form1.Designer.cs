namespace ShipsView
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.methods_params = new System.Windows.Forms.ListBox();
            this.objects = new System.Windows.Forms.ListBox();
            this.runMethod = new System.Windows.Forms.Button();
            this.inputParams = new System.Windows.Forms.Button();
            this.createObj = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Параметры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Свойства";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Метод";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Класс";
            // 
            // methods_params
            // 
            this.methods_params.FormattingEnabled = true;
            this.methods_params.Location = new System.Drawing.Point(388, 26);
            this.methods_params.Name = "methods_params";
            this.methods_params.Size = new System.Drawing.Size(183, 95);
            this.methods_params.TabIndex = 17;
            this.methods_params.SelectedIndexChanged += new System.EventHandler(this.methods_params_SelectedIndexChanged);
            // 
            // objects
            // 
            this.objects.FormattingEnabled = true;
            this.objects.Location = new System.Drawing.Point(87, 26);
            this.objects.Name = "objects";
            this.objects.Size = new System.Drawing.Size(174, 95);
            this.objects.TabIndex = 16;
            // 
            // runMethod
            // 
            this.runMethod.Location = new System.Drawing.Point(346, 150);
            this.runMethod.Name = "runMethod";
            this.runMethod.Size = new System.Drawing.Size(88, 44);
            this.runMethod.TabIndex = 15;
            this.runMethod.Text = "Запустить метод";
            this.runMethod.UseVisualStyleBackColor = true;
            this.runMethod.Click += new System.EventHandler(this.runMethod_Click);
            // 
            // inputParams
            // 
            this.inputParams.Location = new System.Drawing.Point(239, 150);
            this.inputParams.Name = "inputParams";
            this.inputParams.Size = new System.Drawing.Size(90, 44);
            this.inputParams.TabIndex = 14;
            this.inputParams.Text = "ввести параметры";
            this.inputParams.UseVisualStyleBackColor = true;
            this.inputParams.Click += new System.EventHandler(this.inputParams_Click);
            // 
            // createObj
            // 
            this.createObj.Location = new System.Drawing.Point(34, 220);
            this.createObj.Name = "createObj";
            this.createObj.Size = new System.Drawing.Size(75, 23);
            this.createObj.TabIndex = 13;
            this.createObj.Text = "Создать";
            this.createObj.UseVisualStyleBackColor = true;
            this.createObj.Click += new System.EventHandler(this.createObj_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(87, 180);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 309);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.methods_params);
            this.Controls.Add(this.objects);
            this.Controls.Add(this.runMethod);
            this.Controls.Add(this.inputParams);
            this.Controls.Add(this.createObj);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox methods_params;
        private System.Windows.Forms.ListBox objects;
        private System.Windows.Forms.Button runMethod;
        private System.Windows.Forms.Button inputParams;
        private System.Windows.Forms.Button createObj;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

