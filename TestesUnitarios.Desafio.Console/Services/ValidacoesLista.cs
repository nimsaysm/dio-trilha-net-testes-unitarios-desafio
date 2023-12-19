namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            return listaSemNegativos.ToList(); //retorna uma lista sem os números negativos
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            var contem = lista.Contains(numero);
            return contem; //retorna booleano se contém o número
        }

        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            return listaMultiplicada; //retorna a lista mutiplicada pelo número
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max(); //retorna o número maior da lista
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min(); //retorna o número menor da lista
        }
    }
}
