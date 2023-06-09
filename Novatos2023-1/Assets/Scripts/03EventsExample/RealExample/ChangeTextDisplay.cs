using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeTextDisplay : MonoBehaviour
{

    private TextMeshProUGUI _textComponent;

    private void Awake()
    {
        _textComponent= GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        SwitchController.SomethingHappened += ChangeText;
    }

    private void OnDisable()
    {
        SwitchController.SomethingHappened -= ChangeText;
    }

    public void ChangeText()
    {
        _textComponent.text = "(>*-*)> Action <(*-*<)";
    }

}
