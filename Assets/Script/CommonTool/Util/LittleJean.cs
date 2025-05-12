using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleJean
{
    public static string SummerMyNut(double a)
    {
        string str = Math.Round(a, 2).ToString("f2");
        string language = I2.Loc.LocalizationManager.CurrentLanguage;
        if (language == "Russian" || language == "Portuguese (Brazil)")
            str = str.Replace(".", ",");
        return str;
    }

    public static double Stair(double a)
    {
        return Math.Round(a, RetoolLazily.StairPlunge);
    }
}
