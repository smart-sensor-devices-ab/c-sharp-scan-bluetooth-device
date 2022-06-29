namespace Scan_BLE_devices
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.submit_cmd = new System.Windows.Forms.Button();
            this.output_data = new System.Windows.Forms.RichTextBox();
            this.lbl_test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(221, 33);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnect.TabIndex = 1;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click_1);
            // 
            // submit_cmd
            // 
            this.submit_cmd.Location = new System.Drawing.Point(410, 34);
            this.submit_cmd.Name = "submit_cmd";
            this.submit_cmd.Size = new System.Drawing.Size(75, 23);
            this.submit_cmd.TabIndex = 2;
            this.submit_cmd.Text = "Scan ";
            this.submit_cmd.UseVisualStyleBackColor = true;
            this.submit_cmd.Click += new System.EventHandler(this.submit_cmd_Click_1);
            // 
            // output_data
            // 
            this.output_data.Location = new System.Drawing.Point(29, 92);
            this.output_data.Name = "output_data";
            this.output_data.Size = new System.Drawing.Size(456, 346);
            this.output_data.TabIndex = 3;
            this.output_data.Text = "";
            this.output_data.TextChanged += new System.EventHandler(this.output_data_TextChanged);
            // 
            // lbl_test
            // 
            this.lbl_test.AutoSize = true;
            this.lbl_test.Location = new System.Drawing.Point(29, 76);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(0, 13);
            this.lbl_test.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.lbl_test);
            this.Controls.Add(this.output_data);
            this.Controls.Add(this.submit_cmd);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button submit_cmd;
        private System.Windows.Forms.RichTextBox output_data;
        private System.Windows.Forms.Label lbl_test;
    }
}

