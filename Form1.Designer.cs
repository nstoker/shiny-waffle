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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.commandFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.newScript = new System.Windows.Forms.Button();
            this.openScript = new System.Windows.Forms.Button();
            this.saveScript = new System.Windows.Forms.Button();
            this.testScript = new System.Windows.Forms.Button();
            this.richTextBoxWithLineNumbers1 = new shiney_waffle.RichTextBoxWithLineNumbers();
            this.tableLayoutPanel1.SuspendLayout();
            this.commandFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 319);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(627, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.commandFlow, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxWithLineNumbers1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.73754F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 316);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // commandFlow
            // 
            this.commandFlow.AutoScroll = true;
            this.commandFlow.AutoSize = true;
            this.commandFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.commandFlow.Controls.Add(this.newScript);
            this.commandFlow.Controls.Add(this.openScript);
            this.commandFlow.Controls.Add(this.saveScript);
            this.commandFlow.Controls.Add(this.testScript);
            this.commandFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.commandFlow.Location = new System.Drawing.Point(3, 3);
            this.commandFlow.MaximumSize = new System.Drawing.Size(105, 0);
            this.commandFlow.MinimumSize = new System.Drawing.Size(100, 100);
            this.commandFlow.Name = "commandFlow";
            this.commandFlow.Size = new System.Drawing.Size(100, 310);
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
            // openScript
            // 
            this.openScript.Location = new System.Drawing.Point(3, 39);
            this.openScript.Name = "openScript";
            this.openScript.Size = new System.Drawing.Size(90, 30);
            this.openScript.TabIndex = 0;
            this.openScript.Text = "Open";
            this.openScript.UseVisualStyleBackColor = true;
            this.openScript.Click += new System.EventHandler(this.openScript_Click);
            // 
            // saveScript
            // 
            this.saveScript.Location = new System.Drawing.Point(3, 75);
            this.saveScript.Name = "saveScript";
            this.saveScript.Size = new System.Drawing.Size(90, 30);
            this.saveScript.TabIndex = 1;
            this.saveScript.Text = "Save";
            this.saveScript.UseVisualStyleBackColor = true;
            this.saveScript.Click += new System.EventHandler(this.saveScript_Click);
            // 
            // testScript
            // 
            this.testScript.Location = new System.Drawing.Point(3, 111);
            this.testScript.Name = "testScript";
            this.testScript.Size = new System.Drawing.Size(90, 30);
            this.testScript.TabIndex = 2;
            this.testScript.Text = "Test";
            this.testScript.UseVisualStyleBackColor = true;
            this.testScript.Click += new System.EventHandler(this.testScript_Click);
            // 
            // richTextBoxWithLineNumbers1
            // 
            this.richTextBoxWithLineNumbers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxWithLineNumbers1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxWithLineNumbers1.Location = new System.Drawing.Point(110, 4);
            this.richTextBoxWithLineNumbers1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxWithLineNumbers1.Name = "richTextBoxWithLineNumbers1";
            this.richTextBoxWithLineNumbers1.Size = new System.Drawing.Size(493, 308);
            this.richTextBoxWithLineNumbers1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 341);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Shiny-Waffle";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.commandFlow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel commandFlow;
        private System.Windows.Forms.Button openScript;
        private System.Windows.Forms.Button saveScript;
        private System.Windows.Forms.Button testScript;
        private RichTextBoxWithLineNumbers richTextBoxWithLineNumbers1;
        private System.Windows.Forms.Button newScript;
    }
}

