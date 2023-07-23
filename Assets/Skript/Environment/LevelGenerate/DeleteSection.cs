using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSection : MonoBehaviour
{
    private string mName;
    private string toDestroy = "LevelSection(Clone)";
    [Header("Define time to destroy section after it has spawned")]
    public int destroyAfterSeconds = 30;

    // Update is called once per frame
    void Start()
    {
        mName = transform.name;
        if (mName == toDestroy)
        {
            StartCoroutine(Delete());
        }
    }

    IEnumerator Delete()
    {
        yield return new WaitForSeconds(destroyAfterSeconds);
        Destroy(gameObject);
    }
}
