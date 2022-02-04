using System;
using System.IO;
using System.Text;
using Humanizer;

namespace ConsoleAppTemplate
{
    public static class Program
    {
        private static int GetWeeks(int day) => day / 7;

        private static int GetRemainingDays(int day) => day % 7;

        public static string GetEnglishSefira(int day)
        {
            if (day is < 1 or > 49) throw new ArgumentOutOfRangeException();
            var beginning = $"Today is {"day".ToQuantity(day, ShowQuantityAs.Words)}";
            const string ending = "of the Omer.";

            // Less than one week - just days
            if (day < 7) return $"{beginning} {ending}";

            // More than one week - weeks, days, and possibly remaining days
            var week = GetWeeks(day);
            var remainingDays = GetRemainingDays(day);
            var remainingDaysText =
                remainingDays > 0 ? $" and {"day".ToQuantity(remainingDays, ShowQuantityAs.Words)}" : "";
            return
                $"{beginning}, which are {"week".ToQuantity(week, ShowQuantityAs.Words)}{remainingDaysText} {ending}";
        }

        public static void Main()
        {
            StringBuilder output = new();
            for (var i = 1; i <= 49; i++) output.AppendLine(GetEnglishSefira(i));

            var projectDir =
                Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            File.WriteAllText(projectDir + "/SefirahEnglish.txt", output.ToString());
        }
    }
}