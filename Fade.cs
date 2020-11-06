using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public GameObject End;

    float fadespeed = 0.02f;     //フェードスピード
    float alpha;            //透明度の数値

    public bool fadein;     //フェード判定

    // Start is called before the first frame update
    void Start()
    {
        fadein = false;
    }

    // Update is called once per frame
    void Update()
    {
        //フェードイン判定
        if (fadein)
        {
            //フェード開始
            Starfadein();
        }
    }
    void Starfadein()
    {
        //不透明度を上げる
        alpha += fadespeed;
        Setalpha();
        //1以上になったらフェードを停止
        if (alpha >= 1)
        {
            fadein = false;

        }
    }
    void Setalpha()
    {
        //色を更新
        End.GetComponent<Text>().color = new Color(0f, 0f, 0f, alpha);
    }
    public void Set()
    {
        End.GetComponent<Text>().color = new Color(0f, 0f, 0f, 0f);
        fadein = false;
        alpha = 0f;
    }
}
