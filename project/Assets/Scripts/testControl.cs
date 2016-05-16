using UnityEngine;
using System.Collections;

public class testControl : MonoBehaviour {

    private control control;

    void Start()
    {
        control = gameObject.GetComponent<control>();
    }
    
	void Update ()
    {
        //Beispiel1
        control.moveTo( Vector3.up*2, 1);

        //Beispiel2
        //control.moveTo(new Vector3(1,1,0), 1);

        //Beispiel3
        //control.rotateTo(45, 100);
    }
}
