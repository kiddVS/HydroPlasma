namespace HydroPlasma.Forms
{
    partial class TopPressureCalcForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbLineNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCapacityMaxNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnSaveImg = new System.Windows.Forms.Button();
            this.btnCalcMaxPre = new System.Windows.Forms.Button();
            this.tbMaxProbeLength = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMinProbeLength = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbOutputVoltage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCapacityMinNum = new System.Windows.Forms.TextBox();
            this.tbCapacityVal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbComplexFuncBeita = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPulseWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPulseUpTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDensity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartMaxPre = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxPre)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbLineNum);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbCapacityMaxNum);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnSaveData);
            this.groupBox1.Controls.Add(this.btnSaveImg);
            this.groupBox1.Controls.Add(this.btnCalcMaxPre);
            this.groupBox1.Controls.Add(this.tbMaxProbeLength);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbMinProbeLength);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbOutputVoltage);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbCapacityMinNum);
            this.groupBox1.Controls.Add(this.tbCapacityVal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbComplexFuncBeita);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbPulseWidth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPulseUpTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDensity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1101, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "计算参数";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(821, 153);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 57);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "电容器储存能量",
            "电极间距"});
            this.comboBox1.Location = new System.Drawing.Point(935, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 23);
            this.comboBox1.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(806, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "横坐标";
            // 
            // tbLineNum
            // 
            this.tbLineNum.Location = new System.Drawing.Point(640, 110);
            this.tbLineNum.Name = "tbLineNum";
            this.tbLineNum.Size = new System.Drawing.Size(144, 25);
            this.tbLineNum.TabIndex = 22;
            this.tbLineNum.Text = "3";
            this.tbLineNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(515, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "线型条数 ";
            // 
            // tbCapacityMaxNum
            // 
            this.tbCapacityMaxNum.Location = new System.Drawing.Point(391, 111);
            this.tbCapacityMaxNum.Name = "tbCapacityMaxNum";
            this.tbCapacityMaxNum.Size = new System.Drawing.Size(114, 25);
            this.tbCapacityMaxNum.TabIndex = 20;
            this.tbCapacityMaxNum.Text = "10";
            this.tbCapacityMaxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "电容最大个数 个";
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(362, 153);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(130, 57);
            this.btnSaveData.TabIndex = 18;
            this.btnSaveData.Text = "导出数据";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnSaveImg
            // 
            this.btnSaveImg.Location = new System.Drawing.Point(593, 153);
            this.btnSaveImg.Name = "btnSaveImg";
            this.btnSaveImg.Size = new System.Drawing.Size(122, 57);
            this.btnSaveImg.TabIndex = 17;
            this.btnSaveImg.Text = "保存图片";
            this.btnSaveImg.UseVisualStyleBackColor = true;
            this.btnSaveImg.Click += new System.EventHandler(this.btnSaveImg_Click);
            // 
            // btnCalcMaxPre
            // 
            this.btnCalcMaxPre.Location = new System.Drawing.Point(159, 153);
            this.btnCalcMaxPre.Name = "btnCalcMaxPre";
            this.btnCalcMaxPre.Size = new System.Drawing.Size(126, 57);
            this.btnCalcMaxPre.TabIndex = 16;
            this.btnCalcMaxPre.Text = "开始计算";
            this.btnCalcMaxPre.UseVisualStyleBackColor = true;
            this.btnCalcMaxPre.Click += new System.EventHandler(this.btnCalcMaxPre_Click);
            // 
            // tbMaxProbeLength
            // 
            this.tbMaxProbeLength.Location = new System.Drawing.Point(640, 67);
            this.tbMaxProbeLength.Name = "tbMaxProbeLength";
            this.tbMaxProbeLength.Size = new System.Drawing.Size(144, 25);
            this.tbMaxProbeLength.TabIndex = 15;
            this.tbMaxProbeLength.Text = "30";
            this.tbMaxProbeLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(513, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "电极最大间距 mm";
            // 
            // tbMinProbeLength
            // 
            this.tbMinProbeLength.Location = new System.Drawing.Point(640, 25);
            this.tbMinProbeLength.Name = "tbMinProbeLength";
            this.tbMinProbeLength.Size = new System.Drawing.Size(144, 25);
            this.tbMinProbeLength.TabIndex = 13;
            this.tbMinProbeLength.Text = "10";
            this.tbMinProbeLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(513, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "电极最小间距 mm";
            // 
            // tbOutputVoltage
            // 
            this.tbOutputVoltage.Location = new System.Drawing.Point(136, 110);
            this.tbOutputVoltage.Name = "tbOutputVoltage";
            this.tbOutputVoltage.Size = new System.Drawing.Size(112, 25);
            this.tbOutputVoltage.TabIndex = 11;
            this.tbOutputVoltage.Text = "20";
            this.tbOutputVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "输出电压 kV";
            // 
            // tbCapacityMinNum
            // 
            this.tbCapacityMinNum.Location = new System.Drawing.Point(391, 67);
            this.tbCapacityMinNum.Name = "tbCapacityMinNum";
            this.tbCapacityMinNum.Size = new System.Drawing.Size(113, 25);
            this.tbCapacityMinNum.TabIndex = 5;
            this.tbCapacityMinNum.Text = "1";
            this.tbCapacityMinNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCapacityVal
            // 
            this.tbCapacityVal.Location = new System.Drawing.Point(392, 26);
            this.tbCapacityVal.Name = "tbCapacityVal";
            this.tbCapacityVal.Size = new System.Drawing.Size(113, 25);
            this.tbCapacityVal.TabIndex = 9;
            this.tbCapacityVal.Text = "0.5";
            this.tbCapacityVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "电容最小个数 个";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "每级电容量 μF";
            // 
            // tbComplexFuncBeita
            // 
            this.tbComplexFuncBeita.Location = new System.Drawing.Point(136, 67);
            this.tbComplexFuncBeita.Name = "tbComplexFuncBeita";
            this.tbComplexFuncBeita.Size = new System.Drawing.Size(112, 25);
            this.tbComplexFuncBeita.TabIndex = 7;
            this.tbComplexFuncBeita.Text = "0.7";
            this.tbComplexFuncBeita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "复杂积分函数β";
            // 
            // tbPulseWidth
            // 
            this.tbPulseWidth.Location = new System.Drawing.Point(935, 62);
            this.tbPulseWidth.Name = "tbPulseWidth";
            this.tbPulseWidth.Size = new System.Drawing.Size(144, 25);
            this.tbPulseWidth.TabIndex = 5;
            this.tbPulseWidth.Text = "20";
            this.tbPulseWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(806, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "脉冲宽度 μs";
            // 
            // tbPulseUpTime
            // 
            this.tbPulseUpTime.Location = new System.Drawing.Point(935, 25);
            this.tbPulseUpTime.Name = "tbPulseUpTime";
            this.tbPulseUpTime.Size = new System.Drawing.Size(144, 25);
            this.tbPulseUpTime.TabIndex = 3;
            this.tbPulseUpTime.Text = "8";
            this.tbPulseUpTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(806, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "脉冲上升沿 μs";
            // 
            // tbDensity
            // 
            this.tbDensity.Location = new System.Drawing.Point(136, 28);
            this.tbDensity.Name = "tbDensity";
            this.tbDensity.Size = new System.Drawing.Size(112, 25);
            this.tbDensity.TabIndex = 1;
            this.tbDensity.Text = "1000";
            this.tbDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "液体密度 kg/cm³";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartMaxPre);
            this.groupBox2.Location = new System.Drawing.Point(12, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1115, 555);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "计算结果";
            // 
            // chartMaxPre
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMaxPre.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMaxPre.Legends.Add(legend2);
            this.chartMaxPre.Location = new System.Drawing.Point(16, 24);
            this.chartMaxPre.Name = "chartMaxPre";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMaxPre.Series.Add(series2);
            this.chartMaxPre.Size = new System.Drawing.Size(1085, 512);
            this.chartMaxPre.TabIndex = 0;
            this.chartMaxPre.Text = "液相冲击波峰值压力图";
            // 
            // TopPressureCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 811);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TopPressureCalcForm";
            this.Text = "液相冲击波峰值压力计算";
            this.Load += new System.EventHandler(this.TopPressureCalcForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxPre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbOutputVoltage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCapacityMinNum;
        private System.Windows.Forms.TextBox tbCapacityVal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbComplexFuncBeita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPulseWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPulseUpTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDensity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMinProbeLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnSaveImg;
        private System.Windows.Forms.Button btnCalcMaxPre;
        private System.Windows.Forms.TextBox tbMaxProbeLength;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMaxPre;
        private System.Windows.Forms.TextBox tbCapacityMaxNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbLineNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnExit;
    }
}