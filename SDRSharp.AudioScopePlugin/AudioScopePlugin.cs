using System;
using System.Windows.Forms;
using System.ComponentModel;

using SDRSharp.Common;
using SDRSharp.Radio;

namespace SDRSharp.AudioScope
{
    public unsafe class AudioScopePlugin : ISharpPlugin, IRealProcessor
    {
        private const string _displayName = "AudioScope";

        private ISharpControl _control;
        private ControlPanel _controlPanel;
        private FrontPanel _frontPanel;
        private SdrNetServer _netServer;

        public string DisplayName
        {
            get { return _displayName; }
        }

        public bool HasGui
        {
            get { return true; }
        }

        public UserControl GuiControl
        {
            get { return _controlPanel; }
        }

        public void Initialize(ISharpControl control)
        {
            _control = control;
            _frontPanel = new FrontPanel(_control);
            _controlPanel = new ControlPanel(_frontPanel);
            _netServer = new SdrNetServer();
            _netServer.Start();

            _control.RegisterFrontControl(_frontPanel, PluginPosition.Top);
            _control.RegisterStreamHook(this, ProcessorType.FilteredAudioOutput);
        }

        public void Close()
        {
            _frontPanel.Close();
        }

        void IRealProcessor.Process(float* buffer, int length)
        {
            try
            { _netServer.SendSamples(buffer, length); }
            catch (Exception) { }

            try
            { if (_frontPanel.Enable) { _frontPanel.Process(buffer, length); } }
            catch (Exception) { }
        }

        double IStreamProcessor.SampleRate
        {
            set { _netServer.SetSampleRate(value); }
        }

        bool IBaseProcessor.Enabled
        {
            get
            {
                return true;
            }
            set
            {

            }
        }
    }
}
