using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerChicken : MonoBehaviour
{
    
    void Start()
    {
        gameObject.SetActive(false);
    }

   public void ToggleWinMenu()
    {
        gameObject.SetActive(true);

    }
}
