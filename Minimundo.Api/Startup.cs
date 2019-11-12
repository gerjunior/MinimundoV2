using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Minimundo.Domain.Interfaces;
using Minimundo.Domain.Interfaces.Repositories;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;
using Minimundo.Service.Service;

namespace Minimundo.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                 .AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssemblyContaining<Startup>());

            services.AddTransient(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddTransient<IAvaliadorService, AvaliadorService>();
            services.AddTransient<ICampanhaService, CampanhaService>();
            services.AddTransient<ICustoSugestaoService, CustoSugestaoService>();
            services.AddTransient<IEmpresaService, EmpresaService>();
            services.AddTransient<IEnderecoService, EnderecoService>();
            services.AddTransient<IFuncionarioService, FuncionarioService>();
            services.AddTransient<ISugestaoAvaliacaoService, SugestaoAvaliacaoService>();
            services.AddTransient<ISugestaoService, SugestaoService>();
            services.AddTransient<ITelefoneService, TelefoneService>();
            services.AddTransient<IUsuarioService, UsuarioService>();

            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IAvaliadorRepository, AvaliadorRepository>();
            services.AddTransient<ICampanhaRepository, CampanhaRepository>();
            services.AddTransient<ICustoSugestaoRepository, CustoSugestaoRepository>();
            services.AddTransient<IEmpresaRepository, EmpresaRepository>();
            services.AddTransient<IEnderecoRepository, EnderecoRepository>();
            services.AddTransient<IFuncionarioRepository, FuncionarioRepository>();
            services.AddTransient<ISugestaoAvaliacaoRepository, SugestaoAvaliacaoRepository>();
            services.AddTransient<ISugestaoRepository, SugestaoRepository>();
            services.AddTransient<ITelefoneRepository, TelefoneRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}