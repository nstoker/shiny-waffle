namespace shiney_waffle
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.errorList = new System.Windows.Forms.TableLayoutPanel();
            this.commandFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.newScript = new System.Windows.Forms.Button();
            this.loadScript = new System.Windows.Forms.Button();
            this.saveScript = new System.Windows.Forms.Button();
            this.runScript = new System.Windows.Forms.Button();
            this.richTextBoxWithLineNumbers1 = new shiney_waffle.RichTextBoxWithLineNumbers();
            this.statusDisplay = new System.Windows.Forms.RichTextBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.errorList.SuspendLayout();
            this.commandFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(985, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // errorList
            // 
            this.errorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorList.ColumnCount = 3;
            this.errorList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.errorList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.errorList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.errorList.Controls.Add(this.commandFlow, 0, 0);
            this.errorList.Controls.Add(this.richTextBoxWithLineNumbers1, 1, 0);
            this.errorList.Controls.Add(this.statusDisplay, 2, 0);
            this.errorList.Location = new System.Drawing.Point(0, 0);
            this.errorList.Name = "errorList";
            this.errorList.RowCount = 1;
            this.errorList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.errorList.Size = new System.Drawing.Size(985, 421);
            this.errorList.TabIndex = 3;
            // 
            // commandFlow
            // 
            this.commandFlow.AutoScroll = true;
            this.commandFlow.AutoSize = true;
            this.commandFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.commandFlow.Controls.Add(this.newScript);
            this.commandFlow.Controls.Add(this.loadScript);
            this.commandFlow.Controls.Add(this.saveScript);
            this.commandFlow.Controls.Add(this.runScript);
            this.commandFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.commandFlow.Location = new System.Drawing.Point(3, 3);
            this.commandFlow.MaximumSize = new System.Drawing.Size(105, 0);
            this.commandFlow.MinimumSize = new System.Drawing.Size(100, 100);
            this.commandFlow.Name = "commandFlow";
            this.commandFlow.Size = new System.Drawing.Size(100, 415);
            this.commandFlow.TabIndex = 0;
            // 
            // newScript
            // 
            this.newScript.Location = new System.Drawing.Point(3, 3);
            this.newScript.Name = "newScript";
            this.newScript.Size = new System.Drawing.Size(90, 30);
            this.newScript.TabIndex = 3;
            this.newScript.Text = "New Script";
            this.newScript.UseVisualStyleBackColor = true;
            this.newScript.Click += new System.EventHandler(this.newScript_Click);
            // 
            // loadScript
            // 
            this.loadScript.Location = new System.Drawing.Point(3, 39);
            this.loadScript.Name = "loadScript";
            this.loadScript.Size = new System.Drawing.Size(90, 30);
            this.loadScript.TabIndex = 0;
            this.loadScript.Text = "Load Script";
            this.loadScript.UseVisualStyleBackColor = true;
            this.loadScript.Click += new System.EventHandler(this.openScript_Click);
            // 
            // saveScript
            // 
            this.saveScript.Location = new System.Drawing.Point(3, 75);
            this.saveScript.Name = "saveScript";
            this.saveScript.Size = new System.Drawing.Size(90, 30);
            this.saveScript.TabIndex = 1;
            this.saveScript.Text = "Save Script";
            this.saveScript.UseVisualStyleBackColor = true;
            this.saveScript.Click += new System.EventHandler(this.saveScript_Click);
            // 
            // runScript
            // 
            this.runScript.Location = new System.Drawing.Point(3, 111);
            this.runScript.Name = "runScript";
            this.runScript.Size = new System.Drawing.Size(90, 30);
            this.runScript.TabIndex = 4;
            this.runScript.Text = "Run Script";
            this.runScript.UseVisualStyleBackColor = true;
            this.runScript.Click += new System.EventHandler(this.runScript_Click);
            // 
            // richTextBoxWithLineNumbers1
            // 
            this.richTextBoxWithLineNumbers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxWithLineNumbers1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxWithLineNumbers1.Location = new System.Drawing.Point(110, 4);
            this.richTextBoxWithLineNumbers1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxWithLineNumbers1.Name = "richTextBoxWithLineNumbers1";
            this.richTextBoxWithLineNumbers1.Size = new System.Drawing.Size(431, 413);
            this.richTextBoxWithLineNumbers1.TabIndex = 1;
            // 
            // statusDisplay
            // 
            this.statusDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.statusDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusDisplay.Location = new System.Drawing.Point(548, 3);
            this.statusDisplay.Name = "statusDisplay";
            this.statusDisplay.ReadOnly = true;
            this.statusDisplay.Size = new System.Drawing.Size(434, 415);
            this.statusDisplay.TabIndex = 2;
            this.statusDisplay.Text = "";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 446);
            this.Controls.Add(this.errorList);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Shiny-Waffle";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.errorList.ResumeLayout(false);
            this.errorList.PerformLayout();
            this.commandFlow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel errorList;
        private System.Windows.Forms.FlowLayoutPanel commandFlow;
        private System.Windows.Forms.Button loadScript;
        private System.Windows.Forms.Button saveScript;
        private RichTextBoxWithLineNumbers richTextBoxWithLineNumbers1;
        private System.Windows.Forms.Button newScript;
        private System.Windows.Forms.Button runScript;
        private System.Windows.Forms.RichTextBox statusDisplay;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

