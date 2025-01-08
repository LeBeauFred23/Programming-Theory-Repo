using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;
using TMPro;
using UnityEngine.UI;
public class Shape : MonoBehaviour
{

    public Text shapeName;
    public virtual void ClickedShape()
    {
        Debug.Log("is clicked");
    }

    public void DisplayText()
    
    {

    }
}
