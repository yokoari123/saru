using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
    public float time;
    public string kye = "Timer";
    public GameObject GameOverText;
    void Start()
    {
        GameOverText.SetActive(false);
        time = PlayerPrefs.GetFloat(kye, 90);
        GetComponent<Text>().text = ((int)time).ToString();
    }

    void Update()
    {
        stop();
    }
    void stop()
    {
        time -= Time.deltaTime;
        PlayerPrefs.SetFloat(kye, time);
        if (time < 0)
        {
            GameOverText.SetActive(true);
            PlayerPrefs.DeleteKey(kye);
        }
        if (time < 0) time = 0;
        GetComponent<Text>().text = ((int)time).ToString();

    }
}