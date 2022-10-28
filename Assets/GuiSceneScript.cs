using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuiSceneScript : MonoBehaviour
{
    public Canvas canvas;
    public Text text;

    void Start()
    {
        canvas.envas.enabled = false;
        text.text = "ready・・・";
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.Space))
       {
        canvas.enabled = true;
       }
    }
    public void OnButtonClick()
    {
        text.text = "OK!!"
    }
}
