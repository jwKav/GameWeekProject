using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public float delay = 3f;
    private void Start()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("EnemyCount");
        EndKillsText.totalEnemies = enemies.Length;
        
    }
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("EnemyCount");
        ScoreScript.scoreValue = enemies.Length;
        EndKillsText.endScore = enemies.Length;

        if (enemies.Length == 0 || GameObject.FindGameObjectWithTag("Player") == null)
        {
            Invoke("EndGame", delay);
        }
    }
    public void EndGame()
    {
        SceneManager.LoadScene(2);
    }
}
