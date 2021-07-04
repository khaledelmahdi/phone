using PhoneNumbers;

namespace Elmahdi.Phone
{
    public static class FormatPhoneExtensions
    {
        public static string ToLocalPhoneNumber(this string phone, string country = "GB")
        {
            if (string.IsNullOrEmpty(phone))
            {
                return phone;
            }

            try
            {
                var phoneUtil = PhoneNumberUtil.GetInstance();
                var number = phoneUtil.Parse(phone, country);
                return phoneUtil.Format(number, PhoneNumberFormat.NATIONAL);
            }
            catch
            {
                return phone;
            }
        }

        public static string ToInternationalPhoneNumber(this string phone, string country = "GB")
        {
            if (string.IsNullOrEmpty(phone))
            {
                return phone;
            }

            try
            {
                var phoneUtil = PhoneNumberUtil.GetInstance();
                var number = phoneUtil.Parse(phone, country);
                return phoneUtil.Format(number, PhoneNumberFormat.E164);
            }
            catch
            {
                return phone;
            }
        }
    }
}
