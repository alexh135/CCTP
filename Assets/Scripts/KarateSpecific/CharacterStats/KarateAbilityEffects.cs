using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarateAbilityEffects : MonoBehaviour
{
    public KarateSpecialistSkillUnlock specialistSkillUnlock;
    public KarateClass karateClass;
    public KarateEnemyController enemyController;
    public KarateMovement karateMovement;
    public KarateSpecialistSelection karateSpecialistSelection;

    // variables for wood breaker
    public bool canWoodBreak;
    public float woodBreakCoolDown;
    public int woodBreakerDamage = 8;

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

    // varibles for wall run
    public bool canWallRun;
    public bool isWallRunning;
    private bool wallLeft;
    private bool wallRight;
    public float wallRunTimer;
    public float wallRunCoolDown;
    public float maxWallRunTime = 10f;
    public float wallCheckDistance;
    public float minJumpHeight;
    private RaycastHit leftWallHit;
    private RaycastHit rightWallHit;
    public LayerMask whatIsWall;
    public LayerMask whatIsGround;
    private float horizontalInput;
    private float verticleInput;
    public Transform orientation;

    // variables for spin kick
    public bool canSpinKick;
    public float spinKickCoolDown;
    public int spinKickDamage = 8;

    // variables for karate chop
    public bool canKarateChop;
    public float karateChopCoolDown;
    public int chopDamage = 8;

    // variables for zen
    public bool canZen;
    public float zenCoolDown;
    public float maxZenTime = 5;

    // variables for fire punch
    public bool canFirePunch;
    public float firePunchCoolDown;
    public int punchDamage = 8;

    // variables for slide
    public bool canSlide;
    public float slideCoolDown;
    public float maxSlideTime = 10;
    public float originalHeight;
    public float reducedHeight;
    public float slideSpeed;
    public float sliding;

    public void Start()
    {
        sprintSpeedMultiplier = 2;
        damageBoostMultiplier = 2;
        doubleJumpMultiplier = 2;
    }

    public void KarateEffects()
    {
        // if wood break is selected
        if (karateSpecialistSelection.woodBreakSelected)
        {
            canWoodBreak = true;
            if (canWoodBreak)
            {
                // if player input is 1
                if (Input.GetKeyDown("1"))
                {
                    Collider[] colliders = Physics.OverlapSphere(transform.position, 2f);
                    foreach (Collider c in colliders)
                    {
                        if (c.tag == "3DTarget")
                        {
                            enemyController.enemyHealth = enemyController.enemyHealth - woodBreakerDamage;
                        }
                    }
                    canWoodBreak = false;
                    woodBreakCoolDown += Time.deltaTime;
                    if (woodBreakCoolDown == 5)
                    {
                        canWoodBreak = true;
                    }
                    if (woodBreakCoolDown < 5)
                    {
                        canWoodBreak = false;
                    }
                }
            }
        }
        // is speed boost is selected
        if (karateSpecialistSelection.speedSelected)
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
                karateClass.Speed = karateClass.Speed * sprintSpeedMultiplier;
            }
        }
        // if damage boost is selected
        if (karateSpecialistSelection.damageSelected)
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
                karateClass.Strength = karateClass.Strength * damageBoostMultiplier;
            }
        }
        // if jump boost is selected
        if (karateSpecialistSelection.jumpSelected)
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
                karateMovement.jumpHeight = karateMovement.jumpHeight * doubleJumpMultiplier;
            }
        }
        // if wall run is selected
        if (karateSpecialistSelection.wallRunSelected)
        {
            canWallRun = true;
            if (canWallRun)
            {
                // if player inputs 5
                if (Input.GetKeyDown("5"))
                {
                    wallRight = Physics.Raycast(transform.position, orientation.right, out rightWallHit, wallCheckDistance, whatIsWall);
                    wallLeft = Physics.Raycast(transform.position, -orientation.right, out leftWallHit, wallCheckDistance, whatIsWall);
                    if ((wallLeft || wallRight) && karateMovement.z > 0 && AboveGround())
                    {
                        karateMovement.rb.useGravity = false;
                        karateMovement.rb.velocity = new Vector3(karateMovement.rb.velocity.x, 0f, karateMovement.rb.velocity.z);
                        Vector3 wallNormal = wallRight ? rightWallHit.normal : leftWallHit.normal;
                        Vector3 wallForward = Vector3.Cross(wallNormal, transform.up);
                        if ((orientation.forward - wallForward).magnitude > (orientation.forward - -wallForward).magnitude)
                        {
                            wallForward = -wallForward;
                        }
                        karateMovement.rb.AddForce(wallForward * karateClass.Speed, ForceMode.Force);
                        isWallRunning = true;
                    }
                    wallRunCoolDown += Time.deltaTime;
                    if (wallRunCoolDown == maxWallRunTime)
                    {
                        canWallRun = true;
                    }
                    if (wallRunCoolDown < 5)
                    {
                        isWallRunning = false;
                        canWallRun = false;

                    }
                }
            }

        }
        // if spin kick is selected
        if (karateSpecialistSelection.spinKickSelected)
        {
            canSpinKick = true;
            if (canSpinKick)
            {
                // if player inputs 6
                if (Input.GetKeyDown("6"))
                {
                    Collider[] colliders = Physics.OverlapSphere(transform.position, 6f);
                    foreach (Collider c in colliders)
                    {
                        if (c.tag == "3DTarget")
                        {
                            enemyController.enemyHealth = enemyController.enemyHealth - spinKickDamage;
                        }
                    }
                    canSpinKick = false;
                    spinKickCoolDown += Time.deltaTime;
                    if (spinKickCoolDown == 5)
                    {
                        canSpinKick = true;
                    }
                    if (spinKickCoolDown < 5)
                    {
                        canSpinKick = false;
                    }
                }
            }
        }
        // if karate chop is selected
        if (karateSpecialistSelection.karateChopSelected)
        {
            canKarateChop = true;
            if (canKarateChop)
            {
                // if player inputs 7
                if (Input.GetKeyDown("7"))
                {
                    Collider[] colliders = Physics.OverlapSphere(transform.position, 2f);
                    foreach (Collider c in colliders)
                    {
                        if (c.tag == "3DTarget")
                        {
                            enemyController.enemyHealth = enemyController.enemyHealth - chopDamage;
                        }
                    }
                    // begin cool down timer
                    karateChopCoolDown += Time.deltaTime;
                    // if cool down timer is equal to 5 seconds
                    if (karateChopCoolDown == 5)
                    {
                        canKarateChop = true;
                        karateChopCoolDown = 0;
                    }
                }
            }
        }
        // if zen is selected
        if (karateSpecialistSelection.zenSelected)
        {
            canZen = true;
            if (canZen)
            {
                // if player inputs 8
                if (Input.GetKeyDown("8"))
                {
                    karateClass.Health = karateClass.Health * 10;
                    // begin cool down timer
                    zenCoolDown += Time.deltaTime;
                    // if cool down timer is equal to 5 seconds
                    if (zenCoolDown == 5)
                    {
                        canZen = true;
                        zenCoolDown = 0;
                    }
                }
            }
        }
        // if fire punch is selected
        if (karateSpecialistSelection.firePunchSelected)
        {
            canFirePunch = true;
            if (canFirePunch)
            {
                // if player inputs 9
                if (Input.GetKeyDown("9"))
                {
                    Collider[] colliders = Physics.OverlapSphere(transform.position, 5f);
                    foreach (Collider c in colliders)
                    {
                        if (c.tag == "3DTarget")
                        {
                            enemyController.enemyHealth = enemyController.enemyHealth - punchDamage;
                        }
                    }
                    // begin cool down timer
                    firePunchCoolDown += Time.deltaTime;
                    // if cool down timer is equal to 5 seconds
                    if (firePunchCoolDown == 5)
                    {
                        canFirePunch = true;
                        firePunchCoolDown = 0;
                    }
                }
            }
        }
        // if slide is selected
        if (karateSpecialistSelection.slideSelected)
        {
            canSlide = true;
            if (canSlide)
            {
                // if player inputs 0
                if (Input.GetKeyDown("0"))
                {
                    slideCoolDown += Time.deltaTime;
                    if (Input.GetKeyDown(KeyCode.LeftControl) && Input.GetKey(KeyCode.W))
                    {
                        karateMovement.capsuleCollider.height = reducedHeight;
                        karateMovement.rb.AddForce(transform.forward * (slideSpeed + karateClass.Speed), ForceMode.VelocityChange);
                        sliding += Time.deltaTime;
                        if (sliding == 3)
                        {
                            sliding = 0;
                            karateMovement.capsuleCollider.height = originalHeight;
                        }
                    }
                    if (slideCoolDown == maxSlideTime)
                    {
                        canSlide = true;
                        slideCoolDown = 0;
                    }
                    if (slideCoolDown < 5)
                    {
                        canSlide = false;
                    }
                }
            }
        }
    }

    private bool AboveGround()
    {
        return !Physics.Raycast(transform.position, Vector3.down, minJumpHeight, whatIsGround);
    }
}
