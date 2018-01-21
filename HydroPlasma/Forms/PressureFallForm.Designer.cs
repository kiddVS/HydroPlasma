namespace HydroPlasma.Forms
{
    partial class PressureFallForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbLineNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbZhengLiuEfficent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnSaveImg = new System.Windows.Forms.Button();
            this.btnCalcShuaiJian = new System.Windows.Forms.Button();
            this.tbMaxProbeLength = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMinProbeLength = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbShuDianEfficient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBianYaEfficient = new System.Windows.Forms.TextBox();
            this.tbCapacityEnergy = new System.Windows.Forms.TextBox();
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
            this.tbShuaiJianCons = new System.Windows.Forms.TextBox();
            this.tbWaveSpeed = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbEle2WaveEfficient = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbMaxLen = new System.Windows.Forms.TextBox();
            this.tbMinLen = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxPre)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbWaveSpeed);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbEle2WaveEfficient);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbMaxLen);
            this.groupBox1.Controls.Add(this.tbMinLen);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tbShuaiJianCons);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbLineNum);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbZhengLiuEfficent);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnSaveData);
            this.groupBox1.Controls.Add(this.btnSaveImg);
            this.groupBox1.Controls.Add(this.btnCalcShuaiJian);
            this.groupBox1.Controls.Add(this.tbMaxProbeLength);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbMinProbeLength);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbShuDianEfficient);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbBianYaEfficient);
            this.groupBox1.Controls.Add(this.tbCapacityEnergy);
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
            this.groupBox1.Location = new System.Drawing.Point(7, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(813, 202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "计算参数";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(537, 154);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 33);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(375, 121);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "指数衰减常数";
            // 
            // tbLineNum
            // 
            this.tbLineNum.Location = new System.Drawing.Point(469, 88);
            this.tbLineNum.Margin = new System.Windows.Forms.Padding(2);
            this.tbLineNum.Name = "tbLineNum";
            this.tbLineNum.Size = new System.Drawing.Size(109, 21);
            this.tbLineNum.TabIndex = 22;
            this.tbLineNum.Text = "3";
            this.tbLineNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(375, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "线型条数 ";
            // 
            // tbZhengLiuEfficent
            // 
            this.tbZhengLiuEfficent.Location = new System.Drawing.Point(285, 88);
            this.tbZhengLiuEfficent.Margin = new System.Windows.Forms.Padding(2);
            this.tbZhengLiuEfficent.Name = "tbZhengLiuEfficent";
            this.tbZhengLiuEfficent.Size = new System.Drawing.Size(86, 21);
            this.tbZhengLiuEfficent.TabIndex = 20;
            this.tbZhengLiuEfficent.Text = "0.9";
            this.tbZhengLiuEfficent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "整流器效率";
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(267, 154);
            this.btnSaveData.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(82, 33);
            this.btnSaveData.TabIndex = 18;
            this.btnSaveData.Text = "导出数据";
            this.btnSaveData.UseVisualStyleBackColor = true;
            // 
            // btnSaveImg
            // 
            this.btnSaveImg.Location = new System.Drawing.Point(400, 154);
            this.btnSaveImg.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveImg.Name = "btnSaveImg";
            this.btnSaveImg.Size = new System.Drawing.Size(82, 33);
            this.btnSaveImg.TabIndex = 17;
            this.btnSaveImg.Text = "保存图片";
            this.btnSaveImg.UseVisualStyleBackColor = true;
            // 
            // btnCalcShuaiJian
            // 
            this.btnCalcShuaiJian.Location = new System.Drawing.Point(122, 154);
            this.btnCalcShuaiJian.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcShuaiJian.Name = "btnCalcShuaiJian";
            this.btnCalcShuaiJian.Size = new System.Drawing.Size(82, 33);
            this.btnCalcShuaiJian.TabIndex = 16;
            this.btnCalcShuaiJian.Text = "开始计算";
            this.btnCalcShuaiJian.UseVisualStyleBackColor = true;
            this.btnCalcShuaiJian.Click += new System.EventHandler(this.btnCalcShuaiJian_Click);
            // 
            // tbMaxProbeLength
            // 
            this.tbMaxProbeLength.Location = new System.Drawing.Point(469, 54);
            this.tbMaxProbeLength.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaxProbeLength.Name = "tbMaxProbeLength";
            this.tbMaxProbeLength.Size = new System.Drawing.Size(109, 21);
            this.tbMaxProbeLength.TabIndex = 15;
            this.tbMaxProbeLength.Text = "30";
            this.tbMaxProbeLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(374, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "电极最大间距 mm";
            // 
            // tbMinProbeLength
            // 
            this.tbMinProbeLength.Location = new System.Drawing.Point(469, 20);
            this.tbMinProbeLength.Margin = new System.Windows.Forms.Padding(2);
            this.tbMinProbeLength.Name = "tbMinProbeLength";
            this.tbMinProbeLength.Size = new System.Drawing.Size(109, 21);
            this.tbMinProbeLength.TabIndex = 13;
            this.tbMinProbeLength.Text = "10";
            this.tbMinProbeLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "电极最小间距 mm";
            // 
            // tbShuDianEfficient
            // 
            this.tbShuDianEfficient.Location = new System.Drawing.Point(284, 118);
            this.tbShuDianEfficient.Margin = new System.Windows.Forms.Padding(2);
            this.tbShuDianEfficient.Name = "tbShuDianEfficient";
            this.tbShuDianEfficient.Size = new System.Drawing.Size(87, 21);
            this.tbShuDianEfficient.TabIndex = 11;
            this.tbShuDianEfficient.Text = "0.9";
            this.tbShuDianEfficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "输电线效率";
            // 
            // tbBianYaEfficient
            // 
            this.tbBianYaEfficient.Location = new System.Drawing.Point(284, 58);
            this.tbBianYaEfficient.Margin = new System.Windows.Forms.Padding(2);
            this.tbBianYaEfficient.Name = "tbBianYaEfficient";
            this.tbBianYaEfficient.Size = new System.Drawing.Size(86, 21);
            this.tbBianYaEfficient.TabIndex = 5;
            this.tbBianYaEfficient.Text = "0.9";
            this.tbBianYaEfficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCapacityEnergy
            // 
            this.tbCapacityEnergy.Location = new System.Drawing.Point(284, 20);
            this.tbCapacityEnergy.Margin = new System.Windows.Forms.Padding(2);
            this.tbCapacityEnergy.Name = "tbCapacityEnergy";
            this.tbCapacityEnergy.Size = new System.Drawing.Size(86, 21);
            this.tbCapacityEnergy.TabIndex = 9;
            this.tbCapacityEnergy.Text = "1000";
            this.tbCapacityEnergy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "变压器效率";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "电容储能 J";
            // 
            // tbComplexFuncBeita
            // 
            this.tbComplexFuncBeita.Location = new System.Drawing.Point(102, 118);
            this.tbComplexFuncBeita.Margin = new System.Windows.Forms.Padding(2);
            this.tbComplexFuncBeita.Name = "tbComplexFuncBeita";
            this.tbComplexFuncBeita.Size = new System.Drawing.Size(85, 21);
            this.tbComplexFuncBeita.TabIndex = 7;
            this.tbComplexFuncBeita.Text = "0.7";
            this.tbComplexFuncBeita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "复杂积分函数β";
            // 
            // tbPulseWidth
            // 
            this.tbPulseWidth.Location = new System.Drawing.Point(102, 88);
            this.tbPulseWidth.Margin = new System.Windows.Forms.Padding(2);
            this.tbPulseWidth.Name = "tbPulseWidth";
            this.tbPulseWidth.Size = new System.Drawing.Size(85, 21);
            this.tbPulseWidth.TabIndex = 5;
            this.tbPulseWidth.Text = "20";
            this.tbPulseWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "脉冲宽度 μs";
            // 
            // tbPulseUpTime
            // 
            this.tbPulseUpTime.Location = new System.Drawing.Point(102, 58);
            this.tbPulseUpTime.Margin = new System.Windows.Forms.Padding(2);
            this.tbPulseUpTime.Name = "tbPulseUpTime";
            this.tbPulseUpTime.Size = new System.Drawing.Size(85, 21);
            this.tbPulseUpTime.TabIndex = 3;
            this.tbPulseUpTime.Text = "8";
            this.tbPulseUpTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "脉冲上升沿 μs";
            // 
            // tbDensity
            // 
            this.tbDensity.Location = new System.Drawing.Point(102, 20);
            this.tbDensity.Margin = new System.Windows.Forms.Padding(2);
            this.tbDensity.Name = "tbDensity";
            this.tbDensity.Size = new System.Drawing.Size(85, 21);
            this.tbDensity.TabIndex = 1;
            this.tbDensity.Text = "1000";
            this.tbDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "液体密度 kg/cm³";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartMaxPre);
            this.groupBox2.Location = new System.Drawing.Point(7, 217);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(813, 421);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "计算结果";
            // 
            // chartMaxPre
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMaxPre.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMaxPre.Legends.Add(legend1);
            this.chartMaxPre.Location = new System.Drawing.Point(60, 21);
            this.chartMaxPre.Margin = new System.Windows.Forms.Padding(2);
            this.chartMaxPre.Name = "chartMaxPre";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMaxPre.Series.Add(series1);
            this.chartMaxPre.Size = new System.Drawing.Size(721, 364);
            this.chartMaxPre.TabIndex = 0;
            this.chartMaxPre.Text = "液相冲击波峰值压力图";
            // 
            // tbShuaiJianCons
            // 
            this.tbShuaiJianCons.Location = new System.Drawing.Point(469, 119);
            this.tbShuaiJianCons.Margin = new System.Windows.Forms.Padding(2);
            this.tbShuaiJianCons.Name = "tbShuaiJianCons";
            this.tbShuaiJianCons.Size = new System.Drawing.Size(109, 21);
            this.tbShuaiJianCons.TabIndex = 26;
            this.tbShuaiJianCons.Text = "60000";
            this.tbShuaiJianCons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWaveSpeed
            // 
            this.tbWaveSpeed.Location = new System.Drawing.Point(696, 88);
            this.tbWaveSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.tbWaveSpeed.Name = "tbWaveSpeed";
            this.tbWaveSpeed.Size = new System.Drawing.Size(86, 21);
            this.tbWaveSpeed.TabIndex = 34;
            this.tbWaveSpeed.Text = "1500";
            this.tbWaveSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(591, 91);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 12);
            this.label13.TabIndex = 33;
            this.label13.Text = "水中激波速度 m/s";
            // 
            // tbEle2WaveEfficient
            // 
            this.tbEle2WaveEfficient.Location = new System.Drawing.Point(695, 118);
            this.tbEle2WaveEfficient.Margin = new System.Windows.Forms.Padding(2);
            this.tbEle2WaveEfficient.Name = "tbEle2WaveEfficient";
            this.tbEle2WaveEfficient.Size = new System.Drawing.Size(87, 21);
            this.tbEle2WaveEfficient.TabIndex = 32;
            this.tbEle2WaveEfficient.Text = "0.5";
            this.tbEle2WaveEfficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(591, 122);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 31;
            this.label14.Text = "电能转激波效率";
            // 
            // tbMaxLen
            // 
            this.tbMaxLen.Location = new System.Drawing.Point(695, 58);
            this.tbMaxLen.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaxLen.Name = "tbMaxLen";
            this.tbMaxLen.Size = new System.Drawing.Size(86, 21);
            this.tbMaxLen.TabIndex = 28;
            this.tbMaxLen.Text = "50";
            this.tbMaxLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMinLen
            // 
            this.tbMinLen.Location = new System.Drawing.Point(695, 20);
            this.tbMinLen.Margin = new System.Windows.Forms.Padding(2);
            this.tbMinLen.Name = "tbMinLen";
            this.tbMinLen.Size = new System.Drawing.Size(86, 21);
            this.tbMinLen.TabIndex = 30;
            this.tbMinLen.Text = "5";
            this.tbMinLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(591, 62);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 12);
            this.label15.TabIndex = 27;
            this.label15.Text = "最长距离 mm";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(591, 23);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 12);
            this.label16.TabIndex = 29;
            this.label16.Text = "最短距离 mm";
            // 
            // PressureFallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 649);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PressureFallForm";
            this.Text = "水激波衰减规律计算";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMaxPre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbLineNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbZhengLiuEfficent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnSaveImg;
        private System.Windows.Forms.Button btnCalcShuaiJian;
        private System.Windows.Forms.TextBox tbMaxProbeLength;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMinProbeLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbShuDianEfficient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbBianYaEfficient;
        private System.Windows.Forms.TextBox tbCapacityEnergy;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMaxPre;
        private System.Windows.Forms.TextBox tbWaveSpeed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbEle2WaveEfficient;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbMaxLen;
        private System.Windows.Forms.TextBox tbMinLen;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbShuaiJianCons;
    }
}