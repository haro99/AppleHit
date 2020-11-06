using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour {

    public GameObject end;
    public GameObject button;
    public float sarttime;
    public int time;
	// Use this for initialization
	void Start () {
        //時計からスタートした時間を記憶
        sarttime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        //スタートした時間から今の時間を引いてカウントダウン
        time = 30 - (int)(Time.time - sarttime);

        //タイマーが0になったら0を表示する
        if (time > 0)
        {
            this.GetComponent<Text>().text = "time " + time.ToString();
        }
        else
        {
            this.GetComponent<Text>().text = "time 0";
            end.GetComponent<Fade>().fadein = true;
            button.SetActive(true);
        }
	}
    public void Set()
    {
        sarttime = Time.time;
    }
}
