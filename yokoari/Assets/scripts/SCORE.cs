using UnityEngine;
using System.Collections;
using UnityEngine.UI;//Text操作

public class SCORE : MonoBehaviour
{
    private int score;
    private string key = "SCORE";
    // Use this for initialization
    void Start()
    {
        score = PlayerPrefs.GetInt(key, 0);
        GetComponent<Text>().text = "" + score.ToString();
    }
    public void AddPoint(int point)
    {
        score = point + score;
    }

    // Update is called once per frame
    void Update()
    {
        //スコアの更新
        GetComponent<Text>().text = score.ToString();
    }
}

