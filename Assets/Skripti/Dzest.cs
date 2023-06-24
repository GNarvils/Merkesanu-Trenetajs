using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dzest : MonoBehaviour
{
    public void dzest()
    {
        PlayerPrefs.SetFloat("Single", 0);
        PlayerPrefs.SetFloat("Multi", 0);
    }
}

