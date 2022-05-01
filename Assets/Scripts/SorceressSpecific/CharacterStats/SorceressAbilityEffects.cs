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
    public bool canFireBall;
    public float fireDamage = 8f;
    public float fireBallCoolDownTimer;
    public float fireBallThrowForce;
    public float fireBallThrowUpwardForce;

    // variables for levitate
    public bool canLevitate;
    public float levitateCoolDown;
    public float levitateMaxTimer = 5f;
    public Vector3 returnPoint;

    // variables for water ball
    public GameObject waterBall;
    public bool canWaterBall;
    public float waterDamage = 6f;
    public float waterBallThrowCoolDownTimer;
    public float waterBallThrowForce;
    public float waterBallThrowUpwardForce;

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


    public Transform attackPoint;
    public Transform cam;

    public void Start()
    {
        sprintSpeedMultiplier = 2;
        damageBoostMultiplier = 2;
        doubleJumpMultiplier = 2;

        waterBall.SetActive(false);
        fireBall.SetActive(false);
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
            canFireBall = true;
            if (canFireBall)
            {
                // if player inputs 1
                if (Input.GetKeyDown("1"))
                {
                    // spawn in wrecking ball
                    GameObject WreckingBall = Instantiate(fireBall, attackPoint.position, cam.rotation);
                    Rigidbody WreckingBallRb = WreckingBall.GetComponent<Rigidbody>();
                    Vector3 forceDirection = cam.transform.forward;
                    RaycastHit hit;
                    // if wrecking ball hits an object
                    if (Physics.Raycast(cam.position, cam.forward, out hit, 500f))
                    {
                        forceDirection = (hit.point - attackPoint.position).normalized;
                    }
                    Vector3 force = forceDirection * fireBallThrowForce + transform.up * fireBallThrowUpwardForce;
                    WreckingBallRb.AddForce(force, ForceMode.Impulse);
                    canFireBall = false;
                    // begin cool down timer
                    fireBallCoolDownTimer += Time.deltaTime;
                    // if cool down timer is equal to 5 seconds
                    if (fireBallCoolDownTimer == 5)
                    {
                        canFireBall = true;
                        fireBallCoolDownTimer = 0;
                        fireBall.SetActive(false);
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
                    GameObject player = GameObject.FindWithTag("Player");
                    player.transform.position = returnPoint;
                    player.transform.position = new Vector3 (player.transform.position.x, (player.transform.position.y + sorceressMovement.jumpHeight), player.transform.position.z);
                    levitateCoolDown += Time.deltaTime;
                    if (levitateCoolDown == levitateMaxTimer)
                    {
                        canLevitate = true;
                    }
                    if (levitateCoolDown < 5)
                    {
                        canLevitate = false;
                        player.transform.position = returnPoint;
                    }
                }
            }
        }
        // if water ball is selected
        if (sorceressSpecialistSelection.waterBallSelected)
        {
            canWaterBall = true;
            if (canWaterBall)
            {
                // if player inputs 1
                if (Input.GetKeyDown("1"))
                {
                    // spawn in wrecking ball
                    GameObject WreckingBall = Instantiate(waterBall, attackPoint.position, cam.rotation);
                    Rigidbody WreckingBallRb = WreckingBall.GetComponent<Rigidbody>();
                    Vector3 forceDirection = cam.transform.forward;
                    RaycastHit hit;
                    // if wrecking ball hits an object
                    if (Physics.Raycast(cam.position, cam.forward, out hit, 500f))
                    {
                        forceDirection = (hit.point - attackPoint.position).normalized;
                    }
                    Vector3 force = forceDirection * waterBallThrowForce + transform.up * waterBallThrowUpwardForce;
                    WreckingBallRb.AddForce(force, ForceMode.Impulse);
                    canWaterBall = false;
                    // begin cool down timer
                    waterBallThrowCoolDownTimer += Time.deltaTime;
                    // if cool down timer is equal to 5 seconds
                    if (waterBallThrowCoolDownTimer == 5)
                    {
                        canWaterBall = true;
                        waterBallThrowCoolDownTimer = 0;
                        waterBall.SetActive(false);
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
                    Collider[] colliders = Physics.OverlapSphere(transform.position, 6f);
                    foreach (Collider c in colliders)
                    {
                        if (c.tag == "3DTarget")
                        {
                            enemyController.enemyHealth = enemyController.enemyHealth - lightningDamage;
                        }
                    }
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
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        sorceressMovement.rb.AddForce(sorceressMovement.rb.transform.up * sorceressClass.Speed);
                    }
                    // begin cool down timer
                    flyCoolDown += Time.deltaTime;
                    // if cool down timer is equal to 5 seconds
                    if (flyCoolDown == maxFlyTimer)
                    {
                        canFly = true;
                        flyCoolDown = 0;
                    }
                    else if (flyCoolDown < maxFlyTimer)
                    {
                        canFly = true;
                    }
                }
            }
        }
    }
}