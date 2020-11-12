﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Carta", menuName="Cartas/CartaSO")]
public class CartaScriptableObject : ScriptableObject
{
    public enum Palo { Bastos, Copas, Espadas, Oros }
    public string nombre;
    public Palo palo = Palo.Bastos;
    [SerializeField]
    int numero;
    public float valor;
    public bool esFigura;
    public Sprite sprite;
    public Sprite spriteDorso;

    public CartaScriptableObject(string nombre, Palo palo, int numero, float valor, bool esFigura, Sprite sprite, Sprite spriteDorso)
    {
        this.nombre = nombre;
        this.palo = palo;
        this.numero = numero;
        this.valor = valor;
        this.esFigura = esFigura;
        this.sprite = sprite;
        this.spriteDorso = spriteDorso;
    }
}
