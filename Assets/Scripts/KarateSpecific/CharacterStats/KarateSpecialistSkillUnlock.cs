using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarateSpecialistSkillUnlock : MonoBehaviour
{
    // reference to other scripts
    public SkillPointHandler pointHandler;
    public KarateClass karate;

    // references to public bool variables
    public bool woodBreakUnlocked;
    public bool SpeedUnlocked;
    public bool DamageUnlocked;
    public bool jumpUnlocked;
    public bool wallRunningUnlocked;
    public bool spinKickUnlocked;
    public bool karateChopUnlocked;
    public bool zenUnlocked;
    public bool firePunchUnlocked;
    public bool slideUnlocked;

    public void Start()
    {
        // bool variables given value
        woodBreakUnlocked = false;
        SpeedUnlocked = false;
        DamageUnlocked = false;
        jumpUnlocked = false;
        wallRunningUnlocked = false;
        spinKickUnlocked = false;
        karateChopUnlocked = false;
        zenUnlocked = false;
        firePunchUnlocked = false;
        slideUnlocked = false;
    }

    public void UnlockWoodBreak()
    {
        // if skill points value is greater than 5
        if (pointHandler.skillPoints > 5)
        {
            // take off 5 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 5;
            woodBreakUnlocked = true;
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

    public void UnlockWallRun()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            wallRunningUnlocked = true;
        }
    }

    public void UnlockSpinKick()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            spinKickUnlocked = true;
        }
    }

    public void UnlockKarateChop()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            karateChopUnlocked = true;
        }
    }

    public void UnlockZen()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            zenUnlocked = true;
        }
    }

    public void UnlockFirePunch()
    {
        // if skill points value is greater than 15
        if (pointHandler.skillPoints > 15)
        {
            // take off 15 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 15;
            firePunchUnlocked = true;
        }
    }

    public void UnlockSlide()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            slideUnlocked = true;
        }
    }
}
