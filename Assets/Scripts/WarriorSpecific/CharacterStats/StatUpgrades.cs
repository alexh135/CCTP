using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatUpgrades : MonoBehaviour
{
    public SkillPointHandler pointHandler;
    public WarriorClass warrior;

    public void UpgradeHealth()
    {
        if(pointHandler.skillPoints>0)
        {
            pointHandler.skillPoints--;
            warrior.Health++;
        }
    }

    public void UpgradeStrength()
    {
        if (pointHandler.skillPoints > 0)
        {
            pointHandler.skillPoints--;
            warrior.Strength++;
        }
    }

    public void UpgradeSpeed()
    {
        if (pointHandler.skillPoints > 0)
        {
            pointHandler.skillPoints--;
            warrior.Speed++;
        }
    }

    public void UpgradeStamina()
    {
        if (pointHandler.skillPoints > 0)
        {
            pointHandler.skillPoints--;
            warrior.Stamina++;
        }
    }

    public void UpgradeIntellect()
    {
        if (pointHandler.skillPoints > 0)
        {
            pointHandler.skillPoints--;
            warrior.Intellect++;
        }
    }
}
