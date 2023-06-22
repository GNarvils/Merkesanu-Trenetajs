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
    public Dropdown resolution;
    Resolution[] resolutions;
    public List<Resolution> filtrs;
    public float hz;
    void Start()
    {
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

    public void UpdateSens(Slider Atrums)
    {
        sens.text = Atrums.value + "";
        PlayerPrefs.SetFloat("SensX", Atrums.value);
        PlayerPrefs.SetFloat("SensY", Atrums.value);
    }
}
