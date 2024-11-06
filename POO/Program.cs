using POO;

Empresa empresa1 = new Empresa();

Cliente cliente = new Cliente(1, "Juan Pérez");
empresa1.RegistrarCliente(cliente);
Cliente cliente1 = new Cliente(2, "Cristina Santos");
empresa1.RegistrarCliente(cliente1);

var auto = new Auto("Toyota", "Gasolina", "150 HP", "Carburador", "ABC", 2500, true, 4);
empresa1.RegistrarVehiculo(auto);
var camioneta = new Camioneta("Ford", "Eléctrico", "250 HP", "Inyección directa", "ABC", 5000, true, 4);
empresa1.RegistrarVehiculo(camioneta);

empresa1.RegistrarAlquiler(1, "Toyota");
empresa1.RegistrarAlquiler(2, "Toyota");
empresa1.RegistrarAlquiler(2, "Ford");

empresa1.ImprimirAlquileres();
empresa1.ImprimirVehiculos();