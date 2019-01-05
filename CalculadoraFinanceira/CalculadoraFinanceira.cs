using System;

namespace OperacaoFinanceira 
{
	public static class CalculadoraFinanceira
	{
		/// <summary>
		/// Método que calcula juros composto
		/// @author Alexander
		/// </summary>
		/// <param name="capital"></param>
		/// <param name="periodo"></param>
		/// <param name="taxa"></param>
		/// <returns>Retorna um valor do tipo double</returns>
		public static double CalcularJurosComposto(
			double capital, int periodo, double taxa)
		{
			return Math.Round(capital * Math.Pow((1 + taxa / 100), periodo), 2); ;
		}
    }
}
