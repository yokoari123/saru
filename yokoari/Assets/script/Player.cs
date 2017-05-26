using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    SpriteRenderer MainSpriteRenderer;
    // publicで宣言し、inspectorで設定可能にする
    public Sprite usiro;
    /*public Sprite migi;
    public Sprite hidari;*/
    // 速度
    public Vector2 SPEED = new Vector2(0.05f, 0.05f);
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 移動処理
        Move();
    }

    // 移動関数
    void Move()
    {
        // 現在位置をPositionに代入
        Vector2 Position = transform.position;
        // 左キーを押し続けていたら
        if (Input.GetKey("left"))
        {
            // 代入したPositionに対して加算減算を行う
            Position.x -= SPEED.x;
        }
        else if (Input.GetKey("right"))
        { // 右キーを押し続けていたら
          // 代入したPositionに対して加算減算を行う
            Position.x += SPEED.x;
        }
        else if (Input.GetKey("up"))
        { // 上キーを押し続けていたら
          // 代入したPositionに対して加算減算を行う
           /* ChangeStateToHold();*/
            Position.y += SPEED.y;

           
        }
        else if (Input.GetKey("down"))
        { // 下キーを押し続けていたら
          // 代入したPositionに対して加算減算を行う
            Position.y -= SPEED.y;
        }
        // 現在の位置に加算減算を行ったPositionを代入する
        transform.position = Position;
    }
   /* void ChangeStateToHold()
    {
        // SpriteRenderのspriteを設定済みの他のspriteに変更
        // 例) HoldSpriteに変更
        MainSpriteRenderer.sprite = usiro;
    }*/
}