﻿namespace ICDIBasic
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrRead = new System.Windows.Forms.Timer(this.components);
            this.tmrDisplay = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redémarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4RealTimeCAN = new System.Windows.Forms.Timer(this.components);
            this.label30 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.UART1DisplayBox = new System.Windows.Forms.TextBox();
            this.SendUART1 = new System.Windows.Forms.Button();
            this.SendZoneUART1 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtData0 = new System.Windows.Forms.TextBox();
            this.txtData4 = new System.Windows.Forms.TextBox();
            this.txtData3 = new System.Windows.Forms.TextBox();
            this.txtData5 = new System.Windows.Forms.TextBox();
            this.txtData2 = new System.Windows.Forms.TextBox();
            this.txtData7 = new System.Windows.Forms.TextBox();
            this.txtData6 = new System.Windows.Forms.TextBox();
            this.txtData1 = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.chbRemote = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chbExtended = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.EtatProjet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.Poltergeist = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblEtatVehicule = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LblPoidBloc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lblBlocColor = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.BoutonStop = new System.Windows.Forms.Button();
            this.BoutonStart = new System.Windows.Forms.Button();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.Connexion = new System.Windows.Forms.Button();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.RXLED = new System.Windows.Forms.Button();
            this.TXLED = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.BAUDselector = new System.Windows.Forms.ComboBox();
            this.COMselector = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.groupBox19.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox24.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrRead
            // 
            this.tmrRead.Interval = 50;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::PCANBasicExample.Properties.Resources.Image1;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.àProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1357, 28);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem,
            this.redémarrerToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem.BackgroundImage")));
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // redémarrerToolStripMenuItem
            // 
            this.redémarrerToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redémarrerToolStripMenuItem.BackgroundImage")));
            this.redémarrerToolStripMenuItem.Name = "redémarrerToolStripMenuItem";
            this.redémarrerToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.redémarrerToolStripMenuItem.Text = "Redémarrer";
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.àProposToolStripMenuItem.Text = "&À propos";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fileToolStripMenuItem.Text = "&Fichier";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.saveAsToolStripMenuItem.Text = "&Redémarrer";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.exitToolStripMenuItem.Text = "&Quitter";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // historiqueToolStripMenuItem
            // 
            this.historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            this.historiqueToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.historiqueToolStripMenuItem.Text = "Historique";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            // 
            // effacerToolStripMenuItem
            // 
            this.effacerToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.effacerToolStripMenuItem.Name = "effacerToolStripMenuItem";
            this.effacerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.effacerToolStripMenuItem.Text = "Effacer";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.helpToolStripMenuItem.Text = "&À propos";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            // 
            // timer4RealTimeCAN
            // 
            this.timer4RealTimeCAN.Interval = 5;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(1255, 11);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(100, 17);
            this.label30.TabIndex = 56;
            this.label30.Text = "Version 0.95.1";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox25);
            this.tabPage7.Controls.Add(this.groupBox6);
            this.tabPage7.Controls.Add(this.groupBox19);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage7.Size = new System.Drawing.Size(1352, 668);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Onglet de Debug";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.button2);
            this.groupBox25.Controls.Add(this.UART1DisplayBox);
            this.groupBox25.Controls.Add(this.SendUART1);
            this.groupBox25.Controls.Add(this.SendZoneUART1);
            this.groupBox25.Location = new System.Drawing.Point(5, 9);
            this.groupBox25.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox25.Size = new System.Drawing.Size(1325, 452);
            this.groupBox25.TabIndex = 52;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Envoi et réception UART";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1240, 415);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UART1DisplayBox
            // 
            this.UART1DisplayBox.BackColor = System.Drawing.Color.White;
            this.UART1DisplayBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UART1DisplayBox.Location = new System.Drawing.Point(8, 23);
            this.UART1DisplayBox.Margin = new System.Windows.Forms.Padding(4);
            this.UART1DisplayBox.Multiline = true;
            this.UART1DisplayBox.Name = "UART1DisplayBox";
            this.UART1DisplayBox.ReadOnly = true;
            this.UART1DisplayBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UART1DisplayBox.Size = new System.Drawing.Size(1308, 381);
            this.UART1DisplayBox.TabIndex = 5;
            // 
            // SendUART1
            // 
            this.SendUART1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SendUART1.BackgroundImage")));
            this.SendUART1.Image = ((System.Drawing.Image)(resources.GetObject("SendUART1.Image")));
            this.SendUART1.Location = new System.Drawing.Point(1155, 415);
            this.SendUART1.Margin = new System.Windows.Forms.Padding(4);
            this.SendUART1.Name = "SendUART1";
            this.SendUART1.Size = new System.Drawing.Size(77, 34);
            this.SendUART1.TabIndex = 4;
            this.SendUART1.Text = "Envoyer";
            this.SendUART1.UseVisualStyleBackColor = true;
            // 
            // SendZoneUART1
            // 
            this.SendZoneUART1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendZoneUART1.Location = new System.Drawing.Point(8, 415);
            this.SendZoneUART1.Margin = new System.Windows.Forms.Padding(4);
            this.SendZoneUART1.Name = "SendZoneUART1";
            this.SendZoneUART1.Size = new System.Drawing.Size(1137, 30);
            this.SendZoneUART1.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.groupBox12);
            this.groupBox6.Controls.Add(this.groupBox13);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox6.Location = new System.Drawing.Point(5, 481);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(488, 160);
            this.groupBox6.TabIndex = 51;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Envoyer sur le CAN BUS";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btnWrite);
            this.groupBox12.Controls.Add(this.txtData0);
            this.groupBox12.Controls.Add(this.txtData4);
            this.groupBox12.Controls.Add(this.txtData3);
            this.groupBox12.Controls.Add(this.txtData5);
            this.groupBox12.Controls.Add(this.txtData2);
            this.groupBox12.Controls.Add(this.txtData7);
            this.groupBox12.Controls.Add(this.txtData6);
            this.groupBox12.Controls.Add(this.txtData1);
            this.groupBox12.Location = new System.Drawing.Point(8, 107);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox12.Size = new System.Drawing.Size(439, 46);
            this.groupBox12.TabIndex = 55;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Donnée à envoyer";
            // 
            // btnWrite
            // 
            this.btnWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWrite.BackColor = System.Drawing.Color.White;
            this.btnWrite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWrite.BackgroundImage")));
            this.btnWrite.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnWrite.Enabled = false;
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnWrite.Image")));
            this.btnWrite.Location = new System.Drawing.Point(349, 16);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(4);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(76, 25);
            this.btnWrite.TabIndex = 36;
            this.btnWrite.Text = "Écrire";
            this.btnWrite.UseVisualStyleBackColor = false;
            // 
            // txtData0
            // 
            this.txtData0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData0.Location = new System.Drawing.Point(8, 16);
            this.txtData0.Margin = new System.Windows.Forms.Padding(4);
            this.txtData0.MaxLength = 2;
            this.txtData0.Name = "txtData0";
            this.txtData0.Size = new System.Drawing.Size(31, 22);
            this.txtData0.TabIndex = 22;
            this.txtData0.Text = "00";
            this.txtData0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData4
            // 
            this.txtData4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData4.Location = new System.Drawing.Point(179, 16);
            this.txtData4.Margin = new System.Windows.Forms.Padding(4);
            this.txtData4.MaxLength = 2;
            this.txtData4.Name = "txtData4";
            this.txtData4.Size = new System.Drawing.Size(31, 22);
            this.txtData4.TabIndex = 26;
            this.txtData4.Text = "00";
            this.txtData4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData3
            // 
            this.txtData3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData3.Location = new System.Drawing.Point(136, 16);
            this.txtData3.Margin = new System.Windows.Forms.Padding(4);
            this.txtData3.MaxLength = 2;
            this.txtData3.Name = "txtData3";
            this.txtData3.Size = new System.Drawing.Size(31, 22);
            this.txtData3.TabIndex = 25;
            this.txtData3.Text = "00";
            this.txtData3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData5
            // 
            this.txtData5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData5.Location = new System.Drawing.Point(221, 16);
            this.txtData5.Margin = new System.Windows.Forms.Padding(4);
            this.txtData5.MaxLength = 2;
            this.txtData5.Name = "txtData5";
            this.txtData5.Size = new System.Drawing.Size(31, 22);
            this.txtData5.TabIndex = 27;
            this.txtData5.Text = "00";
            this.txtData5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData2
            // 
            this.txtData2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData2.Location = new System.Drawing.Point(93, 16);
            this.txtData2.Margin = new System.Windows.Forms.Padding(4);
            this.txtData2.MaxLength = 2;
            this.txtData2.Name = "txtData2";
            this.txtData2.Size = new System.Drawing.Size(31, 22);
            this.txtData2.TabIndex = 24;
            this.txtData2.Text = "00";
            this.txtData2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData7
            // 
            this.txtData7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData7.Location = new System.Drawing.Point(307, 16);
            this.txtData7.Margin = new System.Windows.Forms.Padding(4);
            this.txtData7.MaxLength = 2;
            this.txtData7.Name = "txtData7";
            this.txtData7.Size = new System.Drawing.Size(31, 22);
            this.txtData7.TabIndex = 29;
            this.txtData7.Text = "00";
            this.txtData7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData6
            // 
            this.txtData6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData6.Location = new System.Drawing.Point(264, 16);
            this.txtData6.Margin = new System.Windows.Forms.Padding(4);
            this.txtData6.MaxLength = 2;
            this.txtData6.Name = "txtData6";
            this.txtData6.Size = new System.Drawing.Size(31, 22);
            this.txtData6.TabIndex = 28;
            this.txtData6.Text = "00";
            this.txtData6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData1
            // 
            this.txtData1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData1.Location = new System.Drawing.Point(51, 16);
            this.txtData1.Margin = new System.Windows.Forms.Padding(4);
            this.txtData1.MaxLength = 2;
            this.txtData1.Name = "txtData1";
            this.txtData1.Size = new System.Drawing.Size(31, 22);
            this.txtData1.TabIndex = 23;
            this.txtData1.Text = "00";
            this.txtData1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.txtID);
            this.groupBox13.Controls.Add(this.chbRemote);
            this.groupBox13.Controls.Add(this.label12);
            this.groupBox13.Controls.Add(this.chbExtended);
            this.groupBox13.Controls.Add(this.label13);
            this.groupBox13.Controls.Add(this.nudLength);
            this.groupBox13.Controls.Add(this.label11);
            this.groupBox13.Location = new System.Drawing.Point(8, 20);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox13.Size = new System.Drawing.Size(439, 80);
            this.groupBox13.TabIndex = 56;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Paramètres d\'envoi";
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Location = new System.Drawing.Point(8, 44);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.MaxLength = 3;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(105, 22);
            this.txtID.TabIndex = 20;
            this.txtID.Text = "0";
            // 
            // chbRemote
            // 
            this.chbRemote.Cursor = System.Windows.Forms.Cursors.Default;
            this.chbRemote.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chbRemote.Location = new System.Drawing.Point(349, 44);
            this.chbRemote.Margin = new System.Windows.Forms.Padding(4);
            this.chbRemote.Name = "chbRemote";
            this.chbRemote.Size = new System.Drawing.Size(59, 30);
            this.chbRemote.TabIndex = 33;
            this.chbRemote.Text = "RTR";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Longueur";
            // 
            // chbExtended
            // 
            this.chbExtended.Cursor = System.Windows.Forms.Cursors.Default;
            this.chbExtended.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chbExtended.Location = new System.Drawing.Point(123, 42);
            this.chbExtended.Margin = new System.Windows.Forms.Padding(4);
            this.chbExtended.Name = "chbExtended";
            this.chbExtended.Size = new System.Drawing.Size(83, 30);
            this.chbExtended.TabIndex = 34;
            this.chbExtended.Text = "Extended";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "ID (Hex):";
            // 
            // nudLength
            // 
            this.nudLength.BackColor = System.Drawing.Color.White;
            this.nudLength.Location = new System.Drawing.Point(233, 44);
            this.nudLength.Margin = new System.Windows.Forms.Padding(4);
            this.nudLength.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.ReadOnly = true;
            this.nudLength.Size = new System.Drawing.Size(67, 22);
            this.nudLength.TabIndex = 21;
            this.nudLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(345, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Data (0..7):";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.label19);
            this.groupBox19.Controls.Add(this.textBox1);
            this.groupBox19.Controls.Add(this.button1);
            this.groupBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox19.Location = new System.Drawing.Point(516, 481);
            this.groupBox19.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox19.Size = new System.Drawing.Size(352, 160);
            this.groupBox19.TabIndex = 4;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Test de réception .HEX d\'Hichie";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 107);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 17);
            this.label19.TabIndex = 2;
            this.label19.Text = "label19";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 23);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(9, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.EtatProjet);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.groupBox17);
            this.tabPage5.Controls.Add(this.groupBox24);
            this.tabPage5.Controls.Add(this.groupBox15);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(1352, 668);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Contrôle et informations";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // EtatProjet
            // 
            this.EtatProjet.AutoSize = true;
            this.EtatProjet.BackColor = System.Drawing.Color.LightGray;
            this.EtatProjet.Location = new System.Drawing.Point(645, 69);
            this.EtatProjet.Name = "EtatProjet";
            this.EtatProjet.Size = new System.Drawing.Size(0, 17);
            this.EtatProjet.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(608, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "État:";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.Poltergeist);
            this.groupBox17.Controls.Add(this.label27);
            this.groupBox17.Controls.Add(this.label18);
            this.groupBox17.Controls.Add(this.lblEtatVehicule);
            this.groupBox17.Controls.Add(this.label32);
            this.groupBox17.Controls.Add(this.lblStation);
            this.groupBox17.Controls.Add(this.label31);
            this.groupBox17.Controls.Add(this.pictureBox3);
            this.groupBox17.Controls.Add(this.LblPoidBloc);
            this.groupBox17.Controls.Add(this.pictureBox1);
            this.groupBox17.Controls.Add(this.label23);
            this.groupBox17.Controls.Add(this.lblBlocColor);
            this.groupBox17.Controls.Add(this.label26);
            this.groupBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox17.Location = new System.Drawing.Point(4, 133);
            this.groupBox17.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox17.Size = new System.Drawing.Size(1337, 537);
            this.groupBox17.TabIndex = 59;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Informations en temps réel";
            // 
            // Poltergeist
            // 
            this.Poltergeist.AutoSize = true;
            this.Poltergeist.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poltergeist.Location = new System.Drawing.Point(10, 45);
            this.Poltergeist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Poltergeist.Name = "Poltergeist";
            this.Poltergeist.Size = new System.Drawing.Size(248, 32);
            this.Poltergeist.TabIndex = 63;
            this.Poltergeist.Text = "Aperçu des trames";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(11, 121);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(129, 25);
            this.label27.TabIndex = 16;
            this.label27.Text = "Station active";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 96);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(150, 25);
            this.label18.TabIndex = 5;
            this.label18.Text = "État du véhicule";
            // 
            // lblEtatVehicule
            // 
            this.lblEtatVehicule.AutoSize = true;
            this.lblEtatVehicule.Location = new System.Drawing.Point(211, 96);
            this.lblEtatVehicule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtatVehicule.Name = "lblEtatVehicule";
            this.lblEtatVehicule.Size = new System.Drawing.Size(77, 25);
            this.lblEtatVehicule.TabIndex = 6;
            this.lblEtatVehicule.Text = "no data";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(1101, 496);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(69, 25);
            this.label32.TabIndex = 59;
            this.label32.Text = "Aucun";
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(211, 121);
            this.lblStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(135, 25);
            this.lblStation.TabIndex = 17;
            this.lblStation.Text = "Table FESTO";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(1047, 471);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(131, 25);
            this.label31.TabIndex = 58;
            this.label31.Text = "Type de bloc:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PCANBasicExample.Properties.Resources.NO;
            this.pictureBox3.Location = new System.Drawing.Point(1183, 380);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(155, 140);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // LblPoidBloc
            // 
            this.LblPoidBloc.AutoSize = true;
            this.LblPoidBloc.Location = new System.Drawing.Point(214, 171);
            this.LblPoidBloc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPoidBloc.Name = "LblPoidBloc";
            this.LblPoidBloc.Size = new System.Drawing.Size(23, 25);
            this.LblPoidBloc.TabIndex = 15;
            this.LblPoidBloc.Text = "0";
            this.LblPoidBloc.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PCANBasicExample.Properties.Resources.festoHoraire;
            this.pictureBox1.Location = new System.Drawing.Point(357, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(988, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(11, 146);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(149, 25);
            this.label23.TabIndex = 12;
            this.label23.Text = "Couleur du bloc";
            // 
            // lblBlocColor
            // 
            this.lblBlocColor.AutoSize = true;
            this.lblBlocColor.Location = new System.Drawing.Point(211, 146);
            this.lblBlocColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlocColor.Name = "lblBlocColor";
            this.lblBlocColor.Size = new System.Drawing.Size(77, 25);
            this.lblBlocColor.TabIndex = 13;
            this.lblBlocColor.Text = "no data";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(15, 171);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(119, 25);
            this.label26.TabIndex = 14;
            this.label26.Text = "Poid du bloc";
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.BoutonStop);
            this.groupBox24.Controls.Add(this.BoutonStart);
            this.groupBox24.Location = new System.Drawing.Point(361, 9);
            this.groupBox24.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox24.Size = new System.Drawing.Size(225, 117);
            this.groupBox24.TabIndex = 62;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Projet";
            // 
            // BoutonStop
            // 
            this.BoutonStop.BackColor = System.Drawing.Color.White;
            this.BoutonStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoutonStop.BackgroundImage")));
            this.BoutonStop.Location = new System.Drawing.Point(8, 54);
            this.BoutonStop.Margin = new System.Windows.Forms.Padding(4);
            this.BoutonStop.Name = "BoutonStop";
            this.BoutonStop.Size = new System.Drawing.Size(209, 28);
            this.BoutonStop.TabIndex = 0;
            this.BoutonStop.Text = "Stop";
            this.BoutonStop.UseVisualStyleBackColor = false;
            this.BoutonStop.Click += new System.EventHandler(this.BoutonStop_Click);
            // 
            // BoutonStart
            // 
            this.BoutonStart.BackgroundImage = global::PCANBasicExample.Properties.Resources.Image1;
            this.BoutonStart.Location = new System.Drawing.Point(8, 18);
            this.BoutonStart.Margin = new System.Windows.Forms.Padding(4);
            this.BoutonStart.Name = "BoutonStart";
            this.BoutonStart.Size = new System.Drawing.Size(209, 28);
            this.BoutonStart.TabIndex = 1;
            this.BoutonStart.Text = "Start";
            this.BoutonStart.UseVisualStyleBackColor = true;
            this.BoutonStart.Click += new System.EventHandler(this.BoutonStart_Click);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.Connexion);
            this.groupBox15.Controls.Add(this.groupBox27);
            this.groupBox15.Controls.Add(this.BAUDselector);
            this.groupBox15.Controls.Add(this.COMselector);
            this.groupBox15.Controls.Add(this.label14);
            this.groupBox15.Controls.Add(this.label15);
            this.groupBox15.Location = new System.Drawing.Point(9, 8);
            this.groupBox15.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox15.Size = new System.Drawing.Size(325, 118);
            this.groupBox15.TabIndex = 56;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Connexion au bus RS-232";
            // 
            // Connexion
            // 
            this.Connexion.BackColor = System.Drawing.Color.White;
            this.Connexion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Connexion.BackgroundImage")));
            this.Connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Connexion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Connexion.Location = new System.Drawing.Point(8, 75);
            this.Connexion.Margin = new System.Windows.Forms.Padding(4);
            this.Connexion.Name = "Connexion";
            this.Connexion.Size = new System.Drawing.Size(209, 28);
            this.Connexion.TabIndex = 8;
            this.Connexion.UseVisualStyleBackColor = false;
            this.Connexion.Click += new System.EventHandler(this.Connexion_Click);
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.label25);
            this.groupBox27.Controls.Add(this.RXLED);
            this.groupBox27.Controls.Add(this.TXLED);
            this.groupBox27.Controls.Add(this.label24);
            this.groupBox27.Location = new System.Drawing.Point(231, 14);
            this.groupBox27.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox27.Size = new System.Drawing.Size(81, 97);
            this.groupBox27.TabIndex = 57;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "RxTx";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 71);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(23, 17);
            this.label25.TabIndex = 12;
            this.label25.Text = "Tx";
            // 
            // RXLED
            // 
            this.RXLED.BackColor = System.Drawing.Color.White;
            this.RXLED.Location = new System.Drawing.Point(41, 16);
            this.RXLED.Margin = new System.Windows.Forms.Padding(4);
            this.RXLED.Name = "RXLED";
            this.RXLED.Size = new System.Drawing.Size(28, 28);
            this.RXLED.TabIndex = 10;
            this.RXLED.UseVisualStyleBackColor = false;
            // 
            // TXLED
            // 
            this.TXLED.BackgroundImage = global::PCANBasicExample.Properties.Resources.Image1;
            this.TXLED.Location = new System.Drawing.Point(41, 62);
            this.TXLED.Margin = new System.Windows.Forms.Padding(4);
            this.TXLED.Name = "TXLED";
            this.TXLED.Size = new System.Drawing.Size(28, 28);
            this.TXLED.TabIndex = 11;
            this.TXLED.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 22);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(24, 17);
            this.label24.TabIndex = 9;
            this.label24.Text = "Rx";
            // 
            // BAUDselector
            // 
            this.BAUDselector.BackColor = System.Drawing.Color.White;
            this.BAUDselector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BAUDselector.ForeColor = System.Drawing.Color.Black;
            this.BAUDselector.FormattingEnabled = true;
            this.BAUDselector.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BAUDselector.Location = new System.Drawing.Point(115, 39);
            this.BAUDselector.Margin = new System.Windows.Forms.Padding(4);
            this.BAUDselector.Name = "BAUDselector";
            this.BAUDselector.Size = new System.Drawing.Size(101, 24);
            this.BAUDselector.TabIndex = 6;
            // 
            // COMselector
            // 
            this.COMselector.BackColor = System.Drawing.Color.White;
            this.COMselector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMselector.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.COMselector.FormattingEnabled = true;
            this.COMselector.Location = new System.Drawing.Point(8, 39);
            this.COMselector.Margin = new System.Windows.Forms.Padding(4);
            this.COMselector.Name = "COMselector";
            this.COMselector.Size = new System.Drawing.Size(97, 24);
            this.COMselector.TabIndex = 7;
            this.COMselector.Click += new System.EventHandler(this.COMselector_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(116, 21);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Baud";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 20);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "Port";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(0, 33);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1360, 697);
            this.tabControl2.TabIndex = 55;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1357, 725);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projet de 5ème session";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox24.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrRead;
        private System.Windows.Forms.Timer tmrDisplay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem historiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effacerToolStripMenuItem;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4RealTimeCAN;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redémarrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox UART1DisplayBox;
        private System.Windows.Forms.Button SendUART1;
        private System.Windows.Forms.TextBox SendZoneUART1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtData0;
        private System.Windows.Forms.TextBox txtData4;
        private System.Windows.Forms.TextBox txtData3;
        private System.Windows.Forms.TextBox txtData5;
        private System.Windows.Forms.TextBox txtData2;
        private System.Windows.Forms.TextBox txtData7;
        private System.Windows.Forms.TextBox txtData6;
        private System.Windows.Forms.TextBox txtData1;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chbRemote;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chbExtended;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label Poltergeist;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblEtatVehicule;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LblPoidBloc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblBlocColor;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.Button BoutonStop;
        private System.Windows.Forms.Button BoutonStart;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Button Connexion;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button RXLED;
        private System.Windows.Forms.Button TXLED;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox BAUDselector;
        private System.Windows.Forms.ComboBox COMselector;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EtatProjet;
        // private System.Windows.Forms.Label GhostLabelDeRéceptionLabeldeTest;
        //private System.Windows.Forms.Label GhostLabelDeRéceptionTestLabel;
    }
}
