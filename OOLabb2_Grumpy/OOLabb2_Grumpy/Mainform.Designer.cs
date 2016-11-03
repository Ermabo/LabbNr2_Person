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
            this.listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(261, 532);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(84, 41);
            this.removeButton.TabIndex = 23;
            this.removeButton.Text = "Kill";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // mergeButton
            // 
            this.mergeButton.Location = new System.Drawing.Point(170, 532);
            this.mergeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(84, 41);
            this.mergeButton.TabIndex = 22;
            this.mergeButton.Text = "Merge";
            this.mergeButton.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(79, 532);
            this.sortButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(84, 41);
            this.sortButton.TabIndex = 21;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(129, 201);
            this.createButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(169, 29);
            this.createButton.TabIndex = 20;
            this.createButton.Text = "Make a human";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // womanRadio
            // 
            this.womanRadio.AutoSize = true;
            this.womanRadio.Location = new System.Drawing.Point(249, 154);
            this.womanRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.womanRadio.Name = "womanRadio";
            this.womanRadio.Size = new System.Drawing.Size(89, 24);
            this.womanRadio.TabIndex = 19;
            this.womanRadio.TabStop = true;
            this.womanRadio.Text = "Woman";
            this.womanRadio.UseVisualStyleBackColor = true;
            // 
            // manRadio
            // 
            this.manRadio.AutoSize = true;
            this.manRadio.Location = new System.Drawing.Point(117, 154);
            this.manRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manRadio.Name = "manRadio";
            this.manRadio.Size = new System.Drawing.Size(65, 24);
            this.manRadio.TabIndex = 18;
            this.manRadio.TabStop = true;
            this.manRadio.Text = "Man";
            this.manRadio.UseVisualStyleBackColor = true;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(62, 104);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(88, 20);
            this.lastnameLabel.TabIndex = 17;
            this.lastnameLabel.Text = "Last name:";
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.Location = new System.Drawing.Point(156, 100);
            this.lastnameTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.Size = new System.Drawing.Size(218, 26);
            this.lastnameTextbox.TabIndex = 16;
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(62, 69);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(88, 20);
            this.firstnameLabel.TabIndex = 15;
            this.firstnameLabel.Text = "First name:";
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.Location = new System.Drawing.Point(156, 65);
            this.firstnameTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(218, 26);
            this.firstnameTextbox.TabIndex = 14;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(125, 21);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(183, 25);
            this.header.TabIndex = 13;
            this.header.Text = "Create new human:";
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 20;
            this.listbox.Location = new System.Drawing.Point(14, 260);
            this.listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(406, 244);
            this.listbox.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 601);
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
            this.Controls.Add(this.listbox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.ListBox listbox;
    }
}

