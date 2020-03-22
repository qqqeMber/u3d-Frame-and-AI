using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int life = 20;
    //组件
    private Transform transform;
    private CapsuleCollider controller;
    //视角控制
    private Transform cameraTransform; // 摄像机的Transform组件
    //参数
    private float speed = 6.0f;
    private float gravity = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        controller = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        //移动控制
        float x = 0, y = 0, z = 0;
        //重力作用
        y = -gravity * Time.deltaTime;
        // 前后移动
        if (Input.GetKey(KeyCode.W))
        {
            z += speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            z -= speed * Time.deltaTime;
        }
        // 左右移动
        if (Input.GetKey(KeyCode.A))
        {
            x -= speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            x += speed * Time.deltaTime;
        }
        transform.position += new Vector3(x, y, z);
    }

    public void OnDamage(int damage)
    {
        life -= damage;
        // 如果生命为0，游戏结束，取消鼠标锁定
        if (life <= 0)
        {
            SceneManager.LoadScene("iceworld");
        }
    }
}
