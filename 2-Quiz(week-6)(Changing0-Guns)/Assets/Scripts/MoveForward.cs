using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    private float MovingObjectSpeed = 5;

    void Start()
    {

    }
    void Update()
    {
         transform.Translate(Vector3.up * MovingObjectSpeed * Time.deltaTime);
    }
}
