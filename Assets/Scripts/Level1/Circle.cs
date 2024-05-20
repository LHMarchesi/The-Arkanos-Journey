using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UIElements;

public class Circle : MonoBehaviour
{

    private BattleManager battleManager;
    public bool hitOut = false;
    public bool hitIn = false;
    public bool destroy = false;
    [SerializeField] private string inputLetter;
    [SerializeField] private int points;
    [SerializeField] private int penaltyPoints;
    [SerializeField] private float deSpawnTime;
    [SerializeField] private Animator animator;

    private bool coroutineStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        battleManager = GameObject.Find("BattleManager").GetComponent<BattleManager>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        deSpawnTime -= Time.deltaTime;

        DestroyCircle();
    }

    private void DestroyCircle()
    {
        if (deSpawnTime <= 0)
        {
            if (!coroutineStarted)
            {
                coroutineStarted = true;
                StartCoroutine(enumerator());

                animator.SetBool("HitOut", true);
                hitOut = true;
                destroy = true;

                battleManager.PointsManager(-penaltyPoints);
                battleManager.LostHp();

            }

        }

        if (IsMouseOverCircle())
        {
            if (Input.anyKeyDown)
            {
                if (Input.inputString.ToUpper() == inputLetter.ToUpper())
                {
                    if (!coroutineStarted)
                    {
                        coroutineStarted = true;
                        StartCoroutine(enumerator());

                        hitIn = true;
                        animator.SetBool("HitIn", true);
                        destroy = true;

                        battleManager.PointsManager(points);
                    }
                }
                else
                {
                    if (!coroutineStarted)
                    {
                        coroutineStarted = true;
                        StartCoroutine(enumerator());

                        animator.SetBool("HitOut", true);
                        hitOut = true;
                        destroy = true;

                        battleManager.PointsManager(-points);
                        battleManager.LostHp();
                    }
                }

            }

        }
    }
    private bool IsMouseOverCircle()
    {
        // Obtiene la posici�n del mouse en el mundo
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = transform.position.z; // Ajusta la coordenada z para que coincida con la del c�rculo

        // Calcula la distancia entre la posici�n del c�rculo y la posici�n del mouse
        float distanceToCircle = Vector3.Distance(transform.position, mousePosition);

        // Si la distancia es menor que el radio del c�rculo, el mouse est� dentro del c�rculo

        return distanceToCircle < GetComponent<CircleCollider2D>().radius;
    }




    private IEnumerator enumerator()
    {

        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
        coroutineStarted = false;


    }
}
