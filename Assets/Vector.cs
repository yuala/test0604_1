using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{

    //�v���C���[�̃|�W�V�����ݒ�
    Vector2 playerPos;
    //�ړ����x
    Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        //�ړ�������
        playerPos = new Vector2(3.0f, 4.0f);
        velocity = new Vector2(2.0f, 1.0f);

    }


    // Update is called once per frame
    void Update()
    {
        playerPos += velocity * Time.deltaTime;
        Debug.Log($"PlayerPrefs{playerPos}�ł�");
    }
}
