using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableBulletColl : MonoBehaviour
{
    [SerializeField]
    private float spawnDelay = 0.2f;
    void Start()
    {
        Invoke("EnableBox", spawnDelay);
        
    }
    public void EnableBox()
    {
        transform.GetComponent<BoxCollider>().enabled = true;
    }
}
