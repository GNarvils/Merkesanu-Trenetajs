using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Spele : MonoBehaviour
{
    public GameObject Ierocis1;
    public GameObject Ierocis2;
    public GameObject Ierocis3;
    public GameObject Aina1;
    public GameObject Aina2;
    public GameObject Aina3;
    public GameObject Merkis1;
    public GameObject Merkis2;
    public GameObject Merkis3;
    public GameObject Multi1;
    public GameObject Multi2;
    public GameObject Multi3;
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
    public int Ierocis = 0;
    public int Ainas = 0;
    public int Merkis = 0;
    public int Muzikas = 0;
    public int Trenins = 0;

    void Start()
    {
        Trenins = PlayerPrefs.GetInt("Trenins");
        if (Trenins == 0)
        {
            Ierocis = PlayerPrefs.GetInt("Ieroics");
            if (Ierocis == 0)
            {
                Ierocis1.SetActive(true);
                Ierocis2.SetActive(false);
                Ierocis3.SetActive(false);
            }
            else if (Ierocis == 1)
            {
                Ierocis1.SetActive(false);
                Ierocis2.SetActive(true);
                Ierocis3.SetActive(false);
            }
            else if (Ierocis == 2)
            {
                Ierocis1.SetActive(false);
                Ierocis2.SetActive(false);
                Ierocis3.SetActive(true);
            }
            Ainas = PlayerPrefs.GetInt("Ainas");
            if (Ainas == 0)
            {
                Aina1.SetActive(true);
                Aina2.SetActive(false);
                Aina3.SetActive(false);
            }
            else if (Ainas == 1)
            {
                Aina1.SetActive(false);
                Aina2.SetActive(true);
                Aina3.SetActive(false);
            }
            else if (Ainas == 2)
            {
                Aina1.SetActive(false);
                Aina2.SetActive(false);
                Aina3.SetActive(true);
            }
            Merkis = PlayerPrefs.GetInt("Merkis");
            if (Merkis == 0)
            {
                Merkis1.SetActive(true);
                Merkis2.SetActive(false);
                Merkis3.SetActive(false);
            }
            else if (Merkis == 1)
            {
                Merkis1.SetActive(false);
                Merkis2.SetActive(true);
                Merkis3.SetActive(false);
            }
            else if (Merkis == 2)
            {
                Merkis1.SetActive(false);
                Merkis2.SetActive(false);
                Merkis3.SetActive(true);
            }
            Muzikas = PlayerPrefs.GetInt("Muzikas");
            music = GetComponent<AudioSource>();
            if (Muzikas == 0)
            {
                music.clip = muzika[0];
                music.Play();
            }
            if (Muzikas == 1)
            {
                music.clip = muzika[1];
                music.Play();
            }
            if (Muzikas == 2)
            {
                music.clip = muzika[2];
                music.Play();
            }

            laiks = 60;
            laikaAtskaite = true;
        }
        else if (Trenins == 1) {
            Ierocis = PlayerPrefs.GetInt("Ieroics");
            if (Ierocis == 0)
            {
                Ierocis1.SetActive(true);
                Ierocis2.SetActive(false);
                Ierocis3.SetActive(false);
            }
            else if (Ierocis == 1)
            {
                Ierocis1.SetActive(false);
                Ierocis2.SetActive(true);
                Ierocis3.SetActive(false);
            }
            else if (Ierocis == 2)
            {
                Ierocis1.SetActive(false);
                Ierocis2.SetActive(false);
                Ierocis3.SetActive(true);
            }
            Ainas = PlayerPrefs.GetInt("Ainas");
            if (Ainas == 0)
            {
                Aina1.SetActive(true);
                Aina2.SetActive(false);
                Aina3.SetActive(false);
            }
            else if (Ainas == 1)
            {
                Aina1.SetActive(false);
                Aina2.SetActive(true);
                Aina3.SetActive(false);
            }
            else if (Ainas == 2)
            {
                Aina1.SetActive(false);
                Aina2.SetActive(false);
                Aina3.SetActive(true);
            }
            Merkis = PlayerPrefs.GetInt("Merkis");
            if (Merkis == 0)
            {
                Merkis1.SetActive(true);
                Multi1.SetActive(true);
                Merkis2.SetActive(false);
                Multi2.SetActive(false);
                Merkis3.SetActive(false);
                Multi3.SetActive(false);
            }
            else if (Merkis == 1)
            {
                Merkis1.SetActive(false);
                Multi1.SetActive(false);
                Merkis2.SetActive(true);
                Multi2.SetActive(true);
                Merkis3.SetActive(false);
                Multi3.SetActive(false);
            }
            else if (Merkis == 2)
            {
                Merkis1.SetActive(false);
                Multi1.SetActive(false);
                Merkis2.SetActive(false);
                Multi2.SetActive(false);
                Merkis3.SetActive(true);
                Multi3.SetActive(true);
            }
            Muzikas = PlayerPrefs.GetInt("Muzikas");
            music = GetComponent<AudioSource>();
            if (Muzikas == 0)
            {
                music.clip = muzika[0];
                music.Play();
            }
            if (Muzikas == 1)
            {
                music.clip = muzika[1];
                music.Play();
            }
            if (Muzikas == 2)
            {
                music.clip = muzika[2];
                music.Play();
            }

            laiks = 60;
            laikaAtskaite = true;
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
