using UnityEngine;
using UnityEngine.UI;

namespace TempoSuspeito
{
    public class EnableDisableGameObjectWithToggle : MonoBehaviour
    {
        public Toggle Toggle;

        private void Start()
        {
            gameObject.SetActive(Toggle.isOn);            
            Toggle.onValueChanged.AddListener(OnValueChange);

        }

        private void OnDestroy()
        {
            Toggle.onValueChanged.RemoveListener(OnValueChange);
        }

        private void OnValueChange(bool newValue)
        {
            gameObject.SetActive(newValue);
        }    
    }
}