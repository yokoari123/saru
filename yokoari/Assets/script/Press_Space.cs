using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Press_Space : MonoBehaviour
{
    //[SerializeField]

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnPressDecide();
        }
    }

    void OnPressDecide()
    {

        Debug.Log("avcfvcdxsa");
        SceneManager.LoadScene("test");

        
    }
}
