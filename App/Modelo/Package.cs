using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public abstract class Package
    {
        string codigo;
        string nombre;
        string direccion;
        string ciudad;
        string departamento;
        string codPosRemitente;
        string codPosDestinatario;
        double peso;
        double precio;

        public Package(string codigo, string nombre, string direccion, string ciudad, string departamento, string codPosRemitente, string codPosDestinatario, double peso, double precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.departamento = departamento;
            this.codPosRemitente = codPosRemitente;
            this.codPosDestinatario = codPosDestinatario;
            this.peso = peso;
            this.precio = precio;
        }


        public Package()
        {
            codigo ="";   
            nombre = "";
            direccion ="";
            ciudad = "";
            departamento = "";
            codPosRemitente = "";
            codPosDestinatario ="";
            peso = 0.0;
            precio = 0.0;
        
        }

        public string CodPosDestinatario
        {
            get { return codPosDestinatario; }
            set { codPosDestinatario = value; }
        }
        public string CodPosRemitente
        {
            get { return codPosRemitente; }
            set { codPosRemitente = value; }
        }
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }



        public override string ToString()
        {
            string res;
            res = "codigo" + codigo + '\n' + "nombre" + nombre + '\n' + "direccion" + direccion + '\n' + "ciudad" + ciudad + '\n' + "departamento" + departamento + '\n' + "codPosRemitente" + codPosRemitente + '\n' + "codPosDestinatario" + codPosDestinatario + '\n' + "peso" + peso + '\n' + "precio" + precio + '\n';
            return res;
        }
        public override bool Equals(object obj)
        {
            Package pa = (Package)obj;
            bool va=false;

            if (pa.codigo==codigo && pa.nombre==nombre && pa.direccion==direccion && pa.ciudad==ciudad && pa.departamento==departamento 
            && pa.codPosRemitente==codPosRemitente && pa.codPosDestinatario==codPosDestinatario && pa.peso==peso. && pa.precio=precio)
            {
                va=true;
            }
            return va;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public abstract double Calculatecost();














    }
}