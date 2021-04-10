using System;

namespace FDevs_Console_ClassLibrary.InterfacesVsImplementacao
{
    public interface IRepositorio
    {
        void Adicionar();
    }

    public class Repositorio : IRepositorio
    {
        public void Adicionar()
        {
            throw new NotImplementedException();
        }
    }

    public class Repositorio2 : IRepositorio
    {
        public void Adicionar()
        {
            throw new NotImplementedException();
        }
    }

    public class UsoImplementacao
    {
        public void Executar()
        {
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }

    public class UsoAbstracao
    {
        private readonly IRepositorio _repository;

        public UsoAbstracao(IRepositorio repositorio)
        {
            _repository = repositorio;
        }

        public void Executar()
        {
            _repository.Adicionar();
        }
    }

    public class TesteImplementacao
    {
        public TesteImplementacao()
        {
            var repositorioImplementacao = new UsoImplementacao();
            repositorioImplementacao.Executar();

            var repositorioAbstracao = new UsoAbstracao(new Repositorio());
            repositorioAbstracao.Executar();

            var repositorioAbstracao2 = new UsoAbstracao(new Repositorio2());
            repositorioAbstracao2.Executar();
        }
    }
}
