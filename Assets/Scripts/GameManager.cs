using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class contains main game loop.
public class GameManager : MonoBehaviour
{
    public CombatDie[] dice = new CombatDie[6];

    // Start is called before the first frame update
    void Start()
    {
        //dice = new CombatDie[6];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            foreach (CombatDie die in dice)
            {
                die.Roll();
            }
            Debug.Log("Rolled " + dice[0].Roll() + ", " + dice[1].Roll() + ", " + dice[2].Roll() 
                + ", " + dice[3].Roll() + ", " + dice[4].Roll() + ", " + dice[5].Roll());
        }
    }
}
