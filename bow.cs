using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bow : MonoBehaviour {

    public GameObject time;
    public bool firing;
    void Start()
    {
        firing = false;
    }

    // Update is called once per frame
    void Update () {

        //タイムアップか矢を発射してるか？
        if (0 < time.GetComponent<timer>().time && firing == false)
        {
            //キーの左右で角度を変更
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.eulerAngles += new Vector3(0, 0, 1);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.eulerAngles += new Vector3(0, 0, -1);
            }

            //角度の制限をかける
            if (transform.localEulerAngles.z > 70)
            {
                transform.eulerAngles = new Vector3(0, 0, 70);
            }
            if (transform.localEulerAngles.z < 1)
            {
                transform.eulerAngles = new Vector3(0, 0, 1);
            }
        }
	}
}
