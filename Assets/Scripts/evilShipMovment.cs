using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evilShipMovment : MonoBehaviour
{

  public  GameObject Evilship;
  public float speed;
  public   GameObject fishspot1, fishspot2, fishspot3, fishspot4, fishspot5, fishspot6;
    Vector3 currentpos;
    int destsvisted = 0;
   



    // Start is called before the first frame update
    void Start()
    {
       
    }

    

    public void dest1()
    {
        if (destsvisted == 0)

        {
            //begin initial movment to point 1 
            Evilship.transform.position = Vector3.MoveTowards(Evilship.transform.position, fishspot1.transform.position, speed * Time.deltaTime);

            if (Evilship.transform.position == fishspot1.transform.position)

            {
                destsvisted = 1;
            }

           
        }
      
    }

    public void dest2()
    {
        if (destsvisted == 1)

        {
            Evilship.transform.position = Vector3.MoveTowards(Evilship.transform.position, fishspot2.transform.position, speed * Time.deltaTime);

            if (Evilship.transform.position == fishspot2.transform.position)

            {
                destsvisted = 2;
            }

        }

    }

    public void dest3()
    {
        if (destsvisted == 2)

        {
            Evilship.transform.position = Vector3.MoveTowards(Evilship.transform.position, fishspot3.transform.position, speed * Time.deltaTime);
            if (Evilship.transform.position == fishspot3.transform.position)

            {
                destsvisted = 3;
            }
        }

    }

    public void dest4()
    {
        if (destsvisted == 3)

        {
            Evilship.transform.position = Vector3.MoveTowards(Evilship.transform.position, fishspot4.transform.position, speed * Time.deltaTime);
            if (Evilship.transform.position == fishspot4.transform.position)

            {
                destsvisted = 4;
            }
        }

    }

    public void dest5()
    {
        if (destsvisted == 4)

        {
            Evilship.transform.position = Vector3.MoveTowards(Evilship.transform.position, fishspot5.transform.position, speed * Time.deltaTime);
            if (Evilship.transform.position == fishspot5.transform.position)

            {
                destsvisted = 5;
            }
        }

    }

    public void dest6()
    {
        if (destsvisted == 5)

        {
            Evilship.transform.position = Vector3.MoveTowards(Evilship.transform.position, fishspot6.transform.position, speed * Time.deltaTime);
            if (Evilship.transform.position == fishspot5.transform.position)

            {
                destsvisted = 0;
            }
        }

    }


    public void Move()

    {

        StartCoroutine(ExampleCoroutine());

        IEnumerator ExampleCoroutine()
        {
            //Print the time of when the function is first called.
            Debug.Log("Started Coroutine at timestamp : " + Time.time);

            //yield on a new YieldInstruction that waits for 5 seconds.
            yield return new WaitForSeconds(5);  //5

            dest1();

            yield return new WaitForSeconds(60); //40

            dest2();

            yield return new WaitForSeconds(60); //30
            dest3();


            yield return new WaitForSeconds(60); //
            dest4();

            yield return new WaitForSeconds(60);
            dest5();

            yield return new WaitForSeconds(60);

            Destroy(Evilship);
        }
    }
    

    // Update is called once per frame
    void Update()
    {

        Debug.Log(destsvisted);
        Move();
    }
}
