using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SorceressAchievementUnlock : MonoBehaviour
{
    // reference to script
    public XPBar xPBar;
    public SorceressEnemyController enemyController;
    public ExplorerRegions explorerRegions;

    // references to UI images
    public Image noviceLevel;
    public Image intermediateLevel;
    public Image advancedLevel;
    public Image masterLevel;

    public Image noviceKiller;
    public Image intermediateKiller;
    public Image advancedKiller;
    public Image masterKiller;

    public Image noviceExplorer;
    public Image intermediateExplorer;
    public Image advancedExplorer;
    public Image masterExplorer;

    public Image masterCompletionist;

    // references to public bool variables
    public bool maxLevel;
    public bool maxKills;
    public bool maxExplorer;
    public bool maxCompletion;

    public void Start()
    {
        // variables given a value on start
        noviceLevel.enabled = false;
        intermediateLevel.enabled = false;
        advancedLevel.enabled = false;
        masterLevel.enabled = false;

        noviceKiller.enabled = false;
        intermediateKiller.enabled = false;
        advancedKiller.enabled = false;
        masterKiller.enabled = false;

        noviceExplorer.enabled = false;
        intermediateExplorer.enabled = false;
        advancedExplorer.enabled = false;
        masterExplorer.enabled = false;

        masterCompletionist.enabled = false;

        maxLevel = false;
        maxKills = false;
        maxExplorer = false;
        maxCompletion = false;
    }

    public void Update()
    {
        LevelAchievements();
        KillAchievements();
        ExplorerAchievements();
    }

    public void LevelAchievements()
    {
        // if player level is equal to 5
        if (xPBar.level == 5)
        {
            // enable novice level image
            noviceLevel.enabled = true;
        }
        // if player level is equal to 10
        if (xPBar.level == 10)
        {
            // enable intermediate level image
            intermediateLevel.enabled = true;
        }
        // if player level is equal to 15
        if (xPBar.level == 15)
        {
            // enable advanced level image
            advancedLevel.enabled = true;
        }
        // if player level is equal to 20
        if (xPBar.level == 20)
        {
            // enable master level image
            masterLevel.enabled = true;
            maxLevel = true;
        }
    }

    public void KillAchievements()
    {
        // if player has killed 10 enemies
        if (enemyController.kills == 10)
        {
            // enable novice killer image
            noviceKiller.enabled = true;
        }
        // if player has killed 20 enemies
        if (enemyController.kills == 20)
        {
            // enable intermediate killer image
            intermediateKiller.enabled = true;
        }
        // if player has killed 30 enemies
        if (enemyController.kills == 30)
        {
            // enable advanced killer image
            advancedKiller.enabled = true;
        }
        // if player has killed 40 enemies
        if (enemyController.kills == 40)
        {
            // enable master killer image
            masterKiller.enabled = true;
            maxKills = true;
        }
    }

    public void ExplorerAchievements()
    {
        // if player has explored 2 regions
        if (explorerRegions.regionsExplored == 2)
        {
            // enable novice explorer image
            noviceExplorer.enabled = true;
        }
        // if player has explored 4 regions
        if (explorerRegions.regionsExplored == 4)
        {
            // enable intermediate explorer image
            intermediateExplorer.enabled = true;
        }
        // if player has explored 6 regions
        if (explorerRegions.regionsExplored == 6)
        {
            // enable advanced explorer image
            advancedExplorer.enabled = true;
        }
        // if player has explored 8 regions
        if (explorerRegions.regionsExplored == 8)
        {
            // enable master explorer image
            masterExplorer.enabled = true;
        }
    }

    public void MaxCompletion()
    {
        // if player has completed all other achievements
        if (maxExplorer && maxLevel && maxKills)
        {
            // completionist image is enabled
            masterCompletionist.enabled = true;
            maxCompletion = true;
        }
    }
}
