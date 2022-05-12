
namespace Female_Pyro_Model_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControls = new System.Windows.Forms.TabControl();
            this.viewmodelPage = new System.Windows.Forms.TabPage();
            this.packBtn = new System.Windows.Forms.Button();
            this.exportLocaBtn = new System.Windows.Forms.Button();
            this.gameLocaBtn = new System.Windows.Forms.Button();
            this.packingText = new System.Windows.Forms.Label();
            this.exportLabel = new System.Windows.Forms.Label();
            this.gameLabel = new System.Windows.Forms.Label();
            this.exportTextBox = new System.Windows.Forms.TextBox();
            this.gameTextBox = new System.Windows.Forms.TextBox();
            this.packProgressBar = new System.Windows.Forms.ProgressBar();
            this.paintLabel = new System.Windows.Forms.Label();
            this.cosmeticLabel = new System.Windows.Forms.Label();
            this.paintListBox = new System.Windows.Forms.CheckedListBox();
            this.cosmeticListBox = new System.Windows.Forms.CheckedListBox();
            this.aboutPage = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.creditAlaxe = new System.Windows.Forms.LinkLabel();
            this.creditLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.exportBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControls.SuspendLayout();
            this.viewmodelPage.SuspendLayout();
            this.aboutPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControls
            // 
            this.tabControls.Controls.Add(this.viewmodelPage);
            this.tabControls.Controls.Add(this.aboutPage);
            this.tabControls.Location = new System.Drawing.Point(-3, 2);
            this.tabControls.Name = "tabControls";
            this.tabControls.SelectedIndex = 0;
            this.tabControls.Size = new System.Drawing.Size(507, 436);
            this.tabControls.TabIndex = 0;
            // 
            // viewmodelPage
            // 
            this.viewmodelPage.Controls.Add(this.packBtn);
            this.viewmodelPage.Controls.Add(this.exportLocaBtn);
            this.viewmodelPage.Controls.Add(this.gameLocaBtn);
            this.viewmodelPage.Controls.Add(this.packingText);
            this.viewmodelPage.Controls.Add(this.exportLabel);
            this.viewmodelPage.Controls.Add(this.gameLabel);
            this.viewmodelPage.Controls.Add(this.exportTextBox);
            this.viewmodelPage.Controls.Add(this.gameTextBox);
            this.viewmodelPage.Controls.Add(this.packProgressBar);
            this.viewmodelPage.Controls.Add(this.paintLabel);
            this.viewmodelPage.Controls.Add(this.cosmeticLabel);
            this.viewmodelPage.Controls.Add(this.paintListBox);
            this.viewmodelPage.Controls.Add(this.cosmeticListBox);
            this.viewmodelPage.Location = new System.Drawing.Point(4, 22);
            this.viewmodelPage.Name = "viewmodelPage";
            this.viewmodelPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewmodelPage.Size = new System.Drawing.Size(499, 410);
            this.viewmodelPage.TabIndex = 1;
            this.viewmodelPage.Text = "Viewmodel";
            this.viewmodelPage.UseVisualStyleBackColor = true;
            // 
            // packBtn
            // 
            this.packBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packBtn.Location = new System.Drawing.Point(427, 345);
            this.packBtn.Name = "packBtn";
            this.packBtn.Size = new System.Drawing.Size(62, 49);
            this.packBtn.TabIndex = 12;
            this.packBtn.Text = "Pack";
            this.packBtn.UseVisualStyleBackColor = true;
            this.packBtn.Click += new System.EventHandler(this.packBtn_Click);
            // 
            // exportLocaBtn
            // 
            this.exportLocaBtn.Location = new System.Drawing.Point(395, 372);
            this.exportLocaBtn.Name = "exportLocaBtn";
            this.exportLocaBtn.Size = new System.Drawing.Size(26, 23);
            this.exportLocaBtn.TabIndex = 11;
            this.exportLocaBtn.Text = "...";
            this.exportLocaBtn.UseVisualStyleBackColor = true;
            this.exportLocaBtn.Click += new System.EventHandler(this.exportLocaBtn_Click);
            // 
            // gameLocaBtn
            // 
            this.gameLocaBtn.Location = new System.Drawing.Point(395, 346);
            this.gameLocaBtn.Name = "gameLocaBtn";
            this.gameLocaBtn.Size = new System.Drawing.Size(26, 23);
            this.gameLocaBtn.TabIndex = 10;
            this.gameLocaBtn.Text = "...";
            this.gameLocaBtn.UseVisualStyleBackColor = true;
            this.gameLocaBtn.Click += new System.EventHandler(this.gameLocaBtn_Click);
            // 
            // packingText
            // 
            this.packingText.AutoSize = true;
            this.packingText.Location = new System.Drawing.Point(395, 324);
            this.packingText.Name = "packingText";
            this.packingText.Size = new System.Drawing.Size(0, 13);
            this.packingText.TabIndex = 9;
            // 
            // exportLabel
            // 
            this.exportLabel.AutoSize = true;
            this.exportLabel.Location = new System.Drawing.Point(6, 377);
            this.exportLabel.Name = "exportLabel";
            this.exportLabel.Size = new System.Drawing.Size(81, 13);
            this.exportLabel.TabIndex = 8;
            this.exportLabel.Text = "Export Location";
            this.exportLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(8, 351);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(79, 13);
            this.gameLabel.TabIndex = 7;
            this.gameLabel.Text = "Game Location";
            this.gameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // exportTextBox
            // 
            this.exportTextBox.Location = new System.Drawing.Point(91, 374);
            this.exportTextBox.Name = "exportTextBox";
            this.exportTextBox.Size = new System.Drawing.Size(298, 20);
            this.exportTextBox.TabIndex = 6;
            // 
            // gameTextBox
            // 
            this.gameTextBox.Location = new System.Drawing.Point(91, 348);
            this.gameTextBox.Name = "gameTextBox";
            this.gameTextBox.Size = new System.Drawing.Size(298, 20);
            this.gameTextBox.TabIndex = 5;
            // 
            // packProgressBar
            // 
            this.packProgressBar.Location = new System.Drawing.Point(91, 319);
            this.packProgressBar.Name = "packProgressBar";
            this.packProgressBar.Size = new System.Drawing.Size(298, 23);
            this.packProgressBar.TabIndex = 4;
            // 
            // paintLabel
            // 
            this.paintLabel.AutoSize = true;
            this.paintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paintLabel.Location = new System.Drawing.Point(226, 3);
            this.paintLabel.Name = "paintLabel";
            this.paintLabel.Size = new System.Drawing.Size(46, 18);
            this.paintLabel.TabIndex = 3;
            this.paintLabel.Text = "Paint";
            // 
            // cosmeticLabel
            // 
            this.cosmeticLabel.AutoSize = true;
            this.cosmeticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cosmeticLabel.Location = new System.Drawing.Point(11, 3);
            this.cosmeticLabel.Name = "cosmeticLabel";
            this.cosmeticLabel.Size = new System.Drawing.Size(80, 18);
            this.cosmeticLabel.TabIndex = 2;
            this.cosmeticLabel.Text = "Cosmetic";
            // 
            // paintListBox
            // 
            this.paintListBox.CheckOnClick = true;
            this.paintListBox.FormattingEnabled = true;
            this.paintListBox.Location = new System.Drawing.Point(229, 24);
            this.paintListBox.Name = "paintListBox";
            this.paintListBox.Size = new System.Drawing.Size(260, 289);
            this.paintListBox.TabIndex = 1;
            this.paintListBox.SelectedIndexChanged += new System.EventHandler(this.paintListBox_SelectedIndexChanged);
            // 
            // cosmeticListBox
            // 
            this.cosmeticListBox.CheckOnClick = true;
            this.cosmeticListBox.FormattingEnabled = true;
            this.cosmeticListBox.Location = new System.Drawing.Point(11, 24);
            this.cosmeticListBox.Name = "cosmeticListBox";
            this.cosmeticListBox.Size = new System.Drawing.Size(209, 289);
            this.cosmeticListBox.TabIndex = 0;
            this.cosmeticListBox.SelectedIndexChanged += new System.EventHandler(this.cosmeticListBox_SelectedIndexChanged);
            // 
            // aboutPage
            // 
            this.aboutPage.Controls.Add(this.label3);
            this.aboutPage.Controls.Add(this.linkLabel1);
            this.aboutPage.Controls.Add(this.creditAlaxe);
            this.aboutPage.Controls.Add(this.creditLabel);
            this.aboutPage.Controls.Add(this.pictureBox1);
            this.aboutPage.Location = new System.Drawing.Point(4, 22);
            this.aboutPage.Name = "aboutPage";
            this.aboutPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutPage.Size = new System.Drawing.Size(499, 410);
            this.aboutPage.TabIndex = 2;
            this.aboutPage.Text = "About";
            this.aboutPage.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(178, 285);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(167, 24);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Check for updates!";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // creditAlaxe
            // 
            this.creditAlaxe.AutoSize = true;
            this.creditAlaxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditAlaxe.Location = new System.Drawing.Point(135, 239);
            this.creditAlaxe.Name = "creditAlaxe";
            this.creditAlaxe.Size = new System.Drawing.Size(166, 24);
            this.creditAlaxe.TabIndex = 2;
            this.creditAlaxe.TabStop = true;
            this.creditAlaxe.Text = "Visit my workshop!";
            this.creditAlaxe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.creditAlaxe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditAlaxe_LinkClicked);
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.Location = new System.Drawing.Point(135, 55);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(218, 40);
            this.creditLabel.TabIndex = 1;
            this.creditLabel.Text = "Programmed by Sour Dani\r\nModels by Alaxe";
            this.creditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Female_Pyro_Model_Manager.Properties.Resources.alaxe;
            this.pictureBox1.Location = new System.Drawing.Point(6, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tip: Rail Spikes can be selected along with other cosmetics.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(502, 434);
            this.Controls.Add(this.tabControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Female Pyro Model Manager";
            this.tabControls.ResumeLayout(false);
            this.viewmodelPage.ResumeLayout(false);
            this.viewmodelPage.PerformLayout();
            this.aboutPage.ResumeLayout(false);
            this.aboutPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControls;
        private System.Windows.Forms.TabPage viewmodelPage;
        private System.Windows.Forms.CheckedListBox paintListBox;
        private System.Windows.Forms.CheckedListBox cosmeticListBox;
        private System.Windows.Forms.Label paintLabel;
        private System.Windows.Forms.Label cosmeticLabel;
        private System.Windows.Forms.ProgressBar packProgressBar;
        private System.Windows.Forms.Label packingText;
        private System.Windows.Forms.Label exportLabel;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.TextBox exportTextBox;
        private System.Windows.Forms.TextBox gameTextBox;
        private System.Windows.Forms.FolderBrowserDialog gameBrowser;
        private System.Windows.Forms.Button packBtn;
        private System.Windows.Forms.Button exportLocaBtn;
        private System.Windows.Forms.Button gameLocaBtn;
        private System.Windows.Forms.FolderBrowserDialog exportBrowser;
        private System.Windows.Forms.TabPage aboutPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.LinkLabel creditAlaxe;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
    }
}

