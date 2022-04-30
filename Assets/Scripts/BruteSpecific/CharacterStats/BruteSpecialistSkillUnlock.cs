using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruteSpecialistSkillUnlock : MonoBehaviour
{
    // reference to other scripts
    public SkillPointHandler pointHandler;
    public BruteClass bruteClass;

    // references to public bool variables
    public bool wreckingBallUnlocked;
    public bool SpeedUnlocked;
    public bool DamageUnlocked;
    public bool jumpUnlocked;
    public bool groundAndPoundUnlocked;
    public bool rockThrowUnlocked;
    public bool bargeUnlocked;
    public bool punchUnlocked;
    public bool furyUnlocked;
    public bool rollUnlocked;

    public void Start()
    {
        // bool variables given value
        wreckingBallUnlocked = false;
        SpeedUnlocked = false;
        DamageUnlocked = false;
        jumpUnlocked = false;
        groundAndPoundUnlocked = false;
        rockThrowUnlocked = false;
        bargeUnlocked = false;
        punchUnlocked = false;
        furyUnlocked = false;
        rollUnlocked = false;
    }

    public void UnlockWreckingBall()
    {
        // if skill points value is greater than 5
        if (pointHandler.skillPoints > 5)
        {
            // take off 5 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 5;
            wreckingBallUnlocked = true;
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

    public void UnlockGroundAndPound()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            groundAndPoundUnlocked = true;
        }
    }

    public void UnlockRockThrow()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            rockThrowUnlocked = true;
        }
    }

    public void UnlockBarge()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            DamageUnlocked = true;
        }
    }

    public void UnlockPunch()
    {
        // if skill points value is greater than 5
        if (pointHandler.skillPoints > 5)
        {
            // take off 5 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 5;
            jumpUnlocked = true;
        }
    }

    public void UnlockFury()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            groundAndPoundUnlocked = true;
        }
    }

    public void UnlockRoll()
    {
        // if skill points value is greater than 10
        if (pointHandler.skillPoints > 10)
        {
            // take off 10 skill points from points value
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            rockThrowUnlocked = true;
        }
    }
}
