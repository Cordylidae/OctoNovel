using Naninovel;
using System;
using UnityEngine;

namespace GameNovel
{
    public class SetGameObjectState : MonoBehaviour
    {
        [SerializeField] private GameObject gObject;
        [SerializeField] private string nameVarible;
        [SerializeField] private bool reversed;

        void Awake()
        {
            SetState();
        }

        public void SetState()
        {
            ICustomVariableManager variableManager = Engine.GetService<ICustomVariableManager>();
            bool state = Convert.ToBoolean(variableManager.GetVariableValue(nameVarible));

            if (state ^ reversed)
            {
                gObject.SetActive(true);
            }
            else
            {
                gObject.SetActive(false);
            }
        }
    }
}
