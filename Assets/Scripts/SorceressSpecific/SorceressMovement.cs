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

    public float sprintSpeed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
    public bool canKillEnemy;
    public bool enemyTakeDamage;
    public bool sprinting;

    public SorceressEnemyController enemyController;
    public SkillPointHandler pointHandler;

    public void Start()
    {
        canKillEnemy = false;
        enemyTakeDamage = false;
        sprinting = false;
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

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * sorceressClass.Speed * Time.deltaTime);

        if (sorceressStaminaBar.publicCurrentStamina >= 2 && isGrounded)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                controller.Move(move * (sorceressClass.Speed + sprintSpeed) * Time.deltaTime);
                sorceressStaminaBar.UseStamina(1);
                sorceressStaminaBar.canRegen = false;
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
