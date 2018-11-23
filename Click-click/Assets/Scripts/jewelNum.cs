using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class jewelNum : MonoBehaviour {
    public Hero_Date date;
    private Text te;
    private float je;
    // Use this for initialization
    void Start () {
        te = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        je = date.jewel;
        if (je > 99999)
        {
            te.text = 99999 + "+";
        }
        else
        {
            te.text = " " + je + " ";
        }
    }
}
