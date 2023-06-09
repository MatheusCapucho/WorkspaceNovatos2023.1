using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assassin : Personagem, ITakeDamage
{
    public Assassin() { _stealth = true; }

    public override float GetDano()
    {
        return _dano;
    }

    public void TakeDamage(float amount)
    {
        _vida -= amount;
    }

    private void SetVida(float amount)
    {
        _vida = amount;
    }
}
