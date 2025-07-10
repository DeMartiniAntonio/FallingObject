using System.Collections;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
     [SerializeField] private AudioClip[] backgroundMusicClips;
     [SerializeField] private AudioSource backgroundMusicSource;
     [SerializeField] private AudioSource soundEffect;

    private void Awake()
    {
        backgroundMusicSource.clip = backgroundMusicClips[0];
    }

    IEnumerator PlayBackgroundMusic() {
        for (int i = 0; i < backgroundMusicClips.Length; i++) {
            backgroundMusicSource.clip=backgroundMusicClips[i];
            yield return new WaitForSeconds(backgroundMusicClips[i].length);
        }
        yield return PlayBackgroundMusic();
    }

    public void PlaySoundEffect() {
        soundEffect.Play();
    }
}
