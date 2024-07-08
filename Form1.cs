using System;
using System.Drawing.Text;
using System.Windows.Forms;
using NAudio.Midi;
using WindowsInput;
using WindowsInput.Native;

namespace MidiConverter
{
    public partial class Form : System.Windows.Forms.Form
    {
        private MidiIn midiIn;
        private InputSimulator inputSimulator;
        private bool isWaitingForInput;

        public Form()
        {
            InitializeComponent();
            inputSimulator = new InputSimulator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            midiIn = new MidiIn(0);
            midiIn.MessageReceived += MidiIn_MessageReceived;
            midiIn.ErrorReceived += MidiIn_ErrorReceived;
            midiIn.Start();

            
        }

        private void MidiIn_MessageReceived(object sender, MidiInMessageEventArgs e)
        {
            var midiEvent = e.MidiEvent as NoteEvent;
            var key = );
            if (midiEvent != null && midiEvent.CommandCode == MidiCommandCode.NoteOn)
            {
                if (isWaitingForInput)
                {
                    isWaitingForInput = false;
                    MessageBox.Show($"note: {midiEvent.NoteName}, id: {midiEvent.NoteNumber}");
                    return;
                }
                
                if (checkboxActive.Checked)
                {
                    if (midiEvent.NoteNumber == 48) // C4
                    {
                        inputSimulator.Keyboard.KeyPress(VirtualKeyCode.SHIFT);
                    }
                    if (midiEvent.NoteNumber == 50) // D4
                    {
                        inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                    }
                }
            }
        }

        private void MidiIn_ErrorReceived(object sender, MidiInMessageEventArgs e)
        {
            MessageBox.Show($"error: {e.RawMessage}");
        }

        private void check_Click(object sender, EventArgs e)
        {
            isWaitingForInput = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            { 
                this.AutoSize = true; 
            }
            else { 
                this.AutoSize = false; 
            }
        }
    }
}
