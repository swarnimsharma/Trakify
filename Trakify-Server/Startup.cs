using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Serilog;
using Trakify.Domain;
using Trakify.Facade.JobFacade;
using Trakify.Repository.EmployeeRepo;
using Trakify.Repository.AssetRepo;
using Trakify.Repository.CodeRepo;
using Trakify.Repository.Common;
using Trakify.Repository.ContractRepo;
using Trakify.Repository.DocumentRepo;
using Trakify.Repository.JobRepo;
using Trakify.Repository.PartRepo;
using Trakify.Repository.PaymentTermsRepo;
using Trakify.Repository.TaxCodeRepo;
using Trakify.Repository.WorkOrderTypeRepo;
using Trakify.Service.AssetService;
using Trakify.Service.CodeService;
using Trakify.Service.ContractService;
using Trakify.Service.DocumentService;
using Trakify.Service.EmployeeService;
using Trakify.Service.JobService;
using Trakify.Service.PartService;
using Trakify.Service.PaymentTermsService;
using Trakify.Service.TexCodeService;
using Trakify.Service.WorkOrderTypeService;
using Trakify.Facade.AssetsFacade;
using System.IO;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Http;
using Trakify.Facade.ContractsFacade;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using System;
using Trakify.Facade.PartFacade;
using Trakify.Repository.DropDownRepo;
using Trakify.Service.DropDownService;
using Trakify.Facade.DropDownFacade;

namespace Trakify_Server
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
            services.AddDbContext<TrakifyContext>();
            //services.AddControllers();
            services.AddSingleton((ILogger)new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.File(Path.GetFullPath("Logs\\Trakify_Log.txt"))
            .CreateLogger());
            //services.AddSession();
            services.AddScoped<IAssetsFacade, AssetsFacade>();
            services.AddScoped<IJobFacade, JobFacade>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IAssetRepository, AssetRepository>();
            services.AddScoped<ICodeRepository, CodeRepository>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IContractRepository, ContractRepository>();
            services.AddScoped<IDocumentRepository, DocumentRepository>();
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IPartRepository, PartRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<ITaxCodeRepository, TaxCodeRepository>();
            services.AddScoped<IWorkOrderTypeRepository, WorkOrderTypeRepository>();
            services.AddScoped<IAssetService, AssetService>();
            services.AddScoped<ICodeService, CodeService>();
            services.AddScoped<IAssetService, AssetService>();
            services.AddScoped<IContractService, ContractService>();
            services.AddScoped<IDocumentService, DocumentService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IPartService, PartService>();
            services.AddScoped<IPaymentTermsService, PaymentTermsService>();
            services.AddScoped<ITaxCodeService, TaxCodeService>();
            services.AddScoped<IWorkOrderTypeService, WorkOrderTypeService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IContractRepository, ContractRepository>();
            services.AddScoped<IContractService, ContractService>();
            services.AddScoped<IContractFacade, ContractFacade>();
            services.AddScoped<IPartRepository, PartRepository>();
            services.AddScoped<IPartService, PartService>();
            services.AddScoped<IpartFacade, PartFacade>();

            services.AddScoped<IDropDownRepository, DropDownRepository>();
            services.AddScoped<IDropDownService, DropDownService>();
            services.AddScoped<IDropDownFacade, DropDownFacade>();
            //services.AddScoped<IJobService, JobService>();
            services.AddDistributedMemoryCache();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
            // Add framework services.
            services.AddMvc(options => options.EnableEndpointRouting = false);
            //services.AddRazorPages();
            MvcOptions options = new MvcOptions();
            options.EnableEndpointRouting = false;
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //MvcOptions options = new MvcOptions();
            //options.EnableEndpointRouting = false;
            //app.UseSession();
            //app.UseMvc();
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All,
                RequireHeaderSymmetry = false,
                ForwardLimit = null,
                KnownNetworks = { new IPNetwork(IPAddress.Parse("::ffff:172.17.0.1"), 104) }
            });
            app.UseSerilogRequestLogging();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor |
            ForwardedHeaders.XForwardedProto
            });
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //app.UseRouting();

            app.UseAuthorization();

            app.UseSession();
            
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                   name: "default",
                   template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}