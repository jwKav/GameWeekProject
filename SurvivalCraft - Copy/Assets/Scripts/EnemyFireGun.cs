using UnityEngine;

public class EnemyFireGun : MonoBehaviour
{
    [SerializeField]
    private float fireRate = 0.2f;
    private float nextShot;

    [SerializeField]
    public GameObject bulletObject;
    public RaycastHit hitInfo;

    public Transform player;
    public void Update()
    {
        if (transform.position != null && AIController.aiShoot && Vector3.Distance(transform.position, player.position) < 300f)
        {
            ConsiderFiring();
        }
    }

    public void ConsiderFiring()
    {
        if (Time.time > nextShot)
        {
            GameObject newBullet = Instantiate(bulletObject, transform.position, transform.rotation) as GameObject;
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * 600f;

            nextShot = Time.time + fireRate;
        }
    }
}
