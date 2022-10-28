using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections.Generic;

public class OneMouseDown_SwitchScene : MonoBehaviour
{
    public string シーン名;
    void OneMouseDown()
    {
        SceneManager.LoadScene (シーン名);
    }        
    
}
