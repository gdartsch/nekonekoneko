using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nekos : MonoBehaviour
{
    [SerializeField] private List<GameObject> nekos = new List<GameObject>();
    [SerializeField] private float timeToSpawnNewNeko;
    [SerializeField] private float yieldUntilReiterate;

    //TODO: Set the speed of the animation from code. Currently you have to go to the animation clip "NekoNekoNeko.anim" and set the samples. Bad and lazy implementation ngl.

    void Start()
    {
        StartCoroutine(NekoNekoNeko());
    }

    IEnumerator NekoNekoNeko()
    {
        while (true)
        {
            foreach (GameObject neko in nekos)
            {
                neko.SetActive(true);
                yield return new WaitForSeconds(timeToSpawnNewNeko);
            }

            foreach (GameObject neko in nekos)
            {
                neko.SetActive(false);
            }
            yield return new WaitForSeconds(yieldUntilReiterate);
        } 
    }
}
