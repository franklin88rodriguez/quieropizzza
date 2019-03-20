using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaAcademica.BL
{
    public class HorariosBL
    {
        Contexto _Contexto;
        public List<Horarios> HorarioBL { get; set; }

        public HorariosBL()
        {
            _Contexto = new Contexto();
            HorarioBL = new List<Horarios>();
        }

        public List<Horarios> ObtenerHorarios()
        {
            HorarioBL = _Contexto.Horario.ToList();//para traer la tabla horario

            return HorarioBL;
        }

        public void EliminarHorario(int id)//eliminando un horario
        {
            var horario = _Contexto.Horario.Find(id);

            _Contexto.Horario.Remove(horario);
            _Contexto.SaveChanges();
        }


        public void GuardarHorario(Horarios hora)
        {
            if (hora.Id == 0)
            {
                _Contexto.Horario.Add(hora);
            }
            else
            {
                var horaExistente = _Contexto.Horario.Find(hora.Id);

                horaExistente.Id = hora.Id;
                horaExistente.Activo = hora.Activo;
                horaExistente.Horario = hora.Horario;
                //periodoExistente.año = censo.;

            }

            _Contexto.SaveChanges();
        }


        public Horarios ObtenerHorarios (int id)
        {
            var hora = _Contexto.Horario.Find(id);

            return hora;
        }




    }
}
