using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaratePassiveSkill : MonoBehaviour
{
    public KarateMovement characterMovement;
    public KarateClass karateClass;

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
            karateClass.Speed = karateClass.Speed + 1;
        }
        if (characterMovement.timesSprinted == 10)
        {
            karateClass.Speed = karateClass.Speed + 1;
        }
        if (characterMovement.timesSprinted == 15)
        {
            karateClass.Speed = karateClass.Speed + 1;
        }
        if (characterMovement.timesSprinted == 20)
        {
            karateClass.Speed = karateClass.Speed + 1;
        }
        if (characterMovement.timesSprinted == 25)
        {
            karateClass.Speed = karateClass.Speed + 1;
        }
        if (characterMovement.timesSprinted == 30)
        {
            karateClass.Speed = karateClass.Speed + 1;
        }
    }
}
