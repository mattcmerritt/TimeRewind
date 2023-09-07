using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerHealth : ScriptableObject
{
    public int Health;
    public int MaxHealth = 100;

    private void OnEnable()
    {
        Health = MaxHealth;
    }

    public void LoseHealth(int lostHealth)
    {
        Health -= lostHealth;
    }

    public void SetHealth(int newHealth)
    {
        Health = newHealth;
    }
}
