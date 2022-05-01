using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SorceressMovement : MonoBehaviour
{
    public CharacterController controller;
    public SorceressClass sorceressClass;
    public Fracture fracture;
    public SorceressAbilityEffects sorceressAbilityEffects;
    public LevelSelect levelSelect;
    public SorceressStaminaBar sorceressStaminaBar;
    public SorceressEnemyController enemyController;
    public SkillPointHandler pointHandler;

    // public float required
    public float sprintSpeed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float groundDistance = 0.4f;
    public float x;
    public float z;

    // transform that works out if the player is on the ground
    public Transform groundCheck;
    public LayerMask groundMask;

    // Vector 3 that stores the players velocity
    Vector3 velocity;

    // public bools required 
    public bool isGrounded;
    public bool canKillEnemy;
    public bool enemyTakeDamage;
    public bool sprinting;

    // public integer that tracks the amount of times the player has sprinted for passive stat upgrades
    public int timesSprinted;

    public Rigidbody rb;

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
        sorceressAbilityEffects.SorceressEffects();
        PlayerControl();
    }

    public void PlayerControl()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * sorceressClass.Speed * Time.deltaTime);

        if (sorceressStaminaBar.publicCurrentStamina >= 2 && isGrounded)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                controller.Move(move * (sorceressClass.Speed + sprintSpeed) * Time.deltaTime);
                sorceressStaminaBar.UseStamina(1);
                sorceressStaminaBar.canRegen = false;
                // add 1 to the number of time the player has sprinted
                timesSprinted = timesSprinted + 1;
            }
         }
       

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (canKillEnemy)
        {
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
