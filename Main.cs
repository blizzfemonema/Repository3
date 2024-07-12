using System;

public static class Helper
{
    public static string GenerareCodUnic(string prefix)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 999);
        string codUnic = prefix + randomNumber;
        return codUnic;
    }
}