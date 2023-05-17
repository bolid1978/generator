namespace WindowsFormsApp1
{
    partial class Generation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generation));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.LbPort = new System.Windows.Forms.Label();
            this.txCommand = new System.Windows.Forms.TextBox();
            this.LbCommand = new System.Windows.Forms.Label();
            this.Lblist = new System.Windows.Forms.Label();
            this.cbCommand = new System.Windows.Forms.ComboBox();
            this.lbZagolovok = new System.Windows.Forms.Label();
            this.checkBoxCommandVVod = new System.Windows.Forms.CheckBox();
            this.checkBoxCommandList = new System.Windows.Forms.CheckBox();
            this.tbF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSendCMV = new System.Windows.Forms.Button();
            this.btSendCMLIST = new System.Windows.Forms.Button();
            this.btFlook = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btSerialN = new System.Windows.Forms.Button();
            this.btFplus = new System.Windows.Forms.Button();
            this.btFminus = new System.Windows.Forms.Button();
            this.tbFplus = new System.Windows.Forms.TextBox();
            this.tbFminus = new System.Windows.Forms.TextBox();
            this.tbSerialN = new System.Windows.Forms.TextBox();
            this.btIgnitionOFF = new System.Windows.Forms.Button();
            this.btIgnitionON = new System.Windows.Forms.Button();
            this.gbIgnition = new System.Windows.Forms.GroupBox();
            this.buttonTime = new System.Windows.Forms.Button();
            this.btSbrosSintez = new System.Windows.Forms.Button();
            this.btMinusSint = new System.Windows.Forms.Button();
            this.btPlusSint = new System.Windows.Forms.Button();
            this.gbHeat = new System.Windows.Forms.GroupBox();
            this.btHeatOFF = new System.Windows.Forms.Button();
            this.btHeatON = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gbTune = new System.Windows.Forms.GroupBox();
            this.gbNumberAndReset = new System.Windows.Forms.GroupBox();
            this.nUpDownSetNumber = new System.Windows.Forms.NumericUpDown();
            this.btSetSerialN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPort = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.gbCommand = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txMesenger = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.TimerResever = new System.Windows.Forms.Timer(this.components);
            this.gbSetLamp = new System.Windows.Forms.GroupBox();
            this.nUpDownSetLamp = new System.Windows.Forms.NumericUpDown();
            this.btSetLamp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.porogLamp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.photoCurrent = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxText = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbIgnition.SuspendLayout();
            this.gbHeat.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbTune.SuspendLayout();
            this.gbNumberAndReset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownSetNumber)).BeginInit();
            this.gbPort.SuspendLayout();
            this.gbCommand.SuspendLayout();
            this.gbSetLamp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownSetLamp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(222, 41);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(148, 40);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(68, 30);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(17, 50);
            this.cbPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(107, 21);
            this.cbPort.TabIndex = 4;
            // 
            // LbPort
            // 
            this.LbPort.AutoSize = true;
            this.LbPort.Location = new System.Drawing.Point(15, 22);
            this.LbPort.Name = "LbPort";
            this.LbPort.Size = new System.Drawing.Size(71, 13);
            this.LbPort.TabIndex = 7;
            this.LbPort.Text = "выбор порта";
            // 
            // txCommand
            // 
            this.txCommand.Location = new System.Drawing.Point(24, 50);
            this.txCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txCommand.Multiline = true;
            this.txCommand.Name = "txCommand";
            this.txCommand.Size = new System.Drawing.Size(105, 44);
            this.txCommand.TabIndex = 8;
            this.txCommand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbCommand
            // 
            this.LbCommand.AutoSize = true;
            this.LbCommand.Location = new System.Drawing.Point(20, 20);
            this.LbCommand.Name = "LbCommand";
            this.LbCommand.Size = new System.Drawing.Size(108, 13);
            this.LbCommand.TabIndex = 9;
            this.LbCommand.Text = "Команды для ввода";
            // 
            // Lblist
            // 
            this.Lblist.AutoSize = true;
            this.Lblist.Location = new System.Drawing.Point(171, 20);
            this.Lblist.Name = "Lblist";
            this.Lblist.Size = new System.Drawing.Size(141, 13);
            this.Lblist.TabIndex = 10;
            this.Lblist.Text = "Список доступных команд";
            // 
            // cbCommand
            // 
            this.cbCommand.AllowDrop = true;
            this.cbCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCommand.FormattingEnabled = true;
            this.cbCommand.Items.AddRange(new object[] {
            "посмотреть температуру",
            "ghh"});
            this.cbCommand.Location = new System.Drawing.Point(156, 47);
            this.cbCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCommand.Name = "cbCommand";
            this.cbCommand.Size = new System.Drawing.Size(194, 24);
            this.cbCommand.TabIndex = 11;
            // 
            // lbZagolovok
            // 
            this.lbZagolovok.AutoSize = true;
            this.lbZagolovok.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbZagolovok.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbZagolovok.Location = new System.Drawing.Point(442, 6);
            this.lbZagolovok.Name = "lbZagolovok";
            this.lbZagolovok.Size = new System.Drawing.Size(236, 29);
            this.lbZagolovok.TabIndex = 12;
            this.lbZagolovok.Text = "основные команды";
            // 
            // checkBoxCommandVVod
            // 
            this.checkBoxCommandVVod.AutoSize = true;
            this.checkBoxCommandVVod.Location = new System.Drawing.Point(135, 50);
            this.checkBoxCommandVVod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxCommandVVod.Name = "checkBoxCommandVVod";
            this.checkBoxCommandVVod.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCommandVVod.TabIndex = 13;
            this.checkBoxCommandVVod.UseVisualStyleBackColor = true;
            // 
            // checkBoxCommandList
            // 
            this.checkBoxCommandList.AutoSize = true;
            this.checkBoxCommandList.Location = new System.Drawing.Point(356, 52);
            this.checkBoxCommandList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxCommandList.Name = "checkBoxCommandList";
            this.checkBoxCommandList.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCommandList.TabIndex = 14;
            this.checkBoxCommandList.UseVisualStyleBackColor = true;
            this.checkBoxCommandList.CheckedChanged += new System.EventHandler(this.checkBoxCommandList_CheckedChanged);
            // 
            // tbF
            // 
            this.tbF.Location = new System.Drawing.Point(11, 27);
            this.tbF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbF.Name = "tbF";
            this.tbF.ReadOnly = true;
            this.tbF.Size = new System.Drawing.Size(217, 20);
            this.tbF.TabIndex = 15;
            this.tbF.Text = "0";
            this.tbF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 16;
            // 
            // btSendCMV
            // 
            this.btSendCMV.Location = new System.Drawing.Point(40, 108);
            this.btSendCMV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSendCMV.Name = "btSendCMV";
            this.btSendCMV.Size = new System.Drawing.Size(68, 30);
            this.btSendCMV.TabIndex = 18;
            this.btSendCMV.Text = "Send";
            this.btSendCMV.UseVisualStyleBackColor = true;
            this.btSendCMV.Click += new System.EventHandler(this.btSendCMV_Click);
            // 
            // btSendCMLIST
            // 
            this.btSendCMLIST.Location = new System.Drawing.Point(195, 108);
            this.btSendCMLIST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSendCMLIST.Name = "btSendCMLIST";
            this.btSendCMLIST.Size = new System.Drawing.Size(118, 30);
            this.btSendCMLIST.TabIndex = 19;
            this.btSendCMLIST.Text = "Send";
            this.btSendCMLIST.UseVisualStyleBackColor = true;
            this.btSendCMLIST.Click += new System.EventHandler(this.btSendCMLIST_Click);
            // 
            // btFlook
            // 
            this.btFlook.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFlook.Location = new System.Drawing.Point(230, 27);
            this.btFlook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btFlook.Name = "btFlook";
            this.btFlook.Size = new System.Drawing.Size(156, 121);
            this.btFlook.TabIndex = 22;
            this.btFlook.Text = "Просмотр текущей частоты";
            this.btFlook.UseVisualStyleBackColor = true;
            this.btFlook.Click += new System.EventHandler(this.btFlook_Click);
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btReset.Location = new System.Drawing.Point(411, 578);
            this.btReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(125, 110);
            this.btReset.TabIndex = 24;
            this.btReset.Text = "сброс настроек генератора";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSerialN
            // 
            this.btSerialN.Location = new System.Drawing.Point(5, 17);
            this.btSerialN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSerialN.Name = "btSerialN";
            this.btSerialN.Size = new System.Drawing.Size(89, 39);
            this.btSerialN.TabIndex = 23;
            this.btSerialN.Text = "просмотр номера";
            this.btSerialN.UseVisualStyleBackColor = true;
            this.btSerialN.Click += new System.EventHandler(this.btSerialN_Click);
            // 
            // btFplus
            // 
            this.btFplus.ForeColor = System.Drawing.Color.Maroon;
            this.btFplus.Location = new System.Drawing.Point(11, 60);
            this.btFplus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btFplus.Name = "btFplus";
            this.btFplus.Size = new System.Drawing.Size(68, 38);
            this.btFplus.TabIndex = 20;
            this.btFplus.Text = "Частота плюс";
            this.btFplus.UseVisualStyleBackColor = true;
            this.btFplus.Click += new System.EventHandler(this.btFplus_Click);
            // 
            // btFminus
            // 
            this.btFminus.ForeColor = System.Drawing.Color.Navy;
            this.btFminus.Location = new System.Drawing.Point(11, 110);
            this.btFminus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btFminus.Name = "btFminus";
            this.btFminus.Size = new System.Drawing.Size(68, 38);
            this.btFminus.TabIndex = 25;
            this.btFminus.Text = "Частота минус";
            this.btFminus.UseVisualStyleBackColor = true;
            this.btFminus.Click += new System.EventHandler(this.btFminus_Click);
            // 
            // tbFplus
            // 
            this.tbFplus.Location = new System.Drawing.Point(95, 69);
            this.tbFplus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFplus.MaxLength = 3;
            this.tbFplus.Name = "tbFplus";
            this.tbFplus.Size = new System.Drawing.Size(90, 20);
            this.tbFplus.TabIndex = 26;
            this.tbFplus.Text = "000";
            this.tbFplus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbFminus
            // 
            this.tbFminus.Location = new System.Drawing.Point(95, 110);
            this.tbFminus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFminus.MaxLength = 3;
            this.tbFminus.Name = "tbFminus";
            this.tbFminus.Size = new System.Drawing.Size(90, 20);
            this.tbFminus.TabIndex = 27;
            this.tbFminus.Text = "000";
            this.tbFminus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSerialN
            // 
            this.tbSerialN.Location = new System.Drawing.Point(125, 27);
            this.tbSerialN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSerialN.Name = "tbSerialN";
            this.tbSerialN.ReadOnly = true;
            this.tbSerialN.Size = new System.Drawing.Size(106, 20);
            this.tbSerialN.TabIndex = 28;
            this.tbSerialN.Text = "0";
            this.tbSerialN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btIgnitionOFF
            // 
            this.btIgnitionOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btIgnitionOFF.ForeColor = System.Drawing.Color.Maroon;
            this.btIgnitionOFF.Location = new System.Drawing.Point(23, 20);
            this.btIgnitionOFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btIgnitionOFF.Name = "btIgnitionOFF";
            this.btIgnitionOFF.Size = new System.Drawing.Size(85, 61);
            this.btIgnitionOFF.TabIndex = 31;
            this.btIgnitionOFF.Text = "Включить автоподстр.";
            this.btIgnitionOFF.UseVisualStyleBackColor = true;
            this.btIgnitionOFF.Click += new System.EventHandler(this.btIgnitionOFF_Click);
            // 
            // btIgnitionON
            // 
            this.btIgnitionON.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btIgnitionON.ForeColor = System.Drawing.Color.Green;
            this.btIgnitionON.Location = new System.Drawing.Point(23, 91);
            this.btIgnitionON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btIgnitionON.Name = "btIgnitionON";
            this.btIgnitionON.Size = new System.Drawing.Size(85, 58);
            this.btIgnitionON.TabIndex = 30;
            this.btIgnitionON.Text = "Выключить автоподстр.";
            this.btIgnitionON.UseVisualStyleBackColor = true;
            this.btIgnitionON.Click += new System.EventHandler(this.btIgnitionON_Click);
            // 
            // gbIgnition
            // 
            this.gbIgnition.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbIgnition.Controls.Add(this.buttonTime);
            this.gbIgnition.Controls.Add(this.btSbrosSintez);
            this.gbIgnition.Controls.Add(this.btMinusSint);
            this.gbIgnition.Controls.Add(this.btPlusSint);
            this.gbIgnition.Controls.Add(this.btIgnitionOFF);
            this.gbIgnition.Controls.Add(this.btIgnitionON);
            this.gbIgnition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbIgnition.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gbIgnition.Location = new System.Drawing.Point(411, 245);
            this.gbIgnition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbIgnition.Name = "gbIgnition";
            this.gbIgnition.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbIgnition.Size = new System.Drawing.Size(125, 330);
            this.gbIgnition.TabIndex = 32;
            this.gbIgnition.TabStop = false;
            this.gbIgnition.Text = "Автоподстройка";
            // 
            // buttonTime
            // 
            this.buttonTime.Location = new System.Drawing.Point(6, 291);
            this.buttonTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTime.Name = "buttonTime";
            this.buttonTime.Size = new System.Drawing.Size(113, 30);
            this.buttonTime.TabIndex = 35;
            this.buttonTime.Text = "текущее время";
            this.buttonTime.UseVisualStyleBackColor = true;
            this.buttonTime.Click += new System.EventHandler(this.buttonTime_Click);
            // 
            // btSbrosSintez
            // 
            this.btSbrosSintez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSbrosSintez.ForeColor = System.Drawing.Color.Black;
            this.btSbrosSintez.Location = new System.Drawing.Point(23, 249);
            this.btSbrosSintez.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSbrosSintez.Name = "btSbrosSintez";
            this.btSbrosSintez.Size = new System.Drawing.Size(85, 35);
            this.btSbrosSintez.TabIndex = 34;
            this.btSbrosSintez.Text = "Сброс";
            this.btSbrosSintez.UseVisualStyleBackColor = true;
            this.btSbrosSintez.Click += new System.EventHandler(this.btSbrosSintez_Click);
            // 
            // btMinusSint
            // 
            this.btMinusSint.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMinusSint.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btMinusSint.Location = new System.Drawing.Point(37, 202);
            this.btMinusSint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMinusSint.Name = "btMinusSint";
            this.btMinusSint.Size = new System.Drawing.Size(58, 36);
            this.btMinusSint.TabIndex = 32;
            this.btMinusSint.Text = "-";
            this.btMinusSint.UseVisualStyleBackColor = true;
            this.btMinusSint.Click += new System.EventHandler(this.btMinusSint_Click);
            // 
            // btPlusSint
            // 
            this.btPlusSint.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPlusSint.ForeColor = System.Drawing.Color.Crimson;
            this.btPlusSint.Location = new System.Drawing.Point(37, 162);
            this.btPlusSint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btPlusSint.Name = "btPlusSint";
            this.btPlusSint.Size = new System.Drawing.Size(58, 36);
            this.btPlusSint.TabIndex = 32;
            this.btPlusSint.Text = "+";
            this.btPlusSint.UseVisualStyleBackColor = true;
            this.btPlusSint.Click += new System.EventHandler(this.btPlusSint_Click);
            // 
            // gbHeat
            // 
            this.gbHeat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbHeat.Controls.Add(this.btHeatOFF);
            this.gbHeat.Controls.Add(this.btHeatON);
            this.gbHeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbHeat.Location = new System.Drawing.Point(542, 245);
            this.gbHeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbHeat.Name = "gbHeat";
            this.gbHeat.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbHeat.Size = new System.Drawing.Size(138, 163);
            this.gbHeat.TabIndex = 33;
            this.gbHeat.TabStop = false;
            this.gbHeat.Text = "Подогрев ";
            // 
            // btHeatOFF
            // 
            this.btHeatOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btHeatOFF.ForeColor = System.Drawing.Color.ForestGreen;
            this.btHeatOFF.Location = new System.Drawing.Point(33, 93);
            this.btHeatOFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHeatOFF.Name = "btHeatOFF";
            this.btHeatOFF.Size = new System.Drawing.Size(81, 61);
            this.btHeatOFF.TabIndex = 31;
            this.btHeatOFF.Text = "Выключить фор. подогрев";
            this.btHeatOFF.UseVisualStyleBackColor = true;
            this.btHeatOFF.Click += new System.EventHandler(this.btHeatOFF_Click);
            // 
            // btHeatON
            // 
            this.btHeatON.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btHeatON.ForeColor = System.Drawing.Color.Maroon;
            this.btHeatON.Location = new System.Drawing.Point(33, 20);
            this.btHeatON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHeatON.Name = "btHeatON";
            this.btHeatON.Size = new System.Drawing.Size(81, 58);
            this.btHeatON.TabIndex = 30;
            this.btHeatON.Text = "Включить фор. подогрев";
            this.btHeatON.UseVisualStyleBackColor = true;
            this.btHeatON.Click += new System.EventHandler(this.btHeatON_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(686, 242);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(119, 165);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Зажигание";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.ForestGreen;
            this.button3.Location = new System.Drawing.Point(17, 93);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 61);
            this.button3.TabIndex = 31;
            this.button3.Text = "Выключить зажгание";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(17, 20);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 58);
            this.button4.TabIndex = 30;
            this.button4.Text = "Включить Зажигание";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // gbTune
            // 
            this.gbTune.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbTune.Controls.Add(this.btFplus);
            this.gbTune.Controls.Add(this.btFminus);
            this.gbTune.Controls.Add(this.tbFplus);
            this.gbTune.Controls.Add(this.tbFminus);
            this.gbTune.Controls.Add(this.tbF);
            this.gbTune.Controls.Add(this.btFlook);
            this.gbTune.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTune.Location = new System.Drawing.Point(413, 52);
            this.gbTune.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTune.Name = "gbTune";
            this.gbTune.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTune.Size = new System.Drawing.Size(392, 160);
            this.gbTune.TabIndex = 35;
            this.gbTune.TabStop = false;
            this.gbTune.Text = "Подстройка частоты";
            // 
            // gbNumberAndReset
            // 
            this.gbNumberAndReset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbNumberAndReset.Controls.Add(this.nUpDownSetNumber);
            this.gbNumberAndReset.Controls.Add(this.btSetSerialN);
            this.gbNumberAndReset.Controls.Add(this.btSerialN);
            this.gbNumberAndReset.Controls.Add(this.tbSerialN);
            this.gbNumberAndReset.Location = new System.Drawing.Point(542, 578);
            this.gbNumberAndReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbNumberAndReset.Name = "gbNumberAndReset";
            this.gbNumberAndReset.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbNumberAndReset.Size = new System.Drawing.Size(264, 110);
            this.gbNumberAndReset.TabIndex = 36;
            this.gbNumberAndReset.TabStop = false;
            this.gbNumberAndReset.Text = "Номер";
            // 
            // nUpDownSetNumber
            // 
            this.nUpDownSetNumber.Location = new System.Drawing.Point(125, 73);
            this.nUpDownSetNumber.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUpDownSetNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownSetNumber.Name = "nUpDownSetNumber";
            this.nUpDownSetNumber.Size = new System.Drawing.Size(106, 20);
            this.nUpDownSetNumber.TabIndex = 30;
            this.nUpDownSetNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUpDownSetNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btSetSerialN
            // 
            this.btSetSerialN.Location = new System.Drawing.Point(6, 60);
            this.btSetSerialN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSetSerialN.Name = "btSetSerialN";
            this.btSetSerialN.Size = new System.Drawing.Size(88, 43);
            this.btSetSerialN.TabIndex = 29;
            this.btSetSerialN.Text = "установка номера";
            this.btSetSerialN.UseVisualStyleBackColor = true;
            this.btSetSerialN.Click += new System.EventHandler(this.btSetSerialN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(506, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Команды для настройки";
            // 
            // gbPort
            // 
            this.gbPort.BackColor = System.Drawing.SystemColors.Control;
            this.gbPort.Controls.Add(this.buttonRefresh);
            this.gbPort.Controls.Add(this.btnOpen);
            this.gbPort.Controls.Add(this.cbPort);
            this.gbPort.Controls.Add(this.btnClose);
            this.gbPort.Controls.Add(this.LbPort);
            this.gbPort.Location = new System.Drawing.Point(11, 43);
            this.gbPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPort.Name = "gbPort";
            this.gbPort.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPort.Size = new System.Drawing.Size(377, 97);
            this.gbPort.TabIndex = 38;
            this.gbPort.TabStop = false;
            this.gbPort.Text = "Выбор порта";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(296, 41);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(68, 30);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // gbCommand
            // 
            this.gbCommand.BackColor = System.Drawing.SystemColors.Control;
            this.gbCommand.Controls.Add(this.cbCommand);
            this.gbCommand.Controls.Add(this.Lblist);
            this.gbCommand.Controls.Add(this.checkBoxCommandList);
            this.gbCommand.Controls.Add(this.btSendCMLIST);
            this.gbCommand.Controls.Add(this.LbCommand);
            this.gbCommand.Controls.Add(this.txCommand);
            this.gbCommand.Controls.Add(this.checkBoxCommandVVod);
            this.gbCommand.Controls.Add(this.btSendCMV);
            this.gbCommand.Location = new System.Drawing.Point(11, 154);
            this.gbCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCommand.Size = new System.Drawing.Size(377, 143);
            this.gbCommand.TabIndex = 39;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = "Ввод команд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(506, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Настройка частоты";
            // 
            // txMesenger
            // 
            this.txMesenger.Location = new System.Drawing.Point(10, 309);
            this.txMesenger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txMesenger.Multiline = true;
            this.txMesenger.Name = "txMesenger";
            this.txMesenger.ReadOnly = true;
            this.txMesenger.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txMesenger.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txMesenger.Size = new System.Drawing.Size(378, 316);
            this.txMesenger.TabIndex = 41;
            this.txMesenger.WordWrap = false;
            this.txMesenger.TextChanged += new System.EventHandler(this.txMesenger_TextChanged);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(12, 645);
            this.btClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(93, 40);
            this.btClear.TabIndex = 42;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // TimerResever
            // 
            this.TimerResever.Interval = 1000;
            // 
            // gbSetLamp
            // 
            this.gbSetLamp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbSetLamp.Controls.Add(this.nUpDownSetLamp);
            this.gbSetLamp.Controls.Add(this.btSetLamp);
            this.gbSetLamp.Location = new System.Drawing.Point(542, 411);
            this.gbSetLamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSetLamp.Name = "gbSetLamp";
            this.gbSetLamp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSetLamp.Size = new System.Drawing.Size(264, 64);
            this.gbSetLamp.TabIndex = 43;
            this.gbSetLamp.TabStop = false;
            this.gbSetLamp.Text = "Порог срабатывания лампы";
            // 
            // nUpDownSetLamp
            // 
            this.nUpDownSetLamp.Location = new System.Drawing.Point(125, 29);
            this.nUpDownSetLamp.Maximum = new decimal(new int[] {
            409,
            0,
            0,
            0});
            this.nUpDownSetLamp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownSetLamp.Name = "nUpDownSetLamp";
            this.nUpDownSetLamp.Size = new System.Drawing.Size(106, 20);
            this.nUpDownSetLamp.TabIndex = 25;
            this.nUpDownSetLamp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUpDownSetLamp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btSetLamp
            // 
            this.btSetLamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSetLamp.Location = new System.Drawing.Point(5, 16);
            this.btSetLamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSetLamp.Name = "btSetLamp";
            this.btSetLamp.Size = new System.Drawing.Size(89, 43);
            this.btSetLamp.TabIndex = 24;
            this.btSetLamp.Text = "Установка";
            this.btSetLamp.UseVisualStyleBackColor = true;
            this.btSetLamp.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.porogLamp);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.photoCurrent);
            this.groupBox1.Location = new System.Drawing.Point(542, 478);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(264, 96);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текущий парог лампы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(132, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "текущий порог";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(152, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "фототок";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // porogLamp
            // 
            this.porogLamp.Location = new System.Drawing.Point(125, 64);
            this.porogLamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.porogLamp.Name = "porogLamp";
            this.porogLamp.ReadOnly = true;
            this.porogLamp.Size = new System.Drawing.Size(106, 20);
            this.porogLamp.TabIndex = 30;
            this.porogLamp.Text = "0";
            this.porogLamp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(5, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 43);
            this.button1.TabIndex = 26;
            this.button1.Text = "Проверка порога ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // photoCurrent
            // 
            this.photoCurrent.Location = new System.Drawing.Point(125, 25);
            this.photoCurrent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.photoCurrent.Name = "photoCurrent";
            this.photoCurrent.ReadOnly = true;
            this.photoCurrent.Size = new System.Drawing.Size(106, 20);
            this.photoCurrent.TabIndex = 29;
            this.photoCurrent.Text = "0";
            this.photoCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 645);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 39);
            this.button2.TabIndex = 45;
            this.button2.Text = "запись текста окна";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxText
            // 
            this.checkBoxText.AutoSize = true;
            this.checkBoxText.Location = new System.Drawing.Point(185, 638);
            this.checkBoxText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxText.Name = "checkBoxText";
            this.checkBoxText.Size = new System.Drawing.Size(15, 14);
            this.checkBoxText.TabIndex = 46;
            this.checkBoxText.UseVisualStyleBackColor = true;
            this.checkBoxText.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 655);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 26);
            this.label6.TabIndex = 47;
            this.label6.Text = "включение редактирование\r\n          данных в окне";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Generation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(106F, 106F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(874, 696);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSetLamp);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.txMesenger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbCommand);
            this.Controls.Add(this.gbPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbNumberAndReset);
            this.Controls.Add(this.gbTune);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbHeat);
            this.Controls.Add(this.gbIgnition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbZagolovok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Generation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор";
            this.Load += new System.EventHandler(this.Generation_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Generation_KeyPress);
            this.gbIgnition.ResumeLayout(false);
            this.gbHeat.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbTune.ResumeLayout(false);
            this.gbTune.PerformLayout();
            this.gbNumberAndReset.ResumeLayout(false);
            this.gbNumberAndReset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownSetNumber)).EndInit();
            this.gbPort.ResumeLayout(false);
            this.gbPort.PerformLayout();
            this.gbCommand.ResumeLayout(false);
            this.gbCommand.PerformLayout();
            this.gbSetLamp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownSetLamp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label LbPort;
        private System.Windows.Forms.TextBox txCommand;
        private System.Windows.Forms.Label LbCommand;
        private System.Windows.Forms.Label Lblist;
        private System.Windows.Forms.ComboBox cbCommand;
        private System.Windows.Forms.Label lbZagolovok;
        private System.Windows.Forms.CheckBox checkBoxCommandVVod;
        private System.Windows.Forms.CheckBox checkBoxCommandList;
        private System.Windows.Forms.TextBox tbF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSendCMV;
        private System.Windows.Forms.Button btSendCMLIST;
        private System.Windows.Forms.Button btFlook;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btSerialN;
        private System.Windows.Forms.Button btFplus;
        private System.Windows.Forms.Button btFminus;
        private System.Windows.Forms.TextBox tbFplus;
        private System.Windows.Forms.TextBox tbFminus;
        private System.Windows.Forms.TextBox tbSerialN;
        private System.Windows.Forms.Button btIgnitionOFF;
        private System.Windows.Forms.Button btIgnitionON;
        private System.Windows.Forms.GroupBox gbIgnition;
        private System.Windows.Forms.GroupBox gbHeat;
        private System.Windows.Forms.Button btHeatOFF;
        private System.Windows.Forms.Button btHeatON;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox gbTune;
        private System.Windows.Forms.GroupBox gbNumberAndReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPort;
        private System.Windows.Forms.GroupBox gbCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txMesenger;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Timer TimerResever;
        private System.Windows.Forms.Button btSbrosSintez;
        private System.Windows.Forms.Button btMinusSint;
        private System.Windows.Forms.Button btPlusSint;
        private System.Windows.Forms.Button btSetSerialN;
        private System.Windows.Forms.GroupBox gbSetLamp;
        private System.Windows.Forms.Button btSetLamp;
        private System.Windows.Forms.NumericUpDown nUpDownSetLamp;
        private System.Windows.Forms.NumericUpDown nUpDownSetNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox photoCurrent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox porogLamp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonTime;
        private System.Windows.Forms.CheckBox checkBoxText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

