using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    public int maxHealth = 3;
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

    }

    private void OnCollisionEnter(Collision collision)
    {
        string colTag = collision.gameObject.tag;
        switch (colTag)
        {
            case "Bullet":
                Demage(1);
                break;
        }

        void Demage(int demageGet)
        {
            Debug.Log("Aaaa you hit me!");
            currentHealth -= demageGet;
            Debug.Log(currentHealth);
            if (currentHealth == 0)
            {
                Debug.Log("Aaaa you kill me!");
                Destroy(gameObject);
            }
        }
    }
}