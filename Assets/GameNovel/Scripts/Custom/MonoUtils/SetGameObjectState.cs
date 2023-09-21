using Naninovel;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace GameNovel
{
    public class SetGameObjectState : MonoBehaviour
    {
        [SerializeField] private List<GameObject> gObject;
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
                foreach(GameObject go in gObject)
                    go.SetActive(true);
            }
            else
            {
                foreach (GameObject go in gObject)
                    go.SetActive(false);
            }
        }
    }
}
