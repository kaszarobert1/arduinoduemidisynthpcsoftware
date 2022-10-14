using Sanford.Multimedia.Midi;

namespace SequencerDemo
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
            if(disposing && (components != null))
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
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.positionHScrollBar = new System.Windows.Forms.HScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mIDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dXDUE7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMidiFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.pianoControl1 = new Sanford.Multimedia.Midi.UI.PianoControl();
            this.sequence1 = new Sanford.Multimedia.Midi.Sequence();
            this.sequencer1 = new Sanford.Multimedia.Midi.Sequencer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.trackBar23 = new System.Windows.Forms.TrackBar();
            this.label24 = new System.Windows.Forms.Label();
            this.trackBar24 = new System.Windows.Forms.TrackBar();
            this.label31 = new System.Windows.Forms.Label();
            this.trackBar31 = new System.Windows.Forms.TrackBar();
            this.label32 = new System.Windows.Forms.Label();
            this.trackBar32 = new System.Windows.Forms.TrackBar();
            this.label33 = new System.Windows.Forms.Label();
            this.trackBar33 = new System.Windows.Forms.TrackBar();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.trackBar37 = new System.Windows.Forms.TrackBar();
            this.label38 = new System.Windows.Forms.Label();
            this.trackBar38 = new System.Windows.Forms.TrackBar();
            this.label39 = new System.Windows.Forms.Label();
            this.trackBar39 = new System.Windows.Forms.TrackBar();
            this.label40 = new System.Windows.Forms.Label();
            this.trackBar40 = new System.Windows.Forms.TrackBar();
            this.label51 = new System.Windows.Forms.Label();
            this.trackBar51 = new System.Windows.Forms.TrackBar();
            this.label54 = new System.Windows.Forms.Label();
            this.trackBar54 = new System.Windows.Forms.TrackBar();
            this.label55 = new System.Windows.Forms.Label();
            this.trackBar55 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.trackBar56 = new System.Windows.Forms.TrackBar();
            this.label58 = new System.Windows.Forms.Label();
            this.trackBar57 = new System.Windows.Forms.TrackBar();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.trackBar60 = new System.Windows.Forms.TrackBar();
            this.trackBar61 = new System.Windows.Forms.TrackBar();
            this.trackBar62 = new System.Windows.Forms.TrackBar();
            this.label86 = new System.Windows.Forms.Label();
            this.trackBar84 = new System.Windows.Forms.TrackBar();
            this.label87 = new System.Windows.Forms.Label();
            this.trackBar85 = new System.Windows.Forms.TrackBar();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.trackBar86 = new System.Windows.Forms.TrackBar();
            this.trackBar87 = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBar12 = new System.Windows.Forms.TrackBar();
            this.trackBar11 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar10 = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBar9 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar21 = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.trackBar14 = new System.Windows.Forms.TrackBar();
            this.trackBar13 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar63 = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.button13 = new System.Windows.Forms.Button();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button19 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar84)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar85)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar86)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar87)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar21)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.GroupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Navy;
            this.stopButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stopButton.Location = new System.Drawing.Point(146, 82);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(112, 35);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Teal;
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.Location = new System.Drawing.Point(278, 82);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(112, 35);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Orange;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.continueButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.continueButton.Location = new System.Drawing.Point(406, 80);
            this.continueButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(112, 35);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // positionHScrollBar
            // 
            this.positionHScrollBar.Location = new System.Drawing.Point(15, 49);
            this.positionHScrollBar.Name = "positionHScrollBar";
            this.positionHScrollBar.Size = new System.Drawing.Size(700, 18);
            this.positionHScrollBar.TabIndex = 3;
            this.positionHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.positionHScrollBar_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkBlue;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mIDIToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1564, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mIDIToolStripMenuItem
            // 
            this.mIDIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputDeviceToolStripMenuItem});
            this.mIDIToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mIDIToolStripMenuItem.Name = "mIDIToolStripMenuItem";
            this.mIDIToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.mIDIToolStripMenuItem.Text = "&MIDI";
            this.mIDIToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // outputDeviceToolStripMenuItem
            // 
            this.outputDeviceToolStripMenuItem.Name = "outputDeviceToolStripMenuItem";
            this.outputDeviceToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.outputDeviceToolStripMenuItem.Text = "Output Device...";
            this.outputDeviceToolStripMenuItem.Click += new System.EventHandler(this.outputDeviceToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.dXDUE7ToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(186, 34);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dXDUE7ToolStripMenuItem
            // 
            this.dXDUE7ToolStripMenuItem.Name = "dXDUE7ToolStripMenuItem";
            this.dXDUE7ToolStripMenuItem.Size = new System.Drawing.Size(186, 34);
            this.dXDUE7ToolStripMenuItem.Text = "DXDUE 7";
            this.dXDUE7ToolStripMenuItem.Click += new System.EventHandler(this.dXDUE7ToolStripMenuItem_Click);
            // 
            // openMidiFileDialog
            // 
            this.openMidiFileDialog.DefaultExt = "mid";
            this.openMidiFileDialog.Filter = "MIDI files|*.mid|All files|*.*";
            this.openMidiFileDialog.Title = "Open MIDI file";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 922);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1564, 30);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 22);
            // 
            // pianoControl1
            // 
            this.pianoControl1.HighNoteID = 109;
            this.pianoControl1.Location = new System.Drawing.Point(11, 74);
            this.pianoControl1.LowNoteID = 21;
            this.pianoControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pianoControl1.Name = "pianoControl1";
            this.pianoControl1.NoteOnColor = System.Drawing.Color.SkyBlue;
            this.pianoControl1.Size = new System.Drawing.Size(1270, 221);
            this.pianoControl1.TabIndex = 5;
            this.pianoControl1.Text = "pianoControl1";
            this.pianoControl1.PianoKeyDown += new System.EventHandler<Sanford.Multimedia.Midi.UI.PianoKeyEventArgs>(this.pianoControl1_PianoKeyDown);
            this.pianoControl1.PianoKeyUp += new System.EventHandler<Sanford.Multimedia.Midi.UI.PianoKeyEventArgs>(this.pianoControl1_PianoKeyUp);
            this.pianoControl1.Click += new System.EventHandler(this.pianoControl1_Click);
            // 
            // sequence1
            // 
            this.sequence1.Format = 1;
            // 
            // sequencer1
            // 
            this.sequencer1.Position = 0;
            this.sequencer1.Sequence = this.sequence1;
            this.sequencer1.PlayingCompleted += new System.EventHandler(this.HandlePlayingCompleted);
            this.sequencer1.ChannelMessagePlayed += new System.EventHandler<Sanford.Multimedia.Midi.ChannelMessageEventArgs>(this.HandleChannelMessagePlayed);
            this.sequencer1.SysExMessagePlayed += new System.EventHandler<Sanford.Multimedia.Midi.SysExMessageEventArgs>(this.HandleSysExMessagePlayed);
            this.sequencer1.Chased += new System.EventHandler<Sanford.Multimedia.Midi.ChasedEventArgs>(this.HandleChased);
            this.sequencer1.Stopped += new System.EventHandler<Sanford.Multimedia.Midi.StoppedEventArgs>(this.HandleStopped);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(10, 49);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(118, 69);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "WAVEFORM";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label23.Location = new System.Drawing.Point(21, 95);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 20);
            this.label23.TabIndex = 51;
            this.label23.Text = "FREQ";
            // 
            // trackBar23
            // 
            this.trackBar23.Location = new System.Drawing.Point(10, 118);
            this.trackBar23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar23.Name = "trackBar23";
            this.trackBar23.Size = new System.Drawing.Size(116, 69);
            this.trackBar23.TabIndex = 52;
            this.trackBar23.Scroll += new System.EventHandler(this.trackBar23_Scroll);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label24.Location = new System.Drawing.Point(27, 106);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 20);
            this.label24.TabIndex = 53;
            this.label24.Text = "LEVEL";
            // 
            // trackBar24
            // 
            this.trackBar24.Location = new System.Drawing.Point(8, 133);
            this.trackBar24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar24.Name = "trackBar24";
            this.trackBar24.Size = new System.Drawing.Size(115, 69);
            this.trackBar24.TabIndex = 54;
            this.trackBar24.Scroll += new System.EventHandler(this.trackBar24_Scroll);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label31.Location = new System.Drawing.Point(387, 25);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(92, 20);
            this.label31.TabIndex = 67;
            this.label31.Text = "LFO MODE";
            // 
            // trackBar31
            // 
            this.trackBar31.Location = new System.Drawing.Point(384, 52);
            this.trackBar31.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar31.Name = "trackBar31";
            this.trackBar31.Size = new System.Drawing.Size(90, 69);
            this.trackBar31.TabIndex = 68;
            this.trackBar31.Scroll += new System.EventHandler(this.trackBar31_Scroll);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label32.Location = new System.Drawing.Point(11, 754);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(90, 20);
            this.label32.TabIndex = 69;
            this.label32.Text = "PICHKEZD";
            // 
            // trackBar32
            // 
            this.trackBar32.Location = new System.Drawing.Point(-2, 784);
            this.trackBar32.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar32.Name = "trackBar32";
            this.trackBar32.Size = new System.Drawing.Size(125, 69);
            this.trackBar32.TabIndex = 70;
            this.trackBar32.Scroll += new System.EventHandler(this.trackBar32_Scroll);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label33.Location = new System.Drawing.Point(258, 25);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(112, 20);
            this.label33.TabIndex = 71;
            this.label33.Text = "LFO VOLUME";
            // 
            // trackBar33
            // 
            this.trackBar33.Location = new System.Drawing.Point(280, 52);
            this.trackBar33.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar33.Name = "trackBar33";
            this.trackBar33.Size = new System.Drawing.Size(90, 69);
            this.trackBar33.TabIndex = 72;
            this.trackBar33.Scroll += new System.EventHandler(this.trackBar33_Scroll);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label34.Location = new System.Drawing.Point(495, 25);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(89, 20);
            this.label34.TabIndex = 73;
            this.label34.Text = "LFO FREQ";
            this.label34.Click += new System.EventHandler(this.label34_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label35.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label35.Location = new System.Drawing.Point(568, 168);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(63, 20);
            this.label35.TabIndex = 75;
            this.label35.Text = "noteset";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label37.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label37.Location = new System.Drawing.Point(25, 346);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(79, 20);
            this.label37.TabIndex = 79;
            this.label37.Text = "STEP BIT";
            this.label37.Click += new System.EventHandler(this.label37_Click);
            // 
            // trackBar37
            // 
            this.trackBar37.BackColor = System.Drawing.Color.Navy;
            this.trackBar37.Location = new System.Drawing.Point(10, 376);
            this.trackBar37.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar37.Maximum = 28;
            this.trackBar37.Minimum = 13;
            this.trackBar37.Name = "trackBar37";
            this.trackBar37.Size = new System.Drawing.Size(114, 69);
            this.trackBar37.TabIndex = 80;
            this.trackBar37.Value = 13;
            this.trackBar37.Scroll += new System.EventHandler(this.trackBar37_Scroll);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label38.Location = new System.Drawing.Point(21, 272);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(75, 20);
            this.label38.TabIndex = 81;
            this.label38.Text = "DETUNE";
            // 
            // trackBar38
            // 
            this.trackBar38.Location = new System.Drawing.Point(9, 297);
            this.trackBar38.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar38.Maximum = 127;
            this.trackBar38.Name = "trackBar38";
            this.trackBar38.Size = new System.Drawing.Size(112, 69);
            this.trackBar38.TabIndex = 82;
            this.trackBar38.Scroll += new System.EventHandler(this.trackBar38_Scroll);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(14, 551);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(68, 20);
            this.label39.TabIndex = 83;
            this.label39.Text = "PICHRL";
            // 
            // trackBar39
            // 
            this.trackBar39.Location = new System.Drawing.Point(14, 578);
            this.trackBar39.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar39.Name = "trackBar39";
            this.trackBar39.Size = new System.Drawing.Size(117, 69);
            this.trackBar39.TabIndex = 84;
            this.trackBar39.Scroll += new System.EventHandler(this.trackBar39_Scroll);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(14, 625);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(71, 20);
            this.label40.TabIndex = 85;
            this.label40.Text = "PICHRR";
            // 
            // trackBar40
            // 
            this.trackBar40.Location = new System.Drawing.Point(12, 654);
            this.trackBar40.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar40.Name = "trackBar40";
            this.trackBar40.Size = new System.Drawing.Size(118, 69);
            this.trackBar40.TabIndex = 86;
            this.trackBar40.Scroll += new System.EventHandler(this.trackBar40_Scroll);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label51.Location = new System.Drawing.Point(602, 25);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(84, 20);
            this.label51.TabIndex = 107;
            this.label51.Text = "TUNE DIV";
            // 
            // trackBar51
            // 
            this.trackBar51.Location = new System.Drawing.Point(592, 52);
            this.trackBar51.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar51.Name = "trackBar51";
            this.trackBar51.Size = new System.Drawing.Size(96, 69);
            this.trackBar51.TabIndex = 108;
            this.trackBar51.Scroll += new System.EventHandler(this.trackBar51_Scroll);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label54.Location = new System.Drawing.Point(19, 23);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(82, 20);
            this.label54.TabIndex = 113;
            this.label54.Text = "OPLEVEL";
            this.label54.Click += new System.EventHandler(this.label54_Click);
            // 
            // trackBar54
            // 
            this.trackBar54.Location = new System.Drawing.Point(6, 54);
            this.trackBar54.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar54.Maximum = 127;
            this.trackBar54.Name = "trackBar54";
            this.trackBar54.Size = new System.Drawing.Size(112, 69);
            this.trackBar54.TabIndex = 114;
            this.trackBar54.Scroll += new System.EventHandler(this.trackBar54_Scroll);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label55.Location = new System.Drawing.Point(22, 425);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(96, 20);
            this.label55.TabIndex = 115;
            this.label55.Text = "FEEDBACK";
            // 
            // trackBar55
            // 
            this.trackBar55.Location = new System.Drawing.Point(14, 455);
            this.trackBar55.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar55.Name = "trackBar55";
            this.trackBar55.Size = new System.Drawing.Size(116, 69);
            this.trackBar55.TabIndex = 116;
            this.trackBar55.Scroll += new System.EventHandler(this.trackBar55_Scroll);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(534, 0);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 117;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label56.ForeColor = System.Drawing.Color.Yellow;
            this.label56.Location = new System.Drawing.Point(8, 173);
            this.label56.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(121, 64);
            this.label56.TabIndex = 118;
            this.label56.Text = "000";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label57.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label57.Location = new System.Drawing.Point(1800, 462);
            this.label57.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(56, 20);
            this.label57.TabIndex = 119;
            this.label57.Text = "dfdffdf";
            // 
            // trackBar56
            // 
            this.trackBar56.Location = new System.Drawing.Point(9, 725);
            this.trackBar56.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar56.Name = "trackBar56";
            this.trackBar56.Size = new System.Drawing.Size(98, 69);
            this.trackBar56.TabIndex = 120;
            this.trackBar56.Scroll += new System.EventHandler(this.trackBar56_Scroll);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(15, 700);
            this.label58.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(78, 20);
            this.label58.TabIndex = 121;
            this.label58.Text = "PICHTVA";
            // 
            // trackBar57
            // 
            this.trackBar57.Location = new System.Drawing.Point(3, 705);
            this.trackBar57.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar57.Maximum = 2;
            this.trackBar57.Name = "trackBar57";
            this.trackBar57.Size = new System.Drawing.Size(124, 69);
            this.trackBar57.TabIndex = 122;
            this.trackBar57.Scroll += new System.EventHandler(this.trackBar57_Scroll);
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label59.Location = new System.Drawing.Point(11, 672);
            this.label59.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(69, 20);
            this.label59.TabIndex = 123;
            this.label59.Text = "PICHOP";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label60.Location = new System.Drawing.Point(111, 25);
            this.label60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(0, 20);
            this.label60.TabIndex = 126;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox2.ForeColor = System.Drawing.Color.LawnGreen;
            this.richTextBox2.Location = new System.Drawing.Point(1174, 46);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(319, 515);
            this.richTextBox2.TabIndex = 129;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(14, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 130;
            this.button1.Text = "Initial";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label66.Location = new System.Drawing.Point(21, 198);
            this.label66.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(80, 20);
            this.label66.TabIndex = 135;
            this.label66.Text = "FIXFREQ";
            this.label66.Click += new System.EventHandler(this.label66_Click);
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label67.Location = new System.Drawing.Point(21, 182);
            this.label67.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(66, 20);
            this.label67.TabIndex = 136;
            this.label67.Text = "FRAME";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label68.Location = new System.Drawing.Point(18, 255);
            this.label68.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(105, 20);
            this.label68.TabIndex = 137;
            this.label68.Text = "ALGORITHM";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label69.Location = new System.Drawing.Point(21, 25);
            this.label69.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(124, 20);
            this.label69.TabIndex = 138;
            this.label69.Text = "EXT LFO FREQ";
            // 
            // trackBar60
            // 
            this.trackBar60.Location = new System.Drawing.Point(10, 223);
            this.trackBar60.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar60.Name = "trackBar60";
            this.trackBar60.Size = new System.Drawing.Size(116, 69);
            this.trackBar60.TabIndex = 139;
            this.trackBar60.Scroll += new System.EventHandler(this.trackBar60_Scroll);
            // 
            // trackBar61
            // 
            this.trackBar61.Location = new System.Drawing.Point(8, 206);
            this.trackBar61.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar61.Maximum = 127;
            this.trackBar61.Minimum = 1;
            this.trackBar61.Name = "trackBar61";
            this.trackBar61.Size = new System.Drawing.Size(110, 69);
            this.trackBar61.TabIndex = 140;
            this.trackBar61.Value = 1;
            this.trackBar61.Scroll += new System.EventHandler(this.trackBar61_Scroll);
            // 
            // trackBar62
            // 
            this.trackBar62.Location = new System.Drawing.Point(6, 280);
            this.trackBar62.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar62.Name = "trackBar62";
            this.trackBar62.Size = new System.Drawing.Size(116, 69);
            this.trackBar62.TabIndex = 145;
            this.trackBar62.Scroll += new System.EventHandler(this.trackBar62_Scroll);
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label86.Location = new System.Drawing.Point(726, 522);
            this.label86.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(140, 20);
            this.label86.TabIndex = 189;
            this.label86.Text = "CHORUSH FREQ";
            // 
            // trackBar84
            // 
            this.trackBar84.Location = new System.Drawing.Point(726, 543);
            this.trackBar84.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar84.Name = "trackBar84";
            this.trackBar84.Size = new System.Drawing.Size(116, 69);
            this.trackBar84.TabIndex = 190;
            this.trackBar84.Scroll += new System.EventHandler(this.trackBar84_Scroll);
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label87.Location = new System.Drawing.Point(726, 386);
            this.label87.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(118, 20);
            this.label87.TabIndex = 191;
            this.label87.Text = "REV DIFFUSE";
            // 
            // trackBar85
            // 
            this.trackBar85.Location = new System.Drawing.Point(723, 411);
            this.trackBar85.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar85.Name = "trackBar85";
            this.trackBar85.Size = new System.Drawing.Size(120, 69);
            this.trackBar85.TabIndex = 192;
            this.trackBar85.Scroll += new System.EventHandler(this.trackBar85_Scroll);
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label88.Location = new System.Drawing.Point(726, 455);
            this.label88.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(134, 20);
            this.label88.TabIndex = 193;
            this.label88.Text = "CHORUS LEVEL";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.BackColor = System.Drawing.Color.Transparent;
            this.label89.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label89.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label89.Location = new System.Drawing.Point(723, 309);
            this.label89.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(132, 20);
            this.label89.TabIndex = 194;
            this.label89.Text = "REVERB LEVEL";
            // 
            // trackBar86
            // 
            this.trackBar86.Location = new System.Drawing.Point(726, 480);
            this.trackBar86.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar86.Maximum = 16;
            this.trackBar86.Name = "trackBar86";
            this.trackBar86.Size = new System.Drawing.Size(116, 69);
            this.trackBar86.TabIndex = 195;
            this.trackBar86.Scroll += new System.EventHandler(this.trackBar86_Scroll);
            // 
            // trackBar87
            // 
            this.trackBar87.Location = new System.Drawing.Point(723, 337);
            this.trackBar87.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar87.Name = "trackBar87";
            this.trackBar87.Size = new System.Drawing.Size(120, 69);
            this.trackBar87.TabIndex = 196;
            this.trackBar87.Scroll += new System.EventHandler(this.trackBar87_Scroll);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(20, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 35);
            this.button2.TabIndex = 201;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(64, 26);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 35);
            this.button3.TabIndex = 202;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(105, 26);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 35);
            this.button4.TabIndex = 203;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(153, 25);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 35);
            this.button5.TabIndex = 204;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button6.Location = new System.Drawing.Point(194, 25);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 35);
            this.button6.TabIndex = 205;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DimGray;
            this.button7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Location = new System.Drawing.Point(232, 26);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 35);
            this.button7.TabIndex = 206;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DimGray;
            this.button8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button8.Location = new System.Drawing.Point(266, 26);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 35);
            this.button8.TabIndex = 207;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DimGray;
            this.button9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button9.Location = new System.Drawing.Point(303, 26);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(34, 35);
            this.button9.TabIndex = 208;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DimGray;
            this.button10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button10.Location = new System.Drawing.Point(342, 25);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 35);
            this.button10.TabIndex = 209;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DimGray;
            this.button11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button11.Location = new System.Drawing.Point(386, 25);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(39, 35);
            this.button11.TabIndex = 210;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Red;
            this.button12.Location = new System.Drawing.Point(130, 88);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(112, 35);
            this.button12.TabIndex = 211;
            this.button12.Text = "WRITE";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label92.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label92.Location = new System.Drawing.Point(434, 29);
            this.label92.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(71, 29);
            this.label92.TabIndex = 212;
            this.label92.Text = "Prog:";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.BackColor = System.Drawing.Color.GreenYellow;
            this.label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label93.Location = new System.Drawing.Point(516, 29);
            this.label93.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(26, 29);
            this.label93.TabIndex = 213;
            this.label93.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label59);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.trackBar12);
            this.groupBox1.Controls.Add(this.trackBar11);
            this.groupBox1.Controls.Add(this.trackBar32);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.trackBar10);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.trackBar9);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.trackBar8);
            this.groupBox1.Controls.Add(this.trackBar7);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.trackBar6);
            this.groupBox1.Controls.Add(this.trackBar57);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.trackBar5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.trackBar21);
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(1033, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(133, 871);
            this.groupBox1.TabIndex = 214;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OP1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(10, 28);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 20);
            this.label21.TabIndex = 158;
            this.label21.Text = "VOLUME";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 591);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 20);
            this.label12.TabIndex = 157;
            this.label12.Text = "RR";
            // 
            // trackBar12
            // 
            this.trackBar12.Location = new System.Drawing.Point(-2, 617);
            this.trackBar12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar12.Name = "trackBar12";
            this.trackBar12.Size = new System.Drawing.Size(135, 69);
            this.trackBar12.TabIndex = 156;
            this.trackBar12.Scroll += new System.EventHandler(this.trackBar12_Scroll_1);
            // 
            // trackBar11
            // 
            this.trackBar11.Location = new System.Drawing.Point(-2, 551);
            this.trackBar11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar11.Name = "trackBar11";
            this.trackBar11.Size = new System.Drawing.Size(130, 69);
            this.trackBar11.TabIndex = 155;
            this.trackBar11.Scroll += new System.EventHandler(this.trackBar11_Scroll_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 526);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 20);
            this.label11.TabIndex = 154;
            this.label11.Text = "RL";
            // 
            // trackBar10
            // 
            this.trackBar10.Location = new System.Drawing.Point(-2, 483);
            this.trackBar10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar10.Name = "trackBar10";
            this.trackBar10.Size = new System.Drawing.Size(129, 69);
            this.trackBar10.TabIndex = 153;
            this.trackBar10.Scroll += new System.EventHandler(this.trackBar10_Scroll_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 458);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 152;
            this.label10.Text = "D2R";
            // 
            // trackBar9
            // 
            this.trackBar9.Location = new System.Drawing.Point(0, 409);
            this.trackBar9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar9.Name = "trackBar9";
            this.trackBar9.Size = new System.Drawing.Size(130, 69);
            this.trackBar9.TabIndex = 151;
            this.trackBar9.Scroll += new System.EventHandler(this.trackBar9_Scroll_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 385);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 150;
            this.label9.Text = "D2L";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 322);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 149;
            this.label8.Text = "D1R";
            // 
            // trackBar8
            // 
            this.trackBar8.Location = new System.Drawing.Point(0, 346);
            this.trackBar8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Size = new System.Drawing.Size(129, 69);
            this.trackBar8.TabIndex = 148;
            this.trackBar8.Scroll += new System.EventHandler(this.trackBar8_Scroll_1);
            // 
            // trackBar7
            // 
            this.trackBar7.Location = new System.Drawing.Point(0, 272);
            this.trackBar7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(132, 69);
            this.trackBar7.TabIndex = 147;
            this.trackBar7.Scroll += new System.EventHandler(this.trackBar7_Scroll_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 248);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 146;
            this.label7.Text = "D1L";
            // 
            // trackBar6
            // 
            this.trackBar6.Location = new System.Drawing.Point(2, 192);
            this.trackBar6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(130, 69);
            this.trackBar6.TabIndex = 145;
            this.trackBar6.Scroll += new System.EventHandler(this.trackBar6_Scroll_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 144;
            this.label6.Text = "AR";
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(-2, 118);
            this.trackBar5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(129, 69);
            this.trackBar5.TabIndex = 143;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 142;
            this.label5.Text = "AL";
            // 
            // trackBar21
            // 
            this.trackBar21.Location = new System.Drawing.Point(4, 49);
            this.trackBar21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar21.Name = "trackBar21";
            this.trackBar21.Size = new System.Drawing.Size(126, 69);
            this.trackBar21.TabIndex = 159;
            this.trackBar21.Scroll += new System.EventHandler(this.trackBar21_Scroll_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 164);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 24);
            this.checkBox1.TabIndex = 160;
            this.checkBox1.Text = "fixed";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Green;
            this.radioButton1.Location = new System.Drawing.Point(14, 26);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 24);
            this.radioButton1.TabIndex = 218;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "OP1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Crimson;
            this.radioButton2.Location = new System.Drawing.Point(14, 62);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 24);
            this.radioButton2.TabIndex = 219;
            this.radioButton2.Text = "OP2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.Purple;
            this.radioButton3.Location = new System.Drawing.Point(14, 94);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 24);
            this.radioButton3.TabIndex = 220;
            this.radioButton3.Text = "OP3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.Goldenrod;
            this.radioButton4.Location = new System.Drawing.Point(14, 129);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(65, 24);
            this.radioButton4.TabIndex = 221;
            this.radioButton4.Text = "OP4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.Color.OrangeRed;
            this.radioButton5.Location = new System.Drawing.Point(14, 163);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(65, 24);
            this.radioButton5.TabIndex = 222;
            this.radioButton5.Text = "OP5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.ForeColor = System.Drawing.Color.Red;
            this.radioButton6.Location = new System.Drawing.Point(14, 195);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(65, 24);
            this.radioButton6.TabIndex = 223;
            this.radioButton6.Text = "OP6";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label38);
            this.groupBox7.Controls.Add(this.checkBox1);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.label55);
            this.groupBox7.Controls.Add(this.label66);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.trackBar23);
            this.groupBox7.Controls.Add(this.trackBar60);
            this.groupBox7.Controls.Add(this.trackBar1);
            this.groupBox7.Controls.Add(this.trackBar55);
            this.groupBox7.Controls.Add(this.trackBar38);
            this.groupBox7.Controls.Add(this.trackBar37);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox7.Location = new System.Drawing.Point(872, 46);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Size = new System.Drawing.Size(153, 515);
            this.groupBox7.TabIndex = 224;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "OP1";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton7.Location = new System.Drawing.Point(14, 223);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(96, 24);
            this.radioButton7.TabIndex = 228;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "PICHEG";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkBox7);
            this.groupBox8.Controls.Add(this.checkBox6);
            this.groupBox8.Controls.Add(this.checkBox5);
            this.groupBox8.Controls.Add(this.checkBox4);
            this.groupBox8.Controls.Add(this.checkBox3);
            this.groupBox8.Controls.Add(this.checkBox2);
            this.groupBox8.Controls.Add(this.label58);
            this.groupBox8.Controls.Add(this.label39);
            this.groupBox8.Controls.Add(this.label40);
            this.groupBox8.Controls.Add(this.trackBar40);
            this.groupBox8.Controls.Add(this.radioButton7);
            this.groupBox8.Controls.Add(this.radioButton1);
            this.groupBox8.Controls.Add(this.radioButton5);
            this.groupBox8.Controls.Add(this.radioButton4);
            this.groupBox8.Controls.Add(this.radioButton6);
            this.groupBox8.Controls.Add(this.radioButton3);
            this.groupBox8.Controls.Add(this.radioButton2);
            this.groupBox8.Controls.Add(this.trackBar39);
            this.groupBox8.Controls.Add(this.trackBar56);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox8.Location = new System.Drawing.Point(728, 46);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox8.Size = new System.Drawing.Size(138, 258);
            this.groupBox8.TabIndex = 225;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "OP";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Location = new System.Drawing.Point(86, 195);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(48, 24);
            this.checkBox7.TabIndex = 240;
            this.checkBox7.Text = "M";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(86, 163);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(48, 24);
            this.checkBox6.TabIndex = 239;
            this.checkBox6.Text = "M";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(86, 129);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(48, 24);
            this.checkBox5.TabIndex = 238;
            this.checkBox5.Text = "M";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(86, 94);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(48, 24);
            this.checkBox4.TabIndex = 237;
            this.checkBox4.Text = "M";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(87, 62);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(48, 24);
            this.checkBox3.TabIndex = 236;
            this.checkBox3.Text = "M";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(86, 28);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 24);
            this.checkBox2.TabIndex = 235;
            this.checkBox2.Text = "M";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox10.Controls.Add(this.button19);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Controls.Add(this.trackBar4);
            this.groupBox10.Controls.Add(this.label14);
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Controls.Add(this.trackBar14);
            this.groupBox10.Controls.Add(this.trackBar13);
            this.groupBox10.Controls.Add(this.trackBar2);
            this.groupBox10.Controls.Add(this.trackBar63);
            this.groupBox10.Controls.Add(this.label60);
            this.groupBox10.Controls.Add(this.label35);
            this.groupBox10.Controls.Add(this.label34);
            this.groupBox10.Controls.Add(this.trackBar33);
            this.groupBox10.Controls.Add(this.label33);
            this.groupBox10.Controls.Add(this.trackBar51);
            this.groupBox10.Controls.Add(this.label69);
            this.groupBox10.Controls.Add(this.trackBar31);
            this.groupBox10.Controls.Add(this.label51);
            this.groupBox10.Controls.Add(this.label31);
            this.groupBox10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox10.Location = new System.Drawing.Point(15, 117);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox10.Size = new System.Drawing.Size(700, 174);
            this.groupBox10.TabIndex = 227;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "GLOBAL";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(157, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 20);
            this.label16.TabIndex = 206;
            this.label16.Text = "OPVOLUME";
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(151, 52);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(104, 69);
            this.trackBar4.TabIndex = 205;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(262, 118);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 204;
            this.label14.Text = "OFSET";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(495, 122);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 20);
            this.label13.TabIndex = 203;
            this.label13.Text = "LIMITGAIN";
            // 
            // trackBar14
            // 
            this.trackBar14.Location = new System.Drawing.Point(592, 118);
            this.trackBar14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar14.Name = "trackBar14";
            this.trackBar14.Size = new System.Drawing.Size(84, 69);
            this.trackBar14.TabIndex = 202;
            this.trackBar14.Scroll += new System.EventHandler(this.trackBar14_Scroll);
            // 
            // trackBar13
            // 
            this.trackBar13.Location = new System.Drawing.Point(384, 118);
            this.trackBar13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar13.Name = "trackBar13";
            this.trackBar13.Size = new System.Drawing.Size(90, 69);
            this.trackBar13.TabIndex = 201;
            this.trackBar13.Scroll += new System.EventHandler(this.trackBar13_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(32, 58);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(100, 69);
            this.trackBar2.TabIndex = 198;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar63
            // 
            this.trackBar63.Location = new System.Drawing.Point(489, 52);
            this.trackBar63.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar63.Name = "trackBar63";
            this.trackBar63.Size = new System.Drawing.Size(94, 69);
            this.trackBar63.TabIndex = 197;
            this.trackBar63.Scroll += new System.EventHandler(this.trackBar63_Scroll_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(729, 583);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 20);
            this.label15.TabIndex = 205;
            this.label15.Text = "REVERBTIME";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(726, 601);
            this.trackBar3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(118, 69);
            this.trackBar3.TabIndex = 199;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Navy;
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button13.Location = new System.Drawing.Point(534, 80);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(112, 35);
            this.button13.TabIndex = 229;
            this.button13.Text = "Auto Note";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // GroupBox9
            // 
            this.GroupBox9.Controls.Add(this.progressBar1);
            this.GroupBox9.Controls.Add(this.button18);
            this.GroupBox9.Controls.Add(this.button17);
            this.GroupBox9.Controls.Add(this.button16);
            this.GroupBox9.Controls.Add(this.button15);
            this.GroupBox9.Controls.Add(this.button14);
            this.GroupBox9.Controls.Add(this.button12);
            this.GroupBox9.Controls.Add(this.label56);
            this.GroupBox9.Controls.Add(this.label57);
            this.GroupBox9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox9.Location = new System.Drawing.Point(1178, 572);
            this.GroupBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox9.Size = new System.Drawing.Size(318, 248);
            this.GroupBox9.TabIndex = 230;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "groupBox9";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.progressBar1.Location = new System.Drawing.Point(11, 140);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(112, 20);
            this.progressBar1.TabIndex = 236;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.MidnightBlue;
            this.button18.Location = new System.Drawing.Point(130, 194);
            this.button18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(112, 35);
            this.button18.TabIndex = 216;
            this.button18.Text = "Clear Text";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.MidnightBlue;
            this.button17.Location = new System.Drawing.Point(130, 146);
            this.button17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(112, 35);
            this.button17.TabIndex = 215;
            this.button17.Text = "Send Text";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Navy;
            this.button16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button16.Location = new System.Drawing.Point(9, 34);
            this.button16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(112, 35);
            this.button16.TabIndex = 214;
            this.button16.Text = "Init Sound";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Navy;
            this.button15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button15.Location = new System.Drawing.Point(9, 91);
            this.button15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(112, 35);
            this.button15.TabIndex = 213;
            this.button15.Text = "OpenSound";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Navy;
            this.button14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button14.Location = new System.Drawing.Point(130, 29);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(112, 35);
            this.button14.TabIndex = 212;
            this.button14.Text = "SaveSound";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.Black;
            this.groupBox11.Controls.Add(this.pianoControl1);
            this.groupBox11.Controls.Add(this.button2);
            this.groupBox11.Controls.Add(this.button3);
            this.groupBox11.Controls.Add(this.button4);
            this.groupBox11.Controls.Add(this.button5);
            this.groupBox11.Controls.Add(this.button6);
            this.groupBox11.Controls.Add(this.button7);
            this.groupBox11.Controls.Add(this.button8);
            this.groupBox11.Controls.Add(this.label93);
            this.groupBox11.Controls.Add(this.label92);
            this.groupBox11.Controls.Add(this.button9);
            this.groupBox11.Controls.Add(this.button10);
            this.groupBox11.Controls.Add(this.button11);
            this.groupBox11.Location = new System.Drawing.Point(7, 656);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox11.Size = new System.Drawing.Size(861, 243);
            this.groupBox11.TabIndex = 231;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "OP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(14, 300);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 341);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(278, 5);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 28);
            this.comboBox2.TabIndex = 232;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(240, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 233;
            this.label2.Text = "IN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(480, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 234;
            this.label3.Text = "OUT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(1175, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 235;
            this.label4.Text = "PARAMETERS:";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label54);
            this.panel1.Controls.Add(this.trackBar62);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label68);
            this.panel1.Controls.Add(this.label67);
            this.panel1.Controls.Add(this.trackBar24);
            this.panel1.Controls.Add(this.trackBar54);
            this.panel1.Controls.Add(this.trackBar61);
            this.panel1.Location = new System.Drawing.Point(870, 569);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 350);
            this.panel1.TabIndex = 236;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(161, 115);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(22, 23);
            this.button19.TabIndex = 207;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1564, 952);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label88);
            this.Controls.Add(this.label86);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.trackBar85);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label87);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.label89);
            this.Controls.Add(this.GroupBox9);
            this.Controls.Add(this.trackBar87);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.trackBar84);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.trackBar86);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.positionHScrollBar);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.trackBar3);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "DXDUE 7";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar84)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar85)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar86)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar87)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar21)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.HScrollBar positionHScrollBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openMidiFileDialog;
        private Sanford.Multimedia.Midi.UI.PianoControl pianoControl1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem mIDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputDeviceToolStripMenuItem;
        private Sequence sequence1;
        private Sequencer sequencer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TrackBar trackBar23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TrackBar trackBar24;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TrackBar trackBar31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TrackBar trackBar32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TrackBar trackBar33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TrackBar trackBar37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TrackBar trackBar38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TrackBar trackBar39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TrackBar trackBar40;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TrackBar trackBar51;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TrackBar trackBar54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TrackBar trackBar55;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TrackBar trackBar56;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TrackBar trackBar57;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TrackBar trackBar60;
        private System.Windows.Forms.TrackBar trackBar61;
        private System.Windows.Forms.TrackBar trackBar62;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.TrackBar trackBar84;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.TrackBar trackBar85;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.TrackBar trackBar86;
        private System.Windows.Forms.TrackBar trackBar87;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar trackBar21;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackBar12;
        private System.Windows.Forms.TrackBar trackBar11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackBar10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBar9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.GroupBox GroupBox9;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TrackBar trackBar63;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar trackBar14;
        private System.Windows.Forms.TrackBar trackBar13;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.ToolStripMenuItem dXDUE7ToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Button button19;
    }
}

