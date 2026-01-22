
namespace WSJTX_Controller
{
    partial class Guide
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
            if (disposing && (components != null))
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
            this.modeLabel = new System.Windows.Forms.TextBox();
            this.callCqButton = new System.Windows.Forms.CheckBox();
            this.listenButton = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.TextBox();
            this.dxButton = new System.Windows.Forms.CheckBox();
            this.nonDxButton = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.TextBox();
            this.potaButton = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.TextBox();
            this.allButton = new System.Windows.Forms.CheckBox();
            this.recentButton = new System.Windows.Forms.CheckBox();
            this.subtitleLabel = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.TextBox();
            this.hunterButton = new System.Windows.Forms.CheckBox();
            this.cqDxButton = new System.Windows.Forms.CheckBox();
            this.cqButton = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // modeLabel
            // 
            this.modeLabel.AccessibleName = "\"...\"";
            this.modeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLabel.Location = new System.Drawing.Point(24, 47);
            this.modeLabel.MaximumSize = new System.Drawing.Size(450, 4);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.ReadOnly = true;
            this.modeLabel.Size = new System.Drawing.Size(448, 22);
            this.modeLabel.TabIndex = 0;
            this.modeLabel.Text = ", Do you want to call CQ or only listen for interesting calls? You\'ll be listenin" +
    "g on both Tx periods, and conserve space on the band.";
            this.modeLabel.Enter += new System.EventHandler(this.ModeLabel_Enter);
            // 
            // callCqButton
            // 
            this.callCqButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callCqButton.Location = new System.Drawing.Point(485, 49);
            this.callCqButton.Name = "callCqButton";
            this.callCqButton.Size = new System.Drawing.Size(134, 27);
            this.callCqButton.TabIndex = 2;
            this.callCqButton.Text = "\'Call CQ\' mode";
            this.callCqButton.UseVisualStyleBackColor = true;
            this.callCqButton.Click += new System.EventHandler(this.callCqButton_Click);
            // 
            // listenButton
            // 
            this.listenButton.AccessibleName = "\'Listen for calls\' mode";
            this.listenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listenButton.Location = new System.Drawing.Point(630, 49);
            this.listenButton.Name = "listenButton";
            this.listenButton.Size = new System.Drawing.Size(144, 27);
            this.listenButton.TabIndex = 3;
            this.listenButton.Text = "\'Listen\' mode";
            this.listenButton.UseVisualStyleBackColor = true;
            this.listenButton.Click += new System.EventHandler(this.listenButton_Click);
            // 
            // label2
            // 
            this.label2.AccessibleName = "\"...\"";
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 137);
            this.label2.MaximumSize = new System.Drawing.Size(450, 22);
            this.label2.Name = "label2";
            this.label2.ReadOnly = true;
            this.label2.Size = new System.Drawing.Size(432, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = ", In addition to calls to you, which other calls do you want to reply to? (You ca" +
    "n choose DX, my continent, both, or none)";
            this.label2.Enter += new System.EventHandler(this.Label2_Enter);
            // 
            // dxButton
            // 
            this.dxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dxButton.Location = new System.Drawing.Point(485, 138);
            this.dxButton.Name = "dxButton";
            this.dxButton.Size = new System.Drawing.Size(134, 27);
            this.dxButton.TabIndex = 8;
            this.dxButton.Text = "Reply to DX";
            this.dxButton.UseVisualStyleBackColor = true;
            this.dxButton.Click += new System.EventHandler(this.dxButton_Click);
            // 
            // nonDxButton
            // 
            this.nonDxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonDxButton.Location = new System.Drawing.Point(630, 138);
            this.nonDxButton.Name = "nonDxButton";
            this.nonDxButton.Size = new System.Drawing.Size(144, 27);
            this.nonDxButton.TabIndex = 9;
            this.nonDxButton.Text = "Reply to my continent";
            this.nonDxButton.UseVisualStyleBackColor = true;
            this.nonDxButton.Click += new System.EventHandler(this.nonDxButton_Click);
            // 
            // label4
            // 
            this.label4.AccessibleName = "\"...\"";
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 181);
            this.label4.MaximumSize = new System.Drawing.Size(450, 4);
            this.label4.Name = "label4";
            this.label4.ReadOnly = true;
            this.label4.Size = new System.Drawing.Size(450, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = ", If you\'re operating Parks on the Air, what will you be doing? (You can choose A" +
    "ctivator, Hunter, or none)";
            this.label4.Enter += new System.EventHandler(this.Label4_Enter);
            // 
            // potaButton
            // 
            this.potaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potaButton.Location = new System.Drawing.Point(485, 182);
            this.potaButton.Name = "potaButton";
            this.potaButton.Size = new System.Drawing.Size(134, 27);
            this.potaButton.TabIndex = 11;
            this.potaButton.Text = "Activator";
            this.potaButton.UseVisualStyleBackColor = true;
            this.potaButton.Click += new System.EventHandler(this.potaButton_Click);
            // 
            // label5
            // 
            this.label5.AccessibleName = "\"...\"";
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 226);
            this.label5.MaximumSize = new System.Drawing.Size(450, 4);
            this.label5.Name = "label5";
            this.label5.ReadOnly = true;
            this.label5.Size = new System.Drawing.Size(445, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = ", When replying to calls, do you want to reply in the order received, or reply  t" +
    "o the most-recent call? (Either way, all responses are stored/answered)";
            this.label5.Enter += new System.EventHandler(this.Label5_Enter);
            // 
            // allButton
            // 
            this.allButton.AccessibleName = "reply in call order";
            this.allButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allButton.Location = new System.Drawing.Point(485, 228);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(134, 27);
            this.allButton.TabIndex = 14;
            this.allButton.Text = "Reply in order";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // recentButton
            // 
            this.recentButton.AccessibleName = "Reply to most recent first";
            this.recentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentButton.Location = new System.Drawing.Point(630, 228);
            this.recentButton.Name = "recentButton";
            this.recentButton.Size = new System.Drawing.Size(144, 27);
            this.recentButton.TabIndex = 15;
            this.recentButton.Text = "Reply to recent first";
            this.recentButton.UseVisualStyleBackColor = true;
            this.recentButton.Click += new System.EventHandler(this.recentButton_Click);
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AccessibleDescription = "";
            this.subtitleLabel.AccessibleName = "\"Options\"";
            this.subtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.Location = new System.Drawing.Point(24, 18);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.ReadOnly = true;
            this.subtitleLabel.Size = new System.Drawing.Size(689, 24);
            this.subtitleLabel.TabIndex = 0;
            this.subtitleLabel.Text = ", Use this setup dialog every time you want to get Tilly ready for your current o" +
    "perating style. Tab through the option descriptions and selections.";
            this.subtitleLabel.Enter += new System.EventHandler(this.SubtitleLabel_Enter);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(629, 293);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(114, 32);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label9
            // 
            this.label9.AccessibleName = "\"...\"";
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 292);
            this.label9.MaximumSize = new System.Drawing.Size(450, 4);
            this.label9.Name = "label9";
            this.label9.ReadOnly = true;
            this.label9.Size = new System.Drawing.Size(420, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = ", You\'re now ready to start. Close this Basic Options dialog, then enable CQ mode" +
    " using Ctrl E";
            this.label9.Enter += new System.EventHandler(this.Label9_Enter);
            // 
            // hunterButton
            // 
            this.hunterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hunterButton.Location = new System.Drawing.Point(630, 181);
            this.hunterButton.Name = "hunterButton";
            this.hunterButton.Size = new System.Drawing.Size(144, 27);
            this.hunterButton.TabIndex = 12;
            this.hunterButton.Text = "Hunter";
            this.hunterButton.UseVisualStyleBackColor = true;
            this.hunterButton.Click += new System.EventHandler(this.hunterButton_Click);
            // 
            // cqDxButton
            // 
            this.cqDxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cqDxButton.Location = new System.Drawing.Point(632, 93);
            this.cqDxButton.Name = "cqDxButton";
            this.cqDxButton.Size = new System.Drawing.Size(144, 27);
            this.cqDxButton.TabIndex = 6;
            this.cqDxButton.Text = "CQ DX";
            this.cqDxButton.UseVisualStyleBackColor = true;
            this.cqDxButton.Click += new System.EventHandler(this.cqDxButton_Click);
            // 
            // cqButton
            // 
            this.cqButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cqButton.Location = new System.Drawing.Point(487, 93);
            this.cqButton.Name = "cqButton";
            this.cqButton.Size = new System.Drawing.Size(134, 27);
            this.cqButton.TabIndex = 5;
            this.cqButton.Text = "CQ";
            this.cqButton.UseVisualStyleBackColor = true;
            this.cqButton.Click += new System.EventHandler(this.cqButton_Click);
            // 
            // label12
            // 
            this.label12.AccessibleName = "\"...\"";
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 92);
            this.label12.MaximumSize = new System.Drawing.Size(450, 4);
            this.label12.Name = "label12";
            this.label12.ReadOnly = true;
            this.label12.Size = new System.Drawing.Size(428, 22);
            this.label12.TabIndex = 4;
            this.label12.Text = ", When calling CQ, do you want to call \'CQ\' or \'CQ DX\'? (You can choose one or bo" +
    "th)";
            this.label12.Enter += new System.EventHandler(this.Label12_Enter);
            // 
            // Guide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 336);
            this.Controls.Add(this.cqDxButton);
            this.Controls.Add(this.cqButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.hunterButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.recentButton);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.potaButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nonDxButton);
            this.Controls.Add(this.dxButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listenButton);
            this.Controls.Add(this.callCqButton);
            this.Controls.Add(this.modeLabel);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 375);
            this.MinimumSize = new System.Drawing.Size(800, 375);
            this.Name = "Guide";
            this.Text = "Tilly Basic Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Guide_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Guide_FormClosed);
            this.Load += new System.EventHandler(this.Guide_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Guide_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox modeLabel;
        private System.Windows.Forms.CheckBox callCqButton;
        private System.Windows.Forms.CheckBox listenButton;
        private System.Windows.Forms.TextBox label2;
        private System.Windows.Forms.CheckBox dxButton;
        private System.Windows.Forms.CheckBox nonDxButton;
        private System.Windows.Forms.TextBox label4;
        private System.Windows.Forms.CheckBox potaButton;
        private System.Windows.Forms.TextBox label5;
        private System.Windows.Forms.CheckBox allButton;
        private System.Windows.Forms.CheckBox recentButton;
        private System.Windows.Forms.TextBox subtitleLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox label9;
        private System.Windows.Forms.CheckBox hunterButton;
        private System.Windows.Forms.CheckBox cqDxButton;
        private System.Windows.Forms.CheckBox cqButton;
        private System.Windows.Forms.TextBox label12;
    }
}