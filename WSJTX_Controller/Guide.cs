using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  WSJTX_Controller;

namespace WSJTX_Controller
{
    public partial class Guide : Form
    {
        private Color normalFore;
        private Color normalBack;
        private Color highlightFore;
        private Color highlightBack;
        private Color highlightBackDisabled;

        private bool cqButtonEnabled = false;
        private bool activatorEnabled = false;
        private bool hunterEnabled = false;
        private bool cqDxButtonEnabled = false;
        private bool nonDxButtonEnabled = false;
        private bool dxButtonEnabled = false;
        private bool dxccButtonEnabled = false;
        private List<CheckBox> disableList;

        private WsjtxClient wsjtxClient;
        private Controller ctrl;

        public Guide(WsjtxClient cl, Controller co)
        {
            InitializeComponent();

            wsjtxClient = cl;
            ctrl = co;

            normalFore = closeButton.ForeColor;
            normalBack = closeButton.BackColor;
            highlightFore = Color.White;
            highlightBack = Color.Green;
            highlightBackDisabled = Color.LightGreen;

            disableList = new List<CheckBox>()
            {
                listenButton,
                callCqButton,

                cqButton,
                cqDxButton,

                dxButton,
                nonDxButton,

                potaButton,
                hunterButton,

                allButton,
                recentButton
            };
        }

        public void UpdateView()
        {
            UpdateAllButtons();
        }

        private void Guide_Load(object sender, EventArgs e)
        {
            modeLabel.Visible = callCqButton.Visible = listenButton.Visible = true;
            UpdateAllButtons();
            dxccButtonEnabled = wsjtxClient.txMode == WsjtxClient.TxModes.LISTEN && ctrl.periodComboBox.SelectedIndex == (int)WsjtxClient.ListenModeTxPeriods.ANY && ctrl.replyNewDxccCheckBox.Checked && ctrl.replyNewOnlyCheckBox.Checked;
            UpdateAllButtons();

            //center on current screen
            Screen screen = Screen.FromControl(ctrl);
            Location = new Point(screen.Bounds.X + ((screen.Bounds.Width - Width) / 2), screen.Bounds.Y + ((screen.Bounds.Height - Height) / 2));

            subtitleLabel.Focus();
        }

        private void Guide_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dxButtonEnabled || nonDxButtonEnabled)
            {
                ctrl.cqOnlyRadioButton.Checked = true;
                ctrl.bandComboBox.SelectedIndex = (int)WsjtxClient.NewCallBands.ANY;
            }
        }

        private void Guide_FormClosed(object sender, FormClosedEventArgs e)
        {
            ctrl.GuideClosed();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateAllButtons()
        {
            foreach (CheckBox b in disableList)
            {
                b.Enabled = !dxccButtonEnabled;
            }

            SetState(listenButton, wsjtxClient.txMode == WsjtxClient.TxModes.LISTEN && ctrl.periodComboBox.SelectedIndex == (int)WsjtxClient.ListenModeTxPeriods.ANY, true);
            SetState(callCqButton, wsjtxClient.txMode == WsjtxClient.TxModes.CALL_CQ, true);

            SetState(cqButton, (cqButtonEnabled = ctrl.callNonDirCqCheckBox.Checked && !ctrl.callDirCqCheckBox.Checked), true);
            SetState(cqDxButton, (cqDxButtonEnabled = ctrl.callCqDxCheckBox.Checked && !ctrl.callDirCqCheckBox.Checked), true);

            SetState(dxButton, (dxButtonEnabled = ctrl.replyDxCheckBox.Checked), true);
            SetState(nonDxButton, (nonDxButtonEnabled = ctrl.replyLocalCheckBox.Checked), true);

            SetState(potaButton, (activatorEnabled = wsjtxClient.txMode == WsjtxClient.TxModes.CALL_CQ && ctrl.directedTextBox.Text == "POTA" && ctrl.callDirCqCheckBox.Checked && !ctrl.callCqDxCheckBox.Checked && !ctrl.callNonDirCqCheckBox.Checked), true);
            SetState(hunterButton, (hunterEnabled = wsjtxClient.txMode == WsjtxClient.TxModes.LISTEN && ctrl.alertTextBox.Text.Contains("POTA") && ctrl.replyDirCqCheckBox.Checked), true);

            SetState(allButton, (ctrl.rankComboBox.SelectedIndex == (int)WsjtxClient.RankMethods.CALL_ORDER), true);
            SetState(recentButton, (ctrl.rankComboBox.SelectedIndex == (int)WsjtxClient.RankMethods.MOST_RECENT), true);

            if (callCqButton.Checked)
            {
                label9.Text = "You're now ready to start. Close this Basic Options dialog, then enable CQ mode using Ctrl, E.";
            }
            else
            {
                label9.Text = "You're now ready to start. Close this Basic Options dialog, and Listen mode is enabled.";
            }
        }

        private void callCqButton_Click(object sender, EventArgs e)
        {
            ctrl.GuideCqMode();
            UpdateAllButtons();
        }

        private void listenButton_Click(object sender, EventArgs e)
        {
            ctrl.GuideListenMode();
            if (wsjtxClient.txMode == WsjtxClient.TxModes.LISTEN) ctrl.periodComboBox.SelectedIndex = (int)WsjtxClient.ListenModeTxPeriods.ANY;
            UpdateAllButtons();
        }



        private void cqButton_Click(object sender, EventArgs e)
        {
            UpdateAllButtons();
            if (cqButtonEnabled)
            {
                ctrl.callNonDirCqCheckBox.Checked = false;
            }
            else
            {
                ctrl.callNonDirCqCheckBox.Checked = true;
                ctrl.callDirCqCheckBox.Checked = false;
            }
            UpdateAllButtons();
        }

        private void cqDxButton_Click(object sender, EventArgs e)
        {
            UpdateAllButtons();
            if (cqDxButtonEnabled)
            {
                ctrl.callCqDxCheckBox.Checked = false;
            }
            else
            {
                ctrl.callCqDxCheckBox.Checked = true;
                ctrl.callDirCqCheckBox.Checked = false;
                ctrl.periodComboBox.SelectedIndex = (int)WsjtxClient.ListenModeTxPeriods.ANY;
            }
            UpdateAllButtons();
        }



        private void dxButton_Click(object sender, EventArgs e)
        {

            UpdateAllButtons();
            ctrl.ToggleDx();
            UpdateAllButtons();
        }


        private void nonDxButton_Click(object sender, EventArgs e)
        {
            UpdateAllButtons();
            ctrl.ToggleLocal();
            UpdateAllButtons();
        }


        private void potaButton_Click(object sender, EventArgs e)
        {
            UpdateAllButtons();
            if (!activatorEnabled && hunterEnabled) ctrl.ToggleHunter();
            ctrl.ToggleActivator();
            ctrl.cqModeButton_Click(null, null);
            UpdateAllButtons();
        }

        private void hunterButton_Click(object sender, EventArgs e)
        {
            UpdateAllButtons();
            if (!hunterEnabled && activatorEnabled) ctrl.ToggleActivator();
            ctrl.ToggleHunter();
            ctrl.listenModeButton_Click(null, null);
            ctrl.periodComboBox.SelectedIndex = (int)WsjtxClient.ListenModeTxPeriods.ANY;
            UpdateAllButtons();
        }



        private void allButton_Click(object sender, EventArgs e)
        {
            UpdateAllButtons();
            if (ctrl.rankComboBox.SelectedIndex != (int)WsjtxClient.RankMethods.CALL_ORDER || ctrl.timeoutNumUpDown.Value != 3)
            {
                ctrl.rankComboBox.SelectedIndex = (int)WsjtxClient.RankMethods.CALL_ORDER;
            }
            UpdateAllButtons();
        }


        private void recentButton_Click(object sender, EventArgs e)
        {
            UpdateAllButtons();
            if (ctrl.rankComboBox.SelectedIndex != (int)WsjtxClient.RankMethods.MOST_RECENT || ctrl.timeoutNumUpDown.Value != 1)
            {
                ctrl.rankComboBox.SelectedIndex = (int)WsjtxClient.RankMethods.MOST_RECENT;
            }
            UpdateAllButtons();
        }



        private void freqButton_Click(object sender, EventArgs e)
        {
            UpdateAllButtons();
            ctrl.freqCheckBox.Checked = !ctrl.freqCheckBox.Checked;
            UpdateAllButtons();
        }


 
        private void SetState(CheckBox button, bool selected, bool enabled)
        {
            if (selected)
            {
                HighLight(button, enabled);
            }
            else
            {
                Normal(button, enabled);
            }
        }

        private void HighLight(CheckBox button, bool enabled)
        {
            button.ForeColor = highlightFore;
            button.BackColor = enabled ? highlightBack : highlightBackDisabled;
            button.Checked = true;
        }

        private void Normal(CheckBox button, bool enabled)
        {
            button.ForeColor = normalFore;
            button.BackColor = normalBack;
            button.Checked = false;
        }

        private void Guide_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Q)
            {
                Close();
            }
        }

        private void Guide_Activated(object sender, EventArgs e)
        {
        }

        private void SubtitleLabel_Enter(object sender, EventArgs e)
        {
            subtitleLabel.SelectionStart = 0;
            subtitleLabel.SelectionLength = 0;
        }

        private void ModeLabel_Enter(object sender, EventArgs e)
        {
            modeLabel.SelectionStart = 0;
            modeLabel.SelectionLength = 0;
        }

        private void Label12_Enter(object sender, EventArgs e)
        {
            label12.SelectionStart = 0;
            label12.SelectionLength = 0;
        }

        private void Label2_Enter(object sender, EventArgs e)
        {
            label2.SelectionStart = 0;
            label2.SelectionLength = 0;
        }

        private void Label4_Enter(object sender, EventArgs e)
        {
            label4.SelectionStart = 0;
            label4.SelectionLength = 0;
        }

        private void Label5_Enter(object sender, EventArgs e)
        {
            label5.SelectionStart = 0;
            label5.SelectionLength = 0;
        }

        private void Label9_Enter(object sender, EventArgs e)
        {
            label9.SelectionStart = 0;
            label9.SelectionLength = 0;
        }
    }
}
