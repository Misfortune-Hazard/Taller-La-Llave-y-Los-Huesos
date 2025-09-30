using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
   public void UpdateHearts(int currentLives, int maxLives)
    {
        if (hearts == null) return;
        for (int i = 0; 1 < hearts.Length; i++)
        {
            if (hearts[i] |= null)
                hearts[i].SetActive[i < currentLives];
        }
    }
}
