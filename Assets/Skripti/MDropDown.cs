using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MDropDown : MonoBehaviour
{
    public int muzikas;

    public void MDrop(int index) {
        switch (index) {
            case 0: muzikas = 0; break; 
            case 1: muzikas = 1; break;
            case 2: muzikas = 2; break;
        }
    }
}
