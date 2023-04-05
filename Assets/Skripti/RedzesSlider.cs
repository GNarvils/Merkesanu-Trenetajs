using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RedzesSlider: MonoBehaviour {
	[SerializeField] Slider redzesslider;
	[SerializeField] private Text teksts;
	// Use this for initialization
	void Start ()
	{
		if (!PlayerPrefs.HasKey ("veletaskana"))
		{
			PlayerPrefs.SetFloat ("veletaskana", 90);
			ladet ();
		}
		else
		{
			ladet ();
		}
		redzesslider.onValueChanged.AddListener ((v) => {
			teksts.text = v.ToString ("0");
		});
	}
	public void mainaskanu()
	{
		AudioListener.volume = redzesslider.value;
		saglabat();
	}
	public void ladet()
	{
		redzesslider.value=PlayerPrefs.GetFloat("veletaskana");
	}
	public void saglabat()
	{
		PlayerPrefs.SetFloat("veletaskana",redzesslider.value);
	}
}
