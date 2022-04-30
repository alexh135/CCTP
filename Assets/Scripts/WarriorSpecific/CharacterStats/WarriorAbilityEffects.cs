using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorAbilityEffects : MonoBehaviour
{
    public WarriorSpecialistSkillUnlock specialistSkillUnlock;
    public WarriorClass warriorClass;
    public EnemyController enemyController;
    public CharacterMovement characterMovement;
    public SpecialistSkillSelection SpecialistSkillSelection;

    public float bargeDIstance = 10f;

    public float speedBoostTimer;
    public bool speedBoosting;
    public int sprintSpeedMultiplier;

    public float doubleDamageTimer;
    public bool doubleDamage;
    public int damageBoostMultiplier;

    public float doubleJumpTimer;
    public bool doubleJumping;
    public int doubleJumpMultiplier;

    public float slowDownTimer;
    public bool slowingTime;
    public int slowSpeedMultiplier;

    public float glitchDistance = 10f;

    public GameObject axe;
    public bool canThrowAxe;
    public int axeDamage;
    public float axeThrowCoolDownTimer;
    public float axeThrowForce;
    public float axeThrowUpwardForce;

    public GameObject shield;
    public bool canUseShield;
    public float shieldTimer;
    public float shieldTimeLimiter;

    public GameObject spear;
    public bool canThrowSpear;
    public int spearDamage;
    public float spearThrowCoolDownTimer;
    public float spearThrowForce;
    public float spearThrowUpwardForce;

    public Transform attackPoint;
    public Transform cam;

    public bool canHeal;
    public int healAmount;

    public void Start()
    {
        sprintSpeedMultiplier = 2;
        damageBoostMultiplier = 2;
        doubleJumpMultiplier = 2;
        slowSpeedMultiplier = 2;
        healAmount = 4;
        shieldTimeLimiter = 5;

        axe.SetActive(false);
        shield.SetActive(false);
        spear.SetActive(false);
    }

    public void WarriorEffects()
    {
        if (SpecialistSkillSelection.bargeSelected)
        {
            if (Input.GetKeyDown("1"))
            {
                Vector3 destination = transform.position + transform.forward * bargeDIstance;
                GameObject player = GameObject.FindWithTag("Player");
                player.transform.position = destination;
            }
        }
        if (SpecialistSkillSelection.speedSelected)
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
                warriorClass.Speed = warriorClass.Speed * sprintSpeedMultiplier;
            }
        }
        if (SpecialistSkillSelection.damageSelected)
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
                warriorClass.Strength = warriorClass.Strength * damageBoostMultiplier;
            }
        }
        if (SpecialistSkillSelection.jumpSelected)
        {
            if (Input.GetKeyDown("4"))
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
                characterMovement.jumpHeight = characterMovement.jumpHeight * doubleJumpMultiplier;
            }
        }
        if (SpecialistSkillSelection.glitchSelected)
        {
            if (Input.GetKeyDown("5"))
            {
                Vector3 destination = transform.position + transform.forward * glitchDistance;
                GameObject player = GameObject.FindWithTag("Player");
                player.transform.position = destination;
            }
        }
        if (SpecialistSkillSelection.timeSelected)
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
                slowDownTimer = 0;
            }
            if (slowingTime)
            {
                enemyController.runSpeed = enemyController.runSpeed / slowSpeedMultiplier;
                enemyController.walkSpeed = enemyController.walkSpeed / slowSpeedMultiplier;
            }
            if (!slowingTime)
            {
                slowDownTimer = 0;
            }
        }
        if (SpecialistSkillSelection.axeSelected)
        {
            canThrowAxe = true;
            if (canThrowAxe)
            {
                if (Input.GetKeyDown("7"))
                {
                    GameObject Axe = Instantiate(axe, attackPoint.position, cam.rotation);
                    Rigidbody AxeRb = Axe.GetComponent<Rigidbody>();
                    Vector3 forceDirection = cam.transform.forward;
                    RaycastHit hit;
                    if (Physics.Raycast(cam.position, cam.forward, out hit, 500f))
                    {
                        forceDirection = (hit.point - attackPoint.position).normalized;
                    }
                    Vector3 force = forceDirection * axeThrowForce + transform.up * axeThrowUpwardForce;
                    AxeRb.AddForce(force, ForceMode.Impulse);
                    canThrowAxe = false;
                    axeThrowCoolDownTimer += Time.deltaTime;
                    if (axeThrowCoolDownTimer == 5)
                    {
                        canThrowAxe = true;
                        axeThrowCoolDownTimer = 0;
                        axe.SetActive(false);
                    }
                }
            }
        }
        if (SpecialistSkillSelection.shieldSelected)
        {
            if (Input.GetKeyDown("8"))
            {
                shieldTimer += Time.deltaTime;
                if (shieldTimer <= shieldTimeLimiter)
                {
                    shield.SetActive(true);
                }
                else if (shieldTimer >= shieldTimeLimiter)
                {
                    shield.SetActive(false);
                    shieldTimer = 0;
                }
            }
        }
        if (SpecialistSkillSelection.spearSelected)
        {
            canThrowSpear = true;
            if (canThrowSpear)
            {
                if (Input.GetKeyDown("7"))
                {
                    GameObject Spear = Instantiate(spear, attackPoint.position, cam.rotation);
                    Rigidbody SpearRb = Spear.GetComponent<Rigidbody>();
                    Vector3 force = cam.transform.forward * spearThrowForce + transform.up * spearThrowUpwardForce;
                    SpearRb.AddForce(force, ForceMode.Impulse);
                    canThrowSpear = false;
                    spearThrowCoolDownTimer += Time.deltaTime;
                    if (spearThrowCoolDownTimer == 5)
                    {
                        canThrowSpear = true;
                        spearThrowCoolDownTimer = 0;
                    }
                }
            }
        }
        if (SpecialistSkillSelection.healSelected)
        {
            if (Input.GetKeyDown("0"))
            {
                warriorClass.Health = warriorClass.Health + healAmount;
            }
        }
    }
}
