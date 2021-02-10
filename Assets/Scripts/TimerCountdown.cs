using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{
    public GameObject textDisplay;
    public GameObject loseText;

   public int secondsLeft = 20;
   public int newSecondsleft;
   public bool takingAway = false;


   void Start(){
   	textDisplay.GetComponent<Text>().text = "Go!";
   	loseText.SetActive(false);
   }

   void Update(){
   	if(takingAway ==false && secondsLeft >0){
   		StartCoroutine(TimerTake());
   	}
   }
   IEnumerator TimerTake(){
   	takingAway = true;
   	yield return new WaitForSeconds(1);
   	secondsLeft-=1;

   	if(secondsLeft < 10){
  		
   		textDisplay.GetComponent<Text>().text = "00:0"+secondsLeft;
   	}
   	else if(secondsLeft >= 60){
   		newSecondsleft = secondsLeft-60;
   		if(newSecondsleft <10){
   			textDisplay.GetComponent<Text>().text = "01:0"+newSecondsleft;
   		}
   		else{
   			textDisplay.GetComponent<Text>().text = "01:"+newSecondsleft;
   		}
   		
   	}
   	else{
   			textDisplay.GetComponent<Text>().text = "00:"+secondsLeft;
   	}

   	if(secondsLeft == 0){
			loseText.SetActive(true);
   	}
   
   	takingAway = false;
   }
}
