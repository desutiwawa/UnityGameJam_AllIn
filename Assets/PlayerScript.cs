///
///プレイヤーを制御するクラス
///

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 0.02f;


    Rigidbody m_rigitBody;
    Animator m_playerAnimator;
    GameObject m_mainCamera;

    bool m_moveFlag;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_rigitBody = GetComponent<Rigidbody>();

        m_playerAnimator = GetComponent<Animator>();

        m_mainCamera = Camera.main.gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }


    void movePlayer()
    {
        //移動処理
        Vector3 move = Vector3.zero;

        //Wキー押したら
        if (Input.GetKey(KeyCode.W))
        {
            move.z += moveSpeed;
        }
        //Sキー押したら
        if (Input.GetKey(KeyCode.S))
        {
            move.z -= moveSpeed;
        }
        //Aキー押したら
        if (Input.GetKey(KeyCode.A))
        {
            move.x -= moveSpeed;
        }
        //Dキー押したら
        if (Input.GetKey(KeyCode.D))
        {
            move.x += moveSpeed;
        }
        //transform.position += move;

        //カメラを考慮した移動
        Vector3 PlayerMove = Vector3.zero;

        Vector3 forward = m_mainCamera.transform.forward;
        Vector3 right = m_mainCamera.transform.right;
        forward.y = 0.0f;
        right.y = 0.0f;
        right *= move.x;
        forward *= move.z;

        //移動速度に上記で計算したベクトルを加算する
        PlayerMove += right + forward;

        //移動
        transform.position += PlayerMove * Time.deltaTime;

        //移動フラグの更新
        if(PlayerMove.sqrMagnitude == 0.0f)
        {
            m_moveFlag = false;
        }
        else
        {
            m_moveFlag = true;
        }

        //回転
        if(PlayerMove.sqrMagnitude > 0.0f)
        {
            transform.rotation = Quaternion.LookRotation(PlayerMove.normalized);



        }


    }

    

  

   




}
