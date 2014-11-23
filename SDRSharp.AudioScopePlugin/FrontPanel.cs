using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using SDRSharp.Radio;
using SDRSharp.Common;

namespace SDRSharp.AudioScope
{
    public partial class FrontPanel : UserControl
    {
        private ISharpControl _control;

        public bool Run { get; set; }
        public bool Unsigned { get; set; }
        public bool Log { get; set; }
        public int Amplification { get; set; }
        public int PointSize { get; set; }
        public bool Roll { get; set; }

        public FrontPanel(ISharpControl control)
        {
            _control = control;
            InitializeComponent();
        }

        public void Close()
        {
            // Termination stuff goes here
        }

        public bool Enable
        {
            get
            { return base.Visible; }
            set
            { base.Visible = value; }
        }

        private float _avgSum;
        private int _avgCount;
        private List<float> _points = new List<float>();

        public unsafe void Process(float* buffer, int length)
        {
            for (int i = 0; i < length; i++)
            {
                _avgSum += buffer[i];
                _avgCount++;
                if (_avgCount > PointSize)
                {
                    _avgSum /= (float)_avgCount;
                    _avgCount = 0;
                    _points.Add(_avgSum);
                }
            }
        }

        private void RedrawByTimer(object sender, EventArgs e)
        {
            try
            {
                if (Enable && Run)
                {
                    Bitmap bmp = new Bitmap(this.Width * 2, this.Height * 2);
                    Graphics gr = Graphics.FromImage(bmp);
                    Pen pen = new Pen(Color.White, 2.0f);
                    gr.Clear(Color.Black);
                    int lasty = 0;
                    float start = 0;
                    double ampl = Math.Exp((double)Amplification * 0.2d);
                    if (Unsigned) { start = (float)bmp.Height - 5; } else { start = (float)bmp.Height * 0.5f; }
                    for (int x = 1; x < bmp.Width; x++)
                    {
                        if (x < _points.Count)
                        {
                            int y = 0;
                            if (Log)
                            {
                                y = (int)(-1.0f * Math.Log(_points[x] * ampl, 1.05) * (float)bmp.Height + start);
                            }
                            else
                            {
                                y = (int)(-1.0f * _points[x] * ampl * (float)bmp.Height + start);
                            }
                            if (y > bmp.Height) { y = bmp.Height - 1; }
                            if (y < 0) { y = 0; }
                            gr.DrawLine(pen, x - 1, lasty, x, y);
                            lasty = y;
                        }
                    }
                    while (_points.Count > bmp.Width)
                        if (Roll)
                        { _points.RemoveAt(0); }
                        else
                        { _points.Clear(); }
                    output.Image = bmp;
                    this.Refresh();
                }
            }
            catch (Exception)
            {            }
        }
    }
}
