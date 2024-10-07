
namespace Hastalabrisca.Code.GameScenes.Currelo
{
    public partial class CurreloCard:Carta
    {
        BarajaEspanola CartaDeLaBaraja;
        public CurreloCard(BarajaEspanola CartaDeLaBaraja)
        {
            this.CartaDeLaBaraja = CartaDeLaBaraja;
        }

        public void CalcularValor(BarajaEspanola triunfo)
        {
            int cardValue = (int)CartaDeLaBaraja%10;
            if(IsMismoPalo(triunfo))
            {
                SetScore(100+cardValue);
            }
            else
            {
                SetScore(cardValue);
            }
        }

        public bool IsMismoPalo(BarajaEspanola carta)
        {
            //crear un metodo que, segun el valor numerico en el enum BarajaEspanola, dividido entre 10
            int paloAjeno=((int)carta-1) / 10;
            int paloPropio = (((int)CartaDeLaBaraja) - 1) / 10;
            return paloAjeno == paloPropio;
        }
    }
}
