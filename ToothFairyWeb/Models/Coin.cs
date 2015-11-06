namespace ToothFairyWeb.Models
{
    /// <summary>
    /// Moedas disponíveis no sistema
    /// </summary>
    public class Coin
    {
        /// <summary>
        /// Identificador da moeda
        /// </summary>
        public virtual int CoinID { get; set; }
        /// <summary>
        /// Nome comum da moeda
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// Símbolo oficial da moeda
        /// </summary>
        public virtual string Symbol { get; set; }
        /// <summary>
        /// Identificador do país de origem da moeda
        /// </summary>
        public virtual int CountryID { get; set; }
        /// <summary>
        /// País de origem da moeda
        /// </summary>
        public virtual Country Country { get; set; }
    }
}
