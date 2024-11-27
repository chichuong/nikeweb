using Microsoft.AspNetCore.Mvc;

namespace testfull.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Xml.Linq;

    public class SiteMapController : Controller
    {
        public IActionResult Index()
        {
            var sitemapXml = @"
            <urlset xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xsd='http://www.w3.org/2001/XMLSchema'>
                <url>
                    <loc>https://localhost:7081/Product/Index</loc>
                    <lastmod>2024-10-23</lastmod>
                    <changefreq>monthly</changefreq>
                    <priority>1</priority>
                </url>
                <url>
                    <loc>https://localhost:7081/Shop/Index</loc>
                    <lastmod>2024-10-23</lastmod>
                    <changefreq>monthly</changefreq>
                    <priority>1</priority>
                </url>
            </urlset>";

            return Content(sitemapXml, "application/xml");
        }
    }
}
