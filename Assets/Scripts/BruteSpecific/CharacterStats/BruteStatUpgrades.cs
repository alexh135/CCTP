using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruteStatUpgrades : MonoBehaviour
{
    public SkillPointHandler pointHandler;
    public BruteClass brute;

    public int maxHealth = 20;
    public int maxStrength = 20;
    public int maxSpeed = 40;
    public int maxStamina = 30;
    public int maxIntellect = 30;

    public void UpgradeHealth()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (brute.Health <= maxHealth)
            {
                pointHandler.skillPoints--;
                brute.Health++;
            }
        }
    }

    public void UpgradeStrength()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (brute.Strength <= maxStrength)
            {
                pointHandler.skillPoints--;
                brute.Strength++;
            }
        }
    }

    public void UpgradeSpeed()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (brute.Speed <= maxSpeed)
            {
                pointHandler.skillPoints--;
                brute.Speed++;
            }
        }
    }

    public void UpgradeStamina()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (brute.Stamina <= maxStamina)
            {
                pointHandler.skillPoints--;
                brute.Stamina++;
            }
        }
    }

    public void UpgradeIntellect()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (brute.Intellect <= maxIntellect)
            {
                pointHandler.skillPoints--;
                brute.Intellect++;
            }
        }
    }
}
