using Ejercicio2.Entities;
//polimorfismo y caste (atributos)
Entity ve = new VehiculoElectrico(id: "1", placa: "hga223", horasCarga: 50.1);
var ve1 = (VehiculoElectrico)ve;
Console.WriteLine(ve1.HorasCarga);

//polimorfismo y caste (metodo)

Entity vg = new VehiculoGasolina(id: "1", placa: "hga256");
var vg1 = (VehiculoGasolina)vg;
vg1.ImprimirValores();


