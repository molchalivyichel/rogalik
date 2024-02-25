
using UnityEngine;

public class SpellCreation : MonoBehaviour
{
    public GameObject fireSpellPrefab; // Префаб огненного заклинания
    public GameObject iceSpellPrefab; // Префаб ледяного заклинания
    public GameObject lightningSpellPrefab; // Префаб молнии заклинания

    private int sphereCount = 0; // Счетчик нажатий на сферы
    private GameObject[] spheres = new GameObject[3]; // Массив для хранения нажатых сфер

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            // Добавляем нажатую сферу в массив
            spheres[sphereCount] = other.gameObject;
            sphereCount++;

            // Проверяем, если нажаты все три сферы
            if (sphereCount == 3)
            {
                CreateSpell();
                ResetSpheres();
            }
        }
    }

    private void CreateSpell()
    {
        // Определяем тип заклинания в зависимости от порядка нажатия на сферы
        if (spheres[0].name == "FireSphere" && spheres[1].name == "IceSphere" && spheres[2].name == "LightningSphere")
        {
            Instantiate(fireSpellPrefab, transform.position, Quaternion.identity);
        }
        else if (spheres[0].name == "IceSphere" && spheres[1].name == "FireSphere" && spheres[2].name == "LightningSphere")
        {
            Instantiate(iceSpellPrefab, transform.position, Quaternion.identity);
        }
        else if (spheres[0].name == "LightningSphere" && spheres[1].name == "FireSphere" && spheres[2].name == "IceSphere")
        {
            Instantiate(lightningSpellPrefab, transform.position, Quaternion.identity);
        }
    }

    private void ResetSpheres()
    {
        sphereCount = 0;
        spheres = new GameObject[3];
    }
}