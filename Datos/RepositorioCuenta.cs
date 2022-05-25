using System;
using System.Collections.Generic;
using System.IO;
namespace Datos
{
    public class RepositorioCuenta
    {
        string ruta = "Cuentas.txt";// ruta donde se guarda el archivo
        public string Guardar(Entidad.Cuenta cuenta)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta, true);

                // 2. operaciones
                escritor.WriteLine(cuenta.ToString());

                //3.  guardar
                escritor.Close();

                return "Se guardaron los datos";
            }
            catch (Exception)
            {
                return "NO Se guardaron los datos";
            }

        }


        public string Modificar(List<Entidad.Cuenta> cuentas)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta, false);// sobreescribe
                foreach (var item in cuentas)
                {
                    escritor.WriteLine(item.ToString());
                    //close
                }

                escritor.Close();

                return "Se modificaron los datos los datos";

              
            }
            catch (Exception)
            {

                return "NO Se guardaron los datos";
            }

        }
       
        public List<Entidad.Cuenta> Consultar()
        {
            try
            {
                StreamReader lector = new StreamReader(ruta);
                List<Entidad.Cuenta> cuentas = new List<Entidad.Cuenta>();
                // 2. operaciones
                string linea = string.Empty;
                while (!lector.EndOfStream)
                {
                    linea = lector.ReadLine();

                    double numCuenta = double.Parse(linea.Split(';')[0]);
                    Entidad.Cliente cliente = new RepositorioClientes().Buscar(linea.Split(';')[1]);
                    double saldo = double.Parse(linea.Split(';')[2]);

                    Entidad.Cuenta cuenta = new Entidad.Cuenta(numCuenta, cliente, saldo);
                    cuentas.Add(cuenta);

                }

                //3.  guardar
                lector.Close();

                return cuentas;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
