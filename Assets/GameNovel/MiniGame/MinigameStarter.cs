using Cysharp.Threading.Tasks;
using DTT.MinigameMemory;
using UnityEngine;

namespace GameNovel
{
    public class MinigameStarter : MonoBehaviour
    {
        [SerializeField] private MemoryGameManager _memoryGameManager;
        [SerializeField] private MemoryGameSettings _myGameSettings;

        [SerializeField] private GameObject timer;
        [SerializeField] private GameObject board;

        public void myStart()
        {
            timer.SetActive(true);
            board.SetActive(true);

            _memoryGameManager.StartGame(_myGameSettings);
            _memoryGameManager.Finish += Finish;
        }


        private void Finish(MemoryGameResults results)
        {
            _memoryGameManager.Stop();

            timer.SetActive(false);
            board.SetActive(false);
        }

        private void OnDisable()
        {
            timer.SetActive(false);
            board.SetActive(false);
        }
    }
}
