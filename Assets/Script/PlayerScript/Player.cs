using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 plyPos;                             //プレイヤー座標
    [SerializeField] private float Speed=0.0f;

    private GameObject[] targetObj;
    private GameObject nearObj;                         //最も近いオブジェクト
    private int objNum=0;

    [SerializeField] private GameObject Goal; 


    // Start is called before the first frame update
    void Start()
    {
        targetObj=GameObject.FindGameObjectsWithTag("Warp");
    }

    //更新処理
    void Update()
    {
        //SearchObj();
        if(transform.position.y>=targetObj[objNum].transform.position.y)
        {
            if (Input.GetKeyDown("space"))
            {
                if(targetObj.Length>=objNum)
                {
                    objNum++;
                }
                else
                {
                    transform.position=Vector3.MoveTowards(transform.position,
                    Goal.transform.position,Speed*Time.deltaTime);
                }
            }
        }

        transform.position=Vector3.MoveTowards(transform.position,
        targetObj[objNum].transform.position,Speed*Time.deltaTime);
    }

    //当たり判定
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy"||collision.collider.tag == "Fire")
        {
            Debug.Log("HIT");
            Destroy(gameObject);
        }
    }

    void SearchObj()
    {
        targetObj=GameObject.FindGameObjectsWithTag("Warp");
        foreach(GameObject obj in targetObj)
        {
            float nearDis=100.0f;
            float objDis=Vector3.Distance(transform.position,obj.transform.position);
            if(transform.position.y<=nearObj.transform.position.y&&nearDis>objDis)
            {
                nearObj=obj;
                nearDis=objDis;
            }
        }
    }
}
