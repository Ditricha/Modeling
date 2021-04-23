namespace Battlefield
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            this.TableWithValues = new System.Windows.Forms.GroupBox();
            this.dataGridView10 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MaskedDigits1 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedDigits2 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedDigits3 = new System.Windows.Forms.MaskedTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.clearSelectionButton = new System.Windows.Forms.Button();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserValue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserValue2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserValue3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlgorithmicValue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlgorithmicValue2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlgorithmicValue3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableValue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableValue2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableValue3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlgorithmicValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            this.TableWithValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите 10 чисел через пробел:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "1-разрядные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "2-разрядные";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "3-разрядные";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Внести введённые числа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.UserValue1});
            this.dataGridView1.Location = new System.Drawing.Point(4, 14);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(93, 243);
            this.dataGridView1.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserValue2});
            this.dataGridView2.Location = new System.Drawing.Point(96, 14);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(63, 243);
            this.dataGridView2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(642, 424);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserValue3});
            this.dataGridView3.Location = new System.Drawing.Point(158, 14);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(63, 243);
            this.dataGridView3.TabIndex = 13;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlgorithmicValue1});
            this.dataGridView4.Location = new System.Drawing.Point(220, 14);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.Size = new System.Drawing.Size(63, 243);
            this.dataGridView4.TabIndex = 14;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AllowUserToResizeColumns = false;
            this.dataGridView5.AllowUserToResizeRows = false;
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlgorithmicValue2});
            this.dataGridView5.Location = new System.Drawing.Point(282, 14);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.Size = new System.Drawing.Size(63, 243);
            this.dataGridView5.TabIndex = 15;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.AllowUserToResizeColumns = false;
            this.dataGridView6.AllowUserToResizeRows = false;
            this.dataGridView6.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlgorithmicValue3});
            this.dataGridView6.Location = new System.Drawing.Point(344, 14);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.RowHeadersVisible = false;
            this.dataGridView6.Size = new System.Drawing.Size(63, 243);
            this.dataGridView6.TabIndex = 16;
            // 
            // dataGridView7
            // 
            this.dataGridView7.AllowUserToAddRows = false;
            this.dataGridView7.AllowUserToDeleteRows = false;
            this.dataGridView7.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableValue1});
            this.dataGridView7.Location = new System.Drawing.Point(406, 14);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.ReadOnly = true;
            this.dataGridView7.RowHeadersVisible = false;
            this.dataGridView7.Size = new System.Drawing.Size(63, 243);
            this.dataGridView7.TabIndex = 17;
            // 
            // dataGridView8
            // 
            this.dataGridView8.AllowUserToAddRows = false;
            this.dataGridView8.AllowUserToDeleteRows = false;
            this.dataGridView8.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableValue2});
            this.dataGridView8.Location = new System.Drawing.Point(468, 14);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.ReadOnly = true;
            this.dataGridView8.RowHeadersVisible = false;
            this.dataGridView8.Size = new System.Drawing.Size(63, 243);
            this.dataGridView8.TabIndex = 18;
            // 
            // dataGridView9
            // 
            this.dataGridView9.AllowUserToAddRows = false;
            this.dataGridView9.AllowUserToDeleteRows = false;
            this.dataGridView9.AllowUserToResizeColumns = false;
            this.dataGridView9.AllowUserToResizeRows = false;
            this.dataGridView9.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView9.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableValue3});
            this.dataGridView9.Location = new System.Drawing.Point(530, 14);
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.ReadOnly = true;
            this.dataGridView9.RowHeadersVisible = false;
            this.dataGridView9.Size = new System.Drawing.Size(63, 243);
            this.dataGridView9.TabIndex = 19;
            // 
            // TableWithValues
            // 
            this.TableWithValues.Controls.Add(this.dataGridView10);
            this.TableWithValues.Controls.Add(this.dataGridView9);
            this.TableWithValues.Controls.Add(this.dataGridView8);
            this.TableWithValues.Controls.Add(this.dataGridView7);
            this.TableWithValues.Controls.Add(this.dataGridView6);
            this.TableWithValues.Controls.Add(this.dataGridView5);
            this.TableWithValues.Controls.Add(this.dataGridView4);
            this.TableWithValues.Controls.Add(this.dataGridView3);
            this.TableWithValues.Controls.Add(this.dataGridView2);
            this.TableWithValues.Controls.Add(this.dataGridView1);
            this.TableWithValues.Location = new System.Drawing.Point(12, 162);
            this.TableWithValues.Name = "TableWithValues";
            this.TableWithValues.Size = new System.Drawing.Size(598, 303);
            this.TableWithValues.TabIndex = 21;
            this.TableWithValues.TabStop = false;
            // 
            // dataGridView10
            // 
            this.dataGridView10.AllowUserToAddRows = false;
            this.dataGridView10.AllowUserToDeleteRows = false;
            this.dataGridView10.AllowUserToResizeColumns = false;
            this.dataGridView10.AllowUserToResizeRows = false;
            this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView10.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.UserValues,
            this.AlgorithmicValues,
            this.TableValues});
            this.dataGridView10.Location = new System.Drawing.Point(4, 257);
            this.dataGridView10.Name = "dataGridView10";
            this.dataGridView10.ReadOnly = true;
            this.dataGridView10.RowHeadersVisible = false;
            this.dataGridView10.Size = new System.Drawing.Size(589, 22);
            this.dataGridView10.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 53);
            this.button3.TabIndex = 10;
            this.button3.Text = "Расчитать критерий";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "Сгенерировать псевдослучайные числа";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MaskedDigits1
            // 
            this.MaskedDigits1.Location = new System.Drawing.Point(90, 53);
            this.MaskedDigits1.Mask = "9999999999999999999";
            this.MaskedDigits1.Name = "MaskedDigits1";
            this.MaskedDigits1.Size = new System.Drawing.Size(250, 20);
            this.MaskedDigits1.TabIndex = 23;
            // 
            // MaskedDigits2
            // 
            this.MaskedDigits2.Location = new System.Drawing.Point(90, 79);
            this.MaskedDigits2.Mask = "99999999999999999999999999999";
            this.MaskedDigits2.Name = "MaskedDigits2";
            this.MaskedDigits2.Size = new System.Drawing.Size(250, 20);
            this.MaskedDigits2.TabIndex = 24;
            // 
            // MaskedDigits3
            // 
            this.MaskedDigits3.Location = new System.Drawing.Point(90, 105);
            this.MaskedDigits3.Mask = "999999999999999999999999999999999999999";
            this.MaskedDigits3.Name = "MaskedDigits3";
            this.MaskedDigits3.Size = new System.Drawing.Size(250, 20);
            this.MaskedDigits3.TabIndex = 25;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(379, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(226, 118);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // clearSelectionButton
            // 
            this.clearSelectionButton.Location = new System.Drawing.Point(12, 131);
            this.clearSelectionButton.Name = "clearSelectionButton";
            this.clearSelectionButton.Size = new System.Drawing.Size(144, 25);
            this.clearSelectionButton.TabIndex = 21;
            this.clearSelectionButton.Text = "Убрать выделение ячеек";
            this.clearSelectionButton.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            this.Index.HeaderText = "№";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Index.Width = 30;
            // 
            // UserValue1
            // 
            this.UserValue1.HeaderText = "      1";
            this.UserValue1.Name = "UserValue1";
            this.UserValue1.ReadOnly = true;
            this.UserValue1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserValue1.Width = 60;
            // 
            // UserValue2
            // 
            this.UserValue2.HeaderText = "      2";
            this.UserValue2.Name = "UserValue2";
            this.UserValue2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserValue2.Width = 60;
            // 
            // UserValue3
            // 
            this.UserValue3.HeaderText = "      3";
            this.UserValue3.Name = "UserValue3";
            this.UserValue3.ReadOnly = true;
            this.UserValue3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserValue3.Width = 60;
            // 
            // AlgorithmicValue1
            // 
            this.AlgorithmicValue1.HeaderText = "      1";
            this.AlgorithmicValue1.Name = "AlgorithmicValue1";
            this.AlgorithmicValue1.ReadOnly = true;
            this.AlgorithmicValue1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AlgorithmicValue1.Width = 60;
            // 
            // AlgorithmicValue2
            // 
            this.AlgorithmicValue2.HeaderText = "      2";
            this.AlgorithmicValue2.Name = "AlgorithmicValue2";
            this.AlgorithmicValue2.ReadOnly = true;
            this.AlgorithmicValue2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AlgorithmicValue2.Width = 60;
            // 
            // AlgorithmicValue3
            // 
            this.AlgorithmicValue3.HeaderText = "      3";
            this.AlgorithmicValue3.Name = "AlgorithmicValue3";
            this.AlgorithmicValue3.ReadOnly = true;
            this.AlgorithmicValue3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AlgorithmicValue3.Width = 60;
            // 
            // TableValue1
            // 
            this.TableValue1.HeaderText = "      1";
            this.TableValue1.Name = "TableValue1";
            this.TableValue1.ReadOnly = true;
            this.TableValue1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TableValue1.Width = 60;
            // 
            // TableValue2
            // 
            this.TableValue2.HeaderText = "      2";
            this.TableValue2.Name = "TableValue2";
            this.TableValue2.ReadOnly = true;
            this.TableValue2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TableValue2.Width = 60;
            // 
            // TableValue3
            // 
            this.TableValue3.HeaderText = "      3";
            this.TableValue3.Name = "TableValue3";
            this.TableValue3.ReadOnly = true;
            this.TableValue3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TableValue3.Width = 60;
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Number.Width = 30;
            // 
            // UserValues
            // 
            this.UserValues.HeaderText = "      Пользовательсие данные";
            this.UserValues.Name = "UserValues";
            this.UserValues.ReadOnly = true;
            this.UserValues.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserValues.Width = 185;
            // 
            // AlgorithmicValues
            // 
            this.AlgorithmicValues.HeaderText = "      Алгоритмические данные";
            this.AlgorithmicValues.Name = "AlgorithmicValues";
            this.AlgorithmicValues.ReadOnly = true;
            this.AlgorithmicValues.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AlgorithmicValues.Width = 185;
            // 
            // TableValues
            // 
            this.TableValues.HeaderText = "            Табличные данные";
            this.TableValues.Name = "TableValues";
            this.TableValues.ReadOnly = true;
            this.TableValues.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TableValues.Width = 185;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 477);
            this.Controls.Add(this.clearSelectionButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.MaskedDigits3);
            this.Controls.Add(this.MaskedDigits2);
            this.Controls.Add(this.MaskedDigits1);
            this.Controls.Add(this.TableWithValues);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            this.TableWithValues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.DataGridView dataGridView9;
        private System.Windows.Forms.GroupBox TableWithValues;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView10;
        private System.Windows.Forms.MaskedTextBox MaskedDigits1;
        private System.Windows.Forms.MaskedTextBox MaskedDigits2;
        private System.Windows.Forms.MaskedTextBox MaskedDigits3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button clearSelectionButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserValue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserValue2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserValue3;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlgorithmicValue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlgorithmicValue2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlgorithmicValue3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableValue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableValue2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableValue3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlgorithmicValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableValues;
    }
}

