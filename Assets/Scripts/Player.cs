using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Weapon _weapon;

    void Start()
    {
        Debug.Log(_weapon.BaseDamage);
        Debug.Log(_weapon.FireRate);

    }
}
