using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    [SerializeField] private TextMeshProUGUI scoreText;

    private float score = 0;

    public void AddScore(int score)
    {
        this.score += score;
        scoreText.text = this.score.ToString();
    }
    public void AddHealth(float value)
    {
        Debug.Log("Added " + value + " health.");
    }
    public void AddMana(float value)
    {
        // Add mana logic here
        Debug.Log("Added " + value + " mana.");
    }

    public void AddDamage(float value)
    {
        // Add damage logic here
        Debug.Log("Added " + value + " damage.");
    }
}
