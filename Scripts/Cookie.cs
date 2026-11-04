using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
    public void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            transform.localScale = Vector3.one * 0.95f;
        }
        if (Input.GetMouseButtonUp(0))
        {
            transform.localScale = Vector3.one;
            The.gameLogic.GetPoints();
        }
    }
}
