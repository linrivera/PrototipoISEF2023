using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Data.Odbc;

namespace CapsDatos
{
    public class Sentencias
    {
        Conexion conectar = new Conexion();
        public List<string> getDatosComboBox(string tabla)
        {
            List<string> results = new List<string>();

            string sql = "SELECT * FROM " + tabla + ";";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    results.Add(reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener los datos de la tabla " + tabla); }

            return results;
        }
        public List<string> getExamenes()
        {
            List<string> results = new List<string>();

            string sql = "SELECT * FROM tbl_examen;";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    results.Add(reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString() + "-" + reader.GetValue(2).ToString() + "-" + reader.GetValue(3).ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener los datos de la tabla "); }

            return results;
        }
        public int getNewId(string campo, string tabla)
        {
            string sql = "SELECT COALESCE(MAX(" + campo + "), 0) FROM " + tabla + ";";
            int id = 0;
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = int.Parse(reader.GetValue(0).ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener el id de la tabla de " + tabla); }
            return id;
        }

        public void insert(string tabla, string values)
        {
            string encabezado = "INSERT INTO "+ tabla + " VALUES (" + values + ");";

            Console.WriteLine(encabezado);
            try
            {
                OdbcCommand command = new OdbcCommand(encabezado, conectar.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

