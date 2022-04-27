using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SorceressStatUpgrades : MonoBehaviour
{
    public SkillPointHandler pointHandler;
    public SorceressClass sorceress;

    public int maxHealth = 10;
    public int maxStrength = 30;
    public int maxSpeed = 20;
    public int maxStamina = 20;
    public int maxIntellect = 30;

    public void UpgradeHealth()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (sorceress.Health <= maxHealth)
            {
                pointHandler.skillPoints--;
                sorceress.Health++;
            }
        }
    }

    public void UpgradeStrength()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (sorceress.Strength <= maxStrength)
            {
                pointHandler.skillPoints--;
                sorceress.Strength++;
            }
        }
    }

    public void UpgradeSpeed()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (sorceress.Speed <= maxSpeed)
            {
                pointHandler.skillPoints--;
                sorceress.Speed++;
            }
        }
    }

    public void UpgradeStamina()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (sorceress.Stamina <= maxStamina)
            {
                pointHandler.skillPoints--;
                sorceress.Stamina++;
            }
        }
    }

    public void UpgradeIntellect()
    {
        if (pointHandler.skillPoints > 0)
        {
            if (sorceress.Intellect <= maxIntellect)
            {
                pointHandler.skillPoints--;
                sorceress.Intellect++;
            }
        }
    }
}
