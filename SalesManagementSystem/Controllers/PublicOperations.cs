
using System.Text.RegularExpressions;

namespace SalesManagementSystem.Controllers
{
    public class PublicOperations
    {
        public static bool CheckArabicCharsOnly(string text)
        {
            Regex rg = new Regex("^[\\u0600-\\u06ff\\s]+$");
            return rg.IsMatch(text);
        }
        //^\+[0-9]{7}$
        public static bool CheckNumbersOnly(string text)
        {
            Regex rg = new Regex("^[0-9]*$");
            return rg.IsMatch(text);
        }

        public static bool CheckDecimal(string text)
        {
            Regex rg = new Regex(@"^-?(0|[1-9]\d*)(\.\d*)?$"); //^-?(0|[1-9]\d*)(\.\d*)?$
            return rg.IsMatch(text);
        }

        public static bool CheckPhoneNumber(string text)
        {
            string internationalPattern = @"^\+\w{7,}$";
            string localPattern = @"^7[0-9]{8}$";
            Regex rg = new Regex(internationalPattern);
            Regex rg2 = new Regex(localPattern);
            return rg.IsMatch(text) || rg2.IsMatch(text);
        }
    }
}
