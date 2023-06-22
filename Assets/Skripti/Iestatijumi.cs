using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Iestatijumi : MonoBehaviour
{
    public Slider FieldOFView;
    public Text FOV;
    public Slider Atrums;
    public Text sens;
    void Start()
    {
        FOV.text = PlayerPrefs.GetFloat("FOV") + "";
        FieldOFView.value = PlayerPrefs.GetFloat("FOV");
        FieldOFView.onValueChanged.AddListener(delegate { UpdateFOV(FieldOFView); });

        sens.text = PlayerPrefs.GetFloat("SensX") + "";
        Atrums.value = PlayerPrefs.GetFloat("SensX");
        Atrums.onValueChanged.AddListener(delegate { UpdateSens(Atrums); });

    }
    public void UpdateFOV(Slider FieldOFView)
    {
        FOV.text = FieldOFView.value + "";
        PlayerPrefs.SetFloat("FOV", FieldOFView.value);
    }

    public void UpdateSens(Slider Atrums)
    {
        sens.text = Atrums.value + "";
        PlayerPrefs.SetFloat("SensX", Atrums.value);
        PlayerPrefs.SetFloat("SensY", Atrums.value);
    }
}
