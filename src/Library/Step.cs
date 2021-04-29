//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }

/*Se implementa el metodo GetStepCost(). Lo implementamos en la clase Step porque es la clase experta en toda la información que necesitamos(Tiempo y precio de el equipamiento y producto).
A la vez no viola con el principio de SRP, ya que no habría más de una razón por la cual modificar el codigo.
*/
        public double GetStepCost()
        {
            double InputCost = Input.UnitCost * Quantity;
            double EquipmentCost = Equipment.HourlyCost * Time;
            return InputCost + EquipmentCost;
        }


    }
}