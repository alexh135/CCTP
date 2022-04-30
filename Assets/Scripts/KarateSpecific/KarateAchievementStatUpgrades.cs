using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KarateAchievementStatUpgrades : MonoBehaviour
{
    // public references to other scripts
    public XPBar xPBar;
    public KarateClass karateClass;
    public KarateAchievmentUnlock achievementUnlocks;
    public SkillPointHandler skillPointHandler;
    public KarateEnemyController enemyController;
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
        // if the required xp has been met and the player is less than level 5
        if (xPBar.levelUp && xPBar.level < 5)
        {
            // adds 1 skill point 
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 1;
        }
        // if the required xp has been met and the player is less than level 10
        if (xPBar.levelUp && xPBar.level < 10)
        {
            // adds 2 skill points
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 2;
        }
        // if the required xp has been met and the player is less than level 15
        if (xPBar.levelUp && xPBar.level < 15)
        {
            // adds 3 skill points
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 3;
        }
        // if the required xp has been met and the player is less than level 20
        if (xPBar.levelUp && xPBar.level < 20)
        {
            // adds 4 skill points
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 4;
        }
    }

    public void KillAchievementStatUpgrades()
    {
        // if player has killed 10 enemies
        if (enemyController.kills == 10)
        {
            // add 1 skill point
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 1;
            // add 1 strength point to player stats
            karateClass.Strength = karateClass.Strength + 1;
        }
        // if player has killed 20 enemies
        if (enemyController.kills == 20)
        {
            // add 2 skill points
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 2;
            // add 1 strength point to player stats
            karateClass.Strength = karateClass.Strength + 1;
        }
        // if player has killed 30 enemies
        if (enemyController.kills == 30)
        {
            // add 3 skill points
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 3;
            // add 1 strength point to player stats
            karateClass.Strength = karateClass.Strength + 1;
        }
        // if player has killed 40 enemies
        if (enemyController.kills == 40)
        {
            // add 4 skill points
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 4;
            // add 1 strength point to player stats
            karateClass.Strength = karateClass.Strength + 1;
        }
    }

    public void ExplorerAchievementStatUpgrades()
    {
        // if player has explored 2 regions
        if (explorerRegions.regionsExplored == 2)
        {
            // add 1 skill point
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 1;
            // add 1 stamina point to player stats
            karateClass.Stamina = karateClass.Stamina + 1;
        }
        // if player has explored 4 regions
        if (explorerRegions.regionsExplored == 4)
        {
            // add 2 skill point
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 2;
            // add 1 stamina point to player stats
            karateClass.Stamina = karateClass.Stamina + 1;
        }
        // if player has explored 6 regions
        if (explorerRegions.regionsExplored == 6)
        {
            // add 3 skill point
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 3;
            // add 1 stamina point to player stats
            karateClass.Stamina = karateClass.Stamina + 1;
        }
        // if player has explored 8 regions
        if (explorerRegions.regionsExplored == 8)
        {
            // add 4 skill point
            skillPointHandler.skillPoints = skillPointHandler.skillPoints + 4;
            // add 1 stamina point to player stats
            karateClass.Stamina = karateClass.Stamina + 1;
        }
    }

    public void maxCompletionStatUpgrades()
    {
        // if player completes all other achievements
        if (achievementUnlocks.maxCompletion)
        {
            // add 4 stat points to all player stats
            karateClass.Stamina = karateClass.Stamina + 4;
            karateClass.Health = karateClass.Health + 4;
            karateClass.Strength = karateClass.Strength + 4;
            karateClass.Speed = karateClass.Speed + 4;
            karateClass.Intellect = karateClass.Intellect + 4;
        }
    }
}
