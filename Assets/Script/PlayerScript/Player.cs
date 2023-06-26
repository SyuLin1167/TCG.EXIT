using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector3 plyPos;                             //プレイヤー座標
    [SerializeField] private float Speed=0.0f;

    private GameObject[] targetObj;
    private Vector3 targetPos;
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
                if(objNum<targetObj.Length-1)
                {
                    objNum++;
                    Debug.Log(objNum);
                    targetPos=targetObj[objNum].transform.position;
                }
                else
                {
                    targetPos=Goal.transform.position;
                }
            }
        }
        transform.position=Vector3.MoveTowards(transform.position,
        targetPos,Speed*Time.deltaTime);
        Debug.Log("経過時間(秒)" + Time.time);
    }

    //当たり判定
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy")||
            other.gameObject.CompareTag("Fire"))
        {
            //Debug.Log("HIT");
            //Destroy(this.gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }
}
