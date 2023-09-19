using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Attacker/Weapon")]
public class Weapon : ScriptableObject
{
    [SerializeField]
    private float _baseDamage;
    public float BaseDamage => _baseDamage;

    [SerializeField, Min(0)]
    private float _fireRate = 0.5f;
    public float FireRate => _fireRate;

}


