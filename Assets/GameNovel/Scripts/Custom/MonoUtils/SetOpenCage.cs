using Naninovel;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace GameNovel
{
    public class SetOpenCage : MonoBehaviour
    {
        [SerializeField] private Sprite[] cageSprite;
        [SerializeField] private Image image;
        [SerializeField] private Button button;
        [SerializeField] private string nameVaribleCage;

        void Awake()
        {
            SetCageState();
        }

        public void SetCageState()
        {
            ICustomVariableManager variableManager = Engine.GetService<ICustomVariableManager>();
            bool state = Convert.ToBoolean(variableManager.GetVariableValue(nameVaribleCage));

            if (!state)
            {
                image.sprite = cageSprite[0];
                button.interactable = true;
            }
            else
            {
                image.sprite = cageSprite[1];
                button.interactable = false;
            }
        }
    }
}
