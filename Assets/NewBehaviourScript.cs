using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //�e�ϐ��錾
    Vector3 moveDirection = Vector3.forward;//�ړ�����
    Vector3 rotationAxis = Vector3.up;//��]����
    float moveSpeed;//�ړ����x
    float rotationSpeed;//��]���x
    int framCount;

    // Start is called before the first frame update
    void Start()
    {
        //�����l�Ƃ��Đݒ�
        moveSpeed = 15f;
        rotationSpeed = 120f;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
