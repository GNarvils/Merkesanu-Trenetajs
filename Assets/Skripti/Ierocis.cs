using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ierocis : MonoBehaviour {
    public Camera camera;
    public float sauts;
    public Text Izsauts;

    void Update()
    {
        Izsauts.text = sauts + "";
        if (Input.GetMouseButtonDown(0))
        {
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
