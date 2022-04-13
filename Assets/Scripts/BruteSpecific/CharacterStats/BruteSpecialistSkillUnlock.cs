using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruteSpecialistSkillUnlock : MonoBehaviour
{
    public SkillPointHandler pointHandler;

    public bool wreckingBallUnlocked;
    public bool SpeedUnlocked;
    public bool DamageUnlocked;
    public bool jumpUnlocked;
    public bool groundAndPoundUnlocked;
    public bool rockThrowUnlocked;

    public void Start()
    {
        wreckingBallUnlocked = false;
        SpeedUnlocked = false;
        DamageUnlocked = false;
        jumpUnlocked = false;
        groundAndPoundUnlocked = false;
        rockThrowUnlocked = false;
    }

    public void UnlockWreckingBall()
    {
        if (pointHandler.skillPoints > 5)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 5;
            wreckingBallUnlocked = true;
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

    public void UnlockGroundAndPound()
    {
        if (pointHandler.skillPoints > 10)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            groundAndPoundUnlocked = true;
        }
    }

    public void UnlockRockThrow()
    {
        if (pointHandler.skillPoints > 10)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            rockThrowUnlocked = true;
        }
    }
}
