using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy :character
{
public void Attack(int damage)
{
Health=Health-damage;

}
}
