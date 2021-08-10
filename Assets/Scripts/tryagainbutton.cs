using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tryagainbutton : MonoBehaviour
{

    public void click()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
