using UnityEngine;
using System.Collections;
using System;

public class NPC : MonoBehaviour {


    //variables

    private Transform target;
    private Unit unit;

    private int maxHealth, curHealth;
    private gender myGender;
    private string myName, mySurname;
    private duty myDuty;
    private float movSpeed = 5;

    private damageResistance myResistance;

    public enum gender
    {
        neutral,
        male,
        female
    }
    public enum duty
    {
        none,
        fisher,
        smith,
        etc
    }

    int[] damageResistance = new int[3];

    //functions

    void Awake(){
        unit = this.gameObject.AddComponent<Unit>();
    }

    void Start(){
        for(int i = damageResistance.Length; i>0; i--)
        {
            damageResistance[i] = 0;
        }
    }

    void Update(){

    }

    void moveToTarget(Transform _target){
        unit._requestPath(movSpeed, _target);
    }


    //getters

    public Transform getTarget()
    {
        return target;
    }

    public int getMaxHealth()
    {
        return maxHealth;
    }

    public int getCurHealth()
    {
        return curHealth;
    }

    public gender getGender()
    {
        return myGender;
    }

    public string getName()
    {
        return myName;
    }

    public string getSurname()
    {
        return mySurname;
    }

    public duty getDuty()
    {
        return myDuty;
    }

    public float getMovSpeed()
    {
        return movSpeed;
    }

    public int getResistance(int _resistance)
    {
        return damageResistance[_resistance];
    }

    //setters

    public void setTarget(Transform _target)
    {
        this.target = _target;
    }

    public void setMaxHealth(int _maxHealth)
    {
        this.maxHealth = _maxHealth;
    }

    public void setCurHealth(int _curHealth)
    {
        this.curHealth = _curHealth;
    }

    public void setGender(gender _gender)
    {
        this.myGender = _gender;
    }

    public void setName(string _name)
    {
        this.myName = _name;
    }

    public void getSurname(string _surname)
    {
        this.mySurname = _surname;
    }

    public void getDuty(duty _duty)
    {
        this.myDuty = _duty;
    }

    public void getMovSpeed(float _movSpeed)
    {
        this.movSpeed = _movSpeed;
    }

    public void setResistance(int _resistance, int _value)
    {
        damageResistance[_resistance] = _value;
    }

}