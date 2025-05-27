namespace DST
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numUD_MinDiapasonSpeed = new System.Windows.Forms.NumericUpDown();
            this.numUD_GradationSpeed = new System.Windows.Forms.NumericUpDown();
            this.numUD_MaxDiapasonSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_ForDiaposon = new System.Windows.Forms.DataGridView();
            this.ColumnSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDayOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ClearTBsDistSpeed = new System.Windows.Forms.Button();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.label_DayTravel = new System.Windows.Forms.Label();
            this.GroupBox7 = new System.Windows.Forms.GroupBox();
            this.label_HourTravel = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_Distance = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox8 = new System.Windows.Forms.GroupBox();
            this.label_MinuteTravel = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_Speed = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox11 = new System.Windows.Forms.GroupBox();
            this.label_DayOfWeekETA = new System.Windows.Forms.Label();
            this.label_TimeETA = new System.Windows.Forms.Label();
            this.label_DateETA = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DateTimePick = new System.Windows.Forms.DateTimePicker();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.numericUpD_Minute = new System.Windows.Forms.NumericUpDown();
            this.Label_HourForNumUDHour = new System.Windows.Forms.Label();
            this.numericUpD_Hour = new System.Windows.Forms.NumericUpDown();
            this.Label_HourForNumUDMinute = new System.Windows.Forms.Label();
            this.GroupBox10 = new System.Windows.Forms.GroupBox();
            this.label_DayOfWeekFmETD = new System.Windows.Forms.Label();
            this.label_TimeFmETD = new System.Windows.Forms.Label();
            this.label_DateFmETD = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_About = new System.Windows.Forms.ToolStripButton();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_MinDiapasonSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_GradationSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_MaxDiapasonSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ForDiaposon)).BeginInit();
            this.panel2.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpD_Minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpD_Hour)).BeginInit();
            this.GroupBox10.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(596, 664);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ETA";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.dataGridView_ForDiaposon);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(2, 337);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(592, 325);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Диапазон скоростей от ETD";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numUD_MinDiapasonSpeed);
            this.panel1.Controls.Add(this.numUD_GradationSpeed);
            this.panel1.Controls.Add(this.numUD_MaxDiapasonSpeed);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 55);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Мин.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(367, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Градац.";
            // 
            // numUD_MinDiapasonSpeed
            // 
            this.numUD_MinDiapasonSpeed.AutoSize = true;
            this.numUD_MinDiapasonSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUD_MinDiapasonSpeed.InterceptArrowKeys = false;
            this.numUD_MinDiapasonSpeed.Location = new System.Drawing.Point(65, 14);
            this.numUD_MinDiapasonSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.numUD_MinDiapasonSpeed.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUD_MinDiapasonSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_MinDiapasonSpeed.Name = "numUD_MinDiapasonSpeed";
            this.numUD_MinDiapasonSpeed.ReadOnly = true;
            this.numUD_MinDiapasonSpeed.Size = new System.Drawing.Size(75, 28);
            this.numUD_MinDiapasonSpeed.TabIndex = 9;
            this.numUD_MinDiapasonSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUD_MinDiapasonSpeed.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numUD_MinDiapasonSpeed.ValueChanged += new System.EventHandler(this.numUD_MinDiapasonSpeed_ValueChanged);
            // 
            // numUD_GradationSpeed
            // 
            this.numUD_GradationSpeed.AutoSize = true;
            this.numUD_GradationSpeed.DecimalPlaces = 1;
            this.numUD_GradationSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUD_GradationSpeed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUD_GradationSpeed.InterceptArrowKeys = false;
            this.numUD_GradationSpeed.Location = new System.Drawing.Point(453, 16);
            this.numUD_GradationSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.numUD_GradationSpeed.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_GradationSpeed.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUD_GradationSpeed.Name = "numUD_GradationSpeed";
            this.numUD_GradationSpeed.ReadOnly = true;
            this.numUD_GradationSpeed.Size = new System.Drawing.Size(75, 28);
            this.numUD_GradationSpeed.TabIndex = 24;
            this.numUD_GradationSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUD_GradationSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_GradationSpeed.ValueChanged += new System.EventHandler(this.numUD_GradationSpeed_ValueChanged);
            // 
            // numUD_MaxDiapasonSpeed
            // 
            this.numUD_MaxDiapasonSpeed.AutoSize = true;
            this.numUD_MaxDiapasonSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUD_MaxDiapasonSpeed.InterceptArrowKeys = false;
            this.numUD_MaxDiapasonSpeed.Location = new System.Drawing.Point(251, 14);
            this.numUD_MaxDiapasonSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.numUD_MaxDiapasonSpeed.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUD_MaxDiapasonSpeed.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUD_MaxDiapasonSpeed.Name = "numUD_MaxDiapasonSpeed";
            this.numUD_MaxDiapasonSpeed.ReadOnly = true;
            this.numUD_MaxDiapasonSpeed.Size = new System.Drawing.Size(75, 28);
            this.numUD_MaxDiapasonSpeed.TabIndex = 22;
            this.numUD_MaxDiapasonSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUD_MaxDiapasonSpeed.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUD_MaxDiapasonSpeed.ValueChanged += new System.EventHandler(this.numUD_MaxDiapasonSpeed_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(185, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Макс.";
            // 
            // dataGridView_ForDiaposon
            // 
            this.dataGridView_ForDiaposon.AllowUserToAddRows = false;
            this.dataGridView_ForDiaposon.AllowUserToDeleteRows = false;
            this.dataGridView_ForDiaposon.AllowUserToOrderColumns = true;
            this.dataGridView_ForDiaposon.AllowUserToResizeRows = false;
            this.dataGridView_ForDiaposon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ForDiaposon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ForDiaposon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.872038F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ForDiaposon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_ForDiaposon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ForDiaposon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSpeed,
            this.ColumnDate,
            this.ColumnTime,
            this.ColumnDayOfWeek});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.872038F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ForDiaposon.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_ForDiaposon.Location = new System.Drawing.Point(3, 79);
            this.dataGridView_ForDiaposon.Name = "dataGridView_ForDiaposon";
            this.dataGridView_ForDiaposon.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.848341F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ForDiaposon.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_ForDiaposon.RowHeadersVisible = false;
            this.dataGridView_ForDiaposon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_ForDiaposon.RowTemplate.Height = 24;
            this.dataGridView_ForDiaposon.Size = new System.Drawing.Size(583, 243);
            this.dataGridView_ForDiaposon.TabIndex = 20;
            // 
            // ColumnSpeed
            // 
            this.ColumnSpeed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSpeed.HeaderText = "Скорость";
            this.ColumnSpeed.MinimumWidth = 7;
            this.ColumnSpeed.Name = "ColumnSpeed";
            this.ColumnSpeed.ReadOnly = true;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Дата";
            this.ColumnDate.MinimumWidth = 7;
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Время";
            this.ColumnTime.MinimumWidth = 7;
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            // 
            // ColumnDayOfWeek
            // 
            this.ColumnDayOfWeek.HeaderText = "День недели";
            this.ColumnDayOfWeek.MinimumWidth = 7;
            this.ColumnDayOfWeek.Name = "ColumnDayOfWeek";
            this.ColumnDayOfWeek.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ClearTBsDistSpeed);
            this.panel2.Controls.Add(this.GroupBox6);
            this.panel2.Controls.Add(this.GroupBox7);
            this.panel2.Controls.Add(this.GroupBox1);
            this.panel2.Controls.Add(this.GroupBox8);
            this.panel2.Controls.Add(this.GroupBox2);
            this.panel2.Controls.Add(this.GroupBox11);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.GroupBox10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 335);
            this.panel2.TabIndex = 23;
            // 
            // btn_ClearTBsDistSpeed
            // 
            this.btn_ClearTBsDistSpeed.Location = new System.Drawing.Point(23, 166);
            this.btn_ClearTBsDistSpeed.Name = "btn_ClearTBsDistSpeed";
            this.btn_ClearTBsDistSpeed.Size = new System.Drawing.Size(149, 23);
            this.btn_ClearTBsDistSpeed.TabIndex = 17;
            this.btn_ClearTBsDistSpeed.Text = "Очистить";
            this.btn_ClearTBsDistSpeed.UseVisualStyleBackColor = true;
            this.btn_ClearTBsDistSpeed.Click += new System.EventHandler(this.btn_ClearTBsDistSpeed_Click);
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.label_DayTravel);
            this.GroupBox6.Location = new System.Drawing.Point(285, 13);
            this.GroupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox6.Size = new System.Drawing.Size(96, 72);
            this.GroupBox6.TabIndex = 9;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "Дней";
            // 
            // label_DayTravel
            // 
            this.label_DayTravel.AutoSize = true;
            this.label_DayTravel.BackColor = System.Drawing.Color.Transparent;
            this.label_DayTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_DayTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DayTravel.Location = new System.Drawing.Point(12, 18);
            this.label_DayTravel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DayTravel.Name = "label_DayTravel";
            this.label_DayTravel.Size = new System.Drawing.Size(66, 46);
            this.label_DayTravel.TabIndex = 5;
            this.label_DayTravel.Text = "00";
            this.label_DayTravel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox7
            // 
            this.GroupBox7.Controls.Add(this.label_HourTravel);
            this.GroupBox7.Location = new System.Drawing.Point(393, 13);
            this.GroupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox7.Size = new System.Drawing.Size(93, 72);
            this.GroupBox7.TabIndex = 10;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "Часов";
            // 
            // label_HourTravel
            // 
            this.label_HourTravel.AutoSize = true;
            this.label_HourTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_HourTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_HourTravel.Location = new System.Drawing.Point(11, 18);
            this.label_HourTravel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_HourTravel.Name = "label_HourTravel";
            this.label_HourTravel.Size = new System.Drawing.Size(64, 46);
            this.label_HourTravel.TabIndex = 4;
            this.label_HourTravel.Text = "00";
            this.label_HourTravel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.TB_Distance);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Location = new System.Drawing.Point(15, 13);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(262, 66);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Дистанция в морских милях";
            // 
            // TB_Distance
            // 
            this.TB_Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.128F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Distance.Location = new System.Drawing.Point(8, 19);
            this.TB_Distance.MaxLength = 8;
            this.TB_Distance.Name = "TB_Distance";
            this.TB_Distance.Size = new System.Drawing.Size(149, 38);
            this.TB_Distance.TabIndex = 3;
            this.TB_Distance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TB_Distance.TextChanged += new System.EventHandler(this.TB_Distance_TextChanged);
            this.TB_Distance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Distance_KeyPress);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label6.Location = new System.Drawing.Point(167, 22);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 31);
            this.Label6.TabIndex = 2;
            this.Label6.Text = "Миль";
            // 
            // GroupBox8
            // 
            this.GroupBox8.Controls.Add(this.label_MinuteTravel);
            this.GroupBox8.Location = new System.Drawing.Point(498, 13);
            this.GroupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox8.Size = new System.Drawing.Size(80, 72);
            this.GroupBox8.TabIndex = 11;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "Минут";
            // 
            // label_MinuteTravel
            // 
            this.label_MinuteTravel.AutoSize = true;
            this.label_MinuteTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_MinuteTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_MinuteTravel.Location = new System.Drawing.Point(11, 19);
            this.label_MinuteTravel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MinuteTravel.Name = "label_MinuteTravel";
            this.label_MinuteTravel.Size = new System.Drawing.Size(55, 39);
            this.label_MinuteTravel.TabIndex = 6;
            this.label_MinuteTravel.Text = "00";
            this.label_MinuteTravel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.TB_Speed);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Location = new System.Drawing.Point(15, 92);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(262, 66);
            this.GroupBox2.TabIndex = 3;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Скорость в Узлах";
            // 
            // TB_Speed
            // 
            this.TB_Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.128F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Speed.Location = new System.Drawing.Point(8, 18);
            this.TB_Speed.MaxLength = 5;
            this.TB_Speed.Name = "TB_Speed";
            this.TB_Speed.Size = new System.Drawing.Size(149, 38);
            this.TB_Speed.TabIndex = 4;
            this.TB_Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TB_Speed.TextChanged += new System.EventHandler(this.TB_Speed_TextChanged);
            this.TB_Speed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Speed_KeyPress);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label5.Location = new System.Drawing.Point(167, 21);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(71, 31);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "Уз/Ч";
            // 
            // GroupBox11
            // 
            this.GroupBox11.Controls.Add(this.label_DayOfWeekETA);
            this.GroupBox11.Controls.Add(this.label_TimeETA);
            this.GroupBox11.Controls.Add(this.label_DateETA);
            this.GroupBox11.Location = new System.Drawing.Point(285, 92);
            this.GroupBox11.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox11.Size = new System.Drawing.Size(293, 115);
            this.GroupBox11.TabIndex = 13;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "ETA от настоящего времени";
            // 
            // label_DayOfWeekETA
            // 
            this.label_DayOfWeekETA.AutoSize = true;
            this.label_DayOfWeekETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DayOfWeekETA.Location = new System.Drawing.Point(109, 61);
            this.label_DayOfWeekETA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DayOfWeekETA.Name = "label_DayOfWeekETA";
            this.label_DayOfWeekETA.Size = new System.Drawing.Size(183, 29);
            this.label_DayOfWeekETA.TabIndex = 13;
            this.label_DayOfWeekETA.Text = "[понедельник]";
            // 
            // label_TimeETA
            // 
            this.label_TimeETA.AutoSize = true;
            this.label_TimeETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TimeETA.Location = new System.Drawing.Point(13, 61);
            this.label_TimeETA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TimeETA.Name = "label_TimeETA";
            this.label_TimeETA.Size = new System.Drawing.Size(96, 36);
            this.label_TimeETA.TabIndex = 12;
            this.label_TimeETA.Text = "TRLbl";
            // 
            // label_DateETA
            // 
            this.label_DateETA.AutoSize = true;
            this.label_DateETA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DateETA.Location = new System.Drawing.Point(13, 25);
            this.label_DateETA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DateETA.Name = "label_DateETA";
            this.label_DateETA.Size = new System.Drawing.Size(202, 36);
            this.label_DateETA.TabIndex = 8;
            this.label_DateETA.Text = "DateResultLbl";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.DateTimePick);
            this.groupBox3.Controls.Add(this.btn_Reset);
            this.groupBox3.Controls.Add(this.numericUpD_Minute);
            this.groupBox3.Controls.Add(this.Label_HourForNumUDHour);
            this.groupBox3.Controls.Add(this.numericUpD_Hour);
            this.groupBox3.Controls.Add(this.Label_HourForNumUDMinute);
            this.groupBox3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox3.Location = new System.Drawing.Point(10, 210);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(264, 115);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Время отхода (ETD)";
            // 
            // DateTimePick
            // 
            this.DateTimePick.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 24.192F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTimePick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTimePick.Location = new System.Drawing.Point(8, 23);
            this.DateTimePick.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePick.Name = "DateTimePick";
            this.DateTimePick.Size = new System.Drawing.Size(246, 34);
            this.DateTimePick.TabIndex = 5;
            this.DateTimePick.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // btn_Reset
            // 
            this.btn_Reset.ForeColor = System.Drawing.Color.Black;
            this.btn_Reset.Location = new System.Drawing.Point(201, 65);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(53, 35);
            this.btn_Reset.TabIndex = 6;
            this.btn_Reset.Text = "RST";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // numericUpD_Minute
            // 
            this.numericUpD_Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpD_Minute.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpD_Minute.Location = new System.Drawing.Point(105, 65);
            this.numericUpD_Minute.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpD_Minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpD_Minute.Name = "numericUpD_Minute";
            this.numericUpD_Minute.Size = new System.Drawing.Size(60, 34);
            this.numericUpD_Minute.TabIndex = 8;
            this.numericUpD_Minute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpD_Minute.ValueChanged += new System.EventHandler(this.MinuteNumericUpDown_ValueChanged);
            // 
            // Label_HourForNumUDHour
            // 
            this.Label_HourForNumUDHour.AutoSize = true;
            this.Label_HourForNumUDHour.BackColor = System.Drawing.Color.Transparent;
            this.Label_HourForNumUDHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_HourForNumUDHour.ForeColor = System.Drawing.Color.Black;
            this.Label_HourForNumUDHour.Location = new System.Drawing.Point(73, 67);
            this.Label_HourForNumUDHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_HourForNumUDHour.Name = "Label_HourForNumUDHour";
            this.Label_HourForNumUDHour.Size = new System.Drawing.Size(30, 29);
            this.Label_HourForNumUDHour.TabIndex = 4;
            this.Label_HourForNumUDHour.Text = "Ч";
            this.Label_HourForNumUDHour.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Label_HourForNumUDHour_MouseDoubleClick);
            // 
            // numericUpD_Hour
            // 
            this.numericUpD_Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpD_Hour.Location = new System.Drawing.Point(8, 65);
            this.numericUpD_Hour.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpD_Hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpD_Hour.Name = "numericUpD_Hour";
            this.numericUpD_Hour.Size = new System.Drawing.Size(60, 34);
            this.numericUpD_Hour.TabIndex = 6;
            this.numericUpD_Hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpD_Hour.ValueChanged += new System.EventHandler(this.HourNumericUpDown_ValueChanged);
            // 
            // Label_HourForNumUDMinute
            // 
            this.Label_HourForNumUDMinute.AutoSize = true;
            this.Label_HourForNumUDMinute.BackColor = System.Drawing.Color.Transparent;
            this.Label_HourForNumUDMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_HourForNumUDMinute.ForeColor = System.Drawing.Color.Black;
            this.Label_HourForNumUDMinute.Location = new System.Drawing.Point(170, 67);
            this.Label_HourForNumUDMinute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_HourForNumUDMinute.Name = "Label_HourForNumUDMinute";
            this.Label_HourForNumUDMinute.Size = new System.Drawing.Size(33, 29);
            this.Label_HourForNumUDMinute.TabIndex = 5;
            this.Label_HourForNumUDMinute.Text = "М";
            this.Label_HourForNumUDMinute.DoubleClick += new System.EventHandler(this.Label_HourForNumUDMinute_DoubleClick);
            // 
            // GroupBox10
            // 
            this.GroupBox10.Controls.Add(this.label_DayOfWeekFmETD);
            this.GroupBox10.Controls.Add(this.label_TimeFmETD);
            this.GroupBox10.Controls.Add(this.label_DateFmETD);
            this.GroupBox10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.GroupBox10.Location = new System.Drawing.Point(285, 214);
            this.GroupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox10.Size = new System.Drawing.Size(293, 115);
            this.GroupBox10.TabIndex = 15;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "ETA от заданных даты и времени";
            // 
            // label_DayOfWeekFmETD
            // 
            this.label_DayOfWeekFmETD.AutoSize = true;
            this.label_DayOfWeekFmETD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DayOfWeekFmETD.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_DayOfWeekFmETD.Location = new System.Drawing.Point(109, 59);
            this.label_DayOfWeekFmETD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DayOfWeekFmETD.Name = "label_DayOfWeekFmETD";
            this.label_DayOfWeekFmETD.Size = new System.Drawing.Size(183, 29);
            this.label_DayOfWeekFmETD.TabIndex = 13;
            this.label_DayOfWeekFmETD.Text = "[понедельник]";
            // 
            // label_TimeFmETD
            // 
            this.label_TimeFmETD.AutoSize = true;
            this.label_TimeFmETD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TimeFmETD.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_TimeFmETD.Location = new System.Drawing.Point(13, 57);
            this.label_TimeFmETD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TimeFmETD.Name = "label_TimeFmETD";
            this.label_TimeFmETD.Size = new System.Drawing.Size(94, 36);
            this.label_TimeFmETD.TabIndex = 12;
            this.label_TimeFmETD.Text = "TPLbl";
            // 
            // label_DateFmETD
            // 
            this.label_DateFmETD.AutoSize = true;
            this.label_DateFmETD.BackColor = System.Drawing.Color.Transparent;
            this.label_DateFmETD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DateFmETD.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_DateFmETD.Location = new System.Drawing.Point(13, 23);
            this.label_DateFmETD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DateFmETD.Name = "label_DateFmETD";
            this.label_DateFmETD.Size = new System.Drawing.Size(205, 36);
            this.label_DateFmETD.TabIndex = 11;
            this.label_DateFmETD.Text = "OptionDateLbl";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 693);
            this.tabControl1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Exit,
            this.toolStripButton_About});
            this.toolStrip1.Location = new System.Drawing.Point(0, 662);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(604, 31);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Exit
            // 
            this.toolStripButton_Exit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_Exit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.toolStripButton_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Exit.ForeColor = System.Drawing.Color.White;
            this.toolStripButton_Exit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Exit.Image")));
            this.toolStripButton_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Exit.Name = "toolStripButton_Exit";
            this.toolStripButton_Exit.Size = new System.Drawing.Size(97, 28);
            this.toolStripButton_Exit.Text = "     Выход     ";
            this.toolStripButton_Exit.Click += new System.EventHandler(this.toolStripButton_Exit_Click);
            // 
            // toolStripButton_About
            // 
            this.toolStripButton_About.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_About.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripButton_About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_About.ForeColor = System.Drawing.Color.White;
            this.toolStripButton_About.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_About.Image")));
            this.toolStripButton_About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_About.Name = "toolStripButton_About";
            this.toolStripButton_About.Size = new System.Drawing.Size(108, 28);
            this.toolStripButton_About.Text = "О программе";
            this.toolStripButton_About.Click += new System.EventHandler(this.toolStripButton_About_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 693);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(620, 740);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_MinDiapasonSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_GradationSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_MaxDiapasonSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ForDiaposon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox11.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpD_Minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpD_Hour)).EndInit();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        internal System.Windows.Forms.Button btn_Reset;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox TB_Distance;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label_HourForNumUDMinute;
        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.TextBox TB_Speed;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label_HourForNumUDHour;
        internal System.Windows.Forms.NumericUpDown numericUpD_Minute;
        internal System.Windows.Forms.DateTimePicker DateTimePick;
        internal System.Windows.Forms.NumericUpDown numericUpD_Hour;
        internal System.Windows.Forms.GroupBox GroupBox11;
        internal System.Windows.Forms.Label label_DayOfWeekETA;
        internal System.Windows.Forms.Label label_TimeETA;
        internal System.Windows.Forms.Label label_DateETA;
        internal System.Windows.Forms.GroupBox GroupBox10;
        internal System.Windows.Forms.Label label_DayOfWeekFmETD;
        internal System.Windows.Forms.Label label_TimeFmETD;
        internal System.Windows.Forms.Label label_DateFmETD;
        internal System.Windows.Forms.GroupBox GroupBox8;
        internal System.Windows.Forms.Label label_MinuteTravel;
        internal System.Windows.Forms.GroupBox GroupBox7;
        internal System.Windows.Forms.Label label_HourTravel;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.Label label_DayTravel;
        private System.Windows.Forms.TabControl tabControl1;
        internal System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_ForDiaposon;
        internal System.Windows.Forms.NumericUpDown numUD_MinDiapasonSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDayOfWeek;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.NumericUpDown numUD_MaxDiapasonSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.NumericUpDown numUD_GradationSpeed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ClearTBsDistSpeed;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Exit;
        private System.Windows.Forms.ToolStripButton toolStripButton_About;
    }
}

