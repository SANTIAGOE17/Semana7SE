using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Semana7SE
{
    public interface Database
    {
        //variable de conexion
        SQLiteAsyncConnection GetConnection();
    }
}
