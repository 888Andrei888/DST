using System;
using System.Windows.Forms;

// ETA - expected time of arrival   // ожидаемое время прибытия
// ETD - expected time of departure // ожидаемое время отхода

namespace DST
{
    public partial class MainForm : Form
    {
        const int RESET_TO_ZERO = 0;
        const int MIN_IN_HOUR = 60;

        Timer TimerForUpdateTimeInTitle = new Timer();

        ETA etaClass = new ETA();

        public object Settings { get; private set; }

        public MainForm()
        {
            InitializeComponent();

            UpdateTitleTime(null, null);

            LoadSettings();

            TimerForUpdateTimeInTitle.Enabled = true;
            TimerForUpdateTimeInTitle.Interval = 1000;
            TimerForUpdateTimeInTitle.Tick += UpdateTitleTime;
            TimerForUpdateTimeInTitle.Start();
        }

        void LoadSettings()
        {
            TB_Distance.Text = Properties.Settings.Default.TB_Distance;
            TB_Speed.Text = Properties.Settings.Default.TB_Speed;
            numUD_MaxDiapasonSpeed.Value = Properties.Settings.Default.numUD_MaxDiapasonSpeed;
            numUD_MinDiapasonSpeed.Value = Properties.Settings.Default.numUD_MinDiapasonSpeed;
            numUD_GradationSpeed.Value = Properties.Settings.Default.numUD_GradationSpeed;
        }
        void SaveSettings()
        {
            Properties.Settings.Default.TB_Distance = TB_Distance.Text;
            Properties.Settings.Default.TB_Speed = TB_Speed.Text;
            Properties.Settings.Default.numUD_MaxDiapasonSpeed = numUD_MaxDiapasonSpeed.Value;
            Properties.Settings.Default.numUD_MinDiapasonSpeed = numUD_MinDiapasonSpeed.Value;
            Properties.Settings.Default.numUD_GradationSpeed = numUD_GradationSpeed.Value;

            Properties.Settings.Default.Save();
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            numericUpD_Hour.Value = DateTime.Now.Hour;
            GetResult();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        void UpdateTitleTime(object sender, object e)
        {
            Text = $"DST v1.5.3 | LT: {DateTime.Now:HH:mm, dddd, dd MMMM yyyy}";
        }

        void GetResult()
        {
            etaClass.Distance = TB_Distance.Text.StringToDouble();
            etaClass.Speed = TB_Speed.Text.StringToDouble();
            etaClass.ETD = GetETD();

            ShowETA_AtNow();
            ShowETA_AtETD();
            FillGridForDiapasonOfSpeed();
        }

        DateTime GetETD()
        {
            double hoursToMinutes = (double)(numericUpD_Hour.Value * MIN_IN_HOUR);
            double minutes = (double)numericUpD_Minute.Value;
            return DateTimePick.Value.Date.AddMinutes(hoursToMinutes + minutes);
        }

        void ShowETA_AtNow()
        {
            try
            {
                (int days, int hours, int minutes) = etaClass.GetDaysHoursMinutes();
                label_DayTravel.Text = $"{days:D2}";
                label_HourTravel.Text = $"{hours:D2}";
                label_MinuteTravel.Text = $"{minutes:D2}";
                label_DateETA.Text = $"{etaClass.GetETAfmNOW():dd MMMM yyyy}";
                label_TimeETA.Text = $"{etaClass.GetETAfmNOW():HH:mm}";
                label_DayOfWeekETA.Text = $"{etaClass.GetETAfmNOW():[dddd]}";
            }
            catch (Exception)
            {
                label_DayTravel.Text = $"";
                label_HourTravel.Text = $"";
                label_MinuteTravel.Text = $"";
                label_DateETA.Text = $"";
                label_TimeETA.Text = $"";
                label_DayOfWeekETA.Text = $"";
            }
        }

        void ShowETA_AtETD()
        {
            try
            {
                label_DateFmETD.Text = $"{etaClass.GetETAfmETD():dd MMMM yyyy}";
                label_TimeFmETD.Text = $"{etaClass.GetETAfmETD():HH:mm}";
                label_DayOfWeekFmETD.Text = $"{etaClass.GetETAfmETD():[dddd]}";
            }
            catch (Exception)
            {
                label_DateFmETD.Text = $"";
                label_TimeFmETD.Text = $"";
                label_DayOfWeekFmETD.Text = $"";
            }
        }

        void FillGridForDiapasonOfSpeed()
        {
            double minSpeed = Convert.ToDouble(numUD_MinDiapasonSpeed.Value);
            double maxSpeed = Convert.ToDouble(numUD_MaxDiapasonSpeed.Value);
            double gradation = Convert.ToDouble(numUD_GradationSpeed.Value);

            double countMultiplier = (gradation <= 0.5 ? 2D : 1D);
            double countOfRows = countMultiplier * (maxSpeed - minSpeed) + 1;

            ETA etaDiapasonOfSpeed = new ETA
            {
                Distance = TB_Distance.Text.StringToDouble(),
                Speed = maxSpeed,
                ETD = GetETD()
            };

            dataGridView_ForDiaposon.Rows.Clear();

            for (int i = 0; i < countOfRows; i++)
            {
                dataGridView_ForDiaposon.Rows.Add();
                dataGridView_ForDiaposon.Rows[i].Cells[0].Value = etaDiapasonOfSpeed.Speed;
                dataGridView_ForDiaposon.Rows[i].Cells[1].Value = $"{etaDiapasonOfSpeed.GetETAfmETD(): dd MMMM yyyy}";
                dataGridView_ForDiaposon.Rows[i].Cells[2].Value = $"{etaDiapasonOfSpeed.GetETAfmETD(): HH:mm}";
                dataGridView_ForDiaposon.Rows[i].Cells[3].Value = $"{etaDiapasonOfSpeed.GetETAfmETD(): dddd}";
                etaDiapasonOfSpeed.Speed -= gradation;
            }

        }

        void btn_Reset_Click(object sender, EventArgs e)
        {
            numericUpD_Hour.Value = RESET_TO_ZERO;
            numericUpD_Minute.Value = RESET_TO_ZERO;
            DateTimePick.Value = DateTime.Now;
            GetResult();
        }

        #region Ввод в TextBox   
        void TB_Distance_TextChanged(object sender, EventArgs e)
        {
            GetResult();
        }

        void TB_Distance_KeyPress(object sender, KeyPressEventArgs e)
        {
            ServeClass.InputDoubleOnlyPositive(sender, e);
        }

        void TB_Speed_TextChanged(object sender, EventArgs e)
        {
            GetResult();
        }

        void TB_Speed_KeyPress(object sender, KeyPressEventArgs e)
        {
            ServeClass.InputDoubleOnlyPositive(sender, e);
        }

        private void btn_ClearTBsDistSpeed_Click(object sender, EventArgs e)
        {
            TB_Distance.Text = "";
            TB_Speed.Text = "";
        }
        #endregion

        #region Ввод ETD DateTimePicker UpDownNumeric
        void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GetResult();
        }

        void HourNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            GetResult();
        }

        void MinuteNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            GetResult();
        }

        void Label_HourForNumUDHour_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            numericUpD_Hour.Value = 0;
        }

        void Label_HourForNumUDMinute_DoubleClick(object sender, EventArgs e)
        {
            numericUpD_Minute.Value = 0;
        }
        #endregion

        #region Пункты верхенго и нижнего Меню
        void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }
        void exitFmAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Application.Exit();
        }
        private void toolStripButton_Exit_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Application.Exit();
        }
        #endregion

        #region Градация скорости от ETD
        void numUD_MinDiapasonSpeed_ValueChanged(object sender, EventArgs e)
        {
            FillGridForDiapasonOfSpeed();
        }
        void numUD_MaxDiapasonSpeed_ValueChanged(object sender, EventArgs e)
        {
            FillGridForDiapasonOfSpeed();
        }
        void numUD_GradationSpeed_ValueChanged(object sender, EventArgs e)
        {
            FillGridForDiapasonOfSpeed();
        }


        #endregion

        private void toolStripButton_About_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }
    }
}
