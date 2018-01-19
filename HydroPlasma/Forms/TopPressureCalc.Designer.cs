namespace HydroPlasma.Forms
{
    partial class TopPressureCalc
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDensity = new System.Windows.Forms.TextBox();
            this.tbPulseUpTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPulseWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbComplexFuncBeita = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCapacityVal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCapacityNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOutputVoltage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMinProbeLength = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMaxProbeLength = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalcMaxPre = new System.Windows.Forms.Button();
            this.btnSaveImg = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartMaxPre = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxPre)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveData);
            this.groupBox1.Controls.Add(this.btnSaveImg);
            this.groupBox1.Controls.Add(this.btnCalcMaxPre);
            this.groupBox1.Controls.Add(this.tbMaxProbeLength);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbMinProbeLength);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbOutputVoltage);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbCapacityNum);
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
            this.groupBox1.Size = new System.Drawing.Size(775, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "计算参数";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // tbDensity
            // 
            this.tbDensity.Location = new System.Drawing.Point(142, 25);
            this.tbDensity.Name = "tbDensity";
            this.tbDensity.Size = new System.Drawing.Size(100, 25);
            this.tbDensity.TabIndex = 1;
            // 
            // tbPulseUpTime
            // 
            this.tbPulseUpTime.Location = new System.Drawing.Point(143, 72);
            this.tbPulseUpTime.Name = "tbPulseUpTime";
            this.tbPulseUpTime.Size = new System.Drawing.Size(100, 25);
            this.tbPulseUpTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "脉冲上升沿 μs";
            // 
            // tbPulseWidth
            // 
            this.tbPulseWidth.Location = new System.Drawing.Point(143, 115);
            this.tbPulseWidth.Name = "tbPulseWidth";
            this.tbPulseWidth.Size = new System.Drawing.Size(100, 25);
            this.tbPulseWidth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "脉冲宽度 μs";
            // 
            // tbComplexFuncBeita
            // 
            this.tbComplexFuncBeita.Location = new System.Drawing.Point(142, 148);
            this.tbComplexFuncBeita.Name = "tbComplexFuncBeita";
            this.tbComplexFuncBeita.Size = new System.Drawing.Size(100, 25);
            this.tbComplexFuncBeita.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "复杂积分函数β";
            // 
            // tbCapacityVal
            // 
            this.tbCapacityVal.Location = new System.Drawing.Point(379, 25);
            this.tbCapacityVal.Name = "tbCapacityVal";
            this.tbCapacityVal.Size = new System.Drawing.Size(100, 25);
            this.tbCapacityVal.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "每级电容量 μF";
            // 
            // tbCapacityNum
            // 
            this.tbCapacityNum.Location = new System.Drawing.Point(379, 72);
            this.tbCapacityNum.Name = "tbCapacityNum";
            this.tbCapacityNum.Size = new System.Drawing.Size(100, 25);
            this.tbCapacityNum.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "电容个数 个";
            // 
            // tbOutputVoltage
            // 
            this.tbOutputVoltage.Location = new System.Drawing.Point(379, 115);
            this.tbOutputVoltage.Name = "tbOutputVoltage";
            this.tbOutputVoltage.Size = new System.Drawing.Size(100, 25);
            this.tbOutputVoltage.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "输出电压 kV";
            // 
            // tbMinProbeLength
            // 
            this.tbMinProbeLength.Location = new System.Drawing.Point(379, 148);
            this.tbMinProbeLength.Name = "tbMinProbeLength";
            this.tbMinProbeLength.Size = new System.Drawing.Size(100, 25);
            this.tbMinProbeLength.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "电极最小间距 mm";
            // 
            // tbMaxProbeLength
            // 
            this.tbMaxProbeLength.Location = new System.Drawing.Point(610, 18);
            this.tbMaxProbeLength.Name = "tbMaxProbeLength";
            this.tbMaxProbeLength.Size = new System.Drawing.Size(100, 25);
            this.tbMaxProbeLength.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(485, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "电极最大间距 mm";
            // 
            // btnCalcMaxPre
            // 
            this.btnCalcMaxPre.Location = new System.Drawing.Point(554, 77);
            this.btnCalcMaxPre.Name = "btnCalcMaxPre";
            this.btnCalcMaxPre.Size = new System.Drawing.Size(109, 23);
            this.btnCalcMaxPre.TabIndex = 16;
            this.btnCalcMaxPre.Text = "开始计算";
            this.btnCalcMaxPre.UseVisualStyleBackColor = true;
            // 
            // btnSaveImg
            // 
            this.btnSaveImg.Location = new System.Drawing.Point(554, 158);
            this.btnSaveImg.Name = "btnSaveImg";
            this.btnSaveImg.Size = new System.Drawing.Size(109, 23);
            this.btnSaveImg.TabIndex = 17;
            this.btnSaveImg.Text = "保存图片";
            this.btnSaveImg.UseVisualStyleBackColor = true;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(554, 120);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(109, 23);
            this.btnSaveData.TabIndex = 18;
            this.btnSaveData.Text = "导出数据";
            this.btnSaveData.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartMaxPre);
            this.groupBox2.Location = new System.Drawing.Point(12, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 357);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "计算结果";
            // 
            // chartMaxPre
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMaxPre.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMaxPre.Legends.Add(legend1);
            this.chartMaxPre.Location = new System.Drawing.Point(10, 24);
            this.chartMaxPre.Name = "chartMaxPre";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMaxPre.Series.Add(series1);
            this.chartMaxPre.Size = new System.Drawing.Size(759, 327);
            this.chartMaxPre.TabIndex = 0;
            this.chartMaxPre.Text = "液相冲击波峰值压力图";
            // 
            // TopPressureCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 581);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TopPressureCalc";
            this.Text = "液相冲击波峰值压力计算";
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
        private System.Windows.Forms.TextBox tbCapacityNum;
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
    }
}