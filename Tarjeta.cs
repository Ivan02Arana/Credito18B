using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CreditoWeb.Models
{
    public class Tarjeta
    {
        [Required(ErrorMessage = "El número de tarjeta es necesario.")]
        [CreditCard]
        public string TarjetaNum { get; set; }
        public TipoTarjeta TipoTarjeta { get; set; }

        public bool Valida { get; set; }

        public Tarjeta(string tarjetaNum)
        {
            this.TarjetaNum = tarjetaNum;
            Valida = esValida();
            TipoTarjeta = tipoDeTarjeta();
        }


        /// Basado en el algoritmo de Luhn determinar si esta tarjeta es valida
        /// como estamos dentro de la clase de tarjeta tenemos acceso a la propiedad TarjetaNum 
        private bool esValida()
        {
            return false;

        }


        /// Si la tarjeta es valida determinar de cuál tipo es VISA, MASTERCARD, AMERICANEXPRESS
        /// como estamos dentro de la clase de tarjeta tenemos acceso a la propiedad TarjetaNum 
        private TipoTarjeta tipoDeTarjeta()
        {
            
            return TipoTarjeta.NOVALIDA;
        }



    }

    public num TipoTarjeta
    {
        if([CreditoWeb]4){
            returnCreditoWeb.TipodeTarjeta.VISA;
        }
        if([CreditoWeb]==3){
            returnCreditoWebTipodeTarjeta.MASTERCARD;
        }   
        if([CreditoWeb]==2){
            returnCreditoWebTipodeTarjeta.AMERICANEXPRESS;
        }
        if([CreditoWeb]==1){  
        returnCreditoWebTipodeTarjeta.DiscoverCard;
           }
        if([0]==0){
            returnCreditoWebTipodeTarjeta.NOVALIDA;
        }
    }
}