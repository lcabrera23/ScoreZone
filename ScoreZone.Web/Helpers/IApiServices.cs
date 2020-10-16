using Microsoft.AspNetCore.Mvc;
using ScoreZone.Web.Data.NoticiasEntities;
using System.Threading.Tasks;

namespace ScoreZone.Web.Helpers
{
    public interface IApiServices
    {
        Task<Root> getFirtsNews(string url);
        Task<Root2> getSecondNews(string url);
    }
}