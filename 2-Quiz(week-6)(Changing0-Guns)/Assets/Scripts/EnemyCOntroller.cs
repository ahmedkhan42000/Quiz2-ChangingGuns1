using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCOntroller : MonoBehaviour
{
    private GameObject Player;
    private GameObject Enemy;
    private Rigidbody RbEnemy;

    private float EnemyMovingSpeed = 5;

    public int InitialHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        RbEnemy = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
        Enemy = GameObject.Find("Enemy");

    }

    // Update is called once per frame
    void Update()
    {
        RbEnemy.AddForce((Player.transform.position - transform.position).normalized * EnemyMovingSpeed * Time.deltaTime, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "FireObject_1(Clone)")
        {
            InitialHealth -= 10;
            Debug.Log("Onitial Health is ======" + InitialHealth);
            if (InitialHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.name == "FireObject_2(Clone)")
        {
            InitialHealth -= 20;
            Debug.Log("Onitial Health is ======" + InitialHealth);
            if (InitialHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.name == "FireObject_3(Clone)")
        {
            InitialHealth -= 30;
            Debug.Log("Onitial Health is ======" + InitialHealth);
            if (InitialHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
