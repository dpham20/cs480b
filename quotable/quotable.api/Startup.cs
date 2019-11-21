using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using quotable.core;

namespace quotable.api
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// 
        /// </summary>
        public IConfiguration Configuration { get; }
        /// <summary>
        /// Allows access to a SimpleRandomQuoteProvider singleton.
        /// </summary>
        /// <param name="services"></param>
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<RandomQuoteProvider, SimpleRandomQuoteProvider>();
            //set up to use a sqlite db
            services.AddDbContext<QuoteContext>(options => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
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

            //Making sure db exist if not create a new one.
            using(var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<QuoteContext>();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                PopulateDatabase(context);
            }
        }

        /// <summary>
        /// Creating database table
        /// </summary>
        /// <param name="context"></param>

        private static void PopulateDatabase(QuoteContext context)
        {
            var author1 = new Author()
            {
                name = "Danny Pham"
            };
            var author2 = new Author()
            {
                name = "Turtle Kid"
            };
            var author3 = new Author()
            {
                name = "Robert Frost"
            };
            var author4 = new Author()
            {
                name = "Marylin Monroe"
            };

            var quote1 = new Quote() { quote = "I'm selfish, impatient and a little insecure. I make mistakes, I am out of control and at times hard to handle. But if you can't handle me at my worst, then you sure as hell don't deserve me at my best."};
            var quote2 = new Quote() { quote = "What Am I doing?" };
            var quote3 = new Quote() { quote = "I like Turtles."};
            var quote4 = new Quote() { quote = "In three words I can sum up everything I've learned about life: it goes on." };

            var qa1 = new QuoteAuthor() { Quote = quote1, Author = author4 };
            var qa2 = new QuoteAuthor() { Quote = quote2, Author = author1 };
            var qa3 = new QuoteAuthor() { Quote = quote3, Author = author2 };
            var qa4 = new QuoteAuthor() { Quote = quote4, Author = author3 };

            context.AddRange(qa1, qa2, qa3, qa4);

            context.SaveChanges();
        }
    }
}
