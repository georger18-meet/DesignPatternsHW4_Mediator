using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public static int MaxMana = 20;
    private static int _manaCount;
    private ParticleSystem _magic;

    public static int ManaCount
    {
        get
        {
            return _manaCount;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _manaCount = MaxMana;
        _magic = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (_manaCount > 0)
            {
                _manaCount--;
                _magic.Play();
            }
            Debug.Log(_manaCount);
        }
    }

    public static void FillAmmo(bool isCharging)
    {
        if (isCharging)
        {
            _manaCount = MaxMana;
        }
    }
}
