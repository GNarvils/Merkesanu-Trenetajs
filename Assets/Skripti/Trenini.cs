using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Trenini : MonoBehaviour
{
    public Dropdown Trenins;

    void Start()
    {
        Trenins.value = PlayerPrefs.GetInt("Trenins");

        Trenins.onValueChanged.AddListener(delegate { Tdrop(Trenins); });
    }
    public void Tdrop(Dropdown Trenins) {
        switch (Trenins.value)
        {
            case 0:
                PlayerPrefs.SetInt("Trenins", 0);
                PlayerPrefs.Save();

                break;
            case 1:
                PlayerPrefs.SetInt("Trenins", 1);
                PlayerPrefs.Save();
                break;
            case 2:
                PlayerPrefs.SetInt("Trenins", 2);
                PlayerPrefs.Save();
                break;
        }
    }
}
