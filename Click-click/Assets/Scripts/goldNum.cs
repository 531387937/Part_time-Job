using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldNum : MonoBehaviour {
    public Hero_Date date;
    private Text te;
    private float gold;
	// Use this for initialization
	void Start () {
        te = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        gold = date.gold;
        if (gold > 99999)
        {
            te.text = 99999 + "+";
        }
        else
        {
            te.text = " " + gold + " ";
        }
	}
}
