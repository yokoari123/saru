using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSpawn1 : MonoBehaviour {

    public GameObject enemy;

    //public Vector2 tmp = new Vector2();

    private int cnt = 0;


    // Use this for initialization
    void Start() {
        cnt = 90;
    }

    void Update()
    {
        cnt++;

        float x = Random.Range(-7,7);
        float y = -8;
        Vector2 pos = new Vector2(x, y);


        if (cnt >= 50)
        {
            CreateEnemy(pos);
            cnt = 0;
        }
	}

    void CreateEnemy(Vector2 position)
    {
        Instantiate(enemy, position, transform.rotation);
    }

}
