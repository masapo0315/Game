using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    //タイトル画面からメインゲームへ飛ぶ

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetButtonDown(""))
        {
            SceneManager.LoadScene("GameMain");
        }
    }
}
