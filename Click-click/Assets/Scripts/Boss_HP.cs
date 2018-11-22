using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss_HP : MonoBehaviour {
    public GameObject GameManage;
    private Boss_Atk atk;
    private Slider sl;
	// Use this for initialization
	void Start () {
        atk = GameManage.GetComponent<Boss_Atk>();
        sl = GetComponent<Slider>();
        sl.maxValue = atk.HP_Max;
	}
	
	// Update is called once per frame
	void Update () {
        sl.value = atk.HP_Max;
	}
}
