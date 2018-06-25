using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {

    public GameObject PauseMenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
         if (Input.GetKey("escape"))
        {
            this.Pause();
        }
             
    }

    public void Quit()
    {
        Application.Quit();
    }

    void Pause()
    {
        PauseMenu.SetActive(true);
    }
}
