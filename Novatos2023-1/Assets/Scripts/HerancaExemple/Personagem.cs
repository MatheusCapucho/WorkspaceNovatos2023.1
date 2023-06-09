using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Personagem : MonoBehaviour
{
    // METODO ABSTRATO
    public abstract float GetDano();

    // ATRIBUTOS
    private string _nome;

    protected float _vida;
    protected float _dano;
    protected float _agilidade;
    protected bool _stealth;

    // CONSTRUTOR(ES)
    public Personagem() { }
    public Personagem(string name) { _nome = name; }

    // MÉTODOS
    public string GetNome() { return _nome; }
    public void SetNome(string nome) { _nome = nome; }

    public void SetDano(float amount) { _dano = amount; }

    public void LoseHealth(float amount)
    {
        _vida -= amount;
    }

}
