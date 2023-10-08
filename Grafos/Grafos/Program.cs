using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Nodo> Nodos = new List<Nodo>();
            List<Conexion> Conexiones = new List<Conexion>();
            InicializarGrafo(Nodos, Conexiones);
            bool flag = true;
            int option = 0;
            while (flag == true)
            {
                Console.WriteLine("Ingrese la opcion que desea realizar \n1. Crear Nodo \n2. Mostrar Nodos \n3. Crear conexion entre nodos \n4. Mostrar Matriz de adyacencia \n5. Mostrar lista de adyacencia\n6. Evaluación de grafos aciclicos.\n7. Camino mas corto.  \n8. Salir");
                option = ObtenerNumeroValido();
                switch (option)
                {
                    case 1:
                        CreateNode(Nodos);
                        break;
                    case 2:
                        Console.WriteLine("\nNodos existentes:\n");
                        ShowNodes(Nodos);
                        break;
                    case 3:
                        if (Nodos.Count > 1)
                        {
                            AddConex(Nodos, Conexiones);
                        }
                        else
                        {
                            Console.WriteLine("No hay suficientes nodos para crear una conexion");
                        }
                        break;
                    case 4:
                        if (Nodos.Count > 1)
                        {
                            int[,] Matix = MatrixA(Nodos, Conexiones);
                            ShowMatrix(Matix);
                        }
                        else
                        {
                            Console.WriteLine("No hay suficientes nodos para crear una matriz de adyacencia");
                        }
                        break;
                    case 5:
                        if (Nodos.Count > 1)
                        {
                            ShowAdjList(Nodos, Conexiones);
                        }
                        else
                        {
                            Console.WriteLine("No hay suficientes nodos para crear una matriz de adyacencia");
                        }
                        break;
                    case 6:
                        IsAciclic(Nodos, Conexiones);
                        break;
                    case 7:
                        List<Nodo> visitedNodes = new List<Nodo>();
                        Console.WriteLine("Ingresa un nodo");
                        string nodo1 = Console.ReadLine();
                        Console.WriteLine("Ingresa otro nodo");
                        string nodo2 = Console.ReadLine();
                        int peso = ComplexConex(nodo1, nodo2, Conexiones, visitedNodes);
                        if (peso == 0)
                        {
                            Console.WriteLine("No hay conexion entre los nodos");
                        }
                        else
                        {
                            Console.WriteLine("El camino de menor peso es de: " + peso);
                        }

                        break;
                    case 8:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                Console.WriteLine("\nPresione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void InicializarGrafo(List<Nodo> list, List<Conexion> conex)
        {
            Nodo Tlaxcala = new Nodo("Tlaxcala");
            Nodo Puebla = new Nodo("Puebla");
            Nodo Veracruz = new Nodo("Veracruz");
            Nodo Tabasco = new Nodo("Tabasco");
            Nodo Chiapas = new Nodo("Chiapas");
            Nodo Oaxaca = new Nodo("Oaxaca");
            Nodo Guerrero = new Nodo("Guerrero");
            Nodo DF = new Nodo("DF");
            list.Add(Tlaxcala);
            list.Add(Puebla);
            list.Add(Veracruz);
            list.Add(Tabasco);
            list.Add(Chiapas);
            list.Add(Oaxaca);
            list.Add(Guerrero);
            list.Add(DF);
            AgregarConexionDirecta(list, conex, "Tlaxcala", "Puebla", 37);
            AgregarConexionDirecta(list, conex, "Puebla", "Tlaxcala", 37);
            AgregarConexionDirecta(list, conex, "Puebla", "DF", 129);
            AgregarConexionDirecta(list, conex, "DF", "Puebla", 129);
            AgregarConexionDirecta(list, conex, "Puebla", "Guerrero", 315);
            AgregarConexionDirecta(list, conex, "Guerrero", "Puebla", 315);
            AgregarConexionDirecta(list, conex, "DF", "Guerrero", 276);
            AgregarConexionDirecta(list, conex, "Guerrero", "DF", 276);
            AgregarConexionDirecta(list, conex, "Oaxaca", "Puebla", 348);
            AgregarConexionDirecta(list, conex, "Puebla", "Oaxaca", 348);
            AgregarConexionDirecta(list, conex, "Oaxaca", "Guerrero", 663);
            AgregarConexionDirecta(list, conex, "Guerrero", "Oaxaca", 663);
            AgregarConexionDirecta(list, conex, "Veracruz", "Oaxaca", 466);
            AgregarConexionDirecta(list, conex, "Oaxaca", "Veracruz", 466);
            AgregarConexionDirecta(list, conex, "Veracruz", "Puebla", 285);
            AgregarConexionDirecta(list, conex, "Puebla", "Veracruz", 285);
            AgregarConexionDirecta(list, conex, "Oaxaca", "Chiapas", 557);
            AgregarConexionDirecta(list, conex, "Chiapas", "Oaxaca", 557);
            AgregarConexionDirecta(list, conex, "Tabasco", "Chiapas", 251);
            AgregarConexionDirecta(list, conex, "Chiapas", "Tabasco", 251);
            AgregarConexionDirecta(list, conex, "Oaxaca", "Tabasco", 810);
            AgregarConexionDirecta(list, conex, "Tabasco", "Oaxaca", 810);
            AgregarConexionDirecta(list, conex, "Tabasco", "Veracruz", 466);
            AgregarConexionDirecta(list, conex, "Veracruz", "Tabasco", 466);
        }

        static void CreateNode(List<Nodo> list)
        {
            Console.WriteLine("Ingresa el valor del nodo");
            string dato = ObtenerLetraValida();
            Nodo node = new Nodo(dato);
            list.Add(node);
        }
        static void AddConex(List<Nodo> list, List<Conexion> Conexiones)
        {
            bool validate = false;
            Console.WriteLine("Ingrese el dato del nodo al que se le agregara la conexion");
            string search = ObtenerLetraValida();
            Console.WriteLine("Ingrese el dato del nodo que se conectara");
            string search2 = ObtenerLetraValida();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].dato == search)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j].dato == search2)
                        {
                            validate = true;
                            Console.WriteLine("Ingresa el peso de la conexion");
                            int peso = ObtenerNumeroValido();
                            while (peso <= 0)
                            {
                                Console.WriteLine("0 no es un peso valido, por favor ingrese un nuevo valor");
                                peso = ObtenerNumeroValido();
                            }
                            Conexion NewConex = new Conexion(list[i], list[j], peso);
                            Conexiones.Add(NewConex);
                        }
                    }
                }
            }
            if (validate == false)
            {
                Console.WriteLine("No se realizo ninguna conexion, verifique si los nodos ingresados existen");
            }
        }
        static void AgregarConexionDirecta(List<Nodo> list, List<Conexion> Conexiones, string search, string search2, int peso)
        {
            bool validate = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].dato == search)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j].dato == search2)
                        {
                            validate = true;
                            Conexion NewConex = new Conexion(list[i], list[j], peso);
                            Conexiones.Add(NewConex);
                        }
                    }
                }
            }
            if (validate == false)
            {
                Console.WriteLine("No se realizo ninguna conexion, verifique si los nodos ingresados existen");
            }
        }
        static int[,] MatrixA(List<Nodo> nodos, List<Conexion> conex)
        {
            int length = nodos.Count;
            int[,] matrix = new int[length, length];
            for (int i = 0; i < nodos.Count; i++)
            {
                for (int k = 0; k < nodos.Count; k++)
                {
                    int peso = GetPoint(nodos[i], nodos[k], conex);
                    matrix[i, k] = peso;
                }
            }
            return matrix;
        }
        static int GetPoint(Nodo NodoIni, Nodo NodeBase, List<Conexion> conex)
        {
            for (int i = 0; i < conex.Count; i++)
            {
                if (conex[i].NodeF == NodeBase && conex[i].NodeI == NodoIni) return conex[i].peso;
            }
            return 0;
        }
        static void ShowMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("[" + matrix[i, j] + "]");
                }
                Console.WriteLine("");
            }
        }
        static string ObtenerLetraValida()
        {
            string n = " ";
            try
            {
                n = Console.ReadLine();
                return n;
            }
            catch
            {
                Console.WriteLine("El valor ingresado no es caracter valido");
                n = ObtenerLetraValida();
                return n;
            }
        }

        static int ObtenerNumeroValido()
        {
            int n = 0;
            try
            {
                n = int.Parse(Console.ReadLine());
                return n;
            }
            catch
            {
                Console.WriteLine("El valor ingresado no es un caracter valido");
                return n;
            }
        }
        static void ShowNodes(List<Nodo> Nodos)
        {
            for (int i = 0; i < Nodos.Count; i++)
            {
                Console.WriteLine(Nodos[i].dato);
            }
        }
        static void ShowAdjList(List<Nodo> nodes, List<Conexion> conex)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                Console.Write(nodes[i].dato);
                for (int j = 0; j < conex.Count; j++)
                {
                    if (conex[j].NodeI == nodes[i])
                    {
                        Console.Write(" -> " + conex[j].NodeF.dato);
                    }
                }
                Console.WriteLine("");
            }
        }
        static void IsAciclic(List<Nodo> Nodos, List<Conexion> Conex)
        {
            int[,] Matriz = MatrixA(Nodos, Conex);
            int bandera1 = 0;
            bool aciclico = false;
            ShowMatrix(Matriz);
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    if (Matriz[i, j] == 0)
                    {
                        bandera1++;
                    }
                    if (bandera1 == Matriz.GetLength(1))
                    {
                        aciclico = true;
                    }
                }
                bandera1 = 0;
            }
            if (aciclico == true)
            {
                Console.WriteLine("\nEl grafo es aciclico");
            }
            else
            {
                Console.WriteLine("\nEl grafo es ciclico");
            }
        }
        static int SimpleConex(string NodeBase, string NodeToFind, List<Conexion> Conex)
        {
            for (int i = 0; i < Conex.Count; i++)
            {
                if (Conex[i].NodeI.dato == NodeBase && Conex[i].NodeF.dato == NodeToFind)
                {
                    return Conex[i].peso;
                }
            }
            return 0;
        }

        static int ComplexConex(string NodeBase, string NodeToFind, List<Conexion> Conex, List<Nodo> VisitedNodes)
        {
            bool Flag = true;
            List<int> ways = new List<int>();
            //Encontra el camino simple 
            int simple = SimpleConex(NodeBase, NodeToFind, Conex);
            if (simple != 0)
            {
                ways.Add(simple);
            }
            //Encontra el camino simple de los nodos adyacentes
            for (int i = 0; i < Conex.Count; i++)
            {
                if (Conex[i].NodeF.dato == NodeToFind)
                {
                    if (Conex[i].NodeI.dato != NodeBase)
                    {
                        for (int j = 0; j < VisitedNodes.Count; j++)
                        {
                            if (VisitedNodes[j] == Conex[i].NodeI)
                            {
                                Flag = false;
                            }
                        }
                        VisitedNodes.Add(Conex[i].NodeI);
                        if (Flag == true)
                        {
                            int ComplexConex_ = ComplexConex(Conex[i].NodeI.dato, Conex[i].NodeF.dato, Conex, VisitedNodes);
                            ComplexConex_ += Conex[i].peso;
                            ways.Add(ComplexConex_);
                        }
                    }
                }
            }
            //Encontrar el menor sumar
            int peso = 0;
            for (int i = 0; i < ways.Count; i++)
            {
                peso += ways[i];

            }
            // Encontrar menu
            for (int i = 0; i < ways.Count; i++)
            {
                if (ways[i] < peso)
                {
                    peso = ways[i];
                }
            }
            return peso;
        }
    }
    public class Nodo
    {
        public string dato;
        public Nodo(string dato)
        {
            this.dato = dato;
        }
    }
    public class Conexion
    {
        public int peso;
        public Nodo NodeI;
        public Nodo NodeF;
        public Conexion(Nodo NodeI, Nodo NodeF, int peso)
        {
            this.NodeI = NodeI;
            this.NodeF = NodeF;
            this.peso = peso;
        }
    }
}