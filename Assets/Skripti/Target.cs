using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public float trapits;
    public Text text;

    public void Hit()
    {
        transform.position = new Vector3(Random.Range(-5, 5), Random.Range(1, 5), Random.Range(-5, 5));
        trapits += 1f;
    }

    void Update() 
    {
        text.text = trapits + "";
    }
}
