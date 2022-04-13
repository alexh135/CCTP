using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SorceressAbilityEffects : MonoBehaviour
{
    public SorceressSpecialistSkillUnlock specialistSkillUnlock;
    public SorceressClass sorceressClass;
    public EnemyController enemyController;
    public SorceressMovement sorceressMovement;

    public float speedBoostTimer;
    public bool speedBoosting;

    public float doubleDamageTimer;
    public bool doubleDamage;

    public float doubleJumpTimer;
    public bool doubleJumping;

    public void SorceressEffects()
    {
        if (specialistSkillUnlock.healthSplashPotUnlocked)
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
                sorceressClass.Speed = sorceressClass.Speed * 2;
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
                sorceressClass.Strength = sorceressClass.Strength * 2;
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
                sorceressMovement.jumpHeight = sorceressMovement.jumpHeight * 2;
            }
        }
        if (specialistSkillUnlock.fireBallUnlocked)
        {
            if (Input.GetKeyDown("5"))
            {

            }
        }
        if (specialistSkillUnlock.levitateUnlcoked)
        {
            if (Input.GetKeyDown("6"))
            {

            }
        }
    }
}
