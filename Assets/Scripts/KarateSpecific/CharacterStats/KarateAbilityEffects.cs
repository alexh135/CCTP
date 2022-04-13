using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarateAbilityEffects : MonoBehaviour
{
    public KarateSpecialistSkillUnlock specialistSkillUnlock;
    public KarateClass karateClass;
    public EnemyController enemyController;
    public KarateMovement karateMovement;

    public float speedBoostTimer;
    public bool speedBoosting;

    public float doubleDamageTimer;
    public bool doubleDamage;

    public float doubleJumpTimer;
    public bool doubleJumping;

    public void KarateEffects()
    {
        if (specialistSkillUnlock.woodBreakUnlocked)
        {
            if (Input.GetKeyDown("1"))
            {

            }
        }
        if (specialistSkillUnlock.SpeedUnlocked)
        {
            if (Input.GetKeyDown("2"))
            {
                speedBoostTimer += Time.deltaTime;
                if (speedBoostTimer <= 5)
                {
                    speedBoosting = true;
                }
            }
            else if (speedBoostTimer >= 5)
            {
                speedBoosting = false;
            }
            if (speedBoosting)
            {
                karateClass.Speed = karateClass.Speed * 2;
            }
        }
        if (specialistSkillUnlock.DamageUnlocked)
        {
            if (Input.GetKeyDown("3"))
            {
                doubleDamageTimer += Time.deltaTime;
                if (doubleDamageTimer <= 5)
                {
                    doubleDamage = true;
                }
            }
            else if (doubleDamageTimer >= 5)
            {
                doubleDamage = false;
            }
            if (doubleDamage)
            {
                karateClass.Strength = karateClass.Strength * 2;
            }
        }
        if (specialistSkillUnlock.jumpUnlocked)
        {
            if (Input.GetKeyDown("3"))
            {
                doubleJumpTimer += Time.deltaTime;
                if (doubleJumpTimer <= 5)
                {
                    doubleJumping = true;
                }
            }
            else if (doubleJumpTimer >= 5)
            {
                doubleJumping = false;
            }
            if (doubleJumping)
            {
                karateMovement.jumpHeight = karateMovement.jumpHeight * 2;
            }
        }
        if (specialistSkillUnlock.wallRunningUnlocked)
        {
            if (Input.GetKeyDown("5"))
            {

            }
        }
        if (specialistSkillUnlock.spinKickUnlocked)
        {
            if (Input.GetKeyDown("6"))
            {

            }
        }
    }
}
