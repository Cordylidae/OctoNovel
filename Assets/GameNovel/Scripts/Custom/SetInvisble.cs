using Naninovel;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace GameNovel
{
    public class SetInvisble : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private string nameVaribleButton;

        void Awake()
        {
            setButtonState();
        }

        public void setButtonState()
        {
            ICustomVariableManager variableManager = Engine.GetService<ICustomVariableManager>();
            bool state = Convert.ToBoolean(variableManager.GetVariableValue(nameVaribleButton));

            Debug.Log(state);

            if (!state) button.interactable = true;
            else button.interactable = false;
        }

    }
}
