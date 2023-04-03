using System;
using System.Linq;
using HtmlAgilityPack;

namespace UnidasTestProject.ElementInspector
{
    class Program
    {
        static void Main(string[] args)
        {
            // carrega a página HTML
            var url = "https://unidas--qa.sandbox.lightning.force.com/lightning/r/Account/001HY000005D6rYYAS/view";
            var web = new HtmlWeb();
            var doc = web.Load(url);

            // seleciona todos os elementos
            var elements = doc.DocumentNode.Descendants();

            // exibe as informações de cada elemento
            foreach (var element in elements)
            {
                Console.WriteLine($"Tag: {element.Name}");
                Console.WriteLine($"ID: {element.Id}");
                Console.WriteLine($"Classes: {string.Join(", ", element.Attributes["class"]?.Value.Split(' ') ?? Enumerable.Empty<string>())}");
                Console.WriteLine($"Atributos: {string.Join(", ", element.Attributes.Where(a => a.Name != "class").Select(a => $"{a.Name}={a.Value}"))}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
