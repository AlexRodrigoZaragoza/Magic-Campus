using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasTextos : MonoBehaviour
{
    public Text texto;
    public GameObject canvas;
    public Ragdoll rag;

    public static bool EscenaPociones = true;
    public static bool EscenaMagia = false;
    public static bool EscenaMixta = false;
    public static bool Fin = false;

    private void Start()
    {
        StartCoroutine(TextosC());
    }


    public IEnumerator TextosC()
    {
        int num = Random.Range(1,7);
        int ran = Random.Range(1, 3);

        if (ran == 1)
        {
            canvas.SetActive(true);

            if (EscenaPociones == true && Fin == false)
            {

                if (num == 1)
                {
                    texto.text = "!Cuidado con lo que mezclas...¡";
                }

                else if (num == 2)
                {
                    texto.text = "Sabes cuanto cuestan los ingredientes, !ay...¡ las pociones son carísimas.";
                }

                else if (num == 3)
                {
                    texto.text = "Recuerda, debes juntar distintos ingredientes para conseguir una poción";
                }

                else if (num == 4)
                {
                    texto.text = "!Eeeeee tu espabila que estoy aquí¡";
                }

                else if (num == 5)
                {
                    texto.text = "¿Te vas a quedar ahí parado?";
                }

                else if (num == 6)
                {
                    texto.text = "Sabes que en realidad no soy de madera...";
                }
            }

            else if (EscenaMagia == true)
            {
                if (num == 1)
                {
                    texto.text = "¿Y tu te consideras un mago... JAJAJA?";
                }

                else if (num == 2)
                {
                    texto.text = "¿Que estas haciendo con las manos?";
                }

                else if (num == 3)
                {
                    texto.text = "Bueno si a eso lo llamas magia...";
                }

                else if (num == 4)
                {
                    texto.text = "!Eeeeee tu espabila que estoy aquí¡";
                }

                else if (num == 5)
                {
                    texto.text = "¿Te vas a quedar ahí parado?";
                }

                else if (num == 6)
                {
                    texto.text = "Sabes que en realidad no soy de madera...";
                }
            }

            else if (EscenaMixta == true)
            {
                if (num == 1)
                {
                    texto.text = "Ahora utiliza todo lo que has aprendido";
                }

                else if (num == 2)
                {
                    texto.text = "¿Eso es todo lo que sabes hacer...?";
                }

                else if (num == 3)
                {
                    texto.text = "Creia que te habiamos enseñado mejor";
                }

                else if (num == 4)
                {
                    texto.text = "!Eeeeee tu espabila que estoy aquí¡";
                }

                else if (num == 5)
                {
                    texto.text = "¿Te vas a quedar ahí parado?";
                }

                else if (num == 6)
                {
                    texto.text = "Sabes que en realidad no soy de madera...";
                }
            }

            yield return new WaitForSeconds(10f);

            StartCoroutine(TextosC());
        }

        else if(ran == 2)
        {
            Debug.Log("Default");
            canvas.SetActive(false);
            StartCoroutine(Wait());
        }

    }    

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(10f);
        StartCoroutine(TextosC());
    }

    public void Update()
    {
        if(rag.ragdoll == true)
        {
            canvas.SetActive(false);
            Fin = true;
        }
    }
}
