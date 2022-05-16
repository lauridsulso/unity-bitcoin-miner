using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

public static int btc;
public static int multiplier;


    // Start is called before the first frame update
    void Start()
    {
        multiplier = PlayerPrefs.GetInt("multiplier", 1);
        btc = PlayerPrefs.GetInt("btc", 0);

    }

    public void Update() {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
    }

   
}
