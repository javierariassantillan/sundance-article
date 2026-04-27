using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetArticle()
        {
            var article = new
            {
                breadcrumb = "Learning Hub / Buying Guides",
                title = "Understanding Hot Tub Costs: A Guide to Different Spa Options",
                author = "Bobbi Smith",
                introTitle = "Title Lorem",
                intro = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                summary = "Investing in a hot tub is a significant decision that involves various factors, including the initial purchase price, installation costs, and ongoing maintenance expenses. In this guide, we'll break down the different components of hot tub costs to help you make an informed decision.",

                sections = new[]
                {
                    new {
                        title = "Initial Purchase Price",
                        items = new[]
                        {
                            "Hot Tub Models: The cost of a hot tub can vary widely depending on the brand, model, size, features, and materials. Entry-level models typically start at around $3,500 to $7,000, mid-range spas range from $7,000 to $12,000, while premium models can cost $12,000 or more.",
                            "Features and Options: Additional features such as advanced hydrotherapy jets, LED lighting, sound systems, and smart technology can increase the price of the hot tub. Consider your budget and prioritize features that align with your preferences and lifestyle."
                        }
                    },
                    new {
                        title = "Installation Costs",
                        items = new[]
                        {
                            "Site Preparation: Before installing a hot tub, you may need to prepare the site, which can involve leveling the ground, pouring a concrete pad, or constructing a deck or patio.",
                            "Electrical Wiring: Hot tubs require a dedicated electrical circuit to power the spa's pump, heater, and control panel. Electrical installation costs can range from $500 to $1,500 or more.",
                            "Delivery and Setup: Delivery and setup typically involve transporting the spa, positioning it, and filling it with water."
                        }
                    },
                    new {
                        title = "Ongoing Maintenance Expenses",
                        items = new[]
                        {
                            "Water Care Products: Maintaining clean and balanced water requires regular use of sanitizers, pH balancers, and clarifiers.",
                            "Energy Costs: Heating and operating a hot tub require electricity. Energy-efficient models can help reduce operating costs over time."
                        }
                    }
                },

                quote = "This is a blockquote lorem ipsum dolor sit amet consectetur adipiscing nulla magna elit. Aliqua nam magna donec labore.",

                conclusionTitle = "In Summary",
                conclusion = "Understanding the costs associated with purchasing and owning a hot tub is essential for making a well-informed decision. By considering factors such as the initial purchase price, installation costs, and ongoing maintenance expenses, you can determine the total cost of ownership and budget accordingly.",

                spas = new[]
                {
                    new { series = "980™ Series", name = "Kingston™", seats = "6+ Seats", features = new[] { "Lounge Seat", "SunCooler", "SmartTub System", "Fluidix Jets", "Energy Efficient" }, price = "$$$$$" },
                    new { series = "880™ Series", name = "Aspen®", seats = "6+ Seats", features = new[] { "Lounge Seat", "SmartTub System", "Fluidix Jets", "Energy Efficient" }, price = "$$$$$" },
                    new { series = "880™ Series", name = "Vistamar™", seats = "6+ Seats", features = new[] { "Lounge Seat", "SmartTub System", "Fluidix Jets" }, price = "$$$$$" }
                },

                relatedArticles = new[]
                {
                    "The Lifespan of a Hot Tub and the Importance of a Warranty",
                    "Enhance Your Spa Experience: Using Your Senses for Water Care",
                    "Overcoming Hard Water Issues in Your Hot Tub: 3 Steps to Combat Scaling"
                }
            };

            return Ok(article);
        }
    }
}