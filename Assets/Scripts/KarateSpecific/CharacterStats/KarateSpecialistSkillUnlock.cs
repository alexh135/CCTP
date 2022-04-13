using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarateSpecialistSkillUnlock : MonoBehaviour
{
    public SkillPointHandler pointHandler;

    public bool woodBreakUnlocked;
    public bool SpeedUnlocked;
    public bool DamageUnlocked;
    public bool jumpUnlocked;
    public bool wallRunningUnlocked;
    public bool spinKickUnlocked;

    public void Start()
    {
        woodBreakUnlocked = false;
        SpeedUnlocked = false;
        DamageUnlocked = false;
        jumpUnlocked = false;
        wallRunningUnlocked = false;
        spinKickUnlocked = false;
    }

    public void UnlockWoodBreak()
    {
        if (pointHandler.skillPoints > 5)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 5;
            woodBreakUnlocked = true;
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

    public void UnlockWallRun()
    {
        if (pointHandler.skillPoints > 10)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            wallRunningUnlocked = true;
        }
    }

    public void UnlockSpinKick()
    {
        if (pointHandler.skillPoints > 10)
        {
            pointHandler.skillPoints = pointHandler.skillPoints - 10;
            spinKickUnlocked = true;
        }
    }
}
