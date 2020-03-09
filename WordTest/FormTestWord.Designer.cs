namespace WordTest
{
    partial class FormTestWord
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
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.toFindStrTextBox = new System.Windows.Forms.TextBox();
            this.replaceStrTextBox = new System.Windows.Forms.TextBox();
            this.toFindStLabel = new System.Windows.Forms.Label();
            this.replaceStrLabel = new System.Windows.Forms.Label();
            this.openTemplateButton = new System.Windows.Forms.Button();
            this.replaceTestButton = new System.Windows.Forms.Button();
            this.replaceAllСheckBox = new System.Windows.Forms.CheckBox();
            this.bookmarkTextBox = new System.Windows.Forms.TextBox();
            this.bookmarkLabel = new System.Windows.Forms.Label();
            this.bookmarkInsertButton = new System.Windows.Forms.Button();
            this.bookmarkInsertTextBox = new System.Windows.Forms.TextBox();
            this.bmarkInsertLabel = new System.Windows.Forms.Label();
            this.bmarkInsertTextButton = new System.Windows.Forms.Button();
            this.insertToBookmarkRadioButton = new System.Windows.Forms.RadioButton();
            this.insertToStartRadioButton = new System.Windows.Forms.RadioButton();
            this.searchFormatLabel = new System.Windows.Forms.Label();
            this.searchFormatTextBox = new System.Windows.Forms.TextBox();
            this.searchFormatButton = new System.Windows.Forms.Button();
            this.formatBoldCheckBox = new System.Windows.Forms.CheckBox();
            this.formatItalicCheckBox = new System.Windows.Forms.CheckBox();
            this.formatFontSizeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.formatFontSizeLabel = new System.Windows.Forms.Label();
            this.formatCenterCheckBox = new System.Windows.Forms.CheckBox();
            this.formatContainerTextBox = new System.Windows.Forms.TextBox();
            this.formatContainerCheckBox = new System.Windows.Forms.CheckBox();
            this.tableButton = new System.Windows.Forms.Button();
            this.tableBookmarkTextBox = new System.Windows.Forms.TextBox();
            this.tableBmarkLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.isParagraphCheckBox = new System.Windows.Forms.CheckBox();
            this.tableBorderCheckBox = new System.Windows.Forms.CheckBox();
            this.insertFileButton = new System.Windows.Forms.Button();
            this.insertCountNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.openBlankButton = new System.Windows.Forms.Button();
            this.selectTableButton = new System.Windows.Forms.Button();
            this.tableNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.addRowsNumUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.formatFontSizeNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertCountNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRowsNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(12, 30);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(353, 22);
            this.pathTextBox.TabIndex = 1;
            this.pathTextBox.Text = "testWordTemplate.dot";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(9, 11);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(343, 16);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Имя файла с шаблоном Word в каталоге с программой:";
            // 
            // toFindStrTextBox
            // 
            this.toFindStrTextBox.Location = new System.Drawing.Point(12, 74);
            this.toFindStrTextBox.Name = "toFindStrTextBox";
            this.toFindStrTextBox.Size = new System.Drawing.Size(107, 22);
            this.toFindStrTextBox.TabIndex = 3;
            this.toFindStrTextBox.Text = "@@testReplace";
            // 
            // replaceStrTextBox
            // 
            this.replaceStrTextBox.Location = new System.Drawing.Point(125, 74);
            this.replaceStrTextBox.Name = "replaceStrTextBox";
            this.replaceStrTextBox.Size = new System.Drawing.Size(240, 22);
            this.replaceStrTextBox.TabIndex = 3;
            this.replaceStrTextBox.Text = "Проверка замены строки!";
            // 
            // toFindStLabel
            // 
            this.toFindStLabel.AutoSize = true;
            this.toFindStLabel.Location = new System.Drawing.Point(9, 55);
            this.toFindStLabel.Name = "toFindStLabel";
            this.toFindStLabel.Size = new System.Drawing.Size(48, 16);
            this.toFindStLabel.TabIndex = 4;
            this.toFindStLabel.Text = "Метка:";
            // 
            // replaceStrLabel
            // 
            this.replaceStrLabel.AutoSize = true;
            this.replaceStrLabel.Location = new System.Drawing.Point(122, 55);
            this.replaceStrLabel.Name = "replaceStrLabel";
            this.replaceStrLabel.Size = new System.Drawing.Size(87, 16);
            this.replaceStrLabel.TabIndex = 4;
            this.replaceStrLabel.Text = "Заменить на:";
            // 
            // openTemplateButton
            // 
            this.openTemplateButton.Location = new System.Drawing.Point(371, 30);
            this.openTemplateButton.Name = "openTemplateButton";
            this.openTemplateButton.Size = new System.Drawing.Size(124, 22);
            this.openTemplateButton.TabIndex = 5;
            this.openTemplateButton.Text = "просто открыть";
            this.openTemplateButton.UseVisualStyleBackColor = true;
            this.openTemplateButton.Click += new System.EventHandler(this.openTemplateButton_Click);
            // 
            // replaceTestButton
            // 
            this.replaceTestButton.Location = new System.Drawing.Point(371, 74);
            this.replaceTestButton.Name = "replaceTestButton";
            this.replaceTestButton.Size = new System.Drawing.Size(124, 22);
            this.replaceTestButton.TabIndex = 5;
            this.replaceTestButton.Text = "заменить строку";
            this.replaceTestButton.UseVisualStyleBackColor = true;
            this.replaceTestButton.Click += new System.EventHandler(this.replaceTestButton_Click);
            // 
            // replaceAllСheckBox
            // 
            this.replaceAllСheckBox.AutoSize = true;
            this.replaceAllСheckBox.Location = new System.Drawing.Point(501, 77);
            this.replaceAllСheckBox.Name = "replaceAllСheckBox";
            this.replaceAllСheckBox.Size = new System.Drawing.Size(48, 20);
            this.replaceAllСheckBox.TabIndex = 6;
            this.replaceAllСheckBox.Text = "все";
            this.replaceAllСheckBox.UseVisualStyleBackColor = true;
            // 
            // bookmarkTextBox
            // 
            this.bookmarkTextBox.Location = new System.Drawing.Point(12, 118);
            this.bookmarkTextBox.Name = "bookmarkTextBox";
            this.bookmarkTextBox.Size = new System.Drawing.Size(107, 22);
            this.bookmarkTextBox.TabIndex = 3;
            this.bookmarkTextBox.Text = "testBookmark";
            // 
            // bookmarkLabel
            // 
            this.bookmarkLabel.AutoSize = true;
            this.bookmarkLabel.Location = new System.Drawing.Point(9, 99);
            this.bookmarkLabel.Name = "bookmarkLabel";
            this.bookmarkLabel.Size = new System.Drawing.Size(68, 16);
            this.bookmarkLabel.TabIndex = 4;
            this.bookmarkLabel.Text = "Закладка:";
            // 
            // bookmarkInsertButton
            // 
            this.bookmarkInsertButton.Location = new System.Drawing.Point(125, 146);
            this.bookmarkInsertButton.Name = "bookmarkInsertButton";
            this.bookmarkInsertButton.Size = new System.Drawing.Size(166, 22);
            this.bookmarkInsertButton.TabIndex = 5;
            this.bookmarkInsertButton.Text = "сложная вставка";
            this.bookmarkInsertButton.UseVisualStyleBackColor = true;
            this.bookmarkInsertButton.Click += new System.EventHandler(this.bookmarkInsertButton_Click);
            // 
            // bookmarkInsertTextBox
            // 
            this.bookmarkInsertTextBox.Location = new System.Drawing.Point(125, 118);
            this.bookmarkInsertTextBox.Name = "bookmarkInsertTextBox";
            this.bookmarkInsertTextBox.Size = new System.Drawing.Size(240, 22);
            this.bookmarkInsertTextBox.TabIndex = 3;
            this.bookmarkInsertTextBox.Text = "Проверка вставки текста на закладку!";
            // 
            // bmarkInsertLabel
            // 
            this.bmarkInsertLabel.AutoSize = true;
            this.bmarkInsertLabel.Location = new System.Drawing.Point(122, 99);
            this.bmarkInsertLabel.Name = "bmarkInsertLabel";
            this.bmarkInsertLabel.Size = new System.Drawing.Size(87, 16);
            this.bmarkInsertLabel.TabIndex = 4;
            this.bmarkInsertLabel.Text = "Заменить на:";
            // 
            // bmarkInsertTextButton
            // 
            this.bmarkInsertTextButton.Location = new System.Drawing.Point(371, 118);
            this.bmarkInsertTextButton.Name = "bmarkInsertTextButton";
            this.bmarkInsertTextButton.Size = new System.Drawing.Size(124, 22);
            this.bmarkInsertTextButton.TabIndex = 5;
            this.bmarkInsertTextButton.Text = "вставить текст";
            this.bmarkInsertTextButton.UseVisualStyleBackColor = true;
            this.bmarkInsertTextButton.Click += new System.EventHandler(this.bmarkInsertTextButton_Click);
            // 
            // insertToBookmarkRadioButton
            // 
            this.insertToBookmarkRadioButton.AutoSize = true;
            this.insertToBookmarkRadioButton.Checked = true;
            this.insertToBookmarkRadioButton.Location = new System.Drawing.Point(297, 148);
            this.insertToBookmarkRadioButton.Name = "insertToBookmarkRadioButton";
            this.insertToBookmarkRadioButton.Size = new System.Drawing.Size(98, 20);
            this.insertToBookmarkRadioButton.TabIndex = 7;
            this.insertToBookmarkRadioButton.TabStop = true;
            this.insertToBookmarkRadioButton.Text = "на закладку";
            this.insertToBookmarkRadioButton.UseVisualStyleBackColor = true;
            // 
            // insertToStartRadioButton
            // 
            this.insertToStartRadioButton.AutoSize = true;
            this.insertToStartRadioButton.Location = new System.Drawing.Point(402, 148);
            this.insertToStartRadioButton.Name = "insertToStartRadioButton";
            this.insertToStartRadioButton.Size = new System.Drawing.Size(146, 20);
            this.insertToStartRadioButton.TabIndex = 8;
            this.insertToStartRadioButton.TabStop = true;
            this.insertToStartRadioButton.Text = "в начало документа";
            this.insertToStartRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchFormatLabel
            // 
            this.searchFormatLabel.AutoSize = true;
            this.searchFormatLabel.Location = new System.Drawing.Point(9, 190);
            this.searchFormatLabel.Name = "searchFormatLabel";
            this.searchFormatLabel.Size = new System.Drawing.Size(277, 16);
            this.searchFormatLabel.TabIndex = 4;
            this.searchFormatLabel.Text = "Найти и отформатировать текст в документе:";
            // 
            // searchFormatTextBox
            // 
            this.searchFormatTextBox.Location = new System.Drawing.Point(12, 209);
            this.searchFormatTextBox.Name = "searchFormatTextBox";
            this.searchFormatTextBox.Size = new System.Drawing.Size(353, 22);
            this.searchFormatTextBox.TabIndex = 3;
            this.searchFormatTextBox.Text = "Основные сведения об объектной модели Word";
            // 
            // searchFormatButton
            // 
            this.searchFormatButton.Location = new System.Drawing.Point(371, 209);
            this.searchFormatButton.Name = "searchFormatButton";
            this.searchFormatButton.Size = new System.Drawing.Size(124, 22);
            this.searchFormatButton.TabIndex = 5;
            this.searchFormatButton.Text = "форматировать";
            this.searchFormatButton.UseVisualStyleBackColor = true;
            this.searchFormatButton.Click += new System.EventHandler(this.searchFormatButton_Click);
            // 
            // formatBoldCheckBox
            // 
            this.formatBoldCheckBox.AutoSize = true;
            this.formatBoldCheckBox.Checked = true;
            this.formatBoldCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.formatBoldCheckBox.Location = new System.Drawing.Point(12, 238);
            this.formatBoldCheckBox.Name = "formatBoldCheckBox";
            this.formatBoldCheckBox.Size = new System.Drawing.Size(73, 20);
            this.formatBoldCheckBox.TabIndex = 9;
            this.formatBoldCheckBox.Text = "жирный";
            this.formatBoldCheckBox.UseVisualStyleBackColor = true;
            // 
            // formatItalicCheckBox
            // 
            this.formatItalicCheckBox.AutoSize = true;
            this.formatItalicCheckBox.Location = new System.Drawing.Point(91, 238);
            this.formatItalicCheckBox.Name = "formatItalicCheckBox";
            this.formatItalicCheckBox.Size = new System.Drawing.Size(68, 20);
            this.formatItalicCheckBox.TabIndex = 9;
            this.formatItalicCheckBox.Text = "курсив";
            this.formatItalicCheckBox.UseVisualStyleBackColor = true;
            // 
            // formatFontSizeNumUpDown
            // 
            this.formatFontSizeNumUpDown.Location = new System.Drawing.Point(273, 237);
            this.formatFontSizeNumUpDown.Name = "formatFontSizeNumUpDown";
            this.formatFontSizeNumUpDown.Size = new System.Drawing.Size(43, 22);
            this.formatFontSizeNumUpDown.TabIndex = 10;
            this.formatFontSizeNumUpDown.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // formatFontSizeLabel
            // 
            this.formatFontSizeLabel.AutoSize = true;
            this.formatFontSizeLabel.Location = new System.Drawing.Point(165, 239);
            this.formatFontSizeLabel.Name = "formatFontSizeLabel";
            this.formatFontSizeLabel.Size = new System.Drawing.Size(107, 16);
            this.formatFontSizeLabel.TabIndex = 11;
            this.formatFontSizeLabel.Text = "Размер шрифта:";
            // 
            // formatCenterCheckBox
            // 
            this.formatCenterCheckBox.AutoSize = true;
            this.formatCenterCheckBox.Location = new System.Drawing.Point(341, 238);
            this.formatCenterCheckBox.Name = "formatCenterCheckBox";
            this.formatCenterCheckBox.Size = new System.Drawing.Size(85, 20);
            this.formatCenterCheckBox.TabIndex = 12;
            this.formatCenterCheckBox.Text = "по центру";
            this.formatCenterCheckBox.UseVisualStyleBackColor = true;
            // 
            // formatContainerTextBox
            // 
            this.formatContainerTextBox.Location = new System.Drawing.Point(12, 291);
            this.formatContainerTextBox.Name = "formatContainerTextBox";
            this.formatContainerTextBox.Size = new System.Drawing.Size(536, 22);
            this.formatContainerTextBox.TabIndex = 13;
            this.formatContainerTextBox.Text = "Этот объект представляет текущий экземпляр Word";
            // 
            // formatContainerCheckBox
            // 
            this.formatContainerCheckBox.AutoSize = true;
            this.formatContainerCheckBox.Location = new System.Drawing.Point(13, 268);
            this.formatContainerCheckBox.Name = "formatContainerCheckBox";
            this.formatContainerCheckBox.Size = new System.Drawing.Size(254, 20);
            this.formatContainerCheckBox.TabIndex = 14;
            this.formatContainerCheckBox.Text = "искать строку для форматирования в:";
            this.formatContainerCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableButton
            // 
            this.tableButton.Location = new System.Drawing.Point(12, 319);
            this.tableButton.Name = "tableButton";
            this.tableButton.Size = new System.Drawing.Size(175, 27);
            this.tableButton.TabIndex = 5;
            this.tableButton.Text = "Вставить таблицу";
            this.tableButton.UseVisualStyleBackColor = true;
            this.tableButton.Click += new System.EventHandler(this.tableButton_Click);
            // 
            // tableBookmarkTextBox
            // 
            this.tableBookmarkTextBox.Location = new System.Drawing.Point(284, 321);
            this.tableBookmarkTextBox.Name = "tableBookmarkTextBox";
            this.tableBookmarkTextBox.Size = new System.Drawing.Size(107, 22);
            this.tableBookmarkTextBox.TabIndex = 3;
            this.tableBookmarkTextBox.Text = "testBookmark";
            // 
            // tableBmarkLabel
            // 
            this.tableBmarkLabel.AutoSize = true;
            this.tableBmarkLabel.Location = new System.Drawing.Point(368, 381);
            this.tableBmarkLabel.Name = "tableBmarkLabel";
            this.tableBmarkLabel.Size = new System.Drawing.Size(103, 16);
            this.tableBmarkLabel.TabIndex = 15;
            this.tableBmarkLabel.Text = "добавить строк:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.MaximumSize = new System.Drawing.Size(130, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "testBookmark2 внутри текста";
            // 
            // isParagraphCheckBox
            // 
            this.isParagraphCheckBox.AutoSize = true;
            this.isParagraphCheckBox.Location = new System.Drawing.Point(500, 120);
            this.isParagraphCheckBox.Name = "isParagraphCheckBox";
            this.isParagraphCheckBox.Size = new System.Drawing.Size(61, 20);
            this.isParagraphCheckBox.TabIndex = 6;
            this.isParagraphCheckBox.Text = "абзац";
            this.isParagraphCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableBorderCheckBox
            // 
            this.tableBorderCheckBox.AutoSize = true;
            this.tableBorderCheckBox.Location = new System.Drawing.Point(15, 353);
            this.tableBorderCheckBox.Name = "tableBorderCheckBox";
            this.tableBorderCheckBox.Size = new System.Drawing.Size(100, 20);
            this.tableBorderCheckBox.TabIndex = 17;
            this.tableBorderCheckBox.Text = "без границы";
            this.tableBorderCheckBox.UseVisualStyleBackColor = true;
            // 
            // insertFileButton
            // 
            this.insertFileButton.Location = new System.Drawing.Point(12, 436);
            this.insertFileButton.Name = "insertFileButton";
            this.insertFileButton.Size = new System.Drawing.Size(283, 27);
            this.insertFileButton.TabIndex = 5;
            this.insertFileButton.Text = "Вставить шаблон на новую страницу, раз:";
            this.insertFileButton.UseVisualStyleBackColor = true;
            this.insertFileButton.Click += new System.EventHandler(this.insertFileButton_Click);
            // 
            // insertCountNumUpDown
            // 
            this.insertCountNumUpDown.Location = new System.Drawing.Point(297, 439);
            this.insertCountNumUpDown.Name = "insertCountNumUpDown";
            this.insertCountNumUpDown.Size = new System.Drawing.Size(61, 22);
            this.insertCountNumUpDown.TabIndex = 18;
            this.insertCountNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // openBlankButton
            // 
            this.openBlankButton.Location = new System.Drawing.Point(371, 5);
            this.openBlankButton.Name = "openBlankButton";
            this.openBlankButton.Size = new System.Drawing.Size(124, 22);
            this.openBlankButton.TabIndex = 5;
            this.openBlankButton.Text = "открыть пустой";
            this.openBlankButton.UseVisualStyleBackColor = true;
            this.openBlankButton.Click += new System.EventHandler(this.openBlankButton_Click);
            // 
            // selectTableButton
            // 
            this.selectTableButton.Location = new System.Drawing.Point(12, 379);
            this.selectTableButton.Name = "selectTableButton";
            this.selectTableButton.Size = new System.Drawing.Size(283, 23);
            this.selectTableButton.TabIndex = 19;
            this.selectTableButton.Text = "Вставка данных в существующ. таблицу №";
            this.selectTableButton.UseVisualStyleBackColor = true;
            this.selectTableButton.Click += new System.EventHandler(this.selectTableButton_Click);
            // 
            // tableNumUpDown
            // 
            this.tableNumUpDown.Location = new System.Drawing.Point(301, 379);
            this.tableNumUpDown.Name = "tableNumUpDown";
            this.tableNumUpDown.Size = new System.Drawing.Size(61, 22);
            this.tableNumUpDown.TabIndex = 18;
            this.tableNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addRowsNumUpDown
            // 
            this.addRowsNumUpDown.Location = new System.Drawing.Point(477, 379);
            this.addRowsNumUpDown.Name = "addRowsNumUpDown";
            this.addRowsNumUpDown.Size = new System.Drawing.Size(46, 22);
            this.addRowsNumUpDown.TabIndex = 18;
            this.addRowsNumUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // FormTestWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 475);
            this.Controls.Add(this.selectTableButton);
            this.Controls.Add(this.addRowsNumUpDown);
            this.Controls.Add(this.tableNumUpDown);
            this.Controls.Add(this.insertCountNumUpDown);
            this.Controls.Add(this.tableBorderCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableBmarkLabel);
            this.Controls.Add(this.formatContainerCheckBox);
            this.Controls.Add(this.formatContainerTextBox);
            this.Controls.Add(this.formatCenterCheckBox);
            this.Controls.Add(this.formatFontSizeLabel);
            this.Controls.Add(this.formatFontSizeNumUpDown);
            this.Controls.Add(this.formatItalicCheckBox);
            this.Controls.Add(this.formatBoldCheckBox);
            this.Controls.Add(this.insertToStartRadioButton);
            this.Controls.Add(this.insertToBookmarkRadioButton);
            this.Controls.Add(this.isParagraphCheckBox);
            this.Controls.Add(this.replaceAllСheckBox);
            this.Controls.Add(this.bookmarkInsertButton);
            this.Controls.Add(this.insertFileButton);
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.searchFormatButton);
            this.Controls.Add(this.bmarkInsertTextButton);
            this.Controls.Add(this.replaceTestButton);
            this.Controls.Add(this.openBlankButton);
            this.Controls.Add(this.openTemplateButton);
            this.Controls.Add(this.bmarkInsertLabel);
            this.Controls.Add(this.replaceStrLabel);
            this.Controls.Add(this.searchFormatLabel);
            this.Controls.Add(this.bookmarkLabel);
            this.Controls.Add(this.bookmarkInsertTextBox);
            this.Controls.Add(this.toFindStLabel);
            this.Controls.Add(this.replaceStrTextBox);
            this.Controls.Add(this.searchFormatTextBox);
            this.Controls.Add(this.tableBookmarkTextBox);
            this.Controls.Add(this.bookmarkTextBox);
            this.Controls.Add(this.toFindStrTextBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathTextBox);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormTestWord";
            this.Text = "Тестирование Word";
            ((System.ComponentModel.ISupportInitialize)(this.formatFontSizeNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertCountNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRowsNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox toFindStrTextBox;
        private System.Windows.Forms.TextBox replaceStrTextBox;
        private System.Windows.Forms.Label toFindStLabel;
        private System.Windows.Forms.Label replaceStrLabel;
        private System.Windows.Forms.Button openTemplateButton;
        private System.Windows.Forms.Button replaceTestButton;
        private System.Windows.Forms.CheckBox replaceAllСheckBox;
        private System.Windows.Forms.TextBox bookmarkTextBox;
        private System.Windows.Forms.Label bookmarkLabel;
        private System.Windows.Forms.Button bookmarkInsertButton;
        private System.Windows.Forms.TextBox bookmarkInsertTextBox;
        private System.Windows.Forms.Label bmarkInsertLabel;
        private System.Windows.Forms.Button bmarkInsertTextButton;
        private System.Windows.Forms.RadioButton insertToBookmarkRadioButton;
        private System.Windows.Forms.RadioButton insertToStartRadioButton;
        private System.Windows.Forms.Label searchFormatLabel;
        private System.Windows.Forms.TextBox searchFormatTextBox;
        private System.Windows.Forms.Button searchFormatButton;
        private System.Windows.Forms.CheckBox formatBoldCheckBox;
        private System.Windows.Forms.CheckBox formatItalicCheckBox;
        private System.Windows.Forms.NumericUpDown formatFontSizeNumUpDown;
        private System.Windows.Forms.Label formatFontSizeLabel;
        private System.Windows.Forms.CheckBox formatCenterCheckBox;
        private System.Windows.Forms.TextBox formatContainerTextBox;
        private System.Windows.Forms.CheckBox formatContainerCheckBox;
        private System.Windows.Forms.Button tableButton;
        private System.Windows.Forms.TextBox tableBookmarkTextBox;
        private System.Windows.Forms.Label tableBmarkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isParagraphCheckBox;
        private System.Windows.Forms.CheckBox tableBorderCheckBox;
        private System.Windows.Forms.Button insertFileButton;
        private System.Windows.Forms.NumericUpDown insertCountNumUpDown;
        private System.Windows.Forms.Button openBlankButton;
        private System.Windows.Forms.Button selectTableButton;
        private System.Windows.Forms.NumericUpDown tableNumUpDown;
        private System.Windows.Forms.NumericUpDown addRowsNumUpDown;
    }
}

