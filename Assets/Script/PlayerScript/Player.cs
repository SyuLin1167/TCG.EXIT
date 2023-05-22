using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 plyPos;                             //プレイヤー座標
    private Vector3 aimPos;                             //目標座標
    private float moveDistance;                         //移動距離
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime=Time.time;                            //開始時間をキャッシュ
        plyPos=transform.position;                      //プレイヤーの位置をキャッシュ
        aimPos=new Vector3(5,3,0);                     //目標座標設定
        moveDistance=Vector3.Distance(plyPos,aimPos);       //目標までの距離を求める

    }

    // Update is called once per frame
    void Update()
    {
        float ipValue=(Time.time-startTime)/moveDistance;  //フレームの補間値を算出
        transform.position=Vector3.Lerp(plyPos,aimPos,ipValue); //移動

    }
}
