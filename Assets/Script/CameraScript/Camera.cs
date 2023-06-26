using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private GameObject target;
    //[SerializeField] private float STEP = 1.0f;//移動速度
    // Start is called before the first frame update

    float startTime;
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime >= 3.0f)
        {
            transform.position = new Vector3(0, target.transform.position.y, -10);
        }
    }
}
