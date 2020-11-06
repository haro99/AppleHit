using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {


    public GameObject apple;
    public GameObject meron;
    public GameObject score;
	// Use this for initialization
	void Start () {
        if (Random.Range(1, 3) < 2)
        {
            meron.SetActive(true);
            meron.transform.position = new Vector2(meron.transform.position.x, Random.Range(-4, 4));
        }
        else {
            apple.SetActive(true);
            apple.transform.position = new Vector2(apple.transform.position.x, Random.Range(-4, 4));
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Set()
    {
        //りんごなら10点、メロンなら50点を追加
        if (apple.activeSelf == true)
        {
            score.GetComponent<Score>().Add(10);
            apple.SetActive(false);
        }
        else
        {
            score.GetComponent<Score>().Add(50);
            meron.SetActive(false);
        }

        //ランダムでりんごかメロンを表示
        if (Random.Range(1, 3) < 2)
        {
            meron.SetActive(true);
            meron.transform.position = new Vector2(meron.transform.position.x, Random.Range(-4, 4));
        }
        else
        {
            apple.SetActive(true);
            apple.transform.position = new Vector2(apple.transform.position.x, Random.Range(-4, 4));
        }
    }
    public void Set2()
    {
        apple.SetActive(false);
        meron.SetActive(false);
        //ランダムでりんごかメロンを表示
        if (Random.Range(1, 3) < 2)
        {
            meron.SetActive(true);
            meron.transform.position = new Vector2(meron.transform.position.x, Random.Range(-4, 4));
        }
        else
        {
            apple.SetActive(true);
            apple.transform.position = new Vector2(apple.transform.position.x, Random.Range(-4, 4));
        }
    }
}
