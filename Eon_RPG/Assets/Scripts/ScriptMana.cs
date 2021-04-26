using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptMana : MonoBehaviour
{
    public Slider slider;

    void SetMaxMana(int mana)
    {
        slider.maxValue = mana;
        slider.value = mana;
    }

    void SetMana(int mana)
    {
        slider.value = mana;
    }
}
