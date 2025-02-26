using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int maxhealth = 100;
    private int currentHealth;

    public Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxhealth;
        healthBar.maxValue = maxhealth;
        healthBar.value = currentHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.value = currentHealth;
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if(GameManager.Instance != null)
        {
            GameManager.Instance.IncrementScore();
            GameManager.Instance.LoadNewScene();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
