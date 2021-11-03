using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickableNumberSpaceController : MonoBehaviour
{

    [SerializeField] int id;
    [SerializeField] int value;
    TextMeshProUGUI tmp;

    public void Awake()
    {
        tmp = GetComponent<TextMeshProUGUI>();
    }

    public void SetID(int i)
    {
        id = i;
    }


    public void SetValue(int i)
    {
        value = i;
        tmp.text = i.ToString();
        
    }
    
}
