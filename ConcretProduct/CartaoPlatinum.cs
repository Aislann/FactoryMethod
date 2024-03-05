using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.ConcretProduct
{
    public class CartaoPlatinum : CartaoCredito
    {
        private readonly string _tipoCartao;
        private int _limiteCartao;
        private int _anuidade;

        public CartaoPlatinum(int limitecartao, int anuidade)
        {
            this._tipoCartao = "Platinum";
            this._limiteCartao = limitecartao;
            this._anuidade = anuidade;
        }

        public override string TipoCartao
        {
            get { return _tipoCartao; }
        }

        public override int LimiteCartao
        {
            get { return _limiteCartao; }
            set { _limiteCartao = value; }
        }

        public override int Anuidade
        {
            get { return _anuidade; }
            set { _anuidade = value; }
        }
    }

    
    
}
