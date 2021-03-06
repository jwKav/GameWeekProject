﻿using UnityEngine;

public class DestroyAircraft : MonoBehaviour
{
    public HealthBar healthBar;
    public GameObject explosion;
    public GameObject[] burnEffects;

    public int maxHealth;
    public int health = 5;

    public int bulletDamage = 1;
    public int rocketDamage = 5;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            TakeDamage(bulletDamage);
        }
        if (other.CompareTag("Rocket"))
        {
            TakeDamage(rocketDamage);
        }
        if (other.CompareTag("Environment") || other.CompareTag("EnemyHit") || other.CompareTag("Player"))
        {
            TakeDamage(health);
        }
    }
    private void Start()
    {
        maxHealth = health;
        healthBar.SetMaxHealth(maxHealth);
        
    }
    private void Update()
    {
        if (health <= 0f)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(transform.parent.parent.gameObject);
        }
        if (gameObject.CompareTag("Player"))
        {
            healthBar.SetHealth(health);
        }

    }
    private void LateUpdate()
    {
        for (int i = 0; i < maxHealth - health; i++)
        {
            Instantiate(burnEffects[i], transform.position, transform.rotation);
        }
        
    }
    void TakeDamage(int i)
    {
        health -= i;
    }
}
