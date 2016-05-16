using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {

    public Transform target;
    public float cameraDistance = -10.0f;
		
	void Update ()
    {
        transform.position = new Vector3(target.position.x, target.position.y, cameraDistance);
	}
}
