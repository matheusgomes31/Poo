﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cliente
{
	private int codigoCliente
	{
		get;
		set;
	}

	private string nomeCliente
	{
		get;
		set;
	}

	private int telefone
	{
		get;
		set;
	}

	public virtual IEnumerable<Venda> Venda
	{
		get;
		set;
	}

	public virtual void imprimirCliente()
	{
		throw new System.NotImplementedException();
	}

}

