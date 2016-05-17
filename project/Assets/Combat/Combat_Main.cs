using UnityEngine;
using System.Collections;

public class Combat_Main : MonoBehaviour {

    public enum damageType
    {
        a,
        b,
        c
    }

    public void attack(Transform _target, damageType _damageType, int damageValue)
    {
        NPC npc = _target.gameObject.GetComponent<NPC>();
        npc.setCurHealth(npc.getCurHealth()-(int)(1-(npc.getResistance((NPC.damageResistance)_damageType)))*damageValue);
    }

}
