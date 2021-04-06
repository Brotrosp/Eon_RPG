using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fireball : MonoBehaviour
{

    public GameObject FireballText;
    
    public void Start()
    {
        FireballText.SetActive(false);
        
    }

    public void OnMouseOver()
    {
        FireballText.SetActive(true);
    }

    public void OnMouseExit()
    {
        FireballText.SetActive(false);
    }

    
}
