using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 offset; //定义位置差变量
    // Start is called before the first frame update
    void Start()
    {
        //得到相机位置 transform.position
        //获取相机和物体的位置差
        offset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //使相机位置始终跟随小球
        transform.position = playerTransform.position+offset;
    }
}
