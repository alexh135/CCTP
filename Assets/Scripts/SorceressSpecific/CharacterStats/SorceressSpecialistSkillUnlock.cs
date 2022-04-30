using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SorceressSpecialistSkillUnlock : MonoBehaviour
{
    // reference to other scripts
    public SkillPointHandler pointHandler;
    public SorceressClass sorceressClass;

    // references to public bool variables
    public bool healthSplashPotUnlocked;
    public bool SpeedUnlocked;
    public bool DamageUnlocked;
    public bool jumpUnlocked;
    public bool fireBallUnlocked;
    public bool levitateUnlocked;
    public bool waterBallUnlocked;
    public bool lightningUnlocked;
    public bool freezeUnlocked;
    public bool flyUnlocked;

    public void Start()
    {
        // bool variables given value
        healthSplashPotUnlocked = false;
        SpeedUnlocked = false;
        DamageUnlocked = false;
        jumpUnlocked = false;
        fireBallUnlocked = false;
        levitateUnlocked = false;
        waterBallUnlocked = false;
        lightningUnlocked = false;
        freezeUnlocked = false;
        flyUnlocked = false;
    }

    public void UnlockHealthSplash()
    {
        // if skill points value is greater than 5
        if (pointHandler.skillPoints > 5)
        {
            // take off 5 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 5;
            healthSplashPotUnlocked = true;
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

    public void UnlockFireBall()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from point value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            fireBallUnlocked = true;
        }
    }

    public void UnlockLevitate()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from point value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            levitateUnlocked = true;
        }
    }

    public void UnlockWaterBall()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 5 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            waterBallUnlocked = true;
        }
    }

    public void UnlockLighting()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            lightningUnlocked = true;
        }
    }

    public void UnlockFreeze()
    {
        // if skill points value is greater than 15
        if (pointHandler.skillPoints > 15)
        {
            // take off 15 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 15;
            freezeUnlocked = true;
        }
    }

    public void UnlockFly()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from point value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            flyUnlocked = true;
        }
    }
}
