using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public int score = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = "score " + score.ToString();

    }
    public void Add(int point){
        score += point;
    }

    public void Set()
    {
        score = 0;
    }
}
