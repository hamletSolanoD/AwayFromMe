using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator_Sala 
{

    private string TipoSala;// sala, pasillo
    private int Orientacion;// si es un pasillo debe tener orientacion 0 =  vertical 1 = horizontal 
    private bool recuerdoTrauma;
    public bool getRecuerdo_Trauma()
    {
        return recuerdoTrauma;
    }
    bool Jefe;
    public bool IsJefe() {

        return Jefe;
    }
    public int getOrientacion() {
        return Orientacion;

    }
    public string getTipoSala() {
        return TipoSala;
    }
    private int NivelDificultad; // 0 recompensas 1 sencillo 2 mediano 3 dificil
    public int getNivelDificultad() {
        return NivelDificultad;
    }
    private Material PisoMaterial;
    public Material getPisoMaterial()
    {
        return PisoMaterial;
    }
    private Material ParedesMaterial;
    public Material getParedesMaterial()
    {
        return ParedesMaterial;
    }
    private Material CieloMaterial;
    public Material getCieloMaterial()
    {
        return CieloMaterial;
    }

    private int EnemigosNumeroSpawns;
    public int getEnemigosNumeroSpawn() {
        return EnemigosNumeroSpawns;
    }
    private int NumeroRecuerdos;
    public int getNumeroRecuerdos() {
        return NumeroRecuerdos;
    }

   


    public MazeGenerator_Sala(string Tipo, Material  PisoMaterial, Material ParedesMaterial, Material CieloMaterial,int Orientacion, int nivelDificultad)
    {
        this.TipoSala = Tipo;
        this.PisoMaterial = PisoMaterial;
        this.ParedesMaterial = ParedesMaterial;
        this.CieloMaterial = CieloMaterial;
        this.Orientacion = Orientacion;
        this.NivelDificultad = nivelDificultad;
        Start();
    }
    public MazeGenerator_Sala(string Tipo, Material PisoMaterial, Material ParedesMaterial, Material CieloMaterial, int nivelDificultad)
    {
        TipoSala = Tipo;
        this.PisoMaterial = PisoMaterial;
        this.ParedesMaterial = ParedesMaterial;
        this.CieloMaterial = CieloMaterial;
        this.Orientacion = 0;
        this.NivelDificultad = nivelDificultad;
        Start();
    }


    void Start()
    {
        switch (NivelDificultad) {
            case 0:// zona segura 
                NumeroRecuerdos = Random.Range(1,4);
         
                EnemigosNumeroSpawns = 0;
                break;
            case 1:// dificultad leve
                NumeroRecuerdos = Random.Range(1,3);
              
                EnemigosNumeroSpawns = Random.Range(0,1);

                break;
            case 2:// dificultad medio
                NumeroRecuerdos = Random.Range(0, 2);
               
                EnemigosNumeroSpawns = Random.Range(1, 2);

                break;
            case 3:// dificultad alta
                recuerdoTrauma = true;
                NumeroRecuerdos = Random.Range(0, 1);
                EnemigosNumeroSpawns = Random.Range(2, 3);
                break;
            case 4:// Fobia Enemigo jefe
                NumeroRecuerdos = 0;
                EnemigosNumeroSpawns = 0;
                break;
            case 5:// pasillos
                NumeroRecuerdos = 0;
                EnemigosNumeroSpawns = 0;
                break;
        }
    }


}
