using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Trenini : MonoBehaviour
{
    public Dropdown Trenins;
    public Text Info;
    void Start()
    {
        Trenins.value = PlayerPrefs.GetInt("Trenins");

        Trenins.onValueChanged.AddListener(delegate { Tdrop(Trenins); });
        if (Trenins.value == 0)
        {
            Info.text = "�aj� re��m� tev ir dotas 60 sekundes un viens m�r�is. No�auj cik vien daudz reizes to vienu m�r�i cik vari!";
        }
        else if (Trenins.value == 1)
        {
            Info.text = "�aj� re��m� tev ir dotas 60 sekundes un pieci m�r�is. No�auj cik vien daudz m�r�us tu vari dotaj� laik�!";
        }
        else if (Trenins.value == 2) {
            Info.text = "Noteikumi t�di pa�i, k� vien�au�anas re��m� tikai tagad ir dota iesp�ja main�t sp�les laiku un m�r�u lielumu.";
        }
    }
    public void Tdrop(Dropdown Trenins) {
        switch (Trenins.value)
        {
            case 0:
                PlayerPrefs.SetInt("Trenins", 0);
                PlayerPrefs.Save();
                Info.text = "�aj� re��m� tev ir dotas 60 sekundes un viens m�r�is. No�auj cik vien daudz reizes to vienu m�r�i cik vari!";
                break;
            case 1:
                PlayerPrefs.SetInt("Trenins", 1);
                PlayerPrefs.Save();
                Info.text = "�aj� re��m� tev ir dotas 60 sekundes un pieci m�r�is. No�auj cik vien daudz m�r�us tu vari dotaj� laik�!";
                break;
            case 2:
                PlayerPrefs.SetInt("Trenins", 2);
                PlayerPrefs.Save();
                Info.text = "Noteikumi t�di pa�i, k� vien�au�anas re��m� tikai tagad ir dota iesp�ja main�t sp�les laiku un m�r�u lielumu.";
                break;
        }
    }
}
