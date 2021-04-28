using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class HealthScript : MonoBehaviour
{

    public Image healthBar;
    public float max_health = 5f;
    public float cur_health = 0f;


    // Start is called before the first frame update
    void Start()
    {
        cur_health = max_health;
        SetHealthBar();
    }

    public void TakeDamage(float amount)
    {
        cur_health -= amount;
        SetHealthBar();
    }

    // Update is called once per frame
    public void SetHealthBar()
    {
        float my_health=cur_health/max_health;
        healthBar.transform.localScale=new Vector3 (Mathf.Clamp(my_health,0f,1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
}
