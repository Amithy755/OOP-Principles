using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : PlayerStats1
{
    [SerializeField] Goblin goblin;

   protected private void attack()
   {
        Debug.Log("Goblin : " + goblin.Health);
        goblin.Health -= Attack;
        Debug.Log("Goblin Health; " + goblin.Health);
   }

    private void Start()
    {
        attack();
    }

}
