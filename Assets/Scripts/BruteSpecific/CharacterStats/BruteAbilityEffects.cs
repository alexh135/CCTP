using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruteAbilityEffects : MonoBehaviour
{
    public BruteSpecialistSkillUnlock specialistSkillUnlock;
    public BruteClass bruteClass;
    public EnemyController enemyController;
    public BruteMovement bruteMovement;

    public float speedBoostTimer;
    public bool speedBoosting;

    public float doubleDamageTimer;
    public bool doubleDamage;

    public float doubleJumpTimer;
    public bool doubleJumping;


    public void BruteEffects()
    {
        if (specialistSkillUnlock.wreckingBallUnlocked)
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
                bruteClass.Speed = bruteClass.Speed * 2;
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
                bruteClass.Strength = bruteClass.Strength * 2;
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
                bruteMovement.jumpHeight = bruteMovement.jumpHeight * 2;
            }
        }
        if (specialistSkillUnlock.groundAndPoundUnlocked)
        {
            if (Input.GetKeyDown("5"))
            {

            }
        }
        if (specialistSkillUnlock.rockThrowUnlocked)
        {
            if (Input.GetKeyDown("6"))
            {

            }
        }
    }
}
