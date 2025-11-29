using UnityEngine;

public class PlayerStateSaveManager : MonoBehaviour
{
    [SerializeField] internal float health = 100;
    [SerializeField] internal float hunger = 100;
    [SerializeField] internal float thirst = 100;
    [SerializeField] internal float stamina = 100;
    [SerializeField] internal float armor = 0;
    [SerializeField] internal float xp = 0;

    void Awake()
    {
        if (!PlayerPrefs.HasKey("Health"))
        { 
            PlayerPrefs.SetFloat("Health", health); 
        }
        if (!PlayerPrefs.HasKey("Hunger"))
        {
            PlayerPrefs.SetFloat("Hunger", hunger); 
        }
        if (!PlayerPrefs.HasKey("Thirst"))
        {
            PlayerPrefs.SetFloat("Thirst", thirst); 
        }
        if (!PlayerPrefs.HasKey("Stamina"))
        {
            PlayerPrefs.SetFloat("Stamina", stamina); 
        }
        if (!PlayerPrefs.HasKey("Armor"))
        {
            PlayerPrefs.SetFloat("Armor", armor); 
        }
        if (!PlayerPrefs.HasKey("XP"))
        {
            PlayerPrefs.SetFloat("XP", xp); 
        }
    }

    internal void SavePlayerStats()
    {
        PlayerPrefs.SetFloat("Health", health); 
        PlayerPrefs.SetFloat("Hunger", hunger); 
        PlayerPrefs.SetFloat("Thirst", thirst); 
        PlayerPrefs.SetFloat("Stamina", stamina);
        PlayerPrefs.SetFloat("Armor", armor); 
        PlayerPrefs.SetFloat("XP", xp);      
        Debug.Log("Oyuncu verileri kaydedildi!");
     }

    internal void LoadPlayerStats()
    {
        health = PlayerPrefs.GetFloat("Health");
        hunger = PlayerPrefs.GetFloat("Hunger");
        thirst = PlayerPrefs.GetFloat("Thirst");
        stamina = PlayerPrefs.GetFloat("Stamina");
        armor = PlayerPrefs.GetFloat("Armor");
        xp = PlayerPrefs.GetFloat("XP");    
        Debug.Log("Oyuncu verileri kayıttan yüklendi!");
    }
}
