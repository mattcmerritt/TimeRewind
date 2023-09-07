using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Simple class to keep the UI updated
public class HealthUI : MonoBehaviour
{
    [SerializeField] private TMP_Text Textbox;
    [SerializeField] private PlayerHealth Health;

    private void Update()
    {
        Textbox.text = $"Health: {Health.Health}";
    }
}
