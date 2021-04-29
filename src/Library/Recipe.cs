//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

/* Se implementa el metodo GetProductionCost(). Lo implementamos en la clase Recipe porque es la clase experta para calcular el precio total de la receta, ya que esta clase contiene cada paso con su respectivo costo.
A la vez no viola con el principio de SRP, ya que no habría más de una razón por la cual modificar el codigo.
*/

        public double GetProductionCost()
        {
            double cost = 0;
            foreach (Step step in this.steps)
            {
                cost = cost + step.GetStepCost();
            }
            return cost;

        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}