﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using RPG.Class.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Personagem
{
    #region Atributos Personagem
    public Item[] VetItem;

    public int MagiaAtual
    {
        get;
        set;
    }
    public string Nome
    {
        get;
        set;
    }
    public Item ArmaAtual
    {
        get;
        set;
    }
    public int Agilidade
    {
        get;
        set;
    }
    public int PontosdeVida
    {
        get;
        set;
    }
    public int PontoMagia
    {
        get;
        set;
    }
    public int PontosdeMana
    {
        get;
        set;
    }
    public int PontoArmadura
    {
        get;
        set;
    }
    public int ResistenciaMagica
    {
        get;
        set;
    }
    public int ForcaFisica
    {
        get;
        set;
    }
    public int Armadura { get; set; }
    public int ForcaMagica { get; set; }
    public int ContGolpe
    {
        get;
        set;
    }
    public string NomeImagem { get; set; }
    #endregion

    public Personagem()
    {
        this.VetItem = new Item[10];
    }
    public void AddPontosMana()
    {
        if ((this.PontosdeMana + 10) < 100)
            this.PontosdeMana += 10;
        else
            this.PontoMagia += (100 - (this.PontosdeMana + 10));
    }
    public void RemovePontosMana(Item item)
    {
        if (PontosdeMana - item.GastoMana < 0)
            this.PontoMagia = 0;
        else
            this.PontosdeMana = this.PontosdeMana - item.GastoMana;
    }
    public void ReceberAtaque(Item item)
    {
        this.PontosdeVida = this.PontosdeVida - item.Dano;
    }
    public void CurarPersonagem(Item item)
    {
        if (item.EfeitoItem == RPG.Class.Enum.EnumEfeitoItem.Cura.ToString())
            this.PontosdeVida = this.PontosdeVida + item.Cura;
        else
            this.PontosdeVida = this.PontosdeVida - item.Dano;
    }
    public void MenorArma()
    {
        this.ArmaAtual = VetItem[0];
        foreach (var item in VetItem)
        {
            if (item != null)
                if (item.Dano < this.ArmaAtual.Dano)
                    this.ArmaAtual = item;
        }
    }

    public void ReceberAtaqueEspecial(Item item)
    {
        if ((this.PontosdeVida - (item.Dano * 3)) >= 0)
            this.PontosdeVida = this.PontosdeVida - (item.Dano * 3);
        else
            this.PontosdeVida = 0;
    }
}

