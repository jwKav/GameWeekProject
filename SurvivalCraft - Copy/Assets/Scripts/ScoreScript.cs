using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    TextMeshProUGUI score;
    

    private void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        score.text = "Enemies Remaining: " + scoreValue;

    }
}
