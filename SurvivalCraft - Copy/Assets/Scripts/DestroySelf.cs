using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    [SerializeField]
    private float destroyTime = 5f;

    private void Start()
    {
        Invoke("SelfDestruct", destroyTime);
    }
    public void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
