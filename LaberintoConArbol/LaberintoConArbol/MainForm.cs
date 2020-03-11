/*
 * Creado por SharpDevelop.
 * Usuario: Christopher
 * Fecha: 28/10/2019
 * Hora: 04:03 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace LaberintoConArbol
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
	public partial class MainForm : Form
	{
//		static String cadena2 = "";
		Nodo inicioN;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		public static String CaminosValidos(Nodo actual, String cadena, String cadena2){
			
			if(actual.arriba != null){
				
				CaminosValidos(actual.arriba, cadena+"Arr, ", "");
			}
			if(actual.derecha != null){
				
				CaminosValidos(actual.derecha, cadena+"Der, ", "");
			}
			if(actual.izquierda != null){
				
				CaminosValidos(actual.izquierda, cadena+"Izq, ", "");
			}
			if(actual.abajo != null){
				
				CaminosValidos(actual.abajo, cadena+"Abj, ", "");
			}
			
			if( actual.Dato == 3){
				
				cadena2+=cadena.Substring(0, cadena.Length-2) + "-";
				
//				MessageBox.Show(cadena.Substring(0, cadena.Length-2));
			}
			return cadena2;
		}
		
		public static void MostrarArbol(Nodo actual, String cadena){

			
			
			if(actual.arriba != null){
				
				MostrarArbol(actual.arriba, cadena+"Arriba, ");
			}
			if(actual.derecha != null){
				
				MostrarArbol(actual.derecha, cadena+"Derecha, ");
			}
			if(actual.izquierda != null){
				
				MostrarArbol(actual.izquierda, cadena+"Izquierda, ");
			}
			if(actual.abajo != null){
				
				MostrarArbol(actual.abajo, cadena+"Abajo, ");
			}
			if(actual.arriba == null && actual.derecha == null && actual.izquierda == null && actual.abajo == null){
				MessageBox.Show(cadena);
			}
			
		}
		
		public static void Mover(byte [,]Matriz, byte fila, byte columna, Nodo actual){
			
			if(actual.Dato != 3){

				Matriz[fila,columna]=4;
				
				//arriba
				if(fila>0){
					if(Matriz[fila-1,columna]==0 || Matriz[fila-1,columna]==3){
						
						actual.arriba = new Nodo(Matriz[fila-1,columna]);
						Mover(Matriz, (byte)(fila-1), columna,actual.arriba);
					}
				}
				
				//derecha
				if(columna < Matriz.GetUpperBound(1)){
					if(Matriz[fila,columna+1]==0 || Matriz[fila,columna+1]==3){
						
						actual.derecha = new Nodo(Matriz[fila,columna+1]);
						Mover(Matriz,fila,(byte)(columna+1), actual.derecha);
					}
				}
				
				//izquierda
				if(columna > 0){
					if(Matriz[fila,columna-1]==0 || Matriz[fila,columna-1]==3 ){
						
						actual.izquierda = new Nodo(Matriz[fila,columna-1]);
						Mover(Matriz,fila,(byte)(columna-1), actual.izquierda);
					}
				}

				//abajo
				if(fila < Matriz.GetUpperBound(0)){
					if(Matriz[fila+1,columna] ==0 || Matriz[fila+1,columna]==3){
						
						actual.abajo = new Nodo(Matriz[fila+1,columna]);
						Mover(Matriz,(byte)(fila+1),columna,actual.abajo);
					}
				}
			}
			
			
		}
		
		public static Boolean Llenado(byte [,]Matriz, TextBox txt){
			
			try{
				
				for (int i = 0; i < txt.Lines.Length ; i++) {
					String cadena = txt.Lines[i];
					String []aux = cadena.Split(',');
					for (int j = 0; j < aux.Length; j++) {
						if (!aux[j].Equals("")){
							Matriz[i,j] =Convert.ToByte(aux[j]);
							
						}
					}
				}
				
			} catch(Exception){
				MessageBox.Show("Error en formato de entrada");
				return false;
			}
			return true;
		}
		
		void ButtonCargarClick(object sender, EventArgs e)
		{
			textBoxdDatos.Text="";
			StreamReader leer = new StreamReader(@"datos.txt"); //leemos el archivo datos.txt
			try {
				
				string datos = leer.ReadLine();
				
				while(datos != null){ //mientras la linea que lee no sea null
					textBoxdDatos.AppendText(datos); //cargamos los datos a el texboxtDatos
					textBoxdDatos.Text+=Environment.NewLine;
					datos = leer.ReadLine();
					
					
				}
				leer.Close();
				
			} catch(Exception){
				MessageBox.Show("Error en formato de entrada");
				
			}
		}
		
		void ButtonCMClick(object sender, EventArgs e)
		{
			byte inicioFila =0;
			byte inicioColumna =0;
			try{
				
				textBoxdDatos.Text=textBoxdDatos.Text.Trim(); //quitamos los espacios en blanco del texboxdatos
				textBoxMatriz.Text="";
				if(textBoxdDatos.Text.Length>0){
					byte filasA = 0, colA = 0;
					filasA = Convert.ToByte(textBoxdDatos.Lines.Length);
					colA =  Convert.ToByte(textBoxdDatos.Lines[0].Split(',').Length);
					byte [,] A =  new byte [filasA,colA];
					bool salA = Llenado(A,textBoxdDatos);
					
					if(salA==true){
						
						for (int i = 0; i < filasA; i++) {
							String fila = textBoxdDatos.Lines[i];
							String [] aux = fila.Split(',');
							for (int j = 0; j <colA; j++) {
								A[i,j] =Convert.ToByte(aux[j]);
								if(A[i,j] ==2){
									inicioFila = (byte)i;
									inicioColumna = (byte)j;
									inicioN = new Nodo(2);
									
								}
								
							}
							
						}
						//llamamos el metodo
						
						Mover(A,inicioFila,inicioColumna, inicioN);
						String cadena2 =CaminosValidos(inicioN, "", "");
						cadena2=cadena2.Substring(0, cadena2.Length-1);
						String []aux1 = cadena2.Split('-');
						String menor;
						menor=aux1[0];
						
						for (int i = 1; i < aux1.Length; i++) {
							if(aux1[i].Length<menor.Length ){
								menor=aux1[i];
								
							}
						}
						MessageBox.Show("El camino mas corto es: "+menor);
						
					}else{
						MessageBox.Show("Error al llenar la matriz");
					}
				}else{
					MessageBox.Show("No hay datos para insertar en la matriz");
				}
				
				
			} catch(Exception ex){
				MessageBox.Show(ex.Message.ToString());
				
			}
		}
		
	}
}
