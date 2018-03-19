using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   public void seting()
    {
        global.pravo = true;
        global.levo1 = false;
        global.niz1 = false;
        global.pravo1 = false;
      
    }
   public void newGame()
    {
		
        global.levo = true;
        global.levo1 = false;
        global.niz1 = false;
        global.pravo1 = false;    
        
    }
   public void exit()
    {
        global.niz = true;
        global.levo1 = false;
        global.niz1 = false;
        global.pravo1 = false;
    }
   public void nazad0()
   {
       global.pravo1 = true;
       global.levo = false;
       global.niz = false;
       global.pravo = false;
   }
   public void nazad1()
   {
       global.levo1 = true;
       global.levo = false;
       global.niz = false;
       global.pravo = false;
   }
   public void nazad2()
   {
       global.niz1 = true;
       global.levo = false;
       global.niz = false;
       global.pravo = false;
   }
   public void exitgame()
   {
       Application.Quit();
   }
}
