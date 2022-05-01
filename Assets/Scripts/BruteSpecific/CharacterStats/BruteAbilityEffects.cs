using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruteAbilityEffects : MonoBehaviour
{
    public BruteSpecialistSkillUnlock specialistSkillUnlock;
    public BruteClass bruteClass;
    public BruteEnemyController enemyController;
    public BruteMovement bruteMovement;
    public BruteSpecialistSelection bruteSpecialistSelection;

    // variables for wrecking ball
    public GameObject wreckingBall;
    public bool canwreckingBall;
    public float wreckingBallDamage = 10f;
    public float wreckingBallThrowCoolDownTimer;
    public float wreckingBallThrowForce;
    public float wreckingBallThrowUpwardForce;

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

    // variables for ground and pound
    public int poundDamage = 8;
    public float poundTimer;
    public bool canPound;
    public int damageRange = 10;

    // variables for rock throw
    public GameObject rock;
    public bool canThrowRock;
    public int rockThrowDamage = 8;
    public float rockThrowCoolDownTimer;
    public float rockThrowForce;
    public float rockThrowUpwardForce;

    // variables for punch
    public float punchDamage = 10f;
    public float punchTimer;
    public bool canPunch;

    // variables for fury
    public float furyDamage = 15f;
    public float furyTimer;
    public bool canFury;

    // variables for roll
    public float rollDamage = 10f;
    public float rollTimer;
    public bool canRoll;

    // variable for barge skill
    public float bargeDIstance = 10f;
    public float bargeCoolDown;
    public bool barging;

    public Transform attackPoint;
    public Transform cam;

    public void Start()
    {
        sprintSpeedMultiplier = 2;
        damageBoostMultiplier = 2;
        doubleJumpMultiplier = 2;

        rock.SetActive(false);
        wreckingBall.SetActive(false);
    }


    public void BruteEffects()
    {
        if (bruteSpecialistSelection.wreckingBallSelected)
        {
            canwreckingBall = true;
            if (canwreckingBall)
            {
                // if player inputs 1
                if (Input.GetKeyDown("1"))
                {
                    // spawn in wrecking ball
                    GameObject WreckingBall = Instantiate(wreckingBall, attackPoint.position, cam.rotation);
                    Rigidbody WreckingBallRb = WreckingBall.GetComponent<Rigidbody>();
                    Vector3 forceDirection = cam.transform.forward;
                    RaycastHit hit;
                    // if wrecking ball hits an object
                    if (Physics.Raycast(cam.position, cam.forward, out hit, 500f))
                    {
                        forceDirection = (hit.point - attackPoint.position).normalized;
                    }
                    Vector3 force = forceDirection * wreckingBallThrowForce + transform.up * wreckingBallThrowUpwardForce;
                    WreckingBallRb.AddForce(force, ForceMode.Impulse);
                    canwreckingBall = false;
                    // begin cool down timer
                    wreckingBallThrowCoolDownTimer += Time.deltaTime;
                    // if cool down timer is equal to 5 seconds
                    if (wreckingBallThrowCoolDownTimer == 5)
                    {
                        canwreckingBall = true;
                        wreckingBallThrowCoolDownTimer = 0;
                        wreckingBall.SetActive(false);
                    }
                }
            }
        }
        if (bruteSpecialistSelection.speedSelected)
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
                // brute speed set to normal multiplied by sprint speed multiplier variable
                bruteClass.Speed = bruteClass.Speed * sprintSpeedMultiplier;
            }
        }
        if (bruteSpecialistSelection.damageSelected)
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
                bruteClass.Strength = bruteClass.Strength * damageBoostMultiplier;
            }
        }
        if (bruteSpecialistSelection.jumpSelected)
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
                bruteMovement.jumpHeight = bruteMovement.jumpHeight * doubleJumpMultiplier;
            }
        }
        if (bruteSpecialistSelection.groundAndPoundSelected)
        {
            if (Input.GetKeyDown("5"))
            {
                canPound = true;
                if (canPound)
                {
                    // if player inputs 5
                    if (Input.GetKeyDown("5"))
                    {
                        // player character jumps in air
                        bruteMovement.velocity.y = Mathf.Sqrt((bruteMovement.jumpHeight * 2) * -2f * bruteMovement.gravity);
                        bruteMovement.velocity.y += bruteMovement.gravity * Time.deltaTime;
                        bruteMovement.controller.Move(bruteMovement.velocity * Time.deltaTime);
                        // close range AOE attack causes damage to enemies within range
                        Collider[] colliders = Physics.OverlapSphere(transform.position, 4f);
                        foreach (Collider c in colliders)
                        {
                            if (c.tag == "3DTarget")
                            {
                                enemyController.enemyHealth = enemyController.enemyHealth - poundDamage;
                            }
                        }
                        canPound = false;
                        // begin cool down timer
                        poundTimer += Time.deltaTime;
                        // if cool down timer is equal to 5 seconds
                        if (poundTimer == 5)
                        {
                            canPound = true;
                            poundTimer = 0;
                        }
                    }
                }
            }
        }
        if (bruteSpecialistSelection.rockThrowSelected)
        {
            if (Input.GetKeyDown("6"))
            {
                canThrowRock = true;
                if (canThrowRock)
                {
                    // if player inputs 6
                    if (Input.GetKeyDown("6"))
                    {
                        // spawn in rock
                        GameObject Rock = Instantiate(rock, attackPoint.position, cam.rotation);
                        Rigidbody RockRb = Rock.GetComponent<Rigidbody>();
                        Vector3 forceDirection = cam.transform.forward;
                        RaycastHit hit;
                        // if rock hits an object
                        if (Physics.Raycast(cam.position, cam.forward, out hit, 500f))
                        {
                            forceDirection = (hit.point - attackPoint.position).normalized;
                        }
                        Vector3 force = forceDirection * rockThrowForce + transform.up * rockThrowUpwardForce;
                        RockRb.AddForce(force, ForceMode.Impulse);
                        canThrowRock = false;
                        // begin cool down timer
                        rockThrowCoolDownTimer += Time.deltaTime;
                        // if cool down timer is equal to 5 seconds
                        if (rockThrowCoolDownTimer == 5)
                        {
                            canThrowRock = true;
                            rockThrowCoolDownTimer = 0;
                            rock.SetActive(false);
                        }
                    }
                }
            }
        }
        if (bruteSpecialistSelection.bargeSelected)
        {
            barging = true;
            if (barging)
            {
                // if player input is 7
                if (Input.GetKeyDown("7"))
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
        if (bruteSpecialistSelection.punchSelected)
        {
            if (Input.GetKeyDown("8"))
            {
                canPunch = true;
                if (canPunch)
                {
                    // if player input is 7
                    if (Input.GetKeyDown("7"))
                    {
                        Collider[] colliders = Physics.OverlapSphere(transform.position, 3f);
                        foreach (Collider c in colliders)
                        {
                            if (c.tag == "3DTarget")
                            {
                                enemyController.enemyHealth = enemyController.enemyHealth - punchDamage;
                            }
                        }
                        canPunch = false;
                        punchTimer += Time.deltaTime;
                        if (punchTimer == 5)
                        {
                            canPunch = true;
                        }
                        if (punchTimer < 5)
                        {
                            canPunch = false;
                        }
                    }
                }
            }
        }
        if (bruteSpecialistSelection.furySelected)
        {
            canFury = true;
            if (canFury)
            {
                // if player input is 9
                if (Input.GetKeyDown("9"))
                {
                    Collider[] colliders = Physics.OverlapSphere(transform.position, 6f);
                    foreach (Collider c in colliders)
                    {
                        if (c.tag == "3DTarget")
                        {
                            enemyController.enemyHealth = enemyController.enemyHealth - furyDamage;
                        }
                    }
                    canFury = false;
                    furyTimer += Time.deltaTime;
                    if (furyTimer == 5)
                    {
                        canFury = true;
                    }
                    if (furyTimer < 5)
                    {
                        canFury = false;
                    }
                }
            }
        }
        if (bruteSpecialistSelection.rollSelected)
        {
            canRoll = true;
            if (canRoll)
            {
                // if player input is 0
                if (Input.GetKeyDown("0"))
                {
                    Collider[] colliders = Physics.OverlapSphere(transform.position, 5f);
                    foreach (Collider c in colliders)
                    {
                        if (c.tag == "3DTarget")
                        {
                            enemyController.enemyHealth = enemyController.enemyHealth - rollDamage;
                        }
                    }
                    canRoll = false;
                    rollTimer += Time.deltaTime;
                    if (rollTimer == 5)
                    {
                        canRoll = true;
                    }
                    if (rollTimer < 5)
                    {
                        canRoll = false;
                    }
                }
            }
        }
    }
}
