using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barbarian : Hero
{
   public Barbarian(string name, int health, int mind, int atk, int def)
    {
        Name = name;
        HealthPoints = health;
        MindPoints = mind;
        AttackPoints = atk;
        DefensePoints = def;

        Inventory = new List<string>();
        Arts = new List<string>();
        Talents = new List<string>();
    }
}
