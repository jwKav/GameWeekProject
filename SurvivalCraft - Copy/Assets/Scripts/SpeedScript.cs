using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeedScript : MonoBehaviour
{
    public static float currSpeed;

    TextMeshProUGUI speedText;

    private int speedPercent;
    private float maxSpeed;
    
    private void Start()
    {
        speedText = GetComponent<TextMeshProUGUI>();
        maxSpeed = PilotMain.maxSpeed;

    }
    private void Update()
    {
        speedPercent = Mathf.RoundToInt((currSpeed / maxSpeed)*100);

        speedText.text = "Speed: "+ speedPercent + " %";

    }
}
