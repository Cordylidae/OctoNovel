using UnityEngine;

namespace GameNovel
{
    public class CreateMiniGame : MonoBehaviour
    {
        public GameObject myMiniGame;
        void Start()
        {
            myMiniGame.GetComponent<Canvas>().worldCamera = Camera.main;
            myMiniGame.SetActive(true);

            DontDestroyOnLoad(myMiniGame);
        }
    }
}
