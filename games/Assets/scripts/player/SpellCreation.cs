
using UnityEngine;

public class SpellCreation : MonoBehaviour
{
    public GameObject fireSpellPrefab; // ������ ��������� ����������
    public GameObject iceSpellPrefab; // ������ �������� ����������
    public GameObject lightningSpellPrefab; // ������ ������ ����������

    private int sphereCount = 0; // ������� ������� �� �����
    private GameObject[] spheres = new GameObject[3]; // ������ ��� �������� ������� ����

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            // ��������� ������� ����� � ������
            spheres[sphereCount] = other.gameObject;
            sphereCount++;

            // ���������, ���� ������ ��� ��� �����
            if (sphereCount == 3)
            {
                CreateSpell();
                ResetSpheres();
            }
        }
    }

    private void CreateSpell()
    {
        // ���������� ��� ���������� � ����������� �� ������� ������� �� �����
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