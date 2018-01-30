namespace HydroPlasma.Forms
{
    partial class Plasam2Explosive
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartMaxPre = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalcMaxPre = new System.Windows.Forms.Button();
            this.tbliquedType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCapacityNum = new System.Windows.Forms.TextBox();
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbComplexFuncBeita = new System.Windows.Forms.TextBox();
            this.tbExplosiveDen = new System.Windows.Forms.Label();
            this.tbExplosiveType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutPutVol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbProbeLen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPulseUptime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPulseWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbExplosiveWeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnSaveImg = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxPre)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartMaxPre);
            this.groupBox2.Location = new System.Drawing.Point(5, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1115, 555);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "计算结果";
            // 
            // chartMaxPre
            // 
            chartArea6.Name = "ChartArea1";
            this.chartMaxPre.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartMaxPre.Legends.Add(legend6);
            this.chartMaxPre.Location = new System.Drawing.Point(16, 24);
            this.chartMaxPre.Name = "chartMaxPre";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartMaxPre.Series.Add(series6);
            this.chartMaxPre.Size = new System.Drawing.Size(1085, 512);
            this.chartMaxPre.TabIndex = 0;
            this.chartMaxPre.Text = "液相冲击波峰值压力图";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveData);
            this.groupBox1.Controls.Add(this.btnSaveImg);
            this.groupBox1.Controls.Add(this.tbPulseWidth);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbPulseUptime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbProbeLen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.OutPutVol);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnCalcMaxPre);
            this.groupBox1.Controls.Add(this.tbliquedType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbCapacityNum);
            this.groupBox1.Controls.Add(this.tbCapacity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbComplexFuncBeita);
            this.groupBox1.Controls.Add(this.tbExplosiveDen);
            this.groupBox1.Controls.Add(this.tbExplosiveType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 226);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "计算参数";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(601, 153);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 56);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalcMaxPre
            // 
            this.btnCalcMaxPre.Location = new System.Drawing.Point(65, 153);
            this.btnCalcMaxPre.Name = "btnCalcMaxPre";
            this.btnCalcMaxPre.Size = new System.Drawing.Size(126, 57);
            this.btnCalcMaxPre.TabIndex = 16;
            this.btnCalcMaxPre.Text = "计算炸药量";
            this.btnCalcMaxPre.UseVisualStyleBackColor = true;
            this.btnCalcMaxPre.Click += new System.EventHandler(this.btnCalcMaxPre_Click);
            // 
            // tbliquedType
            // 
            this.tbliquedType.Location = new System.Drawing.Point(136, 110);
            this.tbliquedType.Name = "tbliquedType";
            this.tbliquedType.ReadOnly = true;
            this.tbliquedType.Size = new System.Drawing.Size(112, 25);
            this.tbliquedType.TabIndex = 11;
            this.tbliquedType.Text = "水";
            this.tbliquedType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "液体类型";
            // 
            // tbCapacityNum
            // 
            this.tbCapacityNum.Location = new System.Drawing.Point(391, 67);
            this.tbCapacityNum.Name = "tbCapacityNum";
            this.tbCapacityNum.Size = new System.Drawing.Size(113, 25);
            this.tbCapacityNum.TabIndex = 5;
            this.tbCapacityNum.Text = "10";
            this.tbCapacityNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCapacity
            // 
            this.tbCapacity.Location = new System.Drawing.Point(392, 26);
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.Size = new System.Drawing.Size(113, 25);
            this.tbCapacity.TabIndex = 9;
            this.tbCapacity.Text = "0.5";
            this.tbCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "电容个数 个";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "电容量 μF";
            // 
            // tbComplexFuncBeita
            // 
            this.tbComplexFuncBeita.Location = new System.Drawing.Point(136, 67);
            this.tbComplexFuncBeita.Name = "tbComplexFuncBeita";
            this.tbComplexFuncBeita.ReadOnly = true;
            this.tbComplexFuncBeita.Size = new System.Drawing.Size(112, 25);
            this.tbComplexFuncBeita.TabIndex = 7;
            this.tbComplexFuncBeita.Text = "1.8";
            this.tbComplexFuncBeita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbExplosiveDen
            // 
            this.tbExplosiveDen.AutoSize = true;
            this.tbExplosiveDen.Location = new System.Drawing.Point(7, 70);
            this.tbExplosiveDen.Name = "tbExplosiveDen";
            this.tbExplosiveDen.Size = new System.Drawing.Size(123, 15);
            this.tbExplosiveDen.TabIndex = 6;
            this.tbExplosiveDen.Text = "炸药密度  g/cm³";
            // 
            // tbExplosiveType
            // 
            this.tbExplosiveType.Enabled = false;
            this.tbExplosiveType.Location = new System.Drawing.Point(136, 28);
            this.tbExplosiveType.Name = "tbExplosiveType";
            this.tbExplosiveType.ReadOnly = true;
            this.tbExplosiveType.Size = new System.Drawing.Size(112, 25);
            this.tbExplosiveType.TabIndex = 1;
            this.tbExplosiveType.Text = "RDX";
            this.tbExplosiveType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "炸药类型";
            // 
            // OutPutVol
            // 
            this.OutPutVol.Location = new System.Drawing.Point(391, 111);
            this.OutPutVol.Name = "OutPutVol";
            this.OutPutVol.Size = new System.Drawing.Size(114, 25);
            this.OutPutVol.TabIndex = 20;
            this.OutPutVol.Text = "20";
            this.OutPutVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "输出电压 KV";
            // 
            // tbProbeLen
            // 
            this.tbProbeLen.Location = new System.Drawing.Point(663, 24);
            this.tbProbeLen.Name = "tbProbeLen";
            this.tbProbeLen.Size = new System.Drawing.Size(114, 25);
            this.tbProbeLen.TabIndex = 22;
            this.tbProbeLen.Text = "10";
            this.tbProbeLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "电极间距 mm";
            // 
            // tbPulseUptime
            // 
            this.tbPulseUptime.Location = new System.Drawing.Point(663, 65);
            this.tbPulseUptime.Name = "tbPulseUptime";
            this.tbPulseUptime.ReadOnly = true;
            this.tbPulseUptime.Size = new System.Drawing.Size(114, 25);
            this.tbPulseUptime.TabIndex = 24;
            this.tbPulseUptime.Text = "0.4";
            this.tbPulseUptime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "脉冲上升时间 μs";
            // 
            // tbPulseWidth
            // 
            this.tbPulseWidth.Location = new System.Drawing.Point(663, 108);
            this.tbPulseWidth.Name = "tbPulseWidth";
            this.tbPulseWidth.ReadOnly = true;
            this.tbPulseWidth.Size = new System.Drawing.Size(114, 25);
            this.tbPulseWidth.TabIndex = 26;
            this.tbPulseWidth.Text = "10";
            this.tbPulseWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "脉冲宽度 μs";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.tbExplosiveWeight);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(821, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 226);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "计算结果";
            // 
            // tbExplosiveWeight
            // 
            this.tbExplosiveWeight.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbExplosiveWeight.Location = new System.Drawing.Point(160, 51);
            this.tbExplosiveWeight.Name = "tbExplosiveWeight";
            this.tbExplosiveWeight.Size = new System.Drawing.Size(114, 38);
            this.tbExplosiveWeight.TabIndex = 28;
            this.tbExplosiveWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(41, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "炸药量 g";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 57);
            this.button1.TabIndex = 27;
            this.button1.Text = "开始绘图";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(251, 153);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(130, 57);
            this.btnSaveData.TabIndex = 28;
            this.btnSaveData.Text = "导出数据";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnSaveImg
            // 
            this.btnSaveImg.Location = new System.Drawing.Point(427, 153);
            this.btnSaveImg.Name = "btnSaveImg";
            this.btnSaveImg.Size = new System.Drawing.Size(122, 56);
            this.btnSaveImg.TabIndex = 27;
            this.btnSaveImg.Text = "保存图片";
            this.btnSaveImg.UseVisualStyleBackColor = true;
            this.btnSaveImg.Click += new System.EventHandler(this.btnSaveImg_Click);
            // 
            // Plasam2Explosive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 811);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Plasam2Explosive";
            this.Text = "液相放电和炸药转换";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxPre)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMaxPre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPulseWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPulseUptime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProbeLen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutPutVol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCalcMaxPre;
        private System.Windows.Forms.TextBox tbliquedType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCapacityNum;
        private System.Windows.Forms.TextBox tbCapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbComplexFuncBeita;
        private System.Windows.Forms.Label tbExplosiveDen;
        private System.Windows.Forms.TextBox tbExplosiveType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbExplosiveWeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnSaveImg;
    }
}