using System.Collections;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
        static MusicScript instance;
        void Start()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else if (instance != this)
            {
                Destroy(gameObject);
            }
        }
}
