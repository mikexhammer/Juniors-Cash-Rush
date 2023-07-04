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
    
    // Update is called once per frame
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
        secNum = Random.Range(0, 3);
        Instantiate(sections[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        yield return new WaitForSeconds(0.25f);
        zPos += secLength;
        yield return new WaitForSeconds(2);
        creatingSections = false;
    }
}