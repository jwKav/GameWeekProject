using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    float camBias = 0.96f;

    private void Update()
    {
        Vector3 moveCamTo = transform.position - transform.forward * 12.0f + transform.up * 5.0f;

        Camera.main.transform.position = Camera.main.transform.position * camBias + moveCamTo * (1 - camBias);
        Camera.main.transform.LookAt(transform.position + transform.forward * 50.0f);
    }
}
