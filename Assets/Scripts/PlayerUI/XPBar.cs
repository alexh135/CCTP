using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPBar : MonoBehaviour
{
    public int level;
    public int currentXP;
    public int requiredXP;

    public Slider slider;
    public SkillPointHandler skillPointHandler;

    public bool levelUp;

    public void Start()
    {
        slider.value = currentXP;
        slider.maxValue = requiredXP;
        levelUp = false;
    }

    public void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            currentXP = currentXP + 10;
        }
        slider.value = currentXP;
        if (currentXP > requiredXP)
        {
            levelUp = true;
            currentXP = 0;
        }
        if (levelUp)
        {
            if (level != 20)
            {
                level = level + 1;
                skillPointHandler.skillPoints++;
                levelUp = false;
            }
        }
    }
}
