using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization;
using System;

public class LanguageChange : MonoBehaviour
{
    public TMP_Text Number;
    
    public void SetLocal(Locale locale)
    {
        LocalizationSettings.SelectedLocale = locale;
    }

    public void LangDropdown(int index)
    {
        Debug.Log(index);
        switch (index)
        {
            case 0:
                SetLocal(LocalizationSettings.AvailableLocales.Locales[3]);
                break;
            case 1:
                SetLocal(LocalizationSettings.AvailableLocales.Locales[1]);
                break;
            case 2:
                SetLocal(LocalizationSettings.AvailableLocales.Locales[2]);
                break;
            case 3:
                SetLocal(LocalizationSettings.AvailableLocales.Locales[0]);
                break;
        }
    }
}
