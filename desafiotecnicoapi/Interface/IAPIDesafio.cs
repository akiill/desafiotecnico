using ApiDesafio.Models;

namespace ApiDesafio.Interface
{
    public interface IAPIDesafio
    {
        DecomporResponse DecomporApi(DecomporRequest request);
    }
}
