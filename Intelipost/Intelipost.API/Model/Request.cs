namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade responsável por qualquer requisição feita.
    /// </summary>
    public class Request<T> where T : class
    {
        /// <summary>
        /// Propriedade genérica para o conteúdo da requisição.
        /// </summary>
        public T Content { get; set; }
    }
}