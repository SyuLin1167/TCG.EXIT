using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //���S�Ɗp�x
    [SerializeField] private GameObject enemy;
    [SerializeField] private Vector3 pos;
    [SerializeField] private float angle = 60;
        [SerializeField] private bool reversAngle=false;
    private Vector3 dir;

    private GameObject enemys;

    // Start is called before the first frame update
    void Start()
    {
        enemys = Instantiate(enemy, transform.position, transform.rotation);  //弾を複製
        enemys.transform.position=this.transform.position+pos;
        dir=new Vector3(0,1,0);
        if(reversAngle)
        {
            angle=-angle;
        }
    }

    // Update is called once per frame
    void Update()
    {
        enemys.transform.RotateAround(this.transform.position, Vector3.forward, angle * Time.deltaTime);
        enemys.transform.rotation=Quaternion.FromToRotation(Vector3.up, dir);
    }
}
