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
    //player�ʒu�ƕ���
    Vector3 playerPosition;
    //player������\��
    Vector3 playerDirection;


    // Start is called before the first frame update
    void Start()
    {
        //player�̈ʒu
        playerPosition = new Vector3(1.0f, 2.0f, 3.0f);
        //player���ʌ����ɔz�u
        playerDirection = Vector3.forward;

        
    }

    // Update is called once per frame
    void Update()
    {

        //�t���[���J�E���g
        framCount++;
        if(framCount>=3)
        {
            //�����������_���Őݒ肷��
            playerDirection = Random.onUnitSphere;
            //�t���[���J�E���g��������
            flamCount = 0;
        }
        //�v���C���[���ړ�������
        playerPosition += playerDirection * 5f * Time.deltaTime;

        //�R���\�[����ʂňʒu��\��
        Debug.Log($"Player�̈ʒu�F{playerPosition}");
    }
}
