using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPath : MonoBehaviour
{
    //Posição do objetivo
    Transform goal;

    //Movimentação através do NavMesh
    NavMeshAgent nav;

    // Velocidade para deslocamento
    float speed= 5.0f;

    //OffSet de precisão de termino entre pontos
    float accuracy= 1.0f;

    // Velocidade de rotação do player
    float rotSpeed= 2.0f;

    // Refencia ao WPManager
    public GameObject wpManager;

    // Pontos localizados no mapa
    GameObject[] wps; 
    GameObject currentNode;
    int currentWP= 0;
    Graph g;

    // Start is called before the first frame update
    void Start()
    {
        // Obtem os pontos salvos em WPManager e passa para WPS
        wps = wpManager.GetComponent<WPManager>().waypoints;

        nav = GetComponent<NavMeshAgent>();
        //g = wpManager.GetComponent<WPManager>().graph;

        // Inicia com o valor 0
        //currentNode = wps[0];
    }


    private void LateUpdate()
    {
        // Se for igual 0 ele irá retornar.
       // if (g.getPathLength() == 0 || currentWP == g.getPathLength())
            return;

        //O nó que estará mais próximo neste momento
       // currentNode = g.getPathPoint(currentWP);

        //se estivermos mais próximo bastante do nó o tanque se moverá para o próximo
        //if (Vector3.Distance(g.getPathPoint(currentWP).transform.position, transform.position) < accuracy)
        //{
        //    currentWP++;
        //}

        // Será responsavel para alterar para o proximo destino
        //if (currentWP < g.getPathLength())
        //{
        //    goal = g.getPathPoint(currentWP).transform;
        //    Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);
        //    Vector3 direction = lookAtGoal - this.transform.position;
        //    this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);
        //    this.transform.position = Vector3.MoveTowards(transform.position, goal.position, Time.deltaTime * speed);
        //}
    }


    // Metodo para navegação até o heliporto no mapa
    public void GoToHeli() 
    {
        nav.SetDestination(wps[0].transform.position);
        //g.AStar(currentNode, wps[0]); 
        //currentWP = 0;
    }

    //Metodo para navegação até as ruinas no mapa
    public void GoToRuin() 
    {
        nav.SetDestination(wps[10].transform.position);
        //g.AStar(currentNode, wps[10]); 
        //currentWP = 0;
    }

    // Metodo para navegação até os tanques no mapa
    public void GoToTanques()
    {
        nav.SetDestination(wps[6].transform.position);
        //g.AStar(currentNode, wps[6]);
        //currentWP = 0;
    }

    public void GoToRefinery()
    {
        nav.SetDestination(wps[4].transform.position);
        //g.AStar(currentNode, wps[4]);
        //currentWP = 0;
    }

}
