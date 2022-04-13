using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarateMovement : MonoBehaviour
{
    public CharacterController controller;
    public KarateClass karateClass;
    public Fracture fracture;
    public KarateAbilityEffects karateAbilityEffects;
    public LevelSelect levelSelect;
    public StaminaBar staminaBar;

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

    public EnemyController enemyController;
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
        karateAbilityEffects.KarateEffects();
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

        controller.Move(move * karateClass.Speed * Time.deltaTime);

        if (staminaBar.publicCurrentStamina >= 2 && isGrounded)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                controller.Move(move * (karateClass.Speed + sprintSpeed) * Time.deltaTime);
                staminaBar.UseStamina(1);
                staminaBar.canRegen = false;
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
