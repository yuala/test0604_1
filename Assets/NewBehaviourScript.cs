using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //各変数宣言
    Vector3 moveDirection = Vector3.forward;//移動方向
    Vector3 rotationAxis = Vector3.up;//回転方向
    float moveSpeed;//移動速度
    float rotationSpeed;//回転速度
    int framCount;

    // Start is called before the first frame update
    void Start()
    {
        //初期値として設定
        moveSpeed = 15f;
        rotationSpeed = 120f;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
