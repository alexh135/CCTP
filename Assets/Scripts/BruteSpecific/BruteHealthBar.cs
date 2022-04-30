using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class BruteHealthBar : MonoBehaviour
{
    // public references to other scripts
    public Slider healthBar;
    public BruteClass bruteClass;

    // public float variables
    public float currentHealth;
    public float maxHealth;
    public float regenPerSecond = 1f;

    // public bool variables
    public bool Dead = false;
    public bool canRegen;

    public void Start()
    {
        maxHealth = (bruteClass.Health * 5);
        // set current health to max health
        currentHealth = maxHealth;
        // set slider max value to the max health value
        healthBar.maxValue = maxHealth;
        // set slider value to max health value
        healthBar.value = maxHealth;
        canRegen = false;
    }

    public void Update()
    {
        // if player is not dead
        if (!Dead)
        {
            if (Input.GetKeyUp("m"))
            {
                Damage(2);
                healthBar.value = currentHealth;
            }
        }
        // if player is dead
        if (Dead)
        {
            Debug.Log("Player Dead");
            // load main menu scene
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
        // if current player health is less than the maximum
        if (currentHealth < maxHealth)
        {
            // player can regen health
            canRegen = true;
        }
        // if current player health is greater than max health
        if (currentHealth > maxHealth)
        {
            // current player helath is equal to the maximum health
            currentHealth = maxHealth;
        }
        // if player health is equal to 0
        if (currentHealth <= 0)
        {
            // player is dead
            Dead = true;
            currentHealth = 0;
        }
        // if the player can regen health
        if (canRegen)
        {
            StartCoroutine(RegenHealth());
        }
    }

    public void Damage(float _damage)
    {
        currentHealth -= _damage;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Dead = true;
        }
    }

    public IEnumerator RegenHealth()
    {
        // every 4 seconds regen a spcified amount of health
        yield return new WaitForSeconds(4);
        currentHealth += regenPerSecond * Time.deltaTime;
        // set slider value to the players current health
        healthBar.value = currentHealth;
    }
}
