using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAlpha : MonoBehaviour
{
    //アタッチしているオブジェクトをTextかImageかを判別し、点滅させる

    //public
    public float speed;

    //private
    private Text text;
    private Image image;
    private float time;

    private enum ObjType
    {
        Text,
        Image
    };
    private ObjType thisObjType = ObjType.Text;

    // Start is called before the first frame update
    void Start()
    {
        //アタッチしているオブジェクトを判別
        if (this.gameObject.GetComponent<Image>())
        {
            thisObjType = ObjType.Image;
            image = this.gameObject.GetComponent<Image>();
        } else if (this.gameObject.GetComponent<Text>())
        {
            thisObjType = ObjType.Text;
            text = this.gameObject.GetComponent<Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpDateAlpha()
    {
        //オブジェクトのアルファ値を更新
        if(thisObjType == ObjType.Image)
        {
            image.color = GetAlphaColor(image.color);
        } else if (thisObjType == ObjType.Text)
        {
            text.color = GetAlphaColor(text.color);
        }
    }

    //アルファ値を更新し、Colorを返す
    Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;
        color.a = Mathf.Sin(time) * 0.5f + 0.5f;

        return color;
    }
}
