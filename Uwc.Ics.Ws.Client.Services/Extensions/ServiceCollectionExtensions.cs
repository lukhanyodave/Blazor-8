
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Uwc.Ics.Ws.Client.Application.Abstractions;
using Uwc.Ics.Ws.Client.Application.Features.DepartmentFeatures;
using Uwc.Ics.Ws.Client.Application.Features.RoleFeatures;
using Uwc.Ics.Ws.Client.Application.Features.VacancyFeatures;
using Uwc.Ics.Ws.Client.Application.Options;

namespace Uwc.Ics.Ws.Client.Application.Extensions
{
    /// <summary>
    /// A helper class for managing the registration of Work Study client services in the WebClient.
    /// </summary>
    public static class ServiceCollectionExtensions
    {

        /// <summary>
        /// Registers all of the client services needed to call the Work Studry REST API resources.
        /// </summary>
        /// <param name="services">The service collection.</param>
        public static void AddWorkStudyServices(this IServiceCollection services)
        {
            //// Register Master Data API config
            //services
            //    .AddOptions<MasterDataApi>()
            //    .Configure<IConfiguration>((options, config) => 
            //    {
            //        config.GetSection(nameof(MasterDataApi)).Bind(options);
            //    });

            //services
            //    .AddOptions<WorkStudyApi>()
            //    .Configure<IConfiguration>((options, config) =>
            //    {
            //        config.GetSection(nameof(WorkStudyApi)).Bind(options);
            //    });

            // Register each service with it's HttpClient and add any additional configuration needed here.
            //services.AddHttpClient<IMasterDataService, MasterDataService>();
            //services.AddHttpClient<IDepartmentService, DepartmentService>();
            //services.AddHttpClient<IUserService, UserService>();
            //services.AddHttpClient<IRoleService, RoleService>();
            //services.AddHttpClient<IPostService, RolesService>();
            //services.AddHttpClient<IPostCategoryService,PostCategoryService>();
            //services.AddHttpClient<IPostTypeService,PostTypeService>();
            //services.AddHttpClient<IVacancyService,VacancyService>();
        }

    }
}
