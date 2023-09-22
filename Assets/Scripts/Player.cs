using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    static int MAX_HP = 100;

    public string name;
    int HP;

    public Player(string name, int hP)
    {
        this.name = name;
        HP = hP;
    }

    public Player() 
    {
        HP = MAX_HP;
        name = "Joe";
    }

    public void DoDamage(int damage)
    {
        HP -= damage;
        if(HP < 0) HP = 0;
    }

    public void Heal(int healing)
    {
        HP += healing;
        if(HP > MAX_HP) HP = MAX_HP;
    }

    public string Name()
    {
        return name;
    }
}
