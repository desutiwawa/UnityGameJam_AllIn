using UnityEngine;

public class MainCameraScript : MonoBehaviour
{

    public float RotSpeed = 0.5f;
    public float RotUpLimit = 40.0f;
    public float RotDownLimit = -20.0f;
    public float CameraRange = 3.0f;
    public float CameraY_Up = 1.5f;

    private GameObject player;
    private float nowX_Rot = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PlayerScriptタグがついたオブジェクトを探す。
        player = GameObject.FindGameObjectWithTag("Player");
        //初期X軸の回転量を保存
        nowX_Rot = transform.localEulerAngles.x;

    }

    // Update is called once per frame
    void Update()
    {
        float Up_rot = 0.5f;
        if(Input.GetKey(KeyCode.UpArrow))
        {
            Up_rot = -RotSpeed;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            Up_rot = RotSpeed;
        }
        else
        {
            Up_rot = 0.0f;
        }


        //上下角度制限
        nowX_Rot += Up_rot;
        if(nowX_Rot > RotUpLimit || nowX_Rot < RotDownLimit)
        {
            nowX_Rot = Mathf.Clamp(nowX_Rot, RotDownLimit, RotUpLimit);
            Up_rot = 0.0f;
        }
        transform.RotateAround(player.transform.position, this.transform.right, Up_rot);

        //左右
        float Left_rot;
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Left_rot = -RotSpeed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Left_rot = RotSpeed;
        }
        else
        {
            Left_rot = 0.0f;
        }
        transform.RotateAround(player.transform.position, Vector3.up, Left_rot);


        //座標計算
        //カメラの前方向を使って移動量を計算
        Vector3 cameraMove = transform.forward * -CameraRange;
        //カメラを少し持ち上げる
        cameraMove.y += CameraY_Up;
        //座標設定
        transform.position = player.transform.position + cameraMove;

    }
}
