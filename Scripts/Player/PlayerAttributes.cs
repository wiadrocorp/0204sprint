using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerAttributes : MonoBehaviour
{

    static int level = 1;

    int perkPt = 0;
    int statPt = 0;

    int currExp = 0;
    int nextLevelExp = (100 * level) * (level + 1);

    float baseDamage = 30;
    float baseAttSpd = 30;

    int baseStamina = 100;
    int currStamina = 100;
    int baseHealth = 150;
    int currHealth;
    int baseArmour = 0;

    //wszystko to som testy bozq

    Strength baseStrength;
    Dexterity baseDexterity;
    Agility baseAgility;
    Endurance baseEndurance;
    Vitality baseVitality;

    public Text printStamina; //zmienna na wyswietlanie

    private void Start()
    {
        SetPrintStamina();
    }

    public void GetExp(int e)
    {
        currExp += e;
        if (currExp >= nextLevelExp) LevelUp();
    }

    public void LevelUp()
    {
        level++;
        statPt += 2; //sila boza dla gracza na wydanie na statystyki
        if (level % 2 == 0) perkPt += 1; //gracz zdobywa perka do wydania na umiejetnosci cale te specjalne co 2 poziomy
        currExp = 0;
        //tutaj jakieś vfx sriksy dupiksy + dźwięki przy zdobyciu nowego poziomu
    }
    
    public void DealDamage() 
    {
        //tutaj dodać sprawdzanie czy stamina > 0
        //tutaj chyba dźwięki/animacje zadawania obrażeń
        float damage = baseDamage + (baseDamage * (baseStrength.BaseStrength * 0.06f));
        currStamina -= 20;
        if (currStamina < 0) currStamina = 0;
        //EnemyAttributes.TakeDamage(damage) ????
        
    }

    public void TakeDamage(int amount)
    {
        //tutaj chyba dźwięki/animacje dostawania obrażeń
        currHealth -= amount;
        
    }

    void SetPrintStamina()
    {
        printStamina.text = currStamina.ToString();
    }

    /*      TODO
     kupić rozpuszczalnik ógółem
     */

    
}
