using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Iestatijumi : MonoBehaviour
{
    public Slider FieldOFView;
    public Text FOV;
    void Start()
    {
        FOV.text = PlayerPrefs.GetFloat("FOV") + "";
        FieldOFView.value = PlayerPrefs.GetFloat("FOV");
        FieldOFView.onValueChanged.AddListener(delegate { UpdateFOV(FieldOFView); });

    }
    public void UpdateFOV(Slider FieldOFView)
    {
        FOV.text = FieldOFView.value + "";
        PlayerPrefs.SetFloat("FOV", FieldOFView.value);
    }
}
