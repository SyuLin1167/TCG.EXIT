using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPoint : MonoBehaviour
{
    private Vector3 warpPos;

    // Start is called before the first frame update
    void Start()
    {
        warpPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
