using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {

    /// <summary>
    /// moves player to vector: target by speed
    /// </summary>
    /// <param name="target"></param>
    /// <param name="speed"></param>
    public void moveTo(Vector3 target, float speed)
    {        
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);        
    }
    /// <summary>
    /// rotates player to angle zRot by speed
    /// </summary>
    /// <param name="zRot"></param>
    /// <param name="speed"></param>
    public void rotateTo(float zRot, float speed)
    {
        //transform.Rotate(new Vector3(transform.rotation.x,transform.rotation.y, zRot));

        transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, zRot), Time.deltaTime * speed);
    }

    /// <summary>
    /// sets rotation instantly to given zRot
    /// </summary>
    /// <param name="zRot"></param>
    public void setRotation (float zRot)
    {
        transform.eulerAngles = new Vector3 (transform.eulerAngles.x,transform.eulerAngles.y, zRot);
    }
}
