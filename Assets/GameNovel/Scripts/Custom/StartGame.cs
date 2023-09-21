using Naninovel;
using UnityEngine;

namespace GameNovel
{
    [CommandAlias("Hello")]
    public class StartGame : Command
    {
        public StringParameter Name;
        public override async UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            if (Assigned(Name))
            {
                Debug.Log($"Fuck bull, {Name}!");
            }
            else
            {
                Debug.Log("Fuck this bull!");
            }

            await UniTask.CompletedTask;
        }
    }
}

