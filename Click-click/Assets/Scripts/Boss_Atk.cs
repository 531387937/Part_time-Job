using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Atk : MonoBehaviour {
    public float HP_Max;
    public int lastTime;
    public static float timer;
    public Hero_Date hero;
    private bool GameStop=false;
    private void Start()
    {
        hero = GetComponent<Hero_Date>();
    }
    // Use this for initialization
    private void Update()
    {
        if (!GameStop)
        { timer += Time.deltaTime; }
        if(timer>=1)
        {
            lastTime--;
            timer = 0;
        }
        if(lastTime<=0)
        {
            Game_Defeat();
        }
        if(HP_Max<=0)
        {
            Game_Winner();
        }
    }
    public void Hero_Attack()
    {
        HP_Max-=hero.atk;
        hero.gold += (int)hero.atk;
        hero.jewel += (int)hero.atk;
    }
    public void Skill_Attack()
    {
        HP_Max -=hero.skill;
        hero.gold += (int)hero.skill;
        hero.jewel += (int)hero.skill;
    }
    public void Game_Defeat()
    {
        print("defeat");
        GameStop = true;
    }
    public void Game_Winner()
    {
        print("winner");
        GameStop = true;
    }
}
