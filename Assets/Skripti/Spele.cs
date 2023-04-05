using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spele : MonoBehaviour
{
    public float laiks;
    public bool laikaAtskaite;
    public Text teksts;


    void Start()
    {
        laiks = 10;
        laikaAtskaite = true;
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
            }
        }
        else {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
