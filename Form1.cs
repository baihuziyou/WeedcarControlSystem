using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace XCOM
{
    public partial class Form1 : Form
    {
        SerialPort mySerialPort = new SerialPort();  //创建一个串口类

        byte[] TransmitDate = new byte[12];  //0-255

        public Form1()
        {
            TransmitDate[0]  = 0x50;   //0x50为起始位；
            TransmitDate[1]  = 0x50;   //0x50:归零；0x51:位置模式； 0x52:点动模式，点一下动一下
            TransmitDate[2]  = 0x00;   //点动模式下有效，点动模式下为0x00为向X正方向运动
            TransmitDate[3]  = 0x00;   //X方向运动的高位
            TransmitDate[4]  = 0x00;   //X方向运动的低位; 数据= 高位*100+低位；
            TransmitDate[5]  = 0x00;   //点动模式下有效，点动模式下为0x00为向Y正方向运动
            TransmitDate[6]  = 0x00;   //Y方向运动的高位
            TransmitDate[7]  = 0x00;   //Y方向运动的低位; 数据= 高位*100+低位；
            TransmitDate[8]  = 0x00;   //点动模式下有效，点动模式下为0x00为向Z正方向运动
            TransmitDate[9]  = 0x00;   //Z方向运动的高位
            TransmitDate[10] = 0x00;   //Z方向运动的低位; 数据= 高位*100+低位；
            TransmitDate[11] = 0x60;   //0x60为终止位；

            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arryPort = SerialPort.GetPortNames();//动态获取计算机的串口端口，并把它的名字存放在arryPort数组中

            //把电脑中的串口添加到SerialPortNames这个combox中
            foreach (var item in arryPort)
            {
                int time = 0;                          //用于确保一个for循环只添加一次

                var i = SerialPortNames.Items.Count;
                for (; i < arryPort.Length; i++)
                {
                    time++;
                    if (time == 1)
                    {
                        SerialPortNames.Items.Add(item);
                    }
                }
            }

            try
            {
                SerialPortName.Items.Add(arryPort[0]);
            }

            catch
            {
                MessageBox.Show("没有串口");
            }

            try
            {
                SerialPortNames.SelectedIndex = 0; //选中第一个串口
                SerialPortName.SelectedIndex = 0;
            }
            catch (Exception)
            {

                throw;
            }


            mySerialPort.PortName = SerialPortNames.Text; //串口名字
            mySerialPort.BaudRate = 9600;                 //串口波特率
            mySerialPort.DataBits = 8;                    //数据位
            mySerialPort.StopBits = StopBits.One;         //停止位
            mySerialPort.Parity = Parity.None;            //无奇偶校验

            try
            {
                mySerialPort.Open();
                OpenSerialPort.BackColor = Color.Green;
                OpenSerialPort.Text = "关闭串口";
                OpenSerialPort1.BackColor = Color.Green;
                OpenSerialPort1.Text = "关闭串口";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!mySerialPort.IsOpen)
            {
                mySerialPort.PortName = SerialPortNames.Text; //串口名字
                mySerialPort.BaudRate = 9600;                 //串口波特率
                mySerialPort.DataBits = 8;                    //数据位
                mySerialPort.StopBits = StopBits.One;         //停止位
                mySerialPort.Parity = Parity.None;            //无奇偶校验
            }



            try
            {
                if (OpenSerialPort.BackColor == Color.Green)
                {
                    mySerialPort.Close();
                    OpenSerialPort.Text = "打开串口";
                    OpenSerialPort.BackColor = Color.WhiteSmoke;
                }

                else
                {
                    mySerialPort.Open();
                    OpenSerialPort.Text = "关闭串口";
                    OpenSerialPort.BackColor = Color.Green;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("can't open xcom");
            }

            
        }

        //独立模式XYZ模式，XYZ选择互斥






        //独立XYZ模式的发送按钮按下时执行一下操作，XYZ中只有一个能有数据，其他的都是0
        //1.把text中的值取余取模得到对应的要发送的数据
        private void IndependentSendButton_Click(object sender, EventArgs e)
        {
            try
            {
                TransmitDate[0] = 0x50;   //0x50为起始位；
                TransmitDate[1] = 0x50;   //0x50:归零；0x51:位置模式； 0x52:点动模式，点一下动一下
                TransmitDate[2] = 0x00;   //点动模式下有效，点动模式下为0x00为向X正方向运动
                TransmitDate[3] = 0x00;   //X方向运动的高位
                TransmitDate[4] = 0x00;   //X方向运动的低位; 数据= 高位*100+低位；
                TransmitDate[5] = 0x00;   //点动模式下有效，点动模式下为0x00为向Y正方向运动
                TransmitDate[6] = 0x00;   //Y方向运动的高位
                TransmitDate[7] = 0x00;   //Y方向运动的低位; 数据= 高位*100+低位；
                TransmitDate[8] = 0x00;   //点动模式下有效，点动模式下为0x00为向Z正方向运动
                TransmitDate[9] = 0x00;   //Z方向运动的高位
                TransmitDate[10] = 0x00;   //Z方向运动的低位; 数据= 高位*100+低位；
                TransmitDate[11] = 0x60;   //0x60为终止位；

                mySerialPort.Write(TransmitDate, 0, 12);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void CombineSendButton_Click(object sender, EventArgs e)
        {
            int XMoveValue = Convert.ToInt32(CombineTextBoxX.Text);
            int YMoveValue = Convert.ToInt32(CombineTextBoxY.Text);
            int ZMoveValue = Convert.ToInt32(CombineTextBoxZ.Text);
            TransmitDate[0] = 0x50;
            TransmitDate[11] = 0x60;
            TransmitDate[1] = 0x51;    //指定位置模式

            try
            {
                TransmitDate[3]  = Convert.ToByte(Convert.ToString(XMoveValue / 100));
                TransmitDate[4]  = Convert.ToByte(Convert.ToString(XMoveValue % 100)); 
                TransmitDate[6]  = Convert.ToByte(Convert.ToString(YMoveValue / 100));
                TransmitDate[7]  = Convert.ToByte(Convert.ToString(YMoveValue % 100)); 
                TransmitDate[9]  = Convert.ToByte(Convert.ToString(ZMoveValue / 100));  
                TransmitDate[10] = Convert.ToByte(Convert.ToString(ZMoveValue % 100));  

                mySerialPort.Write(TransmitDate, 0, 12);   //发送12个字节的数据
            }
            catch (Exception)
            {
                MessageBox.Show("please open seralport first");  
            }
        }



        private void ClickMoveXDown_Click(object sender, EventArgs e)
        {
            int XClickMoveValue = Convert.ToInt32(ClickMoveXDownTextBox.Text);
            TransmitDate[0] = 0x50;
            TransmitDate[11] = 0x60;
            TransmitDate[1] = 0x52;    //指定位置模式


            try
            {
                TransmitDate[2] = 0x01;
                TransmitDate[3] = Convert.ToByte(Convert.ToString(XClickMoveValue / 100));
                TransmitDate[4] = Convert.ToByte(Convert.ToString(XClickMoveValue % 100));
                TransmitDate[5] =  0x00;
                TransmitDate[6] =  0x00;
                TransmitDate[7] =  0x00;
                TransmitDate[8] =  0x00;
                TransmitDate[9] =  0x00;
                TransmitDate[10] = 0x00;

                mySerialPort.Write(TransmitDate, 0, 12);   //发送12个字节的数据
            }
            catch (Exception)
            {
                MessageBox.Show("please open seralport first");
            }
        }

        private void ClickMoveXUp_Click(object sender, EventArgs e)
        {
            int XClickMoveValue = Convert.ToInt32(ClickMoveXDownTextBox.Text);
            TransmitDate[0] = 0x50;
            TransmitDate[11] = 0x60;
            TransmitDate[1] = 0x52;    //指定位置模式

            try
            {
                TransmitDate[2] =  0x00;
                TransmitDate[3] =  Convert.ToByte(Convert.ToString(XClickMoveValue / 100));
                TransmitDate[4] =  Convert.ToByte(Convert.ToString(XClickMoveValue % 100));
                TransmitDate[5] =  0x00;
                TransmitDate[6] =  0x00;
                TransmitDate[7] =  0x00;
                TransmitDate[8] =  0x00;
                TransmitDate[9] =  0x00;
                TransmitDate[10] = 0x00;

                mySerialPort.Write(TransmitDate, 0, 12);   //发送12个字节的数据
            }
            catch (Exception)
            {
                MessageBox.Show("please open seralport first");
            }

        }

        private void ClickMoveYDown_Click(object sender, EventArgs e)
        {
            int YClickMoveValue = Convert.ToInt32(ClickMoveYDownTextBox.Text);
            TransmitDate[0] = 0x50;
            TransmitDate[11] = 0x60;
            TransmitDate[1] = 0x52;    //指定位置模式

            try
            {
                TransmitDate[2]  = 0x00;
                TransmitDate[3]  = 0x00;
                TransmitDate[4]  = 0x00;
                TransmitDate[5]  = 0x01;
                TransmitDate[6]  = Convert.ToByte(Convert.ToString(YClickMoveValue / 100));
                TransmitDate[7]  = Convert.ToByte(Convert.ToString(YClickMoveValue % 100));
                TransmitDate[8]  = 0x00;
                TransmitDate[9]  = 0x00;
                TransmitDate[10] = 0x00;

                mySerialPort.Write(TransmitDate, 0, 12);   //发送12个字节的数据
            }
            catch (Exception)
            {
                MessageBox.Show("please open seralport first");
            }

        }

        private void ClickMoveYUp_Click(object sender, EventArgs e)
        {
            int YClickMoveValue = Convert.ToInt32(ClickMoveYDownTextBox.Text);
            TransmitDate[0] = 0x50;
            TransmitDate[11] = 0x60;
            TransmitDate[1] = 0x52;    //指定位置模式

            try
            {
                TransmitDate[2] =  0x00;
                TransmitDate[3] =  0x00;
                TransmitDate[4] =  0x00;
                TransmitDate[5] =  0x00;
                TransmitDate[6] =  Convert.ToByte(Convert.ToString(YClickMoveValue / 100));
                TransmitDate[7] =  Convert.ToByte(Convert.ToString(YClickMoveValue % 100));
                TransmitDate[8] =  0x00;
                TransmitDate[9] =  0x00;
                TransmitDate[10] = 0x00;
                                    
                mySerialPort.Write(TransmitDate, 0, 12);   //发送12个字节的数据
            }
            catch (Exception)
            {
                MessageBox.Show("please open seralport first");
            }
        }

        private void ClickMoveZDown_Click(object sender, EventArgs e)
        {
            int ZClickMoveValue = Convert.ToInt32(ClickMoveZDownTextBox.Text);
            TransmitDate[0] = 0x50;
            TransmitDate[11] = 0x60;
            TransmitDate[1] = 0x52;    //指定位置模式

            try
            {
                TransmitDate[2] =  0x00;
                TransmitDate[3] =  0x00;
                TransmitDate[4] =  0x00;
                TransmitDate[5] =  0x00;
                TransmitDate[6] =  0X00;
                TransmitDate[7] =  0X00;
                TransmitDate[8] =  0x01;
                TransmitDate[9] =  Convert.ToByte(Convert.ToString(ZClickMoveValue / 100));
                TransmitDate[10] = Convert.ToByte(Convert.ToString(ZClickMoveValue % 100));

                mySerialPort.Write(TransmitDate, 0, 12);   //发送12个字节的数据
            }
            catch (Exception)
            {
                MessageBox.Show("please open seralport first");
            }

        }

        private void ClickMoveZUp_Click(object sender, EventArgs e)
        {
            int ZClickMoveValue = Convert.ToInt32(ClickMoveZDownTextBox.Text);
            TransmitDate[0] = 0x50;
            TransmitDate[11] = 0x60;
            TransmitDate[1] = 0x52;    //指定位置模式
            try
            {
                TransmitDate[2] = 0x00;
                TransmitDate[3] = 0x00;
                TransmitDate[4] = 0x00;
                TransmitDate[5] = 0x00;
                TransmitDate[6] = 0X00;
                TransmitDate[7] = 0X00;
                TransmitDate[8] = 0x00;
                TransmitDate[9] = Convert.ToByte(Convert.ToString(ZClickMoveValue / 100));
                TransmitDate[10] = Convert.ToByte(Convert.ToString(ZClickMoveValue % 100));

                mySerialPort.Write(TransmitDate, 0, 12);   //发送12个字节的数据
            }
            catch (Exception)
            {
                MessageBox.Show("please open seralport first");
            }

        }

        private void SetZeroX_Click(object sender, EventArgs e)
        {
            TransmitDate[0] = 0x50;
            TransmitDate[11] = 0x60;
            try
            {
                TransmitDate[1] = 0x52;
                TransmitDate[2] = 0x01;
                TransmitDate[3] = 0x10; //代表往X负方向走1000
                TransmitDate[4] = 0x00;
                TransmitDate[5] = 0x00;
                TransmitDate[6] = 0x00;
                TransmitDate[7] = 0x00;
                TransmitDate[8] = 0x00;
                TransmitDate[9] = 0x00;
                TransmitDate[10] = 0x00;

                mySerialPort.Write(TransmitDate, 0, 12);   //发送12个字节的数据
            }
            catch (Exception)
            {
                MessageBox.Show("please open seralport first");
            }
        }

        private void SetZeroY_Click(object sender, EventArgs e)
        {
            TransmitDate[0] = 0x50;
            TransmitDate[11] = 0x60;
            try
            {
                TransmitDate[1] = 0x52;
                TransmitDate[2] = 0x00;
                TransmitDate[3] = 0x00; //代表往X负方向走1000
                TransmitDate[4] = 0x00;
                TransmitDate[5] = 0x01;
                TransmitDate[6] = 0x10;
                TransmitDate[7] = 0x00;
                TransmitDate[8] = 0x00;
                TransmitDate[9] = 0x00;
                TransmitDate[10] = 0x00;

                mySerialPort.Write(TransmitDate, 0, 12);   //发送12个字节的数据
            }
            catch (Exception)
            {
                MessageBox.Show("please open seralport first");
            }

        }

        private void SetZeroZ_Click(object sender, EventArgs e)
        {
            TransmitDate[0] = 0x50;
            TransmitDate[11] = 0x60;
            try
            {
                TransmitDate[1] = 0x52;
                TransmitDate[2] = 0x00;
                TransmitDate[3] = 0x00; //代表往X负方向走1000
                TransmitDate[4] = 0x00;
                TransmitDate[5] = 0x00;
                TransmitDate[6] = 0x00;
                TransmitDate[7] = 0x00;
                TransmitDate[8] = 0x01;
                TransmitDate[9] = 0x10;
                TransmitDate[10] = 0x00;

                mySerialPort.Write(TransmitDate, 0, 12);   //发送12个字节的数据
            }
            catch (Exception)
            {
                MessageBox.Show("please open seralport first");
            }

        }

        private void OpenSerialPort1_Click(object sender, EventArgs e)
        {
            if (!mySerialPort.IsOpen)
            {
                mySerialPort.PortName = SerialPortNames.Text; //串口名字
                mySerialPort.BaudRate = 9600;                 //串口波特率
                mySerialPort.DataBits = 8;                    //数据位
                mySerialPort.StopBits = StopBits.One;         //停止位
                mySerialPort.Parity = Parity.None;            //无奇偶校验
            }



            try
            {
                if (OpenSerialPort1.BackColor == Color.Green)
                {
                    mySerialPort.Close();
                    OpenSerialPort1.Text = "打开串口";
                    OpenSerialPort1.BackColor = Color.WhiteSmoke;
                }

                else
                {
                    mySerialPort.Open();
                    OpenSerialPort1.Text = "关闭串口";
                    OpenSerialPort1.BackColor = Color.Green;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("can't open xcom");
            }
        }

        //除草刀具转动，通知控制
        private void Weed_Click(object sender, EventArgs e)
        {

            TransmitDate[0] = 0X60;
            TransmitDate[1] = 0x00;
            TransmitDate[2] = 0x00;
            TransmitDate[3] = 0x00; //代表往X负方向走1000
            TransmitDate[4] = 0x00;
            TransmitDate[5] = 0x00;
            TransmitDate[6] = 0x00;
            TransmitDate[7] = 0x00;
            TransmitDate[8] = 0x00;
            TransmitDate[9] = 0x00;
            TransmitDate[10] = 0x00;
            TransmitDate[11] = 0X70;

            if (Weed.BackColor == Color.Transparent)
            {
                Weed.BackColor = Color.Green;
                TransmitDate[1] = 0x01;
            }

            else
            {
                Weed.BackColor = Color.Transparent;
                TransmitDate[1] = 0x00;
            }

            try
            {
                mySerialPort.Write(TransmitDate, 0, 12);   //发送12个字节的数据
            }
            catch
            {
                MessageBox.Show("发送数据错误，请先检出串口是否打开");
            }


        }
        
        //前进
        private void Car_Forward_Click(object sender, EventArgs e)
        {
            try
            {
                int carvelocity_date = Convert.ToInt32(CarVelocity.Text);
                TransmitDate[0] = 0X70;
                TransmitDate[1] = 0x00;   //方向
                TransmitDate[2] = Convert.ToByte(Convert.ToString(carvelocity_date / 100));
                TransmitDate[3] = Convert.ToByte(Convert.ToString(carvelocity_date % 100));
                TransmitDate[4] = 0x00;
                TransmitDate[5] = Convert.ToByte(Convert.ToString(carvelocity_date / 100));
                TransmitDate[6] = Convert.ToByte(Convert.ToString(carvelocity_date % 100));
                TransmitDate[7] = 0x00;
                TransmitDate[8] = 0x00;
                TransmitDate[9] = 0x00;
                TransmitDate[10] = 0x00;
                TransmitDate[11] = 0X80;
            }

            catch
            {
                MessageBox.Show("速度不对");
            }
           

           

            try
            {
                mySerialPort.Write(TransmitDate, 0, 12);   //发送12个字节的数据
            }
            catch
            {
                MessageBox.Show("发送数据错误，请先检出串口是否打开");
            }
        }

        //后退
        private void Car_Back_Click(object sender, EventArgs e)
        {

            try
            {
                int carvelocity_date = Convert.ToInt32(CarVelocity.Text);
                TransmitDate[0] = 0X70;
                TransmitDate[1] = 0x01;   //方向
                TransmitDate[2] = Convert.ToByte(Convert.ToString(carvelocity_date / 100));
                TransmitDate[3] = Convert.ToByte(Convert.ToString(carvelocity_date % 100));
                TransmitDate[4] = 0x01;
                TransmitDate[5] = Convert.ToByte(Convert.ToString(carvelocity_date / 100));
                TransmitDate[6] = Convert.ToByte(Convert.ToString(carvelocity_date % 100));
                TransmitDate[7] = 0x00;
                TransmitDate[8] = 0x00;
                TransmitDate[9] = 0x00;
                TransmitDate[10] = 0x00;
                TransmitDate[11] = 0X80;
            }

            catch
            {
                MessageBox.Show("速度不对");
            }
        



            try
            {
                mySerialPort.Write(TransmitDate, 0, 12);   //发送12个字节的数据
            }
            catch
            {
                MessageBox.Show("发送数据错误，请先检出串口是否打开");
            }

        }

        private void Car_left_Click(object sender, EventArgs e)
        {
            try
            {
                int carvelocity_date = Convert.ToInt32(CarVelocity.Text);
                TransmitDate[0] = 0X70;
                TransmitDate[1] = 0x00;   //方向
                TransmitDate[2] = Convert.ToByte(Convert.ToString(carvelocity_date / 100));
                TransmitDate[3] = Convert.ToByte(Convert.ToString(carvelocity_date % 100));
                TransmitDate[4] = 0x01;
                TransmitDate[5] = Convert.ToByte(Convert.ToString(carvelocity_date / 100));
                TransmitDate[6] = Convert.ToByte(Convert.ToString(carvelocity_date % 100));
                TransmitDate[7] = 0x00;
                TransmitDate[8] = 0x00;
                TransmitDate[9] = 0x00;
                TransmitDate[10] = 0x00;
                TransmitDate[11] = 0X80;
            }

            catch
            {
                MessageBox.Show("速度不对");
            }


            try
            {
                mySerialPort.Write(TransmitDate, 0, 12);   //发送12个字节的数据
            }
            catch
            {
                MessageBox.Show("发送数据错误，请先检出串口是否打开");
            }

        }

        private void Car_Right_Click(object sender, EventArgs e)
        {
            try
            {
                int carvelocity_date = Convert.ToInt32(CarVelocity.Text);
                TransmitDate[0] = 0X70;
                TransmitDate[1] = 0x01;   //方向
                TransmitDate[2] = Convert.ToByte(Convert.ToString(carvelocity_date / 100));
                TransmitDate[3] = Convert.ToByte(Convert.ToString(carvelocity_date % 100));
                TransmitDate[4] = 0x00;
                TransmitDate[5] = Convert.ToByte(Convert.ToString(carvelocity_date / 100));
                TransmitDate[6] = Convert.ToByte(Convert.ToString(carvelocity_date % 100));
                TransmitDate[7] = 0x00;
                TransmitDate[8] = 0x00;
                TransmitDate[9] = 0x00;
                TransmitDate[10] = 0x00;
                TransmitDate[11] = 0X80;

            }

            catch
            {
                MessageBox.Show("速度不对");
            }


            try
            {
                mySerialPort.Write(TransmitDate, 0, 12);   //发送12个字节的数据
            }
            catch
            {
                MessageBox.Show("发送数据错误，请先检出串口是否打开");
            }
        }
    }
}
