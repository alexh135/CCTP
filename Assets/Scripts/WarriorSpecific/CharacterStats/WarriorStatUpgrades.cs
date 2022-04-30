using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorStatUpgrades : MonoBehaviour
{
    // reference to scripts
    public SkillPointHandler pointHandler;
    public WarriorClass warrior;

    // reference to 
    public int maxHealth = 20;
    public int maxStrength = 30;
    public int maxSpeed = 30;
    public int maxStamina = 20;
    public int maxIntellect = 10;

    public void UpgradeHealth()
    {
        // if skill points is greater than 0
        if(pointHandler.skillPoints>0)
        {
            // if warrior health variable is less than max health
            if (warrior.Health <= maxHealth)
            {
                // remove 1 skillpoint 
                pointHandler.skillPoints--;
                // add 1 to warrior health
                warrior.Health++;
            }
        }
    }

    public void UpgradeStrength()
    {
        // if skill points is greater than 0
        if (pointHandler.skillPoints > 0)
        {
            // if warrior strength is less than max strength
            if (warrior.Strength <= maxStrength)
            {
                // remove 1 skill point
                pointHandler.skillPoints--;
                // add 1 to warrior strength
                warrior.Strength++;
            }
        }
    }

    public void UpgradeSpeed()
    {
        // if skill points is greater than 0
        if (pointHandler.skillPoints > 0)
        {
            // if warrior speed is equal to less than max speed
            if (warrior.Speed <= maxSpeed)
            {
                // remove 1 skill point
                pointHandler.skillPoints--;
                // add 1 to warrior speed
                warrior.Speed++;
            }
        }
    }

    public void UpgradeStamina()
    {
        // if skill points is greater than 0
        if (pointHandler.skillPoints > 0)
        {
            // if warrior stamina is equal to less than max stamina
            if (warrior.Stamina <= maxStamina)
            {
                // remove 1 skill point
                pointHandler.skillPoints--;
                // add 1 to warrior stamina
                warrior.Stamina++;
            }
        }
    }

    public void UpgradeIntellect()
    {
        // if skill points is greater than 0
        if (pointHandler.skillPoints > 0)
        {
            // if warrior intellect is equal to less than max intellect
            if (warrior.Intellect <= maxIntellect)
            {
                // remove 1 skill point
                pointHandler.skillPoints--;
                // add 1 to warrior intellect
                warrior.Intellect++;
            }
        }
    }
}
