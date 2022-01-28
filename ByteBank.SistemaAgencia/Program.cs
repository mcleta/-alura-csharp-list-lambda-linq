using System;
using System.Collections.Generic;
using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Extensions;
using ByteBank.SistemaAgencia.Comparables;
using System.Linq;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>
            {
                new ContaCorrente(123, 45),
                new ContaCorrente(23, 468),
                null,
                new ContaCorrente(12, 458),
                new ContaCorrente(122, 4979),
                null,
                null,
                new ContaCorrente(128, 48),
                new ContaCorrente(173, 789),
            };

            //contas.Sort(); ~~> Chama a implementação dada em IComparableC

            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            var contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            foreach (var cont in contasOrdenadas)
            {
                Console.WriteLine(cont.Agencia + "  " + cont.Numero);
            }

            Console.ReadLine();
        }

        static void TestaSoet()
        {
            var lista = new List<int>();
            //ListExtensoes.AddVarios(lista, 0, 2, 3, 3, 4, 5, 6, 7, 8, 9);

            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);

            lista.AddVarios(09, 28, 93, 33, 84, 45, 624, 457, 386383, 09);
            lista.Remove(1);

            lista.Sort();

            var lista2 = new List<string>()
            {
                "a",
                "g",
                "r",
                "u",
                "p",
                "y"
            };
            lista2.Sort();


            for (var i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            for (var i = 0; i < lista2.Count; i++)
            {
                Console.WriteLine(lista2[i]);
            }
        }


        static void TestaListaDEObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(12);
            listaDeIdades.Adicionar(11);
            listaDeIdades.Adicionar(19);
            listaDeIdades.AdicionarVarios(18, 12, 32);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }


        static void TestaListaDeContaCorrente()
        {
            //ListaContaCorrente lista = new ListaContaCorrente();
            ListaContaCorrente lista = new ListaContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(11111, 1111111);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754)
            };

            lista.AdicionarVarios(contas);

            lista.AdicionarVarios(
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787)
            );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }



        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4456668),
                    new ContaCorrente(874, 7781438)
                };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        static void TestaArrayInt()
        {
            // ARRAY de inteiros, com 5 posições!
            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }

    }
}