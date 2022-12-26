using System.Collections.Generic;
using System.Globalization;

namespace ConversaoMoedas
{
    public class ConversaoMoeda
    {
        public EMoeda MoedaTipo { get; private set; }
        private Dictionary<EMoeda, decimal> ValoresMoedas 
        { 
            get {
                var dicionarioValoresMoedas = new Dictionary<EMoeda, decimal>();
                dicionarioValoresMoedas.Add(EMoeda.Real, 1);
                dicionarioValoresMoedas.Add(EMoeda.Dolar, 0.181m);
                dicionarioValoresMoedas.Add(EMoeda.Euro, 0.1538m);
                dicionarioValoresMoedas.Add(EMoeda.Iene, 52.1m);
                dicionarioValoresMoedas.Add(EMoeda.Libra, 0.14m);

                return dicionarioValoresMoedas;
            }
        }
        private Dictionary<EMoeda, CultureInfo> CultureMoedas 
        { 
            get {
                var dicionarioCultureMoedas = new Dictionary<EMoeda, CultureInfo>();
                
                dicionarioCultureMoedas.Add(EMoeda.Real, CultureInfo.CreateSpecificCulture("pt-BR"));
                dicionarioCultureMoedas.Add(EMoeda.Dolar, CultureInfo.CreateSpecificCulture("en-US"));
                dicionarioCultureMoedas.Add(EMoeda.Euro, CultureInfo.CreateSpecificCulture("fr-FR"));
                dicionarioCultureMoedas.Add(EMoeda.Libra, CultureInfo.CreateSpecificCulture("en-GB"));

                return dicionarioCultureMoedas;
            }
        }
        
        public ConversaoMoeda(EMoeda Moeda)
        {
            MoedaTipo = Moeda;
        }
        public decimal Converter(EMoeda moedaConversao, decimal valorReal)
        {
            decimal valorMoedaConversao = BuscarValorMoeda(moedaConversao);
            return valorReal * valorMoedaConversao;
        }

        public CultureInfo BuscarCultureMoeda(EMoeda Moeda) => CultureMoedas.GetValueOrDefault(Moeda);

        private decimal BuscarValorMoeda(EMoeda Moeda) => ValoresMoedas.GetValueOrDefault(Moeda);
    }
}