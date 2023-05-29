using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 plyPos;                             //プレイヤー座標
    private GameObject[] targetObj;
    private GameObject nearObj;                         //最も近いオブジェクト
    private int objNum=1;
    [SerializeField] GameObject camera;
    private Vector3 cameraPos;

    // Start is called before the first frame update
    void Start()
    {
        targetObj=GameObject.FindGameObjectsWithTag("Warp");
        camera = GameObject.Find("Main Camera");
    }

    //更新処理
    void Update()
    {
        //SearchObj();
        if(transform.position.y>=targetObj[objNum].transform.position.y)
        {
            if(objNum!=0)
            {
                objNum--;
            }
        }


        transform.position=Vector3.MoveTowards(transform.position,
        targetObj[objNum].transform.position,5.0f*Time.deltaTime);

        cameraPos = camera.transform.position;//カメラの座標取得
        if(cameraPos.y > plyPos.y+2.0f)
        {
            Debug.Log("Game Over");
        }
    }

    //当たり判定
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
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
