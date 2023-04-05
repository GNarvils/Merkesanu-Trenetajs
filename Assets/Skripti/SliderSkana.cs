using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderSkana: MonoBehaviour {
	[SerializeField] Slider skanaslider;
	[SerializeField] private Text teksts;
	// Use this for initialization
	void Start ()
	{
		if (!PlayerPrefs.HasKey ("veletaskana"))
		{
			PlayerPrefs.SetFloat ("veletaskana", 100);
			ladet ();
		}
		else
		{
			ladet ();
		}
		skanaslider.onValueChanged.AddListener ((v) => {
			teksts.text = v.ToString ("0");
		});
	}
	public void mainaskanu()
	{
		AudioListener.volume = skanaslider.value;
		saglabat();
	}
	public void ladet()
	{
		skanaslider.value=PlayerPrefs.GetFloat("veletaskana");
	}
	public void saglabat()
	{
		PlayerPrefs.SetFloat("veletaskana",skanaslider.value);
	}
}
