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
            //deneme 2 deneme deneme


        }
    }
    
  
}
