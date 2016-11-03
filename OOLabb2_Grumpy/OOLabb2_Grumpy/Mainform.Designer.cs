namespace OOLabb2_Grumpy
{
    partial class MainForm
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
            this.removeButton = new System.Windows.Forms.Button();
            this.mergeButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.womanRadio = new System.Windows.Forms.RadioButton();
            this.manRadio = new System.Windows.Forms.RadioButton();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.lastnameTextbox = new System.Windows.Forms.TextBox();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.firstnameTextbox = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Label();
            this.personListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(174, 346);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(56, 27);
            this.removeButton.TabIndex = 23;
            this.removeButton.Text = "Kill";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // mergeButton
            // 
            this.mergeButton.Location = new System.Drawing.Point(113, 346);
            this.mergeButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(56, 27);
            this.mergeButton.TabIndex = 22;
            this.mergeButton.Text = "Merge";
            this.mergeButton.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(53, 346);
            this.sortButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(56, 27);
            this.sortButton.TabIndex = 21;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(86, 131);
            this.createButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(113, 19);
            this.createButton.TabIndex = 20;
            this.createButton.Text = "Make a human";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // womanRadio
            // 
            this.womanRadio.AutoSize = true;
            this.womanRadio.Location = new System.Drawing.Point(166, 100);
            this.womanRadio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.womanRadio.Name = "womanRadio";
            this.womanRadio.Size = new System.Drawing.Size(62, 17);
            this.womanRadio.TabIndex = 19;
            this.womanRadio.TabStop = true;
            this.womanRadio.Text = "Woman";
            this.womanRadio.UseVisualStyleBackColor = true;
            this.womanRadio.CheckedChanged += new System.EventHandler(this.womanRadio_CheckedChanged);
            // 
            // manRadio
            // 
            this.manRadio.AutoSize = true;
            this.manRadio.Location = new System.Drawing.Point(78, 100);
            this.manRadio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.manRadio.Name = "manRadio";
            this.manRadio.Size = new System.Drawing.Size(46, 17);
            this.manRadio.TabIndex = 18;
            this.manRadio.TabStop = true;
            this.manRadio.Text = "Man";
            this.manRadio.UseVisualStyleBackColor = true;
            this.manRadio.CheckedChanged += new System.EventHandler(this.manRadio_CheckedChanged);
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(41, 68);
            this.lastnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(59, 13);
            this.lastnameLabel.TabIndex = 17;
            this.lastnameLabel.Text = "Last name:";
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.Location = new System.Drawing.Point(104, 65);
            this.lastnameTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.Size = new System.Drawing.Size(147, 20);
            this.lastnameTextbox.TabIndex = 16;
            this.lastnameTextbox.TextChanged += new System.EventHandler(this.lastnameTextbox_TextChanged);
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(41, 45);
            this.firstnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(58, 13);
            this.firstnameLabel.TabIndex = 15;
            this.firstnameLabel.Text = "First name:";
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.Location = new System.Drawing.Point(104, 42);
            this.firstnameTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(147, 20);
            this.firstnameTextbox.TabIndex = 14;
            this.firstnameTextbox.TextChanged += new System.EventHandler(this.firstnameTextbox_TextChanged);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(83, 14);
            this.header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(130, 17);
            this.header.TabIndex = 13;
            this.header.Text = "Create new human:";
            // 
            // personListbox
            // 
            this.personListbox.FormattingEnabled = true;
            this.personListbox.Location = new System.Drawing.Point(9, 169);
            this.personListbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.personListbox.Name = "personListbox";
            this.personListbox.Size = new System.Drawing.Size(272, 160);
            this.personListbox.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 391);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.mergeButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.womanRadio);
            this.Controls.Add(this.manRadio);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.lastnameTextbox);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.firstnameTextbox);
            this.Controls.Add(this.header);
            this.Controls.Add(this.personListbox);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "People";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.RadioButton womanRadio;
        private System.Windows.Forms.RadioButton manRadio;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.TextBox lastnameTextbox;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.TextBox firstnameTextbox;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.ListBox personListbox;
    }
}

