using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementStatUpgrades : MonoBehaviour
{
    public XPBar xPBar;
    public WarriorClass warriorClass;
    public AchievementUnlocks achievementUnlocks;
    public SkillPointHandler skillPointHandler;
    public EnemyController enemyController;
    public ExplorerRegions explorerRegions;

    void Start()
    {
        
    }

    void Update()
    {
        LevelAchievementStatUpgrades();
        KillAchievementStatUpgrades();
        ExplorerAchievementStatUpgrades();
        maxCompletionStatUpgrades();
    }

    public void LevelAchievementStatUpgrades()
    {
        if (xPBar.levelUp && xPBar.level < 5)
        {
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 1;
        }
        if (xPBar.levelUp && xPBar.level < 10)
        {
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 2;
        }
        if (xPBar.levelUp && xPBar.level < 15)
        {
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 3;
        }
        if (xPBar.levelUp && xPBar.level < 20)
        {
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 4;
        }
    }

    public void KillAchievementStatUpgrades()
    {
        if (enemyController.kills == 10)
        {
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 1;
            warriorClass.Strength = warriorClass.Strength + 1;
        }
        if (enemyController.kills == 20)
        {
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 2;
            warriorClass.Strength = warriorClass.Strength + 1;
        }
        if (enemyController.kills == 30)
        {
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 3;
            warriorClass.Strength = warriorClass.Strength + 1;
        }
        if (enemyController.kills == 40)
        {
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 4;
            warriorClass.Strength = warriorClass.Strength + 1;
        }
    }

    public void ExplorerAchievementStatUpgrades()
    {
        if (explorerRegions.regionsExplored == 2)
        {
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 1;
            warriorClass.Stamina = warriorClass.Stamina + 1;
        }
        if (explorerRegions.regionsExplored == 4)
        {
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 2;
            warriorClass.Stamina = warriorClass.Stamina + 1;
        }
        if (explorerRegions.regionsExplored == 6)
        {
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 3;
            warriorClass.Stamina = warriorClass.Stamina + 1;
        }
        if (explorerRegions.regionsExplored == 8)
        {
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 4;
            warriorClass.Stamina = warriorClass.Stamina + 1;
        }
    }

    public void maxCompletionStatUpgrades()
    {
        if (achievementUnlocks.maxCompletion)
        {
            warriorClass.Stamina = warriorClass.Stamina + 4;
            warriorClass.Health = warriorClass.Health + 4;
            warriorClass.Strength = warriorClass.Strength + 4;
            warriorClass.Speed = warriorClass.Speed + 4;
            warriorClass.Intellect = warriorClass.Intellect + 4;
        }
    }
}
