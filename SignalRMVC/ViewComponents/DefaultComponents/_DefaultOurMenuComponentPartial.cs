using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.ProductDtos;
using SignalRWebUI.Dtos.SliderDtos;

namespace SignalRWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultOurMenuComponentPartial:ViewComponent
    { 
            private readonly IHttpClientFactory _httpClientFactory;

            public _DefaultOurMenuComponentPartial(IHttpClientFactory httpClientFactory)
            {
                _httpClientFactory = httpClientFactory;
            }//amacım clienta ulaşmak

            public async Task<IViewComponentResult> InvokeAsync()
            { //consume işlemi burda oluyor
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync("https://localhost:7187/api/Product");

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData); //jsondan gelen datayı atıcam
                return View(values);
            }
        
    }
}
