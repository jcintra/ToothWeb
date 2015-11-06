using System;
using System.Collections.Generic;

namespace ToothFairyWeb.Models
{
    /// <summary>
    /// Dentes do utilizador
    /// </summary>
    public class Tooth
    {
        /// <summary>
        /// Identificador do dente
        /// </summary>
        public int ToothID { get; set; }
        /// <summary>
        /// Posição do dente na boca (Esquerda para Direita, de cima para baixo)
        /// </summary>
        public int Position { get; set; }
        /// <summary>
        /// Data em que o dente caiu
        /// </summary>
        public DateTime FallenDate { get; set; }
        /// <summary>
        /// Quantia que a fada madrinha deu ao dente
        /// </summary>
        public float Price { get; set; }
        /// <summary>
        /// Identificador da moeda usada na quantia dada pela fada madrinha
        /// </summary>
        public int CoinID { get; set; }
        /// <summary>
        /// Moeda usada na quantia dada pela fada madrinha
        /// </summary>
        public Coin Coin { get; set; }
        /// <summary>
        /// Lista de fotografias do dente caído
        /// </summary>
        public List<Photo> Photos { get; set; }
    }
}
