using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Opcijas : MonoBehaviour
{
    public int ieslegts = 0;
    public GameObject opcijas;
    void Start()
    {
        ieslegts = PlayerPrefs.GetInt("Trenins");
        if (ieslegts == 2) {
            opcijas.SetActive(true);
        }
        else {
            opcijas.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        ieslegts = PlayerPrefs.GetInt("Trenins");
        if (ieslegts == 2)
        {
            opcijas.SetActive(true);
        }
        else
        {
            opcijas.SetActive(false);
        }
    }
}
