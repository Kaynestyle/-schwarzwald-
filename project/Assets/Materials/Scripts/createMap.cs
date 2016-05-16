using UnityEngine;

public class createMap : MonoBehaviour {

    public GameObject myObj;
    private int addX;
    private int addY;

    void Start()
    {
        addX = 1;
        addY = 0;
        myObj.transform.position = new Vector3(-31f,31f,0f);
    }
    void Update()
    {
        if (addX < 63 && addY>(-63))
        {
            Instantiate(myObj, new Vector3( myObj.transform.position.x + addX, myObj.transform.position.y + addY, myObj.transform.position.z), Quaternion.identity);
            addX += 1;            
        }
        else
        {
            addX = 0;
            addY -= 1;
        }

    }
	
}
