using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private GameObject player;
    //[SerializeField] private float STEP = 1.0f;//移動速度
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, player.transform.position.y, -10);
        //this.transform.position += new Vector3(0, STEP * Time.deltaTime, 0);//上に移動
    }
}
