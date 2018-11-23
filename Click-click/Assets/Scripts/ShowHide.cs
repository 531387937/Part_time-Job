using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour {
    private float shake;
    private SpriteRenderer BoxColliderClick;
    public GameObject Boss;
    public Boss_Atk atk;
    // Use this for initialization
    void Start()
    {
        BoxColliderClick = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        shake += Time.deltaTime;
        if (shake % 1 > 0.25f&&shake%1<0.65f)
        {
            BoxColliderClick.enabled = true;
        }
        else
        {
            BoxColliderClick.enabled = false;
        }
        if(shake>=3)
        {
            Boss.SetActive(true);
            atk.enabled = true;
            this.gameObject.SetActive(false);
        }
    }
}
