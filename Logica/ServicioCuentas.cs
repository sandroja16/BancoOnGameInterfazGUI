using Entidad;
using System.Collections.Generic;
namespace Logica
{
    public class ServicioCuentas
    {
        Datos.RepositorioCuenta repositorio = new Datos.RepositorioCuenta();
        List<Cuenta> ListaCuentas;
        public ServicioCuentas()
        {
            ListaCuentas = repositorio.Consultar();
        }
        void Actualizar()
        {
            ListaCuentas = repositorio.Consultar();
        }
        public string Guardar(Cuenta cuenta)
        {
            //validar
            return repositorio.Guardar(cuenta);

        }
        public string Modifar(List<Cuenta> cuentas)
        {
            //validar
            return repositorio.Modificar(cuentas);

        }
        public Cuenta BuscarCuenta(double numcuenta)
        {
            Actualizar();
            foreach (var item in ListaCuentas)
            {
                if (item.NumeroCuenta == numcuenta)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Cuenta> Consultar()
        {
            //Actualizar();
            return ListaCuentas;
        }
    }
}
