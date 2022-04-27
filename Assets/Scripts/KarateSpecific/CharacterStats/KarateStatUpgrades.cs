using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarateStatUpgrades : MonoBehaviour
{
    public SkillPointHandler pointHandler;
    public KarateClass karate;

    public int maxHealth = 20;
    public int maxStrength = 20;
    public int maxSpeed = 40;
    public int maxStamina = 30;
    public int maxIntellect = 30;

    public void UpgradeHealth()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (karate.Health <= maxHealth)
            {
                pointHandler.skillPoints--;
                karate.Health++;
            }
        }
    }

    public void UpgradeStrength()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (karate.Strength <= maxStrength)
            {
                pointHandler.skillPoints--;
                karate.Strength++;
            }
        }
    }

    public void UpgradeSpeed()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (karate.Speed <= maxSpeed)
            {
                pointHandler.skillPoints--;
                karate.Speed++;
            }
        }
    }

    public void UpgradeStamina()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (karate.Stamina <= maxStamina)
            {
                pointHandler.skillPoints--;
                karate.Stamina++;
            }
        }
    }

    public void UpgradeIntellect()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (karate.Intellect <= maxIntellect)
            {
                pointHandler.skillPoints--;
                karate.Intellect++;
            }
        }
    }
}
