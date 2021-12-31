namespace KeyboardCleaner {
    partial class KeyboardCleaner {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MessageLabel = new System.Windows.Forms.Label();
            this.UnlockInstructionsLabel = new System.Windows.Forms.Label();
            this.LockLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // MessageLabel
            //
            this.MessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageLabel.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.White;
            this.MessageLabel.Location = new System.Drawing.Point(0, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(874, 522);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "Keyboard Cleaner Activated!";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // UnlockInstructionsLabel
            //
            this.UnlockInstructionsLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UnlockInstructionsLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnlockInstructionsLabel.ForeColor = System.Drawing.Color.White;
            this.UnlockInstructionsLabel.Location = new System.Drawing.Point(0, 499);
            this.UnlockInstructionsLabel.Name = "UnlockInstructionsLabel";
            this.UnlockInstructionsLabel.Size = new System.Drawing.Size(874, 23);
            this.UnlockInstructionsLabel.TabIndex = 1;
            this.UnlockInstructionsLabel.Text = "Hold Right Click For 1 Second And Release To Unlock";
            this.UnlockInstructionsLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            //
            // LockLabel
            //
            this.LockLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockLabel.ForeColor = System.Drawing.Color.White;
            this.LockLabel.Location = new System.Drawing.Point(0, 410);
            this.LockLabel.Name = "LockLabel";
            this.LockLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.LockLabel.Size = new System.Drawing.Size(874, 89);
            this.LockLabel.TabIndex = 2;
            this.LockLabel.Text = "🔒";
            this.LockLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            //
            // KeyboardCleaner
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(874, 537);
            this.Controls.Add(this.LockLabel);
            this.Controls.Add(this.UnlockInstructionsLabel);
            this.Controls.Add(this.MessageLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KeyboardCleaner";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.Text = "KeyboardCleaner";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label UnlockInstructionsLabel;
        private System.Windows.Forms.Label LockLabel;
    }
}
