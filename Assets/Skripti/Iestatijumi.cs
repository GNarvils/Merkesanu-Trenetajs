using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class Iestatijumi : MonoBehaviour
{
    public Slider FieldOFView;
    public Text FOV;
    public Slider Atrums;
    public Text sens;
    public Dropdown resolution;
    Resolution[] resolutions;
    public List<Resolution> filtrs;
    public float hz;
    public AudioMixer audioMix;
    public Slider Skana;
    public Dropdown Temeklis;
    public Slider Tizmers;
    public Text TI;
    void Start()
    {

        TI.text = PlayerPrefs.GetFloat("TemeklisIz") + "";
        Tizmers.value = PlayerPrefs.GetFloat("TemeklisIz");
        Tizmers.onValueChanged.AddListener(delegate { UpdateIzmers(Tizmers); });

        Temeklis.value = PlayerPrefs.GetInt("Temeklis");
        Temeklis.onValueChanged.AddListener(delegate { Tdrop(Temeklis); });

        FOV.text = PlayerPrefs.GetFloat("FOV") + "";
        FieldOFView.value = PlayerPrefs.GetFloat("FOV");
        FieldOFView.onValueChanged.AddListener(delegate { UpdateFOV(FieldOFView); });

        sens.text = PlayerPrefs.GetFloat("SensX") + "";
        Atrums.value = PlayerPrefs.GetFloat("SensX");
        Atrums.onValueChanged.AddListener(delegate { UpdateSens(Atrums); });

        resolutions = Screen.resolutions;
        resolution.ClearOptions();
        filtrs = new List<Resolution>();
        hz = Screen.currentResolution.refreshRate;

        for (int i = 0; i < resolutions.Length; i++) {
            if (resolutions[i].refreshRate == hz) {
                filtrs.Add(resolutions[i]);
            }
        }

        List<string> options = new List<string>();

        int tagad = 0;

        for (int i = 0; i < filtrs.Count; i++) {
            string option = filtrs[i].width + " x " + filtrs[i].height + " "+filtrs[i].refreshRate+ " Hz";
            options.Add(option);

            if (filtrs[i].width == Screen.currentResolution.width && filtrs[i].height == Screen.currentResolution.height) {
                tagad = i;
            }
        }

        resolution.AddOptions(options);
        resolution.value = tagad;
        resolution.RefreshShownValue();

        Skana.value = PlayerPrefs.GetFloat("vol");
    }
    public void SetResolution(int tagad) {
        Resolution resolution = filtrs[tagad];
        Screen.SetResolution(resolution.width, resolution.height, true);
    }

    public void UpdateFOV(Slider FieldOFView)
    {
        FOV.text = FieldOFView.value + "";
        PlayerPrefs.SetFloat("FOV", FieldOFView.value);
    }
    public void SetVolume(float vol) {
        audioMix.SetFloat("vol", vol);
        PlayerPrefs.SetFloat("vol", vol);
    }

    public void UpdateSens(Slider Atrums)
    {
        sens.text = Atrums.value + "";
        PlayerPrefs.SetFloat("SensX", Atrums.value);
        PlayerPrefs.SetFloat("SensY", Atrums.value);
    }

    public void Tdrop(Dropdown Temeklis)
    {
        switch (Temeklis.value)
        {
            case 0:
                PlayerPrefs.SetInt("Temeklis", 0);
                PlayerPrefs.Save();

                break;
            case 1:
                PlayerPrefs.SetInt("Temeklis", 1);
                PlayerPrefs.Save();
                break;
            case 2:
                PlayerPrefs.SetInt("Temeklis", 2);
                PlayerPrefs.Save();
                break;
        }
    }
    public void UpdateIzmers(Slider Tizmers)
    {
        TI.text = (Mathf.Round(Tizmers.value * 100f)) / 100f + "";
        PlayerPrefs.SetFloat("TemeklisIz", Tizmers.value);
    }
}
