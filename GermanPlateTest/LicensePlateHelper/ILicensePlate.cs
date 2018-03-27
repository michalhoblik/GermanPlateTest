namespace GermanPlateTest.LicensePlateHelper
{
    public interface ILicensePlate
    {
        string Format();
        bool IsValid();
        string GetTwoLetterISO();
        string GetThreeLetterISO();
    }
}
