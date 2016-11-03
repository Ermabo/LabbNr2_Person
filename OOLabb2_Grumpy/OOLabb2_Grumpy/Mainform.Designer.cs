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
            this.removeButton.Location = new System.Drawing.Point(232, 426);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 33);
            this.removeButton.TabIndex = 23;
            this.removeButton.Text = "Kill";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // mergeButton
            // 
            this.mergeButton.Location = new System.Drawing.Point(151, 426);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(75, 33);
            this.mergeButton.TabIndex = 22;
            this.mergeButton.Text = "Merge";
            this.mergeButton.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(70, 426);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 33);
            this.sortButton.TabIndex = 21;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(115, 161);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(150, 23);
            this.createButton.TabIndex = 20;
            this.createButton.Text = "Make a human";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // womanRadio
            // 
            this.womanRadio.AutoSize = true;
            this.womanRadio.Location = new System.Drawing.Point(221, 123);
            this.womanRadio.Name = "womanRadio";
            this.womanRadio.Size = new System.Drawing.Size(77, 21);
            this.womanRadio.TabIndex = 19;
            this.womanRadio.TabStop = true;
            this.womanRadio.Text = "Woman";
            this.womanRadio.UseVisualStyleBackColor = true;
            this.womanRadio.CheckedChanged += new System.EventHandler(this.womanRadio_CheckedChanged);
            // 
            // manRadio
            // 
            this.manRadio.AutoSize = true;
            this.manRadio.Location = new System.Drawing.Point(104, 123);
            this.manRadio.Name = "manRadio";
            this.manRadio.Size = new System.Drawing.Size(56, 21);
            this.manRadio.TabIndex = 18;
            this.manRadio.TabStop = true;
            this.manRadio.Text = "Man";
            this.manRadio.UseVisualStyleBackColor = true;
            this.manRadio.CheckedChanged += new System.EventHandler(this.manRadio_CheckedChanged);
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(55, 83);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(78, 17);
            this.lastnameLabel.TabIndex = 17;
            this.lastnameLabel.Text = "Last name:";
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.Location = new System.Drawing.Point(139, 80);
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.Size = new System.Drawing.Size(194, 22);
            this.lastnameTextbox.TabIndex = 16;
            this.lastnameTextbox.TextChanged += new System.EventHandler(this.lastnameTextbox_TextChanged);
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(55, 55);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(78, 17);
            this.firstnameLabel.TabIndex = 15;
            this.firstnameLabel.Text = "First name:";
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.Location = new System.Drawing.Point(139, 52);
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(194, 22);
            this.firstnameTextbox.TabIndex = 14;
            this.firstnameTextbox.TextChanged += new System.EventHandler(this.firstnameTextbox_TextChanged);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(111, 17);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(154, 20);
            this.header.TabIndex = 13;
            this.header.Text = "Create new human:";
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 16;
            this.listbox.Location = new System.Drawing.Point(12, 208);
            this.listbox.Name = "listbox";
            this.listbox.ScrollAlwaysVisible = true;
            this.listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listbox.Size = new System.Drawing.Size(361, 196);
            this.listbox.TabIndex = 12;
            this.listbox.SelectedValueChanged += new System.EventHandler(this.listbox_SelectedValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 481);
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

