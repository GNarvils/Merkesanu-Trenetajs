﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kustesanas : MonoBehaviour {

    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;

    public Spele skripts;

	private void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        sensX = PlayerPrefs.GetFloat("SensX");
        sensY = PlayerPrefs.GetFloat("SensY");
    }

    private void Update() {
        if (skripts.laikaAtskaite == true) {
            float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
            float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

            yRotation += mouseX;
            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
            orientation.rotation = Quaternion.Euler(0, yRotation, 0);
        }
    }
}
