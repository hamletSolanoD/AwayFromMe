using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator : MonoBehaviour
{

    [SerializeField]
    private float XCuadrantesSize;
    [SerializeField]
    private float YCuadrantesSize;
    [SerializeField]
    private float ZCuadrantesSize;


    private MazeGenerator_Sala[,,] mapa;

    [SerializeField]
    private GameObject pisoMesh;

    [SerializeField]
    private GameObject paredMesh;

    

    [SerializeField]
    private GameObject puertaExtensionMesh;
    [SerializeField]
    private int EscalaDeImportacionPuertaExtension;

    [SerializeField]
    private GameObject puertaMesh;

    [SerializeField]
    private GameObject pisoCorredorMesh;





  
    
 
    private void generarPiso() {

        for (int z = 0; z < mapa.GetLength(2); z++)
        {

            for (int y = 0; y < mapa.GetLength(1); y++)
            {

                for (int x = 0; x < mapa.GetLength(0); x++)
                {
                    if (mapa[x, y, z] != null)
                    {

                        if (mapa[x, y, z].getTipoSala().Equals("sala"))
                        {
                            GameObject piso = Instantiate(pisoMesh, new Vector3(x * XCuadrantesSize, y * YCuadrantesSize, z * ZCuadrantesSize), new Quaternion());
                            GameObject Cielo = Instantiate(pisoMesh, new Vector3(x * XCuadrantesSize, (y * YCuadrantesSize) + YCuadrantesSize / 2, z * ZCuadrantesSize), Quaternion.Euler(new Vector3(180,0,0)));
                        }
                        else if (mapa[x, y, z].getTipoSala().Equals("pasillo"))
                        {
                            if (mapa[x, y, z].getOrientacion() == 0)// Vertical al norte
                            {
                                GameObject pasillo = Instantiate(pisoCorredorMesh, new Vector3(x * XCuadrantesSize, y * YCuadrantesSize, z * ZCuadrantesSize), new Quaternion());

                                GameObject CieloPasillo = Instantiate(pisoCorredorMesh, new Vector3(x * XCuadrantesSize, (y * YCuadrantesSize) + YCuadrantesSize / 2, z * ZCuadrantesSize), Quaternion.Euler(new Vector3(180, 0, 0)));
                            }
                            else { //horizontal 
                                GameObject pasillo = Instantiate(pisoCorredorMesh, new Vector3(x * XCuadrantesSize, y * YCuadrantesSize, z * ZCuadrantesSize), Quaternion.Euler(new Vector3(0, 90, 0)));

                                GameObject CieloPasillo = Instantiate(pisoCorredorMesh, new Vector3(x * XCuadrantesSize, (y * YCuadrantesSize) + YCuadrantesSize / 2, z * ZCuadrantesSize), Quaternion.Euler(new Vector3(180, 90, 0)));

                            }
                           

                        }
                    }


                }


            }


        }
    }
    private void GenerarParedNorte()
    {
        MazeGenerator_Sala salaAnterior = null;
        for (int y = 0; y < mapa.GetLength(1); y++){
            for (int x = 0; x < mapa.GetLength(0); x++)
            {
                salaAnterior = null;
                for (int z = mapa.GetLength(2) - 1; z >= 0; z--) 
                {
                    
                    if (mapa[x, y, z] != null) {
                        if (mapa[x, y, z].getTipoSala().Equals("pasillo"))
                        {
                           
                            
                                if (mapa[x, y, z].getOrientacion() == 0  && salaAnterior == null)// si es un pasillo vertical que da al vacio 
                                {
                                    GameObject paredNorte = Instantiate(paredMesh, new Vector3((x * XCuadrantesSize), (y * YCuadrantesSize) + YCuadrantesSize / 4 , (z * ZCuadrantesSize) + ZCuadrantesSize / 2 +0.4f), Quaternion.Euler(new Vector3(180, 0, 0)));
                                }
                                else if(mapa[x, y, z].getOrientacion() == 1 && (salaAnterior == null || salaAnterior.getTipoSala().Equals("sala") || (salaAnterior.getTipoSala().Equals("pasillo")   && salaAnterior.getOrientacion() == 1 ))) {
                                    // si es un pasillo horizontal  que da al vacio 
                                    GameObject paredNorte = Instantiate(paredMesh, new Vector3((x * XCuadrantesSize), (y * YCuadrantesSize) + YCuadrantesSize / 4 , (z * ZCuadrantesSize) + ZCuadrantesSize / 4 +0.4f), Quaternion.Euler(new Vector3(180, 0, 0)));
                                }
                            



                        }
                     
                        else
                        {// sala 

                           
                            if (salaAnterior == null)
                            {// si es una sala y al norte tiene nada pinitar pared
                                GameObject paredNorte = Instantiate(paredMesh, new Vector3(x * XCuadrantesSize, (y * YCuadrantesSize) + YCuadrantesSize / 4 , (z * ZCuadrantesSize) + YCuadrantesSize / 2 + 0.4f), Quaternion.Euler(new Vector3(180,0,0)));
                            }
                            else if (salaAnterior.getTipoSala().Equals("pasillo"))
                            {
                                if (salaAnterior.getOrientacion() == 0)
                                {// si es una sala y al norte tiene una pasillo vertical dibujar puerta
                                    GameObject paredNorte = Instantiate(puertaMesh, new Vector3(x * XCuadrantesSize, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize) + YCuadrantesSize / 2), Quaternion.Euler(new Vector3(0, 0, 0)));
                                }
                                else
                                {
                                    //si es una sala y al norte tiene un pasillo horizontal dibujar pared
                                    GameObject paredNorte = Instantiate(paredMesh, new Vector3(x * XCuadrantesSize, (y * YCuadrantesSize) + (YCuadrantesSize / 4) , (z * ZCuadrantesSize) + YCuadrantesSize / 2 +0.4f), Quaternion.Euler(new Vector3(180, 0, 0)));
                                }

                            }
                        }
                    }

                    salaAnterior = mapa[x, y, z];


                }
            }
        }
    }
    private void GenerarParedEste()
    {
        MazeGenerator_Sala salaAnterior = null;
        for (int y = 0; y < mapa.GetLength(1); y++)
        {
            for (int z = 0; z < mapa.GetLength(2); z++)
            {
                salaAnterior = null;
                for (int x = 0; x < mapa.GetLength(0); x++)
                {
                    if (mapa[x, y, z] != null)
                    {
                        if (mapa[x, y, z].getTipoSala().Equals("pasillo")) {/// si es un pasillo
                            if (mapa[x, y, z].getOrientacion() == 0)// un pasillo vertical 
                            {

                                if (salaAnterior != null && salaAnterior.getTipoSala().Equals("pasillo") && salaAnterior.getOrientacion() == 1)
                                {
                                    // si es un pasillo vertical con un pasillo horizontal al este pintar excedente 
                                    GameObject puertaEste = Instantiate(puertaExtensionMesh, new Vector3((x * XCuadrantesSize) - (XCuadrantesSize / 4) - (EscalaDeImportacionPuertaExtension * 0.25f), (y * YCuadrantesSize) + YCuadrantesSize / 4, z * ZCuadrantesSize), Quaternion.Euler(new Vector3(0, 90, 0)));
                                }

                                else
                                {
                                    /// si es un pasillo vertical sin ningun otro pasillo al este pintar pared
                                    GameObject paredEste = Instantiate(paredMesh, new Vector3((x * XCuadrantesSize) - YCuadrantesSize / 4 - 0.4f, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize)), Quaternion.Euler(new Vector3(0, 90, 0)));
                                }
                            }
                            else
                            {
                                if (salaAnterior == null)// si es un pasillo horizontal con nada al oeste pintar pared
                                {
                                    GameObject paredEste = Instantiate(paredMesh, new Vector3((x * XCuadrantesSize) - YCuadrantesSize / 2 - 0.4f, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize)), Quaternion.Euler(new Vector3(0, 90, 0)));

                                }
                            }
                        }
                        else {// si la sala anterior es una sala 
                            if (salaAnterior == null)
                            {// si la sala anterior es una sala y al este es vacio 
                                GameObject paredEste = Instantiate(paredMesh, new Vector3((x * XCuadrantesSize) - YCuadrantesSize / 2 - 0.4f, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize)), Quaternion.Euler(new Vector3(0, 90, 0)));

                            }
                            else if (salaAnterior.getTipoSala().Equals("pasillo")) /// si es un sala y al este tiene un pasillo 
                            {
                                if (salaAnterior.getOrientacion() == 0)
                                {
                                    GameObject paredEste = Instantiate(paredMesh, new Vector3((x * XCuadrantesSize) - YCuadrantesSize / 2 - 0.4f, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize)), Quaternion.Euler(new Vector3(0, 90, 0)));

                                }
                                else {
                                    GameObject puertaEste = Instantiate(puertaMesh, new Vector3((x * XCuadrantesSize) - XCuadrantesSize / 2, (y * YCuadrantesSize) + YCuadrantesSize / 4, z * ZCuadrantesSize), Quaternion.Euler(new Vector3(0, 90, 0)));
                                }
                            }
                        }

                    }
                  
                    salaAnterior = mapa[x, y, z];


                }
            }
        }
    }
    private void GenerarParedOeste()
    {
        MazeGenerator_Sala salaAnterior = null;
        for (int y = 0; y < mapa.GetLength(1); y++)
        {
            for (int z = 0; z < mapa.GetLength(2); z++)
            {
                salaAnterior = null;
                for (int x = mapa.GetLength(0)-1; x >= 0; x--)
                {
                    if (mapa[x, y, z] != null)
                    {
                        if (mapa[x, y, z].getTipoSala().Equals("pasillo"))
                        {// si es un pasillo 
                            if (mapa[x, y, z].getOrientacion() == 0)
                            {
                                if (salaAnterior != null && salaAnterior.getTipoSala().Equals("pasillo") && salaAnterior.getOrientacion() == 1)
                                {
                                    //si es un pasillo vetical y con un pasillo horizontal al Oeste pintar excedente 
                                    GameObject puertaEste = Instantiate(puertaExtensionMesh, new Vector3((x * XCuadrantesSize) + (XCuadrantesSize / 4) + (EscalaDeImportacionPuertaExtension * 0.25f), (y * YCuadrantesSize) + YCuadrantesSize / 4, z * ZCuadrantesSize), Quaternion.Euler(new Vector3(0, 90, 0)));
                                }

                                else
                                {
                                    //si es un pasillo vertical sin ningun otra cosa al Oeste pintar pared 
                                    GameObject paredOeste = Instantiate(paredMesh, new Vector3((x * XCuadrantesSize) + YCuadrantesSize / 4 +0.4f, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize)), Quaternion.Euler(new Vector3(0, -90, 0)));
                                }
                            }
                            else {
                                if(salaAnterior == null)// si es un pasillo horizontal con nada al oeste pintar pared
                                {
                                    GameObject paredOeste = Instantiate(paredMesh, new Vector3((x * XCuadrantesSize) + YCuadrantesSize / 2 + 0.4f, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize)), Quaternion.Euler(new Vector3(0, -90, 0)));

                                }
                            }
                        }
                        else // si es una sala 
                        {
                           
                            if (salaAnterior == null) // si es una sala con un oeste vacio pintar pared 
                            {
                                GameObject paredOeste = Instantiate(paredMesh, new Vector3((x * XCuadrantesSize) + YCuadrantesSize / 2 + 0.4f, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize)), Quaternion.Euler(new Vector3(0, -90, 0)));

                            }
                            else if (salaAnterior.getTipoSala().Equals("pasillo"))
                            {// si es una sala con un oeste tipo pasillo pintar puerta si es horizontal y pared si es vertical 

                                if (salaAnterior.getOrientacion() == 0)
                                {
                                    GameObject paredOeste = Instantiate(paredMesh, new Vector3((x * XCuadrantesSize) + YCuadrantesSize / 2 + 0.4f, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize)), Quaternion.Euler(new Vector3(0, -90, 0)));

                                }
                                else
                                {
                                    GameObject paredOeste = Instantiate(puertaMesh, new Vector3((x * XCuadrantesSize) + XCuadrantesSize / 2, (y * YCuadrantesSize) + YCuadrantesSize / 4, z * ZCuadrantesSize), Quaternion.Euler(new Vector3(0, 90, 0)));
                                }
                            }
                        }


                    }

                    salaAnterior = mapa[x, y, z];


                }
            }
        }
    }

    private void GenerarParedSur()
    {

        MazeGenerator_Sala salaAnterior = null;
        for (int y = 0; y < mapa.GetLength(1); y++)
        {
            for (int x = 0; x < mapa.GetLength(0); x++)
            {
                salaAnterior = null;
                for (int z = 0; z < mapa.GetLength(2); z++)
                {
                    if (mapa[x, y, z] != null)
                    {
                        if (mapa[x, y, z].getTipoSala().Equals("pasillo"))// si es un pasillo
                        {
                            if (mapa[x, y, z].getOrientacion() == 0)// si es un pasillo con orientacion vertical
                            {
                                if (salaAnterior != null && salaAnterior.getTipoSala().Equals("pasillo") && salaAnterior.getOrientacion() == 1)
                                //si es un pasillo con orientacion vertical y al sur tiene un pasillo con orientacion horizontal  pintar exedente 
                                {
                                    GameObject puertasur = Instantiate(puertaExtensionMesh, new Vector3((x * XCuadrantesSize), (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize) - ZCuadrantesSize / 2 - (EscalaDeImportacionPuertaExtension * 0.25f)), Quaternion.Euler(new Vector3(0, 0, 0)));
                                }
                                else if (salaAnterior == null)// si es un pasillo con orientacion vertical y al sur tiene el vacio
                                {
                                    GameObject paredSur = Instantiate(paredMesh, new Vector3(x * XCuadrantesSize, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize) - YCuadrantesSize / 2 - 0.4f), Quaternion.Euler(new Vector3(0, 0, 0)));
                                }
                            }
                            else {// si es un pasillo con orientacion horizontal 
                                if (salaAnterior != null && salaAnterior.getTipoSala().Equals("pasillo") && salaAnterior.getOrientacion() == 0)
                                //si es un pasillo con orientacion horizontal  y al sur tiene un pasillo con orientacion vertical pintar exedente 
                                {
                                    GameObject puertasur = Instantiate(puertaExtensionMesh, new Vector3((x * XCuadrantesSize), (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize) - ZCuadrantesSize / 4 - (EscalaDeImportacionPuertaExtension * 0.25f)), Quaternion.Euler(new Vector3(0, 0, 0)));
                                }
                                // si es un pasillo con orientacion horizontal y al sur no tiene nigun pasillo con orientacion vertical 
                                else
                                {
                                    
                                    GameObject paredEste = Instantiate(paredMesh, new Vector3((x * XCuadrantesSize), (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize) - ZCuadrantesSize / 4 - 0.4f), Quaternion.Euler(new Vector3(0, 0, 0)));
                                }

                            }

                        }
                        else// si es una sala 
                        {
                           
                             if (salaAnterior == null) // si es una sala y al sur tiene vacio pintar pared
                            {
                                GameObject paredSur = Instantiate(paredMesh, new Vector3(x * XCuadrantesSize, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize) - YCuadrantesSize / 2-0.4f), Quaternion.Euler(new Vector3(0, 0, 0)));

                            }

                            else if (salaAnterior.getTipoSala().Equals("pasillo"))// si es una sala y al sur tiene un pasillo 
                            {


                                if (salaAnterior.getOrientacion() == 0)// pasillo vertical pintar puerta
                                {
                                    GameObject paredSur = Instantiate(puertaMesh, new Vector3(x * XCuadrantesSize, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize) - YCuadrantesSize / 2), Quaternion.Euler(new Vector3(0, 0, 0)));
                                }
                                else// pasillo horizontal pintar pared
                                {
                                    GameObject paredSur = Instantiate(paredMesh, new Vector3(x * XCuadrantesSize, (y * YCuadrantesSize) + YCuadrantesSize / 4, (z * ZCuadrantesSize) - YCuadrantesSize / 2 - 0.4f), Quaternion.Euler(new Vector3(0, 0, 0)));

                                }

                            }
                        }
                    }
                    salaAnterior = mapa[x, y, z];


                }
            }
        }
    }
            
        

    
    void Start()
    {

        mapa = FindObjectOfType <MazeGenerator_MapGenerator> ().getMapa();

        generarPiso();
        GenerarParedNorte();
        GenerarParedSur();
        GenerarParedEste();
        GenerarParedOeste();


      
    }
    public static float redondeo(float Numero, int cantidadRedondeo)
    {
        float scale =  Mathf.Pow(10, cantidadRedondeo);
        return Mathf.Round (Numero * scale) / scale;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
