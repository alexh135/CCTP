using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public WarriorClass warriorClass;

    public float currentHealth;
    public float maxHealth;
    public float regenPerSecond = 1f;
    public bool Dead = false;
    public bool canRegen;

    public void Start()
    {
        maxHealth = (warriorClass.Health * 5);
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = maxHealth;
        canRegen = false;
    }

    public void Update()
    {
        if (!Dead)
        {
            if (Input.GetKeyUp("m"))
            {
                Damage(2);
                healthBar.value = currentHealth;
            }
        }
        if (Dead)
        {
            Debug.Log("Player Dead");
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
        if (currentHealth < maxHealth)
        {
            canRegen = true;
        }
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if (currentHealth <= 0)
        {
            Dead = true;
            currentHealth = 0;
        }
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
        yield return new WaitForSeconds(4);
        currentHealth += regenPerSecond * Time.deltaTime;
        healthBar.value = currentHealth;
    }
}
