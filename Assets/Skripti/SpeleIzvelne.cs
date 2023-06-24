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
    public Text SRekords;
    public Text MRekords;

    public void Awake() {
    SRekords.text = PlayerPrefs.GetFloat("Single") + "";
    MRekords.text = PlayerPrefs.GetFloat("Multi") + "";
    }

    public void Start()
    {
        Ieroci.value = PlayerPrefs.GetInt("Ieroics");

        Ieroci.onValueChanged.AddListener(delegate { Idrop(Ieroci); });

        Aina.value = PlayerPrefs.GetInt("Ainas");

        Aina.onValueChanged.AddListener(delegate { Adrop(Aina); });

        Merki.value = PlayerPrefs.GetInt("Merkis");

        Merki.onValueChanged.AddListener(delegate { Medrop(Merki); });

        Muzika.value = PlayerPrefs.GetInt("Muzikas");

        Muzika.onValueChanged.AddListener(delegate { Mudrop(Muzika); });
    }
    public void Update() {
        SRekords.text = PlayerPrefs.GetFloat("Single") + "";
        MRekords.text = PlayerPrefs.GetFloat("Multi") + "";
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
   
    public void Mudrop(Dropdown Muzika)
    {
        switch (Muzika.value)
        {
            case 0:
                PlayerPrefs.SetInt("Muzikas", 0);
                PlayerPrefs.Save();

                break;
            case 1:
                PlayerPrefs.SetInt("Muzikas", 1);
                PlayerPrefs.Save();
                break;
            case 2:
                PlayerPrefs.SetInt("Muzikas", 2);
                PlayerPrefs.Save();
                break;
        }
    }


}

