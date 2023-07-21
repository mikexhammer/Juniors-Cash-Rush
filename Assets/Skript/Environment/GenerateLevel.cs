using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] sections;
    [Header("Set secLength to the length of the section")]
    [SerializeField] public int secLength = 50;
    private int zPos = 50; // 50 is the length of the section
    private bool creatingSections = false;
    private int secNum;

    [Header("Set time to generate new section")]
    public int generateAfterSeconds = 6;

    void Update()
    {
        if (creatingSections == false)
        {
            creatingSections = true;
            StartCoroutine(GenerateSections());
        }        
    }
    
    IEnumerator GenerateSections()
    {
        secNum = Random.Range(0, 6);
        Instantiate(sections[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += secLength;
        yield return new WaitForSeconds(generateAfterSeconds);
        creatingSections = false;
    }
}
