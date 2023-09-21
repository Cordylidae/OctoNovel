using Naninovel;
using System.Collections;
using UnityEngine;

namespace GameNovel
{
    [CommandAlias("MiniGame")]
    public class MiniGame : Command
    {
        public override async UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            var Task = UniTask.DelayFrame(10);
            await Task;
        }
    }
}
