using System;
using System.ComponentModel;
using System.Windows.Forms;
using Sanford.Multimedia.Midi;
using Sanford.Multimedia.Midi.UI;
using Sanford.Multimedia;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;

namespace SequencerDemo
{
    public partial class Form1 : Form
    {
        int op1al;
        int op1ar;
        int op1d1l;
        int op1d1r;
        int op1d2l;
        int op1d2r;
        int op1rl;
        int op1rr;
        int op3ar;
        int op3al;
        int op3d1l;
        int op3d1r;
        int op2d1r;
        int op2d1l;
        int op2ar;
        int op2al;
        int op2d2r;
        int op2d2l;
        int op2rl;
        int op2rr;
        int pichkezd;
        int pichal;
        int pichar;
        int pichd1l;
        int pichd1r;
        int pichd2l;
        int pichd2r;
        int pichrl;
        int pichrr;
        int pichvolume;
        int opmenu = 1;
        int opmenulast;
        int op1notefixed;
        int op2notefixed;
        int op3notefixed;
        int op4notefixed;
        int op5notefixed;
        int op6notefixed;
        int op1waveform;
        int op2waveform;
        int op3waveform;
        int op4waveform;
        int op5waveform;
        int op6waveform;
        int op1generatorfreq;
        int op2generatorfreq;
        int op3generatorfreq;
        int op4generatorfreq;
        int op5generatorfreq;
        int op6generatorfreq;
        int op1generatorfreqfix;
        int op2generatorfreqfix;
        int op3generatorfreqfix;
        int op4generatorfreqfix;
        int op5generatorfreqfix;
        int op6generatorfreqfix;
        int op1volume;
        int op2volume;
        int op3volume;
        int op4volume;
        int op5volume;
        int op6volume;
        int op1volumelast;
        int op2volumelast;
        int op3volumelast;
        int op4volumelast;
        int op5volumelast;
        int op6volumelast;
        int op3d2l;
        int op3d2r;
        int op3rl;
        int op3rr;
        int op4al;
        int op4ar;
        int op4d1l;
        int op4d1r;
        int op4d2l;
        int op4d2r;
        int op4rl;
        int op4rr;
        int op5al;
        int op5ar;
        int op5d1l;
        int op5d1r;
        int op5d2l;
        int op5d2r;
        int op5rl;
        int op5rr;
        int op6ar;
        int op6d1l;
        int op6d1r;
        int op6d2l;
        int op6d2r;
        int op6rl;
        int op6rr;
        int op6al;
        int reverblevel=1;
        int reverbdiffuse=1;
        int choruslevel=1;
        int chorusfreq=1;
        int feedbacklevel=1;
        int level;
        int op1lep=22;
        int op2lep=22;
        int op3lep=22;
        int op4lep=22;
        int op5lep=22;
        int op6lep=22;
        int algorithm;
        int op1pich;
        int op2pich;
        int op3pich;
        int op4pich;
        int op5pich;
        int op6pich;
        int oplevel;
        int op1detune;
        int op2detune;
        int op3detune;
        int op4detune;
        int op5detune;
        int op6detune;
        int modulation;
        int lfo2freq;
        int lfo2volume;
        int szorzo;
        int frame = 7;
        int timemax = 330;
        int limitgain;
        int reverbtime;
        int ofset;
        int maxrelease = 100;
        int maxtime = 150;

        private bool scrolling = false;

        private bool playing = false;

        private bool closing = false;

        private OutputDevice outDevice;
        private InputDevice inDevice;

        public int outDeviceID=0;
        public int inDeviceID = 0;

        private OutputDeviceDialog outDialog = new OutputDeviceDialog();
        private SynchronizationContext context;

        //Point panelposition = new Point(600, 0);
        //Point panelposition2 = new Point(700, 0);
        //Point panelposition3 = new Point(800, 0);
        public Form1()
        {
            InitializeComponent();
            trackbarminmax();
            this.Size = new Size(1024, 700);
            for (int i = 0; i < Sanford.Multimedia.Midi.OutputDevice.DeviceCount; i++)
            {
                comboBox1.Items.Add(Sanford.Multimedia.Midi.OutputDevice.GetDeviceCapabilities(i).name);
            }
            for (int i = 0; i < Sanford.Multimedia.Midi.InputDevice.DeviceCount; i++)
            {
                comboBox2.Items.Add(Sanford.Multimedia.Midi.InputDevice.GetDeviceCapabilities(i).name);
            }
            StreamReader sr = new StreamReader("defaultout.ini");
            outDeviceID = Convert.ToInt32(sr.ReadLine());
            sr.Close();
            StreamReader sr2 = new StreamReader("condition_temp.due");
            richTextBox2.Text = sr2.ReadToEnd();


       
            sr2.Close();

            // groupBox1.Location = panelposition;    
            // groupBox8.Location = panelposition2;

            // richTextBox2.Location= panelposition3;
            //  richTextBox2.Width = 150;
            groupBox1.Show();
            groupBox8.Show();
            //initvariable();
        }

        protected override void OnLoad(EventArgs e)
        {
            if(OutputDevice.DeviceCount == 0)
            {
                MessageBox.Show("No MIDI output devices available.", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

                Close();
            }
            else
            {
                try
                {
                   
                    outDevice = new OutputDevice(outDeviceID);
                 //   InputDevice inDevice = new InputDevice(0);

                    sequence1.LoadProgressChanged += HandleLoadProgressChanged;
                    sequence1.LoadCompleted += HandleLoadCompleted;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    Close();
                }
            }
            
            
            if (InputDevice.DeviceCount == 0)
            {
                MessageBox.Show("No MIDI input devices available.", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Close();
            }
            else
            {
                try
                {
                    context = SynchronizationContext.Current;
                    inDevice = new InputDevice(inDeviceID);
                    label56.Text = inDeviceID.ToString();
                    inDevice.ChannelMessageReceived += HandleChannelMessageReceived;
                    inDevice.SysCommonMessageReceived += HandleSysCommonMessageReceived;
                   // inDevice.SysExMessageReceived += HandleSysExMessageReceived;
                   // inDevice.SysRealtimeMessageReceived += HandleSysRealtimeMessageReceived;
                  //  inDevice.Error += new EventHandler<ErrorEventArgs>(inDevice_Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Close();
                }
            }

            base.OnLoad(e);
        }


       




        private void HandleChannelMessageReceived(object sender, ChannelMessageEventArgs e)
        {
            context.Post(delegate (object dummy)
            {

                richTextBox2.Text += e.Message.Command.ToString() + '\t' + '\t' +
                    e.Message.MidiChannel.ToString() + '\t' +
                    e.Message.Data1.ToString() + '\t' +
                    e.Message.Data2.ToString(); 
                /*
                .Items.Add(
                    e.Message.Command.ToString() + '\t' + '\t' +
                    e.Message.MidiChannel.ToString() + '\t' +
                    e.Message.Data1.ToString() + '\t' +
                    e.Message.Data2.ToString());

                channelListBox.SelectedIndex = channelListBox.Items.Count - 1;
                */
            }, null);
        }

        private void HandleSysCommonMessageReceived(object sender, SysCommonMessageEventArgs e)
        {
            context.Post(delegate (object dummy)
            {
            richTextBox2.Text +=
               e.Message.SysCommonType.ToString() + '\t' + '\t' +
                    e.Message.Data1.ToString() + '\t' +
                    e.Message.Data2.ToString();

                
            }, null);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            pianoControl1.PressPianoKey(e.KeyCode);
            

            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            pianoControl1.ReleasePianoKey(e.KeyCode);

            base.OnKeyUp(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            closing = true;

            base.OnClosing(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            sequence1.Dispose();

            if(outDevice != null)
            {
                outDevice.Dispose();
            }

            outDialog.Dispose();
            if (inDevice != null)
            {
                inDevice.Close();
            }

            base.OnClosed(e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openMidiFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openMidiFileDialog.FileName;

                try
                {
                    sequencer1.Stop();
                    playing = false;
                    sequence1.LoadAsync(fileName);
                    this.Cursor = Cursors.WaitCursor;
                    startButton.Enabled = false;
                    continueButton.Enabled = false;
                    stopButton.Enabled = false;
                    openToolStripMenuItem.Enabled = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }                
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void outputDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outDeviceID = 0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog dlg = new AboutDialog();

            dlg.ShowDialog();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            try
            {
                playing = false;
                sequencer1.Stop();
                timer1.Stop();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }   

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                playing = true;
                sequencer1.Start();
                timer1.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
      
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                playing = true;
                sequencer1.Continue();
                timer1.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void positionHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if(e.Type == ScrollEventType.EndScroll)
            {
              //  sequencer1.Position = e.NewValue;
                sequencer1.Start();
                sequencer1.Position = 0;
               // scrolling = false;
            }
            else
            {
                scrolling = true;
            }
        }

        private void HandleLoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void HandleLoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            startButton.Enabled = true;
            continueButton.Enabled = true;
            stopButton.Enabled = true;
            openToolStripMenuItem.Enabled = true;
            toolStripProgressBar1.Value = 0;

            if(e.Error == null)
            {
                positionHScrollBar.Value = 0;
                positionHScrollBar.Maximum = sequence1.GetLength();
            }
            else
            {
                MessageBox.Show(e.Error.Message);
            }
        }

        private void HandleChannelMessagePlayed(object sender, ChannelMessageEventArgs e)
        {
            if(closing)
            {
                return;
            }

            outDevice.Send(e.Message);
            pianoControl1.Send(e.Message);
        }

        private void HandleChased(object sender, ChasedEventArgs e)
        {
            foreach(ChannelMessage message in e.Messages)
            {
                outDevice.Send(message);
            }
        }

        private void HandleSysExMessagePlayed(object sender, SysExMessageEventArgs e)
        {
       //     outDevice.Send(e.Message); Sometimes causes an exception to be thrown because the output device is overloaded.
        }

        private void HandleStopped(object sender, StoppedEventArgs e)
        {
            foreach(ChannelMessage message in e.Messages)
            {
                outDevice.Send(message);
                pianoControl1.Send(message);
            }
        }

        private void HandlePlayingCompleted(object sender, EventArgs e)
        {
            timer1.Stop();
        }
      int  timer2ido=0;
        private void pianoControl1_PianoKeyDown(object sender, PianoKeyEventArgs e)
        {
            #region Guard

            if(playing)
            {
                return;
            }

            #endregion

            outDevice.Send(new ChannelMessage(ChannelCommand.NoteOn, 0, e.NoteID, 127));
            timer2.Interval = frame/4;
            timer2.Start();
            timer2ido = 0;
            
        }

        private void pianoControl1_PianoKeyUp(object sender, PianoKeyEventArgs e)
        {
            #region Guard

            if(playing)
            {
                return;
            }

            #endregion

            outDevice.Send(new ChannelMessage(ChannelCommand.NoteOff, 0, e.NoteID, 0));
            timer2ido = maxrelease+1;
        }
        
        
        int lfo1value = 22;
        int lfo1min = 20;
        int lfo1max = 23;
        int lfo1irany = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
          /*
            if(!scrolling)
            {
                positionHScrollBar.Value = sequencer1.Position;
            }
          */
            if (autonote){
                if (lfo1irany == 1) {
                    if (lfo1value<lfo1max)
                    {
                        lfo1value++;
                    }
                    else
                    {
                        lfo1irany = 0;
                    }
                }
                else
                {
                    if (lfo1value > lfo1min)
                    {
                        lfo1value--;
                    }
                    else
                    {
                        lfo1irany = 1;
                    }

                }
               int value = (lfo1value - 13) * 8;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 82, value));
               
            }
        }

        private void pianoControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Waveform
           
            int value = trackBar1.Value;
            variableset("waveform", value);          
            label56.Text = value + " ";
        
        }

        private void trackBar23_Scroll(object sender, EventArgs e)
        {
            // opgeneratorfreq
         
            int value = trackBar23.Value;
            variableset("generatorfreq", value);
          //  outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 44,value));
            label56.Text = value + " ";      
        }

        private void trackBar24_Scroll(object sender, EventArgs e)
        {
            // level

            int value = trackBar24.Value;
            variableset("level", value);
           // outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 71, value));
            label56.Text = value + " ";
        }

        private void trackBar31_Scroll(object sender, EventArgs e)
        {
            
            //modulation

            int value = trackBar31.Value;
            variableset("modulation", value);
            label56.Text = value + " ";

        }

        private void trackBar32_Scroll(object sender, EventArgs e)
        {
            // PICHKEZD
            
            int value = trackBar32.Value;
            variableset("pichkezd",value);
            label56.Text = value + " ";
           
        }

        private void trackBar33_Scroll(object sender, EventArgs e)
        {
            //lfovolume

            int value = trackBar33.Value;
            variableset("lfo2volume", value);
            label56.Text = value + " ";

        }

        private void trackBar34_Scroll(object sender, EventArgs e)
        {          
        }

        private void trackBar35_Scroll(object sender, EventArgs e)
        {            
        }

        private void trackBar36_Scroll(object sender, EventArgs e)
        {
           
        }

        private void trackBar37_Scroll(object sender, EventArgs e)
        {
            // lep       
            int value = trackBar37.Value;
            variableset("lep", value);
            label56.Text = value + " ";
            
        }

        private void trackBar38_Scroll(object sender, EventArgs e)
        {
            // detune       
            int value = trackBar38.Value;
            variableset("detune", value);
            label56.Text = value + " ";

        }

        private void trackBar39_Scroll(object sender, EventArgs e)
        {          
        }

        private void trackBar40_Scroll(object sender, EventArgs e)
        {          
        }

        private void trackBar51_Scroll(object sender, EventArgs e)
        {
            // tune div       
            int value = trackBar51.Value;
            variableset("szorzo", value);
            label56.Text = value + " ";
        }

        private void trackBar54_Scroll(object sender, EventArgs e)
        {
            //oplevel

            int value = trackBar54.Value;
            variableset("oplevel", value);
            label56.Text = value + " ";
        }

        private void trackBar55_Scroll(object sender, EventArgs e)
        {
            //feedbacklevel

            int value = trackBar55.Value;
            variableset("feedbacklevel",value);           
            label56.Text = value + " ";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            outDeviceID = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            { 
                outDeviceID = 0;
                outDevice = new OutputDevice(outDeviceID);
                
            }

            if (comboBox1.SelectedIndex == 1) {
                outDeviceID = 1;        
                outDevice = new OutputDevice(outDeviceID);
                label56.Text = Sanford.Multimedia.Midi.OutputDevice.DeviceCount+"";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                outDeviceID = 2;
          
                outDevice = new OutputDevice(outDeviceID);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                outDeviceID = 3;
                outDevice = new OutputDevice(outDeviceID);
            }
            StreamWriter sw = new StreamWriter("defaultout.ini");
            sw.WriteLine(outDeviceID);
            sw.Close();

        }

        private void trackBar56_Scroll(object sender, EventArgs e)
        {
          
        }

        private void trackBar57_Scroll(object sender, EventArgs e)
        {
            //pichop     
            int value = trackBar57.Value;
            variableset("pich", value);            
            label56.Text = value + " ";
            String szoveg = richTextBox2.Text;
        }

        private void trackBar58_Scroll(object sender, EventArgs e)
        {
         
        }

        private void trackBar59_Scroll(object sender, EventArgs e)
        {
           
        }
        void parametersetfull()
        {
            string[] sor = richTextBox2.Text.Split('\n');
            for (int i = 0; i < sor.Length - 1; i++)
            {
                string[] darabok = sor[i].Split('=');
                string variablename = darabok[0].Trim();
                int value = Convert.ToInt32(darabok[1].Substring(0, darabok[1].Length - 1).Trim());
             //   parameterset(variablename, value);
            }
        }

        void initvariable() {
            string[] sor = richTextBox2.Text.Split('\n');
            StreamWriter sw = new StreamWriter("lastopen.log");
            for (int i = 0; i < sor.Length-1; i++)
            {
                
                progressBar1.Maximum = sor.Length;
                progressBar1.Value = i;
                string[] darabok = sor[i].Split('=');
                string variablename = darabok[0].Trim();
                int value =Convert.ToInt32( darabok[1].Substring(0,darabok[1].Length-1).Trim());
                // label56.Text = variablename+"#"+value+"#";
                if (variablename.Contains("op1"))
                { outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 54));
                    opmenu = 1;
                }
                if (variablename.Contains("op2"))
                { outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 55));
                    opmenu = 2;
                }
                if (variablename.Contains("op3"))
                { outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 56));
                    opmenu = 3;
                }
                if (variablename.Contains("op4"))
                { outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 57));
                    opmenu = 4;
                }
                if (variablename.Contains("op5"))
                { outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 58));
                    opmenu = 5;
                }
                if (variablename.Contains("op6"))
                { outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 59));
                    opmenu = 6;
                }
                if (variablename.Contains("pich")&& !variablename.Contains("op"))
                {
                    opmenu = 7;
                    outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 54));
                    Thread.Sleep(10);
                    outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 53));
                }
                Thread.Sleep(10);
                try
                {
                    sw.WriteLine(variablename + "=" + value+" (op"+opmenu+")");
                    parameterset(variablename, value);
                }
                catch (Exception e){
                    MessageBox.Show("A hiba a fájl"+i+"sorában!");
                    throw;
                }
                Thread.Sleep(10);
            }
            sw.Close();
            initglobaltrackbar();
            maxreleaseset();
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            }

        private void trackBar60_Scroll(object sender, EventArgs e)
        {
            //generatorfreqfix
          
            int value = trackBar60.Value;
            variableset("generatorfreqfix", value);           
            label56.Text = value + " ";
           
        }

        private void trackBar61_Scroll(object sender, EventArgs e)
        {
            //frame
            int value = trackBar61.Value;
            variableset("frame", value);
            label56.Text = value + " ";
        }

        private void trackBar62_Scroll(object sender, EventArgs e)
        {
            //Algorithm
            int value = trackBar62.Value;
            variableset("algorithm", value);          
            label56.Text = trackBar62.Value + " ";
  
            
        }

        private void trackBar63_Scroll(object sender, EventArgs e)
        {
            //Level
       /*
            int value = trackBar63.Value;
            variableset("level", value);
            label56.Text = value + " ";     
       */
        }

        private void trackBar84_Scroll(object sender, EventArgs e)
        {
            //chorusfreq
           
            int value = trackBar84.Value;
            variableset("chorusfreq", value);           
            label56.Text = value + " ";            
        }

        private void trackBar85_Scroll(object sender, EventArgs e)
        {
            //Reverb diffuse
          
            int value = trackBar85.Value;
            variableset("reverbdiffuse", value);          
            label56.Text = value.ToString();
            
        }

        private void trackBar86_Scroll(object sender, EventArgs e)
        {
            //Choruslevel
          
            int value = trackBar86.Value;
            variableset("choruslevel", value);         
            label56.Text = value+ " ";        
        }

        private void trackBar87_Scroll(object sender, EventArgs e)
        {
            //Reverblevel
           
            int value = trackBar87.Value;
            variableset("reverblevel", value);           
            label56.Text = value + " ";
            
        }
 
        private void trackBar82_Scroll(object sender, EventArgs e)
        {
           
        }

        private void trackBar83_Scroll(object sender, EventArgs e)
        {
            //pichzaj2
        }

        int prog;
        private void button2_Click(object sender, EventArgs e)
        {
            prog = 0;
            outDevice.Send(new ChannelMessage(ChannelCommand.ProgramChange,0,prog));
            label93.Text = prog + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prog = 1;
            outDevice.Send(new ChannelMessage(ChannelCommand.ProgramChange, 0, prog));
            label93.Text = prog + "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            prog = 2;
            outDevice.Send(new ChannelMessage(ChannelCommand.ProgramChange, 0, prog));
            label93.Text = prog + "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            prog = 3;
            outDevice.Send(new ChannelMessage(ChannelCommand.ProgramChange, 0, prog));
            label93.Text = prog + "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            prog = 4;
            outDevice.Send(new ChannelMessage(ChannelCommand.ProgramChange, 0, prog));
            label93.Text = prog + "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            prog = 5;
            outDevice.Send(new ChannelMessage(ChannelCommand.ProgramChange, 0, prog));
            label93.Text = prog + "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            prog = 6;
            outDevice.Send(new ChannelMessage(ChannelCommand.ProgramChange, 0, prog));
            label93.Text = prog + "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            prog = 7;
            outDevice.Send(new ChannelMessage(ChannelCommand.ProgramChange, 0, prog));
            label93.Text = prog + "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            prog = 8;
            outDevice.Send(new ChannelMessage(ChannelCommand.ProgramChange, 0, prog));
            label93.Text = prog + "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            prog = 9;
            outDevice.Send(new ChannelMessage(ChannelCommand.ProgramChange, 0, prog));
            label93.Text = prog + "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            outDevice.Send(new ChannelMessage(ChannelCommand.PolyPressure, 0, 124,0));
        }


        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            opmenu = 1;
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 54));
           
            trackBar21.Value = op1volume;
            groupBox1.Text =  "OP"+ opmenu;
            groupBox7.Text = "OP" + opmenu;
            groupBox1.ForeColor = Color.White;
            groupBox1.BackColor = Color.Green;
            groupBox7.ForeColor = Color.White;
            groupBox7.BackColor = Color.Green;
            trackBar1.Value = op1waveform;
            trackBar21.Value = op1volume;
            trackBar23.Value =op1generatorfreq;
            trackBar60.Value = op1generatorfreqfix;
            trackBar5.Value = op1al;
            trackBar6.Value = op1ar;
            trackBar7.Value = op1d1l;
            trackBar8.Value = op1d1r;
            trackBar9.Value = op1d2l;
            trackBar10.Value = op1d2r;
            trackBar11.Value = op1rl;
            trackBar12.Value = op1rr;
            trackBar37.Value = op1lep;
            trackBar57.Value = op1pich;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
       
            opmenu = 2;
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 55));
          
            groupBox1.Text = "OP" + opmenu;
            groupBox7.Text = "OP" + opmenu;
            groupBox1.ForeColor = Color.White;
            groupBox1.BackColor = Color.Crimson;
            groupBox7.ForeColor = Color.White;
            groupBox7.BackColor = Color.Crimson;

            trackBar1.Value = op2waveform;
            trackBar21.Value = op2volume;
            trackBar23.Value = op2generatorfreq;
            trackBar60.Value = op2generatorfreqfix;
            trackBar5.Value = op2al;
            trackBar6.Value = op2ar;
            trackBar7.Value = op2d1l;
            trackBar8.Value = op2d1r;
            trackBar9.Value = op2d2l;
            trackBar10.Value = op2d2r;
            trackBar11.Value = op2rl;
            trackBar12.Value = op2rr;
            trackBar37.Value = op2lep;
            trackBar57.Value = op2pich;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
          
            opmenu = 3;
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 56));
           
            groupBox1.Text = "OP" + opmenu;
            groupBox7.Text = "OP" + opmenu;
            groupBox1.ForeColor = Color.White;
            groupBox1.BackColor = Color.Purple;
            groupBox7.ForeColor = Color.White;
            groupBox7.BackColor = Color.Purple;
            trackBar1.Value = op3waveform;
            trackBar21.Value = op3volume;
            trackBar23.Value = op3generatorfreq;
            trackBar60.Value = op3generatorfreqfix;
            trackBar5.Value = op3al;
            trackBar6.Value = op3ar;
            trackBar7.Value = op3d1l;
            trackBar8.Value = op3d1r;
            trackBar9.Value = op3d2l;
            trackBar10.Value = op3d2r;
            trackBar11.Value = op3rl;
            trackBar12.Value = op3rr;
            trackBar37.Value = op3lep;
            trackBar57.Value = op3pich;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
            opmenu = 4;
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 57));
        
            groupBox1.Text = "OP" + opmenu;
            groupBox7.Text = "OP" + opmenu;
            groupBox1.BackColor = Color.Goldenrod;
            groupBox1.ForeColor = Color.White;
            groupBox7.BackColor = Color.Goldenrod;
            groupBox7.ForeColor = Color.White;
            trackBar1.Value = op4waveform;
            trackBar21.Value = op4volume;
            trackBar23.Value = op4generatorfreq;
            trackBar60.Value = op4generatorfreqfix;
            trackBar5.Value = op4al;
            trackBar6.Value = op4ar;
            trackBar7.Value = op4d1l;
            trackBar8.Value = op4d1r;
            trackBar9.Value = op4d2l;
            trackBar10.Value = op4d2r;
            trackBar11.Value = op4rl;
            trackBar12.Value = op4rr;
            trackBar37.Value = op4lep;
            trackBar57.Value = op4pich;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
           
            opmenu = 5;
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 58));
         
            groupBox1.Text = "OP" + opmenu;
            groupBox7.Text = "OP" + opmenu;
            groupBox1.BackColor = Color.OrangeRed;          
            groupBox1.ForeColor = Color.White;
            groupBox7.BackColor = Color.OrangeRed;
            groupBox7.ForeColor = Color.White;
            trackBar1.Value = op5waveform;
            trackBar21.Value = op5volume;
            trackBar23.Value = op5generatorfreq;
            trackBar60.Value = op5generatorfreqfix;
            trackBar5.Value = op5al;
            trackBar6.Value = op5ar;
            trackBar7.Value = op5d1l;
            trackBar8.Value = op5d1r;
            trackBar9.Value = op5d2l;
            trackBar10.Value = op5d2r;
            trackBar11.Value = op5rl;
            trackBar12.Value = op5rr;
            trackBar37.Value = op5lep;
            trackBar57.Value = op5pich;

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
          
            opmenu = 6;
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 59));
      
            groupBox1.Text = "OP" + opmenu;
            groupBox7.Text = "OP" + opmenu;
            groupBox1.BackColor = Color.Red;          
            groupBox7.ForeColor = Color.White;
            groupBox7.BackColor = Color.Red;
            groupBox1.ForeColor = Color.White;
            trackBar1.Value = op6waveform;
            trackBar21.Value = op6volume;
            trackBar23.Value = op6generatorfreq;
            trackBar60.Value = op6generatorfreqfix;
            trackBar5.Value = op6al;
            trackBar6.Value = op6ar;
            trackBar7.Value = op6d1l;
            trackBar8.Value = op6d1r;
            trackBar9.Value = op6d2l;
            trackBar10.Value = op6d2r;
            trackBar11.Value = op6rl;
            trackBar12.Value = op6rr;
            trackBar37.Value = op6lep;
            trackBar57.Value = op6pich;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
           
            opmenu = 7;
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 54));
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 53));
            groupBox1.Text = "PICH";
            groupBox1.BackColor = Color.HotPink;
            groupBox1.ForeColor = Color.White;
            groupBox7.BackColor = Color.HotPink;
            groupBox7.ForeColor = Color.White;
            groupBox7.Text = "PICH" + opmenu;                  
            trackBar5.Value = pichal;
            trackBar6.Value = pichar;
            trackBar7.Value = pichd1l;
            trackBar8.Value = pichd1r;
            trackBar9.Value = pichd2l;
            trackBar10.Value = pichd2r;
            trackBar11.Value = pichrl;
            trackBar12.Value = pichrr;
        }


      

        private void trackBar5_Scroll_1(object sender, EventArgs e)
        {
            // op1al!!!!!
        
            int value = trackBar5.Value;
            variableset("al", value);
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 108, value));
            label56.Text = value + " ";
        }


        private void trackBar6_Scroll_1(object sender, EventArgs e)
        {
            // AR!!!!
    
            int value = trackBar6.Value;
            variableset("ar", value);
          
            label56.Text = value + " ";               
        }
        
        private void trackBar7_Scroll_1(object sender, EventArgs e)
        {
            //D1L!!!!
         
            int value = trackBar7.Value;
            variableset("d1l", value);         
            
            label56.Text = value + " ";              
        }
      
        private void trackBar8_Scroll_1(object sender, EventArgs e)
        {
            // D1R!!!!
        
            int value = trackBar8.Value;
            variableset("d1r", value);
                  
            label56.Text = value + " ";         
        }
      
        private void trackBar9_Scroll_1(object sender, EventArgs e)
        {
            // D2L!!!
        
            int value = trackBar9.Value;
            variableset("d2l", value);
          
            label56.Text = value + " ";     
        }
       
        private void trackBar10_Scroll_1(object sender, EventArgs e)
        {
            // D2R!!!
       
            int value = trackBar10.Value;
            variableset("d2r", value);
          
            label56.Text = value + " ";         
        }
        
        private void trackBar11_Scroll_1(object sender, EventArgs e)
        {
            // RL!!!
           
            int value = trackBar11.Value;
            variableset("rl", value);
           
            label56.Text = value + " ";          
        }
        
        private void trackBar12_Scroll_1(object sender, EventArgs e)
        {
            // RR!!!!
           
            int value = trackBar12.Value;
            variableset("rr",value );           
           
            label56.Text = value + " ";       
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            //notfixed
            if (checkBox1.Checked)
            {
                int value = 1;
                variableset("notefixed", 1);
               
                label56.Text = "true";
            }
            else
            {
                
                variableset("notefixed", 0);
            
                label56.Text = "false";
            }
        }     
        
        private void trackBar21_Scroll_1(object sender, EventArgs e)
        {
            // opvolume           
            int value = trackBar21.Value;
            variableset("volume", value);
            label56.Text = value + " ";
            
        }

       





        Boolean autonote = false;
        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Interval=500;
            timer1.Start();
            
            if (autonote == false)
            {
                autonote = true;
            }
            else { autonote = false; }
        }

        private void button14_Click(object sender, EventArgs e)
        {       
            saveFileDialog1.ShowDialog();        
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {       
            String Filename = saveFileDialog1.FileName;
            //label56.Text = Filename;
            StreamWriter w = new StreamWriter(Filename, false, Encoding.Default);
            w.Write(richTextBox2.Text);
            w.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            String Filename = openFileDialog1.FileName;
            string [] splits= openFileDialog1.FileName.Split('\\');
            label4.Text = splits[splits.Length - 1].ToUpper(); 
            StreamReader r = new StreamReader(@Filename, Encoding.Default);
            richTextBox2.Text = r.ReadToEnd();
            r.Close();
        }

        private void label54_Click(object sender, EventArgs e)
        {
        }

        private void button15_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            initvariable();
            op1volumelast = op1volume;
            op2volumelast = op1volume;
            op3volumelast = op1volume;
            op4volumelast = op1volume;
            op5volumelast = op1volume;
            op6volumelast = op1volume;

        }

        private void button16_Click(object sender, EventArgs e)
        {
           
        }
        public void gorberajzol()
        {
            BufferedGraphicsContext currentContext;
            BufferedGraphics myBuffer;
            currentContext = BufferedGraphicsManager.Current;
            myBuffer = currentContext.Allocate(pictureBox1.CreateGraphics(), this.DisplayRectangle);
            myBuffer.Graphics.Clear(Color.Black);

           // Graphics g = pictureBox1.CreateGraphics();
            System.Drawing.SolidBrush b = new System.Drawing.SolidBrush(System.Drawing.Color.LightGreen);
            System.Drawing.SolidBrush b2 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            System.Drawing.SolidBrush b3 = new System.Drawing.SolidBrush(System.Drawing.Color.LightPink);
            System.Drawing.SolidBrush b4 = new System.Drawing.SolidBrush(System.Drawing.Color.Purple);
            System.Drawing.SolidBrush b5 = new System.Drawing.SolidBrush(System.Drawing.Color.Gold);
            System.Drawing.SolidBrush b6 = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.SolidBrush b7 = new System.Drawing.SolidBrush(System.Drawing.Color.Orange);
            System.Drawing.SolidBrush b8 = new System.Drawing.SolidBrush(System.Drawing.Color.Gray);
         
            Pen p = new Pen(b, 2);
            Pen p2 = new Pen(b2, 2);
            Pen p3 = new Pen(b3, 2);
            Pen p4 = new Pen(b4, 2);
            Pen p5 = new Pen(b5, 2);
            Pen p6 = new Pen(b6, 2);
            Pen p7 = new Pen(b7, 2);
            Pen p8 = new Pen(b8, 2);
            Font F = new Font(FontFamily.GenericMonospace, 12.0F,FontStyle.Italic, GraphicsUnit.Pixel);
            int vonalpont = pictureBox1.Height - 10;
            // g.DrawLine(p2, 1, vonalpont- op1al, pictureBox1.Width, vonalpont);
            //  g.DrawLine(p2, 1, vonalpont, pictureBox1.Width, vonalpont);
            myBuffer.Graphics.DrawLine(p, 1, vonalpont, 1 + op1ar, vonalpont - op1al);
            myBuffer.Graphics.DrawLine(p, 1 + op1ar, vonalpont - op1al, 1 + op1ar + op1d1r, vonalpont - op1d1l);
            myBuffer.Graphics.DrawLine(p, 1 + op1ar + op1d1r, vonalpont - op1d1l, 1 + op1ar + op1d1r + op1d2r, vonalpont - op1d2l);
            myBuffer.Graphics.DrawLine(p, 1 + op1ar + op1d1r + op1d2r, vonalpont - op1d2l, 1 + op1ar + op1d1r + op1d2r + op1rr, vonalpont - op1rl);
            myBuffer.Graphics.DrawString("op1", F, b,  op1ar, vonalpont - op1al);

            myBuffer.Graphics.DrawLine(p3, 1, vonalpont, 1 + op2ar, vonalpont - op2al);
            myBuffer.Graphics.DrawLine(p3, 1 + op2ar, vonalpont - op2al, 1 + op2ar + op2d1r, vonalpont - op2d1l);
            myBuffer.Graphics.DrawLine(p3, 1 + op2ar + op2d1r, vonalpont - op2d1l, 1 + op2ar + op2d1r + op2d2r, vonalpont - op2d2l);
            myBuffer.Graphics.DrawLine(p3, 1 + op2ar + op2d1r + op2d2r, vonalpont - op2d2l, 1 + op2ar + op2d1r + op2d2r + op2rr, vonalpont - op2rl);
            myBuffer.Graphics.DrawString("op2", F, b3, op2ar, vonalpont - op2al);

            myBuffer.Graphics.DrawLine(p4, 1, vonalpont, 1 + op3ar, vonalpont - op3al);
            myBuffer.Graphics.DrawLine(p4, 1 + op3ar, vonalpont - op3al, 1 + op3ar + op3d1r, vonalpont - op3d1l);
            myBuffer.Graphics.DrawLine(p4, 1 + op3ar + op3d1r, vonalpont - op3d1l, 1 + op3ar + op3d1r + op3d2r, vonalpont - op3d2l);
            myBuffer.Graphics.DrawLine(p4, 1 + op3ar + op3d1r + op3d2r, vonalpont - op3d2l, 1 + op3ar + op3d1r + op3d2r + op3rr, vonalpont - op3rl);
            myBuffer.Graphics.DrawString("op3", F, b4, op3ar, vonalpont - op3al);
            myBuffer.Graphics.DrawLine(p5, 1, vonalpont, 1 + op4ar, vonalpont - op4al);
            myBuffer.Graphics.DrawLine(p5, 1 + op4ar, vonalpont - op4al, 1 + op4ar + op4d1r, vonalpont - op4d1l);
            myBuffer.Graphics.DrawLine(p5, 1 + op4ar + op4d1r, vonalpont - op4d1l, 1 + op4ar + op4d1r + op4d2r, vonalpont - op4d2l);
            myBuffer.Graphics.DrawLine(p5, 1 + op4ar + op4d1r + op4d2r, vonalpont - op4d2l, 1 + op4ar + op4d1r + op4d2r + op4rr, vonalpont - op4rl);
            myBuffer.Graphics.DrawString("op4", F, b5, op4ar, vonalpont - op4al);
            myBuffer.Graphics.DrawLine(p6, 1, vonalpont, 1 + op5ar, vonalpont - op5al);
            myBuffer.Graphics.DrawLine(p6, 1 + op5ar, vonalpont - op5al, 1 + op5ar + op5d1r, vonalpont - op5d1l);
            myBuffer.Graphics.DrawLine(p6, 1 + op5ar + op5d1r, vonalpont - op5d1l, 1 + op5ar + op5d1r + op5d2r, vonalpont - op5d2l);
            myBuffer.Graphics.DrawLine(p6, 1 + op5ar + op5d1r + op5d2r, vonalpont - op5d2l, 1 + op5ar + op5d1r + op5d2r + op5rr, vonalpont - op5rl);
            myBuffer.Graphics.DrawString("op5", F, b6, op5ar, vonalpont - op5al);
            myBuffer.Graphics.DrawLine(p7, 1, vonalpont, 1 + op6ar, vonalpont - op6al);
            myBuffer.Graphics.DrawLine(p7, 1 + op6ar, vonalpont - op6al, 1 + op6ar + op6d1r, vonalpont - op6d1l);
            myBuffer.Graphics.DrawLine(p7, 1 + op6ar + op6d1r, vonalpont - op6d1l, 1 + op6ar + op6d1r + op6d2r, vonalpont - op6d2l);
            myBuffer.Graphics.DrawLine(p7, 1 + op6ar + op6d1r + op6d2r, vonalpont - op6d2l, 1 + op6ar + op6d1r + op6d2r + op6rr, vonalpont - op6rl);
            myBuffer.Graphics.DrawString("op6", F, b7, op6ar, vonalpont - op6al);
            int pichvonalpont = vonalpont - 200;
            myBuffer.Graphics.DrawLine(p7, 1, pichvonalpont, 1 + pichar, pichvonalpont - pichal);
            myBuffer.Graphics.DrawLine(p7, 1 + pichar, pichvonalpont - pichal, 1 + pichar + pichd1r, pichvonalpont - pichd1l);
            myBuffer.Graphics.DrawLine(p7, 1 + pichar + pichd1r, pichvonalpont - pichd1l, 1 + pichar + pichd1r + pichd2r, pichvonalpont - pichd2l);
            myBuffer.Graphics.DrawLine(p7, 1 + pichar + pichd1r + pichd2r, pichvonalpont - pichd2l, 1 + pichar + pichd1r + pichd2r + pichrr, pichvonalpont - pichrl);
            myBuffer.Graphics.DrawString("pich", F, b7, pichar, pichvonalpont - pichal);

            myBuffer.Graphics.DrawLine(p8, timer2ido,0, timer2ido, 300);
            myBuffer.Render();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                inDeviceID = 0;
                inDevice = new InputDevice(inDeviceID);
              //  Sanford.Multimedia.Midi.InputDevice.Connect(outDeviceID, inDeviceID);

            }

            if (comboBox1.SelectedIndex == 1)
            {
                inDeviceID = 0;
                inDevice = new InputDevice(inDeviceID);

            }
        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                op1volume = op1volumelast;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 54));
                Thread.Sleep(20);
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 5, op1volume));
                Thread.Sleep(20);
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0,6, 53 + opmenu));


            }
            else
            {
                op1volumelast = op1volume;
                op1volume = 0;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller,0, 6, 54));
                Thread.Sleep(20);
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 5, 0));
                Thread.Sleep(20);
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller,0, 6, 53 + opmenu));

            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                op2volume = op2volumelast;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller,0, 6, 55));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 5, op2volume));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller,0, 6, 53 + opmenu));


            }
            else
            {     
                op2volumelast = op2volume;
                op2volume = 0;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller,0, 6, 55));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 5, 0));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller,0, 6, 53+ opmenu));

            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                op3volume = op3volumelast;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 56));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 5, op3volume));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 53 + opmenu));


            }
            else
            {
                op3volumelast = op3volume;
                op3volume = 0;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 56));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 5, 0));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 53 + opmenu));

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                op4volume = op4volumelast;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 57));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 5, op4volume));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 53 + opmenu));


            }
            else
            {
                op4volumelast = op4volume;
                op4volume = 0;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 57));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 5, 0));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 53 + opmenu));

            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                op5volume = op5volumelast;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 58));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 5, op5volume));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 53 + opmenu));


            }
            else
            {
                op5volumelast = op5volume;
                op5volume = 0;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 58));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 5, 0));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 53 + opmenu));

            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                op6volume = op6volumelast;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 59));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 5, op6volume));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 53 + opmenu));


            }
            else
            {
                op6volumelast = op6volume;
                op6volume = 0;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 59));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 5, 0));
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 53 + opmenu));

            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("condition_temp.due");
            sw.Write(richTextBox2.Text);
            sw.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            initvariable();
        }


        


        

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void trackBar63_Scroll_1(object sender, EventArgs e)
        {
            //lfovolume
            int value = trackBar63.Value;
            variableset("lfo2freq", value);
            label56.Text = value + " ";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
        }

        private void label37_Click(object sender, EventArgs e)
        {

        }


        public void parameterset(string variablename, int value)
        {

            if (variablename.Contains("al"))
            {
                switch (opmenu)
                {
                    case 1: op1al = value; break;
                    case 2: op2al = value; break;
                    case 3: op3al = value; break;
                    case 4: op4al = value; break;
                    case 5: op5al = value; break;
                    case 6: op6al = value; break;
                    case 7: pichal = value; break;
                }
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 108, value));
            }
            if (variablename.Contains("ar"))
            {
                switch (opmenu)
                {
                    case 1: op1ar = value; break;
                    case 2: op2ar = value; break;
                    case 3: op3ar = value; break;
                    case 4: op4ar = value; break;
                    case 5: op5ar = value; break;
                    case 6: op6ar = value; break;
                    case 7: pichar = value; break;
                }
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 114, value));
            }

            if (variablename.Contains("d1l"))
            {
                switch (opmenu)
                {
                    case 1: op1d1l = value; break;
                    case 2: op2d1l = value; break;
                    case 3: op3d1l = value; break;
                    case 4: op4d1l = value; break;
                    case 5: op5d1l = value; break;
                    case 6: op6d1l = value; break;
                    case 7: pichd1l = value; break;
                }
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 109, value));
            }
            if (variablename.Contains("d1r"))
            {
                switch (opmenu)
                {
                    case 1: op1d1r = value; break;
                    case 2: op2d1r = value; break;
                    case 3: op3d1r = value; break;
                    case 4: op4d1r = value; break;
                    case 5: op5d1r = value; break;
                    case 6: op6d1r = value; break;
                    case 7: pichd1r = value; break;
                }
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 115, value));
            }

            if (variablename.Contains("d2l"))
            {
                switch (opmenu)
                {
                    case 1: op1d2l = value; break;
                    case 2: op2d2l = value; break;
                    case 3: op3d2l = value; break;
                    case 4: op4d2l = value; break;
                    case 5: op5d2l = value; break;
                    case 6: op6d2l = value; break;
                    case 7: pichd2l = value; break;
                }
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 110, value));
            }

            if (variablename.Contains("d2r"))
            {
                switch (opmenu)
                {
                    case 1: op1d2r = value; break;
                    case 2: op2d2r = value; break;
                    case 3: op3d2r = value; break;
                    case 4: op4d2r = value; break;
                    case 5: op5d2r = value; break;
                    case 6: op6d2r = value; break;
                    case 7: pichd2r = value; break;
                }
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 116, value));
            }

            if (variablename.Contains("rl"))
            {
                switch (opmenu)
                {
                    case 1: op1rl = value; break;
                    case 2: op2rl = value; break;
                    case 3: op3rl = value; break;
                    case 4: op4rl = value; break;
                    case 5: op5rl = value; break;
                    case 6: op6rl = value; break;
                    case 7: pichrl = value; break;
                }
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 111, value));
            }
            if (variablename.Contains("rr"))
            {
                switch (opmenu)
                {
                    case 1: op1rr = value; break;
                    case 2: op2rr = value; break;
                    case 3: op3rr = value; break;
                    case 4: op4rr = value; break;
                    case 5: op5rr = value; break;
                    case 6: op6rr = value; break;
                    case 7: pichrr = value; break;
                }
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 117, value));
            }

            if (variablename.Contains("detune"))
            {
                switch (opmenu)
                {
                    case 1: op1detune = value; break;
                    case 2: op2detune = value; break;
                    case 3: op3detune = value; break;
                    case 4: op4detune = value; break;
                    case 5: op5detune = value; break;
                    case 6: op6detune = value; break;
                    case 7: break;
                }
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 113, value));
            }

            if (variablename.Contains("generatorfreq") && !variablename.Contains("fix"))
            {
                switch (opmenu)
                {
                    case 1: op1generatorfreq = value; break;
                    case 2: op2generatorfreq = value; break;
                    case 3: op3generatorfreq = value; break;
                    case 4: op4generatorfreq = value; break;
                    case 5: op5generatorfreq = value; break;
                    case 6: op6generatorfreq = value; break;
                }
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 44, value));
            }
            if (variablename.Contains("generatorfreqfix"))
            {
                switch (opmenu)
                {
                    case 1: op1generatorfreqfix = value; break;
                    case 2: op2generatorfreqfix = value; break;
                    case 3: op3generatorfreqfix = value; break;
                    case 4: op4generatorfreqfix = value; break;
                    case 5: op5generatorfreqfix = value; break;
                    case 6: op6generatorfreqfix = value; break;
                }
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 0, value));
            }
            if (variablename.Contains("notefixed"))
            {
                switch (opmenu)
                {
                    case 1: op1notefixed = value; break;
                    case 2: op2notefixed = value; break;
                    case 3: op3notefixed = value; break;
                    case 4: op4notefixed = value; break;
                    case 5: op5notefixed = value; break;
                    case 6: op6notefixed = value; break;
                }
                if (value==1)
                {
                    outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 28));
                }
                else
                {
                    outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 29));
                }
               
               
            }


            if (variablename.Contains("volume"))
            {
                switch (opmenu)
                {
                    case 1: op1volume = value; op1volumelast = value; break;
                    case 2: op2volume = value; op2volumelast = value; break;
                    case 3: op3volume = value; op3volumelast = value; break;
                    case 4: op4volume = value; op4volumelast = value; break;
                    case 5: op5volume = value; op5volumelast = value; break;
                    case 6: op6volume = value; op6volumelast = value; break;
                    case 7: pichvolume = value; break;
                }
                if (opmenu == 7)
                {
                    outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 106, value));
                }
                else
                {
                    outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 5, value));
                }

            }

            if (variablename.Contains("waveform"))
            {
                switch (opmenu)
                {
                    case 1: op1waveform = value; break;
                    case 2: op2waveform = value; break;
                    case 3: op3waveform = value; break;
                    case 4: op4waveform = value; break;
                    case 5: op5waveform = value; break;
                    case 6: op6waveform = value; break;
                }
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, value));
            }
            if (variablename.Contains("lep"))
            {

                switch (opmenu)
                {
                    case 1: op1lep = value; break;
                    case 2: op2lep = value; break;
                    case 3: op3lep = value; break;
                    case 4: op4lep = value; break;
                    case 5: op5lep = value; break;
                    case 6: op6lep = value; break;
                }
                value = (value - 13) * 8;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 82, value));
            }
            if (variablename.Contains("pich") && variablename.Contains("op"))
            {
                switch (opmenu)
                {
                    case 1: op1pich = value; break;
                    case 2: op2pich = value; break;
                    case 3: op3pich = value; break;
                    case 4: op4pich = value; break;
                    case 5: op5pich = value; break;
                    case 6: op6pich = value; break;
                }
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, value + 32));

            }


            if (variablename == "reverblevel")
            {
                reverblevel = value;

                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 7, value));

            }
            if (variablename == "reverbdiffuse")
            {
                reverbdiffuse = value;

                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 105, value));

            }
            if (variablename == "choruslevel")
            {
                choruslevel = value;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 43, trackBar86.Value));

            }
            if (variablename == "chorusfreq")
            {
                chorusfreq = value;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 41, value));
            }
            if (variablename == "level")
            {
                level = value;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 72, value));

            }
            if (variablename == "algorithm")
            {
                algorithm = value;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 40, value + 55));
            }
            if (variablename == "feedbacklevel")
            {
                feedbacklevel = value;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 80, value));
            }

            if (variablename == "oplevel")
            {
                oplevel = value;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 45, value));
            }
            if (variablename == "level")
            {
                level = value;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 72, value));
            }

            if (variablename == "frame")
            {
                frame = value;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 101, value));
            }


            if (variablename == "lfo2volume")
            {
                lfo2volume = value;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 107, value));
            }
            if (variablename == "lfo2freq")
            {
                lfo2freq = value;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 104, value));
            }
            if (variablename == "modulation")
            {
                modulation = value;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 102, value));
            }
            if (variablename == "szorzo")
            {
                szorzo= value;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 42, value));
            }

            if (variablename == "pichkezd")
            {
                pichkezd = value;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 103, pichkezd));
            }

            if (variablename == "limitgain")
            {
                limitgain = value;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 46, limitgain));
            }
            if (variablename == "reverbtime")
            {
                reverbtime = value;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 47, reverbtime));
            }
            if (variablename == "ofset")
            {
                ofset = value;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 48, ofset));
            }
            // MessageBox.Show(variablename + " " + opmenu + " " + value);

        }


        public void variableset(string name, int value)
        {
            if (name == "al" || name == "ar" || name == "d1l" || name == "d1r" || name == "d2l" || name == "d2r" || name == "rl" || name == "rr" || name == "notefixed" || name == "waveform" || name == "generatorfreq" || name == "generatorfreqfix" || name == "volume" || name == "lep" || name == "pich" || name == "detune")
            {
                if (opmenu == 7)
                {
                    parameterset(name, value);
                    opszoveg("pich" + name, value);
                }
                else
                {
                    parameterset("op" + opmenu + name, value);
                    opszoveg("op" + opmenu + name, value);
                    maxreleaseset();

                }

            }

            if (name == "reverblevel" || name == "reverbdiffuse" || name == "choruslevel" || name == "chorusfreq" || name == "level" || name == "algorithm" || name == "feedbacklevel" || name == "pichkezd" || name == "algorithm" || name == "oplevel" || name == "lfo2volume" || name == "lfo2freq" || name == "modulation" || name == "szorzo" || name == "frame" || name == "reverbtime" || name == "ofset" || name == "limitgain")
            {
                parameterset(name, value);
                opszoveg(name, value);
            }
            gorberajzol();
            Thread.Sleep(50);
        }

        public void opszoveg(string name, int value)
        {
            //update richtextbox
            String szoveg = richTextBox2.Text;
            int torolnikezd = szoveg.IndexOf(name + "= ");
            if (torolnikezd >= 0)
            {
                int torolnivege = szoveg.IndexOf(";\n", torolnikezd);


                szoveg = szoveg.Remove(torolnikezd, torolnivege + 2 - torolnikezd);
            }
            richTextBox2.Text = name + "= " + value + ";\n";
            richTextBox2.Text += szoveg;
            int size = richTextBox2.Lines.Length;
            label4.Text = "PARAMETERS: " + size;
        }
        void trackbarminmax()
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 16;
            trackBar3.Minimum = 0;
            trackBar3.Maximum = 127;
            trackBar5.Minimum = 0;
            trackBar5.Maximum = 127;
            trackBar6.Minimum = 0;
            trackBar6.Maximum = 127;
            trackBar7.Minimum = 0;
            trackBar7.Maximum = 127;
            trackBar8.Minimum = 0;
            trackBar8.Maximum = 127;
            trackBar9.Minimum = 0;
            trackBar9.Maximum = 127;
            trackBar10.Minimum = 0;
            trackBar10.Maximum = 127;
            trackBar11.Minimum = 0;
            trackBar11.Maximum = 127;
            trackBar12.Minimum = 0;
            trackBar12.Maximum = 127;
            trackBar13.Minimum = 0;
            trackBar13.Maximum = 127;         
            trackBar14.Minimum = 0;
            trackBar14.Maximum = 127;
            trackBar21.Minimum = 0;
            trackBar21.Maximum = 127;
            trackBar23.Minimum = 0;
            trackBar23.Maximum = 127;
            trackBar24.Minimum = 0;
            trackBar24.Maximum = 127;
            trackBar31.Minimum = 0;
            trackBar31.Maximum = 127;
            trackBar32.Minimum = 0;
            trackBar32.Maximum = 100;
            trackBar33.Minimum = 0;
            trackBar33.Maximum = 100;
            trackBar37.Minimum = 13;
            trackBar37.Maximum = 28;
            trackBar51.Minimum = 1;
            trackBar51.Maximum = 127;
            trackBar54.Minimum = 0;
            trackBar54.Maximum = 127;
            trackBar55.Minimum = 35;
            trackBar55.Maximum = 80;
            trackBar56.Minimum = 32;
            trackBar56.Maximum = 34;
            trackBar57.Minimum = 0;
            trackBar57.Maximum = 2;
            trackBar60.Minimum = 0;
            trackBar60.Maximum = 127;
            trackBar62.Minimum = 0;
            trackBar62.Maximum = 32;
            trackBar63.Minimum = 1;
            trackBar63.Maximum = 127;
            trackBar84.Minimum = 1;
            trackBar84.Maximum = 127;
            trackBar85.Minimum = 0;
            trackBar85.Maximum = 127;
            trackBar86.Minimum = 0;
            trackBar86.Maximum = 16;
            trackBar87.Minimum = 0;
            trackBar87.Maximum = 127;
        }
        void initglobaltrackbar()
        {
            trackBar87.Value = reverblevel;
            trackBar85.Value = reverbdiffuse;
            trackBar86.Value = choruslevel;
            trackBar84.Value = chorusfreq;
            trackBar55.Value = feedbacklevel;
            trackBar62.Value = algorithm;
            trackBar54.Value = oplevel;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar2.Value*10;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer2ido < maxtime)
            {
                if (timer2ido!=maxrelease)
                {
                timer2ido++;
                }
                
                gorberajzol();
            }
        }

        private void trackBar14_Scroll(object sender, EventArgs e)
        {
            //limitgain
            int value = trackBar14.Value;
            variableset("limitgain", value);
            label56.Text = value + " ";
        }

        private void trackBar13_Scroll(object sender, EventArgs e)
        {
            //ofset
            int value = trackBar13.Value;
            variableset("ofset", value);
            label56.Text = value + " ";
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            //reverbtime
            int value = trackBar3.Value;
            variableset("reverbtime", value);
            label56.Text = value + " ";
        }

        private void dXDUE7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void maxreleaseset()
        {
            maxrelease = op1ar + op1d1r + op1d2r;
            int maxrelease1 = op2ar + op2d1r + op2d2r;
            if (maxrelease < maxrelease1) { maxrelease = maxrelease1; }
            int maxrelease2 = op3ar + op3d1r + op3d2r;
            if (maxrelease < maxrelease2) { maxrelease = maxrelease2; }
            int maxrelease3 = op4ar + op4d1r + op4d2r;
            if (maxrelease < maxrelease3) { maxrelease = maxrelease3; }
            int maxrelease4 = op5ar + op5d1r + op5d2r;
            if (maxrelease < maxrelease4) { maxrelease = maxrelease4; }
            int maxrelease5 = op6ar + op6d1r + op6d2r;
            if (maxrelease < maxrelease5) { maxrelease = maxrelease5; }

            maxtime = maxrelease + op1rr + 1;
            int maxtime1 = maxrelease + op2rr + 1;
            if (maxtime < maxtime1) { maxtime = maxtime1; }
            int maxtime2 = maxrelease + op3rr + 1;
            if (maxtime < maxtime2) { maxtime = maxtime2; }
            int maxtime3 = maxrelease + op4rr + 1;
            if (maxtime < maxtime3) { maxtime = maxtime3; }
            int maxtime4 = maxrelease + op5rr + 1;
            if (maxtime < maxtime4) { maxtime = maxtime4; }
            int maxtime5 = maxrelease + op6rr + 1;
            if (maxtime < maxtime5) { maxtime = maxtime5; }
        }

        
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            // opvolume  mindent egyszerre
                            
            int value = trackBar21.Value;
            variableset("volume", value);
            label56.Text = value + " ";

        }

        int opvolume=10;
        private void button19_Click(object sender, EventArgs e)
        {
           
            if (op1volume != 0 && op2volume!=0 && op3volume != 0 && op4volume != 0 && op5volume != 0 && op6volume != 0) {
                opmenu = 1;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 54));
                op1volume--;
                variableset("volume", op1volume);
                label56.Text = op1volume + " ";
                opmenu = 2;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 55));
                op2volume--;
                variableset("volume", op2volume);
                label56.Text = op2volume + " ";
                opmenu = 3;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 56));
                op3volume--;
                variableset("volume", op3volume);
                label56.Text = op3volume + " ";
                opmenu = 4;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 57));
                op4volume--;
                variableset("volume", op4volume);
                label56.Text = op4volume + " ";
                opmenu = 5;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 58));
                op5volume--;
                variableset("volume", op5volume);
                label56.Text = op5volume + " ";
                opmenu = 6;
                outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0, 6, 59));
                op6volume--;
                variableset("volume", op6volume);
                label56.Text = op6volume + " ";
            }
        }
    }
}
