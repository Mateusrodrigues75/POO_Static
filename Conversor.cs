using System;

namespace POO_Static
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5.05f;
        private static float cotacaoEuro = 6.15f;

        public static float RealParaDolar(float valorRS){
            Console.WriteLine($"R${valorRS} em dólar é US$: ");
            return valorRS/cotacaoDolar;
        }
        public static float DolarParaReal(float valorUS){
            Console.WriteLine($"US${valorUS} em reais é R$: ");
            return cotacaoDolar * valorUS;
        }
        
        
        
        public static float RealParaEuro(float valorRS){
            Console.WriteLine($"R${valorRS} em euro é €: ");
            return valorRS/cotacaoEuro;
        }

        public static float EuroParaReal(float valorEU){
            Console.WriteLine($"€{valorEU} em reais é R$: ");
            return cotacaoEuro * valorEU;
        }
    }
}