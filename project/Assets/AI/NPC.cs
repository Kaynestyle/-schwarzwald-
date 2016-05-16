using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour {

    public Transform target;
    public Unit _Unit;

    public int maxHealth, curHealth;
    public gender myGender;
    public string myName, mySurname;
    public duty myDuty;
    public float movSpeed = 5;

    public enum gender {
        neutral,
        male,
        female
    }
    public enum duty {
        none,
        fisher,
        smith,
        etc
    }


    void Awake(){
        _Unit = this.gameObject.AddComponent<Unit>();
    }

    void Start(){
        moveToTarget(target);
    }

    void Update(){

    }

    void moveToTarget(Transform _target){
        _Unit._requestPath(movSpeed, _target);
    }

}