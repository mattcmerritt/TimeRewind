using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to handle rewinding time to a previous state, based on rewind delay
public class PlayerRewind : MonoBehaviour
{
    [SerializeField] private List<PlayerState> PreviousPlayerStates = new List<PlayerState>();
    [Range(0, 10), SerializeField] private float RewindDelay;

    private void Update()
    {
        PlayerState currentState = GetComponent<PlayerStats>().SaveState();
        PreviousPlayerStates.Add(currentState);
        while (PreviousPlayerStates.Count > 0 && currentState.Timestamp - PreviousPlayerStates[0].Timestamp > RewindDelay)
        {
            PreviousPlayerStates.RemoveAt(0); // Remove states that are too old from the beginning of the list
        }
        // Rewind player on space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<PlayerStats>().RestoreState(PreviousPlayerStates[0]);
            PreviousPlayerStates.Clear();
        }
    }

    private void OnDisable()
    {
        PreviousPlayerStates.Clear(); // Necessary to prevent a cascade of errors with the list having elements on exit
    }
}
