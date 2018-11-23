using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero_Date : MonoBehaviour {
    //现在的每次点击伤害
    public float atk;
    //现在的英雄技能伤害
    public float skill;
    //英雄提升所需金币
    public int Hero_Need;
    //技能提升所需钻石
    public int Skill_Need;
    //现在所拥有的金币
    public int gold;
    //现在所拥有的钻石
    public int jewel;
    public void HeroPro()
    {
        if (gold > Hero_Need)
        {
            gold -= Hero_Need;
            atk +=
        }
    }
}
