using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptVita : MonoBehaviour
{
    public Slider slider;

    public void SetMaxEnergia(int energia)
    {
        slider.maxValue = energia;
        slider.value = energia;
    }

    public void SetEnergia(int energia)
    {
        slider.value = energia;
    }

    
}
