using PhoneNumbers;

namespace Elmahdi.Phone
{
    public static class ValidatePhoneNumber
    {
        public static bool IsValidPhoneNumberFor(this string phone, string country = "GB")
        {
            if (string.IsNullOrEmpty(phone))
            {
                return false;
            }

            try
            {
                var phoneUtil = PhoneNumberUtil.GetInstance();
                var number = phoneUtil.Parse(phone, country);
                return phoneUtil.IsValidNumber(number);
            }
            catch
            {
                return false;
            }
        }
    }
}