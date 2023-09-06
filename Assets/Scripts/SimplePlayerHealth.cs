using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Handles the critical data of the player, specifically health
public class SimplePlayerHealth : MonoBehaviour
{
    [SerializeField] private int Health = 100;

    public void LoseHealth(int lostHealth)
    {
        Health -= lostHealth;
    }

    public void SetHealth(int newHealth)
    {
        Health = newHealth;
    }

    public int GetHealth()
    {
        return Health;
    }
}
