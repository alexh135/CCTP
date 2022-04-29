using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementUnlocks : MonoBehaviour
{
    public XPBar xPBar;

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

    public bool maxLevel;
    public bool maxKills;
    public bool maxExplorer;
    public bool maxCompletion;

    public void Start()
    {
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
        if (xPBar.level == 5)
        {
            noviceLevel.enabled = true;
        }
        if (xPBar.level == 10)
        {
            intermediateLevel.enabled = true;
        }
        if (xPBar.level == 15)
        {
            advancedLevel.enabled = true;
        }
        if (xPBar.level == 20)
        {
            masterLevel.enabled = true;
            maxLevel = true;
        }
    }

    public void KillAchievements()
    {

    }

    public void ExplorerAchievements()
    {

    }
    public void MaxCompletion()
    {
        if (maxExplorer && maxLevel && maxKills)
        {
            masterCompletionist.enabled = true;
            maxCompletion = true;
        }
    }
}
