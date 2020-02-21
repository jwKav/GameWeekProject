using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    GameObject weaponType;
    [SerializeField]
    public GameObject bulletObject;
    public GameObject rocketObject;

    [SerializeField]
    private float fireRate = 0.1f;
    [SerializeField]
    private float rocketRate = 0.5f;
    float nextShot;
    private float bulletSpeed = 900f;
    private float rocketSpeed = 600f;
    void Start()
    {
        weaponType = transform.gameObject;
    }
    private void Update()
    {
        
        if (weaponType.CompareTag("MachineGun") && Input.GetButton("Jump"))
        {
            ConsiderFiring(fireRate, bulletObject, bulletSpeed);
        }

        if (weaponType.CompareTag("RocketLauncher") && Input.GetKeyDown(KeyCode.F))
        {
            ConsiderFiring(rocketRate, rocketObject, rocketSpeed);
        }

        //else if (planeType.CompareTag("PlayerCollider"))
        //{
        //    Physics.Raycast(enemyPlane.transform.position, enemyPlane.transform.forward, out hitinfo, 100000);
            

        //    if (hitinfo.transform.tag != null && hitinfo.transform.CompareTag("AICollider"))
        //    {
        //        Debug.Log(hitinfo.transform.tag.ToString());
        //        ConsiderFiring();
        //    }
        //}
        //else
        //{
        //    return;
        //}
    }
    public void ConsiderFiring(float fireRate, GameObject bulletObject, float projectileSpeed)
    {
        if (Time.time > nextShot)
        {
            GameObject newBullet = Instantiate(bulletObject, transform.position, transform.rotation) as GameObject;
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * projectileSpeed;

            nextShot = Time.time + fireRate;
        }
    }
}
