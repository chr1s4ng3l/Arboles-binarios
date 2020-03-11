/*
 * Creado por SharpDevelop.
 * Usuario: Christopher
 * Fecha: 28/10/2019
 * Hora: 04:04 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace LaberintoConArbol
{
	/// <summary>
	/// Description of Nodo.
	/// </summary>
	public class Nodo
	{
		private byte dato;
		public Nodo arriba, derecha, izquierda, abajo;
		public Nodo()
		{
			
		}
		public Nodo(byte dato){
			this.dato=dato;
			
		}
		
		public byte Dato{
			get{
				return this.dato;
			}
			set{
				if(value>=0 && value <5)
					this.dato = value;
				else
					this.dato=1;
			}
		}
	}
}
