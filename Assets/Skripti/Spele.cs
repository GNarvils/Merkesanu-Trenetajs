using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class Spele : MonoBehaviour
{
    public Camera cam;
    public GameObject Ierocis1;
    public GameObject Ierocis2;
    public GameObject Ierocis3;
    public GameObject Aina1;
    public GameObject Aina2;
    public GameObject Aina3;
    public GameObject Multi1;
    public GameObject Multi2;
    public GameObject Multi3;
    public GameObject M1Iz;
    public GameObject M2Iz;
    public GameObject M3Iz;
    public GameObject Temeklis1;
    public GameObject Temeklis2;
    public GameObject Temeklis3;
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
    public Text pun;
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
    public float fov = 0;
    public float izmers = 0;
    public int Temeklis = 0;
    public float TemeklisIz = 0;
    public float Red = 0;
    public float Green = 0;
    public float Blue = 0;
    public float punkti = 0;
    public float punktiHi = 0;
    public float zaude = 0;
    public GameObject Rekords;
    void Awake()
    {
        fov = PlayerPrefs.GetFloat("FOV");
        cam.fieldOfView = fov;
        Red = PlayerPrefs.GetFloat("Sarkans");
        Green = PlayerPrefs.GetFloat("Zals");
        Blue = PlayerPrefs.GetFloat("Zils");
        byte RedI = (byte)Red;
        byte GreenI = (byte)Green;
        byte BlueI = (byte)Blue;
        Temeklis1.GetComponent<Image>().color = new Color32(RedI, GreenI, BlueI, 255);
        Temeklis2.GetComponent<Image>().color = new Color32(RedI, GreenI, BlueI, 255);
        Temeklis3.GetComponent<Image>().color = new Color32(RedI, GreenI, BlueI, 255);
    }
    void Start()
    {
        Trenins = PlayerPrefs.GetInt("Trenins");
        izmers = PlayerPrefs.GetFloat("Izmers") - 1f;
        Temeklis = PlayerPrefs.GetInt("Temeklis");
        TemeklisIz = PlayerPrefs.GetFloat("TemeklisIz") - 1f;
        if (Temeklis == 0)
        {
            Temeklis1.SetActive(true);
            Temeklis2.SetActive(false);
            Temeklis3.SetActive(false);
        }
        else if (Temeklis == 1)
        {
            Temeklis1.SetActive(false);
            Temeklis2.SetActive(true);
            Temeklis3.SetActive(false);
        }
        else if (Temeklis == 2)
        {
            Temeklis1.SetActive(false);
            Temeklis2.SetActive(false);
            Temeklis3.SetActive(true);
        }
        Temeklis1.transform.localScale += new Vector3(TemeklisIz, TemeklisIz, TemeklisIz);
        Temeklis2.transform.localScale += new Vector3(TemeklisIz, TemeklisIz, TemeklisIz);
        Temeklis3.transform.localScale += new Vector3(TemeklisIz, TemeklisIz, TemeklisIz);

        if (Trenins == 0)
        {
            M1Iz.transform.localScale += new Vector3(0, 0, 0);
            M2Iz.transform.localScale += new Vector3(0, 0, 0);
            M3Iz.transform.localScale += new Vector3(0, 0, 0);
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
                M1Iz.SetActive(true);
                M2Iz.SetActive(false);
                M3Iz.SetActive(false);
            }
            else if (Merkis == 1)
            {
                M1Iz.SetActive(false);
                M2Iz.SetActive(true);
                M3Iz.SetActive(false);
            }
            else if (Merkis == 2)
            {
                M1Iz.SetActive(false);
                M2Iz.SetActive(false);
                M3Iz.SetActive(true);
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
            M1Iz.transform.localScale += new Vector3(0, 0, 0);
            M2Iz.transform.localScale += new Vector3(0, 0, 0);
            M3Iz.transform.localScale += new Vector3(0, 0, 0);
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
                M1Iz.SetActive(true);
                Multi1.SetActive(true);
                M2Iz.SetActive(false);
                Multi2.SetActive(false);
                M3Iz.SetActive(false);
                Multi3.SetActive(false);
            }
            else if (Merkis == 1)
            {
                M1Iz.SetActive(false);
                Multi1.SetActive(false);
                M2Iz.SetActive(true);
                Multi2.SetActive(true);
                M3Iz.SetActive(false);
                Multi3.SetActive(false);
            }
            else if (Merkis == 2)
            {
                M1Iz.SetActive(false);
                Multi1.SetActive(false);
                M2Iz.SetActive(false);
                Multi2.SetActive(false);
                M3Iz.SetActive(true);
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
        else if (Trenins == 2)
        {
            M1Iz.transform.localScale += new Vector3(izmers, izmers, izmers);
            M2Iz.transform.localScale += new Vector3(izmers, izmers, izmers);
            M3Iz.transform.localScale += new Vector3(izmers, izmers, izmers);
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
                M1Iz.SetActive(true);
                M2Iz.SetActive(false);
                M3Iz.SetActive(false);
            }
            else if (Merkis == 1)
            {
                M1Iz.SetActive(false);
                M2Iz.SetActive(true);
                M3Iz.SetActive(false);
            }
            else if (Merkis == 2)
            {
                M1Iz.SetActive(false);
                M2Iz.SetActive(false);
                M3Iz.SetActive(true);
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

            laiks = PlayerPrefs.GetFloat("Laiks"); ;
            laikaAtskaite = true;
        }


    }
    void Update()
    {

        if (laikaAtskaite == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                SceneManager.LoadScene("GalvenaIzvelne", LoadSceneMode.Single);
            }
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
                zaude = (sauts.sauts - Kopa) * 50;
                punkti = (Kopa * 100) - zaude; 
                pun.text = punkti + "";
                if (preci > 49f)
                {
                    labi.SetActive(true);
                }
                else {
                    slikti.SetActive(true);
                }
                if (Trenins == 0)
                {
                   punktiHi = PlayerPrefs.GetFloat("Single");
                    if (punkti > punktiHi) {
                        PlayerPrefs.SetFloat("Single", punkti);
                        Rekords.SetActive(true);
                    }
                }
                else if (Trenins == 1) {
                   punktiHi = PlayerPrefs.GetFloat("Multi");
                    if (punkti > punktiHi)
                    {
                        PlayerPrefs.SetFloat("Multi", punkti);
                        Rekords.SetActive(true);
                    }
                }
                
            }
        }
        else {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
