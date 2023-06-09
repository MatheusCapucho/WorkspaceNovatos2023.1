using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameplayRPG : MonoBehaviour
{
    void Start()
    {
        Mago mage1 = new Mago();
        Assassin ass1 = new Assassin();

        mage1.SetDano(30f);
        mage1.MultiplicadorDeDano(3f);
        ass1.SetDano(20f);

        Debug.Log(mage1.GetDano());
        Debug.Log(ass1.GetDano());

        var objs = FindObjectsOfType<MonoBehaviour>().OfType<ITakeDamage>();

        foreach (var item in objs)
        {
            item.TakeDamage(10f);
        }



    }
}
