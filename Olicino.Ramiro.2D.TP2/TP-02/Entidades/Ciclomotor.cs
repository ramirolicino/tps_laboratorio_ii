﻿using System;
using System.Text;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }


        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        public override ETamanio Tamanio { get => ETamanio.Chico; }


        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
