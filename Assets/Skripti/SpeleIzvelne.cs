using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SpeleIzvelne : MonoBehaviour
{
    public Dropdown Ieroci;
    public Dropdown Aina;
    public Dropdown Merki;
    public Dropdown Muzika;
    public void Start()
    {
        Ieroci.value = PlayerPrefs.GetInt("Ieroics");

        Ieroci.onValueChanged.AddListener(delegate { Idrop(Ieroci); });

        Aina.value = PlayerPrefs.GetInt("Ainas");

        Aina.onValueChanged.AddListener(delegate { Adrop(Aina); });

        Merki.value = PlayerPrefs.GetInt("Merkis");

        Merki.onValueChanged.AddListener(delegate { Medrop(Merki); });
    }
    public void Idrop(Dropdown Ieroci)
    {
        switch (Ieroci.value)
        {
            case 0:
                PlayerPrefs.SetInt("Ieroics", 0);
                PlayerPrefs.Save();

                break;
            case 1:
                PlayerPrefs.SetInt("Ieroics", 1);
                PlayerPrefs.Save();
                break;
            case 2:
                PlayerPrefs.SetInt("Ieroics", 2);
                PlayerPrefs.Save();
                break;
        }
    }

    public void Adrop(Dropdown Aina)
    {
        switch (Aina.value)
        {
            case 0:
                PlayerPrefs.SetInt("Ainas", 0);
                PlayerPrefs.Save();

                break;
            case 1:
                PlayerPrefs.SetInt("Ainas", 1);
                PlayerPrefs.Save();
                break;
            case 2:
                PlayerPrefs.SetInt("Ainas", 2);
                PlayerPrefs.Save();
                break;
        }
    }
    
    public void Medrop(Dropdown Merkis)
    {
        switch (Merkis.value)
        {
            case 0:
                PlayerPrefs.SetInt("Merkis", 0);
                PlayerPrefs.Save();

                break;
            case 1:
                PlayerPrefs.SetInt("Merkis", 1);
                PlayerPrefs.Save();
                break;
            case 2:
                PlayerPrefs.SetInt("Merkis", 2);
                PlayerPrefs.Save();
                break;
        }
    }

}

