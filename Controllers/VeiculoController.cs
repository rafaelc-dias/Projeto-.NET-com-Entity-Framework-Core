using APIControleFrotas.Models.Application.Services;
using ControleFrotas.Models.Domain.Entites;
using ControleFrotas.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIControleFrotas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoServico veiculoServico;

        public VeiculoController(IVeiculoServico veiculoServico)
        {
            this.veiculoServico = veiculoServico;
        }

        [HttpGet]
        [Route("listar")]
        public async Task<List<Veiculo>> Listar()
        {
            try
            {
                return await veiculoServico.Listar();   
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("listar2")]
        public async Task<List<Veiculo>> Listar2()
        {
            try
            {
                return await veiculoServico.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("pesquisar/{id}")]
        public async Task<Veiculo> Pesquisar(string id)
        {
            try
            {
                return await veiculoServico.Pesquisar(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<string> Cadastrar([FromBody] VeiculoDTO veiculo)
        {
            try
            {
                var entidade = veiculo.ConverteParaEntidade();
                await veiculoServico.Cadastrar(entidade);
                return "Cadastro efetuado com sucesso";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Route("atualizar")]
        public async Task<string> Atualizar([FromBody] VeiculoDTO veiculo)
        {
            try
            {
                var entidade = veiculo.ConverteParaEntidade();
                await veiculoServico.Atualizar(entidade);
                return "Cadastro efetuado com sucesso";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        [Route("excluir/{id}")]
        public async Task<string> Excluir(string id)
        {
            try
            {
                await veiculoServico.Excluir(id);
                return "exclusão efetuada com sucesso";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
