using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject ShieldText;

    public void Start()
    {
        ShieldText.SetActive(false);
    }

    public void OnMouseOver()
    {
        ShieldText.SetActive(true);
    }

    public void OnMouseExit()
    {
        ShieldText.SetActive(false);
    }
}
