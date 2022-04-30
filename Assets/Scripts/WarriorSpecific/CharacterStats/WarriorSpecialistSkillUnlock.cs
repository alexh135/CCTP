using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorSpecialistSkillUnlock : MonoBehaviour
{
    public SkillPointHandler pointHandler;
    public WarriorClass warrior;

    public bool BargeUnlocked;
    public bool SpeedUnlocked;
    public bool DamageUnlocked;
    public bool jumpUnlocked;
    public bool glitchUnlocked;
    public bool timeUnlocked;
    public bool axeUnlocked;
    public bool shieldUnlocked;
    public bool spearUnlocked;
    public bool healUnlocked;

    public void Start()
    {
        BargeUnlocked = false;
        SpeedUnlocked = false;
        DamageUnlocked = false;
        jumpUnlocked = false;
        glitchUnlocked = false;
        timeUnlocked = false;
        axeUnlocked = false;
        shieldUnlocked = false;
        spearUnlocked = false;
        healUnlocked = false;
    }

    public void UnlockBarge()
    {
        if (pointHandler.skillPoints > 5)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 5;
            BargeUnlocked = true;
        }
    }

    public void UnlockSpeedBoost()
    {
        if (pointHandler.skillPoints > 5)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 5;
            SpeedUnlocked = true;
        }
    }

    public void UnlockDoubleDamage()
    {
        if (pointHandler.skillPoints > 10)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            DamageUnlocked = true;
        }
    }

    public void UnlockDoubleJump()
    {
        if (pointHandler.skillPoints > 5)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 5;
            jumpUnlocked = true;
        }
    }

    public void UnlockGlitch()
    {
        if (pointHandler.skillPoints > 10)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            glitchUnlocked = true;
        }
    }

    public void UnlockSlowDownTime()
    {
        if (pointHandler.skillPoints > 10)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            timeUnlocked = true;
        }
    }

    public void UnlockAxeThrow()
    {
        if (pointHandler.skillPoints > 10)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            axeUnlocked = true;
        }
    }

    public void UnlockShield()
    {
        if (pointHandler.skillPoints > 10)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            shieldUnlocked = true;
        }
    }

    public void UnlockSpearThrow()
    {
        if (pointHandler.skillPoints > 10)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            spearUnlocked = true;
        }
    }

    public void UnlockHeal()
    {
        if (pointHandler.skillPoints > 15)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            healUnlocked = true;
        }
    }
}
