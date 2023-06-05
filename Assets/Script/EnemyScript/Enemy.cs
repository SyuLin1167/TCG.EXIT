using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //���S�Ɗp�x
    [SerializeField] private GameObject enemy;
    [SerializeField] private Vector3 pos;
    [SerializeField] private float angle = 50;

    private GameObject enemys;

    // Start is called before the first frame update
    void Start()
    {
        enemys = Instantiate(enemy, transform.position, transform.rotation);  //弾を複製
        enemys.transform.position=this.transform.position+pos;
    }

    // Update is called once per frame
    void Update()
    {
        enemys.transform.RotateAround(this.transform.position, Vector3.forward, angle * Time.deltaTime);
    }
}
