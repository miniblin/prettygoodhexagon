using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{

	private int score=0;
	public Text scoreText;
	static private Score _S;
	static public Score S {
		get{
			return _S;
		}
		set{
			if(_S!=null){
				Debug.Log("you are attempting to set this singleton a second time");
			}
			_S=value;
		}
	}
    // Use this for initialization
    void Start()
    {
		S=this;
		S.scoreText.text="0";
    }

    // Update is called once per frame
    static public void IncrementScore(){
		Debug.Log("Incrementing Score");
		S.score+=1;
		S.scoreText.text = S.score.ToString();;
	}
}
