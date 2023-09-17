using UnityEngine;
using Naninovel;


namespace GameNovel
{
    public class StartGame : MonoBehaviour
    {
        public string ScriptName;
        public string Label;

        void GetStartScript()
        {
            var inputManager = Engine.GetService<IInputManager>();
            inputManager.ProcessInput = true;

            var scriptPlayer = Engine.GetService<IScriptPlayer>();
            scriptPlayer.PreloadAndPlayAsync(ScriptName, label: Label).Forget();

        }
    }

}
