using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PilotMain : MonoBehaviour
{
    [SerializeField]
    public float speed = 100f;
    public static float maxSpeed = 1000f;
    [SerializeField]
    private float minSpeed = 0.0f;
    private float verticalSens =120f;
    private float horizontalSens = 180f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && speed < maxSpeed)
        {
            speed += 100f;
        }
        if (Input.GetKeyDown(KeyCode.E) && speed > minSpeed)
        {
            speed -= 100f;
        }

        transform.position += transform.forward * Time.deltaTime * speed;

        if (speed == 0)
        {
            transform.position -= transform.up * Time.deltaTime * 0.5f;
        }

        if (speed > 0)
        {
            transform.Rotate(Input.GetAxis("Vertical") * Time.deltaTime * verticalSens, 0.0f, -Input.GetAxis("Horizontal") * Time.deltaTime * horizontalSens);
        }
    }
    private void LateUpdate()
    {
        SpeedScript.currSpeed = speed;
    }
}
