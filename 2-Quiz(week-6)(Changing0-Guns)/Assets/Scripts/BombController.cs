using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided With " + collision.collider.name);
        if (collision.gameObject.tag == "Enemy")
        {
            if (gameObject.name == "FireObject_1(Clone)")
            {
                //Debug.Log("Fire Object Name == " + gameObject);
                collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 3, ForceMode.Impulse);
                //Debug.Log("Force Applied "+collision.gameObject);
            }
            if (gameObject.name == "FireObject_2(Clone)")
            {
                //Debug.Log("Fire Object Name == " + gameObject);
                collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 6, ForceMode.Impulse);
                //Debug.Log("Force Applied " + collision.gameObject);
            }
            if (gameObject.name == "FireObject_3(Clone)")
            {
               // Debug.Log("Fire Object Name == " + gameObject);
                collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 9, ForceMode.Impulse);
                //Debug.Log("Force Applied " + collision.gameObject);
            }

        }
        Destroy(gameObject);
       //Debug.Log("Destroyed");
    }
}
