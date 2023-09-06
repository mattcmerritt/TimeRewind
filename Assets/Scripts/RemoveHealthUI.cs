using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// Simple script to be used by button callback to lower player health
public class RemoveHealthUI : MonoBehaviour
{
    [SerializeField] private SimplePlayerHealth PlayerHealth;
    [SerializeField] private EventSystem EventSystem;

    public void RemovePlayerHealth(int amount)
    {
        PlayerHealth.LoseHealth(amount);

        // Need to deselect the button so pressing buttons doesn't trigger it again
        EventSystem.SetSelectedGameObject(null, null);
    }
}
