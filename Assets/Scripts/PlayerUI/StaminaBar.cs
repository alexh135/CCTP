using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Slider staminaBar;
    public WarriorClass warrior;
    public CharacterMovement characterMovement;

    public float maxStamina;
    public float currentStamina;
    public float publicCurrentStamina;
    public float regenPerSecond = 4f;
    public bool canSprint;
    public bool canRegen;

    public void Start()
    {
        maxStamina = (warrior.Stamina * 5);
        currentStamina = maxStamina;
        staminaBar.maxValue = maxStamina;
        staminaBar.value = maxStamina;
        canSprint = true;
        canRegen = false;
    }

    public void UseStamina(int amount)
    {
        if (currentStamina - amount >= 0)
        {
            currentStamina -= amount;
            staminaBar.value = currentStamina;
        }
    }

    public void Update()
    {
        publicCurrentStamina = currentStamina;
        if (currentStamina < maxStamina)
        {
            canRegen = true;
        }
        if (currentStamina > maxStamina)
        {
            currentStamina = maxStamina;
        }

        if (canRegen)
        {
            StartCoroutine(RegenStamina());
        }
    }

    public IEnumerator RegenStamina()
    {
        yield return new WaitForSeconds(2);
        currentStamina += regenPerSecond * Time.deltaTime;
        staminaBar.value = currentStamina;
    }
}

