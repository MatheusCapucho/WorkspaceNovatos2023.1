using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mago : Personagem, ITakeDamage
{
    public Mago() { _stealth = false; }

    public override float GetDano()
    {
        return _dano;
    }

    public void MultiplicadorDeDano(float mult)
    {
        _dano *= mult;
    }

    public void TakeDamage(float amount)
    {
        _vida -= amount * 2f;
    }
}
