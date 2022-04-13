using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SorceressSpecialistSkillUnlock : MonoBehaviour
{
    public SkillPointHandler pointHandler;

    public bool healthSplashPotUnlocked;
    public bool SpeedUnlocked;
    public bool DamageUnlocked;
    public bool jumpUnlocked;
    public bool fireBallUnlocked;
    public bool levitateUnlcoked;

    public void Start()
    {
        healthSplashPotUnlocked = false;
        SpeedUnlocked = false;
        DamageUnlocked = false;
        jumpUnlocked = false;
        fireBallUnlocked = false;
        levitateUnlcoked = false;
    }

    public void UnlockHealthSplash()
    {
        if (pointHandler.skillPoints > 5)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 5;
            healthSplashPotUnlocked = true;
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

    public void UnlockFireBall()
    {
        if (pointHandler.skillPoints > 10)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            fireBallUnlocked = true;
        }
    }

    public void UnlockLevitate()
    {
        if (pointHandler.skillPoints > 10)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            levitateUnlcoked = true;
        }
    }
}
