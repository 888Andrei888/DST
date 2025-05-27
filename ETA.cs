using System;

namespace DST
{
    class ETA
    {
        private double speed;
        private double distance;

        public ETA() { }
        public ETA(double distance, double speed)
        {
            Distance = distance;
            Speed = speed;
        }
        public ETA(double distance, double speed, DateTime ETD_DateTime)
        {
            Distance = distance;
            Speed = speed;
            ETD = ETD_DateTime;
        }

        public double Distance { get => distance; set => distance = value; }
        public double Speed { get => speed; set => speed = value; }
        public DateTime ETD { get; set; } = DateTime.Now;

        public double GetTotalHoursInVoyage()
        {
            return (Distance / Speed).Check_Infinity_NaN();
        }

        public (int days, int hours, int minutes) GetDaysHoursMinutes()
        {
            double totalHoursInVoayge = GetTotalHoursInVoyage();

            int days = (int)(totalHoursInVoayge / 24D);
            int hours = (int)(totalHoursInVoayge % 24D);
            int minutes = (int)((totalHoursInVoayge - Math.Truncate(totalHoursInVoayge)) * 60D);

            return (days, hours, minutes);
        }

        public DateTime GetETAfmNOW()
        {
            return DateTime.Now.AddHours(GetTotalHoursInVoyage());
        }

        public DateTime GetETAfmETD()
        {
            return ETD.AddHours(GetTotalHoursInVoyage());
        }
    }
}