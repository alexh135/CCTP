using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveStatUpgrades : MonoBehaviour
{
    public CharacterMovement characterMovement;
    public WarriorClass warriorClass;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PassiveSprintUpgrades();
    }

    public void PassiveSprintUpgrades()
    {
        if (characterMovement.timesSprinted == 5)
        {
            warriorClass.Speed = warriorClass.Speed + 1;
        }
        if (characterMovement.timesSprinted == 10)
        {
            warriorClass.Speed = warriorClass.Speed + 1;
        }
        if (characterMovement.timesSprinted == 15)
        {
            warriorClass.Speed = warriorClass.Speed + 1;
        }
        if (characterMovement.timesSprinted == 20)
        {
            warriorClass.Speed = warriorClass.Speed + 1;
        }
        if (characterMovement.timesSprinted == 25)
        {
            warriorClass.Speed = warriorClass.Speed + 1;
        }
        if (characterMovement.timesSprinted == 30)
        {
            warriorClass.Speed = warriorClass.Speed + 1;
        }
    }
}
