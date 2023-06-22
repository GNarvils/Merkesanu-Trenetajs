using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ierocis : MonoBehaviour {
    public new Camera camera;
    public float sauts;
    public Text Izsauts;
    public Spele skripts;
    public AudioSource saut;

    void Start() {
        saut = GetComponent<AudioSource>();
    }
    void Update()
    {
        Izsauts.text = sauts + "";
        if (skripts.laikaAtskaite == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                saut.Play();
                sauts += 1f;
                RaycastHit hit;

                if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit))
                {

                    Target target = hit.transform.GetComponent<Target>();

                    if (target != null)
                    {
                        target.Hit();
                    }
                }
            }
        }
    }
}
