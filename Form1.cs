using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Threading.Tasks;
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

        private const int MOUSE_LEFT = 1;
        private const int MOUSE_RIGHT = 2;
        private const int MOUSE_UP = 3;
        private const int MOUSE_DOWN = 4;


        private bool isMouseMoving = false;
        private int currentMouseDirection = 0;

        private void MidiIn_MessageReceived(object sender, MidiInMessageEventArgs e)
        {
            if (e.MidiEvent is NoteEvent midiEvent)
            {
                if (isWaitingForInput && midiEvent.CommandCode == MidiCommandCode.NoteOn)
                {
                    isWaitingForInput = false;
                    MessageBox.Show($"note: {midiEvent.NoteName}, id: {midiEvent.NoteNumber}");
                    return;
                }

                if (checkboxActive.Checked)
                {
                    var keyCode = GetVirtualKeyCode(midiEvent.NoteNumber);

                    if (midiEvent.CommandCode == MidiCommandCode.NoteOn)
                    {
                        if (keyCode.Item1)
                        {
                            StartMouseMove(keyCode.Item2);
                        }
                        else if (keyCode.Item2 == (int)VirtualKeyCode.LBUTTON || keyCode.Item2 == (int)VirtualKeyCode.RBUTTON)
                        {
                            MouseDown((VirtualKeyCode)keyCode.Item2);
                        }
                        else
                        {
                            inputSimulator.Keyboard.KeyDown((VirtualKeyCode)keyCode.Item2);
                        }
                    }
                    else if (midiEvent.CommandCode == MidiCommandCode.NoteOff)
                    {
                        if (keyCode.Item1)
                        {
                            StopMouseMove();
                        }
                        else if (keyCode.Item2 == (int)VirtualKeyCode.LBUTTON || keyCode.Item2 == (int)VirtualKeyCode.RBUTTON)
                        {
                            MouseUp((VirtualKeyCode)keyCode.Item2);
                        }
                        else
                        {
                            inputSimulator.Keyboard.KeyUp((VirtualKeyCode)keyCode.Item2);
                        }
                    }
                }
            }
        }

        private (bool, int) GetVirtualKeyCode(int noteNumber)
        {
            switch (noteNumber)
            {
                case 48: // C4
                    return (false, (int)VirtualKeyCode.SHIFT);
                case 49: // C#4
                    return (false, (int)VirtualKeyCode.VK_Q);
                case 50: // D4
                    return (false, (int)VirtualKeyCode.VK_A);
                case 51: // D#4
                    return (false, (int)VirtualKeyCode.VK_W);
                case 52: // E4
                    return (false, (int)VirtualKeyCode.VK_S);
                case 53: // F4
                    return (false, (int)VirtualKeyCode.VK_D);
                case 54: // F#4
                    return (false, (int)VirtualKeyCode.VK_E);
                case 55: // G4
                    return (false, (int)VirtualKeyCode.SPACE);
                case 56: // G#4
                    return (false, (int)VirtualKeyCode.F5);
                case 57: // A4
                    return (false, (int)VirtualKeyCode.VK_F);
                case 60: // C5
                    return (false, (int)VirtualKeyCode.LBUTTON);
                case 61: // C#5
                    return (false, (int)VirtualKeyCode.RBUTTON);
                case 62: // D5
                    return (true, MOUSE_LEFT);
                case 63: // D#5
                    return (true, MOUSE_UP);
                case 64: // E5
                    return (true, MOUSE_DOWN);
                case 65: // F5
                    return (true, MOUSE_RIGHT);
                //scrolln:
                // G#5:68 up wheel_scrolling once
                // F#5:66 down wheel_scrolling once
                default:
                    return (false, (int)VirtualKeyCode.ESCAPE);
            }
        }

        private new void MouseDown(VirtualKeyCode button)
        {
            switch (button)
            {
                case VirtualKeyCode.LBUTTON:
                    inputSimulator.Mouse.LeftButtonDown();
                    break;
                case VirtualKeyCode.RBUTTON:
                    inputSimulator.Mouse.RightButtonDown();
                    break;
            }
        }

        private new void MouseUp(VirtualKeyCode button)
        {
            switch (button)
            {
                case VirtualKeyCode.LBUTTON:
                    inputSimulator.Mouse.LeftButtonUp();
                    break;
                case VirtualKeyCode.RBUTTON:
                    inputSimulator.Mouse.RightButtonUp();
                    break;
            }
        }

        private void StartMouseMove(int direction)
        {
            if (!isMouseMoving)
            {
                isMouseMoving = true;
                currentMouseDirection = direction;
                MoveMouseContinuously();
            }
        }

        private void StopMouseMove()
        {
            isMouseMoving = false;
        }

        private async void MoveMouseContinuously()
        {
            const int moveAmount = 15;
            while (isMouseMoving)
            {
                switch (currentMouseDirection)
                {
                    case MOUSE_LEFT:
                        inputSimulator.Mouse.MoveMouseBy(-moveAmount, 0);
                        break;
                    case MOUSE_UP:
                        inputSimulator.Mouse.MoveMouseBy(0, -moveAmount);
                        break;
                    case MOUSE_DOWN:
                        inputSimulator.Mouse.MoveMouseBy(0, moveAmount);
                        break;
                    case MOUSE_RIGHT:
                        inputSimulator.Mouse.MoveMouseBy(moveAmount, 0);
                        break;
                }
                await Task.Delay(10);
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