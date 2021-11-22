using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class CarHealth : MonoBehaviour
{
    // Car Max HP
    public float maxHP = 100;

    // Damage for hard, medium and soft collision
    public float hardCollisionDamage = 20;
    public float mediumCollisionDamage = 10;
    public float softCollisionDamage = 5;

    // Vector magnitude thresholds for hard, medium and soft collision
    public float hardCollisionThreshold = 4;
    public float mediumCollisionThreshold = 3;
    public float softCollisionThreshold = 1;

    // Health threshold before car starts smoking
    public float smokeThreshold = 50;

    // Specifies the smoke particle system
    public GameObject smoke;

    // Car current HP (priv)
    private float currentHP;

    // Specifies the explosion particle system
    public GameObject explosionPrefab;

    private float startTime;

    public string collidedWith;
    public GameObject player;

    // Car current HP (pub)
    public float CurrentHP
    {
        get
        {
            return currentHP;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;

        // Initializes HP
        currentHP = maxHP;

        // Starts with smoke deactivated
        smoke.SetActive(false);
    }

    // Checks to see if the Car is dead
    void Update()
    {
        DeathCheck();
        Smoke();
    }

    // Executes if hard collision is detected
    public void HardCollision()
    {
        // Subtracts specified HP from current HP
        currentHP -= hardCollisionDamage;
    }

    // Executes if medium collision is detected
    public void MediumCollision()
    {
        // Subtracts specified HP from current HP
        currentHP -= mediumCollisionDamage;
    }

    // Executes if soft collision is detected
    public void SoftCollision()
    {
        // Subtracts specified HP from current HP
        currentHP -= softCollisionDamage;
    }

    // Called by checkpoints to restore HP to Car when colliding with them.
    public void checkpointHPRestore(float healStrength)
    {
        // Restores HP based on amount specified by call
        currentHP += healStrength;

        // Prevents overheal
        if(currentHP > 100)
        {
            currentHP = 100;
        }
    }

    void Smoke()
    {
        if (currentHP <= smokeThreshold)
        {
            smoke.SetActive(true);
        }

        else
        {
            smoke.SetActive(false);
        }

    }

    // Checks if Car is dead
    void DeathCheck()
    {
        // Destroys Car if HP drops to 0
        if(currentHP <= 0)
        {
            AnalyticsEvent.GameOver();
            Analytics.CustomEvent("Death", new Dictionary<string, object>
            {
                {"Time", Time.time - startTime},
                {"Position ", player.transform.position },
                {"Collided with ", collidedWith }

            });

            GameObject explosion = Instantiate(explosionPrefab.gameObject);
            explosion.transform.position = this.transform.position;
            UIManager.Instance.LoseGame();
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        collidedWith = collision.gameObject.name;
        Debug.Log(collidedWith);
    }
}
