using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody RbPlayer;

    private GameObject FirePrefab;
    public GameObject FirePrefab_1;
    public GameObject FirePrefab_2;
    public GameObject FirePrefab_3;
    private GameObject FireClone;
    private GameObject SelectedWeapon_1;
    private GameObject SelectedWeapon_2;
    private GameObject SelectedWeapon_3;


    public float HorizontalInput;
    public float VerticalInput;

    private float PlayerMovementSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        RbPlayer.GetComponent<Rigidbody>();
        SelectedWeapon_1 = GameObject.Find("Selected_Gun_1");
        SelectedWeapon_2 = GameObject.Find("Selected_Gun_2");
        SelectedWeapon_3 = GameObject.Find("Selected_Gun_3");
        SelectedWeapon_1.SetActive(false);
        SelectedWeapon_2.SetActive(false);
        SelectedWeapon_3.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        BombSelection();
        FireBomb();
    }
    public GameObject BombSelection()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            FirePrefab = FirePrefab_1;
            SelectedWeapon_1.SetActive(true);
            SelectedWeapon_2.SetActive(false);
            SelectedWeapon_3.SetActive(false);


        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            FirePrefab = FirePrefab_2;
            SelectedWeapon_1.SetActive(false);
            SelectedWeapon_2.SetActive(true);
            SelectedWeapon_3.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            FirePrefab = FirePrefab_3;
            SelectedWeapon_1.SetActive(false);
            SelectedWeapon_2.SetActive(false);
            SelectedWeapon_3.SetActive(true);
        }
        return FirePrefab;
    }
    public void Movement()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        RbPlayer.AddForce(Vector3.right * PlayerMovementSpeed * HorizontalInput * Time.deltaTime, ForceMode.Impulse);
        RbPlayer.AddForce(Vector3.forward * PlayerMovementSpeed * VerticalInput * Time.deltaTime, ForceMode.Impulse);
    }
    void FireBomb()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (FirePrefab == null)
            { Debug.Log("No Weapon Selected"); }
            else { FireClone = Instantiate(FirePrefab, transform.position + new Vector3(0, 0, 1), FirePrefab.transform.rotation); }
            
        }
    }
}
