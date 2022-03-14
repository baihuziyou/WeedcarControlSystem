
namespace XCOM
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CarVelocity = new System.Windows.Forms.TextBox();
            this.Car_left = new System.Windows.Forms.Button();
            this.Car_Right = new System.Windows.Forms.Button();
            this.Car_Back = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.Car_Forward = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.SerialPortName = new System.Windows.Forms.ComboBox();
            this.OpenSerialPort1 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.SerialPortNames = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.ClickMoveZUp = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.ClickMoveYUp = new System.Windows.Forms.Button();
            this.ClickMoveZDown = new System.Windows.Forms.Button();
            this.ClickMoveYDown = new System.Windows.Forms.Button();
            this.ClickMoveXDown = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ClickMoveXUp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ClickMoveButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ClickMoveZDownTextBox = new System.Windows.Forms.TextBox();
            this.ClickMoveYDownTextBox = new System.Windows.Forms.TextBox();
            this.ClickMoveXDownTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.CombineSendButton = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.CombineTextBoxY = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.CombineTextBoxX = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.CombineTextBoxZ = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.IndependentSendButton = new System.Windows.Forms.Button();
            this.SetZeroZ = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.SetZeroY = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.SetZeroX = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.OpenSerialPort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Weed = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(971, 631);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.SerialPortName);
            this.tabPage1.Controls.Add(this.OpenSerialPort1);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(963, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "移动平台控制系统";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.CarVelocity);
            this.panel4.Controls.Add(this.Car_left);
            this.panel4.Controls.Add(this.Car_Right);
            this.panel4.Controls.Add(this.Car_Back);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.Car_Forward);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Location = new System.Drawing.Point(123, 246);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(1);
            this.panel4.Size = new System.Drawing.Size(711, 246);
            this.panel4.TabIndex = 54;
            // 
            // CarVelocity
            // 
            this.CarVelocity.Location = new System.Drawing.Point(119, 90);
            this.CarVelocity.Name = "CarVelocity";
            this.CarVelocity.Size = new System.Drawing.Size(101, 21);
            this.CarVelocity.TabIndex = 47;
            // 
            // Car_left
            // 
            this.Car_left.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Car_left.Location = new System.Drawing.Point(334, 109);
            this.Car_left.Name = "Car_left";
            this.Car_left.Size = new System.Drawing.Size(98, 38);
            this.Car_left.TabIndex = 46;
            this.Car_left.Text = "左转";
            this.Car_left.UseVisualStyleBackColor = true;
            this.Car_left.Click += new System.EventHandler(this.Car_left_Click);
            // 
            // Car_Right
            // 
            this.Car_Right.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Car_Right.Location = new System.Drawing.Point(585, 109);
            this.Car_Right.Name = "Car_Right";
            this.Car_Right.Size = new System.Drawing.Size(98, 38);
            this.Car_Right.TabIndex = 46;
            this.Car_Right.Text = "右转";
            this.Car_Right.UseVisualStyleBackColor = true;
            this.Car_Right.Click += new System.EventHandler(this.Car_Right_Click);
            // 
            // Car_Back
            // 
            this.Car_Back.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Car_Back.Location = new System.Drawing.Point(457, 190);
            this.Car_Back.Name = "Car_Back";
            this.Car_Back.Size = new System.Drawing.Size(98, 38);
            this.Car_Back.TabIndex = 46;
            this.Car_Back.Text = "后退";
            this.Car_Back.UseVisualStyleBackColor = true;
            this.Car_Back.Click += new System.EventHandler(this.Car_Back_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(227, 88);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(52, 24);
            this.label28.TabIndex = 40;
            this.label28.Text = "r/min";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(224, 91);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 24);
            this.label26.TabIndex = 40;
            this.label26.Text = "r/min";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(28, 88);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(105, 24);
            this.label24.TabIndex = 40;
            this.label24.Text = "转动速度：";
            // 
            // Car_Forward
            // 
            this.Car_Forward.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Car_Forward.Location = new System.Drawing.Point(457, 26);
            this.Car_Forward.Name = "Car_Forward";
            this.Car_Forward.Size = new System.Drawing.Size(98, 38);
            this.Car_Forward.TabIndex = 46;
            this.Car_Forward.Text = "前进";
            this.Car_Forward.UseVisualStyleBackColor = true;
            this.Car_Forward.Click += new System.EventHandler(this.Car_Forward_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(4, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 24);
            this.label23.TabIndex = 40;
            this.label23.Text = "车辆控制";
            // 
            // SerialPortName
            // 
            this.SerialPortName.FormattingEnabled = true;
            this.SerialPortName.Location = new System.Drawing.Point(141, 121);
            this.SerialPortName.Name = "SerialPortName";
            this.SerialPortName.Size = new System.Drawing.Size(101, 20);
            this.SerialPortName.TabIndex = 52;
            // 
            // OpenSerialPort1
            // 
            this.OpenSerialPort1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenSerialPort1.Location = new System.Drawing.Point(790, 113);
            this.OpenSerialPort1.Name = "OpenSerialPort1";
            this.OpenSerialPort1.Size = new System.Drawing.Size(107, 38);
            this.OpenSerialPort1.TabIndex = 51;
            this.OpenSerialPort1.Text = "打开串口";
            this.OpenSerialPort1.UseVisualStyleBackColor = true;
            this.OpenSerialPort1.Click += new System.EventHandler(this.OpenSerialPort1_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(270, 120);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(126, 24);
            this.label22.TabIndex = 48;
            this.label22.Text = "波特率：9600";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(453, 120);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(301, 24);
            this.label25.TabIndex = 49;
            this.label25.Text = "数据位：8，停止位:1，无奇偶校验";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(65, 120);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(86, 24);
            this.label27.TabIndex = 50;
            this.label27.Text = "串口号：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.hScrollBar1);
            this.tabPage2.Controls.Add(this.SerialPortNames);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.Weed);
            this.tabPage2.Controls.Add(this.OpenSerialPort);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(963, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "执行机构控制系统";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(72, 53);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(719, 272);
            this.textBox2.TabIndex = 16;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(147, 128);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar1.TabIndex = 15;
            // 
            // SerialPortNames
            // 
            this.SerialPortNames.FormattingEnabled = true;
            this.SerialPortNames.Location = new System.Drawing.Point(142, 13);
            this.SerialPortNames.Name = "SerialPortNames";
            this.SerialPortNames.Size = new System.Drawing.Size(101, 20);
            this.SerialPortNames.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.ClickMoveZUp);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.ClickMoveYUp);
            this.panel3.Controls.Add(this.ClickMoveZDown);
            this.panel3.Controls.Add(this.ClickMoveYDown);
            this.panel3.Controls.Add(this.ClickMoveXDown);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.ClickMoveXUp);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.ClickMoveButton);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.ClickMoveZDownTextBox);
            this.panel3.Controls.Add(this.ClickMoveYDownTextBox);
            this.panel3.Controls.Add(this.ClickMoveXDownTextBox);
            this.panel3.Location = new System.Drawing.Point(607, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 262);
            this.panel3.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(83, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "点动模式";
            // 
            // ClickMoveZUp
            // 
            this.ClickMoveZUp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClickMoveZUp.Location = new System.Drawing.Point(201, 169);
            this.ClickMoveZUp.Name = "ClickMoveZUp";
            this.ClickMoveZUp.Size = new System.Drawing.Size(50, 24);
            this.ClickMoveZUp.TabIndex = 2;
            this.ClickMoveZUp.Text = "+";
            this.ClickMoveZUp.UseVisualStyleBackColor = true;
            this.ClickMoveZUp.Click += new System.EventHandler(this.ClickMoveZUp_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(153, 169);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 24);
            this.label16.TabIndex = 0;
            this.label16.Text = "mm";
            // 
            // ClickMoveYUp
            // 
            this.ClickMoveYUp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClickMoveYUp.Location = new System.Drawing.Point(201, 123);
            this.ClickMoveYUp.Name = "ClickMoveYUp";
            this.ClickMoveYUp.Size = new System.Drawing.Size(50, 24);
            this.ClickMoveYUp.TabIndex = 2;
            this.ClickMoveYUp.Text = "+";
            this.ClickMoveYUp.UseVisualStyleBackColor = true;
            this.ClickMoveYUp.Click += new System.EventHandler(this.ClickMoveYUp_Click);
            // 
            // ClickMoveZDown
            // 
            this.ClickMoveZDown.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClickMoveZDown.Location = new System.Drawing.Point(25, 169);
            this.ClickMoveZDown.Name = "ClickMoveZDown";
            this.ClickMoveZDown.Size = new System.Drawing.Size(50, 24);
            this.ClickMoveZDown.TabIndex = 2;
            this.ClickMoveZDown.Text = "-";
            this.ClickMoveZDown.UseVisualStyleBackColor = true;
            this.ClickMoveZDown.Click += new System.EventHandler(this.ClickMoveZDown_Click);
            // 
            // ClickMoveYDown
            // 
            this.ClickMoveYDown.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClickMoveYDown.Location = new System.Drawing.Point(25, 123);
            this.ClickMoveYDown.Name = "ClickMoveYDown";
            this.ClickMoveYDown.Size = new System.Drawing.Size(50, 24);
            this.ClickMoveYDown.TabIndex = 2;
            this.ClickMoveYDown.Text = "-";
            this.ClickMoveYDown.UseVisualStyleBackColor = true;
            this.ClickMoveYDown.Click += new System.EventHandler(this.ClickMoveYDown_Click);
            // 
            // ClickMoveXDown
            // 
            this.ClickMoveXDown.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClickMoveXDown.Location = new System.Drawing.Point(25, 77);
            this.ClickMoveXDown.Name = "ClickMoveXDown";
            this.ClickMoveXDown.Size = new System.Drawing.Size(50, 24);
            this.ClickMoveXDown.TabIndex = 2;
            this.ClickMoveXDown.Text = "-";
            this.ClickMoveXDown.UseVisualStyleBackColor = true;
            this.ClickMoveXDown.Click += new System.EventHandler(this.ClickMoveXDown_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(153, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "mm";
            // 
            // ClickMoveXUp
            // 
            this.ClickMoveXUp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClickMoveXUp.Location = new System.Drawing.Point(201, 77);
            this.ClickMoveXUp.Name = "ClickMoveXUp";
            this.ClickMoveXUp.Size = new System.Drawing.Size(50, 24);
            this.ClickMoveXUp.TabIndex = 2;
            this.ClickMoveXUp.Text = "+";
            this.ClickMoveXUp.UseVisualStyleBackColor = true;
            this.ClickMoveXUp.Click += new System.EventHandler(this.ClickMoveXUp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "mm";
            // 
            // ClickMoveButton
            // 
            this.ClickMoveButton.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClickMoveButton.Location = new System.Drawing.Point(78, 221);
            this.ClickMoveButton.Name = "ClickMoveButton";
            this.ClickMoveButton.Size = new System.Drawing.Size(130, 38);
            this.ClickMoveButton.TabIndex = 2;
            this.ClickMoveButton.Text = "NO USE";
            this.ClickMoveButton.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(83, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Z:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(83, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "Y:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(81, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 24);
            this.label15.TabIndex = 0;
            this.label15.Text = "X:";
            // 
            // ClickMoveZDownTextBox
            // 
            this.ClickMoveZDownTextBox.Location = new System.Drawing.Point(112, 171);
            this.ClickMoveZDownTextBox.Name = "ClickMoveZDownTextBox";
            this.ClickMoveZDownTextBox.Size = new System.Drawing.Size(36, 21);
            this.ClickMoveZDownTextBox.TabIndex = 1;
            this.ClickMoveZDownTextBox.Text = "0";
            // 
            // ClickMoveYDownTextBox
            // 
            this.ClickMoveYDownTextBox.Location = new System.Drawing.Point(111, 125);
            this.ClickMoveYDownTextBox.Name = "ClickMoveYDownTextBox";
            this.ClickMoveYDownTextBox.Size = new System.Drawing.Size(36, 21);
            this.ClickMoveYDownTextBox.TabIndex = 1;
            this.ClickMoveYDownTextBox.Text = "0";
            // 
            // ClickMoveXDownTextBox
            // 
            this.ClickMoveXDownTextBox.Location = new System.Drawing.Point(111, 79);
            this.ClickMoveXDownTextBox.Name = "ClickMoveXDownTextBox";
            this.ClickMoveXDownTextBox.Size = new System.Drawing.Size(36, 21);
            this.ClickMoveXDownTextBox.TabIndex = 1;
            this.ClickMoveXDownTextBox.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.CombineSendButton);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.CombineTextBoxY);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.CombineTextBoxX);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.CombineTextBoxZ);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(344, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 262);
            this.panel2.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "位置控制模式";
            // 
            // CombineSendButton
            // 
            this.CombineSendButton.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CombineSendButton.Location = new System.Drawing.Point(51, 221);
            this.CombineSendButton.Name = "CombineSendButton";
            this.CombineSendButton.Size = new System.Drawing.Size(130, 38);
            this.CombineSendButton.TabIndex = 2;
            this.CombineSendButton.Text = "发送";
            this.CombineSendButton.UseVisualStyleBackColor = true;
            this.CombineSendButton.Click += new System.EventHandler(this.CombineSendButton_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(163, 175);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 24);
            this.label21.TabIndex = 0;
            this.label21.Text = "mm";
            // 
            // CombineTextBoxY
            // 
            this.CombineTextBoxY.Location = new System.Drawing.Point(74, 130);
            this.CombineTextBoxY.Name = "CombineTextBoxY";
            this.CombineTextBoxY.Size = new System.Drawing.Size(83, 21);
            this.CombineTextBoxY.TabIndex = 1;
            this.CombineTextBoxY.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(27, 175);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "Z：";
            // 
            // CombineTextBoxX
            // 
            this.CombineTextBoxX.Location = new System.Drawing.Point(74, 81);
            this.CombineTextBoxX.Name = "CombineTextBoxX";
            this.CombineTextBoxX.Size = new System.Drawing.Size(83, 21);
            this.CombineTextBoxX.TabIndex = 1;
            this.CombineTextBoxX.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(163, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 24);
            this.label19.TabIndex = 0;
            this.label19.Text = "mm";
            // 
            // CombineTextBoxZ
            // 
            this.CombineTextBoxZ.Location = new System.Drawing.Point(74, 176);
            this.CombineTextBoxZ.Name = "CombineTextBoxZ";
            this.CombineTextBoxZ.Size = new System.Drawing.Size(83, 21);
            this.CombineTextBoxZ.TabIndex = 1;
            this.CombineTextBoxZ.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(163, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "mm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "X：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Y：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.IndependentSendButton);
            this.panel1.Controls.Add(this.SetZeroZ);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.SetZeroY);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.SetZeroX);
            this.panel1.Controls.Add(this.label5);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(72, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 262);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "置零";
            // 
            // IndependentSendButton
            // 
            this.IndependentSendButton.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IndependentSendButton.Location = new System.Drawing.Point(51, 221);
            this.IndependentSendButton.Name = "IndependentSendButton";
            this.IndependentSendButton.Size = new System.Drawing.Size(130, 38);
            this.IndependentSendButton.TabIndex = 2;
            this.IndependentSendButton.Text = "全部置零";
            this.IndependentSendButton.UseVisualStyleBackColor = true;
            this.IndependentSendButton.Click += new System.EventHandler(this.IndependentSendButton_Click);
            // 
            // SetZeroZ
            // 
            this.SetZeroZ.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetZeroZ.Location = new System.Drawing.Point(69, 163);
            this.SetZeroZ.Name = "SetZeroZ";
            this.SetZeroZ.Size = new System.Drawing.Size(66, 28);
            this.SetZeroZ.TabIndex = 2;
            this.SetZeroZ.Text = "置零";
            this.SetZeroZ.UseVisualStyleBackColor = true;
            this.SetZeroZ.Click += new System.EventHandler(this.SetZeroZ_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(141, 165);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 24);
            this.label18.TabIndex = 0;
            this.label18.Text = "Z";
            // 
            // SetZeroY
            // 
            this.SetZeroY.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetZeroY.Location = new System.Drawing.Point(69, 117);
            this.SetZeroY.Name = "SetZeroY";
            this.SetZeroY.Size = new System.Drawing.Size(66, 28);
            this.SetZeroY.TabIndex = 2;
            this.SetZeroY.Text = "置零";
            this.SetZeroY.UseVisualStyleBackColor = true;
            this.SetZeroY.Click += new System.EventHandler(this.SetZeroY_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(141, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 24);
            this.label17.TabIndex = 0;
            this.label17.Text = "Y";
            // 
            // SetZeroX
            // 
            this.SetZeroX.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetZeroX.Location = new System.Drawing.Point(69, 71);
            this.SetZeroX.Name = "SetZeroX";
            this.SetZeroX.Size = new System.Drawing.Size(66, 28);
            this.SetZeroX.TabIndex = 2;
            this.SetZeroX.Text = "置零";
            this.SetZeroX.UseVisualStyleBackColor = true;
            this.SetZeroX.Click += new System.EventHandler(this.SetZeroX_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "X";
            // 
            // OpenSerialPort
            // 
            this.OpenSerialPort.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenSerialPort.Location = new System.Drawing.Point(797, 53);
            this.OpenSerialPort.Name = "OpenSerialPort";
            this.OpenSerialPort.Size = new System.Drawing.Size(99, 38);
            this.OpenSerialPort.TabIndex = 10;
            this.OpenSerialPort.Text = "打开串口";
            this.OpenSerialPort.UseVisualStyleBackColor = true;
            this.OpenSerialPort.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "波特率：9600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "数据位：8，停止位:1，无奇偶校验";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "串口号：";
            // 
            // Weed
            // 
            this.Weed.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Weed.Location = new System.Drawing.Point(797, 287);
            this.Weed.Name = "Weed";
            this.Weed.Size = new System.Drawing.Size(99, 38);
            this.Weed.TabIndex = 10;
            this.Weed.Text = "除草刀具";
            this.Weed.UseVisualStyleBackColor = true;
            this.Weed.Click += new System.EventHandler(this.Weed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 655);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "智能除草机器人控制";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox CarVelocity;
        private System.Windows.Forms.Button Car_left;
        private System.Windows.Forms.Button Car_Right;
        private System.Windows.Forms.Button Car_Back;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button Car_Forward;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox SerialPortName;
        private System.Windows.Forms.Button OpenSerialPort1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.ComboBox SerialPortNames;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ClickMoveZUp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button ClickMoveYUp;
        private System.Windows.Forms.Button ClickMoveZDown;
        private System.Windows.Forms.Button ClickMoveYDown;
        private System.Windows.Forms.Button ClickMoveXDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ClickMoveXUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ClickMoveButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ClickMoveZDownTextBox;
        private System.Windows.Forms.TextBox ClickMoveYDownTextBox;
        private System.Windows.Forms.TextBox ClickMoveXDownTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CombineSendButton;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox CombineTextBoxY;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox CombineTextBoxX;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox CombineTextBoxZ;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button IndependentSendButton;
        private System.Windows.Forms.Button SetZeroZ;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button SetZeroY;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button SetZeroX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OpenSerialPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Weed;
    }
}

