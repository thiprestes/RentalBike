namespace RentalMotorcycle.Data.Helper;

public static class StringsExtension
{
    public static string FormatWith(
        this string format,
        params object?[] args)
    {
        if (args is null)
        {
            return format;
        }

        return string.Format(format, args);
    }    
}