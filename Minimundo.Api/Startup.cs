using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Minimundo.Domain.Entities;
using Minimundo.Domain.Entities.Authentication;
using Minimundo.Domain.Interfaces;
using Minimundo.Domain.Interfaces.Repositories;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;
using Minimundo.Service.Service;
using Minimundo.Service.Validators;
using System;

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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                 .AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssemblyContaining<Startup>());

            var signingConfigurations = new SigningConfigurations();
            services.AddSingleton(signingConfigurations);

            var tokenConfigurations = new TokenConfigurations();
            new ConfigureFromConfigurationOptions<TokenConfigurations>(
                Configuration.GetSection("TokenConfigurations"))
                    .Configure(tokenConfigurations);
            services.AddSingleton(tokenConfigurations);

            services.AddAuthentication(authOptions =>
            {
                authOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                authOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(bearerOptions =>
            {
                var paramsValidation = bearerOptions.TokenValidationParameters;
                paramsValidation.IssuerSigningKey = signingConfigurations.Key;
                paramsValidation.ValidAudience = tokenConfigurations.Audience;
                paramsValidation.ValidIssuer = tokenConfigurations.Issuer;

                // Valida a assinatura de um token recebido
                paramsValidation.ValidateIssuerSigningKey = true;

                // Verifica se um token recebido ainda é válido
                paramsValidation.ValidateLifetime = true;

                // Tempo de tolerância para a expiração de um token (utilizado
                // caso haja problemas de sincronismo de horário entre diferentes
                // computadores envolvidos no processo de comunicação)
                paramsValidation.ClockSkew = TimeSpan.Zero;
            });

            // Ativa o uso do token como forma de autorizar o acesso
            // a recursos deste projeto
            services.AddAuthorization(auth =>
            {
                auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
                    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser().Build());
            });
            //services.AddControllers();

            #region Validators

            services.AddSingleton<IValidator<Avaliador>, AvaliadorValidator>();
            services.AddSingleton<IValidator<Campanha>, CampanhaValidator>();
            services.AddSingleton<IValidator<CustoSugestao>, CustoSugestaoValidator>();
            services.AddSingleton<IValidator<Empresa>, EmpresaValidator>();
            services.AddSingleton<IValidator<Endereco>, EnderecoValidator>();
            services.AddSingleton<IValidator<Funcionario>, FuncionarioValidator>();
            services.AddSingleton<IValidator<SugestaoAvaliacao>, SugestaoAvaliacaoValidator>();
            services.AddSingleton<IValidator<Sugestao>, SugestaoValidator>();
            services.AddSingleton<IValidator<Telefone>, TelefoneValidator>();
            services.AddSingleton<IValidator<Usuario>, UsuarioValidator>();

            #endregion Validators

            #region Services

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

            #endregion Services

            #region Repositories

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

            #endregion Repositories
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
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}