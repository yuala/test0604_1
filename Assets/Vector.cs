using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{

    //プレイヤーのポジション設定
    Vector2 playerPos;
    //移動速度
    Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        //移動させた
        playerPos = new Vector2(3.0f, 4.0f);
        velocity = new Vector2(2.0f, 1.0f);

    }


    // Update is called once per frame
    void Update()
    {
        playerPos += velocity * Time.deltaTime;
        Debug.Log($"PlayerPrefs{playerPos}です");
    }
}
