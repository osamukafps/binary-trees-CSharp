// See https://aka.ms/new-console-template for more information
using binarysearchtrees;

Console.WriteLine("Árvore Binária de Busca em C#");
Console.WriteLine("---------- Inserção e Percurso em Ordem ---------");
BinarySearchTree ExampleTree()
{
    int[] values = new int[] { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };
    var tree = new BinarySearchTree();
    foreach (var value in values)
    {
        tree.Insert(value);
    }

    return tree;
}

var bst = ExampleTree();
bst.InorderTraversal();

Console.WriteLine("\n \n ---------- Busca ---------");
int value = 16;
Console.WriteLine($"Buscando {value}");
var searchResult = bst.Search(value);
Console.WriteLine($"{searchResult.Root.Data} encontrado...");

Console.WriteLine("\n \n ---------- Percurso em Nível ---------");
bst.LevelOrderTraversal();

Console.WriteLine("\n \n ---------- Busca Máximo e Mínimo ---------");
Console.WriteLine("Máximo: " + bst.Max());
Console.WriteLine("Mínimo: " + bst.Min());

Console.WriteLine("\n \n ---------- Remoção ---------");
Console.WriteLine("------- Antes ------");
bst.InorderTraversal();
Console.WriteLine("\n------- Depois ------");
int valueToRemove = 16;
bst.Remove(value);
bst.InorderTraversal();

