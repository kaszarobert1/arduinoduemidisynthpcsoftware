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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
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
            this.label19 = new System.Windows.Forms.Label();
            this.trackBar25 = new System.Windows.Forms.TrackBar();
            this.label27 = new System.Windows.Forms.Label();
            this.trackBar17 = new System.Windows.Forms.TrackBar();
            this.button19 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.trackBar13 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar63 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.trackBar14 = new System.Windows.Forms.TrackBar();
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
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.trackBar22 = new System.Windows.Forms.TrackBar();
            this.trackBar20 = new System.Windows.Forms.TrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.trackBar15 = new System.Windows.Forms.TrackBar();
            this.label18 = new System.Windows.Forms.Label();
            this.trackBar16 = new System.Windows.Forms.TrackBar();
            this.trackBar18 = new System.Windows.Forms.TrackBar();
            this.label20 = new System.Windows.Forms.Label();
            this.trackBar19 = new System.Windows.Forms.TrackBar();
            this.label22 = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.GroupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar19)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Teal;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stopButton.Location = new System.Drawing.Point(97, 32);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "Stop";
            this.stopButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Teal;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.Location = new System.Drawing.Point(185, 32);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Teal;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.continueButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.continueButton.Location = new System.Drawing.Point(271, 31);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 23);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue";
            this.continueButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mIDIToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1039, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mIDIToolStripMenuItem
            // 
            this.mIDIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputDeviceToolStripMenuItem});
            this.mIDIToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mIDIToolStripMenuItem.Name = "mIDIToolStripMenuItem";
            this.mIDIToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.mIDIToolStripMenuItem.Text = "&MIDI";
            this.mIDIToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // outputDeviceToolStripMenuItem
            // 
            this.outputDeviceToolStripMenuItem.Name = "outputDeviceToolStripMenuItem";
            this.outputDeviceToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dXDUE7ToolStripMenuItem
            // 
            this.dXDUE7ToolStripMenuItem.Name = "dXDUE7ToolStripMenuItem";
            this.dXDUE7ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 654);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1039, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pianoControl1
            // 
            this.pianoControl1.HighNoteID = 109;
            this.pianoControl1.Location = new System.Drawing.Point(7, 48);
            this.pianoControl1.LowNoteID = 21;
            this.pianoControl1.Name = "pianoControl1";
            this.pianoControl1.NoteOnColor = System.Drawing.Color.SkyBlue;
            this.pianoControl1.Size = new System.Drawing.Size(469, 79);
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
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar1.Location = new System.Drawing.Point(3, 32);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(1);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(67, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(1, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "WAVEFORM";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label23.Location = new System.Drawing.Point(1, 54);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 13);
            this.label23.TabIndex = 51;
            this.label23.Text = "FREQ";
            // 
            // trackBar23
            // 
            this.trackBar23.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar23.Location = new System.Drawing.Point(3, 66);
            this.trackBar23.Name = "trackBar23";
            this.trackBar23.Size = new System.Drawing.Size(67, 45);
            this.trackBar23.TabIndex = 52;
            this.trackBar23.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar23.Scroll += new System.EventHandler(this.trackBar23_Scroll);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label24.Location = new System.Drawing.Point(5, 70);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 13);
            this.label24.TabIndex = 53;
            this.label24.Text = "LEVEL";
            // 
            // trackBar24
            // 
            this.trackBar24.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar24.Location = new System.Drawing.Point(7, 82);
            this.trackBar24.Name = "trackBar24";
            this.trackBar24.Size = new System.Drawing.Size(67, 45);
            this.trackBar24.TabIndex = 54;
            this.trackBar24.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar24.Scroll += new System.EventHandler(this.trackBar24_Scroll);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label31.Location = new System.Drawing.Point(233, 16);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(62, 13);
            this.label31.TabIndex = 67;
            this.label31.Text = "LFO MODE";
            // 
            // trackBar31
            // 
            this.trackBar31.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar31.Location = new System.Drawing.Point(230, 26);
            this.trackBar31.Name = "trackBar31";
            this.trackBar31.Size = new System.Drawing.Size(67, 45);
            this.trackBar31.TabIndex = 68;
            this.trackBar31.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar31.Scroll += new System.EventHandler(this.trackBar31_Scroll);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label32.Location = new System.Drawing.Point(1, 378);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(65, 13);
            this.label32.TabIndex = 69;
            this.label32.Text = "PICHBEGIN";
            // 
            // trackBar32
            // 
            this.trackBar32.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar32.Location = new System.Drawing.Point(3, 391);
            this.trackBar32.Name = "trackBar32";
            this.trackBar32.Size = new System.Drawing.Size(67, 45);
            this.trackBar32.TabIndex = 70;
            this.trackBar32.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar32.Scroll += new System.EventHandler(this.trackBar32_Scroll);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label33.Location = new System.Drawing.Point(158, 16);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(75, 13);
            this.label33.TabIndex = 71;
            this.label33.Text = "LFO VOLUME";
            // 
            // trackBar33
            // 
            this.trackBar33.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar33.Location = new System.Drawing.Point(156, 27);
            this.trackBar33.Name = "trackBar33";
            this.trackBar33.Size = new System.Drawing.Size(67, 45);
            this.trackBar33.TabIndex = 72;
            this.trackBar33.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar33.Scroll += new System.EventHandler(this.trackBar33_Scroll);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label34.Location = new System.Drawing.Point(300, 15);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 13);
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
            this.label35.Location = new System.Drawing.Point(379, 109);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(42, 13);
            this.label35.TabIndex = 75;
            this.label35.Text = "noteset";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label37.Location = new System.Drawing.Point(1, 178);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(55, 13);
            this.label37.TabIndex = 79;
            this.label37.Text = "STEP BIT";
            this.label37.Click += new System.EventHandler(this.label37_Click);
            // 
            // trackBar37
            // 
            this.trackBar37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.trackBar37.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar37.Location = new System.Drawing.Point(3, 192);
            this.trackBar37.Maximum = 28;
            this.trackBar37.Minimum = 13;
            this.trackBar37.Name = "trackBar37";
            this.trackBar37.Size = new System.Drawing.Size(67, 45);
            this.trackBar37.TabIndex = 80;
            this.trackBar37.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar37.Value = 13;
            this.trackBar37.Scroll += new System.EventHandler(this.trackBar37_Scroll);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label38.Location = new System.Drawing.Point(1, 144);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(52, 13);
            this.label38.TabIndex = 81;
            this.label38.Text = "DETUNE";
            // 
            // trackBar38
            // 
            this.trackBar38.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar38.Location = new System.Drawing.Point(3, 157);
            this.trackBar38.Maximum = 127;
            this.trackBar38.Name = "trackBar38";
            this.trackBar38.Size = new System.Drawing.Size(67, 45);
            this.trackBar38.TabIndex = 82;
            this.trackBar38.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar38.Scroll += new System.EventHandler(this.trackBar38_Scroll);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(9, 358);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(46, 13);
            this.label39.TabIndex = 83;
            this.label39.Text = "PICHRL";
            // 
            // trackBar39
            // 
            this.trackBar39.Location = new System.Drawing.Point(9, 376);
            this.trackBar39.Name = "trackBar39";
            this.trackBar39.Size = new System.Drawing.Size(78, 45);
            this.trackBar39.TabIndex = 84;
            this.trackBar39.Scroll += new System.EventHandler(this.trackBar39_Scroll);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(9, 406);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(48, 13);
            this.label40.TabIndex = 85;
            this.label40.Text = "PICHRR";
            // 
            // trackBar40
            // 
            this.trackBar40.Location = new System.Drawing.Point(8, 425);
            this.trackBar40.Name = "trackBar40";
            this.trackBar40.Size = new System.Drawing.Size(79, 45);
            this.trackBar40.TabIndex = 86;
            this.trackBar40.Scroll += new System.EventHandler(this.trackBar40_Scroll);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label51.Location = new System.Drawing.Point(157, 51);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(58, 13);
            this.label51.TabIndex = 107;
            this.label51.Text = "TUNE DIV";
            // 
            // trackBar51
            // 
            this.trackBar51.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar51.Location = new System.Drawing.Point(155, 60);
            this.trackBar51.Name = "trackBar51";
            this.trackBar51.Size = new System.Drawing.Size(67, 45);
            this.trackBar51.TabIndex = 108;
            this.trackBar51.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar51.Scroll += new System.EventHandler(this.trackBar51_Scroll);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label54.Location = new System.Drawing.Point(3, 38);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(55, 13);
            this.label54.TabIndex = 113;
            this.label54.Text = "OPLEVEL";
            this.label54.Click += new System.EventHandler(this.label54_Click);
            // 
            // trackBar54
            // 
            this.trackBar54.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar54.Location = new System.Drawing.Point(5, 50);
            this.trackBar54.Maximum = 127;
            this.trackBar54.Name = "trackBar54";
            this.trackBar54.Size = new System.Drawing.Size(67, 45);
            this.trackBar54.TabIndex = 114;
            this.trackBar54.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar54.Scroll += new System.EventHandler(this.trackBar54_Scroll);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label55.Location = new System.Drawing.Point(3, 2);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(63, 13);
            this.label55.TabIndex = 115;
            this.label55.Text = "FEEDBACK";
            // 
            // trackBar55
            // 
            this.trackBar55.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar55.Location = new System.Drawing.Point(5, 15);
            this.trackBar55.Name = "trackBar55";
            this.trackBar55.Size = new System.Drawing.Size(67, 45);
            this.trackBar55.TabIndex = 116;
            this.trackBar55.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar55.Scroll += new System.EventHandler(this.trackBar55_Scroll);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(356, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 117;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label56.ForeColor = System.Drawing.Color.Goldenrod;
            this.label56.Location = new System.Drawing.Point(5, 108);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(81, 42);
            this.label56.TabIndex = 118;
            this.label56.Text = "000";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label57.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label57.Location = new System.Drawing.Point(1200, 300);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(44, 13);
            this.label57.TabIndex = 119;
            this.label57.Text = "dfdffdf";
            // 
            // trackBar56
            // 
            this.trackBar56.Location = new System.Drawing.Point(6, 471);
            this.trackBar56.Name = "trackBar56";
            this.trackBar56.Size = new System.Drawing.Size(65, 45);
            this.trackBar56.TabIndex = 120;
            this.trackBar56.Scroll += new System.EventHandler(this.trackBar56_Scroll);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(10, 455);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(53, 13);
            this.label58.TabIndex = 121;
            this.label58.Text = "PICHTVA";
            // 
            // trackBar57
            // 
            this.trackBar57.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar57.Location = new System.Drawing.Point(3, 355);
            this.trackBar57.Maximum = 2;
            this.trackBar57.Name = "trackBar57";
            this.trackBar57.Size = new System.Drawing.Size(67, 45);
            this.trackBar57.TabIndex = 122;
            this.trackBar57.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar57.Scroll += new System.EventHandler(this.trackBar57_Scroll);
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label59.Location = new System.Drawing.Point(1, 343);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(47, 13);
            this.label59.TabIndex = 123;
            this.label59.Text = "PICHOP";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label60.Location = new System.Drawing.Point(74, 16);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(0, 13);
            this.label60.TabIndex = 126;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(158)))), ((int)(((byte)(215)))));
            this.richTextBox2.Location = new System.Drawing.Point(783, 32);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(214, 439);
            this.richTextBox2.TabIndex = 129;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(9, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 130;
            this.button1.Text = "Initial";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label66.Location = new System.Drawing.Point(1, 108);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(52, 13);
            this.label66.TabIndex = 135;
            this.label66.Text = "FIXFREQ";
            this.label66.Click += new System.EventHandler(this.label66_Click);
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label67.Location = new System.Drawing.Point(5, 105);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(44, 13);
            this.label67.TabIndex = 136;
            this.label67.Text = "FRAME";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label68.Location = new System.Drawing.Point(5, 140);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(71, 13);
            this.label68.TabIndex = 137;
            this.label68.Text = "ALGORITHM";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label69.Location = new System.Drawing.Point(1, 16);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(83, 13);
            this.label69.TabIndex = 138;
            this.label69.Text = "EXT LFO FREQ";
            // 
            // trackBar60
            // 
            this.trackBar60.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar60.Location = new System.Drawing.Point(3, 121);
            this.trackBar60.Name = "trackBar60";
            this.trackBar60.Size = new System.Drawing.Size(67, 45);
            this.trackBar60.TabIndex = 139;
            this.trackBar60.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar60.Scroll += new System.EventHandler(this.trackBar60_Scroll);
            // 
            // trackBar61
            // 
            this.trackBar61.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar61.Location = new System.Drawing.Point(7, 116);
            this.trackBar61.Maximum = 127;
            this.trackBar61.Minimum = 1;
            this.trackBar61.Name = "trackBar61";
            this.trackBar61.Size = new System.Drawing.Size(67, 45);
            this.trackBar61.TabIndex = 140;
            this.trackBar61.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar61.Value = 1;
            this.trackBar61.Scroll += new System.EventHandler(this.trackBar61_Scroll);
            // 
            // trackBar62
            // 
            this.trackBar62.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar62.Location = new System.Drawing.Point(7, 154);
            this.trackBar62.Name = "trackBar62";
            this.trackBar62.Size = new System.Drawing.Size(67, 45);
            this.trackBar62.TabIndex = 145;
            this.trackBar62.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar62.Scroll += new System.EventHandler(this.trackBar62_Scroll);
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label86.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label86.Location = new System.Drawing.Point(1, 192);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(85, 13);
            this.label86.TabIndex = 189;
            this.label86.Text = "CHORUS FREQ";
            // 
            // trackBar84
            // 
            this.trackBar84.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.trackBar84.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar84.Location = new System.Drawing.Point(3, 204);
            this.trackBar84.Name = "trackBar84";
            this.trackBar84.Size = new System.Drawing.Size(67, 45);
            this.trackBar84.TabIndex = 190;
            this.trackBar84.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar84.Scroll += new System.EventHandler(this.trackBar84_Scroll);
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label87.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label87.Location = new System.Drawing.Point(3, 227);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(57, 13);
            this.label87.TabIndex = 191;
            this.label87.Text = "EQVALUE";
            // 
            // trackBar85
            // 
            this.trackBar85.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.trackBar85.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar85.Location = new System.Drawing.Point(3, 239);
            this.trackBar85.Name = "trackBar85";
            this.trackBar85.Size = new System.Drawing.Size(67, 45);
            this.trackBar85.TabIndex = 192;
            this.trackBar85.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar85.Scroll += new System.EventHandler(this.trackBar85_Scroll);
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label88.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label88.Location = new System.Drawing.Point(1, 157);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(89, 13);
            this.label88.TabIndex = 193;
            this.label88.Text = "CHORUS LEVEL";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.BackColor = System.Drawing.Color.Transparent;
            this.label89.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label89.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label89.Location = new System.Drawing.Point(1, 5);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(87, 13);
            this.label89.TabIndex = 194;
            this.label89.Text = "REVERB LEVEL";
            // 
            // trackBar86
            // 
            this.trackBar86.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.trackBar86.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar86.Location = new System.Drawing.Point(3, 168);
            this.trackBar86.Maximum = 16;
            this.trackBar86.Name = "trackBar86";
            this.trackBar86.Size = new System.Drawing.Size(67, 45);
            this.trackBar86.TabIndex = 195;
            this.trackBar86.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar86.Scroll += new System.EventHandler(this.trackBar86_Scroll);
            // 
            // trackBar87
            // 
            this.trackBar87.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.trackBar87.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar87.Location = new System.Drawing.Point(3, 19);
            this.trackBar87.Name = "trackBar87";
            this.trackBar87.Size = new System.Drawing.Size(67, 45);
            this.trackBar87.TabIndex = 196;
            this.trackBar87.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar87.Scroll += new System.EventHandler(this.trackBar87_Scroll);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(4, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 21);
            this.button2.TabIndex = 201;
            this.button2.Text = "0";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(41, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 21);
            this.button3.TabIndex = 202;
            this.button3.Text = "1";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(80, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 21);
            this.button4.TabIndex = 203;
            this.button4.Text = "2";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(119, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 21);
            this.button5.TabIndex = 204;
            this.button5.Text = "3";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Teal;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button6.Location = new System.Drawing.Point(160, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 21);
            this.button6.TabIndex = 205;
            this.button6.Text = "4";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Teal;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Location = new System.Drawing.Point(201, 16);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 21);
            this.button7.TabIndex = 206;
            this.button7.Text = "5";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Teal;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button8.Location = new System.Drawing.Point(243, 16);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 21);
            this.button8.TabIndex = 207;
            this.button8.Text = "6";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Teal;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button9.Location = new System.Drawing.Point(285, 16);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 21);
            this.button9.TabIndex = 208;
            this.button9.Text = "7";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Teal;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button10.Location = new System.Drawing.Point(327, 16);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 21);
            this.button10.TabIndex = 209;
            this.button10.Text = "8";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Teal;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button11.Location = new System.Drawing.Point(367, 16);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(35, 21);
            this.button11.TabIndex = 210;
            this.button11.Text = "9";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Red;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button12.Location = new System.Drawing.Point(87, 58);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 211;
            this.button12.Text = "WRITE";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.groupBox1.Controls.Add(this.trackBar32);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.trackBar57);
            this.groupBox1.Controls.Add(this.label59);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.trackBar12);
            this.groupBox1.Controls.Add(this.trackBar11);
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
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.trackBar5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.trackBar21);
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(679, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 442);
            this.groupBox1.TabIndex = 214;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OP1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label21.Location = new System.Drawing.Point(1, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 158;
            this.label21.Text = "VOLUME";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 307);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 157;
            this.label12.Text = "RR";
            // 
            // trackBar12
            // 
            this.trackBar12.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar12.Location = new System.Drawing.Point(3, 319);
            this.trackBar12.Name = "trackBar12";
            this.trackBar12.Size = new System.Drawing.Size(67, 45);
            this.trackBar12.TabIndex = 156;
            this.trackBar12.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar12.Scroll += new System.EventHandler(this.trackBar12_Scroll_1);
            // 
            // trackBar11
            // 
            this.trackBar11.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar11.Location = new System.Drawing.Point(3, 283);
            this.trackBar11.Name = "trackBar11";
            this.trackBar11.Size = new System.Drawing.Size(67, 45);
            this.trackBar11.TabIndex = 155;
            this.trackBar11.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar11.Scroll += new System.EventHandler(this.trackBar11_Scroll_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 154;
            this.label11.Text = "RL";
            // 
            // trackBar10
            // 
            this.trackBar10.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar10.Location = new System.Drawing.Point(3, 247);
            this.trackBar10.Name = "trackBar10";
            this.trackBar10.Size = new System.Drawing.Size(67, 45);
            this.trackBar10.TabIndex = 153;
            this.trackBar10.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar10.Scroll += new System.EventHandler(this.trackBar10_Scroll_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 152;
            this.label10.Text = "D2R";
            // 
            // trackBar9
            // 
            this.trackBar9.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar9.Location = new System.Drawing.Point(3, 213);
            this.trackBar9.Name = "trackBar9";
            this.trackBar9.Size = new System.Drawing.Size(67, 45);
            this.trackBar9.TabIndex = 151;
            this.trackBar9.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar9.Scroll += new System.EventHandler(this.trackBar9_Scroll_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 150;
            this.label9.Text = "D2L";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 149;
            this.label8.Text = "D1R";
            // 
            // trackBar8
            // 
            this.trackBar8.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar8.Location = new System.Drawing.Point(3, 175);
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Size = new System.Drawing.Size(67, 45);
            this.trackBar8.TabIndex = 148;
            this.trackBar8.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar8.Scroll += new System.EventHandler(this.trackBar8_Scroll_1);
            // 
            // trackBar7
            // 
            this.trackBar7.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar7.Location = new System.Drawing.Point(1, 138);
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(67, 45);
            this.trackBar7.TabIndex = 147;
            this.trackBar7.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar7.Scroll += new System.EventHandler(this.trackBar7_Scroll_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 146;
            this.label7.Text = "D1L";
            // 
            // trackBar6
            // 
            this.trackBar6.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar6.Location = new System.Drawing.Point(3, 103);
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(67, 45);
            this.trackBar6.TabIndex = 145;
            this.trackBar6.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar6.Scroll += new System.EventHandler(this.trackBar6_Scroll_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 144;
            this.label6.Text = "AR";
            // 
            // trackBar5
            // 
            this.trackBar5.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar5.Location = new System.Drawing.Point(3, 68);
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(67, 45);
            this.trackBar5.TabIndex = 143;
            this.trackBar5.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 142;
            this.label5.Text = "AL";
            // 
            // trackBar21
            // 
            this.trackBar21.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar21.Location = new System.Drawing.Point(3, 32);
            this.trackBar21.Name = "trackBar21";
            this.trackBar21.Size = new System.Drawing.Size(67, 45);
            this.trackBar21.TabIndex = 159;
            this.trackBar21.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar21.Scroll += new System.EventHandler(this.trackBar21_Scroll_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 160;
            this.checkBox1.Text = "fixed";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Teal;
            this.radioButton1.Location = new System.Drawing.Point(7, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
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
            this.radioButton2.Location = new System.Drawing.Point(7, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 219;
            this.radioButton2.Text = "OP2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.Purple;
            this.radioButton3.Location = new System.Drawing.Point(7, 61);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 220;
            this.radioButton3.Text = "OP3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.LemonChiffon;
            this.radioButton4.Location = new System.Drawing.Point(7, 84);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(46, 17);
            this.radioButton4.TabIndex = 221;
            this.radioButton4.Text = "OP4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.Color.OrangeRed;
            this.radioButton5.Location = new System.Drawing.Point(7, 106);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(46, 17);
            this.radioButton5.TabIndex = 222;
            this.radioButton5.Text = "OP5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.ForeColor = System.Drawing.Color.Red;
            this.radioButton6.Location = new System.Drawing.Point(7, 127);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(46, 17);
            this.radioButton6.TabIndex = 223;
            this.radioButton6.Text = "OP6";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.groupBox7.Controls.Add(this.trackBar37);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Controls.Add(this.trackBar38);
            this.groupBox7.Controls.Add(this.label38);
            this.groupBox7.Controls.Add(this.checkBox1);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.label66);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.trackBar23);
            this.groupBox7.Controls.Add(this.trackBar60);
            this.groupBox7.Controls.Add(this.trackBar1);
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(158)))), ((int)(((byte)(215)))));
            this.groupBox7.Location = new System.Drawing.Point(582, 30);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(92, 220);
            this.groupBox7.TabIndex = 224;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "OP1";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton7.Location = new System.Drawing.Point(7, 145);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(65, 17);
            this.radioButton7.TabIndex = 228;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "PICHEG";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
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
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(158)))), ((int)(((byte)(215)))));
            this.groupBox8.Location = new System.Drawing.Point(485, 30);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(92, 168);
            this.groupBox8.TabIndex = 225;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "OP Generators";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Location = new System.Drawing.Point(55, 127);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(35, 17);
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
            this.checkBox6.Location = new System.Drawing.Point(55, 106);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(35, 17);
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
            this.checkBox5.Location = new System.Drawing.Point(55, 84);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(35, 17);
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
            this.checkBox4.Location = new System.Drawing.Point(55, 61);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(35, 17);
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
            this.checkBox3.Location = new System.Drawing.Point(56, 40);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(35, 17);
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
            this.checkBox2.Location = new System.Drawing.Point(55, 18);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(35, 17);
            this.checkBox2.TabIndex = 235;
            this.checkBox2.Text = "M";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.groupBox10.Controls.Add(this.label33);
            this.groupBox10.Controls.Add(this.label31);
            this.groupBox10.Controls.Add(this.label51);
            this.groupBox10.Controls.Add(this.trackBar51);
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Controls.Add(this.trackBar25);
            this.groupBox10.Controls.Add(this.label27);
            this.groupBox10.Controls.Add(this.trackBar17);
            this.groupBox10.Controls.Add(this.button19);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Controls.Add(this.label14);
            this.groupBox10.Controls.Add(this.trackBar13);
            this.groupBox10.Controls.Add(this.trackBar2);
            this.groupBox10.Controls.Add(this.trackBar63);
            this.groupBox10.Controls.Add(this.label60);
            this.groupBox10.Controls.Add(this.label35);
            this.groupBox10.Controls.Add(this.label34);
            this.groupBox10.Controls.Add(this.trackBar33);
            this.groupBox10.Controls.Add(this.label69);
            this.groupBox10.Controls.Add(this.trackBar31);
            this.groupBox10.Controls.Add(this.trackBar4);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(158)))), ((int)(((byte)(215)))));
            this.groupBox10.Location = new System.Drawing.Point(10, 60);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(466, 136);
            this.groupBox10.TabIndex = 227;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "GLOBAL";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(232, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 208;
            this.label19.Text = "FINE TUNE";
            // 
            // trackBar25
            // 
            this.trackBar25.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar25.Location = new System.Drawing.Point(365, 26);
            this.trackBar25.Name = "trackBar25";
            this.trackBar25.Size = new System.Drawing.Size(67, 45);
            this.trackBar25.TabIndex = 211;
            this.trackBar25.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar25.Scroll += new System.EventHandler(this.trackBar25_Scroll);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label27.Location = new System.Drawing.Point(367, 15);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 13);
            this.label27.TabIndex = 210;
            this.label27.Text = "LFO DELAY";
            // 
            // trackBar17
            // 
            this.trackBar17.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar17.Location = new System.Drawing.Point(227, 62);
            this.trackBar17.Name = "trackBar17";
            this.trackBar17.Size = new System.Drawing.Size(67, 45);
            this.trackBar17.TabIndex = 209;
            this.trackBar17.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar17.Scroll += new System.EventHandler(this.trackBar17_Scroll);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(48, 62);
            this.button19.Margin = new System.Windows.Forms.Padding(2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(15, 15);
            this.button19.TabIndex = 207;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(88, 16);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 206;
            this.label16.Text = "OPVOLUME";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(5, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 204;
            this.label14.Text = "OFSET:";
            // 
            // trackBar13
            // 
            this.trackBar13.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar13.Location = new System.Drawing.Point(85, 60);
            this.trackBar13.Name = "trackBar13";
            this.trackBar13.Size = new System.Drawing.Size(67, 45);
            this.trackBar13.TabIndex = 201;
            this.trackBar13.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar13.Scroll += new System.EventHandler(this.trackBar13_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar2.Location = new System.Drawing.Point(3, 29);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(67, 45);
            this.trackBar2.TabIndex = 198;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar63
            // 
            this.trackBar63.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar63.Location = new System.Drawing.Point(297, 26);
            this.trackBar63.Name = "trackBar63";
            this.trackBar63.Size = new System.Drawing.Size(67, 45);
            this.trackBar63.TabIndex = 197;
            this.trackBar63.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar63.Scroll += new System.EventHandler(this.trackBar63_Scroll_1);
            // 
            // trackBar4
            // 
            this.trackBar4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar4.Location = new System.Drawing.Point(85, 27);
            this.trackBar4.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(67, 45);
            this.trackBar4.TabIndex = 205;
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label13.Location = new System.Drawing.Point(5, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 203;
            this.label13.Text = "LIMITGAIN";
            // 
            // trackBar14
            // 
            this.trackBar14.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar14.Location = new System.Drawing.Point(7, 190);
            this.trackBar14.Name = "trackBar14";
            this.trackBar14.Size = new System.Drawing.Size(67, 45);
            this.trackBar14.TabIndex = 202;
            this.trackBar14.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar14.Scroll += new System.EventHandler(this.trackBar14_Scroll);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label15.Location = new System.Drawing.Point(3, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 205;
            this.label15.Text = "REV DIFFUSE";
            // 
            // trackBar3
            // 
            this.trackBar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.trackBar3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar3.Location = new System.Drawing.Point(3, 57);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(67, 45);
            this.trackBar3.TabIndex = 199;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Teal;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button13.Location = new System.Drawing.Point(356, 31);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 229;
            this.button13.Text = "Auto Note";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // GroupBox9
            // 
            this.GroupBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.GroupBox9.Controls.Add(this.progressBar1);
            this.GroupBox9.Controls.Add(this.button18);
            this.GroupBox9.Controls.Add(this.button17);
            this.GroupBox9.Controls.Add(this.button16);
            this.GroupBox9.Controls.Add(this.button15);
            this.GroupBox9.Controls.Add(this.button14);
            this.GroupBox9.Controls.Add(this.button12);
            this.GroupBox9.Controls.Add(this.label56);
            this.GroupBox9.Controls.Add(this.label57);
            this.GroupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GroupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(158)))), ((int)(((byte)(215)))));
            this.GroupBox9.Location = new System.Drawing.Point(782, 476);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new System.Drawing.Size(212, 156);
            this.GroupBox9.TabIndex = 230;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "Sound";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.progressBar1.Location = new System.Drawing.Point(7, 91);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(75, 13);
            this.progressBar1.TabIndex = 236;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Teal;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button18.Location = new System.Drawing.Point(87, 123);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 216;
            this.button18.Text = "Clear Text";
            this.button18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Teal;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button17.Location = new System.Drawing.Point(87, 91);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 215;
            this.button17.Text = "TEST ";
            this.button17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Teal;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button16.Location = new System.Drawing.Point(6, 25);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 214;
            this.button16.Text = "Init Sound";
            this.button16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Teal;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button15.Location = new System.Drawing.Point(6, 58);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 213;
            this.button15.Text = "OpenSound";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Teal;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button14.Location = new System.Drawing.Point(87, 25);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 212;
            this.button14.Text = "SaveSound";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.groupBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.groupBox11.Controls.Add(this.pianoControl1);
            this.groupBox11.Controls.Add(this.button2);
            this.groupBox11.Controls.Add(this.button3);
            this.groupBox11.Controls.Add(this.button4);
            this.groupBox11.Controls.Add(this.button5);
            this.groupBox11.Controls.Add(this.button6);
            this.groupBox11.Controls.Add(this.button7);
            this.groupBox11.Controls.Add(this.button8);
            this.groupBox11.Controls.Add(this.button9);
            this.groupBox11.Controls.Add(this.button10);
            this.groupBox11.Controls.Add(this.button11);
            this.groupBox11.Location = new System.Drawing.Point(9, 495);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(467, 138);
            this.groupBox11.TabIndex = 231;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "OP";
            this.groupBox11.Enter += new System.EventHandler(this.groupBox11_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(9, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 187);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(185, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 232;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(160, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 233;
            this.label2.Text = "IN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(320, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 234;
            this.label3.Text = "OUT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(680, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 235;
            this.label4.Text = "PARAMETERS:";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.trackBar14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.trackBar62);
            this.panel1.Controls.Add(this.label68);
            this.panel1.Controls.Add(this.trackBar61);
            this.panel1.Controls.Add(this.label67);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.trackBar24);
            this.panel1.Controls.Add(this.trackBar54);
            this.panel1.Controls.Add(this.label54);
            this.panel1.Controls.Add(this.trackBar55);
            this.panel1.Controls.Add(this.label55);
            this.panel1.Location = new System.Drawing.Point(582, 255);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 218);
            this.panel1.TabIndex = 236;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label26.Location = new System.Drawing.Point(3, 331);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(42, 13);
            this.label26.TabIndex = 245;
            this.label26.Text = "FREQ2";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label25.Location = new System.Drawing.Point(3, 367);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 13);
            this.label25.TabIndex = 247;
            this.label25.Text = "Q2";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // trackBar22
            // 
            this.trackBar22.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar22.Location = new System.Drawing.Point(3, 344);
            this.trackBar22.Name = "trackBar22";
            this.trackBar22.Size = new System.Drawing.Size(67, 45);
            this.trackBar22.TabIndex = 246;
            this.trackBar22.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar22.Scroll += new System.EventHandler(this.trackBar22_Scroll);
            // 
            // trackBar20
            // 
            this.trackBar20.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar20.Location = new System.Drawing.Point(3, 380);
            this.trackBar20.Name = "trackBar20";
            this.trackBar20.Size = new System.Drawing.Size(67, 45);
            this.trackBar20.TabIndex = 248;
            this.trackBar20.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar20.Scroll += new System.EventHandler(this.trackBar20_Scroll);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label17.Location = new System.Drawing.Point(1, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 238;
            this.label17.Text = "DELAYTIME1";
            // 
            // trackBar15
            // 
            this.trackBar15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.trackBar15.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar15.Location = new System.Drawing.Point(3, 94);
            this.trackBar15.Name = "trackBar15";
            this.trackBar15.Size = new System.Drawing.Size(67, 45);
            this.trackBar15.TabIndex = 237;
            this.trackBar15.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar15.Scroll += new System.EventHandler(this.trackBar15_Scroll);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label18.Location = new System.Drawing.Point(1, 121);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 240;
            this.label18.Text = "DELAYTIME2";
            // 
            // trackBar16
            // 
            this.trackBar16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.trackBar16.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar16.Location = new System.Drawing.Point(3, 133);
            this.trackBar16.Name = "trackBar16";
            this.trackBar16.Size = new System.Drawing.Size(67, 45);
            this.trackBar16.TabIndex = 239;
            this.trackBar16.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar16.Scroll += new System.EventHandler(this.trackBar16_Scroll);
            // 
            // trackBar18
            // 
            this.trackBar18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.trackBar18.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar18.Location = new System.Drawing.Point(3, 274);
            this.trackBar18.Name = "trackBar18";
            this.trackBar18.Size = new System.Drawing.Size(67, 45);
            this.trackBar18.TabIndex = 242;
            this.trackBar18.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar18.Scroll += new System.EventHandler(this.trackBar18_Scroll);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label20.Location = new System.Drawing.Point(1, 262);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 241;
            this.label20.Text = "FREQ\'";
            // 
            // trackBar19
            // 
            this.trackBar19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.trackBar19.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBar19.Location = new System.Drawing.Point(3, 309);
            this.trackBar19.Name = "trackBar19";
            this.trackBar19.Size = new System.Drawing.Size(67, 45);
            this.trackBar19.TabIndex = 244;
            this.trackBar19.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar19.Scroll += new System.EventHandler(this.trackBar19_Scroll);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.label22.Location = new System.Drawing.Point(1, 297);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 13);
            this.label22.TabIndex = 243;
            this.label22.Text = "Q";
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Teal;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button20.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button20.Location = new System.Drawing.Point(5, 31);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(40, 21);
            this.button20.TabIndex = 214;
            this.button20.Text = "op-";
            this.button20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Teal;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button21.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button21.Location = new System.Drawing.Point(47, 6);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(40, 21);
            this.button21.TabIndex = 249;
            this.button21.Text = "P+";
            this.button21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Teal;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button22.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button22.Location = new System.Drawing.Point(47, 61);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(40, 21);
            this.button22.TabIndex = 250;
            this.button22.Text = "P-";
            this.button22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Teal;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button23.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button23.Location = new System.Drawing.Point(89, 33);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(40, 21);
            this.button23.TabIndex = 251;
            this.button23.Text = "op+";
            this.button23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Teal;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button24.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button24.Location = new System.Drawing.Point(411, 10);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(40, 21);
            this.button24.TabIndex = 252;
            this.button24.Text = "+";
            this.button24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Teal;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button25.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button25.Location = new System.Drawing.Point(411, 61);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(40, 21);
            this.button25.TabIndex = 253;
            this.button25.Text = "-";
            this.button25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.button25);
            this.panel2.Controls.Add(this.button21);
            this.panel2.Controls.Add(this.button24);
            this.panel2.Controls.Add(this.button22);
            this.panel2.Controls.Add(this.button23);
            this.panel2.Location = new System.Drawing.Point(10, 398);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 92);
            this.panel2.TabIndex = 254;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Location = new System.Drawing.Point(145, 10);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(247, 72);
            this.panel6.TabIndex = 254;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(158)))), ((int)(((byte)(127)))));
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Location = new System.Drawing.Point(10, 9);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 54);
            this.panel3.TabIndex = 254;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Perpetua Titling MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(69)))), ((int)(((byte)(57)))));
            this.label29.Location = new System.Drawing.Point(10, 25);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(211, 27);
            this.label29.TabIndex = 1;
            this.label29.Text = "Algorithm: 005";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Perpetua Titling MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(69)))), ((int)(((byte)(57)))));
            this.label28.Location = new System.Drawing.Point(10, 0);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(179, 27);
            this.label28.TabIndex = 0;
            this.label28.Text = "P7: Sine Wave";
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Teal;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button26.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button26.Location = new System.Drawing.Point(3, 23);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(38, 23);
            this.button26.TabIndex = 255;
            this.button26.Text = "PEQ";
            this.button26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Teal;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button27.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button27.Location = new System.Drawing.Point(46, 23);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(38, 23);
            this.button27.TabIndex = 256;
            this.button27.Text = "DLEQ";
            this.button27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Teal;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button28.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button28.Location = new System.Drawing.Point(3, 58);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(38, 23);
            this.button28.TabIndex = 257;
            this.button28.Text = "HQ";
            this.button28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.Teal;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button29.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button29.Location = new System.Drawing.Point(46, 58);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(38, 23);
            this.button29.TabIndex = 258;
            this.button29.Text = "LIM";
            this.button29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.Teal;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button30.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button30.Location = new System.Drawing.Point(3, 87);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(38, 23);
            this.button30.TabIndex = 259;
            this.button30.Text = "PEQ";
            this.button30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.Teal;
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button31.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button31.Location = new System.Drawing.Point(45, 87);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(38, 23);
            this.button31.TabIndex = 260;
            this.button31.Text = "DLEQ";
            this.button31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.Teal;
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button32.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button32.Location = new System.Drawing.Point(3, 122);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(38, 23);
            this.button32.TabIndex = 261;
            this.button32.Text = "HQ";
            this.button32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.Teal;
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button33.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button33.Location = new System.Drawing.Point(45, 122);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(38, 23);
            this.button33.TabIndex = 262;
            this.button33.Text = "LIM";
            this.button33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label30);
            this.panel4.Controls.Add(this.button26);
            this.panel4.Controls.Add(this.button33);
            this.panel4.Controls.Add(this.button31);
            this.panel4.Controls.Add(this.button27);
            this.panel4.Controls.Add(this.button32);
            this.panel4.Controls.Add(this.button30);
            this.panel4.Controls.Add(this.button28);
            this.panel4.Controls.Add(this.button29);
            this.panel4.Location = new System.Drawing.Point(582, 476);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(93, 157);
            this.panel4.TabIndex = 263;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(158)))), ((int)(((byte)(215)))));
            this.label30.Location = new System.Drawing.Point(3, 5);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(75, 13);
            this.label30.TabIndex = 263;
            this.label30.Text = "EFFECT ON";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel5.Controls.Add(this.trackBar20);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.trackBar22);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.trackBar19);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.trackBar18);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.trackBar85);
            this.panel5.Controls.Add(this.label87);
            this.panel5.Controls.Add(this.trackBar84);
            this.panel5.Controls.Add(this.label86);
            this.panel5.Controls.Add(this.trackBar86);
            this.panel5.Controls.Add(this.label88);
            this.panel5.Controls.Add(this.label89);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.trackBar16);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.trackBar15);
            this.panel5.Controls.Add(this.trackBar3);
            this.panel5.Controls.Add(this.trackBar87);
            this.panel5.Location = new System.Drawing.Point(485, 203);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(92, 430);
            this.panel5.TabIndex = 264;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1039, 676);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.GroupBox9);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.panel5);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ESP32FM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar19)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button continueButton;
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
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TrackBar trackBar15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar trackBar16;
        private System.Windows.Forms.TrackBar trackBar17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TrackBar trackBar18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TrackBar trackBar19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TrackBar trackBar20;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TrackBar trackBar22;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.TrackBar trackBar25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label30;
    }
}

