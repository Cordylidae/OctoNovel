using Naninovel;
using Naninovel.Commands;
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
            SetButtonState();
        }

        public void SetButtonState()
        {
            int state = State();

            if (state == 0) button.interactable = true;
            else
            {
                button.interactable = false;
                Color dColor = Color.white;

                if (state != 1) dColor.a = 0.0f;
                SetDisabledColor(dColor);
            }
        }

        public void SetMapState()
        {
            int state = State();

            if (state == 0 || state == 3) button.interactable = true;
            else
            {
                button.interactable = false;
                Color dColor = Color.white;

                if (state == 2) dColor.a = 0.0f;
                SetDisabledColor(dColor);
            }
        }

        public void SetQuestState()
        {
            int state = State();

            if (state == 0 || state == 3) button.interactable = true;
            else
            {
                button.interactable = false;
            }
        }

        int State()
        {
            ICustomVariableManager variableManager = Engine.GetService<ICustomVariableManager>();
            return Convert.ToInt32(variableManager.GetVariableValue(nameVaribleButton));
        }

        void SetDisabledColor(Color color)
        {
            ColorBlock cb = button.colors;
            cb.disabledColor = color;
            button.colors = cb;
        }

    }
}
