using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RCA.BitacoraCamiones.Models
{

    public class Foto
    {
        [PrimaryKey, AutoIncrement]
        public int FOT_Id { get; set; }

        public int ING_Id { get; set; }

        public string FOT_RutaLocal { get; set; } = string.Empty;
        public string FOT_UrlNube { get; set; } = string.Empty;

        public string FOT_SyncStatus { get; set; } = "Pending";
    }
}
