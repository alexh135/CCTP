using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrutePassiveStats : MonoBehaviour
{
    public BruteMovement characterMovement;
    public BruteClass bruteClass;

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
            bruteClass.Speed = bruteClass.Speed + 1;
        }
        if (characterMovement.timesSprinted == 10)
        {
            bruteClass.Speed = bruteClass.Speed + 1;
        }
        if (characterMovement.timesSprinted == 15)
        {
            bruteClass.Speed = bruteClass.Speed + 1;
        }
        if (characterMovement.timesSprinted == 20)
        {
            bruteClass.Speed = bruteClass.Speed + 1;
        }
        if (characterMovement.timesSprinted == 25)
        {
            bruteClass.Speed = bruteClass.Speed + 1;
        }
        if (characterMovement.timesSprinted == 30)
        {
            bruteClass.Speed = bruteClass.Speed + 1;
        }
    }
}
