using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vecor3 : MonoBehaviour
{
<<<<<<< HEAD

=======
    /*
     * 
     * 
     * 
     * aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
     * 
     * 
     */
>>>>>>> parent of 63a19ba (aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa)
    //player位置と方向
    Vector3 playerPosition;
    //player方向を表す
    Vector3 playerDirection;


    // Start is called before the first frame update
    void Start()
    {
        //playerの位置
        playerPosition = new Vector3(1.0f, 2.0f, 3.0f);
        //player正面向きに配置
        playerDirection = Vector3.forward;

        
    }

    // Update is called once per frame
    void Update()
    {

        //フレームカウント
        framCount++;
        if(framCount>=3)
        {
            //方向をランダムで設定する
            playerDirection = Random.onUnitSphere;
            //フレームカウントを初期化
            flamCount = 0;
        }
        //プレイヤーを移動させる
        playerPosition += playerDirection * 5f * Time.deltaTime;

        //コンソール画面で位置を表示
        Debug.Log($"Playerの位置：{playerPosition}");
    }
}
