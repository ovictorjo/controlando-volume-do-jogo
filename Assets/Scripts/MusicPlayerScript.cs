using UnityEngine;

namespace Assets.Scripts
{
    public class MusicPlayerScript : MonoBehaviour
    {
        public AudioSource AudioSource;
        private float musicVolume = 1f;
        
        void Start()
        {
            AudioSource.Play();
        }

        
        void Update()
        {
            AudioSource.volume = musicVolume;
        }

        public void updateVolume (float volume)
        {
            musicVolume -= volume;
        }
    }
}
