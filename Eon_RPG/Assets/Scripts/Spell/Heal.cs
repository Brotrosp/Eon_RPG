using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public GameObject HealText;

    public void Start()
    {
        HealText.SetActive(false);
    }

    public void OnMouseOver()
    {
        HealText.SetActive(true);
    }

    public void OnMouseExit()
    {
        HealText.SetActive(false);
    }
}
