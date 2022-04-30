using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KarateStaminaBar : MonoBehaviour
{
    // public references to other scripts
    public Slider staminaBar;
    public KarateClass karate;
    public KarateMovement characterMovement;

    // public float variables
    public float maxStamina;
    public float currentStamina;
    public float publicCurrentStamina;
    public float regenPerSecond = 4f;

    // public bool variables
    public bool canSprint;
    public bool canRegen;

    public void Start()
    {
        maxStamina = (karate.Stamina * 5);
        // player current stamina is set to the maximum stamina
        currentStamina = maxStamina;
        // slider maximum value is set to the maximum stamina value
        staminaBar.maxValue = maxStamina;
        // sldier value set to maximum player stamina
        staminaBar.value = maxStamina;
        canSprint = true;
        canRegen = false;
    }

    public void UseStamina(int amount)
    {
        if (currentStamina - amount >= 0)
        {
            currentStamina -= amount;
            // slider value set to current stamina value
            staminaBar.value = currentStamina;
        }
    }

    public void Update()
    {
        publicCurrentStamina = currentStamina;
        // if players current stamina is less than the maximum
        if (currentStamina < maxStamina)
        {
            canRegen = true;
        }
        // if players stamina is greater than the maximum
        if (currentStamina > maxStamina)
        {
            // players current stamina is set to the maximum
            currentStamina = maxStamina;
        }

        if (canRegen)
        {
            StartCoroutine(RegenStamina());
        }
    }

    public IEnumerator RegenStamina()
    {
        // every two seconds regen a specifiied amount of stamina
        yield return new WaitForSeconds(2);
        currentStamina += regenPerSecond * Time.deltaTime;
        staminaBar.value = currentStamina;
    }
}
