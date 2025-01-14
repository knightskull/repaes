﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Record
{
    public int IdRecord { get; set; }
    public string Plate { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Nullable<System.DateTime> GateIn { get; set; }
    public Nullable<System.DateTime> GateOut { get; set; }
    public Nullable<int> IdUser { get; set; }

    public virtual User User { get; set; }
}

public partial class User
{
    public User()
    {
        this.Records = new HashSet<Record>();
    }

    public int IdUser { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public Nullable<int> NumberGroup { get; set; }

    public virtual ICollection<Record> Records { get; set; }
}
