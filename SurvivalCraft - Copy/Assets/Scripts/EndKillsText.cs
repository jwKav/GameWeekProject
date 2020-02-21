using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndKillsText : MonoBehaviour
{
    TextMeshProUGUI endKillsText;

    public static float endScore;
    public static float totalEnemies;

    private void Start()
    {
        endKillsText = GetComponent<TextMeshProUGUI>();

    }
    private void Update()
    {

        endKillsText.text = "You destroyed " + (totalEnemies -endScore) + "/" + totalEnemies + " enemies";
    }
}