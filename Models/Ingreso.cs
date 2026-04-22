using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace RCA.BitacoraCamiones.Models
{

    public class Ingreso
    {
        [PrimaryKey, AutoIncrement]
        public int ING_Id { get; set; }

        public string ING_Placa { get; set; } = string.Empty;
        public string ING_Conductor { get; set; } = string.Empty;

        public DateTime ING_Fecha { get; set; }

        public string ING_SyncStatus { get; set; } = "Pending";
    }
}
