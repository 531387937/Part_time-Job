using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Boss_Atk atk;
    private Text te;
	// Use this for initialization
	void Start () {
        te = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        te.text = "倒计时" + atk.lastTime + "s";
	}
}
