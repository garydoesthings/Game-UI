using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionsLog : MonoBehaviour {

    public GameObject previousMenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void openOptions(GameObject menu)
    {
        previousMenu = menu;
        this.gameObject.SetActive(true);
    }

    public void closeOptions()
    {
        if (previousMenu)
        {
            previousMenu.SetActive(true);
        }
        this.gameObject.SetActive(false);
    }


}
