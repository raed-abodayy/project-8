using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character
{
    private string name = "zarifeh";
    private int health = 100;
    public int Health
    {

        get { return health; }
        set
        {
            health = value;
            if (health>100) { health=100; }
        }


    }
    public string Name
    {
        get { return name; }
        set { name = value; }



    }
    public void InitilizePlayer(string playername, int playerhealth)
    {
        name = playername;
        health = playerhealth;


    }
public void PrintHealth()
{Debug.Log(health);}
public void PrintStatus()
{
    Debug.Log(name+"    "+health);

}

}
