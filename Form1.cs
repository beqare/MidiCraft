using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
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
            if (e.MidiEvent is NoteEvent midiEvent && midiEvent.CommandCode == MidiCommandCode.NoteOn)
            {
                if (isWaitingForInput)
                {
                    isWaitingForInput = false;
                    MessageBox.Show($"note: {midiEvent.NoteName}, id: {midiEvent.NoteNumber}");
                    return;
                }

                if (checkboxActive.Checked)
                {
                    switch (midiEvent.NoteNumber)
                    {
                        case 48: // C4
                            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.SHIFT);
                            break;
                        case 49: // C#4
                            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_Q);
                            break;
                        case 50: // D4
                            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                            break;
                        case 51: // D#4
                            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_W);
                            break;
                        case 52: // E4
                            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_S);
                            break;
                        case 53: // F4
                            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_D);
                            break;
                        case 54: // F#4
                            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_E);
                            break;
                        case 55: // G4
                            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.SPACE);
                            break;
                        case 56: // G#4
                            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.F5);
                            break;
                        case 57: // A4
                            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_F);
                            break;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://snoopti.de/discord");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://snoopti.de/github");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image image = MidiCraft.Properties.Resources.keybinds;

            string tempFilePath = Path.Combine(Path.GetTempPath(), "midicraft-keybinds_temp.png");
            image.Save(tempFilePath, ImageFormat.Png);

            Process.Start(tempFilePath);
        }
    }
}