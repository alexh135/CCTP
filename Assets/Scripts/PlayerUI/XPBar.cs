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

    [Range(1f, 300f)]
    public float additionMultiplier = 300;
    [Range(2f, 4f)]
    public float powerMultiplier = 2;
    [Range(7f, 4f)]
    public float divisionMultiplier = 7;

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
            level = level + 1;
            skillPointHandler.skillPoints++;
            levelUp = false;
        }
    }
}
