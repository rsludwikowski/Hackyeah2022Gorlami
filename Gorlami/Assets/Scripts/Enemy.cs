using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Enemy : MonoBehaviour
{


    public int maxHealth = 3;
    public int currentHealth;
    public Transform bulletSpawn;
    public GameObject bulletPrefab;
    public float bulletSpeed = 30;
    public float bulletTime = 3;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

    }
    void Update()
    {
        //gameObject.
            Debug.Log("FIREEEEEEEEE!!!\n");
            EnemyFire();
    }
    private void OnCollisionEnter(Collision collision)
    {
        string colTag = collision.gameObject.tag;
        switch (colTag)
        {
            case "EnemyBullet":
                Shooting shooting = collision.gameObject.GetComponent<Shooting>();
                Demage(shooting.bulletDamage);
                break;
        }

        void Demage(int demageGet)
        {
            Debug.Log("Aaaa you hit me!");
            currentHealth -= demageGet;
            Debug.Log(currentHealth);
            if (currentHealth <= 0)
            {
                Debug.Log("Aaaa you kill me!");
                Destroy(gameObject);
            }
        }
    }
    private IEnumerator DestroyBullet(GameObject bullet, float bulletlifetime) //zeby kula nie leciala w nieskonczonosc
    {
        yield return new WaitForSeconds(bulletlifetime);
        Destroy(bullet);
    }

    private void EnemyFire () {
        GameObject bullet = Instantiate(bulletPrefab,gameObject.transform.position,Quaternion.identity);
        Physics.IgnoreCollision(bullet.GetComponent<BoxCollider>(), bulletSpawn.parent.GetComponent<BoxCollider>());
       
        //Vector3 rotation = bullet.transform.rotation.eulerAngles;
        //bullet.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);
        Vector3 force =new Vector3(0, 0, 20);
        bullet.GetComponent<Rigidbody>().AddForce( force* bulletSpeed, ForceMode.Impulse);
        StartCoroutine(DestroyBullet(bullet, bulletTime));
    }
}
