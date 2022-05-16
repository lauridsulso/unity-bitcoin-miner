using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Game : MonoBehaviour
{
    
    public Text ui;

   public void Increment() {
       GameManager.btc += GameManager.multiplier;
       PlayerPrefs.SetInt("btc", GameManager.btc);
   }

   public void Buy(int number) {
       if(number == 1 && GameManager.btc >= 50) {
           GameManager.btc -= 50;
           GameManager.multiplier += 5;
           PlayerPrefs.SetInt("btc", GameManager.btc);
           PlayerPrefs.SetInt("multiplier", GameManager.multiplier);

       }
       if(number == 2 && GameManager.btc >= 100) {
           GameManager.btc -= 100;
           GameManager.multiplier += 10;
           PlayerPrefs.SetInt("btc", GameManager.btc);
           PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
       }
       if(number == 3 && GameManager.btc >= 200) {
           GameManager.btc -= 200;
           GameManager.multiplier += 20;
           PlayerPrefs.SetInt("btc", GameManager.btc);
           PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
       }
       if(number == 4 && GameManager.btc >= 300) {
           GameManager.btc -= 300;
           GameManager.multiplier += 30;
           PlayerPrefs.SetInt("btc", GameManager.btc);
           PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
       }
       if(number == 5 && GameManager.btc >= 400) {
           GameManager.btc -= 400;
           GameManager.multiplier += 40;
           PlayerPrefs.SetInt("btc", GameManager.btc);
           PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
       }
       if(number == 6 && GameManager.btc >= 1000) {
           GameManager.btc -= 1000;
           GameManager.multiplier += 100;
           PlayerPrefs.SetInt("btc", GameManager.btc);
           PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
       }
   }
   
   void Update() {
       ui.text = "BTC: " + GameManager.btc;
   }
}
