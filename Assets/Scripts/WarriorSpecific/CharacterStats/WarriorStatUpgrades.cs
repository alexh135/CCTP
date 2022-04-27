using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorStatUpgrades : MonoBehaviour
{
    public SkillPointHandler pointHandler;
    public WarriorClass warrior;

    public int maxHealth = 20;
    public int maxStrength = 30;
    public int maxSpeed = 30;
    public int maxStamina = 20;
    public int maxIntellect = 10;

    public void UpgradeHealth()
    {
        if(pointHandler.skillPoints>0)
        {
            if (warrior.Health <= maxHealth)
            {
                pointHandler.skillPoints--;
                warrior.Health++;
            }
        }
    }

    public void UpgradeStrength()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (warrior.Strength <= maxStrength)
            {
                pointHandler.skillPoints--;
                warrior.Strength++;
            }
        }
    }

    public void UpgradeSpeed()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (warrior.Speed <= maxSpeed)
            {
                pointHandler.skillPoints--;
                warrior.Speed++;
            }
        }
    }

    public void UpgradeStamina()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (warrior.Stamina <= maxStamina)
            {
                pointHandler.skillPoints--;
                warrior.Stamina++;
            }
        }
    }

    public void UpgradeIntellect()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (warrior.Intellect <= maxIntellect)
            {
                pointHandler.skillPoints--;
                warrior.Intellect++;
            }
        }
    }
}
