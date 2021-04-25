using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Abilities : MonoBehaviour
{
    [Header("Ability 1")]
    public float cooldown1 = 2;
    public Image abilityImage1;
    bool isCooldown = false;
    public KeyCode ability1;

    [Header("Ability 2")]
    public float cooldown2 = 5;
    public Image abilityImage2;
    bool isCooldown2 = false;
    public KeyCode ability2;


    [Header("Ability 3")]
    public float cooldown3 = 10;
    public Image abilityImage3;
    bool isCooldown3 = false;
    public KeyCode ability3;

    public Animator animator;

    public GameObject proiettile;
    public GameObject puntatore;

    void Start()
    {
        abilityImage1.fillAmount = 0;
        abilityImage2.fillAmount = 0;
        abilityImage3.fillAmount = 0;
    }

    void Update()
    {
        Ability1();
        Ability2();
        Ability3();
    }
 
    void Ability1()
    {
        if (Input.GetKeyDown(ability1) && isCooldown == false)
        {
            isCooldown = true;
            abilityImage1.fillAmount = 1;
            animator.SetBool("AbilityFireBall", true);

            GameObject pallina = Instantiate(proiettile, puntatore.transform.position, puntatore.transform.rotation);
            pallina.GetComponent<Rigidbody>().velocity = puntatore.transform.forward * 10;
            Destroy(pallina, 2f);
        }

        if (isCooldown)
        {
            abilityImage1.fillAmount -= 1 / cooldown1 * Time.deltaTime;

            if (abilityImage1.fillAmount <= 0)
            {
                abilityImage1.fillAmount = 0;
                isCooldown = false;
                animator.SetBool("AbilityFireBall", false);
            }
        }
    }

    
    void Ability2()
    {
        if (Input.GetKeyDown(ability2) && isCooldown2 == false)
        {
            isCooldown2 = true;
            abilityImage2.fillAmount = 1;
            animator.SetBool("Heal", true);
        }

        if (isCooldown2)
        {
            abilityImage2.fillAmount -= 1 / cooldown2 * Time.deltaTime;

            if (abilityImage2.fillAmount <= 0)
            {
                abilityImage2.fillAmount = 0;
                isCooldown2 = false;
                animator.SetBool("Heal", false);
            }
        }
    }

    void Ability3()
    {
        if (Input.GetKeyDown(ability3) && isCooldown3 == false)
        {
            isCooldown3 = true;
            abilityImage3.fillAmount = 1;
        }

        if (isCooldown3)
        {
            abilityImage3.fillAmount -= 1 / cooldown3 * Time.deltaTime;

            if (abilityImage3.fillAmount <= 0)
            {
                abilityImage3.fillAmount = 0;
                isCooldown3 = false;
            }
        }
    }

}
