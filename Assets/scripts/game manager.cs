using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    enemy player1 = new enemy();
    player player2 = new player();
    void Start()
    {
        player2.InitilizePlayer("raed", 80);
        player1.InitilizePlayer("khalid", 100);
        player1.PrintStatus();
        player2.PrintStatus();
        player1.Attack(20);
        player1.PrintHealth();
        player2.Heal(30);
        player2.PrintHealth();
    }
}
