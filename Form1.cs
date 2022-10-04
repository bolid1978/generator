using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO.Ports;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{

    

    public partial class Generation : Form
    {
        int Fflag = 0, Pflag = 0, Mflag = 0, AutoTuneOFFFlag = 0, AutoTuneONFlag = 0, HeatONFlag = 0, HeatOFFFlag = 0, IgnitionONFlag = 0,
        IgnitionOFFFlag = 0, LampPorogFlagg = 0, LampLookPhotoFlagg = 0,
        ResetFlag=0, SerialNumberFlag=0, SintezSbroslag=0,SendFlag = 0,btIgnitionONSet=1,SendascFlag=0, temperetureFlag = 0;

    
      




        public void  ResetFlagAll()
        {
            Fflag = Pflag = Mflag= SendFlag = AutoTuneOFFFlag = AutoTuneONFlag = HeatONFlag = HeatOFFFlag = IgnitionONFlag = 0; 
            IgnitionOFFFlag = ResetFlag =  SerialNumberFlag = SintezSbroslag= btIgnitionONSet = SendascFlag = LampPorogFlagg = LampLookPhotoFlagg = temperetureFlag = SendascFlag = 0;

        }

      

        public Generation()
        {
            InitializeComponent();
            

        }

      



        //---------объявление порта и его определение
        public object SerialPort1 { get; private set; }

       



        

         private void Generation_Load(object sender, EventArgs e)
        {
            // vvodbayt();

            //timer1.Start();
            // ----- словарь команд
            Dictionary<string, string> command = new Dictionary<string, string>()
        {
             { "проверка температуры", "t"},
             { "проверка секунды", "S"},
             { "проверка версии прошивки", "v"}
        };
            cbCommand.DataSource = new BindingSource(command, null);
            cbCommand.DisplayMember = "Key";
            cbCommand.ValueMember = "Value";

            try
                {
                    string[] ports = SerialPort.GetPortNames();
                    cbPort.Items.AddRange(ports);
                    cbPort.SelectedIndex = 0;
                    btnClose.Enabled = false;
                    //serialPort1.DiscardInBuffer();
                   // serialPort1.ReadTimeout = 100;
                }

                catch
                {
                    MessageBox.Show("Нет ни одного порта");

                }

            ResetFlagAll();
        }
        //---------------------------------------------------------

        private void btnOpen_Click(object sender, EventArgs e)
        {
            
            
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                try
                {
                    serialPort1.PortName = cbPort.Text;
                    serialPort1.Open();



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            try
            {

                serialPort1.Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //------------------------------------------------------------------
        /*private void label2_Click(object sender, EventArgs e)
        {
            tbF.Text = Convert.ToString(command.ElementAt(0));
           
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        */
        //------------***********---регулятор на кнопках----************-------------
        //----------проверка частоты ------------
        private void btFlook_Click(object sender, EventArgs e)
        {
            ResetFlagAll();
            char[] LookF = new char [1];
            LookF[0] = 'F';
          
            //char[] temp = new char[4];
            //string read = new string(reseverF);
            try
            {
                if (serialPort1.IsOpen)
                {
                   // serialPort1.WriteLine("F"/*txMesenger.Text + Environment.NewLine*/);
                    serialPort1.Write(LookF,0,1)/*txMesenger.Text + Environment.NewLine*/;
                    Fflag = 1;
                    txMesenger.Text = txMesenger.Text + Convert.ToString(LookF[0]) + Environment.NewLine/*"\r\n"*/;
                    // txMesenger.Clear();
                   // txMesenger.Text = Convert.ToString(serialPort1.Read(reseverF, 0, 3));
                   // string read = new string(reseverF);
                   // txMesenger.Text = read; 

                }
                                
            }            
            catch (Exception ex)  
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----------увеличение чacтоты
        private void btFplus_Click(object sender, EventArgs e)
        {
            ResetFlagAll();
            char[] PlusF = new char[1];
            PlusF[0] = 'P';
            string temp;


            try
            {
                if (/*(Convert.ToInt32(tbFplus.Text) + Convert.ToInt32(tbF.Text) < 10000) &&*/ (tbFplus.Text.Count() == 3))
                {
                    if (serialPort1.IsOpen)
                    {
                        temp = (PlusF[0] + " " + tbFplus.Text);


                        serialPort1.WriteLine(temp);
                        Pflag = 1;
                        txMesenger.Text = txMesenger.Text + Convert.ToString(PlusF[0]) + " " + tbFplus.Text + Environment.NewLine/*"\r\n"*/;

                       
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----------уменьшение  чacтоты
        private void btFminus_Click(object sender, EventArgs e)
        {
            ResetFlagAll();
            char[] MlusF = new char[1];
                MlusF[0] = 'M';
                string temp;


                try
                {
                    if (/*(Convert.ToInt32(tbF.Text)-Convert.ToInt32(tbFminus.Text) > -10000) && */(tbFminus.Text.Count() == 3))
                    {
                        if (serialPort1.IsOpen)
                        {
                            temp = (MlusF[0] + " " + tbFminus.Text);


                            serialPort1.WriteLine(temp);
                            Mflag = 1;
                            txMesenger.Text = txMesenger.Text + Convert.ToString(MlusF[0]) + " " + tbFminus.Text + Environment.NewLine/*"\r\n"*/;


                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }

       /* private void gbIgnition_Enter(object sender, EventArgs e)
        {

        }*/

        /*private void btPlusSint_MouseDown(object sender, MouseEventArgs e)
        {
           
                if(e.Button == MouseButtons.Left)
                                {
                    txMesenger.Text = txMesenger.Text+"1";
                                }
               
                

           
        }*/
   
        //-----------------двигает полосу прокрутки-----------------------------------------
        private void txMesenger_TextChanged(object sender, EventArgs e)
        {
            //--------двигает полосу прокрутки вниз
            
            {
                txMesenger.SelectionStart = txMesenger.Text.Length;
                txMesenger.ScrollToCaret();
                //txMesenger.Refresh();
            }
        }

        //-------отсылает строку в порт без символа переноса строки то есть без ENTRE
        void Sendasc(string str)
        {
            ResetFlagAll();
            serialPort1.Write(str);
            serialPort1.DiscardOutBuffer();
          //  SendascFlag = 1;

        }

        //**********************************
        //---------если нажали кнопку на клавиатуре 

        //-------нажатие кнопок правельное
        private void Generation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txCommand.Focused && !tbFplus.Focused && !tbFminus.Focused && !nUpDownSetLamp.Focused && !tbSerialN.Focused && !nUpDownSetNumber.Focused &&!txCommand.Focused)
                try
                {


                    //----------включение форсиров подогрева
                    if (e.KeyChar == '3')
                    {
                        Sendasc("3");
                        txMesenger.Text = txMesenger.Text + "3\t включение форсированного подогрева" + Environment.NewLine;
                        HeatOFFFlag = 1;
                        return;
                    }
                    //-------------выключение форсиров подогрева
                    if (e.KeyChar == '2')
                    {
                        Sendasc("2");
                        txMesenger.Text = txMesenger.Text + "2\t выключение форсированного подогрева" + Environment.NewLine;
                        HeatONFlag = 1;
                        return;
                    }
                    //----------включение зажигания
                    if (e.KeyChar == '1')
                    {
                        Sendasc("1");
                        txMesenger.Text = txMesenger.Text + "1\t включение зажигание" + Environment.NewLine;
                        IgnitionONFlag = 1;
                        return;
                    }
                    //-------------выключение зажигания
                    if (e.KeyChar == '0')
                    {
                        Sendasc("0");
                        txMesenger.Text = txMesenger.Text + "0\t выключение зажигание" + Environment.NewLine;
                        IgnitionOFFFlag = 1;
                        return;
                    }

                    //-------------Включена автоподстройка

                    if (e.KeyChar == 'g')
                    {
                        Sendasc("g");
                        txMesenger.Text = txMesenger.Text + "Включена автоподстройка" + Environment.NewLine;
                        btIgnitionONSet = 1;
                        return;
                    }

                    //----------"Выключена автоподстройка
                    if (e.KeyChar == 'h')
                    {
                        Sendasc("h");
                        txMesenger.Text = txMesenger.Text + "Выключена автоподстройка" + Environment.NewLine;
                        btIgnitionONSet = 0;
                        return;
                    }

                    //----------Если выключена автоподстройка регулировка
                    if (btIgnitionONSet == 0)
                    {
                        if (e.KeyChar == 'a')
                        {
                            Sendasc("a");
                            SendascFlag = 1;
                        }

                        if (e.KeyChar == 's')
                        {

                            Sendasc("s");
                            SendascFlag = 1;
                        }
                        if (e.KeyChar == 'c')
                        {
                            Sendasc("c");
                            SintezSbroslag = 1;
                        }


                    }
                    else
                    {
                        txMesenger.Text = txMesenger.Text + "Включена автоподстройка" + Environment.NewLine;
                    }
                    
                    //---------- проверка уровня фототока 
                        if (e.KeyChar == 'X')
                         {

                          Sendasc("X");
                          LampLookPhotoFlagg = 1;
                           txMesenger.Text = txMesenger.Text + Convert.ToString('X') + "\t проверка установленого порога лампы" + Environment.NewLine/*"\r\n"*/;
                            return;
                        }
                    //---------- проверка входной секунды 
                    if (e.KeyChar == 'S')
                    {

                        Sendasc("S");
                        SendascFlag = 1;
                        txMesenger.Text = txMesenger.Text + Convert.ToString('S') + "\t проверка установленого порога лампы" + Environment.NewLine/*"\r\n"*/;
                        return;
                    }

                    //---------- проверка температуры 
                    if (e.KeyChar == 't')
                    {

                        Sendasc("t");
                        SendascFlag = 1;
                        txMesenger.Text = txMesenger.Text + Convert.ToString('t') + "\t проверка установленого порога лампы" + Environment.NewLine/*"\r\n"*/;
                        return;
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


        



        }

         private void btSendCMLIST_Click(object sender, EventArgs e)
        {
           
            
                try
                {
                    if (cbCommand.Text != null && checkBoxCommandList.Checked)
                    {
                    string value = ((KeyValuePair<string, string>)cbCommand.SelectedItem).Value;
                    Sendasc(value);
                    SendascFlag = 1;
                    txMesenger.Text = txMesenger.Text + Convert.ToString(value) + "\t проверка установленого порога лампы" + Environment.NewLine/*"\r\n"*/;
                    return;


                }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            
        }



        //----------если нажали кнопку  

        /* private void Generation_KeyDown_1(object sender, KeyEventArgs e)
         {
             if(!txCommand.Focused&&!tbFplus.Focused&&!tbFminus.Focused&&!nUpDownSetLamp.Focused&&!tbSerialN.Focused&&!nUpDownSetNumber.Focused)
             try
             {


                     //----------включение форсиров подогрева
                     if (e.KeyData == Keys.D3)
                 {
                     Sendasc("3");
                     txMesenger.Text = txMesenger.Text + "3\t включение форсированного подогрева" + Environment.NewLine;
                     HeatOFFFlag = 1; 
                     return;
                 }
                 //-------------выключение форсиров подогрева
                 if (e.KeyData == Keys.D2)
                 {
                     Sendasc("2");
                     txMesenger.Text = txMesenger.Text + "2\t выключение форсированного подогрева" + Environment.NewLine;
                     HeatONFlag = 1; 
                     return;
                 }
                 //----------включение зажигания
                 if (e.KeyData == Keys.D1)
                 {
                     Sendasc("1");
                     txMesenger.Text = txMesenger.Text + "1\t включение зажигание" + Environment.NewLine;
                     IgnitionONFlag = 1;
                     return;
                 }
                 //-------------выключение зажигания
                 if (e.KeyData == Keys.D0)
                 {
                     Sendasc("0");
                     txMesenger.Text = txMesenger.Text + "0\t выключение зажигание" + Environment.NewLine;
                     IgnitionOFFFlag = 1;
                     return;
                 }







                 if (e.KeyData == Keys.G)
                 {
                     Sendasc("g");
                     txMesenger.Text = txMesenger.Text + "Включена автоподстройка" + Environment.NewLine;
                     btIgnitionONSet = 1;
                     return;
                 }
                 if (e.KeyData == Keys.H)
                 {
                     Sendasc("h");
                     txMesenger.Text = txMesenger.Text + "Выключена автоподстройка" + Environment.NewLine;
                     btIgnitionONSet = 0;
                     return;
                 }

                 if (btIgnitionONSet == 0)
                 {
                     if (e.KeyData == Keys.A)
                     {
                         Sendasc("a");
                     }

                     if (e.KeyData == Keys.S)
                     {

                         Sendasc("s");
                     }
                     if (e.KeyData == Keys.C)
                     {
                         Sendasc("c");
                     }


                 }
                 else
                 {
                     txMesenger.Text = txMesenger.Text + "Включена автоподстройка" + Environment.NewLine;
                 }
             }
             catch (Exception ex)
             {

                 MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

         }*/







        //*****************************************
        //---------**************кнопки на форме

        //--------------увеличение частоты с кнопки
        private void btPlusSint_Click(object sender, EventArgs e)
        {
            try
            {
                if (btIgnitionONSet == 0)
                {
                    ResetFlagAll();
                    serialPort1.Write("a");
                    SendascFlag = 1;
                }
                else
                {
                    txMesenger.Text = txMesenger.Text + "Включена автоподстройка" + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        //-------------уменьшение частоты с кнопки
        private void btMinusSint_Click(object sender, EventArgs e)
        {
            try
            {
                if (btIgnitionONSet == 0)
                {
                    ResetFlagAll();
                    serialPort1.Write("s");
                    SendascFlag = 1;
                }
                else
                {
                    txMesenger.Text = txMesenger.Text + "Включена автоподстройка" + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-----------------Если нажали послать команду
        private void btSendCMV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txCommand.Text != null && checkBoxCommandVVod.Checked)
                {
                    SendFlag = 1;
                    serialPort1.Write(txCommand.Text);
                    
                    serialPort1.DiscardOutBuffer();
                    txMesenger.Text = txMesenger.Text + txCommand.Text + Environment.NewLine/*"\r\n"*/;
                    txCommand.Clear();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //----------------если нажали проверка установленого порога лампы
        private void button1_Click_1(object sender, EventArgs e)
        {
            Sendasc("X");
            LampLookPhotoFlagg = 1;
            txMesenger.Text = txMesenger.Text + Convert.ToString('X') + "\t проверка установленого порога лампы" + Environment.NewLine/*"\r\n"*/;
        }


          //--------------если нажали серийный номер установить

         private void btSetSerialN_Click(object sender, EventArgs e)
        {
            try
            {
                if (nUpDownSetNumber.Value < 10) Sendasc("Z 00" + nUpDownSetNumber.Value);
                if (nUpDownSetNumber.Value > 10 && nUpDownSetNumber.Value < 100) Sendasc("Z 0" + nUpDownSetNumber.Value);
                if (nUpDownSetNumber.Value > 100 && nUpDownSetNumber.Value < 1000) Sendasc("Z " + nUpDownSetNumber.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----------------если нажали установка порога лампы
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    // if (nUpDownSetLamp.Value < 10) Sendasc("y 00" + nUpDownSetLamp.Value);
                    // if (nUpDownSetLamp.Value > 10 && nUpDownSetLamp.Value < 100) Sendasc("y 0" + nUpDownSetLamp.Value);
                    // if (nUpDownSetLamp.Value > 100 && nUpDownSetLamp.Value < 410) Sendasc("y " + nUpDownSetLamp.Value);
                    Sendasc("Y " + nUpDownSetLamp.Value);
                    LampPorogFlagg = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        //------------нажали Сброс синтезатора

        private void btSbrosSintez_Click(object sender, EventArgs e)
        {
            try
            {

                if (btIgnitionONSet == 0)
                {
                    ResetFlagAll();


                    if (serialPort1.IsOpen)
                    {



                        serialPort1.WriteLine(Convert.ToString('c'));
                        SintezSbroslag = 1;
                        txMesenger.Text = txMesenger.Text + Convert.ToString('c') + "\t сброс настроек синтезатора" + Environment.NewLine/*"\r\n"*/;


                    }


                }
                else
                {
                    txMesenger.Text = txMesenger.Text + "Включена автоподстройка" + Environment.NewLine;
                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----------включение  зажигания
        private void button4_Click(object sender, EventArgs e)
        {
            ResetFlagAll();
            try
            {

                if (serialPort1.IsOpen)
                {



                    serialPort1.WriteLine(Convert.ToString('1'));
                    IgnitionONFlag = 1;
                    txMesenger.Text = txMesenger.Text + Convert.ToString('1') + "\t включение зажигание" + Environment.NewLine/*"\r\n"*/;
                    

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        //----------выключение  зажигания
        private void button3_Click(object sender, EventArgs e)
        {
            ResetFlagAll();
            try
            {

                if (serialPort1.IsOpen)
                {



                    serialPort1.WriteLine(Convert.ToString('0'));
                    IgnitionOFFFlag = 1;
                    txMesenger.Text = txMesenger.Text + Convert.ToString('0') + "\t выключение зажигание" + Environment.NewLine/*"\r\n"*/;


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        

        //----------включениея подогрев 
        private void btHeatON_Click(object sender, EventArgs e)
        {
            ResetFlagAll();
            try
            {

                if (serialPort1.IsOpen)
                {



                    serialPort1.WriteLine(Convert.ToString('3'));
                    HeatONFlag = 1;
                    txMesenger.Text = txMesenger.Text + Convert.ToString('3') + "\t включение форсированного подогрева" + Environment.NewLine/*"\r\n"*/;


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
        //----------выключение подогрева
        private void btHeatOFF_Click(object sender, EventArgs e)
        {
            ResetFlagAll();
            try
            {

                if (serialPort1.IsOpen)
                {



                    serialPort1.WriteLine(Convert.ToString('2'));
                    HeatOFFFlag = 1;
                    txMesenger.Text = txMesenger.Text + Convert.ToString('2') + "\t выключение форсированного подогрева" + Environment.NewLine/*"\r\n"*/;


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        
        //----------включение автоподстройки
        private void btIgnitionON_Click(object sender, EventArgs e)
        {
            ResetFlagAll();
            btIgnitionONSet = 0;// флаг включения автоподстройки
            try
            {
               
                    if (serialPort1.IsOpen)
                    {
                        


                        serialPort1.WriteLine(Convert.ToString('h'));
                        AutoTuneONFlag = 1;
                        txMesenger.Text = txMesenger.Text + Convert.ToString('h')+ "\t выключение автоподстройки" + Environment.NewLine/*"\r\n"*/;


                    }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        //----------выключение автоподстройки
        private void btIgnitionOFF_Click(object sender, EventArgs e)
        {
            ResetFlagAll();
            btIgnitionONSet = 1;
            try
            {

                if (serialPort1.IsOpen)
                {



                    serialPort1.WriteLine(Convert.ToString('g'));
                    AutoTuneOFFFlag = 1;
                    txMesenger.Text = txMesenger.Text + Convert.ToString('g') +"\t включение автоподстройки"+ Environment.NewLine/*"\r\n"*/;


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //---------------серийный номер
        private void btSerialN_Click(object sender, EventArgs e)
        {
            ResetFlagAll();
            try
            {

                if (serialPort1.IsOpen)
                {



                    serialPort1.WriteLine(Convert.ToString('N'));
                    SerialNumberFlag = 1;
                    txMesenger.Text = txMesenger.Text + Convert.ToString('N') + "\t серийный номер" + Environment.NewLine/*"\r\n"*/;


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----------------сброс настроек 
        private void btReset_Click(object sender, EventArgs e)
        {
            ResetFlagAll();
            if (serialPort1.IsOpen)
            {

                serialPort1.WriteLine(Convert.ToString('Z'));
                ResetFlag = 1;
                txMesenger.Text = txMesenger.Text + Convert.ToString('Z' + "\t сброс настроек")+ Environment.NewLine; 
                

            }
        }
        //***********
        
        
        //****************************
       

        //************-------------приём данных-----------------*****************
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            /* char[] reseverF = new char[3];
             reseverF[0] = 'g';
             reseverF[1] = 'k';
             reseverF[2] = 'l';*/
            //TimerResever.Start();
            string temp ;
            try
            {
                if (serialPort1.IsOpen)
                {
                    //----------если было запущено F
                    if (Fflag == 1)
                    {
                        tbF.Text = "";

                        //serialPort1.DiscardInBuffer();
                        //reseverF[0]= Convert.ToChar(serialPort1.ReadByte());
                        temp = serialPort1.ReadLine();
                        txMesenger.Text = txMesenger.Text + temp;//Convert.ToChar(serialPort1.ReadByte());
                        temp = temp.Trim(new char[] { 'F', });
                        tbF.Text = tbF.Text + temp;

                        /* reseverF[0] = Convert.ToChar(serialPort1.ReadByte());
                         txMesenger.Text = txMesenger.Text + reseverF[0];//Convert.ToChar(serialPort1.ReadByte());
                         tbF.Text = tbF.Text + reseverF[0];

                         reseverF[0] = Convert.ToChar(serialPort1.ReadByte());
                         txMesenger.Text = txMesenger.Text + reseverF[0];//Convert.ToChar(serialPort1.ReadByte());
                         tbF.Text = tbF.Text + reseverF[0];*/


                        Fflag = 0;
                        txMesenger.Text = txMesenger.Text + Environment.NewLine;

                    }

                    //----------если было запущено P
                    if (Pflag == 1)
                    {

                        temp = serialPort1.ReadLine();
                        txMesenger.Text = txMesenger.Text + temp;//Convert.ToChar(serialPort1.ReadByte());



                        Pflag = 0;
                        txMesenger.Text = txMesenger.Text + Environment.NewLine;

                        // txMesenger.Text = txMesenger.Text + temp;//Convert.ToChar(serialPort1.ReadByte());
                        tbF.Text = null;
                        temp = temp.Trim(new char[] { 'F', });
                        tbF.Text = tbF.Text + temp;




                    }

                    //----------если было запущено M
                    if (Mflag == 1)
                    {

                        temp = serialPort1.ReadLine();
                        txMesenger.Text = txMesenger.Text + temp;//Convert.ToChar(serialPort1.ReadByte());



                        Mflag = 0;
                        txMesenger.Text = txMesenger.Text + Environment.NewLine;

                        tbF.Text = null;
                        temp = temp.Trim(new char[] { 'F', });
                        tbF.Text = tbF.Text + temp;


                    }

                    //----------если было запущено IgnitioinON
                    if (IgnitionONFlag == 1)
                    {

                        temp = serialPort1.ReadLine();
                        txMesenger.Text = txMesenger.Text + temp + Environment.NewLine; ;//Convert.ToChar(serialPort1.ReadByte());
                        IgnitionONFlag = 0;

                    }

                    //----------если было запущено IgnitioinOFF
                    if (IgnitionOFFFlag == 1)
                    {

                        temp = serialPort1.ReadLine();
                        txMesenger.Text = txMesenger.Text + temp + Environment.NewLine; ;//Convert.ToChar(serialPort1.ReadByte());
                        IgnitionOFFFlag = 0;

                    }
                    //------------если был включён подогрев
                    if (HeatONFlag == 1)
                    {

                        temp = serialPort1.ReadLine();
                        txMesenger.Text = txMesenger.Text + temp + Environment.NewLine; ;//Convert.ToChar(serialPort1.ReadByte());
                        HeatONFlag = 0;

                    }
                    //------------если был выключён подогрев
                    if (HeatOFFFlag == 1)
                    {

                        temp = serialPort1.ReadLine();
                        txMesenger.Text = txMesenger.Text + temp + Environment.NewLine; ;//Convert.ToChar(serialPort1.ReadByte());
                        HeatOFFFlag = 0;

                    }

                    //------------если был включён подогрев
                    if (AutoTuneONFlag == 1)
                    {

                        temp = serialPort1.ReadLine();
                        txMesenger.Text = txMesenger.Text + temp + Environment.NewLine; ;//Convert.ToChar(serialPort1.ReadByte());
                        AutoTuneONFlag = 0;

                    }
                    //------------если был выключён подогрев
                    if (AutoTuneOFFFlag == 1)
                    {

                        temp = serialPort1.ReadLine();
                        txMesenger.Text = txMesenger.Text + temp + Environment.NewLine; ;//Convert.ToChar(serialPort1.ReadByte());
                        AutoTuneOFFFlag = 0;

                    }
                    //------------------если был нажат сброс синтезатора

                    if (SintezSbroslag== 1)
                    {

                        temp = serialPort1.ReadLine();
                        txMesenger.Text = txMesenger.Text + temp + Environment.NewLine; ;//Convert.ToChar(serialPort1.ReadByte());
                        SintezSbroslag = 0;

                    }

                    //--------------если был нажат серийный номер
                    if (SerialNumberFlag == 1)
                    {
                        temp = serialPort1.ReadLine();
                        temp = serialPort1.ReadLine();
                        txMesenger.Text = txMesenger.Text + temp.Trim(new char[] { 'N', '\r', '\n' });//temp;//Convert.ToChar(serialPort1.ReadByte());



                        SerialNumberFlag = 0;
                        txMesenger.Text = txMesenger.Text + Environment.NewLine;

                        tbSerialN.Text = null;
                        tbSerialN.Text = temp.Trim(new char[] {'N', '\r','\n' });

                    }
                    //-----------если был нажат ресет-------------
                    if (ResetFlag == 1)
                    {
                        temp = serialPort1.ReadLine();
                        temp = serialPort1.ReadLine();
                        txMesenger.Text = txMesenger.Text + "Z "+temp;//Convert.ToChar(serialPort1.ReadByte());

                        tbSerialN.Text = null;
                        tbSerialN.Text = temp.Trim(new char[] { 'N','\r','\n' });


                        txMesenger.Text = txMesenger.Text /*tbSerialN.Text*/ + Environment.NewLine/*"\r\n"*/;
                        serialPort1.WriteLine("Z "+tbSerialN.Text);

                        ResetFlag = 0;
                        
                    }
                    //-----------------Если нажали послать команду
                    if (SendFlag == 1)
                    {
                        SendFlag = 0;
                        txMesenger.Text = txMesenger.Text + serialPort1.ReadExisting()/*tbSerialN.Text*/ + Environment.NewLine;
                        
                    }
                    //------------если нажали установку порога лампы
                    if (LampPorogFlagg == 1)
                    {

                        temp = serialPort1.ReadLine();
                        serialPort1.DiscardOutBuffer();
                        temp = serialPort1.ReadLine();
                        
                        txMesenger.Text = txMesenger.Text + temp + Environment.NewLine; ;//Convert.ToChar(serialPort1.ReadByte());
                        LampPorogFlagg = 0;

                    }

                    //-----------если нажали проверка фототока 
                    if (LampLookPhotoFlagg == 1)
                    {

                        temp = serialPort1.ReadLine();
                        serialPort1.DiscardOutBuffer();
                        temp = serialPort1.ReadLine();
                        String[] str = temp.Split(' ');
                        if (str.Length > 3 && str != null)
                        {
                            if (str[1] != null) photoCurrent.Text = str[1];
                            if (str[5] != null) porogLamp.Text = str[5];
                        }
                        txMesenger.Text = txMesenger.Text + temp + Environment.NewLine;


                        LampLookPhotoFlagg = 0;

                    }

                    //------------если нажали Sendasc
                    if (SendascFlag == 1)
                    {

                        temp = serialPort1.ReadExisting();
                       
                        txMesenger.Text = txMesenger.Text + temp + Environment.NewLine; ;//Convert.ToChar(serialPort1.ReadByte());
                        SendascFlag = 0;

                    }
                    serialPort1.DiscardInBuffer();




                    serialPort1.DiscardInBuffer();



                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btClear_Click(object sender, EventArgs e)
        {
            txMesenger.Clear();
        }
      


    
    }
}
