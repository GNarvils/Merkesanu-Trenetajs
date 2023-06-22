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
            Info.text = "Ðajâ reþîmâ tev ir dotas 60 sekundes un viens mçríis. Noðauj cik vien daudz reizes to vienu mçríi cik vari!";
        }
        else if (Trenins.value == 1)
        {
            Info.text = "Ðajâ reþîmâ tev ir dotas 60 sekundes un pieci mçríis. Noðauj cik vien daudz mçríus tu vari dotajâ laikâ!";
        }
        else if (Trenins.value == 2) {
            Info.text = "Noteikumi tâdi paði, kâ vienðauðanas reþîmâ tikai tagad ir dota iespçja mainît spçles laiku un mçríu lielumu.";
        }
    }
    public void Tdrop(Dropdown Trenins) {
        switch (Trenins.value)
        {
            case 0:
                PlayerPrefs.SetInt("Trenins", 0);
                PlayerPrefs.Save();
                Info.text = "Ðajâ reþîmâ tev ir dotas 60 sekundes un viens mçríis. Noðauj cik vien daudz reizes to vienu mçríi cik vari!";
                break;
            case 1:
                PlayerPrefs.SetInt("Trenins", 1);
                PlayerPrefs.Save();
                Info.text = "Ðajâ reþîmâ tev ir dotas 60 sekundes un pieci mçríis. Noðauj cik vien daudz mçríus tu vari dotajâ laikâ!";
                break;
            case 2:
                PlayerPrefs.SetInt("Trenins", 2);
                PlayerPrefs.Save();
                Info.text = "Noteikumi tâdi paði, kâ vienðauðanas reþîmâ tikai tagad ir dota iespçja mainît spçles laiku un mçríu lielumu.";
                break;
        }
    }
}
