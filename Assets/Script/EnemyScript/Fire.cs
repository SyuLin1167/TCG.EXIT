using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] ParticleSystem fireParticle;
    [SerializeField] private float moveSpeed = 1.0f;//移動速度

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);//上に移動
        fireParticle.transform.position=this.transform.position+new Vector3(0,-5,0);
    }
}
