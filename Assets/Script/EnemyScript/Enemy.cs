using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //íÜêSÇ∆äpìx
    [SerializeField] GameObject target;
    float angle = 50;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.forward, angle * Time.deltaTime);
    }
}
