namespace FuncularLabs.AiDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            photocropper = new TabPage();
            originfilename = new Label();
            croppedfilename = new Label();
            label1 = new Label();
            autocroppedpictureBox = new PictureBox();
            originalpictureBox = new PictureBox();
            saveBtn1 = new Button();
            autocropBtn = new Button();
            chooseBtn = new Button();
            textsummarizer = new TabPage();
            saveBtn2 = new Button();
            autosummarizeBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            summaryTextBox = new RichTextBox();
            originalTextBox = new RichTextBox();
            grammarcorrector = new TabPage();
            saveBtn3 = new Button();
            autocorrectBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            correctedTextBox = new RichTextBox();
            correctorOriginalTextBox = new RichTextBox();
            tabControl1.SuspendLayout();
            photocropper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)autocroppedpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)originalpictureBox).BeginInit();
            textsummarizer.SuspendLayout();
            grammarcorrector.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(photocropper);
            tabControl1.Controls.Add(textsummarizer);
            tabControl1.Controls.Add(grammarcorrector);
            tabControl1.Location = new Point(84, 50);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(600, 480);
            tabControl1.TabIndex = 0;
            // 
            // photocropper
            // 
            photocropper.Controls.Add(originfilename);
            photocropper.Controls.Add(croppedfilename);
            photocropper.Controls.Add(label1);
            photocropper.Controls.Add(autocroppedpictureBox);
            photocropper.Controls.Add(originalpictureBox);
            photocropper.Controls.Add(saveBtn1);
            photocropper.Controls.Add(autocropBtn);
            photocropper.Controls.Add(chooseBtn);
            photocropper.Location = new Point(4, 24);
            photocropper.Name = "photocropper";
            photocropper.Padding = new Padding(3);
            photocropper.Size = new Size(592, 452);
            photocropper.TabIndex = 0;
            photocropper.Text = "Photo Cropper";
            photocropper.UseVisualStyleBackColor = true;
            // 
            // originfilename
            // 
            originfilename.AutoSize = true;
            originfilename.Font = new Font("Segoe UI", 11F);
            originfilename.Location = new Point(87, 330);
            originfilename.Name = "originfilename";
            originfilename.Size = new Size(0, 20);
            originfilename.TabIndex = 3;
            // 
            // croppedfilename
            // 
            croppedfilename.AutoSize = true;
            croppedfilename.Font = new Font("Segoe UI", 11F);
            croppedfilename.Location = new Point(326, 305);
            croppedfilename.Name = "croppedfilename";
            croppedfilename.Size = new Size(0, 20);
            croppedfilename.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(86, 302);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "Original:";
            // 
            // autocroppedpictureBox
            // 
            autocroppedpictureBox.BackColor = Color.White;
            autocroppedpictureBox.Location = new Point(327, 129);
            autocroppedpictureBox.Name = "autocroppedpictureBox";
            autocroppedpictureBox.Size = new Size(170, 170);
            autocroppedpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            autocroppedpictureBox.TabIndex = 1;
            autocroppedpictureBox.TabStop = false;
            // 
            // originalpictureBox
            // 
            originalpictureBox.BackColor = Color.White;
            originalpictureBox.Location = new Point(85, 129);
            originalpictureBox.Name = "originalpictureBox";
            originalpictureBox.Size = new Size(170, 170);
            originalpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            originalpictureBox.TabIndex = 1;
            originalpictureBox.TabStop = false;
            // 
            // saveBtn1
            // 
            saveBtn1.Location = new Point(327, 362);
            saveBtn1.Name = "saveBtn1";
            saveBtn1.Size = new Size(170, 30);
            saveBtn1.TabIndex = 0;
            saveBtn1.Text = "Save as...";
            saveBtn1.UseVisualStyleBackColor = true;
            saveBtn1.Click += saveBtn1_Click;
            // 
            // autocropBtn
            // 
            autocropBtn.Font = new Font("Segoe UI", 11F);
            autocropBtn.Location = new Point(327, 82);
            autocropBtn.Name = "autocropBtn";
            autocropBtn.Size = new Size(170, 30);
            autocropBtn.TabIndex = 0;
            autocropBtn.Text = "Auto Crop";
            autocropBtn.UseVisualStyleBackColor = true;
            autocropBtn.Click += autocropBtn_Click;
            // 
            // chooseBtn
            // 
            chooseBtn.Font = new Font("Segoe UI", 11F);
            chooseBtn.Location = new Point(85, 82);
            chooseBtn.Name = "chooseBtn";
            chooseBtn.Size = new Size(170, 30);
            chooseBtn.TabIndex = 0;
            chooseBtn.Text = "Choose...";
            chooseBtn.UseVisualStyleBackColor = true;
            chooseBtn.Click += chooseBtn_Click;
            // 
            // textsummarizer
            // 
            textsummarizer.Controls.Add(saveBtn2);
            textsummarizer.Controls.Add(autosummarizeBtn);
            textsummarizer.Controls.Add(label4);
            textsummarizer.Controls.Add(label3);
            textsummarizer.Controls.Add(summaryTextBox);
            textsummarizer.Controls.Add(originalTextBox);
            textsummarizer.Location = new Point(4, 24);
            textsummarizer.Name = "textsummarizer";
            textsummarizer.Padding = new Padding(3);
            textsummarizer.Size = new Size(592, 452);
            textsummarizer.TabIndex = 1;
            textsummarizer.Text = "Text Summarizer";
            textsummarizer.UseVisualStyleBackColor = true;
            // 
            // saveBtn2
            // 
            saveBtn2.Font = new Font("Segoe UI", 11F);
            saveBtn2.Location = new Point(345, 408);
            saveBtn2.Name = "saveBtn2";
            saveBtn2.Size = new Size(170, 30);
            saveBtn2.TabIndex = 4;
            saveBtn2.Text = "Save as...";
            saveBtn2.UseVisualStyleBackColor = true;
            saveBtn2.Click += saveBtn2_Click;
            // 
            // autosummarizeBtn
            // 
            autosummarizeBtn.Font = new Font("Segoe UI", 11F);
            autosummarizeBtn.Location = new Point(345, 215);
            autosummarizeBtn.Name = "autosummarizeBtn";
            autosummarizeBtn.Size = new Size(170, 30);
            autosummarizeBtn.TabIndex = 3;
            autosummarizeBtn.Text = "Auto Summarize";
            autosummarizeBtn.UseVisualStyleBackColor = true;
            autosummarizeBtn.Click += autosummarizeBtn_ClickAsync;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(75, 240);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 2;
            label4.Text = "Summary:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(75, 40);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 1;
            label3.Text = "Original:";
            // 
            // summaryTextBox
            // 
            summaryTextBox.Location = new Point(75, 265);
            summaryTextBox.Name = "summaryTextBox";
            summaryTextBox.Size = new Size(440, 130);
            summaryTextBox.TabIndex = 0;
            summaryTextBox.Text = "";
            // 
            // originalTextBox
            // 
            originalTextBox.Location = new Point(75, 65);
            originalTextBox.Name = "originalTextBox";
            originalTextBox.Size = new Size(440, 130);
            originalTextBox.TabIndex = 0;
            originalTextBox.Text = "";
            // 
            // grammarcorrector
            // 
            grammarcorrector.Controls.Add(saveBtn3);
            grammarcorrector.Controls.Add(autocorrectBtn);
            grammarcorrector.Controls.Add(label6);
            grammarcorrector.Controls.Add(label5);
            grammarcorrector.Controls.Add(correctedTextBox);
            grammarcorrector.Controls.Add(correctorOriginalTextBox);
            grammarcorrector.Location = new Point(4, 24);
            grammarcorrector.Name = "grammarcorrector";
            grammarcorrector.Padding = new Padding(3);
            grammarcorrector.Size = new Size(592, 452);
            grammarcorrector.TabIndex = 2;
            grammarcorrector.Text = "Grammar Corrector";
            grammarcorrector.UseVisualStyleBackColor = true;
            // 
            // saveBtn3
            // 
            saveBtn3.Font = new Font("Segoe UI", 11F);
            saveBtn3.Location = new Point(345, 408);
            saveBtn3.Name = "saveBtn3";
            saveBtn3.Size = new Size(170, 30);
            saveBtn3.TabIndex = 4;
            saveBtn3.Text = "Save as...";
            saveBtn3.UseVisualStyleBackColor = true;
            saveBtn3.Click += saveBtn3_Click;
            // 
            // autocorrectBtn
            // 
            autocorrectBtn.Font = new Font("Segoe UI", 11F);
            autocorrectBtn.Location = new Point(345, 215);
            autocorrectBtn.Name = "autocorrectBtn";
            autocorrectBtn.Size = new Size(170, 30);
            autocorrectBtn.TabIndex = 3;
            autocorrectBtn.Text = "Auto Correct";
            autocorrectBtn.UseVisualStyleBackColor = true;
            autocorrectBtn.Click += autocorrectBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(75, 240);
            label6.Name = "label6";
            label6.Size = new Size(230, 20);
            label6.TabIndex = 2;
            label6.Text = "Grammar and Spelling Corrected:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(75, 40);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 1;
            label5.Text = "Original:";
            // 
            // correctedTextBox
            // 
            correctedTextBox.Location = new Point(75, 265);
            correctedTextBox.Name = "correctedTextBox";
            correctedTextBox.Size = new Size(440, 130);
            correctedTextBox.TabIndex = 0;
            correctedTextBox.Text = "";
            // 
            // correctorOriginalTextBox
            // 
            correctorOriginalTextBox.Location = new Point(75, 65);
            correctorOriginalTextBox.Name = "correctorOriginalTextBox";
            correctorOriginalTextBox.Size = new Size(440, 130);
            correctorOriginalTextBox.TabIndex = 0;
            correctorOriginalTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 581);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "AI Demos";
            tabControl1.ResumeLayout(false);
            photocropper.ResumeLayout(false);
            photocropper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)autocroppedpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)originalpictureBox).EndInit();
            textsummarizer.ResumeLayout(false);
            textsummarizer.PerformLayout();
            grammarcorrector.ResumeLayout(false);
            grammarcorrector.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage photocropper;
        private TabPage textsummarizer;
        private TabPage grammarcorrector;
        private PictureBox autocroppedpictureBox;
        private PictureBox originalpictureBox;
        private Button autocropBtn;
        private Button chooseBtn;
        private Label croppedfilename;
        private Label label1;
        private Button saveBtn1;
        private Button saveBtn2;
        private Button autosummarizeBtn;
        private Label label4;
        private Label label3;
        private RichTextBox summaryTextBox;
        private RichTextBox originalTextBox;
        private RichTextBox correctedTextBox;
        private RichTextBox correctorOriginalTextBox;
        private Label originfilename;
        private Button saveBtn3;
        private Button autocorrectBtn;
        private Label label6;
        private Label label5;
    }
}
