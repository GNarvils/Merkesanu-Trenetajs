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
    public Target nosauts1;
    public Target nosauts2;
    public Target nosauts3;
    public Target multi11;
    public Target multi12;
    public Target multi13;
    public Target multi14;
    public Target multi21;
    public Target multi22;
    public Target multi23;
    public Target multi24;
    public Target multi31;
    public Target multi32;
    public Target multi33;
    public Target multi34;
    public float Kopa1;
    public float Kopa2;
    public float Kopa3;
    public float Kopa;
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
                Kopa1 = nosauts1.trapits + multi11.trapits + multi12.trapits + multi13.trapits + multi14.trapits;
                Kopa2 = nosauts2.trapits + multi21.trapits + multi22.trapits + multi23.trapits + multi24.trapits;
                Kopa3 = nosauts3.trapits + multi31.trapits + multi32.trapits + multi33.trapits + multi34.trapits;
                Kopa = Kopa1 + Kopa2 + Kopa3;
                nosauti.text = Kopa + "";
                preci = Kopa / sauts.sauts * 100;
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
