using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Canvas Canvas;
    public TextMeshProUGUI ManaText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ManaText.text = ("Mana " + Shooting.ManaCount + "/" + Shooting.MaxMana);

        Shooting.FillAmmo(Recharge.IsCahrging);
    }
}
