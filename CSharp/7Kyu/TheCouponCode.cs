using System;
using System.Globalization;

public static class Kata
{
    public static bool
    CheckCoupon(
        string enteredCode,
        string correctCode,
        string currentDate,
        string expirationDate
    )
    {
        if (
            string.IsNullOrWhiteSpace(enteredCode) ||
            string.IsNullOrWhiteSpace(correctCode) ||
            string.IsNullOrWhiteSpace(currentDate) ||
            string.IsNullOrWhiteSpace(expirationDate)
        )
        {
            return false;
        }

        if (enteredCode != correctCode)
        {
            return false;
        }

        DateTime current =
            DateTime
                .Parse(currentDate.Replace(",", ""),
                CultureInfo.GetCultureInfo("en-GB"));
        DateTime expiration =
            DateTime
                .Parse(expirationDate.Replace(",", ""),
                CultureInfo.GetCultureInfo("en-GB"));

        if (current.Date > expiration.Date)
        {
            return false;
        }

        return true;
    }
}
