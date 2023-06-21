using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pasveidu : MonoBehaviour
{
    public Slider laiks;
    public Text laik;
    public Slider izmers;
    public Text izmer;
    void Start()
    {
        laik.text = PlayerPrefs.GetFloat("Laiks") + "";
        laiks.value = PlayerPrefs.GetFloat("Laiks");
        laiks.onValueChanged.AddListener(delegate { UpdateL(laiks); });

        izmer.text = PlayerPrefs.GetFloat("Izmers") + "";
        izmers.value = PlayerPrefs.GetFloat("Izmers");
        izmers.onValueChanged.AddListener(delegate { UpdateI(izmers); });

    }
    public void UpdateL(Slider laiks) {
        laik.text = laiks.value + "";
        PlayerPrefs.SetFloat("Laiks", laiks.value);
    }

    public void UpdateI(Slider izmers)
    {
        izmer.text = (Mathf.Round(izmers.value*100f))/100f + "";
        PlayerPrefs.SetFloat("Izmers", izmers.value);
    }


}
