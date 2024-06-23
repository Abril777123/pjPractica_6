using pjPractica_6;

//Vehiculo miCoche = new Coche();
//miCoche.RealizarMantenimiento(); // Output: Realizando mantenimiento del coche: Cambio de aceite y revisión de frenos.
//Console.WriteLine("Costo del mantenimiento del coche: $" + miCoche.ObtenerCostoMantenimiento());

//Vehiculo miMoto = new Moto();
//miMoto.RealizarMantenimiento(); // Output: Realizando mantenimiento de la moto: Lubricación de cadena y revisión de neumáticos.
//Console.WriteLine("Costo del mantenimiento de la moto: $" + miMoto.ObtenerCostoMantenimiento());

//miCoche.Lavar(); // Output: Lavando el vehículo.

//Coche miCocheReal = new Coche();
//miCocheReal.Lavar(); // Output: Lavando el coche con cera y shampoo especial.

//Servicio servicioAceite = new CambioAceite();
//servicioAceite.RealizarServicio(); // Output: Realizando cambio de aceite.
//Console.WriteLine("Costo del cambio de aceite: $" + servicioAceite.CalcularCosto());

//Servicio servicioFrenos = new ReparacionFrenos();
//servicioFrenos.RealizarServicio(); // Output: Realizando reparación de frenos.
//Console.WriteLine("Costo de la reparación de frenos: $" + servicioFrenos.CalcularCosto());

Vehiculo miCoche = new Coche();
miCoche.RealizarMantenimiento(); // Output: Realizando mantenimiento del coche: Cambio de aceite y revisión de frenos.
Console.WriteLine("Costo del mantenimiento del coche: $" + miCoche.ObtenerCostoMantenimiento());

Vehiculo miMoto = new Moto();
miMoto.RealizarMantenimiento(); // Output: Realizando mantenimiento de la moto: Lubricación de cadena y revisión de neumáticos.
Console.WriteLine("Costo del mantenimiento de la moto: $" + miMoto.ObtenerCostoMantenimiento());


// Uso de los servicios
Servicio servicioAceite = new CambioAceite();
servicioAceite.RealizarServicio();
Console.WriteLine("Costo del cambio de aceite: $" + servicioAceite.CalcularCosto());
Console.WriteLine("Tiempo del cambio de aceite: " + servicioAceite.CalcularTiempoServicio() + " horas");

Servicio servicioFrenos = new ReparacionFrenos();
servicioFrenos.RealizarServicio();
Console.WriteLine("Costo de la reparación de frenos: $" + servicioFrenos.CalcularCosto());
Console.WriteLine("Tiempo de la reparación de frenos: " + servicioFrenos.CalcularTiempoServicio() + " horas");

