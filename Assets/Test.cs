﻿using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

    int[] array = {21,33,56,100 };

    void Start ()
    {
     for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for(int i = array.Length-1;i>=0; i--)
        {
            Debug.Log(array[i]);
        }
        Boss boss = new Boss();
        for(int i = 0; i < 10; i++)
        {
            boss.Magic();

        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public class Boss
    {
        int mp = 53;

        public void Magic() 
        {
            if (mp > 5)
            {
                mp -= 5;

                Debug.Log("魔法攻撃をした。残りⅯＰは" + mp);
            }
            else
            {
                Debug.Log("ⅯＰが足りないため魔法が使えません");
            }
        }
    }
}
