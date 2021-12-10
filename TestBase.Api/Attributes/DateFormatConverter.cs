using Newtonsoft.Json.Converters;

namespace TestBase.Api.Attributes
{
    public class DateFormatConverter : IsoDateTimeConverter
    {
        public DateFormatConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}
