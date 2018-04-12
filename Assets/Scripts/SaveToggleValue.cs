using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TempoSuspeito
{
    public class SaveToggleValue : MonoBehaviour
    {
        private static readonly Dictionary<string, bool> ValueDic = new Dictionary<string, bool>(); 
        private Toggle _toggle;
        public string Context;

        private void Awake()
        {
            _toggle = GetComponent<Toggle>();
        }

        private void Start()
        {
            if (ValueDic.ContainsKey(Context))
            {
                _toggle.isOn = ValueDic[Context];
            }
            else
            {
                ValueDic.Add(Context,_toggle.isOn);
            }
            
        }

        private void OnEnable()
        {
            _toggle.onValueChanged.AddListener(OnValueChange);
        }

        private void OnDisable()
        {
            _toggle.onValueChanged.RemoveListener(OnValueChange);
        }

        private void OnValueChange(bool newValue)
        {
            ValueDic[Context] = newValue;
        }    
    }
}