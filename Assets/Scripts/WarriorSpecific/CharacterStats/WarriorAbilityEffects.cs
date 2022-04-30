using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorAbilityEffects : MonoBehaviour
{
    // reference to scripts
    public WarriorSpecialistSkillUnlock specialistSkillUnlock;
    public WarriorClass warriorClass;
    public WarriorEnemyController enemyController;
    public CharacterMovement characterMovement;
    public SpecialistSkillSelection SpecialistSkillSelection;

    // variable for barge skill
    public float bargeDIstance = 10f;
    public float bargeCoolDown;
    public bool barging;

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

    // variables for slow time perk
    public float slowDownTimer;
    public bool slowingTime;
    public int slowSpeedMultiplier;

    // variable for glitch perk
    public float glitchDistance = 10f;
    public float glitchCoolDown;
    public bool glitching;

    // variables for axe throw perk
    public GameObject axe;
    public bool canThrowAxe;
    public int axeDamage;
    public float axeThrowCoolDownTimer;
    public float axeThrowForce;
    public float axeThrowUpwardForce;

    // variables for shield
    public GameObject shield;
    public bool canUseShield;
    public float shieldTimer;
    public float shieldTimeLimiter;

    // variables for spear throw perk
    public GameObject spear;
    public bool canThrowSpear;
    public int spearDamage;
    public float spearThrowCoolDownTimer;
    public float spearThrowForce;
    public float spearThrowUpwardForce;

    public Transform attackPoint;
    public Transform cam;

    // variables for heal
    public bool canHeal;
    public int healAmount;
    public float healCoolDown;

    public void Start()
    {
        // values assigned for upgrade multipliers 
        sprintSpeedMultiplier = 2;
        damageBoostMultiplier = 2;
        doubleJumpMultiplier = 2;
        slowSpeedMultiplier = 2;
        healAmount = 4;
        shieldTimeLimiter = 5;

        // gameobjects set to hidden at start
        axe.SetActive(false);
        shield.SetActive(false);
        spear.SetActive(false);
    }

    public void WarriorEffects()
    {
        // if barge is selected
        if (SpecialistSkillSelection.bargeSelected)
        {
            barging = true;
            if (barging)
            {
                // if player input is 1
                if (Input.GetKeyDown("1"))
                {
                    // initialise destination position
                    Vector3 destination = transform.position + transform.forward * bargeDIstance;
                    GameObject player = GameObject.FindWithTag("Player");
                    // set player position to destination position
                    player.transform.position = destination;
                    barging = false;
                    bargeCoolDown += Time.deltaTime;
                    if (bargeCoolDown == 5)
                    {
                        barging = true;
                    }
                    if (bargeCoolDown < 5)
                    {
                        barging = false;
                    }
                }
            }
        }
        // is speed boost is selected
        if (SpecialistSkillSelection.speedSelected)
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
                warriorClass.Speed = warriorClass.Speed * sprintSpeedMultiplier;
            }
        }
        // if damage boost is selected
        if (SpecialistSkillSelection.damageSelected)
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
                warriorClass.Strength = warriorClass.Strength * damageBoostMultiplier;
            }
        }
        // if jump boost is selected
        if (SpecialistSkillSelection.jumpSelected)
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
                characterMovement.jumpHeight = characterMovement.jumpHeight * doubleJumpMultiplier;
            }
        }
        // if glitch is selected
        if (SpecialistSkillSelection.glitchSelected)
        {
            glitching = true;
            if (glitching)
            {
                // if player inputs 5
                if (Input.GetKeyDown("5"))
                {
                    // set player position to destination position
                    Vector3 destination = transform.position + transform.forward * glitchDistance;
                    GameObject player = GameObject.FindWithTag("Player");
                    player.transform.position = destination;
                    glitching = false;
                    glitchCoolDown += Time.deltaTime;
                    if (glitchCoolDown == 5)
                    {
                        glitching = true;
                    }
                    if (glitchCoolDown < 5)
                    {
                        glitching = false;
                    }
                }
            }

        }
        // if slow time is selected
        if (SpecialistSkillSelection.timeSelected)
        {
            // if player inputs 6
            if (Input.GetKeyDown("6"))
            {
                slowDownTimer += Time.deltaTime;
                // if slow down timer is less than 5 seconds
                if (slowDownTimer <= 5)
                {
                    slowingTime = true;
                }
            }
            // if slow down timer is less than 5 seconds
            else if (slowDownTimer >= 5)
            {
                slowingTime = false;
                slowDownTimer = 0;
            }
            if (slowingTime)
            {
                // set enemy movement speeds to normal speed divided by slow speed multiplier
                enemyController.runSpeed = enemyController.runSpeed / slowSpeedMultiplier;
                enemyController.walkSpeed = enemyController.walkSpeed / slowSpeedMultiplier;
            }
            if (!slowingTime)
            {
                slowDownTimer = 0;
            }
        }
        // if axe throw is selected
        if (SpecialistSkillSelection.axeSelected)
        {
            canThrowAxe = true;
            if (canThrowAxe)
            {
                // if player inputs 7
                if (Input.GetKeyDown("7"))
                {
                    // spawn in axe
                    GameObject Axe = Instantiate(axe, attackPoint.position, cam.rotation);
                    Rigidbody AxeRb = Axe.GetComponent<Rigidbody>();
                    Vector3 forceDirection = cam.transform.forward;
                    RaycastHit hit;
                    // if axe hits an object
                    if (Physics.Raycast(cam.position, cam.forward, out hit, 500f))
                    {
                        forceDirection = (hit.point - attackPoint.position).normalized;
                    }
                    Vector3 force = forceDirection * axeThrowForce + transform.up * axeThrowUpwardForce;
                    AxeRb.AddForce(force, ForceMode.Impulse);
                    canThrowAxe = false;
                    // begin cool down timer
                    axeThrowCoolDownTimer += Time.deltaTime;
                    // if cool down timer is equal to 5 seconds
                    if (axeThrowCoolDownTimer == 5)
                    {
                        canThrowAxe = true;
                        axeThrowCoolDownTimer = 0;
                        axe.SetActive(false);
                    }
                }
            }
        }
        // if shield is selected
        if (SpecialistSkillSelection.shieldSelected)
        {
            // if player inputs 8
            if (Input.GetKeyDown("8"))
            {
                shieldTimer += Time.deltaTime;
                // if shield timer is less than or equal to the shield time limiter
                if (shieldTimer <= shieldTimeLimiter)
                {
                    shield.SetActive(true);
                }
                // if shield timer is greater than or equal to the shield time limiter
                else if (shieldTimer >= shieldTimeLimiter)
                {
                    shield.SetActive(false);
                    shieldTimer = 0;
                }
            }
        }
        // if spear throaw is selected
        if (SpecialistSkillSelection.spearSelected)
        {
            canThrowSpear = true;
            if (canThrowSpear)
            {
                // if player inputs 9
                if (Input.GetKeyDown("9"))
                {
                    // spawn in spear
                    GameObject Spear = Instantiate(spear, attackPoint.position, cam.rotation);
                    Rigidbody SpearRb = Spear.GetComponent<Rigidbody>();
                    Vector3 force = cam.transform.forward * spearThrowForce + transform.up * spearThrowUpwardForce;
                    SpearRb.AddForce(force, ForceMode.Impulse);
                    canThrowSpear = false;
                    // begin cool down timer
                    spearThrowCoolDownTimer += Time.deltaTime;
                    // if cool down timer is equal to 5 seconds
                    if (spearThrowCoolDownTimer == 5)
                    {
                        canThrowSpear = true;
                        spearThrowCoolDownTimer = 0;
                    }
                }
            }
        }
        // if heal is selected
        if (SpecialistSkillSelection.healSelected)
        {
            canHeal = true;
            if (canHeal)
            {
                // if player inputs 0
                if (Input.GetKeyDown("0"))
                {
                    // add heal amount variable to warrior health
                    warriorClass.Health = warriorClass.Health + healAmount;
                    healCoolDown += Time.deltaTime;
                    if (healCoolDown == 5)
                    {
                        canHeal = true;
                        healCoolDown = 0;
                    }
                    if (healCoolDown < 5)
                    {
                        canHeal = false;
                    }
                }
            }
        }
    }
}
