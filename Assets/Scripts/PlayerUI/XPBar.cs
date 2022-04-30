using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPBar : MonoBehaviour
{
    // public integer variables
    public int level;
    public int currentXP;
    public int requiredXP;

    // public references to other scripts
    public Slider slider;
    public SkillPointHandler skillPointHandler;

    // public bool variable
    public bool levelUp;

    public void Start()
    {
        // slider value set to current Xp amount
        slider.value = currentXP;
        // sldier value set to the required amount of Xp to level up
        slider.maxValue = requiredXP;
        levelUp = false;
    }

    public void Update()
    {
        slider.value = currentXP;
        // if players current Xp is more than the required amount of Xp
        if (currentXP > requiredXP)
        {
            // player can level up
            levelUp = true;
            // player Xp returned to 0
            currentXP = 0;
        }
        // if the player has reached the required Xp to level up
        if (levelUp)
        {
            // if the players level is less than 20
            if (level != 20)
            {
                // increase player level by 1
                level = level + 1;
                // add 1 skill point
                skillPointHandler.skillPoints++;
                levelUp = false;
            }
        }
    }
}
