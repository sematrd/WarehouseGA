using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticSharp.Domain;
using GeneticSharp.Domain.Crossovers;
using GeneticSharp.Domain.Mutations;
using GeneticSharp.Domain.Populations;
using GeneticSharp.Domain.Selections;
using GeneticSharp.Domain.Terminations;

namespace WarehouseGA
{
    class Program
    {
        static void Main(string[] args)
        {
            var selection = new EliteSelection();
            var crossover=new OnePointCrossover(); //başlangıç olarak atanmıştır, değiştirilebilir.
            var mutation = new UniformMutation(); //başlangıç olarak atanmıştır, değiştirilebilir.
            var fitness = new GaFitness();
            var chromosome = new GaChromosome();
            var population=new Population(134,139,chromosome);
            
            var ga=new GeneticAlgorithm(population,fitness,selection,crossover,mutation);
            ga.Termination=new GenerationNumberTermination(); //algoritmanın kaçıngı generation da durdurulacağını belirler.

             Console.WriteLine("GA running...");
            ga.Start();
            Console.WriteLine("GA done in {0} generations.", ga.GenerationsNumber);

            var bestChromosome = ga.BestChromosome as GaChromosome;
            Console.WriteLine("Best solution found is X:{0}, Y:{1} with {2} fitness.", bestChromosome.X, bestChromosome.Y, bestChromosome.Fitness);
		    Console.ReadKey(); //
            
        }
    }
    
  
}
