using NUnit.Framework;
using OperacaoFinanceira;

namespace NUnit.Testes
{

	/// <summary>
	/// Classe de teste criada para garantir o funcionamento
	///	das principais operações realizadas.
	///	@author Alexander	
	/// </summary>
	[TestFixture]
	public class TesteCalculadoraFinanceira
	{
		[TestCase(10000, 12, 2, 12682.42)]
		[TestCase(15000, 36, 6, 122208.78)]
		[TestCase(12000, 48, 3, 49587.02)]
		public void TesteCalcularJurosComposto(
			double capital, int periodo, double taxa, double valorEsperado)
		{
			/* ======================== Execução ===================== */
			var montante = CalculadoraFinanceira.CalcularJurosComposto(
				capital, periodo, taxa);

			/* ====================== Verificação ==================== */
			Assert.AreEqual(valorEsperado, montante);
		}
	}
}
