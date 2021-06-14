using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This is a parent class for all Heroes in the game. */
public abstract class Hero
{
    protected string Name { get; set; }
    protected int HealthPoints { get; set; }
    protected int MindPoints { get; set; }           //resistance to spells
    protected int AttackPoints { get; set; }
    protected int DefensePoints { get; set; }

    protected List<string> Inventory { get; set; }   //this should change to a list of item objects
    protected List<string> Arts { get; set; }      //should be list of skill objects
    protected List<string> Talents { get; set; }    //passive skills
}
