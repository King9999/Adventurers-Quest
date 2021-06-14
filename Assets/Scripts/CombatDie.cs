using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This is a special die. It's six sided but consists of 3 skulls, 2 white shields, and 1 black shield.
* There's a 3/6 chance to roll a skull, 2/6 chance to roll a white shield, and a 1/6 chance to roll a
* black shield.  */
public class CombatDie : MonoBehaviour
{
   /* public enum Side
    {
        Skull1,
        Skull2,
        Skull3,
        WhiteShield1,
        WhiteShield2,
        BlackShield
    }*/

    public enum Side
    {
        Skull,
        WhiteShield,
        BlackShield
    }

    public Side Roll()
    {
        //pull a random value from the enums
        float rollValue = Random.value;
        Debug.Log("Roll value: " + rollValue);

        if (rollValue <= (1f / 6f))
            return Side.BlackShield;
        else if (rollValue <= (2f / 6f))
            return Side.WhiteShield;
        else 
            return Side.Skull;          //this should be the most common occurrence

        //return (Side)Random.Range((int)Side.Skull1, (int)Side.BlackShield + 1);
    }

   
}
