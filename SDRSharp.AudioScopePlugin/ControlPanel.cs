using System;
using System.Windows.Forms;

namespace SDRSharp.AudioScope
{
    public partial class ControlPanel : UserControl
    {
        private FrontPanel _frontPanel;

        public ControlPanel(FrontPanel frontPanel)
        {
            _frontPanel = frontPanel;
            InitializeComponent();
        }

        private void checkBoxesChanged(object sender, EventArgs e)
        {
            _frontPanel.Amplification = amplitude.Value ;
            _frontPanel.PointSize = speed.Value;
            _frontPanel.Roll = rollCheckbox.Checked;
            _frontPanel.Enable = enableCheckBox.Checked;
            _frontPanel.Run = cbRun.Checked;
            _frontPanel.Log = cbLog.Checked;
            _frontPanel.Unsigned = cbUnsigned.Checked;
        }

    }
}
