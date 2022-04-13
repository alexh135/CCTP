using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorAbilityEffects : MonoBehaviour
{
    public WarriorSpecialistSkillUnlock specialistSkillUnlock;
    public WarriorClass warriorClass;
    public EnemyController enemyController;
    public CharacterMovement characterMovement;

    public float bargeDIstance = 10f;

    public float speedBoostTimer;
    public bool speedBoosting;

    public float doubleDamageTimer;
    public bool doubleDamage;

    public float doubleJumpTimer;
    public bool doubleJumping;

    public float slowDownTimer;
    public bool slowingTime;

    public float glitchDistance = 10f;

    public void WarriorEffects()
    {
        if (specialistSkillUnlock.BargeUnlocked)
        {
            if (Input.GetKeyDown("1"))
            {
                Vector3 destination = transform.position + transform.forward * bargeDIstance;
                GameObject player = GameObject.FindWithTag("Player");
                player.transform.position = destination;
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
                warriorClass.Speed = warriorClass.Speed * 2;
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
                warriorClass.Strength = warriorClass.Strength * 2;
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
                characterMovement.jumpHeight = characterMovement.jumpHeight * 2;
            }
        }
        if (specialistSkillUnlock.glitchUnlocked)
        {
            if (Input.GetKeyDown("5"))
            {
                Vector3 destination = transform.position + transform.forward * glitchDistance;
                GameObject player = GameObject.FindWithTag("Player");
                player.transform.position = destination;
            }
        }
        if (specialistSkillUnlock.timeUnlocked)
        {
            if (Input.GetKeyDown("6"))
            {
                slowDownTimer += Time.deltaTime;
                if (slowDownTimer <= 5)
                {
                    slowingTime = true;
                }
            }
            else if (slowDownTimer >= 5)
            {
                slowingTime = false;
            }
            if (slowingTime)
            {
                enemyController.runSpeed = enemyController.runSpeed / 3;
                enemyController.walkSpeed = enemyController.walkSpeed / 3;
            }
        }
    }
}
