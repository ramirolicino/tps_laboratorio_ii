using System;

namespace Entidades
{
    public class Operando
    {
        //ATRIBUTO
        private double numero;

        //CONSTRUCTORES
        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
            : this()
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
            : this()
        {
            this.Numero = strNumero;
        }


        //PROPIEDAD
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }


        /// <summary>
        /// Comprobará que el valor recibido sea numérico, y lo retornará en formato double. Caso contrario, retornará 0.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Retorna el numero en formato double</returns>
        private double ValidarOperando(string strNumero)
        {
            if (double.TryParse(strNumero, out double numero))
            {
                return numero;
            }
            else
            {
                return 0;
            }
        }


        /// <summary>
        /// Determina si es bianrio o no 
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Retorna true si es binario o false en caso contrario</returns>
        private bool EsBinario(string binario)
        {
            foreach (char item in binario)
            {
                if (item != '1' && item != '0')
                {
                    return false;
                }
            }

            return true;
        }


        /// <summary>
        /// Convertirán un número binario a decimal, en caso de ser posible. Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Retorna el numero binario en decimal</returns>
        public string BinarioDecimal(string binario)
        {
            double numeroDecimal = 0;
            int cantCaracteres = binario.Length;

            if (EsBinario(binario))
            {

                foreach (char caracter in binario)
                {
                    cantCaracteres--;
                    if (caracter == '1')
                    {
                        numeroDecimal += (int)Math.Pow(2, cantCaracteres);
                    }
                }

                return numeroDecimal.ToString();
            }
            else
            {
                return "Valor inválido";
            }
        }


        /// <summary>
        /// Convertirán un número decimal a binario, en caso de ser posible. Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna el numero decimal en bianrio</returns>
        public string DecimalBinario(double numero)
        {
            string ValorBin = string.Empty;
            int resultDiv = (int)numero;
            int restoDiv;

            if (resultDiv >= 0)
            {
                do
                {
                    restoDiv = resultDiv % 2;
                    resultDiv /= 2;
                    ValorBin = restoDiv.ToString() + ValorBin;

                } while (resultDiv > 0);
            }

            return ValorBin;
        }


        /// <summary>
        /// Convertirán un número decimal a binario, en caso de ser posible. Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna el numero decimal en bianrio</returns>
        public string DecimalBinario(string numero)
        {
            if (double.TryParse(numero, out double num))
            {
                return DecimalBinario(num);
            }
            else
            {
                return "Valor inválido";
            }
        }


        //SOBRECARGA
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }
    }
}
