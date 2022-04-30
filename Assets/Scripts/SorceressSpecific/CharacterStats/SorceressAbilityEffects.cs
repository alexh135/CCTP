using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SorceressAbilityEffects : MonoBehaviour
{
    public SorceressSpecialistSkillUnlock specialistSkillUnlock;
    public SorceressClass sorceressClass;
    public SorceressEnemyController enemyController;
    public SorceressMovement sorceressMovement;
    public SorceressSpecialistSelection sorceressSpecialistSelection;

    // variables for health splash
    public bool canHeal;
    public float healCoolDown;
    public int healAmount = 4;

    // variables for sprint boost
    public float speedBoostTimer;
    public bool speedBoosting;
    public int sprintSpeedMultiplier;

    // variables for damage boost
    public float doubleDamageTimer;
    public bool doubleDamage;
    public int damageBoostMultiplier;

    // variables for jump boost
    public float doubleJumpTimer;
    public bool doubleJumping;
    public int doubleJumpMultiplier;

    // variables for fire ball
    public GameObject fireBall;
    public bool canFireFireBall;
    public float fireBallCoolDown;
    public int fireDamage = 10;

    // variables for levitate
    public bool canLevitate;
    public float levitateCoolDown;
    public float levitateMaxTimer = 5f;

    // variables for water ball
    public GameObject waterBall;
    public bool canFireWaterBall;
    public float waterBallCoolDown;
    public int waterDamage = 6;

    // variables for lightning
    public bool canFireLighting;
    public float lightningCoolDown;
    public int lightningDamage = 8;

    // variables for freeze
    public bool canFreeze;
    public float freezeCoolDown;
    public bool frozen;
    public float maxFreezeTimer = 5;

    // variables for fly
    public bool canFly;
    public float flyCoolDown;
    public float maxFlyTimer = 5;

    public void Start()
    {
        sprintSpeedMultiplier = 2;
        damageBoostMultiplier = 2;
        doubleJumpMultiplier = 2;
    }

    public void SorceressEffects()
    {
        // if health splash is selected
        if (sorceressSpecialistSelection.healthSplashSelected)
        {
            canHeal = true;
            if (canHeal)
            {
                // if player input is 1
                if (Input.GetKeyDown("1"))
                {
                    sorceressClass.Health = sorceressClass.Health + healAmount;
                    canHeal = false;
                    healCoolDown += Time.deltaTime;
                    if (healCoolDown == 5)
                    {
                        canHeal = true;
                    }
                    if (healCoolDown < 5)
                    {
                        canHeal = false;
                    }
                }
            }
        }
        // is speed boost is selected
        if (sorceressSpecialistSelection.speedSelected)
        {
            // if player inputs 2
            if (Input.GetKeyDown("2"))
            {
                speedBoostTimer += Time.deltaTime;
                if (speedBoostTimer <= 5)
                {
                    // if speed boost timer is less than 5 seconds
                    speedBoosting = true;
                }
            }
            else if (speedBoostTimer >= 5)
            {
                // if speed boost timer is greater than 5 seconds
                speedBoosting = false;
            }
            if (speedBoosting)
            {
                // warrior speed set to normal multiplied by sprint speed multiplier variable
                sorceressClass.Speed = sorceressClass.Speed * sprintSpeedMultiplier;
            }
        }
        // if damage boost is selected
        if (sorceressSpecialistSelection.damageSelected)
        {
            // if player inputs 3
            if (Input.GetKeyDown("3"))
            {
                doubleDamageTimer += Time.deltaTime;
                // if damage boost timer is less than 5 seconds
                if (doubleDamageTimer <= 5)
                {
                    doubleDamage = true;
                }
            }
            // if damage boost timer is less than 5 seconds
            else if (doubleDamageTimer >= 5)
            {
                doubleDamage = false;
            }
            if (doubleDamage)
            {
                // warrior damage set to normal mulltiplied by damage boost multiplier
                sorceressClass.Strength = sorceressClass.Strength * damageBoostMultiplier;
            }
        }
        // if jump boost is selected
        if (sorceressSpecialistSelection.jumpSelected)
        {
            // if player inputs 4
            if (Input.GetKeyDown("4"))
            {
                doubleJumpTimer += Time.deltaTime;
                // if jump boost timer is less than 5 seconds
                if (doubleJumpTimer <= 5)
                {
                    doubleJumping = true;
                }
            }
            // if jump boost timer is less than 5 seconds
            else if (doubleJumpTimer >= 5)
            {
                doubleJumping = false;
            }
            if (doubleJumping)
            {
                // set player jump height to normal multiplied by double jump multiplier
                sorceressMovement.jumpHeight = sorceressMovement.jumpHeight * doubleJumpMultiplier;
            }
        }
        // if fire ball is selected
        if (sorceressSpecialistSelection.fireBallSelected)
        {
            canFireFireBall = true;
            if (canFireFireBall)
            {
                // if player inputs 5
                if (Input.GetKeyDown("5"))
                {

                    canFireFireBall = false;
                    fireBallCoolDown += Time.deltaTime;
                    if (fireBallCoolDown == 5)
                    {
                        canFireFireBall = true;
                    }
                    if (fireBallCoolDown < 5)
                    {
                        canFireFireBall = false;
                    }
                }
            }

        }
        // if levitate is selected
        if (sorceressSpecialistSelection.levitateSelected)
        {
            canLevitate = true;
            if (canLevitate)
            {
                // if player inputs 6
                if (Input.GetKeyDown("6"))
                {

                    canLevitate = false;
                    levitateCoolDown += Time.deltaTime;
                    if (levitateCoolDown == levitateMaxTimer)
                    {
                        canLevitate = true;
                    }
                    if (levitateCoolDown < 5)
                    {
                        canLevitate = false;
                    }
                }
            }
        }
        // if water ball is selected
        if (sorceressSpecialistSelection.waterBallSelected)
        {
            canFireWaterBall = true;
            if (canFireWaterBall)
            {
                // if player inputs 7
                if (Input.GetKeyDown("7"))
                {

                    canFireWaterBall = false;
                    // begin cool down timer
                    waterBallCoolDown += Time.deltaTime;
                    // if cool down timer is equal to 5 seconds
                    if (waterBallCoolDown == 5)
                    {
                        canFireWaterBall = true;
                        waterBallCoolDown = 0;
                    }
                }
            }
        }
        // if lightning is selected
        if (sorceressSpecialistSelection.lightningSelected)
        {
            canFireLighting = true;
            if (canFireLighting)
            {
                // if player inputs 7
                if (Input.GetKeyDown("7"))
                {

                    canFireLighting = false;
                    // begin cool down timer
                    lightningCoolDown += Time.deltaTime;
                    // if cool down timer is equal to 5 seconds
                    if (lightningCoolDown == 5)
                    {
                        canFireLighting = true;
                        lightningCoolDown = 0;
                    }
                }
            }
        }
        // if freeze is selected
        if (sorceressSpecialistSelection.freezeSelected)
        {
            canFreeze = true;
            if (canFreeze)
            {
                // if player inputs 7
                if (Input.GetKeyDown("7"))
                {
                    frozen = true;
                    if (frozen)
                    {
                        enemyController.runSpeed = 0;
                        enemyController.walkSpeed = 0;
                    }
                    canFreeze = false;
                    // begin cool down timer
                    freezeCoolDown += Time.deltaTime;
                    // if cool down timer is equal to 5 seconds
                    if (freezeCoolDown == maxFreezeTimer)
                    {
                        canFreeze = true;
                        frozen = false;
                        freezeCoolDown = 0;
                    }
                }
            }
        }
        // if fly is selected
        if (sorceressSpecialistSelection.flySelected)
        {
            canFly = true;
            if (canFly)
            {
                // if player inputs 7
                if (Input.GetKeyDown("7"))
                {

                    canFly = false;
                    // begin cool down timer
                    flyCoolDown += Time.deltaTime;
                    // if cool down timer is equal to 5 seconds
                    if (flyCoolDown == maxFlyTimer)
                    {
                        canFly = true;
                        flyCoolDown = 0;
                    }
                }
            }
        }
    }
}