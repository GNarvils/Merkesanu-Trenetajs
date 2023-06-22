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

        List<string> options = new List<string>();

        int tagad = 0;

        for (int i = 0; i < resolutions.Length; i++) {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height) {
                tagad = i;
            }
        }

        resolution.AddOptions(options);
        resolution.value = tagad;
        resolution.RefreshShownValue();
    }
    public void SetResolution(int tagad) {
        Resolution resolution = resolutions[tagad];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
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
