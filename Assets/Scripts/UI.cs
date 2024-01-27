using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private TMP_InputField _speedField;
    [SerializeField] private TMP_InputField _dictanceField;
    [SerializeField] private TMP_InputField _spawnTimeField;

    public event UnityAction<string> SpeedFieldChanged;
    public event UnityAction<string> DictanceFieldChanged;
    public event UnityAction<string> SpawnTimeFieldChanged;


    



    public void SpeedChange()
    {
        SpeedFieldChanged?.Invoke(_speedField.text);
        Debug.Log(_speedField.text);
        Debug.Log("speed change");

    }

    public void DictanceChange()
    {
        DictanceFieldChanged?.Invoke(_dictanceField.text);
        Debug.Log(_speedField.text);
        Debug.Log("speed change");

    }

    public void SpawnTimeChange()
    {
        SpawnTimeFieldChanged?.Invoke(_spawnTimeField.text);
        Debug.Log(_speedField.text);
        Debug.Log("speed change");

    }
}
