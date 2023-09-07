using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Handles the critical data of the player, specifically health
// In a more complex project this would be more involved
public class PlayerStats : MonoBehaviour
{
    [SerializeField] private PlayerHealth Health;

    public PlayerState SaveState()
    {
        return new PlayerState(
            transform.position,
            Health.Health,
            Time.time
        );
    }

    public void RestoreState(PlayerState state)
    {
        transform.position = state.Position;
        Health.SetHealth(state.Health);
    }
}
