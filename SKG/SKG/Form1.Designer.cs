namespace SKG
{
    partial class FormFigure
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFigure));
            this.labelSize = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelRotationSpeed = new System.Windows.Forms.Label();
            this.trackBarsize = new System.Windows.Forms.TrackBar();
            this.trackBarspeed = new System.Windows.Forms.TrackBar();
            this.trackBarrotation = new System.Windows.Forms.TrackBar();
            this.buttonstir = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttondefault = new System.Windows.Forms.Button();
            this.buttondepict = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelStarting = new System.Windows.Forms.Label();
            this.labelStartingDirection = new System.Windows.Forms.Label();
            this.labelStartingX = new System.Windows.Forms.Label();
            this.labelStartingY = new System.Windows.Forms.Label();
            this.labelStartingDirectionX = new System.Windows.Forms.Label();
            this.labelStartingDirectionY = new System.Windows.Forms.Label();
            this.textBoxStartingX = new System.Windows.Forms.TextBox();
            this.textBoxStartingY = new System.Windows.Forms.TextBox();
            this.textBoxStartingEnterCoordX = new System.Windows.Forms.TextBox();
            this.textBoxStartingEnterCoordY = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelErrors = new System.Windows.Forms.Label();
            this.ErrorText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarspeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarrotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(546, 31);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(90, 13);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "Размер фигуры:";
            this.labelSize.Click += new System.EventHandler(this.labelSize_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(546, 95);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(99, 13);
            this.labelSpeed.TabIndex = 1;
            this.labelSpeed.Text = "Скорость фигуры:";
            // 
            // labelRotationSpeed
            // 
            this.labelRotationSpeed.AutoSize = true;
            this.labelRotationSpeed.Location = new System.Drawing.Point(546, 160);
            this.labelRotationSpeed.Name = "labelRotationSpeed";
            this.labelRotationSpeed.Size = new System.Drawing.Size(112, 13);
            this.labelRotationSpeed.TabIndex = 2;
            this.labelRotationSpeed.Text = "Скорость вращения:";
            // 
            // trackBarsize
            // 
            this.trackBarsize.Location = new System.Drawing.Point(545, 47);
            this.trackBarsize.Maximum = 80;
            this.trackBarsize.Minimum = 40;
            this.trackBarsize.Name = "trackBarsize";
            this.trackBarsize.Size = new System.Drawing.Size(124, 45);
            this.trackBarsize.TabIndex = 6;
            this.trackBarsize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarsize.Value = 40;
            this.trackBarsize.Scroll += new System.EventHandler(this.trackBarsize_Scroll);
            // 
            // trackBarspeed
            // 
            this.trackBarspeed.Location = new System.Drawing.Point(545, 113);
            this.trackBarspeed.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarspeed.Maximum = 5;
            this.trackBarspeed.Minimum = 1;
            this.trackBarspeed.Name = "trackBarspeed";
            this.trackBarspeed.Size = new System.Drawing.Size(124, 45);
            this.trackBarspeed.SmallChange = 5;
            this.trackBarspeed.TabIndex = 8;
            this.trackBarspeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarspeed.Value = 1;
            this.trackBarspeed.Scroll += new System.EventHandler(this.trackBarspeed_Scroll);
            // 
            // trackBarrotation
            // 
            this.trackBarrotation.Location = new System.Drawing.Point(545, 175);
            this.trackBarrotation.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarrotation.Maximum = 5;
            this.trackBarrotation.Minimum = 1;
            this.trackBarrotation.Name = "trackBarrotation";
            this.trackBarrotation.Size = new System.Drawing.Size(124, 45);
            this.trackBarrotation.TabIndex = 10;
            this.trackBarrotation.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarrotation.Value = 1;
            this.trackBarrotation.Scroll += new System.EventHandler(this.trackBarRotationSpeed_Scroll);
            // 
            // buttonstir
            // 
            this.buttonstir.Location = new System.Drawing.Point(545, 216);
            this.buttonstir.Name = "buttonstir";
            this.buttonstir.Size = new System.Drawing.Size(277, 29);
            this.buttonstir.TabIndex = 13;
            this.buttonstir.Text = "Старт/движения";
            this.buttonstir.UseVisualStyleBackColor = true;
            this.buttonstir.Click += new System.EventHandler(this.buttonstir_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(546, 251);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(277, 29);
            this.buttonStop.TabIndex = 14;
            this.buttonStop.Text = "В начало";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttondefault
            // 
            this.buttondefault.Location = new System.Drawing.Point(546, 286);
            this.buttondefault.Name = "buttondefault";
            this.buttondefault.Size = new System.Drawing.Size(276, 34);
            this.buttondefault.TabIndex = 15;
            this.buttondefault.Text = "По умолчанию (размер)";
            this.buttondefault.UseVisualStyleBackColor = true;
            this.buttondefault.Click += new System.EventHandler(this.buttondefault_Click);
            // 
            // buttondepict
            // 
            this.buttondepict.Location = new System.Drawing.Point(696, 70);
            this.buttondepict.Name = "buttondepict";
            this.buttondepict.Size = new System.Drawing.Size(128, 33);
            this.buttondepict.TabIndex = 16;
            this.buttondepict.Text = "Нарисовать";
            this.buttondepict.UseVisualStyleBackColor = true;
            this.buttondepict.Click += new System.EventHandler(this.buttondepict_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Траектория ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelStarting
            // 
            this.labelStarting.AutoSize = true;
            this.labelStarting.Location = new System.Drawing.Point(693, 31);
            this.labelStarting.Name = "labelStarting";
            this.labelStarting.Size = new System.Drawing.Size(131, 13);
            this.labelStarting.TabIndex = 18;
            this.labelStarting.Text = "Начальные координаты:";
            // 
            // labelStartingDirection
            // 
            this.labelStartingDirection.AutoSize = true;
            this.labelStartingDirection.Location = new System.Drawing.Point(693, 106);
            this.labelStartingDirection.Name = "labelStartingDirection";
            this.labelStartingDirection.Size = new System.Drawing.Size(134, 13);
            this.labelStartingDirection.TabIndex = 19;
            this.labelStartingDirection.Text = "Начальное направление:";
            // 
            // labelStartingX
            // 
            this.labelStartingX.AutoSize = true;
            this.labelStartingX.Location = new System.Drawing.Point(705, 54);
            this.labelStartingX.Name = "labelStartingX";
            this.labelStartingX.Size = new System.Drawing.Size(17, 13);
            this.labelStartingX.TabIndex = 20;
            this.labelStartingX.Text = "X:";
            // 
            // labelStartingY
            // 
            this.labelStartingY.AutoSize = true;
            this.labelStartingY.Location = new System.Drawing.Point(763, 54);
            this.labelStartingY.Name = "labelStartingY";
            this.labelStartingY.Size = new System.Drawing.Size(17, 13);
            this.labelStartingY.TabIndex = 21;
            this.labelStartingY.Text = "Y:";
            // 
            // labelStartingDirectionX
            // 
            this.labelStartingDirectionX.AutoSize = true;
            this.labelStartingDirectionX.Location = new System.Drawing.Point(705, 129);
            this.labelStartingDirectionX.Name = "labelStartingDirectionX";
            this.labelStartingDirectionX.Size = new System.Drawing.Size(17, 13);
            this.labelStartingDirectionX.TabIndex = 22;
            this.labelStartingDirectionX.Text = "X:";
            // 
            // labelStartingDirectionY
            // 
            this.labelStartingDirectionY.AutoSize = true;
            this.labelStartingDirectionY.Location = new System.Drawing.Point(763, 129);
            this.labelStartingDirectionY.Name = "labelStartingDirectionY";
            this.labelStartingDirectionY.Size = new System.Drawing.Size(17, 13);
            this.labelStartingDirectionY.TabIndex = 23;
            this.labelStartingDirectionY.Text = "Y:";
            // 
            // textBoxStartingX
            // 
            this.textBoxStartingX.Location = new System.Drawing.Point(728, 48);
            this.textBoxStartingX.Name = "textBoxStartingX";
            this.textBoxStartingX.Size = new System.Drawing.Size(29, 20);
            this.textBoxStartingX.TabIndex = 24;
            this.textBoxStartingX.TextChanged += new System.EventHandler(this.textBoxStartingX_TextChanged);
            // 
            // textBoxStartingY
            // 
            this.textBoxStartingY.Location = new System.Drawing.Point(786, 48);
            this.textBoxStartingY.Name = "textBoxStartingY";
            this.textBoxStartingY.Size = new System.Drawing.Size(29, 20);
            this.textBoxStartingY.TabIndex = 27;
            this.textBoxStartingY.TextChanged += new System.EventHandler(this.textBoxStartingY_TextChanged);
            // 
            // textBoxStartingEnterCoordX
            // 
            this.textBoxStartingEnterCoordX.Location = new System.Drawing.Point(728, 122);
            this.textBoxStartingEnterCoordX.Name = "textBoxStartingEnterCoordX";
            this.textBoxStartingEnterCoordX.Size = new System.Drawing.Size(29, 20);
            this.textBoxStartingEnterCoordX.TabIndex = 28;
            this.textBoxStartingEnterCoordX.TextChanged += new System.EventHandler(this.textBoxStartingEnterCoordX_TextChanged);
            // 
            // textBoxStartingEnterCoordY
            // 
            this.textBoxStartingEnterCoordY.Location = new System.Drawing.Point(786, 122);
            this.textBoxStartingEnterCoordY.Name = "textBoxStartingEnterCoordY";
            this.textBoxStartingEnterCoordY.Size = new System.Drawing.Size(29, 20);
            this.textBoxStartingEnterCoordY.TabIndex = 29;
            this.textBoxStartingEnterCoordY.TextChanged += new System.EventHandler(this.textBoxStartingEnterCoordY_TextChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(9, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(531, 308);
            this.pictureBox.TabIndex = 30;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click_1);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.ForeColor = System.Drawing.Color.Navy;
            this.labelErrors.Location = new System.Drawing.Point(15, 329);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(0, 13);
            this.labelErrors.TabIndex = 31;
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.ForeColor = System.Drawing.Color.Navy;
            this.ErrorText.Location = new System.Drawing.Point(12, 323);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(76, 13);
            this.ErrorText.TabIndex = 32;
            this.ErrorText.Text = "Ошибок нет...";
            // 
            // FormFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(834, 340);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBoxStartingEnterCoordY);
            this.Controls.Add(this.textBoxStartingEnterCoordX);
            this.Controls.Add(this.textBoxStartingY);
            this.Controls.Add(this.textBoxStartingX);
            this.Controls.Add(this.labelStartingDirectionY);
            this.Controls.Add(this.labelStartingDirectionX);
            this.Controls.Add(this.labelStartingY);
            this.Controls.Add(this.labelStartingX);
            this.Controls.Add(this.labelStartingDirection);
            this.Controls.Add(this.labelStarting);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttondepict);
            this.Controls.Add(this.buttondefault);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonstir);
            this.Controls.Add(this.trackBarrotation);
            this.Controls.Add(this.trackBarspeed);
            this.Controls.Add(this.trackBarsize);
            this.Controls.Add(this.labelRotationSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFigure";
            this.Text = "Графика";
            this.Load += new System.EventHandler(this.FormFigure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarspeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarrotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelRotationSpeed;
        private System.Windows.Forms.TrackBar trackBarsize;
        private System.Windows.Forms.TrackBar trackBarspeed;
        private System.Windows.Forms.TrackBar trackBarrotation;
        private System.Windows.Forms.Button buttonstir;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttondefault;
        private System.Windows.Forms.Button buttondepict;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelStarting;
        private System.Windows.Forms.Label labelStartingDirection;
        private System.Windows.Forms.Label labelStartingX;
        private System.Windows.Forms.Label labelStartingY;
        private System.Windows.Forms.Label labelStartingDirectionX;
        private System.Windows.Forms.Label labelStartingDirectionY;
        private System.Windows.Forms.TextBox textBoxStartingX;
        private System.Windows.Forms.TextBox textBoxStartingY;
        private System.Windows.Forms.TextBox textBoxStartingEnterCoordX;
        private System.Windows.Forms.TextBox textBoxStartingEnterCoordY;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.Label ErrorText;
    }
}

