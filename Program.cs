/*
 * Created by SharpDevelop.
 * User: pablo
 * Date: 08/11/2024
 * Time: 11:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace quicksortAlgorith
{
	class Program
	{
		public static int[] vetto = new int[10];
		
		public static void Main(string[] args)
		{
			Preenchervetor();
			QuicksortA(vetto, 0, vetto.Length - 1);
			
			//imprimir o vetor ordenado com quicksort
			Console.WriteLine("Vetor ordenado com QuickSort: ");
			for(int i = 0; i < vetto.Length; i++){
				Console.Write(", {0}", vetto[i]);
			}
			
			Console.ReadKey(true);
		}
		
		
		
		
		public static void Preenchervetor(){
			for(int i = 0; i<vetto.Length;i++){
				Console.WriteLine("digite os elementos para compor o vetor:");
				int a = int.Parse(Console.ReadLine());
				vetto[i] = a;
			}
			for (int i2 = 0; i2<vetto.Length;i2++){
				Console.Write(", {0}",vetto[i2]);
			}
			Console.WriteLine();
		}
		
		
		
		public static void QuicksortA(int[] vetor, int inicio, int finaldovetor){
			int aux = 0;
			int esq = inicio;
			int dir = finaldovetor;
			int p = vetor[(esq+dir)/2];
			
			
			while (esq<=dir){
				
				while(vetor[esq]< p){
					esq++;
				}
				
				while(vetor[dir] > p){
					dir--;
				}
				
				if(esq <= dir){
					aux= vetor[esq];
					vetor[esq] = vetor[dir];
					vetor[dir] = aux;
					esq++;
					dir--;					
				}
			}
			
			if(inicio < dir){
				QuicksortA(vetor,inicio,dir);
			}
			if(esq < finaldovetor){
				QuicksortA(vetor,esq,finaldovetor);
			}
		}
		
	}
}