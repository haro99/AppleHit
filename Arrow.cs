using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

    public Vector3 add;
    public Vector3 g;
    public Vector3 position;
    public Quaternion rotation;
    public GameObject bow;
    public GameObject fruit;
    public GameObject time;
    public bool a;
    public float angle;
    // Use this for initialization
    void Start () {

        a = false;
        add.x = 0;
        add.y = 0;
        add.z = 0;
        g.x = 0;
        g.y = -0.002f;
        g.z = 0;
    }
	
	// Update is called once per frame
	void Update () {

        //スペースを押されたら矢を飛ばす
        if (0 < time.GetComponent<timer>().time && Input.GetKeyDown(KeyCode.Space)　&& a == false)
        {
            position = this.transform.position;
            rotation = bow.transform.rotation;

            add.x = 0.2f * Mathf.Cos(bow.transform.localEulerAngles.z * Mathf.Deg2Rad);
            add.y = 0.2f * Mathf.Sin(bow.transform.localEulerAngles.z * Mathf.Deg2Rad);
            bow.GetComponent<bow>().firing = true;
            a = true;
        }

        //スペースを押されたら更新処理、矢の位置や角度を変更する
        if (a == true)
        {
            add += g;
            angle = (float)(Math.Atan2(add.y, add.x) * (180 / Math.PI));
            this.transform.position += add;
            this.transform.rotation = Quaternion.Euler(0f, 0f, angle);
        }
    }

    //当たった処理
    void OnTriggerEnter2D()
    {
        //当たった時に矢の位置を最初の位置に戻す
        //print("hit");
        add.x = 0;
        add.y = 0;
        add.z = 0;
        this.transform.position = position;
        this.transform.rotation = bow.transform.rotation;
        //フルーツのセットをセットする
        fruit.GetComponent<Fruit>().Set();
        bow.GetComponent<bow>().firing = false;
        a = false;
    }

    //画面外に出たら矢を戻す
    void OnBecameInvisible()
    {
        //print("out");
        add.x = 0;
        add.y = 0;
        add.z = 0;
        this.transform.position = position;
        this.transform.rotation = bow.transform.rotation;
        bow.GetComponent<bow>().firing = false;
        a = false;
    }
}