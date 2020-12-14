namespace Classes_metodos_e_atributos_estaticos.classes
{
    public class Conversor
    {
        private static float CotacaoDolar = 5.24f;
        private static float CotacaoEuro = 6.11f;
        
        public static float RealParaDolar(float valorRS){
            return valorRS / CotacaoDolar;
        }

        public static float DolarParaReais(float valorUS){
            return CotacaoDolar * valorUS;
        }

        public static float RealParaEuro(float valorRS2){
            return valorRS2 / CotacaoEuro;
        }

        public static float EuroParaReal(float valorEU){
            return CotacaoEuro * valorEU;
        }
    }
}