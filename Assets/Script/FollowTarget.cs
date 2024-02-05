using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 offset; //����λ�ò����
    // Start is called before the first frame update
    void Start()
    {
        //�õ����λ�� transform.position
        //��ȡ����������λ�ò�
        offset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //ʹ���λ��ʼ�ո���С��
        transform.position = playerTransform.position+offset;
    }
}
