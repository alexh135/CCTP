using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorSpecialistSkillUnlock : MonoBehaviour
{
    // reference to other scripts
    public SkillPointHandler pointHandler;
    public WarriorClass warrior;

    // references to public bool variables
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
        // bool variables given value
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
        // if skill points value is greater than 5
        if (pointHandler.skillPoints > 5)
        {
            // take off 5 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 5;
            BargeUnlocked = true;
        }
    }

    public void UnlockSpeedBoost()
    {
        // if skill points value is greater than 5
        if (pointHandler.skillPoints > 5)
        {
            // take off 5 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 5;
            SpeedUnlocked = true;
        }
    }

    public void UnlockDoubleDamage()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            DamageUnlocked = true;
        }
    }

    public void UnlockDoubleJump()
    {
        // if skill points value is greater than 5
        if (pointHandler.skillPoints > 5)
        {
            // take off 5 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 5;
            jumpUnlocked = true;
        }
    }

    public void UnlockGlitch()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            glitchUnlocked = true;
        }
    }

    public void UnlockSlowDownTime()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            timeUnlocked = true;
        }
    }

    public void UnlockAxeThrow()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            axeUnlocked = true;
        }
    }

    public void UnlockShield()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            shieldUnlocked = true;
        }
    }

    public void UnlockSpearThrow()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            spearUnlocked = true;
        }
    }

    public void UnlockHeal()
    {
        // if skill points value is greater than 15
        if (pointHandler.skillPoints > 15)
        {
            // take off 15 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            healUnlocked = true;
        }
    }
}
