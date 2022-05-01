using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruteMovement : MonoBehaviour
{
    public CharacterController controller;
    public BruteClass bruteClass;
    public Fracture fracture;
    public BruteAbilityEffects bruteAbilityEffects;
    public LevelSelect levelSelect;
    public BruteStaminaBar bruteStaminaBar;
    public BruteEnemyController enemyController;
    public SkillPointHandler pointHandler;

    public float sprintSpeed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public Vector3 velocity;
    bool isGrounded;
    public bool canKillEnemy;
    public bool enemyTakeDamage;
    public bool sprinting;

    // public integer that tracks the amount of times the player has sprinted for passive stat upgrades
    public int timesSprinted;

    public void Start()
    {
        canKillEnemy = false;
        enemyTakeDamage = false;
        sprinting = false;
        timesSprinted = 0;
    }

    // Update is called once per frame
    void Update()
    {
        bruteAbilityEffects.BruteEffects();
        PlayerControl();
    }

    public void PlayerControl()
    {
         isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        // get the inputs for up, down, left and right
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // vector 3 used to store the direction of movement
        Vector3 move = transform.right * x + transform.forward * z;

        // player moves at speed taken from warrior class
        controller.Move(move * bruteClass.Speed * Time.deltaTime);

        // if player has stamina and is on the ground
        if (bruteStaminaBar.publicCurrentStamina >= 2 && isGrounded)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                controller.Move(move * (bruteClass.Speed + sprintSpeed) * Time.deltaTime);
                bruteStaminaBar.UseStamina(1);
                bruteStaminaBar.canRegen = false;
                timesSprinted = timesSprinted + 1;
            }
        }

        // if player presses the jump key (space) and player is on the ground
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        // if the player is within range of the enemy
        if (canKillEnemy)
        {
            // if player left clicks
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Enemy Killed");
                pointHandler.skillPoints++;
                enemyTakeDamage = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "3DTarget")
        {
            Debug.Log("Enemy in range");
            canKillEnemy = true;
        }
    }
}
