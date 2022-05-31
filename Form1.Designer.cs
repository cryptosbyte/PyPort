
namespace SanAndreasCheats
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pythonInput = new ScintillaNET.Scintilla();
            this.RunScriptImgBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.console1 = new ConsoleControl.ConsoleControl();
            this.SuspendLayout();
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(326, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 0;
            this.guna2ControlBox3.Click += new System.EventHandler(this.guna2ControlBox3_Click);
            // 
            // guna2ControlBox4
            // 
            this.guna2ControlBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.guna2ControlBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.guna2ControlBox4.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox4.Location = new System.Drawing.Point(368, 0);
            this.guna2ControlBox4.Name = "guna2ControlBox4";
            this.guna2ControlBox4.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox4.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(249, 29);
            this.guna2Panel1.TabIndex = 2;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // pythonInput
            // 
            this.pythonInput.AutoCMaxHeight = 9;
            this.pythonInput.BiDirectionality = ScintillaNET.BiDirectionalDisplayType.Disabled;
            this.pythonInput.CaretForeColor = System.Drawing.Color.White;
            this.pythonInput.CaretLineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.pythonInput.CaretLineVisible = true;
            this.pythonInput.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pythonInput.LexerName = null;
            this.pythonInput.Location = new System.Drawing.Point(5, 32);
            this.pythonInput.Name = "pythonInput";
            this.pythonInput.ScrollWidth = 156;
            this.pythonInput.Size = new System.Drawing.Size(321, 208);
            this.pythonInput.TabIndents = true;
            this.pythonInput.TabIndex = 3;
            this.pythonInput.Text = "print(\"Welcome to Python\")";
            this.pythonInput.UseRightToLeftReadingLayout = false;
            this.pythonInput.WrapMode = ScintillaNET.WrapMode.None;
            // 
            // RunScriptImgBtn
            // 
            this.RunScriptImgBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.RunScriptImgBtn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.RunScriptImgBtn.Image = ((System.Drawing.Image)(resources.GetObject("RunScriptImgBtn.Image")));
            this.RunScriptImgBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.RunScriptImgBtn.ImageRotate = 0F;
            this.RunScriptImgBtn.Location = new System.Drawing.Point(331, 36);
            this.RunScriptImgBtn.Name = "RunScriptImgBtn";
            this.RunScriptImgBtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.RunScriptImgBtn.Size = new System.Drawing.Size(76, 68);
            this.RunScriptImgBtn.TabIndex = 5;
            this.RunScriptImgBtn.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(80, 80);
            this.guna2ImageButton2.Location = new System.Drawing.Point(332, 110);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(76, 68);
            this.guna2ImageButton2.TabIndex = 6;
            // 
            // console1
            // 
            this.console1.IsInputEnabled = true;
            this.console1.Location = new System.Drawing.Point(5, 250);
            this.console1.Name = "console1";
            this.console1.SendKeyboardCommandsToProcess = false;
            this.console1.ShowDiagnostics = false;
            this.console1.Size = new System.Drawing.Size(402, 122);
            this.console1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(413, 383);
            this.Controls.Add(this.console1);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.RunScriptImgBtn);
            this.Controls.Add(this.pythonInput);
            this.Controls.Add(this.guna2ControlBox4);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "5";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox4;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private ScintillaNET.Scintilla pythonInput;
        private Guna.UI2.WinForms.Guna2ImageButton RunScriptImgBtn;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private ConsoleControl.ConsoleControl console1;
    }
}

