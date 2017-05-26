using System.Linq;
using UnityEngine;
using System.Collections;
using System;

public class cube_spawn : MonoBehaviour
{
    public GameObject[] cobe = new GameObject[10];      //敵オブジェクト
    public int index = 0;                               //発生数
    public float interval;                              //発生間隔
    float timer = 0;                                    //経過時間
    public bool flg;
    public float Interval_Random_min = 1.0f;
    public float Interval_Random_max = 2.5f;


    void Start()
    {
        cobe = cobe.OrderBy(i => Guid.NewGuid()).ToArray();
    }

    void Update()
    {
        timer += Time.deltaTime;                        //経過時間加算
        if (timer >= interval)
        {
            if (index >= cobe.Length)
            {
                if(flg) index = 0;                       //あると無限生成
                cobe = cobe.OrderBy(i => Guid.NewGuid()).ToArray();
            }
            else
            {
                Spawn();                                //スポーン実行
            }
            index++;

            interval = UnityEngine.Random.Range(Interval_Random_min,Interval_Random_max);
            timer = 0;                                  //初期化
            
        }
    }

    void Spawn()
    {
        Vector3 pos = new Vector3(0, 10, 0);
        Instantiate(cobe[index], pos, Quaternion.identity);
    }
}