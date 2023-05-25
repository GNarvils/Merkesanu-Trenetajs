using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Spele : MonoBehaviour
{
    public float laiks;
    public bool laikaAtskaite;
    public Text teksts;
    public GameObject uzvara;
    public Ierocis sauts;
    public Target nosauts;
    public Text sauti;
    public Text nosauti;
    public Text precizi;
    public float preci;
    public GameObject labi;
    public GameObject slikti;
    public AudioClip[] muzika;
    public AudioSource music;
    public MDropDown mizvelne;

    void Start()
    {
        music = GetComponent<AudioSource>();
        laiks = 10;
        laikaAtskaite = true;
       if (mizvelne.muzikas == 0) {
            AudioClip clip = muzika[0];
            music.PlayOneShot(clip);
        }
        if (mizvelne.muzikas == 1)
        {
            AudioClip clip = muzika[1];
            music.PlayOneShot(clip);
        }
        if (mizvelne.muzikas == 2)
        {
            AudioClip clip = muzika[2];
            music.PlayOneShot(clip);
        }
     
    }
    void Update()
    {

        if (laikaAtskaite == true)
        {
            laiks -= Time.deltaTime;
            teksts.text = Mathf.Round(laiks) + "";
            if (laiks < 0f)
            {
                laikaAtskaite = false;
                uzvara.SetActive(true);
                sauti.text = sauts.sauts + "";
                nosauti.text = nosauts.trapits + "";
                preci = nosauts.trapits / sauts.sauts * 100;
                precizi.text = Mathf.Round(preci) + "%";
                if (preci > 49f)
                {
                    labi.SetActive(true);
                }
                else {
                    slikti.SetActive(true);
                }
            }
        }
        else {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
