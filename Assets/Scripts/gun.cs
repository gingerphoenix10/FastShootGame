using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gun : MonoBehaviour
{
    public Text ammodisplay;
    private int ammocount = 30;
    private int maxammo = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            if (ammocount>0) {
                ammocount--;
            }
        }
        if (Input.GetKeyDown("r")) {
            ammocount = maxammo;
        }
        ammodisplay.text = ammocount.ToString();
    }
}
